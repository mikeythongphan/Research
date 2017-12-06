using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace vnyi.Utility.RES
{
    public class clsSocket
    {
        public static void SendToServer(Socket Socket, string msg)
        {
            try
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
                if (Socket != null)
                {
                    Socket.Send(data);
                }
            }
            catch (Exception ex) { ; }
        }

        public static string ConvertData(IAsyncResult asyn)
        {
            string data = string.Empty;
            try
            {
                SocketPacket socPacket = (SocketPacket)asyn.AsyncState;
                int iRx = socPacket.mSocket.EndReceive(asyn);
                char[] chars = new char[iRx];
                System.Text.Decoder d = System.Text.Encoding.ASCII.GetDecoder();
                int charLen = d.GetChars(socPacket.mDataBuffer, 0, iRx, chars, 0);
                data = new string(chars);
            }
            catch { }
            return data;
        }

        public static IPEndPoint NewEndPointServer(string IPServer, int PORT)
        {
            IPAddress ip = IPAddress.Parse(IPServer);
            // Create the end point 
            IPEndPoint ipEnd = new IPEndPoint(ip, PORT);
            return ipEnd;
        }

        //Tao chuoi theo tham so truyen vao dinh dang a|b|c|...|*
        public static string JoinString(params object[] s)
        {
            string str = string.Empty;
            for (int i = 0; i < s.Length; i++)
                str += s[i].ToString() + "|";
            str += "*";
            return str;
        }
    }

    public class SocketPacket
    {
        public System.Net.Sockets.Socket mSocket;
        public byte[] mDataBuffer = new byte[1024];
    }
}
