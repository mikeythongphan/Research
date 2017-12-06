using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Net.Sockets;
using System.Timers;
using System.Data;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using vnyi.Utility.RES;
using vnyi.Utility;

namespace vnyi.ServiceClient
{
    public partial class ServiceClient : ServiceBase
    {        
        private static Socket ClientSocket = null;        
        Timer timer = new System.Timers.Timer();
        public AsyncCallback mCallBack, tfClientCallBack;  
       // private static bool isConnect = false,isRunGetdata = true;
        private static int TimeRun =1;
        /// <summary>
        /// Khi send goi lai ham nhan du lieu
        /// </summary>
        private static bool isCallRecieptData = false,isGetScriptProcess=false;
        /// <summary>
        public delegate void OnCommandEventHandler(string command);
        /// <summary>
        /// Tạo kết nối tới server
        /// </summary>
        public  void ConecServer()
        {
          //  Logger.TranferDataLog(" Begin conect" + DateTime.Now.ToString());
            try
            {

                if (ClientSocket == null || !ClientSocket.Connected)
                {
                    if (ClientSocket == null)
                        ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    ClientSocket.BeginConnect(clsSocket.NewEndPointServer(Utility.GetConfigValue(SettingsKey.S_SERVERIP),
                        clsFormat.IntConvert(Utility.GetConfigValue(SettingsKey.SERVERPORT))),
                        ClientConectedCallback,
                        ClientSocket);
                }
                else
                {
                    clsSocket.SendToServer(ClientSocket, clsSocket.JoinString(SendSocket.CONN, clsMisc.GetIP(), Utility.getKey, Utility.BranchID, Utility.ComputerName));
                }
               
            }
            catch (Exception ex)
            {
                ClientSocket = null;
                ClearConectSocket();
                Logger.TranferDataLog(" Conect server Error " + ex.Message);
            }
        }
        /// <summary>
        /// Kết nối thành công
        /// </summary>
        /// <param name="asyn"></param>
        private void ClientConectedCallback(IAsyncResult asyn)
        {
            try
            {
                if (ClientSocket.Connected)
                {
                  //  Logger.TranferDataLog("Connected Server .." + DateTime.Now.ToString());
                    clsSocket.SendToServer(ClientSocket, clsSocket.JoinString(SendSocket.CONN, clsMisc.GetIP(), Utility.getKey, Utility.BranchID,Utility.ComputerName));
                    ClientWaitData();
                    Logger.TranferDataLog("Client Conected Server " + DateTime.Now.ToString());
                }
                else
                {
                   // Logger.TranferDataLog("Conect false " + DateTime.Now.ToString());
                    ClearConectSocket();
                }
            }
            catch (Exception ex)
            {                
                Logger.TranferDataLog("Send Error" + ex.Message);
                ClearConectSocket();
            }          
        }          
    /// <summary>
    /// Stop service
    /// </summary>
    private void TranferStop()
    {        
       clsSocket.SendToServer(ClientSocket, clsSocket.JoinString(SendSocket.EXIT, clsMisc.GetIP()));       
    }
    private void ClearConectSocket()
    {
        try
        {
            Logger.TranferDataLog("ClearConectSocket");
            if (ClientSocket != null)
            {
                if (!ClientSocket.Connected)
                ClientSocket.Disconnect(true);
                ClientSocket.Close(100);
                ClientSocket.Dispose();
                
            }
        }
        catch (Exception ex)
        {
            Logger.TranferDataLog("ClearConectSocket Error " + ex.Message);
        }
    }
      /// <summary>
      /// Chờ để hứng data
      /// </summary>
      /// <param name="socket"></param>
        public void ClientWaitData()
        {
            try
            {
                isCallRecieptData = false;
                if (ClientSocket == null)
                    return;
                if (tfClientCallBack == null)
                    tfClientCallBack = new AsyncCallback(ClientDataReceived);
                SocketPacket socPacket = new SocketPacket();
                socPacket.mSocket = ClientSocket;
                ClientSocket.BeginReceive(socPacket.mDataBuffer, 0, socPacket.mDataBuffer.Length, SocketFlags.None, tfClientCallBack, socPacket);
            }
            catch (SocketException ex)
            {
                ClearConectSocket();
            }
            catch (Exception ex)
            {
                isCallRecieptData = true;
                Logger.TranferDataLog(" Client is Wait Data with Error: " + ex.ToString());
            }
        }
      
        /// Client Received data from Server
        /// </summary>
        /// <param name="asyn">IAsyncResult</param>
        public void ClientDataReceived(IAsyncResult asyn)
        {

            try
            {
                SocketPacket socPacket = (SocketPacket)asyn.AsyncState;
                int iRx = socPacket.mSocket.EndReceive(asyn);
                char[] chars = new char[iRx + 1];
                System.Text.Decoder d = System.Text.Encoding.ASCII.GetDecoder();
                int charLen = d.GetChars(socPacket.mDataBuffer, 0, iRx, chars, 0);
                string data = new System.String(chars);
                data = data.Trim();
        //Logger.TranferDataLog(" Reciep -" + data + "-" + DateTime.Now.ToString());
                if (data.Contains("RECEIVE"))
                {
                    TransferSaleDataToServer.GetScriptAndFlusToDataBase();                
                }
                else
                    if (data.Contains("TRANSFER")) // format : TRANSFER -- ra lenh chuyen so lieu
                    {
                        TransferSaleDataToServer.SaveFileAndLog();
                    }

                ClientWaitData();
            }
            catch (SocketException ex)
            {
                Logger.TranferDataLog("SocketException " + ex.ToString());
                ClearConectSocket();
            }
            catch (Exception ex)
            {
                isCallRecieptData = true;
                Logger.TranferDataLog("Error Data ClientDataReceived: " + ex.ToString());
            }
        }
        /// <summary>
        /// Lấy Script từ server và chạy tại client
        /// </summary>
      
    }
}
