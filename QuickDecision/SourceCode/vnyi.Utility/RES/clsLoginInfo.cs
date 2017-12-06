using System;
using System.Text;
using vnyi.Library.Sys;

namespace vnyi.Utility.RES
{
    public class clsLoginInfo
    {
        #region Properties
        /// <summary>
        /// Ngôn ngữ Log vào hệ thống
        /// </summary>
        public static Nullable<Int16> Culture = 1;
        /// <summary>
        /// UserID Log vào hệ thống
        /// </summary>
        public static Nullable<int> UserID = 0;
        /// <summary>
        /// UserName Log vào hệ thống
        /// </summary>
        public static string UserName = "nimda";
        /// <summary>
        /// Mật khẩu
        /// </summary>
        public static string PWD = string.Empty;
        /// <summary>
        /// Nhóm User Log vào hệ thống
        /// </summary>
        public static Nullable<int> UserGroupID;
        /// <summary>
        /// ID Đối tượng (Nhân viên,..) Log vào hệ thống
        /// </summary>
        public static Nullable<int> ObjectID;
        /// <summary>
        /// Mã Đối tượng (Nhân viên,..) Log vào hệ thống
        /// </summary>
        public static string ObjectNo;
        /// <summary>
        /// Tên đối tượng Log vào hệ thống
        /// </summary>
        public static string ObjectName = string.Empty;
        /// <summary>
        /// Mã Chi nhánh, trung tâm
        /// </summary>
        public static Nullable<int> BranchID;
        /// <summary>
        /// Tên chi nhánh
        /// </summary>
        public static string BranchName;
        /// <summary>
        /// Mã Khu
        /// </summary>
        public static Nullable<int> AreaID;
        /// <summary>
        /// Tên khu
        /// </summary>
        public static string AreaName;
        /// <summary>
        /// Tên máy
        /// </summary>
        public static string PCName = string.Empty;
        /// <summary>
        /// Địa chỉ IP máy Log vào hệ thống
        /// </summary>
        public static string IPAddress = string.Empty;
        /// <summary>
        /// Thời gian đăng nhập
        /// </summary>
        public static Nullable<DateTime> LoginTime = null;
        /// <summary>
        /// Trạng thái Loggin
        /// </summary>
        public static bool LoggedIn = false;
        /// <summary>
        /// Chế độ LogIn
        /// </summary>
        public static LoginMode Mode = LoginMode.Normal;

        /// <summary>
        /// Nhân viên đăng nhập là nhân viên phục vụ hay không
        /// </summary>
        public static bool b_Waiter = false;

        public enum LoginMode
        {
            Normal = 0
        }

        /// <summary>
        /// POSID
        /// </summary>
        public static int POSID;
        /// <summary>
        /// POSNAME
        /// </summary>
        public static string POSNAME;
        #endregion

        #region "LogIn - LogOut"
        public static bool LogIn(int pUserID, string pUserName, int ObjectID, string pObject_No, string pObject_Name,
                                string pComputerName, string pIPAddress, DateTime pLoginTime,
                                string pPassword, int POSID, string POSNAME, bool bWaiter)
        {
            try
            {
                clsLoginInfo.LoggedIn = true;
                clsLoginInfo.UserID = pUserID;
                clsLoginInfo.UserName = pUserName;
                clsLoginInfo.ObjectID = ObjectID;
                clsLoginInfo.ObjectNo = pObject_No;
                clsLoginInfo.ObjectName = pObject_Name;
                clsLoginInfo.PCName = pComputerName;
                clsLoginInfo.IPAddress = pIPAddress;
                clsLoginInfo.LoginTime = pLoginTime;
                clsLoginInfo.PWD = pPassword;
                clsLoginInfo.Mode = LoginMode.Normal;
                clsLoginInfo.POSID = POSID;
                clsLoginInfo.POSNAME = POSNAME;
                clsLoginInfo.b_Waiter = bWaiter;
                return SaveLog(true);
            }
            catch { return false; }
        }

        public static bool LogOut()
        {
            try
            {
                if (!clsLoginInfo.LoggedIn) return false;
                clsLoginInfo.LoggedIn = false;
                return SaveLog(false);
            }
            catch { return false; }
        }

        private static bool SaveLog(bool pLogIn)
        {
            try
            {
                LOGINHISTORY obj = new LOGINHISTORY();
                obj.UserID = clsLoginInfo.UserID;
                obj.PCNAME = clsLoginInfo.PCName;
                obj.IPADDRESS = clsLoginInfo.IPAddress;
                if (pLogIn)
                    obj.DATETIME = clsLoginInfo.LoginTime;
                else
                    obj.DATETIME = DateTime.Now;
                obj.ISLOGINED = pLogIn;
                obj.RSP_POSID = clsLoginInfo.POSID;
                obj.RSP_NAME = clsLoginInfo.POSNAME;
                return LOGINHISTORYDAO.Insert(obj);
            }
            catch
            {
                return false;
            }
        }

        #endregion

    }
}
