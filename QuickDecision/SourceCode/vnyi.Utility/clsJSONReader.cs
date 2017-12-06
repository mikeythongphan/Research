using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ext.Net;
using System.Data;

namespace vnyi.Utility
{
    public enum enmJSONReaderType
    {
        Created = 1,
        Updated = 2,
        Deleted = 4

    }

    public class clsJSONReader
    {
        private static string _keyUpdated = "\"Updated\":";
        private static string _keyCreated = "\"Created\":";
        private static string _keyDeleted = "\"Deleted\":";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="getType"></param>
        /// <returns></returns>
        public static string GetData(string data, enmJSONReaderType getType)
        {
            string value = "";
            switch (getType)
            {
                case enmJSONReaderType.Created:
                    value = GetCreated(data);
                    break;
                case enmJSONReaderType.Updated:
                    value = GetUpdated(data);
                    break;
                case enmJSONReaderType.Deleted:
                    value = GetDeleted(data);
                    break;
            }
            return value;
        }
        /// <summary>
        /// Convert Qua chuỗi Jsion     
        /// </summary>
        /// <param name="Dt">Data Table</param>        
        /// <returns></returns>
        public static string GetJSONString(DataTable Dt)
        {
            return GetJSONString(Dt, null);
        }

        /// <summary>
        /// Convert Qua chuỗi Jsion     
        /// </summary>
        /// <param name="Dt">Data Table</param>
        /// <param name="TopRecod">Số dòng muốn lấy top nếu muốn lấy hết chuyền null</param>
        /// <returns></returns>
        public static string GetJSONString(DataTable Dt, int? TopRecod)
        {
            string StrJsion = string.Empty;
            int RecodNum = 0;
            if (TopRecod != null)
            {
                if (Dt.Rows.Count >= TopRecod.Value)
                    RecodNum = TopRecod.Value;
            }
            else RecodNum = Dt.Rows.Count;
            if (RecodNum > 0)
            {
                StringBuilder Sb = new StringBuilder();
                Sb.Append("{\"" + Dt.TableName + "\" :");
                Sb.Append(GetjsonStringRecord(Dt, RecodNum));
                Sb.Append("}");
                StrJsion = Sb.ToString();
            }
            return StrJsion;
        }

        /// <summary>
        /// Tạo json chi co reco của DataTable
        /// </summary>
        /// <param name="Dt"></param>
        /// <param name="TopRecod"></param>
        /// <returns></returns>
        public static string GetjsonStringRecord(DataTable Dt, int? TopRecod)
        {
            if (TopRecod == null)
                TopRecod = Dt.Rows.Count;
            StringBuilder Sb = new StringBuilder();
            string[] StrDc = new string[Dt.Columns.Count];
            string HeadStr = string.Empty;

            for (int i = 0; i < Dt.Columns.Count; i++)
            {

                StrDc[i] = Dt.Columns[i].Caption;

                HeadStr += "\"" + StrDc[i] + "\" : \"" + StrDc[i] + i.ToString() + "¾" + "\",";
            }
            HeadStr = HeadStr.Trim(',');
            Sb.Append(" [");
            for (int i = 0; i < TopRecod; i++)
            {

                string TempStr = HeadStr;
                Sb.Append("{");

                for (int j = 0; j < Dt.Columns.Count; j++)
                {

                    if (Dt.Rows[i][j].GetType() == typeof(decimal))
                        TempStr = TempStr.Replace(Dt.Columns[j] + j.ToString() + "¾",clsFormat.DecimalToString(Dt.Rows[i][j]));
                    else if (Dt.Rows[i][j].GetType() == typeof(bool))
                    {
                        if (clsFormat.BooleanConvert(Dt.Rows[i][j]) == true)
                            TempStr = TempStr.Replace(Dt.Columns[j] + j.ToString() + "¾", "1");
                        else TempStr = TempStr.Replace(Dt.Columns[j] + j.ToString() + "¾", "0");
                    }
                    else TempStr = TempStr.Replace(Dt.Columns[j] + j.ToString() + "¾", Dt.Rows[i][j].ToString());

                }

                Sb.Append(TempStr + "},");
            }
            Sb = new StringBuilder(Sb.ToString().Substring(0, Sb.ToString().Length - 1));
            Sb.Append("]");
            return Sb.ToString();
        }
        public static string getJsonFromRow(DataRow dr)
        {
            string[] StrDc = new string[dr.Table.Columns.Count];
            string HeadStr = string.Empty;
            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {

                StrDc[i] = dr.Table.Columns[i].Caption;

                HeadStr += "\"" + StrDc[i] + "\" : \"" + StrDc[i] + i.ToString() + "¾" + "\",";
            }
            HeadStr = HeadStr.Substring(0, HeadStr.Length - 1);
            StringBuilder Sb = new StringBuilder();
            string TempStr = HeadStr;
            Sb.Append("{");
            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {
                if (dr.Table.Columns[i].DataType == typeof(decimal))
                    TempStr = TempStr.Replace(dr.Table.Columns[i] + i.ToString() + "¾", clsFormat.removeComma(dr[i]));
                if (dr.Table.Columns[i].DataType == typeof(DateTime))
                {
                    try
                    {
                        if (dr[i] != DBNull.Value)
                            TempStr = TempStr.Replace(dr.Table.Columns[i] + i.ToString() + "¾", ((DateTime)dr[i]).ToString("s"));
                        else TempStr = TempStr.Replace(dr.Table.Columns[i] + i.ToString() + "¾", ((DateTime)dr[i]).ToString("s"));
                    }
                    catch (Exception e)
                    {
                        TempStr = TempStr.Replace(dr.Table.Columns[i] + i.ToString() + "¾", "null");
                    }

                }
                else
                    TempStr = TempStr.Replace(dr.Table.Columns[i] + i.ToString() + "¾", dr[i].ToString());
            }
            Sb.Append(TempStr + "}");
            return Sb.ToString();
        }

        /// <summary>
        /// Lấy chuổi json khi chuyền vào một đối tượng
        /// </summary>
        /// <typeparam name="T">Kiểu Data chuyền vào Là object</typeparam>
        /// <param name="obj">Đối tượng muốn chuyển</param>
        /// <returns></returns>
        public static string GetJsonString<T>(T obj)
        {
            string strJson = JSON.Serialize(obj);
            return strJson;
        }
        /// <summary>
        /// Lay chuoi cap nhat co the chuyen qua dictionary: 
        ///  Dictionary&lt;string, string&gt;[] EntryData = Coolite.Ext.Web.JSON.Deserialize&lt;Dictionary&lt;string, string&gt;[]&gt;(data);
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string GetUpdated(string data)
        {

            string value = "";
            int iMain = data.IndexOf(_keyUpdated);
            if (iMain == -1)
                return "";
            int iOther = -1;

            iOther = data.IndexOf(_keyCreated);
            if (iOther == -1)
                iOther = data.IndexOf(_keyDeleted);

            if (iOther == -1 || iOther < iMain)
                return value = data.Substring(iMain + _keyUpdated.Length).Trim();
            else
                return value = data.Substring(iMain + _keyUpdated.Length, iOther - (iMain + _keyUpdated.Length) - 1).Trim();


        }
        /// <summary>
        /// Lay chuoi tao moi co the chuyen qua dictionary: 
        ///  Dictionary&lt;string, string&gt;[] EntryData = Coolite.Ext.Web.JSON.Deserialize&lt;Dictionary&lt;string, string&gt;[]&gt;(data);
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string GetCreated(string data)
        {
            string value = "";
            int iMain = data.IndexOf(_keyCreated);
            if (iMain == -1)
                return "";
            int iOther = -1;

            iOther = data.IndexOf(_keyUpdated);
            if (iOther == -1)
                iOther = data.IndexOf(_keyDeleted);

            if (iOther == -1 || iOther < iMain)
                return value = data.Substring(iMain + _keyCreated.Length).Trim();
            else
                return value = data.Substring(iMain + _keyCreated.Length, iOther - (iMain + _keyCreated.Length) - 1).Trim();
        }
        /// <summary>
        /// Lay chuoi xoa co the chuyen qua dictionary: 
        /// Dictionary&lt;string, string&gt;[] EntryData = Coolite.Ext.Web.JSON.Deserialize&lt;Dictionary&lt;string, string&gt;[]&gt;(data);
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string GetDeleted(string data)
        {
            string value = "";
            int iMain = data.IndexOf(_keyDeleted);
            if (iMain == -1)
                return "";
            int iOther = -1;

            iOther = data.IndexOf(_keyCreated);
            if (iOther == -1)
                iOther = data.IndexOf(_keyUpdated);

            if (iOther == -1 || iOther < iMain)
                return value = data.Substring(iMain + _keyDeleted.Length).Trim();
            else
                return value = data.Substring(iMain + _keyDeleted.Length, iOther - (iMain + _keyDeleted.Length) - 1).Trim();
        }
    }
}
