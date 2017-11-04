using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryData
{
    /// <summary>
    /// Chua cac chuoi ket noi den cac database
    /// </summary>
    public class Connection
    {
        public static string sConnectionStringDatabase = string.Empty;
        public static string sConnectionString_Report = "Data Source=serv2.simpay.com.vn,3232;Initial Catalog=DB_REPORTS;Connect Timeout=200;User id=erpx;Password=!erp23??";
        public static string sConnectionString_System = "Data Source=serv2.simpay.com.vn,3232;Initial Catalog=DB_USER_ROLE_PERMISSION;Connect Timeout=200;User id=erpx;Password=!erp23??";
        public static string sConnectionString_Viettel = "Data Source=192.168.1.19,1433;Initial Catalog=viettel;Connect Timeout=200;User id=duy;Password=duy";
        public static string sConnectionString_VinaEZPay = "Data Source=192.168.1.19,1433;Initial Catalog=VinaEZPay;Connect Timeout=200;User id=duy;Password=duy";
        public static string sConnectionString_Viettel_History = "Data Source=serv2.simpay.com.vn,3232;Initial Catalog=DB_VIETTEL_HISTORY;Connect Timeout=200;User id=erpx;Password=!erp23??";
        public static string sConnectionString_EWallet = "Data Source=serv2.simpay.com.vn,3232;Initial Catalog=DB_EWALLET;Connect Timeout=200;User id=erpx;Password=!erp23??";
        public static string sConnectionString_ViettelAnypay = "Data Source=192.168.1.19,1433;Initial Catalog=ViettelPostpaidAnypay;Connect Timeout=200;User id=duy;Password=duy";
    }
}
