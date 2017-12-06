using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;

namespace vnyi.ServiceClient
{
    public class Logger 
    {
        private static string strFileName = @"\logfile_" + DateTime.Now.ToString("dd-MM-yyyy");
        private static int Running = 1;
        public static void TranferDataLog(string str)
        {
            try
            {
                string DirectoryPath = Application.StartupPath + @"\Logfile";                
                if (!Directory.Exists(DirectoryPath))
                    Directory.CreateDirectory(DirectoryPath);

                if (File.Exists(DirectoryPath + strFileName + ".txt"))
                {
                    FileInfo infor = new FileInfo(DirectoryPath + strFileName + ".txt");
                    if (ConvertBytesToMegabytes(infor.Length) >= 10)
                    {
                        strFileName = strFileName + Running.ToString();
                        Running++;
                    }
                }
                TextWriter file = new StreamWriter(DirectoryPath + strFileName + ".txt", true, Encoding.UTF8);
                file.WriteLine(str + Environment.NewLine);
                file.Flush();
                file.Close();
                file.Dispose();
            }
            catch (Exception ex) { ; }
        }
        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

    }
}
