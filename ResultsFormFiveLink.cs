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

namespace Game
{
    public partial class ResultsForm : Form
    {

        string strSend = "";                //Send string
        long iSendNum = 0;                 //send Number
        string strSendInfo = "";          //Send information about status
        //int iSuccessNum = 0;
        string[] strAllData = new String[500000];
        IPEndPoint iep;

        private ThreadStart start;
        private Thread listenThread;
        static private bool m_bListening = false;

        Socket clientsock;
        private String strIP = "";
       

        Socket ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 


        public ResultsForm()
        {
            InitializeComponent();
        }

        private void button_nextRound_Click(object sender, EventArgs e)
        {
            GlobleData.numRound = GlobleData.numRound + 1;            

            //this.Visible = false;
            this.Close();

            FiveLinkForm link = new FiveLinkForm();
            link.Visible = true;
            //FourLinkForm_Load();
            
        }

        //private void FourLinkForm_Load(object sender, EventArgs e)
        //{
        //    label_score_total.Text = GlobleData.Score_total.ToString();
        //    label_score_current.Text = GlobleData.Score_current.ToString();
        //}

        private void ResultsFormFiveLink_Load(object sender, EventArgs e)
        {
            if (GlobleData.msg_received[0] == "Results")
            {
                label_Route1.Visible = true;
                label_Route2.Visible = true;
                label_Route3.Visible = true;

                label_Route1.Text = GlobleData.msg_received[1];
                label_Route2.Text = GlobleData.msg_received[2];
                label_Route3.Text = GlobleData.msg_received[3];

                //if (strA[4] == "true")
                //{
                //    label_isEqu.Text = "Y";
                //    label_TT1 = "1 & 2";
                //}
                //else
                //{
                //    label_isEqu.Text = "N";
                //    label_TT1 = strA[3];
                //}

                label_TT1.Text = GlobleData.msg_received[3];
                label_TT2.Text = GlobleData.msg_received[4];
                label_TT3.Text = GlobleData.msg_received[5];

                

            }
            
            label_score_current.Text = GlobleData.Score_current.ToString();

            label_Route.Text = GlobleData.numRoute.ToString();

        }

        private void button_nextGame_Click(object sender, EventArgs e)
        {
            FourLinkForm2 form = new FourLinkForm2();
            form.Visible = true;
            this.Close;
        } 

    }
}
