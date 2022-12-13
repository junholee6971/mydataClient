using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    class TcpClientMsg
    {
        private static TcpClient client;
        private static NetworkStream ns;

        public static NetworkStream GetTcpClient()
        {
            if (client == null)
            {
                client = ConnectTcp();
                ns = client.GetStream();
            }
            
            return ns;

        }

        private static TcpClient ConnectTcp()
        {
            TcpClient tc = null;
            try
            {
                String szServerIP = ConfigurationManager.AppSettings["ServerIP"];
                tc = new TcpClient(szServerIP, 9100);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tc;
        }

        public static string SendAndRecieve(string msg)
        {

            string sendMsg = msg + "\r";

            byte[] bytes = Encoding.ASCII.GetBytes(sendMsg);
            byte[] retbytes = new byte[30000];

            string retMsg = null;

            try
            {


                NetworkStream client = GetTcpClient();

                if (client == null) return "접속이 되지 않았습니다.";

                client.Write(bytes, 0, bytes.Length);

                int recvLen = client.Read(retbytes, 0, retbytes.Length);

                retMsg = Encoding.ASCII.GetString(retbytes, 0, recvLen);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               Close();
            }


            return retMsg;

        }

        public static void Close()
        {
            if( ns != null)
            {
                ns.Close();
                ns = null;
            }

            if (client != null)
            {
                client.Close();
                client = null;
            }
        }



    }
}

