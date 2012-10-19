/****************************** Module Header ******************************\
* Module Name:  LoginForm.cs
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
using System.Data.Sql;
#endregion

namespace Game
{
    public partial class LoginForm : Form
    {
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

        Socket clientsock;
        private String strIP = "";
        bool bServerOK = false;



        #region Contructor
        public LoginForm()
        {
            InitializeComponent();
            // add event handlers
            this.Load += new EventHandler(LoginForm_Load);
            this.FormClosed += new FormClosedEventHandler(LoginForm_FormClosed);
            this.FormClosing += new FormClosingEventHandler(LoginForm_FormClosing);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
        }

        #endregion

        #region EventHandlers
        void LoginForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.buttonLogin;
        }

        void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isWrongPassword)
                e.Cancel = true;
            //Application.Exit();
        }

        void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!GlobalData.IsUserLoggedIn)
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //string name = textBoxName.Text;
            string ID = textBoxID.Text;

            if (textBox_IP.Text != "")
            {
                GlobalData.IP = textBox_IP.Text;
            }

            GlobalData.IsUserLoggedIn = true;
            //GlobalData.UserName = name;
            GlobalData.UserID = ID;
            this.DialogResult = DialogResult.OK;
            //isWrongPassword = false;
            
            //Communication();

            String str = GlobalData.UserID;
            //store2PlayerDB(str);

        }

        //private string GlobalData.strDatabaseIP = "";
        private string strDatabaseName = "Game_2";
        private string strDatabaseUser = "";
        private string strDatabasePwd = "";

        //send data directly to DB
        private void store2PlayerDB(string str)
        {
            //DB myDatabase = new DB();
            String sql = "";
            DateTime dt = DateTime.Now;
            DB myDatabase = new DB("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            //("Data Source=UNIVERSI-9CB70F\\SQLEXPRESS" + ";Initial Catalog=" + "Game" + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            string TableName;
            TableName = "Player";
            //CreateGameTable(TableName);
            //if (GlobalData.Current_Round == 0)
            //{
            //    sql = "Truncate" + TableName;
            //    myDatabase.ExeSql(sql);
            //}

            sql = "INSERT INTO [" + TableName + "]([ID])VALUES('";
            sql = sql + str + "')";
            myDatabase.ExeSql(sql);
        }

        #endregion

    }
}
