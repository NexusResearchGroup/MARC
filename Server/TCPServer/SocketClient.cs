using System;
using System.Collections.Generic;
using System.Text;

namespace LabCommServer
{

    using System.Net.Sockets;
    using System.Net;

    /// <summary>
    /// Summary description for Client.
    /// </summary>
    public class SocketClient
    {
        private Socket sock;
        //private string strData = "";
        public string strData = "";
        public string[] strA;

        public SocketClient(Socket _sock)
        {
            //port = Convert.ToInt32(_port);
            strData="";
            sock = _sock;
        }

        public Socket Sock
        {
            get { return sock; }
            set { sock = value; }
        }

        //public string strData 
        //{
        //    get { return strData; }
        //    set { strData = value; }
        //}

        public void ReceiveData()
        {
            //while (true)
            //{
            try
            {

                Console.WriteLine("Connection accepted from " + this.sock.RemoteEndPoint);
                //txtInfor.Text = DateTime.Now.ToString() + ":  " + s.RemoteEndPoint.ToString() + ": Connected\r\n" + txtInfor.Text;

                byte[] bytes = new byte[1024];
                int bytesRec = this.sock.Receive(bytes);
                strData += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                //Console.WriteLine("Recieved...");
                // for (int i = 0; i < bytesRec; i++)
                Console.Write("Recieved..."+strData);//Convert.ToChar(b[i]));
                //Console.WriteLine("worker thread: working...");

                string[] strB = strData.Split('$');

                //send confirmation
                ASCIIEncoding asen = new ASCIIEncoding();
                string str = "Submitted Successfully! You Submit Route " + strB[3] + "\nPress OK and Please Wait...";
                this.sock.Send(asen.GetBytes(str));//"The string was recieved by the server from port 5567."));
                Console.WriteLine("\nSent Acknowledgement");       

                strA = strB;

            }
            catch (Exception err)
            {
                Console.WriteLine("Error..... " + err.Message);//.StackTrace);
                return;
            }

            //}
                
        }
    }

}
