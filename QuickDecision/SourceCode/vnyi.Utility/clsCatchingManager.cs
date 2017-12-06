using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using vnyi.Library.Sys;
namespace vnyi.Utility.CatchingManager
{
    public enum CatchingType
    {
        Messager,
        Control,
        TranferFile
    }
    public class iMessager
    {
        public string Title
        {
            set;
            get;
        }
        public string Messager
        {
            set;
            get;
        }
    }
    public static class Messager
    {

        public static string Msg_TITLE = "Thông báo";
        public static string Msg_ERROR_INPUT = "Vui lòng nhập";
        /// <summary>
        /// Lấy cả dataset cho thông báo
        /// </summary>
        /// <param name="ServerPath"></param>
        /// <param name="LangID"></param>
        /// <param name="PageName"></param>
        /// <returns></returns>
        public static DataSet GetDataSet_Keysearch(string DirectoryPath, Int16 LangID, string PageName)
        {
            DataSet ds = null;
            string CacheName = String.Format("{0}-{1}", PageName, LangID.ToString());
            string FilePath = DirectoryPath + String.Format("\\{0}.xml", CacheName);
            if (File.Exists(FilePath))
            {
                ds = new DataSet();
                System.IO.FileStream fsReadXml = new System.IO.FileStream(FilePath, System.IO.FileMode.Open);
                ds.ReadXml(fsReadXml);
                fsReadXml.Flush();
                fsReadXml.Dispose();
            }
            else
            {
            ds = PAGEDAO.getAllMessagerInPage(PageName, LangID);
            if (!File.Exists(DirectoryPath))
                System.IO.Directory.CreateDirectory(DirectoryPath);
            if (!System.IO.File.Exists(FilePath))
                using (System.IO.FileStream stream = System.IO.File.Create(FilePath, 1024))
                    ds.WriteXml(stream);
            }
            return ds;
        }

        /// <summary>
        /// Nguyen Thai Binh
        /// Dung de load keymessage cua form login va connect khi chua co chuoi ket noi -> chua connect duoc database
        /// </summary>
        /// <param name="DirectoryPath"></param>
        /// <param name="LangID"></param>
        /// <param name="PageName"></param>
        /// <returns></returns>
        public static DataSet GetDataSet_Keysearch_Client(string DirectoryPath, Int16 LangID, string PageName)
        {
            DataSet ds = null;
            string CacheName = String.Format("{0}-{1}", PageName, LangID.ToString());
            string FilePath = DirectoryPath + String.Format("\\{0}.xml", CacheName);
            if (File.Exists(FilePath))
            {
                ds = new DataSet();
                System.IO.FileStream fsReadXml = new System.IO.FileStream(FilePath, System.IO.FileMode.Open);
                ds.ReadXml(fsReadXml);
                fsReadXml.Flush();
                fsReadXml.Dispose();
            }
            else
            {
                ds = PAGEDAO.getAllMessagerInPage(PageName, LangID);
                if (!File.Exists(DirectoryPath))
                    System.IO.Directory.CreateDirectory(DirectoryPath);
                if (!System.IO.File.Exists(FilePath))
                    using (System.IO.FileStream stream = System.IO.File.Create(FilePath, 1024))
                        ds.WriteXml(stream);
            }
            return ds;
        }

        /// <summary>
        /// Lấy thông báo tương ứng với trang, kiểu thông báo và ngôn ngữ 
        /// </summary>
        /// <param name="LangID">Mã ngôn ngữ</param>
        /// <param name="PageName">Tên trang mình muốn lấy</param>
        /// <param name="KeySearch">từ khóa dùng đễ gắn kết</param>
        /// <param name="Title">Out put ra một tiêu đề cho câu thông báo</param>
        /// <returns>trả về một câu thông báo tương ứng với trang hiện tại</returns>
        public static string GetMessager(string ServerPath, Int16 LangID, string PageName, vnyi.Utility.CatchingManager.keyWord.MessagerKey KeySearch, out string Title)
        {
            Title = "";
            string strMessager = KeySearch.ToString();
            DataSet ds = GetDataSet_Keysearch(ServerPath, LangID, PageName);
            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable products = ds.Tables[0];
                IEnumerable<DataRow> results = (
                    from obj in products.AsEnumerable()
                    where obj.Field<string>(MASSAGER.COLUMN_MES_KEYSEARCH).Trim() == KeySearch.ToString().Trim()
                    select obj);
                if (results.Count<DataRow>() > 0)
                {
                    var objR = results.Single();
                    if (objR != null)
                    {
                        strMessager = objR.Field<string>(MESSAGERFORLANG.COLUMN_MESS_NAME);
                        Title = objR.Field<string>(MESSAGERFORLANG.COLUMN_MESS_Title);
                    }
                }
                else
                {
                    strMessager = KeySearch.ToString();//"Plesea insert Record in to sql Database !";
                    Title = "chưa Cập Nhật Data";
                }

            }
            return strMessager;
        }

        public static string GetMessager(string ServerPath, Int16 LangID, string PageName, string KeySearch, out string Title)
        {
            Title = "";
            string strMessager = "";
            DataSet ds = GetDataSet_Keysearch(ServerPath, LangID, PageName);
            if (ds != null && ds.Tables.Count > 0)
            {

                DataTable products = ds.Tables[0];
                IEnumerable<DataRow> results = (
                    from obj in products.AsEnumerable()
                    where obj.Field<string>(MASSAGER.COLUMN_MES_KEYSEARCH).Trim() == KeySearch.ToString().Trim()
                    select obj);

                if (results.Count<DataRow>() > 0)
                {
                    var objR = results.ElementAt(0);
                    if (objR != null)
                    {
                        strMessager = objR.Field<string>(MESSAGERFORLANG.COLUMN_MESS_NAME);
                        Title = objR.Field<string>(MESSAGERFORLANG.COLUMN_MESS_Title);
                    }
                }
                else
                {
                    strMessager = KeySearch;//"Plesea insert Record in to sql Database !";
                    Title = "chưa Cập Nhật Data";
                }
            }
            return strMessager;
        }
        /// <summary>
        /// Lấy key trực tiếp từ sql cho form
        /// </summary>
        /// <param name="Key">từ khóa</param>
        /// <param name="LangID">ngôn ngữ</param>
        /// <returns></returns>
        public static iMessager getMessagerByKey(keyWord.MessagerKey Key, Int16? LangID)
        {
            iMessager mess = new iMessager
            {
                Messager = string.Empty,
                Title = string.Empty
            };
            DataSet ds = new DataSet();
            ds = MASSAGERDAO.getMessagerByKey(Key.ToString(), LangID);
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                {
                    mess.Title = ds.Tables[0].Rows[0]["Title"] != null ? ds.Tables[0].Rows[0]["Title"].ToString() : "";
                    mess.Messager = ds.Tables[0].Rows[0]["Messager"] != null ? ds.Tables[0].Rows[0]["Messager"].ToString() : "";
                }
            return mess;
        }
    }
    public static class CatchControl
    {
        /// <summary>
        /// Lấy tất cả control trên form trả ra dataset
        /// </summary>
        /// <param name="ServerPath"></param>
        /// <param name="LangID"></param>
        /// <param name="PageName"></param>
        /// <param name="Module"></param>
        /// <returns></returns>
        public static DataSet GetDatasetOfControlInPage(string ServerPath, Int16? LangID, string PageName, Int16 Module)
        {
            string CacheName = String.Format("{0}-{1}", PageName, LangID);
            string strFilePath = String.Format("{0}\\{1}.xml", ServerPath, CacheName);
            DataSet ds = null;
            if (File.Exists(strFilePath))
            {
                ds = new DataSet();
                using (System.IO.FileStream fsReadXml = new System.IO.FileStream(strFilePath, System.IO.FileMode.Open))
                {
                    ds.ReadXml(fsReadXml);
                    fsReadXml.Flush();
                    fsReadXml.Dispose();
                }
            }

            if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                ds = PAGEDAO.getAllControlInPage(PageName, LangID, Module);
                if (!Directory.Exists(ServerPath))
                    Directory.CreateDirectory(ServerPath);
                else if (File.Exists(strFilePath))
                    File.Delete(strFilePath);
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        using (System.IO.FileStream stream = System.IO.File.Create(strFilePath, 1024))
                        {
                            ds.WriteXml(stream, XmlWriteMode.WriteSchema);
                            stream.Flush();
                            stream.Dispose();
                        }
            }

            return ds;
        }

        /// <summary>
        /// Lấy tất cả control trên form trả ra dataset (lay tai resouce cua client
        /// </summary>
        /// <param name="ServerPath"></param>
        /// <param name="LangID"></param>
        /// <param name="PageName"></param>
        /// <param name="Module"></param>
        /// <returns></returns>
        public static DataSet GetDatasetOfControlInPage_Client(string ServerPath, Int16? LangID, string PageName, Int16 Module)
        {
            string CacheName = String.Format("{0}-{1}", PageName, LangID);
            string strFilePath = String.Format("{0}\\{1}.xml", ServerPath, CacheName);
            DataSet ds = null;
            if (File.Exists(strFilePath))
            {
                ds = new DataSet();
                using (System.IO.FileStream fsReadXml = new System.IO.FileStream(strFilePath, System.IO.FileMode.Open))
                {
                    ds.ReadXml(fsReadXml);
                    fsReadXml.Flush();
                    fsReadXml.Dispose();
                }
            }

            if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                ds = PAGEDAO.getAllControlInPage(PageName, LangID, Module);
                if (!Directory.Exists(ServerPath))
                    Directory.CreateDirectory(ServerPath);
                else if (File.Exists(strFilePath))
                    File.Delete(strFilePath);
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        using (System.IO.FileStream stream = System.IO.File.Create(strFilePath, 1024))
                        {
                            ds.WriteXml(stream, XmlWriteMode.WriteSchema);
                            stream.Flush();
                            stream.Dispose();
                        }
            }

            return ds;
        }

        /// <summary>
        /// Lấy tất cả Tiêu đề của control trên một trang
        /// 
        /// </summary>
        /// <param name="LangID"></param>
        /// <param name="PageName"></param>
        /// <param name="TitleOfControl"></param>
        /// <param name="Toltip"></param>
        /// <returns></returns>
        public static List<vnyi.Library.Sys.CONTROL> GetControlInPage(string ServerPath, Int16? LangID, string PageName, Int16 Module)
        {
            List<vnyi.Library.Sys.CONTROL> Resul = new List<vnyi.Library.Sys.CONTROL>();
            DataSet ds = GetDatasetOfControlInPage(ServerPath, LangID, PageName, Module);
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        foreach (DataRow row in ds.Tables[0].Rows)
                            Resul.Add(new vnyi.Library.Sys.CONTROL(row));
            return Resul;
        }

        /// <summary>
        /// Lấy tất cả Tiêu đề của control trên một trang tai file resource client
        /// 
        /// </summary>
        /// <param name="LangID"></param>
        /// <param name="PageName"></param>
        /// <param name="TitleOfControl"></param>
        /// <param name="Toltip"></param>
        /// <returns></returns>
        public static List<vnyi.Library.Sys.CONTROL> GetControlInPage_Client(string ServerPath, Int16? LangID, string PageName, Int16 Module)
        {
            List<vnyi.Library.Sys.CONTROL> Resul = new List<vnyi.Library.Sys.CONTROL>();
            DataSet ds = GetDatasetOfControlInPage_Client(ServerPath, LangID, PageName, Module);
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        foreach (DataRow row in ds.Tables[0].Rows)
                            Resul.Add(new vnyi.Library.Sys.CONTROL(row));
            return Resul;
        }

        /// <summary>
        /// Lấy tất cả Tiêu đề của control trên một report dùng cho winform
        /// 
        /// </summary>
        /// <param name="LangID"></param>
        /// <param name="PageName"></param>
        /// <param name="TitleOfControl"></param>
        /// <param name="Toltip"></param>
        /// <returns></returns>
        public static List<CONTROL> GetControlInPage_WF(string FilePath, Int16? LangID, string ReportName, Int16 Module)
        {
            List<vnyi.Library.Sys.CONTROL> Resul = new List<vnyi.Library.Sys.CONTROL>();
            string CacheName = String.Format("{0}-{1}", ReportName, LangID);
            string strPath = String.Format("{0}\\{1}.xml", FilePath, CacheName);
            DataSet ds = null;
            if (File.Exists(strPath))
            {
                ds = new DataSet();
                using (System.IO.FileStream fsReadXml = new System.IO.FileStream(strPath, System.IO.FileMode.Open))
                {
                    ds.ReadXml(fsReadXml);
                    fsReadXml.Flush();
                    fsReadXml.Dispose();
                }
            }
            else
            {
            ds = PAGEDAO.getAllControlInPage(ReportName, LangID, Module);
            string filename = String.Format("{0}", strPath);
            if (!File.Exists(FilePath))
                System.IO.Directory.CreateDirectory(FilePath);
            if (!File.Exists(strPath))
            {
                try
                {
                    using (System.IO.FileStream stream = System.IO.File.Create(strPath, 1024))
                    {
                        ds.WriteXml(stream);
                        stream.Flush();
                        stream.Dispose();
                    }
                }
                catch (Exception ex) { ;}
            }
            }
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        foreach (DataRow row in ds.Tables[0].Rows)
                            Resul.Add(new vnyi.Library.Sys.CONTROL(row));
            return Resul;
        }
    }
}
