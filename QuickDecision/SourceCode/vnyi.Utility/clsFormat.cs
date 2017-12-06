using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.Data;
using System.Collections;

namespace vnyi.Utility
{
    /// <summary>
    /// Dung dinh dang convert giua cac kieu du lieu
    /// </summary>
    public class clsFormat
    {


        public static object GetType(object value)
        {
            object objReturn = null;

            if (clsFormat.DateConvert(value) != DateTime.MaxValue)
            {
                return clsFormat.DateConvert(value);
            }
            else if (clsFormat.Int16Convert(value) != Int16.MinValue)
                return clsFormat.Int16Convert(value);
            else if (clsFormat.IntConvert(value) != Int16.MinValue)
                return clsFormat.IntConvert(value);

            return objReturn;
        }
        /// <summary>
        /// chuyển int qua kiêu string time
        ///
        /// </summary>
        /// <param name="?"></param>
        /// <returns> format hh:mm</returns>
        public static string ConvertIntoTimeString(int iTime)
        {


            string time = iTime.ToString();
            if (time.Length < 4)
                time = "0" + time.Substring(0, 1) + ":" + time.Substring(1, 2);
            else time = time.Substring(0, 2) + ":" + time.Substring(2, 2);
            return time;

        }
        /// <summary>
        /// Convert chính xac kiểu ngày tháng
        /// </summary>
        /// <param name="date">Object Date</param>
        /// <param name="Format">Kiểu định dạng</param>
        /// <returns>DateTime</returns>
        public static DateTime DateParseExact(object date, string Format)
        {
            try
            {
                if (date is DateTime)
                    return (DateTime)date;
                DateTime result = DateTime.ParseExact(date.ToString(), Format,null);
                return result;
            }
            catch (Exception ex)
            {
                return System.Data.SqlTypes.SqlDateTime.MinValue.Value;
            }
        }
        /// <summary>
        /// Convert to Date Time
        /// </summary>
        /// <param name="date"></param>
        /// <returns>DateTime.MaxValue</returns>
        public static DateTime DateConvert(object date)
        {
            try
            {
                if (date is DateTime)
                    return (DateTime)date;
                DateTime result = DateTime.Parse(date.ToString(), CultureInfo.CurrentCulture);
                return result;
            }
            catch (Exception ex)
            {
                return System.Data.SqlTypes.SqlDateTime.MinValue.Value;
            }
        }
        public static DateTime? DateConvertNull(object date)
        {
            try
            {
                if (date == null) return null;
                DateTime d = DateTime.Parse(date.ToString(), CultureInfo.CurrentCulture);
                if (d == DateTime.MinValue || d == DateTime.MaxValue)
                    return null;
                if (date is DateTime)
                    return (DateTime)date;
                return d;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Convert to datetime with culture
        /// </summary>
        /// <param name="date"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static DateTime DateConvert(object date, CultureInfo culture)
        {
            try
            {
                if (culture == null)
                    culture = CultureInfo.CurrentCulture;
                return DateTime.Parse(date.ToString(), culture);
            }
            catch (Exception ex)
            {
                return DateTime.Now;
            }
        }
        /// <summary>
        /// Lấy Tên tháng theo ngôn ngữ hiện tại 
        /// </summary>
        /// <param name="Month"></param>
        /// <returns></returns>
        public static string getMonthName(int? Month, string CultureSufix)
        {
            string monthName = string.Empty;
            if (string.IsNullOrEmpty(CultureSufix))
                CultureSufix = "en-US";
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.GetCultureInfo(CultureSufix);
            monthName = culture.DateTimeFormat.GetMonthName(Month.Value);
            return monthName;
        }

        public static byte ByteConvert(object value)
        {
            try { return Convert.ToByte(value); }
            catch { return 0; }
        }

        public static byte? ByteConvertNull(object value)
        {
            try { return Convert.ToByte(value); }
            catch { return null; }
        }

        /// <summary>
        /// Convert to int
        /// </summary>
        /// <param name="ojb"></param>
        /// <returns>int.Minvalue </returns>
        public static int IntConvert(object obj)
        {
            try
            {
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int? IntConvertNull(object obj)
        {
            try
            {
                return int.Parse(obj.ToString());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Convert to decimal
        /// </summary>
        /// <param name="ojb">String</param>
        /// <returns>Decimal</returns>
        public static decimal DecimalConvert(object obj)
        {
            try
            {
                // return decimal.Parse(Convert.ToString(obj, new CultureInfo("en-US")), new CultureInfo("en-US"));
                //return decimal.Parse(Convert.ToString(obj), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint);
                return Convert.ToDecimal(obj, CultureInfo.GetCultureInfo("en-US"));
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double DoubleConvert(object obj)
        {
            try
            {
                // return decimal.Parse(Convert.ToString(obj, new CultureInfo("en-US")), new CultureInfo("en-US"));
                //return decimal.Parse(Convert.ToString(obj), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint);
                return double.Parse(obj.ToString(), NumberStyles.Float, new CultureInfo("en-US"));
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        /// <summary>
        /// Convert to decimal
        /// </summary>
        /// <param name="ojb">String</param>
        /// <returns>Decimal</returns>
        public static decimal? DecimalConvertNull(object obj)
        {
            try
            {
                if (obj == null)
                    return null;
                // return decimal.Parse(Convert.ToString(obj, new CultureInfo("en-US")), new CultureInfo("en-US"));
                //return decimal.Parse(Convert.ToString(obj), NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint);
                return Convert.ToDecimal(obj, CultureInfo.GetCultureInfo("en-US"));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ojb"></param>
        /// <returns></returns>
        public static Int16 Int16Convert(object ojb)
        {

            try
            {
                return Int16.Parse(ojb.ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static Int16? Int16ConvertNull(object ojb)
        {

            try
            {
                return Int16.Parse(ojb.ToString());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Int64 Int64Convert(object ojb)
        {
            try
            {
                return Int64.Parse(ojb.ToString());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static Int64? Int64ConvertNull(object ojb)
        {
            try
            {
                return Int64.Parse(ojb.ToString());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// convert to string
        /// </summary>
        /// <param name="ojb"></param>
        /// <returns>string.Empty</returns>
        public static string StringConvert(object ojb)
        {
            string str = "";
            try
            {
                str = Convert.ToString(ojb);
                str = str.Replace(',', '.');
                string[] array = str.Split('.');
                str = array[0].ToString();
                if (array.Length == 2)
                    if (Int16Convert(array[1]) > 0)
                        str += String.Format(".{0}", array[1]);
                return str;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        public static string DecimalToString(object ojb)
        {
            // ojb = ojb.ToString().ToString(CultureInfo.GetCultureInfo("en-US"));
            bool flat = false;
            int icount = 1;
            string str = "", strString = "", strend = "";
            if (ojb == null)
                return string.Empty;
            try
            {
                str = Convert.ToString(ojb, CultureInfo.CurrentCulture);
                if (str.StartsWith("-"))
                {
                    flat = true;
                    str = str.Remove(0, 1);
                }
                str = str.Replace(',', '.');
                string[] array = str.Split('.');

                if (array.Length == 2)
                {
                    array[1] = array[1].TrimEnd('0');
                    int type = IntConvert(array[1]);
                    if (type > 0)
                    {
                        strend = String.Format(".{0}", array[1]);
                    }
                }
                if (array[0].Length < 4)
                {
                    strString = array[0] + strend;
                }
                else
                {
                    for (int i = array[0].Length - 1; i >= 0; i--)
                    {
                        if (icount % 3 == 0 && i > 0)
                            strString = String.Format(",{0}{1}", array[0][i], strString);
                        else strString = array[0][i] + strString;
                        icount++;
                    }
                    strString += strend;
                }
                if (flat)
                    strString = String.Format("-{0}", strString);
                return strString;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public static string DecimalToString(object ojb, bool Decimal)
        {
            // ojb = ojb.ToString().ToString(CultureInfo.GetCultureInfo("en-US"));
            bool flat = false;
            int icount = 1;
            string str = "", strString = "", strend = "";
            if (ojb == null)
                return string.Empty;
            //else if (ojb.ToString() == "0")
            //    return string.Empty;
            try
            {
                str = Convert.ToString(ojb, CultureInfo.GetCultureInfo("en-US"));
                if (str.StartsWith("-"))
                {
                    flat = true;
                    str = str.Remove(0, 1);
                }
                str = str.Replace(',', '.');
                string[] array = str.Split('.');

                if (array.Length == 2)
                {
                    array[1] = array[1].TrimEnd('0');
                    int type = IntConvert(array[1]);
                    if (type > 0)
                    {
                        strend = String.Format(".{0}", array[1]);
                    }
                }
                if (array[0].Length < 4)
                {
                    strString = array[0] + strend;
                }
                else
                {
                    for (int i = array[0].Length - 1; i >= 0; i--)
                    {
                        if (icount % 3 == 0 && i > 0)
                            strString = String.Format(",{0}{1}", array[0][i], strString);
                        else strString = array[0][i] + strString;
                        icount++;
                    }
                    if (Decimal)
                    {
                        if (strend.LastIndexOf('.') > -1)
                            strend += "00";
                        else
                            strend += ".00";
                        strend = strend.Substring(0, 3);
                    }
                    strString += strend;
                }
                if (flat)
                    strString = String.Format("-{0}", strString);
                return strString;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// Chuyen qua string 
        /// </summary>
        /// <param name="ojb"></param>
        /// <returns></returns>
        public static string DecimalToStringToReport(object ojb)
        {
            // ojb = ojb.ToString().ToString(CultureInfo.GetCultureInfo("en-US"));
            bool flat = false;
            int icount = 1;
            string str = "", strString = "", strend = "";
            if (ojb == null)
                return string.Empty;
            else if (ojb.ToString() == "0")
                return string.Empty;
            try
            {
                str = Convert.ToString(ojb, CultureInfo.GetCultureInfo("en-US"));
                if (str.StartsWith("-"))
                {
                    flat = true;
                    str = str.Remove(0, 1);
                }
                str = str.Replace(',', '.');
                string[] array = str.Split('.');

                if (array.Length == 2)
                {
                    array[1] = array[1].TrimEnd('0');
                    int type = IntConvert(array[1]);
                    if (type > 0)
                    {
                        strend = String.Format(".{0}", array[1]);
                    }
                }
                if (array[0].Length < 4)
                {
                    strString = array[0] + strend;
                }
                else
                {
                    for (int i = array[0].Length - 1; i >= 0; i--)
                    {
                        if (icount % 3 == 0 && i > 0)
                            strString = String.Format(",{0}{1}", array[0][i], strString);
                        else strString = array[0][i] + strString;
                        icount++;
                    }
                    strString += strend;
                }
                if (flat)
                    strString = String.Format("({0})", strString);
                return strString;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// Bo dau phay khi aua tu SQL > Client
        /// ly do: de dau phay du lieu ko dung, ko render dc du lieu tren luoi
        /// Chi dung cho du lieu decimal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string removeComma(object obj)
        {
            string strIn, strResult, strEnd;
            try
            {
                strIn = obj.ToString();
                strEnd = strIn.Substring(strIn.IndexOf(",") + 1).TrimEnd('0');
                if (strEnd.Length == 0)
                    strResult = strIn.Split(',')[0].ToString();
                else
                    strResult = obj.ToString().Replace(",", ".").TrimEnd('0');
                return strResult;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// chuyển đối tượng qua kiểu bool
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string.Empty</returns>
        public static bool BooleanConvert(object value)
        {
            try
            {
                if (value == null)
                    return false;
                else
                {
                    if (value.GetType().ToString().Equals("System.String"))
                    {
                        string Result = value.ToString().ToLower();
                        if ((Result.Equals("1")) || (Result.Equals("true")))
                            return true;
                        else
                            return false;
                    }
                    else if (value.GetType().ToString().Equals("System.Int32"))
                    {
                        return Convert.ToBoolean(value);
                    }

                }
                return Convert.ToBoolean(value);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// chuyển đối tượng qua kiểu bool
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string.Empty</returns>
        public static bool? BooleanConvertNull(object value)
        {
            try
            {
                if (value == null)
                    return false;
                else
                {
                    if (value.GetType().ToString().Equals("System.String"))
                    {
                        string Result = value.ToString().ToLower();
                        switch (Result)
                        {
                            case "1":
                                return true;
                            case "true":
                                return true;
                            case "0":
                                return false;
                            case "false":
                                return false;
                            default:
                                return null;
                        }
                    }
                    else if (value.GetType().ToString().Equals("System.Int32"))
                    {
                        return Convert.ToBoolean(value);
                    }

                }
                return Convert.ToBoolean(value);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DateTime? DateConvertNull()
        {
            throw new NotImplementedException();
        }

        public static string DateToString(DateTime? dt, RegularType re)
        {
            return String.Format("{0:" + Regular.Get(re).Format + "}", dt);
        }
    }
}
