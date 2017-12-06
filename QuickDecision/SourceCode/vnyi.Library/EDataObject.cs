using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using vnyi.DataProvider;
using System.Data.SqlClient;

namespace vnyi.DLL
{
    public partial class DataObject
    {
        /// <summary>
        /// Chuyển qua kiểu Int16 not null
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Int16 ConvertshortInt(object value)
        {      
                return Convert.ToInt16(value);
        }
        /// <summary>
        /// Thực hiện map sqlparramter và value chứa trong DataObject
        /// </summary>
        /// <param name="DataObject">DataObject</param>
        /// <param name="spName">tên store</param>
        /// <returns></returns>
        public static SqlParameter[] MapParramter(DataObject DataObject,string spName)
        {
             System.Data.SqlClient.SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(vnyi.DataProvider.SqlHelper.ConnectString, spName);            
             foreach (SqlParameter item in commandParameters)
             {
                 item.Value = DataObject.getEntityValue(item.ParameterName.Replace("@", ""));
             }
             return commandParameters;
        }
        /// <summary>
        /// Map parramter với object
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="Parramter"></param>
        public static void MapParramter(DataObject obj, ref SqlParameter[] Parramter)
        {
            foreach (SqlParameter item in Parramter)
            {
                string Attribute = item.ParameterName.Replace("@", "");
                if (obj.CheckAttributeContent(Attribute))
                    item.Value = obj.getEntityValue(Attribute);

            }
        }
        public static Nullable<Int16> ConvertToInt16(object value)
        {
            try
            {
                
                if (value == null)
                    return null;
                short result = Convert.ToInt16(value);              
                return result;
            }
            catch { return null; }
        }

        /// <summary>
        /// Convert qua null giữ nguyên gia trị -1
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Nullable<Int16> ConvertToInt16Type1(object value)
        {
            try
            {
                if (value == null) return null;
                short result = Convert.ToInt16(value);
                return result;
            }
            catch { return null; }
        }
        public static int? ConvertToInt32(object value)
        {
            try
            {
                if (value == null) return null;
                int result = Convert.ToInt32(value);
               // if (result == -1) return null;
                return result;
            }
            catch { return null; }
        }
        /// <summary>
        /// Comvert to int 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ConvertToInt(object value)
        {
            try
            {
                int result = Convert.ToInt32(value);
                return result;
            }
            catch (Exception ex)
            {
                return 0;

            }
        }
        public static Nullable<Int64> ConvertToInt64(object value)
        {
            try
            {
                if (value == null) return null;
                long result = Convert.ToInt64(value);
                if (result == -1) return null;
                return result;
            }
            catch { return null; }
        }
        public static String ConvertToString(object value)
        {
            try
            {
                if (value == null || value == string.Empty || value.ToString().Trim().Equals("")) return null;
                return value.ToString();
            }
            catch { return null; }
        }
        public static Int64 ConvertInt64(object value)
        {
            try
            {
                if (value == null) return -1;
                long result = Convert.ToInt64(value);
                return result;
            }
            catch { return 0; }
        }
        public static bool ConvertToBoolean(object value)
        {
            try
            {
                if (value == DBNull.Value)
                    return false;
                return Convert.ToBoolean(value);
            }
            catch { return false; }
        }
        public static Nullable<DateTime> ConvertToDateTime(object value)
        {
            try
            {
                DateTime Timer = DateTime.MinValue;
                if (value == null) return null;
                Timer = Convert.ToDateTime(value);
                if (Timer == DateTime.MinValue || Timer == DateTime.MaxValue)
                    return null;
                else return Timer;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Chuyển qua date time if null se lay Now
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ConvertToDateTimeNotnull(object value)
        {
            try
            {
                DateTime Timer = DateTime.MinValue;
                if (value == null) return DateTime.Now;
                Timer = Convert.ToDateTime(value);
                if (Timer == DateTime.MinValue || Timer == DateTime.MaxValue)
                    return DateTime.Now;
                else return Timer;
            }
            catch
            {
                return DateTime.Now;
            }
        }
        public static decimal ConvertDecimal(object Value)
        {
            try
            {
                if (Value == null)
                    return 0;
                else
                    return Convert.ToDecimal(Value);
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// convert to ToDouble
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static Double ToDouble(object Value)
        {
            try
            {
                if (Value == null)
                    return 0;
                else
                    return Convert.ToDouble(Value);
            }
            catch
            {
                return 0;
            }
        }
        public static decimal? ConvertDecimalnull(object Value)
        {
            try
            {
                if (Value == null)
                    return null;
                else
                    return Convert.ToDecimal(Value);
            }
            catch
            {
                return null;
            }
        }
        public static byte? ConvertToByte(object value)
        {
            try
            {
                if (value == null) return null;
                return Convert.ToByte(value);
            }
            catch { return null; }
        }

        public static byte[] ConvertToByteArray(object value)
        {
            try
            {
                if (value == null) return null;
                return (byte[])(value);
            }
            catch { return null; }
        }

        public static object GetSafeObjectValue(object dataValue, object nullSafeValue)
        {
           
            return dataValue == DBNull.Value ? nullSafeValue : dataValue == null ? DBNull.Value : dataValue;
        }        
        /// <summary>
        /// Lấy null theo kiểu sql
        /// </summary>
        /// <param name="Value">Giá trị cần kiểm tra</param>
        /// <param name="nullValue">giá trị null</param>
        /// <returns>DBNull if Value==nullValue </returns>
        public static object GetSafeDBValue(object Value, object nullValue)
        {
            return Value == nullValue ? DBNull.Value : Value;
        }
    }
}
