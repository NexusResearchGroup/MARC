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
    public class GlobleData
    {

        public static string IP = "134.84.148.222";
        //public static string IP = "192.168.0.101";
        
        static bool isUserLoggedIn;

        public static bool IsUserLoggedIn
        {
            get { return GlobleData.isUserLoggedIn; }
            set { GlobleData.isUserLoggedIn = value; }
        }

        static string userName;

        public static string UserName
        {
            get { return GlobleData.userName; }
            set { GlobleData.userName = value; }
        }

        static string userID;

        public static string UserID
        {
            get { return GlobleData.userID; }
            set { GlobleData.userID = value; }
        }

        public static int NumGame=1;

        public static int numRound_FourLink=1;
        public static int numRound_FiveLink =1;

        public static int numRoute_FourLink;
        public static int numRoute_FiveLink;

        public static int TOTAL_ROUND=1;

        //public static string NumGame;
        //{
        //    get { return GlobleData.NumGame; }
        //    set { GlobleData.NumGame = value; }
        //}

        public static int Score_current_FourLink;
        public static int Score_total_FourLink;

        public static int Score_current_FiveLink;
        public static int Score_total_FiveLink;


        //public static int Score_current_FiverLink;
        public static int Score_total=0;

        public static string Path_shortest;
        public static bool IsEquilibrium;

        public static string strData;
        public static string[] msg_received;

        public static byte[] bytes=new byte[1024];
        public static int bytesread;



    }
}
