using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;
using System.Timers;
using vnyi.Library.RES;
using vnyi.Utility.RES;
using vnyi.Utility;

namespace vnyi.ServiceClient
{
    public partial class ServiceClient : ServiceBase
    {
        private static bool isTimerTransferRun = true;
        private static List<TimersRun> ListTimer = new List<TimersRun>(); 
        public ServiceClient()
        {
            InitializeComponent();
        }
        private void StopService()
        {
            timer.Stop();
            clsSocket.SendToServer(ClientSocket, clsSocket.JoinString(SendSocket.EXIT, clsMisc.GetIP()));
        }
        protected override void OnStart(string[] args)
        {
            try
            {
               // Logger.TranferDataLog("Start Service" + DateTime.Now.ToString());
                bool IsLoadConfig = false;
                do
                    IsLoadConfig = Utility.LoadDataConfig();
                while (!IsLoadConfig);
                timer.Enabled = true;
                timer.Interval = 6000;
                timer.Elapsed += new ElapsedEventHandler(timerTransfer);
                
            
            }
            catch (Exception ex)
            {
                Logger.TranferDataLog("Star Error" + ex.ToString());
            }
        }
        protected override void OnPause()
        {
            timer.Stop();
            clsSocket.SendToServer(ClientSocket, clsSocket.JoinString(SendSocket.EXIT, clsMisc.GetIP()));
            base.OnPause();
        }

        protected override void OnStop()
        {
            StopService();
        }
        /// <summary>
        /// Kiểm tra giờ hiện tại để được chuyền số liệu hay không
        /// </summary>
        /// <param name="Now"></param>
        /// <returns></returns>
        private bool CheckTimerTransfer(DateTime Now)
        {
            if (ListTimer.Count <= 0)
            {
                string strTime = Utility.GetConfigValue(SettingsKey.TimeBeginTransfer);
                strTime = strTime.Trim();
                string[] TimeAr = strTime.Split(';');
                foreach (string item in TimeAr)
                {
                    try
                    {
                        string[] arrg = item.Trim(';').Trim(':').Trim().Split(':');
                        if (arrg.Length >= 1)
                        {
                            TimersRun time = new TimersRun();
                            time.BeginHour = clsFormat.IntConvert(arrg[0]);
                            if (arrg.Length >= 2)
                                time.BeginMinute = clsFormat.IntConvert(arrg[1]);
                            ListTimer.Add(time);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.TranferDataLog("Add Time Error " + ex.Message);
                    }

                }
            }
            bool isTrue = false;
            foreach (TimersRun item in ListTimer)
            {
                if (item.BeginHour == Now.Hour && item.BeginMinute == Now.Minute)
                    isTrue = true;
            }         
            return isTrue;
        }
        private void timerTransfer(object sender, ElapsedEventArgs e)
        {
            try
            {
             // Logger.TranferDataLog("Timmer run" + DateTime.Now.ToString());
                ConecServer();
            //  Logger.TranferDataLog("isTimerTransferRun" + isTimerTransferRun.ToString() + " " + DateTime.Now.ToString());
                if (isTimerTransferRun)// && CheckTimerTransfer(DateTime.Now))
                {
                //   Logger.TranferDataLog("Timmer run" + DateTime.Now.ToString());
                    isTimerTransferRun = false;
                    TransferSaleDataToServer.SaveFileAndLog();                    
                    isTimerTransferRun = true;                   
                }                
                TransferSaleDataToServer.TransferFileDataToServer();
                TransferSaleDataToServer.RunScripFile();
            }
            catch (Exception ex)
            {

                Logger.TranferDataLog("Timmer run Error" + ex.Message);
            }            

        }
    

    }
}
