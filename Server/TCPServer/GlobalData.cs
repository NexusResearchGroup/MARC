using System;
using System.Collections.Generic;
using System.Text;

namespace LabCommServer
{
    public class GlobalData
    {

        //public static string IP = "134.84.74.137";
        //public static string IP = "160.94.177.19";

        //office
        public static string IP = "134.84.148.222";
        public static string strDatabaseIP = "UNIVERSI-9CB70F\\SQLEXPRESS";//"134.84.148.222\\SQLEXPRESS"; 

        //home
        //public static string IP = "134.84.228.175";//"192.168.0.101";
        //public static string strDatabaseIP = "UNIVERSI-9CB70F\\SQLEXPRESS";//"XUANDI\\SQLEXPRESS";


        public static string strDatabaseIP_lab="UNIVERSI-9CB70F\\SQLEXPRESS";
        public static string strDatabaseIP_home = "XUANDI\\SQLEXPRESS";


        public static string Path_shortest;
        public static bool IsEquilibrium = false;
        public static int[] numPlayer = new int[3];
        public static string strSend;

        public static int TT1;
        public static int TT2;
        public static int TT3;
        public static int[] TT=new int[3];

        public static int Current_Round;
        public static int Current_Game;
        public static int Current_Scenario;

        public static int PLAYER_NUM = 1;

        public static int ROUND_NUM_trial = 7;//
        public static int ROUND_NUM_1=1;//=5;
        public static int ROUND_NUM=1;// = 10;
    }
}
