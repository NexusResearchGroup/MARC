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
    public partial class FourLinkForm : Form
    {
        public FourLinkForm()
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

            //DialogResult result = MessageBox.Show("You submit Route:" + GlobalData.numRoute_FourLink.ToString() + ";\n Press OK and wait...", "Submitted!", MessageBoxButtons.OK);//, MessageBoxIcon.Asterisk);
            //if (result == DialogResult.OK)
            //{
                //MessageBox.Show("You submit Route" + GlobleData.numRoute.ToString() + "\n Submitted successfully!\n Press OK to continue");
                Communication_Submit();
            //}
            //else if (result == DialogResult.Cancel)
            //{
                
            //}

                //Communication_Result();
        }


        private void Communication_Submit()
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

                String str = "Game" + "$" + GlobalData.UserID + "$"+ Convert.ToString(GlobalData.numRound_FourLink) + "$" + Convert.ToString(GlobalData.numRoute_FourLink) + "$" + GlobalData.NumGame.ToString() + "$" + GlobalData.Score_total.ToString() + "$" + GlobalData.NumScenario.ToString();
                Stream stm = tcpclnt.GetStream();

                    
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Transmitting.....");
                stm.Write(ba, 0, ba.Length);//send route info to server

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

                GlobalData.TT[0] = GlobalData.msg_received[3];
                GlobalData.TT[1] = GlobalData.msg_received[4];

                GlobalData.Path_shortest = GlobalData.msg_received[5];
                GlobalData.IsEquilibrium = Convert.ToBoolean(GlobalData.msg_received[6]);

                GlobalData.Score_total -= Convert.ToInt32(GlobalData.TT[GlobalData.numRoute_FourLink - 1]);
                label4_score_total.Text = GlobalData.Score_total.ToString();
              
            }
            catch
            {
            }

            ResultsForm result = new ResultsForm();
            result.Visible = true;
            //this.Visible = false;
            this.Close();
        }
        

        private void FourLinkForm_Load(object sender, EventArgs e)
        {
            label4_score_total.Text = GlobalData.Score_total.ToString();

            GlobalData.NumGame = 1;
            GlobalData.NumScenario = 1;

            label_Round.Text = GlobalData.numRound_FourLink.ToString();
            label_Game.Text = GlobalData.NumScenario.ToString();

            
            //disable close button
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

        }

        void FourLinkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            this.Dispose();
            Application.Exit();
        }

        void FourLinkForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            this.Dispose();
            Application.Exit();
        }


    }
}
