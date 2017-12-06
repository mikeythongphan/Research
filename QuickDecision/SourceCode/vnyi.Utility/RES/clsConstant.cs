using System;
using System.Text;

namespace vnyi.Utility.RES
{
    public class clsConstant
    {
        // Date time
        public static DateTime DATETIME_DEFAUT = new DateTime(1800, 1, 1, 0, 0, 1);
        //public static String 

        public static string DATETIME_NULL = "01/01/0001 12:00:00 AM";

        public static string DATETIME_MAX = "01/01/9999 12:00:00 AM";

        /// <summary>
        /// Value ID Column is Null
        /// </summary>
        public static int IDNULL = 0;

        /// <summary>
        /// Format định dạng hiển thị của cột tiền
        /// </summary>
        public static string FormatMoney = "{0:C}";
    }
}
