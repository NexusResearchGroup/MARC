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
using System.Runtime.InteropServices;
#endregion


namespace Game
{
    public partial class FiveLinkForm : Form
    {
        public FiveLinkForm()
        {
            InitializeComponent();
        }

       Socket ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

       // disable close button
       const int MF_BYPOSITION = 0x400;
       [DllImport("User32")]
       private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
       [DllImport("User32")]
       private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
       [DllImport("User32")]
       private static extern int GetMenuItemCount(IntPtr hWnd);

        private void Submit_Click(object sender, EventArgs e)
        {

            //GlobleData.numRound_FiveLink = GlobleData.numRound_FiveLink + 1;   
            
            if (route1.Checked == true)
            {

                GlobalData.numRoute_FiveLink = 1;
            }
            else if (route2.Checked == true)
            {

                GlobalData.numRoute_FiveLink = 2;
            }
            else if (route3.Checked == true)
            {

                GlobalData.numRoute_FiveLink = 3;
            }

            //button_Submit.Visible = false;
            //label_submit.Visible = true;
            //label4.Visible = true;
            //label_Route.Visible = true;
            //label_Route.Text = GlobleData.numRoute.ToString();

            //DialogResult result = MessageBox.Show("You submit Route:" + GlobalData.numRoute_FiveLink.ToString() + ";\n Press OK and wait...", "Submitted!", MessageBoxButtons.OK);//, MessageBoxIcon.Asterisk);
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

                String str = "Game" + "$" + GlobalData.UserID + "$" + Convert.ToString(GlobalData.numRound_FiveLink) + "$" + Convert.ToString(GlobalData.numRoute_FiveLink) + "$" + GlobalData.NumGame.ToString() + "$" + GlobalData.Score_total.ToString() + "$" + GlobalData.NumScenario.ToString();
                Stream stm = tcpclnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Transmitting.....");

                stm.Write(ba, 0, ba.Length);

                //receive data from server once submit
                byte[] dat = new byte[100];
                int datLength = stm.Read(dat, 0, 100);
                string strDat = Encoding.ASCII.GetString(dat, 0, datLength);
                //label_submit.Visible = true;
                //label_submit.Text = strDat;

                DialogResult dialog = MessageBox.Show(strDat, "Important Message");//, MessageBoxIcon.Asterisk);
                button_Submit.Enabled = false;

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

                GlobalData.TT[0] = GlobalData.msg_received[4];
                GlobalData.TT[1] = GlobalData.msg_received[5];
                GlobalData.TT[2] = GlobalData.msg_received[6];

                    GlobalData.Path_shortest = GlobalData.msg_received[7];
                    GlobalData.IsEquilibrium = Convert.ToBoolean(GlobalData.msg_received[8]);


                    //if (GlobalData.NumGame == 2 || GlobalData.NumGame == 4)//(GlobalData.NumGame == 4 && GlobalData.numRoute_FiveLink != 3))
                    //{
                        GlobalData.Score_total -= Convert.ToInt32(GlobalData.TT[GlobalData.numRoute_FiveLink - 1]);
                        label5_score_total.Text = GlobalData.Score_total.ToString();
                    //}
                    //else if (GlobalData.NumGame == 3 && GlobalData.numRoute_FiveLink == 3)
                    //{
                    //    GlobalData.Score_total = GlobalData.Score_total-Convert.ToInt32(GlobalData.TT[GlobalData.numRoute_FiveLink - 1])-GlobalData.FEE;
                    //    label5_score_total.Text = GlobalData.Score_total.ToString();
                    //}
               
                //if (GlobleData.numRound == GlobleData.TOTAL_ROUND)
                //{
                //    SendTotalScore();
                //}

            }
            catch
            {
            }


            ResultsForm_FiveLink result = new ResultsForm_FiveLink();
            result.Visible = true;
            //this.Visible = false;
            this.Close();


        }

        

        private void FiveLinkForm_Load(object sender, EventArgs e)
        {
            label5_score_total.Text = GlobalData.Score_total.ToString();

            GlobalData.NumGame = 1;
            GlobalData.NumScenario = 2;

            label6.Text = GlobalData.numRound_FiveLink.ToString();
            label4.Text = GlobalData.NumScenario.ToString();
            label_add.Visible = true;


            //if (GlobalData.NumGame == 2 || GlobalData.NumGame == 4)
            //{
            //    label_add.Visible = true;

            //}
            //else if (GlobalData.NumGame == 1 || GlobalData.NumGame == 3)
            //{            

            //    label_add.Visible = false;
                
            //}

            //disable close button
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
        }

        void FiveLinkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        void FiveLinkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }



    }
}
