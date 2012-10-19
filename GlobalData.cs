/****************************** Module Header ******************************\
* Module Name:  GlobleData.cs
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class GlobalData
    {

        //public static string IP = "134.84.148.222";
        //public static string IP = "192.168.0.101";
        //public static string IP = "134.84.74.137";
        //public static string IP = "160.94.177.19";

        //office
        public static string IP = "134.84.148.222";
        public static string strDatabaseIP = "UNIVERSI-9CB70F\\SQLEXPRESS";//"134.84.148.222\\SQLEXPRESS"; 

        //home
        //public static string IP = "134.84.228.175";//"192.168.0.101";
        //public static string strDatabaseIP = "UNIVERSI-9CB70F\\SQLEXPRESS";//"XUANDI\\SQLEXPRESS";

        //public static string strDatabaseIP_lab = "UNIVERSI-9CB70F\\SQLEXPRESS";
        //public static string strDatabaseIP_home = "XUANDI\\SQLEXPRESS";
        
        static bool isUserLoggedIn;

        public static bool IsUserLoggedIn
        {
            get { return GlobalData.isUserLoggedIn; }
            set { GlobalData.isUserLoggedIn = value; }
        }

        //static string userName;

        //public static string UserName
        //{
        //    get { return GlobalData.userName; }
        //    set { GlobalData.userName = value; }
        //}

        static string userID;

        public static string UserID
        {
            get { return GlobalData.userID; }
            set { GlobalData.userID = value; }
        }

        public static int NumGame=1;
        public static int NumScenario = 1;

        public static int numRound_FourLink=1;
        public static int numRound_FiveLink =1;

        public static int numRoute_FourLink;
        public static int numRoute_FiveLink;

        public static int TOTAL_ROUND_trial = 7;
        public static int TOTAL_ROUND_1=1;
        public static int TOTAL_ROUND=1;

        //public static string NumGame;
        //{
        //    get { return GlobleData.NumGame; }
        //    set { GlobleData.NumGame = value; }
        //}

        public static int Score_total=800;

        public static string Path_shortest;
        public static bool IsEquilibrium;

        public static string strData;
        public static string[] msg_received;

        public static byte[] bytes=new byte[1024];
        public static int bytesread;

        public static int TT1;
        public static int TT2;
        public static int TT3;
        public static string[] TT = new string[3];

        //public static int FEE = 15;

		public static int doesNothing;
    }
}
