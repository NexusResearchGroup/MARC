using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Runtime.InteropServices;

namespace Game
{
    public partial class ResultsForm : Form
    {        
      
        Socket ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // disable close button
        const int MF_BYPOSITION = 0x400;
        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);


        public ResultsForm()
        {
            InitializeComponent();
        }

        private void button_nextRound_Click(object sender, EventArgs e)
        {
            GlobalData.numRound_FourLink = GlobalData.numRound_FourLink + 1; 
            
            this.Close();

            if (GlobalData.NumGame == 1)
            {
                FourLinkForm link = new FourLinkForm();
                link.Visible = true;
            }
            else if (GlobalData.NumGame == 2)
            {
                FourLinkForm2 link2 = new FourLinkForm2();
                link2.Visible = true;
            }
            
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            GlobalData.TT[0] = GlobalData.msg_received[3];
            GlobalData.TT[1] = GlobalData.msg_received[4];

            if (GlobalData.msg_received[7] != "")
            {
                GlobalData.TOTAL_ROUND_1 = Convert.ToInt16(GlobalData.msg_received[7]);
            }

            if (GlobalData.msg_received[9] != "")
            {
                GlobalData.TOTAL_ROUND_trial = Convert.ToInt16(GlobalData.msg_received[9]);
            }
            
            if (GlobalData.msg_received[0] == "Results")
            {
                label_Route1.Visible = true;
                label_Route2.Visible = true;

                label_Route1.Text = GlobalData.msg_received[1];
                label_Route2.Text = GlobalData.msg_received[2];


                label_TT1.Text = GlobalData.msg_received[3];
                label_TT2.Text = GlobalData.msg_received[4];

                label_Route.Text = GlobalData.numRoute_FourLink.ToString();

                if (GlobalData.NumGame == 1)
                {
                    if (GlobalData.numRound_FourLink == GlobalData.TOTAL_ROUND_trial)
                    {
                        button_nextGame.Visible = true;
                    }
                }
                else
                {
                    if (GlobalData.numRound_FourLink == GlobalData.TOTAL_ROUND_1)
                    {
                        button_nextGame.Visible = true;
                    }
                }
            }

            //disable close button
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int menuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

        }

        private void button_nextGame_Click(object sender, EventArgs e)
        {
            this.Close();
            
            GlobalData.numRound_FiveLink = 1;

            if (GlobalData.NumGame == 1)
            {
                FiveLinkForm link5 = new FiveLinkForm();
                link5.Visible = true;
            }
            else if (GlobalData.NumGame == 2)
            {
                FiveLinkForm2 link52 = new FiveLinkForm2();
                link52.Visible = true;
            }
        }

    }
}
