using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public class Tools
    {
        static string pathLog = @"D:\WindowsServiceAutoBuyPincard\";
        static object syncObj = new object();

        public static void Logger(String mess, String name, String functionName)
        {
            lock (syncObj)
            {
                try
                {
                    Directory.CreateDirectory(pathLog + DateTime.Now.ToString("yyyy-MM-dd"));
                    StreamWriter sw = new StreamWriter(pathLog + DateTime.Now.ToString("yyyy-MM-dd") + "\\" + DateTime.Now.ToString("MM-dd-HH") + name + ".txt", true);
                    sw.WriteLine(DateTime.Now.ToString("hh-mm-ss") + " : [" + functionName + "] :: " + mess);
                    sw.Flush();
                    sw.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
