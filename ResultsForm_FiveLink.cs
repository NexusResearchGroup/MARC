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
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Game
{
    public partial class ResultsForm_FiveLink : Form
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


        private string strDatabaseName = "Game_2";

        public ResultsForm_FiveLink()
        {
            InitializeComponent();
        }

        private void button_nextRound_Click(object sender, EventArgs e)
        {
            GlobalData.numRound_FiveLink = GlobalData.numRound_FiveLink + 1;   


            //this.Visible = false;
            this.Close();

            if (GlobalData.NumGame == 1)
            {
                FiveLinkForm link = new FiveLinkForm();
                link.Visible = true;
            }
            else if (GlobalData.NumGame == 2)
            {
                FiveLinkForm2 link2 = new FiveLinkForm2();
                link2.Visible = true;
            }
                
            
        }
      

        private void ResultsForm_FiveLink_Load(object sender, EventArgs e)
        {
            if (GlobalData.msg_received[0] == "Results")
            {
                label_route1.Visible = true;
                label_route2.Visible = true;
                label_route3.Visible = true;

                label_route1.Text = GlobalData.msg_received[1];
                label_route2.Text = GlobalData.msg_received[2];
                label_route3.Text = GlobalData.msg_received[3];

                label_TT1.Text = GlobalData.msg_received[4];
                label_TT2.Text = GlobalData.msg_received[5];
                label_TT3.Text = GlobalData.msg_received[6];

                if (GlobalData.msg_received[9] != "")
                {
                    GlobalData.TOTAL_ROUND = Convert.ToInt16(GlobalData.msg_received[9]);
                }
                

                label_Route.Text = GlobalData.numRoute_FiveLink.ToString();

                if (GlobalData.NumGame == 1)
                {
                    if (GlobalData.numRound_FiveLink == GlobalData.TOTAL_ROUND)
                    {                        
                        button_nextRound.Visible = false;
                        //button_thanks.Visible = true;
                        //MessageBox.Show("Game over!\n Thanks for playing!");
                        label_thanks.Visible = false;
                        button_exit.Visible = false;
                        button5_nextGame.Visible = true;
                    }
                }
                else if (GlobalData.NumGame == 2)
                {
                    if (GlobalData.numRound_FiveLink == GlobalData.TOTAL_ROUND)
                    {
                        button_nextRound.Visible = false;
                        //button_thanks.Visible = true;
                        //MessageBox.Show("Game over!\n Thanks for playing!");
                        label_thanks.Visible = true;
                        button_exit.Visible = true;

                        groupBox_FinalScore.Visible = true;
                        label_finalscore.Text = GlobalData.Score_total.ToString();
                    }
                }

                //disable close button
                IntPtr hMenu = GetSystemMenu(this.Handle, false);
                int menuItemCount = GetMenuItemCount(hMenu);
                RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

            }

        }

        void ResultsForm_FiveLink_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        void ResultsForm_FiveLink_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {

            ////Excel Application Variables
            //Excel.Application xlApp = new Excel.Application();
            //Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(1); ;
            //Excel.Sheets xlSheets = null;
            //Excel.Worksheet xlNewSheet = null;
            //object misValue = System.Reflection.Missing.Value;

            //xlSheets = xlWorkbook.Worksheets;
            ////create a new spreadsheet
            //xlNewSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
            ////xlNewSheet.Name = "phase";

            //int rowIndex = 1; int colIndex = 1;
            //xlNewSheet.Cells[rowIndex, colIndex] = "Hello World!";

            ////post process
            //xlWorkbook.SaveAs("C:\\Documents and Settings\\Administrator\\Desktop\\GameReport.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkbook.Close(Type.Missing, Type.Missing, Type.Missing);
            //xlApp.Quit();
            
            
            ////import data from SQL to Excel
            ////timePt = timeConvert(timePt);
            ////string timePt_str = String.Format("{0:D9}", timePt);
            //int InterID_txt = 103;

            ////DB myDatabase = new DB("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");

            //string ConnectionString = ("Data Source=" + GlobalData.strDatabaseIP + ";Initial Catalog=" + strDatabaseName + ";Integrated Security=no;UID=" + "Xuan" + ";Password=" + "123456");
            //SqlConnection Conn = new SqlConnection(ConnectionString);

            //DataSet DataSet = new DataSet();
            //string SQL_Sig = "select * from Results22 where PhaseID=";
            //SqlDataAdapter Adapter = new SqlDataAdapter(SQL_Sig,Conn);//定义并初始化数据适配器
            //Adapter.Fill(DataSet);//将数据适配器中的数据填充到数据集中
     

            
            this.Dispose();
            Application.Exit();
        }

        private void button5_nextGame_Click(object sender, EventArgs e)
        { 
            this.Close();

            GlobalData.NumGame = 2;
            //GlobalData.NumScenario = 1;

            GlobalData.numRound_FourLink = 1;
            GlobalData.numRound_FiveLink = 1;

            FourLinkForm2 link42 = new FourLinkForm2();
            link42.Visible = true;

                //FiveLinkForm2 link52 = new FiveLinkForm2();
                //link52.Visible = true;
          
        }

        //private void button_video_Click(object sender, EventArgs e)
        //{
        //    this.Close();

        //    GlobalData.numRound_FiveLink = 1;
        //    GlobalData.NumGame = 4;

        //    FiveLinkForm link5 = new FiveLinkForm();
        //    link5.Visible = true;
        //}

       
    }
}
