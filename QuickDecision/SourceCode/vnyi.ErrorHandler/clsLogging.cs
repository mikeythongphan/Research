using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;
using System.IO;
namespace vnyi.ManagerError
{
    /// <summary>
    /// Ghi log
    /// </summary>
    public class Logger
    {

        /// <summary>
        /// Lấy File Path
        /// </summary>
        private static string FilePath
        {
            get
            {
                return System.IO.Path.Combine(context.Server.MapPath("~"), ErrorDirectory, "ErrorFile" + DateTime.Now.ToString("yyyy_MM_dd") + ".xml"); ;
            }
        }
        /// <summary>
        /// Lấy thư mục chứa File Error
        /// </summary>
        private static string ErrorDirectory
        {
            get
            {
                return ConfigurationManager.AppSettings["LogFolder"];
            }
        }
        /// <summary>
        /// Lấy current context
        /// </summary>
        private static System.Web.HttpContext context
        {
            get
            {
                return System.Web.HttpContext.Current;
            }          

        }      
        public static void Write(Exception ex, List<ExtendedProperties> Properties)
        {
            string Content = CreateLogTemplate(ex, Properties);
            WriteEntry(Content);
        }
        //public static void Write(Exception wex)
        //{
        //    string msgFormat = ConfigurationManager.AppSettings["LogMsgFormat"];
        //    string Entry = string.Format(msgFormat, wex.Message, wex.GetType(), wex.Message, string.Empty);
        //    WriteEntry(Entry);
        //}
        private static void WriteEntry(string Entry)
        {
            if (!string.IsNullOrEmpty(Entry))
            {
                string FileP = FilePath;
                //if (!File.Exists(FileP))
                //{
                //    File.Create(FileP);
                //}
                using (StreamWriter Stream = new StreamWriter(FileP, true))
                {
                    Stream.Write(Entry);
                    Stream.Flush();
                    Stream.Dispose();
                }
            }
        }
        private static string CreateLogTemplate(Exception ex, List<ExtendedProperties> Properties)
        {

            string Template = "<LogEntry>";
            Template += Environment.NewLine;
            Template += "<Logtime>" + Environment.NewLine + DateTime.Now.ToString("dd/MM/yyyy hh:mm") + Environment.NewLine + "</Logtime>";
            Template += Environment.NewLine;
            Template += "<Title>" + Environment.NewLine + ex.GetType().FullName + Environment.NewLine + "</Title>";
            Template += Environment.NewLine;
            Template += "<Message>" + Environment.NewLine + ex.Message + Environment.NewLine + "</Message>";
            Template += Environment.NewLine;
            Template += "<ExceptionMesseger>" + Environment.NewLine + ex.ToString() + Environment.NewLine + "</ExceptionMesseger>";
            Template += Environment.NewLine;
            foreach (ExtendedProperties item in Properties)
            {
                Template += "<" + item.Key + ">" + Environment.NewLine + System.Web.HttpUtility.HtmlEncode(item.Value)+ Environment.NewLine + "</" + item.Key + ">";
                Template += Environment.NewLine;
            }
            Template += "</LogEntry>";
            Template += Environment.NewLine;
            return Template;
        }
        /// <summary>
        /// Lấy danh sách File Lỗi
        /// </summary>
        /// <returns></returns>
        public static List<FileInfo> GetAllFileError()
        {

            string Direct = System.IO.Path.Combine(context.Server.MapPath("~"), ErrorDirectory);
            List<FileInfo> Resul = new List<FileInfo>();
            if (!Directory.Exists(Direct))
                return Resul;
            string[] filePaths = Directory.GetFiles(Direct, "*.xml", SearchOption.TopDirectoryOnly);
            foreach (string FilePath in filePaths)
            {
                System.IO.FileInfo infor = new System.IO.FileInfo(FilePath);
                if (infor.Exists && infor.Extension == ".xml" && infor.Name.Contains("ErrorFile"))
                {
                    Resul.Add(new FileInfo
                    {
                        CreationTime = infor.CreationTime,
                        LastWriteTime = infor.LastWriteTime,
                        Name = infor.Name,
                        Extension = infor.Extension,
                        LastAccessTime = infor.LastAccessTime,
                        Size = infor.Length
                    });
                }

            }
            return Resul;
        }
        /// <summary>
        /// Đọc file Lỗi
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public static System.Data.DataSet getDataFromFile(string FileName)
        {
            System.Data.DataSet Resul = new System.Data.DataSet();
            string FilePath = System.IO.Path.Combine(context.Server.MapPath("~"), ErrorDirectory, FileName);
            if (File.Exists(FilePath))
            {
               var fileContent = string.Empty;
                using (StreamReader reader = new StreamReader(FilePath, Encoding.UTF8))
                {   
                    fileContent = reader.ReadToEnd();
                }                
                fileContent = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Table>" + fileContent + "</Table>";
                StringReader Reader = new StringReader(fileContent);
                Resul.ReadXml(Reader);
            }

            return Resul;
        }
    }
    public class FileInfo
    {
        public string Name
        {
            get;
            set;
        }
        public string Extension
        {
            get;
            set;
        }
        public DateTime LastWriteTime
        {
            get;
            set;
        }
        public DateTime CreationTime
        {
            get;
            set;
        }
        public DateTime LastAccessTime
        {
            get;
            set;
        }
        public long Size
        {
            get;
            set;
        }




    }
    /// <summary>
    /// Những thuộc tính khác
    /// </summary>
    public class ExtendedProperties
    {
        /// <summary>
        /// Từ khóa 
        /// </summary>
        public string Key
        {
            get;
            set;
        }
        /// <summary>
        /// Giá trị
        /// </summary>
        public object Value
        {
            get;
            set;
        }

    }
}
