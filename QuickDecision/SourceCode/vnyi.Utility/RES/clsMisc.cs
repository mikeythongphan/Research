using System;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace vnyi.Utility.RES
{
    public class clsMisc
    {
        /// <summary>
        /// Lấy IP máy tính
        /// </summary>
        /// <returns></returns>
        public static string GetIP()
        {
            string strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostByName(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[0].ToString();
        }

        /// <summary>
        /// Lay IP may tinh va processID
        /// </summary>
        /// <returns></returns>
        public static string GetIPAndProcessID()
        {
            return GetIP() + ":" + clsGlobal.I_PROCESSID;
        }

        /// <summary>
        /// Lấy tên máy tính
        /// </summary>
        /// <returns></returns>
        public static string GetComputerName()
        {
            return Dns.GetHostName();
        }

        private static char toUpper(char chr)
        {
            return chr.ToString().ToUpper().ToCharArray()[0];
        }

        /// <summary>
        /// Dung để tranlate các kí tự có dấu để hiện thị màn hình VFD
        /// </summary>
        /// <param name="sInputText"></param>
        /// <returns></returns>
        public static string RejectDiacritic(string sInputText)
        {
            char[] chrList = new char[] { 'a', 'e', 'o', 'u', 'i', 'y', 'd' };
            char[] chr = new char[0];
            bool lower;

            for (int i = 0; i < chrList.Length; i++)
            {
                lower = true;
                if (chrList[i] == 'a')
                    chr = new char[] { 'a', 'à', 'á', 'ạ', 'ả', 'ã', 'â', 'ă', 'ấ', 'ầ', 'ậ', 'ẩ', 'ẫ', 'ắ', 'ằ', 'ặ', 'ẳ', 'ẵ' };
                else if (chrList[i] == 'e')
                    chr = new char[] { 'e', 'é', 'è', 'ẹ', 'ẻ', 'ẽ', 'ê', 'ế', 'ề', 'ệ', 'ể', 'ễ' };
                else if (chrList[i] == 'o')
                    chr = new char[] { 'o', 'ó', 'ò', 'ọ', 'ỏ', 'õ', 'ô', 'ố', 'ồ', 'ộ', 'ổ', 'ỗ', 'ơ', 'ớ', 'ờ', 'ợ', 'ở', 'ỡ' };
                else if (chrList[i] == 'u')
                    chr = new char[] { 'u', 'ú', 'ù', 'ụ', 'ủ', 'ũ', 'ư', 'ứ', 'ừ', 'ự', 'ử', 'ữ' };
                else if (chrList[i] == 'i')
                    chr = new char[] { 'i', 'í', 'ì', 'ị', 'ỉ', 'ĩ' };
                else if (chrList[i] == 'y')
                    chr = new char[] { 'y', 'ý', 'ỳ', 'ỵ', 'ỷ', 'ỹ' };
                else if (chrList[i] == 'd')
                    chr = new char[] { 'd', 'đ' };

                for (int j = 1; j < chr.Length; j++)
                {
                    sInputText = sInputText.Replace(chr[j], chr[0]);
                    chr[j] = toUpper(chr[j]);
                    if (lower && j == chr.Length - 1)
                    {
                        chr[0] = toUpper(chr[0]);
                        lower = false;
                        j = 0;
                    }
                }
            }
            return sInputText;
        }

        #region Kiểm tra lần cuối user thao tác trên máy (dùng các hàm API của window)

        #region Cac bien toan cu
        public const int WM_NCLBUTTONDOWN = 0xa1;
        public const int HTCAPTION = 2;
        [StructLayout(LayoutKind.Sequential)]
        public struct LASTINPUTINFO
        {
            public static readonly int SizeOf = Marshal.SizeOf(typeof(LASTINPUTINFO));

            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dwTime;
        }

        #endregion

        #region user32
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, int msg, uint wparam, uint lparam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        public static int GetLastInputTime()
        {
            int nIdleTime = 0;
            LASTINPUTINFO liiInfo = new LASTINPUTINFO();
            liiInfo.cbSize = Marshal.SizeOf(liiInfo);
            liiInfo.dwTime = 0;
            int nEnvTicks = Environment.TickCount;
            if (GetLastInputInfo(ref liiInfo))
            {
                int nLastInputTick = (int)liiInfo.dwTime;
                nIdleTime = nEnvTicks - nLastInputTick;
            }
            return ((nIdleTime > 0) ? (nIdleTime / 1000) : nIdleTime);
        }
        #endregion

        #endregion

        #region Cài đặt dịch vụ trong window
        /// <summary>
        /// Create a Windows service when it does not exist, else configure it.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="binPath"></param>
        /// <param name="userName"></param>
        /// <param name="unecryptedPassword"></param>
        /// <param name="startupType"></param>
        /// <param name="type"></param>
        public static void runProcess(string displayName, string binPath, string userName, string unecryptedPassword, ServiceStartUpType startupType,
            ServiceAction type)
        {
            // Determine if service has to be created (Create) or edited (Config)
            StringBuilder builder = new StringBuilder();

            switch (type)
            {
                case ServiceAction.create:
                    builder.AppendFormat("{0} {1} ", type.ToString(), displayName);
                    builder.AppendFormat("binPath= \"{0}\"  ", binPath);
                    //builder.AppendFormat("displayName= \"{0}\"  ", displayName);

                    // Only add "obj" when username is not empty. If omitted the "Local System" account will be used
                    if (!string.IsNullOrEmpty(userName))
                    {
                        builder.AppendFormat("obj= \"{0}\"  ", userName);
                    }

                    // Only add password when unecryptedPassword it is not empty and user name is not "NT AUTHORITY\Local Service" or NT AUTHORITY\NetworkService
                    if (!string.IsNullOrEmpty(unecryptedPassword)
                        && !unecryptedPassword.Equals(@"NT AUTHORITY\Local Service")
                        && !unecryptedPassword.Equals(@"NT AUTHORITY\NetworkService"))
                    {
                        builder.AppendFormat("password= \"{0}\"  ", unecryptedPassword);
                    }
                    builder.AppendFormat("start= \"{0}\"  ", startupType.ToString());
                    break;
                case ServiceAction.Config:
                    builder.AppendFormat("config {0} ", displayName);
                    builder.AppendFormat("start= \"{0}\"  ", startupType.ToString());
                    break;
                case ServiceAction.delete:
                    builder.AppendFormat("{0} {1} ", type.ToString(), displayName);
                    break;
                case ServiceAction.stop:
                    builder.AppendFormat("{0} {1} ", type.ToString(), displayName);
                    break;
                case ServiceAction.start:
                    builder.AppendFormat("{0} {1} ", type.ToString(), displayName);
                    break;
            }
            // Execute sc.exe commando
            using (Process process = new Process())
            {
                process.StartInfo.FileName = @"sc.exe";
                process.StartInfo.Arguments = builder.ToString();
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.Close();
            }

        }

        #endregion
    }

    public enum ServiceStartUpType
    {
        /// <summary>
        /// Automatic
        /// </summary>
        auto,

        /// <summary>
        /// Disabled
        /// </summary>
        disabled,

        /// <summary>
        /// Manual
        /// </summary>
        demand
    }

    public enum ServiceAction
    {
        /// <summary>
        /// Tạo service
        /// </summary>
        create,

        /// <summary>
        /// Sửa cấu hình Service
        /// </summary>
        Config,

        /// <summary>
        /// Xóa Service
        /// </summary>
        delete,

        start,
        stop,
    }

}
