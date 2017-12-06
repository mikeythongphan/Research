using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using vnyi.Utility.RES;
using vnyi.Library.RES;
using vnyi.Utility;
using System.IO;

namespace vnyi.ServiceClient
{
    public class Utility
    {

        public static string GetConfigValue(SettingsKey Key)
        {
            string FileName = StartupPath + @"\Configs\ServiceConfig.xml";
            string value = clsSysUtils.ReadSetting(FileName, Key.ToString());
         //   Logger.TranferDataLog("valueKey "+ Key.ToString() + " " + value);
            return value;
        }
        /// <summary>
        /// Lấy link config
        /// </summary>
        public static string StartupPath
        {
            get
            {
                return System.Windows.Forms.Application.StartupPath ;
            }
        }
        public static string SaveFilePath
        {
            get
            {
                return StartupPath + @"\Configs\Data";
            }
        }
        /// <summary>
        /// Lấy key cho client này
        /// </summary>
        public static string getKey
        {
            get
            {
                return WriteCacheKey();
            }
        }
        public static string ComputerName
        {
            get
            {
                return clsMisc.GetComputerName();
            }
        }
        /// <summary>
        /// Lấy mã chi nhánh hiện tại
        /// </summary>
        public static int BranchID
        {
            get
            {
                return clsFormat.IntConvert(Utility.GetConfigValue(SettingsKey.BranchID));
            }
        }
        private static string Key = string.Empty;
        private static string WriteCacheKey()
        {
            
                if (string.IsNullOrEmpty(Key))
                {
                    string strFileName = System.Windows.Forms.Application.StartupPath + @"\Configs\SetupConfig.xml";
                    DataSet ds = new DataSet();
                    if (System.IO.File.Exists(strFileName))
                    {
                        try
                        {
                            ds.ReadXml(strFileName);
                            if (ds.Tables.Count > 0)
                                if (ds.Tables[0].Rows.Count > 0)
                                    Key = ds.Tables[0].Rows[0]["Key"].ToString();
                        }
                        catch (Exception ex)
                        {
                            Logger.TranferDataLog("Read file Error" + ex.Message);
                            System.IO.File.Delete(strFileName);
                            Key = string.Empty;
                        }
                    }
                    else
                    {
                        try
                        {                            
                            Key= System.Guid.NewGuid().ToString();                          
                            ds.Tables.Add();
                            ds.Tables[0].Columns.Add(new DataColumn("Key"));
                            DataRow row = ds.Tables[0].NewRow();
                            row["Key"] = Key;
                            ds.Tables[0].Rows.Add(row);
                            ds.WriteXml(strFileName);
                            ds.Dispose();
                        }
                        catch (Exception ex)
                        {
                            Logger.TranferDataLog("Write file Error" + ex.Message);
                        }
                    }
                }
                return Key;        
        }
        /// <summary>
        /// Lấy thông tin của cau kết nối
        /// </summary>
        /// <returns></returns>
        public static Conection getConection()
        {
            Conection conect = null;
            try
            {
                if (!File.Exists(clsGlobal.S_FILECONNECT)) return conect;
                DataSet ds = new DataSet();
                ds.ReadXml(clsGlobal.S_FILECONNECT);
                if (ds != null)
                    if (ds.Tables.Count > 0)
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = ds.Tables[0].Select(DBCONNECT.COLUMN_ACTIVE + "=True")[0];
                            if (dr != null)
                            {
                                conect = new Conection
                                {
                                    DataBase = dr[DBCONNECT.COLUMN_DATABASES].ToString(),
                                    ServerName = dr[DBCONNECT.COLUMN_SERVERS].ToString(),
                                    Uid = Cryptography.DecryptData(dr[DBCONNECT.COLUMN_UID].ToString()),
                                    Pwd = Cryptography.DecryptData(dr[DBCONNECT.COLUMN_PASSWORD].ToString())
                                };
                            }

                        }


            }
            catch (Exception ex)
            {
                conect = null;
                Logger.TranferDataLog("Load Config Error " + ex.ToString() + "_" + DateTime.Now.ToString());
            }
            return conect;

        }
        /// <summary>
        /// Lấy câu kết nối với server
        /// </summary>
        /// <returns></returns>
        public static bool LoadDataConfig()
        {            
            bool isFlat = false;
            try
            {
                if (!File.Exists(clsGlobal.S_FILECONNECT)) return false;
                DataSet ds = new DataSet();
                ds.ReadXml(clsGlobal.S_FILECONNECT);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Select(DBCONNECT.COLUMN_ACTIVE + "=True")[0];
                        clsGlobal.SetConnection(dr[DBCONNECT.COLUMN_SERVERS].ToString(),
                            dr[DBCONNECT.COLUMN_DATABASES].ToString(),
                            Cryptography.DecryptData(dr[DBCONNECT.COLUMN_UID].ToString()),
                            Cryptography.DecryptData(dr[DBCONNECT.COLUMN_PASSWORD].ToString())
                            );
                        isFlat = true;
                    }


                }
            }
            catch (Exception ex)
            {
                Logger.TranferDataLog("Load config Error " + ex.ToString());
            }
            return isFlat;
        }
        /// <summary>
    }
    public class TimersRun
    {
        private int beginHour = 23, beginMinute=0;
        /// <summary>
        /// Giờ bắt đầu chạy
        /// </summary>
        public int BeginHour
        {
            get
            {
                return beginHour;
            }
            set
            {
                beginHour = value;
            }

        }
        /// <summary>
        /// Phút bắt đầu chạy
        /// </summary>
        public  int BeginMinute
        {
            get
            {

                return beginMinute;
            }
            set
            {
                beginMinute = value;
            }
        }
    }
  
    /// Một số key của file ServiceConfig
    /// </summary>
    public enum SettingsKey
    {
        /// <summary>
        /// Mã chi nhánh
        /// </summary>
        BranchID,
        /// <summary>
        /// IP máy chủ
        /// </summary>
        S_SERVERIP,
        /// <summary>
        /// Sử dụng chuyền nhận số liệu
        /// </summary>
        ISTRANFER,
        /// <summary>
        /// Thông báo từ server: hãy nhận dữ liệu
        /// </summary>
        RECEIVE,
        /// <summary>
        /// Port : server
        /// </summary>
        SERVERPORT,
        /// <summary>
        /// Số record chuyển mỗi lần
        /// </summary>
        RECORDTRAN,
        /// <summary>
        /// Làm server chuyền số liệu
        /// </summary>
        ISERVERTRAN,
        /// <summary>
        /// Thời gian chuyền
        /// </summary>
        TimeBeginTransfer,
        /// <summary>
        /// Ngôn ngữ sử dụng
        /// </summary>
        LANG_AUTOID,
        TOPRECORD,
        ServiceUrl
    }
    /// <summary>
    /// Quản lý kết nối
    /// </summary>
    public class Conection
    {
        /// <summary>
        /// Tên server
        /// </summary>
        public string ServerName
        {
            get;
            set;
        }
        /// <summary>
        /// Tên dataBase
        /// </summary>
        public string DataBase
        {
            get;
            set;
        }
        /// <summary>
        /// User Kết nối
        /// </summary>
        public string Uid
        {
            get;
            set;
        }
        /// <summary>
        /// Mật khẩu đăng nhập
        /// </summary>
        public string Pwd
        {
            get;
            set;
        }
    }
}
