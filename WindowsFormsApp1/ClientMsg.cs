using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    public class ClientMsg
    {
        private static Socket socket;

        public static Socket GetSocket()
        {
            if(socket == null)
            {
                socket = ConnectSocket();
            }

            return socket;
        }

        public static void Close()
        {
            if(socket != null)
            {
                socket.Close();
            }
        }

        private static Socket ConnectSocket()
        {
            Socket so;
            try
            {

                IPAddress serverIp = IPAddress.Parse("szServerIP");
                IPEndPoint iPEndPoint = new IPEndPoint(serverIp, 9100);
                so = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                so.Connect(iPEndPoint);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

            return so;
        }

        public static string SendAndRecieve(string msg)
        {
            string sendMsg = msg + "\r";

            byte[] bytes = Encoding.UTF8.GetBytes(sendMsg);
            byte[] retbytes = new byte[30000];

            socket = GetSocket();

            if (socket == null) return "접속이 되지 않았습니다.";

            socket.Send(bytes, 0, bytes.Length, SocketFlags.None);

            socket.Receive(retbytes, 0, retbytes.Length, SocketFlags.None);

            int recvLen = byteArrayDefrag(retbytes);

            string retMsg = Encoding.UTF8.GetString(retbytes, 0, recvLen + 1);

            return retMsg;

        }

        private static int byteArrayDefrag(byte[] sData)
        {
            int endLength = 0;

            for (int i = 0; i < sData.Length; i++)
            {
                if ((byte)sData[i] != (byte)0)
                {
                    endLength = i;
                }
            }

            return endLength;
        }

    }
}
