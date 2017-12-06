using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using vnyi.Library;
using System.Reflection;
using System.Resources;
using vnyi.Library.System.LoginInfor;

namespace vnyi.ManagerError
{
    public class vnyiException
    {
        /// <summary>
        /// Quản lý messager file bao gồm logfile 
        /// </summary>
        /// <param name="ex">Exception</param>
        /// /// <param name="Loginfor">Loginfor</param>
        /// <returns>SqlMessage</returns>
        public static SqlMessage throwException(Exception ex,Int16 ? LangID)
        {
            var context=System.Web.HttpContext.Current.Request;
            
            if (LangID == null)
                LangID = 1;
            SqlMessage meResul = null;
            if (ex is SqlException)
                meResul=SqlException((SqlException)ex);
            List<ExtendedProperties> Properties = new List<ExtendedProperties>();
            Properties.Add(new ExtendedProperties
            { Key="Page",
              Value = context.RawUrl.Substring(context.RawUrl.LastIndexOf('/') + 1)
            });
            Logger.Write(ex, Properties);
            if (meResul == null)
            {
                meResul = new SqlMessage
                  {
                      Status = sqlMessagerType.SystemError,
                      Title = ex.GetType().FullName,
                      Message = ex.Message,
                      ExceptionMesseger = ex.ToString()
                  };
            }
            
            return meResul;
        }
        private static SqlMessage SqlException(SqlException ex)
        {   
            SqlMessage meResul = new SqlMessage
            {
                Status = sqlMessagerType.SystemError,
                Title = ex.GetType().FullName,
                Message =ex.Message,
                ExceptionMesseger = ex.ToString()
            };
            //ex.GetHashCode();
            switch (ex.Number)
            {
                case 4060: // Database không hợp lệ
                    meResul.Message = "Database không tồn tại, vui lòng kiểm tra hoặc liên hệ với admin !";
                    break;
                case 18456: // không Đăng nhập sql 
                    meResul.Message = "không Đăng nhập sql, vui lòng kiểm tra lại server sql trước khi chạy";
                    break;
                case 547: // Ràng buộc khóa ngoại 
                    meResul.Message = "Ràng buộc khóa ngoại, vui lòng kiểm tra lại !";
                    break;
                case 2627: // trùng khóa chính
                    meResul.Message = "Trùng khóa chính , vui lòng kiểm tra lại khóa chính";
                    break;
                case 2601: // Unique Index/Constriant Violation 
                    meResul.Message = "Unique Index/Constriant Violation";
                    break;
                case 50000:
                    meResul.Message = "Vui lòng kiểm tra lại dữ liệu trước khi lưu";
                    break;
                default:
                    break;
            }
            return meResul;
        }
        private static SqlMessage SqlException(SystemException ex)
        {
            SqlMessage meResul = new SqlMessage
            {
                Status = sqlMessagerType.SystemError,
                Title = ex.GetType().FullName,
                Message = ex.Message,
                ExceptionMesseger = ex.ToString()
            };
           
            return meResul;
        }
        /// <summary>
        /// ArgumentException	An argument to a method was invalid.
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static SqlMessage SqlException(ArgumentException ex)
        {
            SqlMessage meResul = new SqlMessage
            {
                Status = sqlMessagerType.SystemError,
                Title = ex.GetType().FullName,
                Message =ex.Message,
                ExceptionMesseger = ex.ToString()
            };

            return meResul;
        }
        /// <summary>
        /// ArgumentNullException	A null argument was passed to a method that doesn't accept it.
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static SqlMessage SqlException(ArgumentNullException ex)
        {
            SqlMessage meResul = new SqlMessage
            {
                Status = sqlMessagerType.SystemError,
                Title = ex.GetType().FullName,
                Message =ex.Message,
                ExceptionMesseger = ex.Message
            };

            return meResul;
        }       

    }
}
