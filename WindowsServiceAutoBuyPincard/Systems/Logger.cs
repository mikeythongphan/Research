using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public class Logger
    {
        public static string RootLogPath = "";
        static readonly object syncObj = new object();
        static Logger()
        {
            RootLogPath = @"D:\WindowsServiceAutoBuyPincard\";
        }
        public static void Log(string pvMessage)
        {
            lock (syncObj)
            {
                // Log file
                string SubPath = DateTime.Now.ToString("yyyy-MM-dd");
                string FullPath = RootLogPath + @"\" + SubPath + @"\";

                if (!Directory.Exists(FullPath))
                    Directory.CreateDirectory(FullPath);

                string FileName = DateTime.Now.ToString("HH") + ".log";
                StreamWriter swLog;

                if (!File.Exists(FullPath + FileName))
                {
                    swLog = new StreamWriter(FullPath + FileName);
                }
                else
                {
                    swLog = File.AppendText(FullPath + FileName);
                }


                swLog.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt") + ": " + pvMessage);
                swLog.Close();
            }
        }
    }
}
