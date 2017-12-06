using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vnyi.Utility
{
    /// <summary>
    /// Một số hàm so sánh 
    /// </summary>
    public class CompareTo
    {
        /// <summary>
        /// So sánh 2 chuỗi với nhau null hoặc Empty không tính
        /// </summary>
        /// <param name="Parram1">chuỗi 1</param>
        /// <param name="Parram2">chuỗi 2</param>
        /// <returns>
        /// Trả về kiểu int:
        /// 1 :hai chuỗi = nhau và không null 
        /// 2: chuỗi 1 null or Empty
        ///  3: chuỗi 2 null or Empty
        /// 4 : 2 chuỗi k0 bằng nhau và không null
        /// </returns>
        public static int CompareNotEmpty(string Parram1, string Parram2)
        {
            int status = 1;
            if (!CheckNotEmpty(Parram1))
                status = 2;
            else
                if (!CheckNotEmpty(Parram2))
                    status = 3;
                else
                    if (Parram1 != Parram2)
                        status = 4;
            return status;
        }
        /// <summary>
        /// Kiểm tra chuỗi parram1 not null và Empty
        /// </summary>
        /// <param name="parram1"></param>
        /// <returns></returns>
        public static bool CheckNotEmpty(string parram1)
        {
            return !string.IsNullOrEmpty(parram1);
        }
    }
}
