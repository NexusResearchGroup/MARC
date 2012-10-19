using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Data;

using System.Data.Sql;

namespace LabCommServer
{
    public partial class LabServer : Form
    {        
        static private bool m_bListening = false;
        static private System.Net.IPAddress MyIP;
        
        SocketClient[] SClient;//=null;
       
        
        static private int CLIENT_NUM = 30;

        //private string GlobalData.strDatabaseIP = "";
        private string strDatabaseName = "Game_2";
        private string strDatabaseUser = "";
        private string strDatabasePwd = "";

        public LabServer()
        {
            InitializeComponent();
            SClient = new SocketClient[CLIENT_NUM];
        }

        private void LabServer_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.View = View.Details;

            string str = System.Environment.CurrentDirectory;
            picStatus.Load(str + "/Image/red.bmp");
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (textBox_playerNo.Text != "")
            {
                GlobalData.PLAYER_NUM = Convert.ToInt32(textBox_playerNo.Text);
            }

            if (textBox_round_trial.Text != "")
            {
                GlobalData.ROUND_NUM_trial = Convert.ToInt32(textBox_round_trial.Text);
            }
            if (textBox_round_1.Text != "")
            {
                GlobalData.ROUND_NUM_1 = Convert.ToInt32(textBox_round_1.Text);
            }
            if (textBox_round.Text != "")
            {
                GlobalData.ROUND_NUM = Convert.ToInt32(textBox_round.Text);
            }

            if (comboBox_IP.Text != "")
            {
                GlobalData.IP = comboBox_IP.Text;
            }

            if (comboBox_DB.Text != "")
            {
                GlobalData.strDatabaseIP = comboBox_DB.Text;
            }

            
            m_bListening = true;

            string str = System.Environment.CurrentDirectory;
            string strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);

            IPEndPoint iep = new IPEndPoint(ipEntry.AddressList[0], 5567);//ServerIp
            MyIP = System.Net.IPAddress.Parse(ipEntry.AddressList[0].ToString());

            picStatus.Load(str + "/Image/green.bmp");
            label4.Text = "Server Listening";
            comboBox_IP.Text = ipEntry.AddressList[0].ToString();
            cmdStart.Text = "Stop";

            try
            {
                IPAddress ipAd = IPAddress.Parse(GlobalData.IP);
                // use local m/c IP address, and 
                // use the same in the client

                /* Initializes the Listener */
                TcpListener MySocketListener = new TcpListener(ipAd, 5567);

                /* Start Listeneting at the specified port */
                MySocketListener.Start();


                //MySocketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //MySocketListener.Bind(iep);

                Console.WriteLine("The server is running at port 5567...");
                Console.WriteLine("The local End point is  :" +
                                  MySocketListener.LocalEndpoint);


                while(true)
                {
                    
                    int flag = 0;
                    while (true)
                    {
                        Console.WriteLine("Waiting for a connection.....");
                        Socket newSocket = MySocketListener.AcceptSocket(); 

                        int iNum3 = 0;                        
                        for (int i = 0; i < SClient.Length; i++)
                        {
                            if (SClient[i] == null)
                            {
                                iNum3 = i;
                                break;
                            }
                        }
                        SClient[iNum3] = new SocketClient(newSocket);
                        Thread.Sleep(100);
                        txtInfor.Text = DateTime.Now.ToString() + ":  " + newSocket.RemoteEndPoint.ToString() + ": Connected\r\n" + txtInfor.Text;
                        Thread clientservice = new Thread(new ThreadStart(SClient[iNum3].ReceiveData));
                        clientservice.Start();

                        txtInfor.Refresh();


                        while (SClient[iNum3].strA == null)
                        {
                            Thread.Sleep(100);
                        }
                        string[] strA = SClient[iNum3].strA;
                        

                        if (SClient[iNum3].strA.Length > 1)
                        {
                            string strID, strName;
                            int iGame, iScenario, iRound, iRoute,iscore;
                            strID = strA[1];

                           
                                //strName = strA[2];                            
                                iRound = Convert.ToInt16(strA[2]);
                                iRoute = Convert.ToInt16(strA[3]);
                                iGame = Convert.ToInt16(strA[4]);
                                iscore = Convert.ToInt16(strA[5]);
                                iScenario = Convert.ToInt16(strA[6]);

                                GlobalData.Current_Game = iGame;
                                GlobalData.Current_Round = iRound;
                                GlobalData.Current_Scenario = iScenario;


                            //if (strA[0] == "Player")
                            //{

                            //    store2PlayerDB(strA);

                            //    //ListViewItem Item = new ListViewItem();
                            //    //Item.Text = (listView1.Items.Count).ToString();
                            //    //Item.SubItems.Add(strID);
                            //    //listView1.Items.Add(Item);
                            //}
                            if (strA[0] == "Game")
                            {
                                store2GameDB(strA);
                                flag = flag + 1;
                            }
                            else //trA[0]=="Score"
                            {
                                //storeData2ScoreDB(strA);
                            }
                        }
                        else
                        {
                            QueryGameDB();
                        }


                        if (flag == GlobalData.PLAYER_NUM)
                        {
                            ASCIIEncoding asen = new ASCIIEncoding();

                            for (int m = 0; m < SClient.Length - 1; m++)
                            {
                                if (SClient[m] != null)
                                {
                                    SClient[m].Sock.Send(asen.GetBytes(GlobalData.strSend));//"The string was recieved by the server from port 5567."));
                                    Console.WriteLine("\nSent Acknowledgement");
                                    SClient[m] = null;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                        }

                        /* clean up */
                        //newSocket.Close();
                    }
                    //ASCIIEncoding asen = new ASCIIEncoding();
                    //Socket s = MySocketListener.AcceptSocket();
                    //s.Send(asen.GetBytes(GlobalData.strSend));//"The string was recieved by the server from port 5567."));
                    //Console.WriteLine("\nSent Acknowledgement");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error..... " + err.Message);//.StackTrace);
            }

                //myList.Stop();

        }

        //Store data into Database
        private void store2PlayerDB(string[] strA)
        {
            //DB myDatabase = new DB();
            String sql = "";
            DateTime dt = DateTime.Now;
            DB myDatabase = new DB("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            //("Data Source=UNIVERSI-9CB70F\\SQLEXPRESS" + ";Initial Catalog=" + "Game" + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            string TableName;
            TableName = "Player" + strA[1].ToString();
            //CreateGameTable(TableName);
            //if (GlobalData.Current_Round == 0)
            //{
            //    sql = "Truncate" + TableName;
            //    myDatabase.ExeSql(sql);
            //}

            sql = "INSERT INTO [" + TableName + "]([Player])VALUES('";
            sql = sql + strA[1]+ "')";
            myDatabase.ExeSql(sql);
        }


        private void store2GameDB(string[] strA)
        {
            //DB myDatabase = new DB();
            String sql = "";
            DateTime dt = DateTime.Now;
            DB myDatabase = new DB("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
                //("Data Source=UNIVERSI-9CB70F\\SQLEXPRESS" + ";Initial Catalog=" + "Game" + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            string TableName;
            TableName = "Game"+strA[4].ToString()+strA[6].ToString();
            //CreateGameTable(TableName);
            //if (GlobalData.Current_Round == 0)
            //{
            //    sql = "Truncate" + TableName;
            //    myDatabase.ExeSql(sql);
            //}

            sql = "INSERT INTO [" + TableName + "]([ID], [Round#],[Route#],[Scenario#],[Score])VALUES('";
            sql = sql + strA[1] + "','" + strA[2] + "','" + strA[3] + "','" + strA[6] + "','" + strA[5] + "')";
            myDatabase.ExeSql(sql);


            //search DB to get player #
            QueryGameDB();
        }

        private void QueryGameDB()
        {
            //int round = GlobalData.Current_Round;

            DB mydabase = new DB("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
        

            if (GlobalData.Current_Scenario == 1)
            {

                DataSet ds1 = mydabase.ReadDataSet("Select * from Game" + GlobalData.Current_Game.ToString() + GlobalData.Current_Scenario.ToString() + " where Scenario#=" + GlobalData.Current_Scenario.ToString() + " and Round#=" + GlobalData.Current_Round.ToString() + " and  Route# = '1'");
                GlobalData.numPlayer[0] = ds1.Tables[0].Rows.Count;

                DataSet ds2 = mydabase.ReadDataSet("Select * from Game" + GlobalData.Current_Game.ToString() + GlobalData.Current_Scenario.ToString() + " where Scenario#=" + GlobalData.Current_Scenario.ToString() + " and Round#=" + GlobalData.Current_Round.ToString() + " and  Route# = '2'");
                GlobalData.numPlayer[1] = ds2.Tables[0].Rows.Count;

                if (GlobalData.Current_Game == 1)
                {
                    getTT12(GlobalData.numPlayer);
                }
                else if (GlobalData.Current_Game == 2)
                {
                    getTT22(GlobalData.numPlayer);
                }

                //find shortest path
                if (GlobalData.TT[0] <= GlobalData.TT[1])
                {
                    GlobalData.Path_shortest = GlobalData.TT[0].ToString();
                    GlobalData.IsEquilibrium = false;
                }
                else if (GlobalData.TT[0] >= GlobalData.TT[1])
                {
                    GlobalData.Path_shortest = GlobalData.TT[1].ToString();
                    GlobalData.IsEquilibrium = false;
                }
                else if (GlobalData.TT[0] == GlobalData.TT[1])
                {
                    GlobalData.Path_shortest = GlobalData.TT[0].ToString();
                    GlobalData.IsEquilibrium = true;
                }

                GlobalData.strSend = "Results" + "$" + GlobalData.numPlayer[0].ToString() + "$" + GlobalData.numPlayer[1].ToString() + "$" + GlobalData.TT[0].ToString() + "$" + GlobalData.TT[1].ToString() + "$" + GlobalData.Path_shortest + "$" + GlobalData.IsEquilibrium.ToString() + "$" + GlobalData.ROUND_NUM_1.ToString() + "$" + GlobalData.IP.ToString() + "$" + GlobalData.ROUND_NUM_trial.ToString();
                storeResultDB2(GlobalData.strSend);
            
            }
            else if (GlobalData.Current_Scenario == 2)
            {

                DataSet ds1 = mydabase.ReadDataSet("Select * from Game" + GlobalData.Current_Game.ToString() + GlobalData.Current_Scenario.ToString() + " where Scenario#=" + GlobalData.Current_Scenario.ToString() + " and Round#=" + GlobalData.Current_Round.ToString() + " and  Route# = '1'");
                GlobalData.numPlayer[0] = ds1.Tables[0].Rows.Count;

                DataSet ds2 = mydabase.ReadDataSet("Select * from Game" + GlobalData.Current_Game.ToString() + GlobalData.Current_Scenario.ToString() + " where Scenario#=" + GlobalData.Current_Scenario.ToString() + " and Round#=" + GlobalData.Current_Round.ToString() + " and  Route# = '2'");
                GlobalData.numPlayer[1] = ds2.Tables[0].Rows.Count;// CLIENT_NUM - ds.Tables[0].Rows.Count;


                DataSet ds3 = mydabase.ReadDataSet("Select * from Game" + GlobalData.Current_Game.ToString() + GlobalData.Current_Scenario.ToString() + " where Scenario#=" + GlobalData.Current_Scenario.ToString() + " and Round#=" + GlobalData.Current_Round.ToString() + " and  Route# = '3'");
                GlobalData.numPlayer[2] = ds3.Tables[0].Rows.Count;// CLIENT_NUM - ds.Tables[0].Rows.Count;

                if (GlobalData.Current_Game == 1)
                {
                    getTT13(GlobalData.numPlayer);
                }
                else if (GlobalData.Current_Game == 2)
                {
                    getTT23(GlobalData.numPlayer);
                }

                //Array.Sort(GlobalData.numPlayer);
                //find shortest path
                if (GlobalData.TT[0] <= GlobalData.TT[1] && GlobalData.TT[0] <= GlobalData.TT[2])
                {
                    GlobalData.Path_shortest = GlobalData.TT[0].ToString();
                    GlobalData.IsEquilibrium = false;
                }
                else if (GlobalData.TT[1] <= GlobalData.TT[0] && GlobalData.TT[1] <= GlobalData.TT[2])
                {
                    GlobalData.Path_shortest = GlobalData.TT[1].ToString();
                    GlobalData.IsEquilibrium = false;
                }
                else if (GlobalData.TT[2] <= GlobalData.TT[0] && GlobalData.TT[2] <= GlobalData.TT[1])
                {
                    GlobalData.Path_shortest = GlobalData.TT[2].ToString();
                    GlobalData.IsEquilibrium = false;
                }
                else if (GlobalData.TT[0] == GlobalData.TT[1] && GlobalData.TT[1] == GlobalData.TT[2])
                {
                    GlobalData.Path_shortest = GlobalData.TT[0].ToString();
                    GlobalData.IsEquilibrium = true;
                }

                GlobalData.strSend = "Results" + "$" + GlobalData.numPlayer[0].ToString() + "$" + GlobalData.numPlayer[1].ToString() + "$" + GlobalData.numPlayer[2].ToString() + "$" + GlobalData.TT[0].ToString() + "$" + GlobalData.TT[1].ToString() + "$" + GlobalData.TT[2].ToString() + "$" + GlobalData.Path_shortest + "$" + GlobalData.IsEquilibrium.ToString() + "$" + GlobalData.ROUND_NUM.ToString() + "$" + GlobalData.IP.ToString();
                storeResultDB3(GlobalData.strSend);
            }
            
      
        }

        //Store data into Database
        private void storeResultDB2(string strSend)
        {

            string[] strA;
            strA = strSend.Split('$');

            String sql = "";
            DateTime dt = DateTime.Now;
            DB myDatabase = new DB("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            //("Data Source=UNIVERSI-9CB70F\\SQLEXPRESS" + ";Initial Catalog=" + "Game" + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            string TableName;
            TableName = "Result22";



            sql = "INSERT INTO [" + TableName + "]([Player#1], [Player#2],[TT1],[TT2],[SP],[Round#],[Scenario#])VALUES('";
            sql = sql + strA[1] + "','" + strA[2] + "','" + strA[3] + "','" + strA[4] + "','" + strA[5] + "','" + GlobalData.Current_Round.ToString() + "','" + GlobalData.Current_Game.ToString() + "')";
            myDatabase.ExeSql(sql);
        }


        private void storeResultDB3(string strSend)
        {
            
            string[] strA;
            strA = strSend.Split('$');

            String sql = "";
            DateTime dt = DateTime.Now;
            DB myDatabase = new DB("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            //("Data Source=UNIVERSI-9CB70F\\SQLEXPRESS" + ";Initial Catalog=" + "Game" + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            string TableName;
            TableName = "Result23";
            


            sql = "INSERT INTO [" + TableName + "]([Player#1], [Player#2], [Player#3],[TT1],[TT2],[TT3],[SP],[Round#],[Scenario#])VALUES('";
            sql = sql + strA[1] + "','" + strA[2] + "','" + strA[3] + "','" + strA[4] + "','" + strA[5] + "','" + strA[6] + "','" + strA[7] + "','" + GlobalData.Current_Round.ToString() + "','" + GlobalData.Current_Game.ToString() + "')";
            myDatabase.ExeSql(sql);
        }
 
        private void CreateGameTable(string strName)
        {
            DB myDatabase1 = new DB("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + strDatabaseUser + ";Password=" + strDatabasePwd);
            string str_sql = "CREATE TABLE [dbo].[" + strName + "]" +
                "([ID] [int] NOT NULL," +
                "[Name] [varchar](24) NOT NULL," +
                //"[Game#] [int] NOT NULL," +
                "[Round#] [int] NOT NULL," +
                "[Route#] [int] NOT NULL)";
            myDatabase1.ExeSql(str_sql);
        }

        private void CreateScoreTable(string strName)
        {
            DB myDatabase1 = new DB("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + strDatabaseUser + ";Password=" + strDatabasePwd);
            string str_sql = "CREATE TABLE [dbo].[" + strName + "]" +
                "([ID] [int] NOT NULL," +
                "[Name] [varchar](24) NOT NULL," +
                "[Game#] [int] NOT NULL," +
                "[Score] [int] NOT NULL,";
            myDatabase1.ExeSql(str_sql);
        }



        private void getTT12(int[] players)//object sender, EventArgs e)
        {
            GlobalData.TT[0] = players[0] + 15;
            GlobalData.TT[1] = players[1] + 15;
        }

        private void getTT22(int[] players)//object sender, EventArgs e)
        {
            GlobalData.TT[0] = players[0] + 4;
            GlobalData.TT[1] = players[1] + 4;
        }

        private void getTT13(int[] players)//object sender, EventArgs e)
        {
            GlobalData.TT[0] = players[0] + players[2] + 15;
            GlobalData.TT[1] = players[1] + players[2] + 15;
            GlobalData.TT[2] = players[0] + players[1] + 2 * players[2];
        }

        private void getTT23(int[] players)//object sender, EventArgs e)
        {
            GlobalData.TT[0] = players[0] + 4;
            GlobalData.TT[1] = players[1] + 4;
            GlobalData.TT[2] = 8;
        }

    }
}