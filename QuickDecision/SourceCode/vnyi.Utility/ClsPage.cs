using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vnyi.Utility
{
    public class clsPage
    {
        /// <summary>
        /// Lấy ra Tên trang với đường dẫn
        /// </summary>
        /// <returns></returns>
        public static string GetPageName(string RawUrl)
        {
            try
            {
                if (string.IsNullOrEmpty(RawUrl))
                    return null;
                string strPageName = "";
                if (RawUrl.Contains("/"))
                {
                    if(RawUrl.Contains(".aspx"))
                    strPageName = RawUrl.Substring(0, RawUrl.LastIndexOf(".aspx"));
                    else
                        if (RawUrl.Contains(".ascx"))
                        strPageName = RawUrl.Substring(0, RawUrl.LastIndexOf(".ascx"));
                    int StartIndex = strPageName.LastIndexOf("/")+1;
                    strPageName = strPageName.Substring(StartIndex, strPageName.Length - StartIndex);

                }
                else strPageName = RawUrl;
                return strPageName.Trim();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Lấy ra Mã ngôn ngữ mà UserLog vào
        /// </summary>
        /// <returns></returns>
        public static Int16 GetLangID(Int16? Culture)
        {
            Int16 LangID = 1;
            if (Culture != null)
                LangID = Culture.Value;
            return LangID;
        }

    }
}
