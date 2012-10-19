#region Using directives
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Text;
using System.IO;
#endregion


namespace Game
{
    public partial class FourLinkForm : Form
    {
        public FourLinkForm()
        {
            InitializeComponent();
        }

        
        string[] strAllData = new String[500000];
       

        Socket ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private void Submit_Click(object sender, EventArgs e)
        {

            //GlobleData.numRound_FourLink = GlobleData.numRound_FourLink + 1;

            if (route1.Checked == true)
            {

                GlobalData.numRoute_FourLink = 1;
            }
            else
            {

                GlobalData.numRoute_FourLink = 2;
            }

            //button_Submit.Visible = false;
            //label_submit.Visible = true;
            //label4.Visible = true;
            //label_Route.Visible = true;
            //label_Route.Text = GlobleData.numRoute.ToString();

            DialogResult result = MessageBox.Show("You submit Route:" + GlobalData.numRoute_FourLink.ToString() + ";\n Press OK and wait...", "Submitted!", MessageBoxButtons.OK);//, MessageBoxIcon.Asterisk);
            //if (result == DialogResult.OK)
            //{
                //MessageBox.Show("You submit Route" + GlobleData.numRoute.ToString() + "\n Submitted successfully!\n Press OK to continue");
                Communication();
            //}
            //else if (result == DialogResult.Cancel)
            //{
                
            //}
        }


        private void Communication()
        {
            // send to server
            try
            {
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");

                tcpclnt.Connect(GlobalData.IP, 5567);
                // use the ipaddress as in the server program

                Console.WriteLine("Connected");
                Console.Write("Enter the string to be transmitted : ");

                String str = "Game" + "$" + GlobalData.UserID + "$" + GlobalData.UserName + "$" + Convert.ToString(GlobalData.numRound_FourLink) + "$" + Convert.ToString(GlobalData.numRoute_FourLink) + "$" + GlobalData.NumGame.ToString();
                Stream stm = tcpclnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Transmitting.....");

                stm.Write(ba, 0, ba.Length);



                //receive data from server
                byte[] data = new byte[100];
                int receivedDataLength = stm.Read(data, 0, 100);
                GlobalData.strData = Encoding.ASCII.GetString(data, 0, receivedDataLength);

                for (int i = 0; i < receivedDataLength; i++)
                    Console.Write(Convert.ToChar(data[i]));

                //tcpclnt.Close();
            }

            catch (Exception err)
            {
                Console.WriteLine("Error..... " + err.StackTrace);
            }


            try
            {
                GlobalData.msg_received = GlobalData.strData.Split('$');

                GlobalData.TT[0] = GlobalData.msg_received[3];
                GlobalData.TT[1] = GlobalData.msg_received[4];

                if (GlobalData.msg_received.Length > 1)//==5
                {
                    GlobalData.Path_shortest = GlobalData.msg_received[5];
                    GlobalData.IsEquilibrium = Convert.ToBoolean(GlobalData.msg_received[6]);

                    if (GlobalData.NumGame == 1)
                    {

                        if (GlobalData.IsEquilibrium == true)
                        {
                            GlobalData.Score_current_FourLink1 = 10;
                        }
                        else if (GlobalData.TT[GlobalData.numRoute_FourLink - 1] == GlobalData.Path_shortest)
                        {
                            GlobalData.Score_current_FourLink1 = 10;
                        }
                        else
                        {
                            GlobalData.Score_current_FourLink1 = 0;
                        }

                        label_score_current.Text = GlobalData.Score_current_FourLink1.ToString();
                        GlobalData.Score_total_FourLink1 = GlobalData.Score_total_FourLink1 + GlobalData.Score_current_FourLink1;
                        GlobalData.Score_total += GlobalData.Score_current_FourLink1;

                        label_score_total.Text = GlobalData.Score_total.ToString();
                        label_score_current.Text = GlobalData.Score_current_FourLink1.ToString();
                    }
                    else if (GlobalData.NumGame == 3)
                    {

                        if (GlobalData.IsEquilibrium == true)
                        {
                            GlobalData.Score_current_FourLink2 = 10;
                        }
                        else if (GlobalData.TT[GlobalData.numRoute_FourLink - 1] == GlobalData.Path_shortest)
                        {
                            GlobalData.Score_current_FourLink2 = 10;
                        }
                        else
                        {
                            GlobalData.Score_current_FourLink2 = 0;
                        }

                        label_score_current.Text = GlobalData.Score_current_FourLink2.ToString();
                        GlobalData.Score_total_FourLink2 = GlobalData.Score_total_FourLink2 + GlobalData.Score_current_FourLink2;
                        GlobalData.Score_total += GlobalData.Score_current_FourLink1;

                        label_score_total.Text = GlobalData.Score_total.ToString();
                        label_score_current.Text = GlobalData.Score_current_FourLink2.ToString();
                    }
                }
            }
            catch
            {
            }

            

            ResultsForm result = new ResultsForm();
            result.Visible = true;
            //this.Visible = false;
            this.Close();
        }
        

        private void SendTotalScore()
        {

            TcpClient client = new TcpClient();
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("134.84.148.222"), 5567);
            client.Connect(serverEndPoint);
            NetworkStream clientStream = client.GetStream();

            String msg = "Score"+ "$" +GlobalData.UserID + "$" + GlobalData.UserName + "$" + GlobalData.NumGame + "$" + GlobalData.Score_total_FourLink1;
            Byte[] sendBytes = Encoding.Default.GetBytes(msg);
            ClientSock.Connect(serverEndPoint);
            ClientSock.Send(sendBytes);

        }

        private void FourLinkForm_Load(object sender, EventArgs e)
        {
            if (GlobalData.NumGame == 1)
            {
                label_score_total.Text = GlobalData.Score_total.ToString();
                label_score_current.Text = GlobalData.Score_current_FourLink1.ToString();

                label_Round.Text = GlobalData.numRound_FourLink.ToString();
                label_Game.Text = GlobalData.NumGame.ToString();
            }
            else if (GlobalData.NumGame == 3)
            {
                label_score_total.Text = GlobalData.Score_total.ToString();
                label_score_current.Text = GlobalData.Score_current_FourLink2.ToString();

                label_Round.Text = GlobalData.numRound_FourLink.ToString();
                label_Game.Text = GlobalData.NumGame.ToString();
            }


            //if (GlobalData.NumGame == 3)
            //{
            //    label_exp.Visible = true;
            //}
        }


        private void getTT2(int[] players)//object sender, EventArgs e)
        {
            GlobalData.TT[0] = (10 * players[0] + 210).ToString();
            GlobalData.TT[1] = (10 * players[1] + 210).ToString();
        }

        private void getTT3(int[] players)//object sender, EventArgs e)
        {
            GlobalData.TT[0] = (10 * players[0] + 210).ToString();
            GlobalData.TT[1] = (10 * players[1] + 210).ToString();
            GlobalData.TT[2] = (10 * players[2] + 210).ToString();
        }

        

    }
}
