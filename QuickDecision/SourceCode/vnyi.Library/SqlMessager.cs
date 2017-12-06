
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using vnyi.DataProvider;

namespace vnyi.Library
{
    public class SqlMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            get;
            set;
        }
        /// <summary>
        /// Mã lỗi trong hệ thống
        /// </summary>
        public int ExceptionNumber
        {
            get;
            set;
        }
        /// <summary>
        /// chi tiết lỗi trong hệ thống
        /// </summary>
        public string ExceptionMesseger
        {
            get;
            set;
        }
        /// <summary>
        /// Trang thái 
        /// </summary>
        public sqlMessagerType Status
        {
            get;
            set;
        }
        /// <summary>
        /// Thông tin nội dung thông báo
        /// </summary>
        public string Message
        {
            get;
            set;
        }
        /// <summary>
        /// Tiêu đề thông báo
        /// </summary>
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        /// Từ khóa thông báo
        /// </summary>
        public string MessagerKey
        {
            get;
            set;
        }

        /// <summary>
        /// đối tượng chuyền lên
        /// </summary>
        public Object ResulObj
        {
            get;
            set;
        }
        public ReturnType returnType
        {
            get;
            set;
        }
    }
    public enum sqlMessagerType
    {
        /// <summary>
        /// Thành công
        /// </summary>
        Success = 1,
        /// <summary>
        /// Lỗi về Data so System quản lý
        /// </summary>
        Error = 2,
        /// <summary>
        /// Lỗi system khi throw exCeption
        /// </summary>
        SystemError = 3,
        /// <summary>
        /// Không phù hợp License
        /// </summary>
        NotValidLicense
    }
    /// <summary>
    /// Dành cho trang thái bị lỗi
    /// </summary>
    public enum ReturnType
    {
        /// <summary>
        ///Lỗi xảy ra khi kiểm quyền 
        /// </summary>
        CheckRole,
        /// <summary>
        /// Cảnh báo Record đã bị thay đổi
        /// </summary>
        RowVesion,
        /// <summary>
        /// Record này đã bị xóa
        /// </summary>
        RecoDelete,
        /// <summary>
        /// Lỗi xảy ra khi kiểm tra data
        /// </summary>
        CheckData,
        /// <summary>
        /// thực thi Sql không thành công
        /// </summary>
        NotExcute,
        /// <summary>
        /// Khổng
        /// </summary>
        NotAcceptData,
        /// <summary>
        /// Bình thường không xảy ra lỗi
        /// </summary>        
        Normal,
        /// <summary>
        /// ID tồn tại
        /// </summary>
        IDExit,
        /// <summary>
        /// d
        /// </summary>
        CommitFalse,
        /// <summary>
        /// Serial đã sử dụng k được xóa chứng từ
        /// </summary>
        UserSerial,
        /// <summary>
        /// Đã tồn tại trong hệ thống
        /// </summary>
        ExitIn,
        /// <summary>
        /// Lỗi của hệ thống
        /// </summary>
        SystemError,
        /// <summary>
        /// Từ chối truy cập
        /// </summary>
        ISDENIED,
        /// <summary>
        /// Liên quan ve trạng thái
        /// </summary>
        Status,
        /// <summary>
        /// Kỳ tài chính đã đóng
        /// </summary>
        FinanIsClose
    }
}