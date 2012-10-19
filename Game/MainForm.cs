/****************************** Module Header ******************************\
* Module Name:  MainForm.cs
* Project:      CSWinFormSingleInstanceApp
* Copyright (c) Microsoft Corporation.
* 
* The  sample demonstrates how to achieve the goal that only 
* one instance of the application is allowed in Windows Forms application..
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/en-us/openness/resources/licenses.aspx#MPL.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Text;

namespace Game
{
    public partial class MainForm : Form
    {
        #region fields
        LoginForm loginEntry = new LoginForm();
        FourLinkForm Link = new FourLinkForm();
        string loginMsg = "";
        event EventHandler LoginMsgChanged;


        private Boolean isWrongPassword = false;

        string strSend = "";                //Send string
        long iSendNum = 0;                 //send Number
        string strSendInfo = "";          //Send information about status
        //int iSuccessNum = 0;
        string[] strAllData = new String[500000];
        long iAllDataNum = 0;
        int iSpanNum = 0;
        IPEndPoint iep;

        private ThreadStart start;
        private Thread listenThread;
        static private bool m_bListening = false;

        Socket ClientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private String strIP = "";
        bool bServerOK = false;

        #endregion

        #region Properties
        public string LoginMsg
        {
            get { return loginMsg; }
            set
            {
                if (value != loginMsg)
                {
                    loginMsg = value;
                    OnLoginMsgChanged(EventArgs.Empty);
                }
            }
        }
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
            this.StartPosition = FormStartPosition.CenterScreen;
         
        }
        #endregion

        #region EventHandlers
        void MainForm_Load(object sender, EventArgs e)
        {
            //show Login dialog
            loginEntry.ShowDialog();
            //display welcome message
            DisplayWelcomeMessage();
            //bind Text of lableUserStatus to LoginMsg property.
            this.labelUserStatus.DataBindings.Add("Text", this, "LoginMsg");
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            GlobalData.IsUserLoggedIn = true;
            LoginMsg = "User Successfully logged into the game";


            // FourLinkForm jumps in
            this.Visible = false;
            //FourLinkForm Link = new FourLinkForm();
            FourLinkForm Link = new FourLinkForm();
            if (Link.ShowDialog() == DialogResult.OK)
            {
                if (this.Visible == false && GlobalData.IsUserLoggedIn)
                {
                    this.Visible = true;
                }
                LoginMsg = "User Successfully logged in";
            }
            
        }
        #endregion

        #region HelperMethods
        void DisplayWelcomeMessage()
        {
            string welcomeMsg = "Welcome to Game:" + GlobalData.UserID;
            this.labelWelcomeMsg.Text = welcomeMsg;        
            LoginMsg ="User Successfully logged in";
           
        }

        void OnLoginMsgChanged(EventArgs e)
        {
            if (LoginMsgChanged != null)
            {
                LoginMsgChanged(this, e);
            }
        }
        #endregion
    }
}
