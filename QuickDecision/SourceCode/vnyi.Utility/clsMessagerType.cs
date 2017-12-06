using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Microsoft.Practices.EnterpriseLibrary.Caching;
//using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations;
using System.Data;
namespace vnyi.Utility.CatchingManager
{

    //create by Phongvt
    //Create date 21/03/2009
    //Edit date: 
    //Decsription: Tao cau truc message
    public class Msg
    {
        public List<ErrorForm> ErrorInForm
        {
            get;
            set;
        }
        public List<ErrorGrid> ErrorInGrid
        {
            get;
            set;
        }
        public Msg()
        {
            ErrorInForm = new List<ErrorForm>();
            ErrorInGrid = new List<ErrorGrid>();
        }

        public void add(string ctrl, string message)
        {
            ErrorForm error = new ErrorForm();
            error.Ctrl = ctrl;
            error.Message = message;
            ErrorInForm.Add(error);
        }
        public void add(string grdName, int rowIndex, string colName, string message)
        {
            ErrorGrid error = new ErrorGrid();
            error.GridName = grdName;
            error.RowIndex = rowIndex;
            error.ColName = colName;
            error.Message = message;
            ErrorInGrid.Add(error);
        }
    }
    public class ErrorForm
    {
        public string Ctrl
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
    }
    public class ErrorGrid
    {
        public string GridName
        {
            get;
            set;
        }
        public int RowIndex
        {
            get;
            set;
        }
        public string ColName
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
    }

    public class keyWord
    {
        public enum SessionKey
        {
            /// <summary>
            /// Session User 
            /// </summary>
            us
        }

        /// <summary>
        /// Lấy Kiểu dữ liệu của Massager 
        /// </summary>
        public enum MessagerKey
        {
            #region TimeService
            /// <summary>
            /// Chạy 1 lần
            /// </summary>
            OneTimeOnly,
            /// <summary>
            /// Chạy hàng ngày
            /// </summary>
            Daily,
            /// <summary>
            /// Chạy hàng tuần
            /// </summary>
            Weekly,
            /// <summary>
            /// chạy hàng tháng
            /// </summary>
            Monthly,
            /// <summary>
            /// Đầu tiên
            /// </summary>
            First,
            /// <summary>
            /// Thứ 2
            /// </summary>
            Second,
            /// <summary>
            /// Thứ 3
            /// </summary>
            Third,
            /// <summary>
            /// Thứ 4
            /// </summary>
            Fourth,
            /// <summary>
            /// Cuối cùng
            /// </summary>
            Last,
            /// <summary>
            /// Xuất báo cáo
            /// </summary>
            ExportReport,
            /// <summary>
            /// Gửi mail
            /// </summary>
            SendMail,
            /// <summary>
            /// Thực thi câu lệnh
            /// </summary>
            ExcuteCommand,
            #endregion
            #region REPORT
            /// <summary>
            /// Nhập thông tin trước khi tìm kiếm
            /// </summary>
            ImPortDataBeforSearch,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:STT
            /// </summary>
            index,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Mô tả
            /// </summary>
            description,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Địa điểm:
            /// </summary>
            place,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Có:
            /// </summary>
            credit,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:31-03-2011
            ///Mesasger:Tổng nợ
            /// </summary>
            TotalDebit,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:31-03-2011
            ///Mesasger:Tổng có
            /// </summary>
            TotalCredit,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:31-03-2011
            ///Mesasger:Lũy kế nợ
            /// </summary>
            AccumulatedDebtor,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:31-03-2011
            ///Mesasger:Lũy kế có
            /// </summary>
            AccumulatedCredit,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:31-03-2011
            ///Mesasger:Cấp 1
            /// </summary>
            Level1,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:31-03-2011
            ///Mesasger:Cấp 2
            /// </summary>
            Level2,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:31-03-2011
            ///Mesasger:Cấp 3
            /// </summary>
            Level3,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:31-03-2011
            ///Mesasger:Lỗi cú pháp công thức
            /// </summary>
            SyntaxError,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:01-04-2011
            ///Mesasger:Chưa có dữ liệu để kiểm tra
            /// </summary>
            EmptySyntaxError,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:01-04-2011
            ///Mesasger:Công thức đúng
            /// </summary>
            ValidSyntaxError,
            /// <summary>
            /// Page :ReportMark.aspx
            /// Title:Thông báo
            /// Create by:Tondb
            /// Create date:01-04-2011
            ///Mesasger:Công thức bạn tạo vượt giới hạn cho phép
            /// </summary>
            MaxLengthSyntaxError,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Nợ:
            /// </summary>
            debit,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Địa chỉ
            /// </summary>
            address,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Mã số thuế
            /// </summary>
            taxcode,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Số lượng chọn xuất.
            /// </summary>
            QuantitySelect,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Đơn vị
            /// </summary>
            unit,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:ĐƠN MUA HÀNG 
            /// </summary>
            rpisoname,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger: Nhập thông tin để tìm kiếm.
            /// </summary>
            BlankText,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger: Mua.
            /// </summary>
            BUY,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger: Mua.
            /// </summary>
            ReturnBuy,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger: Bán trả lại
            /// </summary>
            ReturnSell,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger: Bán
            /// </summary>
            Sell,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger: Giá đích danh.
            /// </summary>
            TargetPrice,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger: Giá chung.
            /// </summary>
            GeneralPrice,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger: Thiết lập giá bán
            /// </summary>
            SaleSetting,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger: Sản xuất.
            /// </summary>
            PRODUCT,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Tên nhà cung cấp:
            /// </summary>
            suppliername,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Điện thoại:
            /// </summary>
            tel,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Fax:
            /// </summary>
            fax,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Số lượng
            /// </summary>
            quantityrp,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Đã xử lý
            /// </summary>
            Treated,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Đang xử lý
            /// </summary>
            WaittingTreatment,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Chờ duyệt
            /// </summary>
            AwaitingApproval,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Thành tiền
            /// </summary>
            amount,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Cộng tiền hàng
            /// </summary>
            total,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:VAT
            /// </summary>
            vat,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Tổng tiền thành toán:
            /// </summary>
            totalamount,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Số tiền viết bằng chữ
            /// </summary>
            inwords,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Ngày giao hàng:
            /// </summary>
            deliverydate,


            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Phương thức thanh toán
            /// </summary>
            menthodofpayment,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Người lập
            /// </summary>
            writer,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Kết toán trưởng
            /// </summary>
            chiefaccountant,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Giám đốc
            /// </summary>
            manager,



            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Ngày:
            /// </summary>
            date,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Loại tiền
            /// </summary>
            currency,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Số
            /// </summary>
            rpno,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Mã hàng
            /// </summary>
            itemno,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Đơn giá
            /// </summary>
            unitprice,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Nơi giao hàng
            deliveryplace,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Ký, họ tên
            signature,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Ký, đóng dấu
            signaturestamp,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Đơn đặt hàng
            rpponame,



            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:khách hàng
            customer,


            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Tên khách hàng
            customername,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:HÓA đơn
            rpinvoicename,


            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Khách hàng
            rpinvoicesign,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Hợp đồng
            contract,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Ngân hàng
            bank,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:TK ngan hàng
            accountnorp,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Thuế xuát
            taxrate,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Thuế xuát
            rpinvoicefooter,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Thuôc sử hữu
            issuedby,

            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Phiếu xuất kho
            rpoutwardname,

            /// Page :
            /// title:
            ///Mesasger:Tên người nhận
            receivername,

            /// Page :
            /// title:
            ///Mesasger:Lý do
            reason,



            /// Page :
            /// title:
            ///Mesasger:Xuất tại kho(ngăn lô)
            selfstock,

            /// Page :
            /// title:
            ///Mesasger:Chứng từ gốc kèm theo
            origindocument,
            /// Page :
            /// title:
            ///Mesasger:yêu cầu
            requestquantity,
            /// Page :
            /// title:
            ///Mesasger:thực xuất
            realquantity,
            /// Page :
            /// title:
            ///Mesasger:Người nhận hàng
            receiver,
            /// Page :
            /// title:
            ///Mesasger:Thủ kho
            storekeeper,
            /// Page :
            /// title:
            ///Mesasger:Phiếu nhập kho
            rpinwardname,
            /// Page :
            /// title:
            ///Mesasger:Họ tên người giao
            deliveryname,
            /// Page :
            /// title:
            ///Mesasger:Theo
            accordance,
            /// Page :
            /// title:
            ///Mesasger:số
            no,

            /// Page :
            /// title:
            ///Mesasger:ngày
            day,

            /// Page :
            /// title:
            ///Mesasger:tháng
            Month,

            /// Page :
            /// title:
            ///Mesasger:năm
            year,

            /// Page :
            /// title:
            ///Mesasger:của
            of,

            /// Page :
            /// title:
            ///Mesasger:Theo chứng từ
            docquantity,

            /// Page :
            /// title:
            ///Mesasger:Thực nhập
            realinwardquantity,

            /// Page :
            /// title:
            ///Mesasger:PHIẾU XUẤT CHUYỂN KHO
            rpmoveoutstockname,
            /// Page :
            /// title:
            ///Mesasger:Mã người thực hiện
            executerno,


            /// Page :
            /// title:
            ///Mesasger:Tên người thực hiện
            executername,
            /// Page :
            /// title:
            ///Mesasger:Thủ kho nhập
            storekeeperin,
            /// Page :
            /// title:
            ///Mesasger:Thủ kho xuất
            storekeeperout,
            /// Page :
            /// title:
            ///Mesasger:Phương tiện vận chuyển
            transport,
            /// Page :
            /// title:
            ///Mesasger:Cộng
            sum,
            /// Page :
            /// title:
            ///Mesasger:Từ kho
            fromstock,
            /// Page :
            /// title:
            ///Mesasger:Đến kho
            tostock,
            /// Page :
            /// title:
            ///Mesasger:Thực xuất
            realoutwardquantity,

            /// Page :
            /// title:
            ///Mesasger:PHIẾU XUẤT KHO KIÊM VẬN CHUYỂN NỘI BỘ
            rpintenalmovementname,

            /// Page :
            /// title:
            ///Mesasger:liên
            rplien,

            /// Page :
            /// title:
            ///Mesasger:Căn cứ lệnh điều động số
            commandmaneuver,

            /// Page :
            /// title:
            ///Mesasger:về việc
            about,

            /// Page :
            /// title:
            ///Mesasger:Thực xuất
            realoutquantity,

            /// Page :
            /// title:
            ///Mesasger:Thực nhập
            realinquantity,

            /// Page :
            /// title:
            ///Mesasger:Xuất
            export,

            /// Page :
            /// title:
            ///Mesasger:Nhập
            import,

            /// Page :
            /// title:
            ///Mesasger:Kho xuất
            outstock,
            /// Page :
            /// title:
            ///Mesasger:Kho xuất chưa chính xác
            EmptyOutStock,

            /// Page :
            /// title:
            ///Mesasger:Kho Nhập
            instock,

            /// Page :
            /// title:
            ///Mesasger:Kho nhập chưa chính xác
            EmptyInStock,


            /// Page :
            /// title:
            ///Mesasger:BẢNG CÂN ĐỐI KẾ TOÁN
            rpglbalancename,
            #endregion
            #region Confirm
            /// <summary>
            /// Page :ObjList
            /// title:cảnh báo
            ///Mesasger:Bạn có thực sự muốn xoá muốn xoá
            /// </summary>
            ConfirmDelete,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Bạn có chắc bỏ qua thao tác
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/07/2010
            /// </summary>
            ConfirmCancel,
            /// <summary>
            /// Page:All
            /// Messager:Thiết lập
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/08/2011
            /// </summary>
            Setup,
            /// <summary>
            /// Page:All
            /// Messager:Thiết lập
            /// Title:Thiết lập nhân viên
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/08/2011
            /// </summary>
            SetupEmployee,
            /// <summary>
            /// Page:All
            /// Messager:Thiết lập control
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 22/08/2011
            /// </summary>
            SetupControl,
            /// <summary>
            /// Page:All
            /// Messager:Thiết lập trang ứng dụng
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 22/08/2011
            /// </summary>
            SetupPageList,
            /// <summary>
            /// Page:All
            /// Messager:Thiết lập trang thông báo
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 22/08/2011
            /// </summary>
            SetupMessageList,
            /// <summary>
            /// Page:All
            /// Messager:Thiết lập menu
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 22/08/2011
            /// </summary>
            SetupMenuList,
            /// <summary>
            /// Thông báo
            /// Bạn phải lưu trước khi in. Bạn có muốn lưu rồi in không?
            /// </summary
            ConfirmSaveBeforePrint,
            /// <summary>
            /// Thông báo
            /// bạn có muốn lưu dữ liệu này không?
            /// </summary
            ConfirmSave,
            /// <summary>
            /// Page :
            /// title:
            ///Mesasger:Bạn có muốn đóng
            /// </summary>
            ConfirmClose,
            /// <summary>
            /// Title :Canh báo 
            /// Mesasger:Thay đổi tiền tê
            /// </summary>
            ConfirmCurrencyChange,
            /// <summary>
            /// Page :
            /// title:Cảnh báo
            ///Mesasger:Bạn muốn thực hiện chức năng này ?
            /// </summary>
            ConfirmProcess,
            #endregion
            #region Error
            /// <summary>
            /// Dữ liệu nhập không hợp lệ, vui lòng xem chi tiết lỗi và kiểm tra lại !
            /// title = Thông báo lỗi
            /// </summary>
            AlertError,
            /// <summary>
            /// Dữ liệu đã bị xóa!
            /// title = Thông báo 
            /// </summary>
            AlertDeleted,
            /// <summary>
            /// Dữ liệu đã bị thay đổi!
            /// title = Thông báo 
            /// </summary>
            AlertDataChange,
            /// <summary>
            /// Dữ liệu đang được xử lý bởi một người dùng khác, vui lòng kiểm tra lại !
            /// Thông báo 
            /// </summary>
            AlertDataInProcess,
            /// <summary>
            /// Title: thông báo
            /// Mess: Dữ liệu đã được xử lý, vui lòng kiểm tra lại !
            /// </summary>
            AlertDataProcessed,
            /// <summary>
            /// Title : Thông báo
            /// Mess: Số lượng người sử dụng vượt quá giới hạn đăng ký,vui lòng liên hệ nhà cung cấp để được thêm sử dụng !
            /// </summary>
            AlertUserOver,
            /// <summary>
            /// Title : Thông báo
            /// Mess:Hệ thống đã hết hạn sử dụng , Vui lòng liên hệ nhà cung cấp để được gia hạn sử dụng !
            /// </summary>
            AlertExpiryDateOver,
            /// <summary>
            /// Title : Thông báo
            /// Mess: Hệ thống chưa đăng ký bản quyền,  vui lòng liên hệ nhà cung cấp để được cấp lại bản quyền!
            /// </summary>
            AlertNotExist,
            /// <summary>
            /// Title : Thông báo
            /// Mess:Module này không được Quyền sử dụng,  Vui lòng liên hệ nhà cung cấp !
            /// </summary>
            AlertModuleDecline,
            #endregion
            #region General Messages
            /// <summary>
            /// Title :thông báo
            /// Content:tên đăng nhập và mật khẩu không đúng, vui lòng kiểm tra lại
            /// </summary>
            UserNameAndPasswordNotcorrectpleasecheckAgain,
            /// <summary>
            /// Không tồn tại trong hệ thống
            /// </summary>
            NotExistData,
            /// <summary>
            ///Có lỗi trong quá trình tạo hóa đơn, vui lòng kiểm tra lại !
            /// </summary>
            makeInvoiceError,
            /// <summary>
            /// Dữ liệu bị trùng, vui lòng kiểm tra lại !
            /// </summary>
            DataDuplicate,
            /// <summary>
            /// Description: Tổ chức
            /// Page:ObjectList.aspx
            /// </summary>
            IsOrganzition,
            /// <summary>
            /// Description: Cá nhân
            /// Page:ObjectList.aspx
            /// </summary>
            IsPerson,
            /// <summary>
            /// Mã đã tồn tại trong hệ thống
            /// </summary>
            IdExitInSystem,
            //--------------------------------------------------
            /// <summary>
            /// Thông báo: Vui long chọn phân loại hàng hóa
            /// title = message = "Thông báo"
            /// </summary            
            ItemType,
            /// <summary>
            /// Thông báo: Bạn phải chọn kho hàng khác kho chuyển
            /// title = message = "Thông báo"
            /// </summary            
            SelectWareHouse,
            /// <summary>
            /// Thông báo: Bạn phải chọn Serial xuất
            /// title = message = "Thông báo"
            /// </summary            
            SelectSerial,
            /// <summary>
            /// Thông báo: Mã phiếu xuất:
            /// title = message = "Thông báo"
            /// </summary            
            OutWardNo,
            /// <summary>
            /// Thông báo kho rỗng
            /// title = message = "Thông báo"
            /// </summary   
            FindNotFound,
            /// <summary>
            /// Thông báo: Người yêu cầu không được để trống
            /// title = message = "Thông báo"
            /// </summary            
            WhoRequest,
            /// <summary>
            /// Không tìm thấy bản ghi nào...!
            /// title = message = "Thông báo"
            /// </summary            
            QuatityOutReal,
            /// <summary>
            /// Không cho phép xuất kho âm
            /// title = message = "Thông báo"
            /// </summary            
            Negative,
            /// <summary>
            /// Không cho phép xuất kho âm
            /// title = message = "Thông báo"
            /// </summary            
            FinderIC,
            /// <summary>
            /// Tìm kiếm chi tiết phiếu Xuất - Nhập kho 
            /// title = message = "Cảnh báo"
            /// </summary
            FinderInvoice,
            /// <summary>
            /// Tìm kiếm chi tiết hóa đơn Xuất - Nhập kho 
            /// title = message = "Cảnh báo"
            /// </summary  
            QuatityOut,

            AlertTitle,
            /// <summary>
            /// Dung để láy "Cảnh báo"
            /// title = message = "Cảnh báo"
            /// </summary>
            WarningTitle,
            /// <summary>
            /// Dung để láy "Lỗi"
            /// title = message = "Lỗi"
            /// </summary>
            ErrorTitle,
            /// Page: ChangePassword
            /// Messager: nhập sai password 
            /// Title:Thông báo
            /// </summary>
            PassNotCorrect,
            /// Page: ChangePassword.aspx
            /// Messager: Password mới trùng với password cũ
            /// Title:Thông báo
            /// </summary>
            OldNewPassDuplicate,
            /// Page: ChangePassword.aspx
            /// Messager: nhập sai password mới
            /// Title:Thông báo
            /// </summary>
            NewPassNotCorrect,
            /// Page: All
            /// Messager: Dữ liệu không được để trống
            /// Title:Thông báo
            /// </summary>
            ValidateBlank,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Tỷ giá của tiền hạch toán so với
            /// Title:
            /// </summary>
            LabelCurrencyRate,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Tỷ giá không được rỗng!
            /// Title:
            /// </summary>
            EmptyCurrencyRate,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Mệnh giá lớn hơn 0.
            /// Title:
            /// </summary>
            EmptyBankNote,
            /// <summary>
            /// Page: All
            /// Messager: Kỳ này đã có chứng từ.
            /// Title:
            /// </summary>
            HaveDocumentInFici,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Giá bán lớn hơn 0.
            /// Title:
            /// </summary>
            EmptyBuyingRate,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Giá mua lớn hơn 0.
            /// Title:
            /// </summary>
            EmptySellingRate,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Giá chuyển khoản lớn hơn 0.
            /// Title:
            /// </summary>
            EmptyTransferRate,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Ngày lớn hơn 0.
            /// Title:
            /// </summary>
            EmptyDate,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Ngày và Mệnh Giá không trùng.
            /// Title:
            /// </summary>
            DuplicateNoteAndActvDate,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Vui lòng kiểm tra:
            /// Title:
            /// </summary>
            EmptyPleaseDbCheck,
            /// <summary>
            /// Page: CurrencyRate.aspx
            /// Messager: Tỷ giá
            /// Title:
            /// </summary>
            LabelCurrencyRate1,
            /// <summary>
            /// Page: AccountGroup
            /// Messager: Nhóm tài khoản này đang được sử dụng không thể xóa.
            /// Title: Lỗi Quyền
            /// </summary>
            AccgRelation,
            /// <summary>
            /// Page: AccountGroup
            /// Messager: Loại nhóm này đang được sử dụng không thể xóa.
            /// Title: Lỗi Quyền
            /// </summary>
            AcctRelation,
            /// <summary>
            /// Page: All
            /// Messager: Chưa thể cập nhật lỗi.
            /// Title: Lỗi Quyền
            /// </summary>
            UpdateError,
            /// <summary>
            /// Page: BatchTransfer
            /// Messager: Tài khoản từ không được để rỗng.
            /// Title: Thông báo
            /// </summary>
            AccountFromNull,
            /// <summary>
            /// Page: BatchTransfer
            /// Messager: Tài khoản đến không được để rỗng.
            /// Title: Thông báo
            /// </summary>
            AccountToNull,
            /// <summary>
            /// Page: BatchTransfer
            /// Messager: Tài khoản từ chưa chính xác .
            /// Title: Thông báo
            /// </summary>
            AccountFromnotExactly,
            /// <summary>
            /// Hóa đơn đã bị khóa sổ
            /// </summary>
            OrderIsRose,
            /// <summary>
            /// Page: BatchTransfer
            /// Messager: Tài khoản đến chưa chính xác .
            /// Title: Thông báo
            /// </summary>
            AccountTonotExactly,
            /// <summary>
            /// Page: BatchTransfer
            /// Messager: Tài khoản từ và đến không được trùng nhau .
            /// Title: Thông báo
            /// </summary>
            AccountSame,
            /// <summary>
            /// Page: BatchTransfer
            /// Messager: Cặp tài khoản không được trùng nhau.
            /// Title: Thông báo
            /// </summary>
            CoupleAccountSame,
            /// <summary>
            /// Page: ITEMLIST
            /// Messager: Xin vui lòng kiểm tra lại đường dẫn.
            /// Title: Thông báo
            /// </summary>
            FileError,
            /// <summary>
            /// Page: ARBUSSINESS
            /// Messager: Tất cả các định khoản trước đó sẽ bị xóa nếu bạn chọn đồng ý.
            /// Title: Thông báo
            /// </summary>
            DeleteAllEntry,
            /// <summary>
            /// Page: ARBUSSINESS
            /// Messager: Định khoản tự động chỉ có thể sửa không được xóa.
            /// Title: Thông báo
            /// </summary>
            EntryAuto,
            /// <summary>
            /// Page:All
            /// Messager: Lưu thành công
            /// Title: Thông báo
            /// </summary>
            SaveSuccess,
            /// <summary>
            /// Page:All
            /// Messager: Hệ thống đang xử lý
            /// Title: Hệ thống đang xử lý
            /// </summary>
            Loading,
            /// <summary>
            /// Page:ActionTranfeEnd
            /// Messager: thực thi thất bại
            /// Title: Thông báo
            /// </summary>
            CaculatorFalse,
            /// <summary>
            /// Page:ActionTranfeEnd
            /// Messager: thực thi thành công
            /// Title: Thông báo
            /// </summary>
            CaculatorSusess,
            /// <summary>
            /// Page:ActionTranfeEnd
            /// Messager: Kỳ trước đang mở , hãy đóng trước khi kết sổ kỳ này
            /// Title: Lỗi
            /// </summary>
            ReFinancyOpen,
            /// <summary>
            /// Page:ActionTranfeEnd
            /// Messager: Kỳ hiện tại đã đóng , vui lòng mở sổ trước khi kết chuyển !
            /// Title: Lỗi
            /// </summary>
            CurrentFinancyClose,
            /// <summary>
            /// Page:TranferData
            /// Messager: Bạn có muốn thực hiện kết chuyển !
            /// Title: Lỗi
            /// </summary>
            TranferData,
            /// <summary>
            /// Page:ExecuteTranferFail
            /// Messager: Có lỗi trong khi kết chuyển số liệu! 
            /// Title: Lỗi
            /// </summary>
            TranferFail,
            /// <summary>
            /// Page:ExecuteTranferFail
            /// Messager: Kết chuyển thành công! 
            /// Title: Lỗi
            /// </summary>
            TranferSuccess,
            /// <summary>
            /// Messager: Chọn chứng từ trước khi thực hiện !.
            /// Title: Thông báo
            /// </summary>
            PleaseChooseDocument,
            /// <summary>
            /// Messager: Chỉ ghi sổ những chứng từ có cùng trạng.
            /// Title: Thông báo
            /// </summary>
            PostSameStatus,
            /// <summary>
            /// Messager: Xoá dữ liệu thành công.
            /// Title: Thông báo
            /// </summary>
            DeleteSuccessful,
            /// <summary>
            /// Messager: Xoá dữ liệu thất bại.
            /// Title: Lỗi
            /// </summary>
            DeleteFailed,
            /// <summary>
            /// Messager: Nguyên giá của tài sản bằng 0.
            /// Title: Lỗi
            /// </summary>
            CostZero,
            /// <summary>
            /// Messager: Nhân viên
            /// Title: Dữ liệu
            /// </summary>
            Employee,
            /// <summary>
            /// Messager: Khách hàng
            /// Title: Dữ liệu
            /// </summary>
            Customer,
            /// <summary>
            /// Messager: Nhà cung cấp
            /// Title: Dữ liệu
            /// </summary>
            Supplier,
            /// <summary>
            /// Messager: Nhà phân phối
            /// Title: Dữ liệu
            /// </summary>
            Distributor,
            /// <summary>
            /// Messager: Đối tác
            /// Title: Dữ liệu
            /// </summary>
            Partner,
            /// <summary>
            /// Messager: Đối tượng khác
            /// Title: Dữ liệu
            /// </summary>
            OtherPerson,
            /// <summary>
            /// Messager: Số lượng tồn kho không đủ yêu cầu xuất.
            /// Title: Thông báo
            /// </summary>
            LackQuantity,
            /// <summary>
            /// Messager: Lưu dữ liệu thất bại, xin thử lại sau.
            /// Title: Lỗi
            /// </summary>
            SaveFailed,
            /// <summary>
            /// Messager: Chưa có mặt hàng nào được chọn cảnh báo hết hoặc đã hết hàng. Vui lòng kiểm tra lại !
            /// Title: Lỗi
            /// </summary>
            NotItemtCheckedForWarning,
            /// <summary>
            /// Messager: Có lỗi trong quá trình phân quyền cho nhóm.
            /// Title: Lỗi
            /// </summary>
            ControlError,
            /// <summary>
            /// Page:CreateUser.aspx
            /// Create by:Tondb
            /// Create date:16-08-2010
            /// Messager: Thêm menu vào nhóm người dùng bị lỗi
            /// Title: Lỗi
            /// </summary>
            MenuRoleError,
            /// <summary>
            /// Page:DeductionTax.aspx
            /// Create by:Tondb
            /// Create date:05-05-2011
            /// Messager: Tạo chứng từ nghiệp vụ tổng hợp bị lỗi
            /// Title: Lỗi
            /// </summary>
            CreateGLBusinessFailed,
            /// <summary>
            /// Page:DeductionTax.aspx
            /// Create by:Tondb
            /// Create date:05-05-2011
            /// Messager:VAT đầu ra còn lại
            /// Title: Lỗi
            /// </summary>
            VATOutRemained,
            /// <summary>
            /// Page:DeductionTax.aspx
            /// Create by:Tondb
            /// Create date:05-05-2011
            /// Messager:VAT đầu vào còn lại
            /// Title: Lỗi
            /// </summary>
            VATInRemained,
            /// <summary>
            /// Page:Item,
            /// Messager: Giá bán sỉ phải lớn hơn 0.
            /// Title: Cảnh báo
            /// </summary>
            Wholesale,
            /// <summary>
            /// Page:ucItem,
            /// Messager:Nhóm thực đơn
            /// Title: Cảnh báo
            /// </summary>
            ResSetMenuName,
            /// <summary>
            /// Page:ucItem,
            /// Messager:Thiết lập nhóm hàng hóa
            /// Title: Tiêu đề
            /// </summary>
            SetupGroupItems,
            /// <summary>
            /// Page:ucItem,
            /// Messager:Chưa lựa chọn hàng hóa hoặc loại lựa chọn.
            /// Title: Cảnh báo
            /// </summary>
            ItemorResType,
            /// <summary>
            /// Page:all,
            /// Messager:Chưa chọn hàng hóa
            /// Title: Cảnh báo
            /// </summary>
            ErrorChoiceItem,
            /// <summary>
            /// Page:GeneralSaleSetting,
            /// Messager: Giá bán cho mặt hàng này đã được thiết lập.
            /// Title: Cảnh báo
            /// </summary>
            SamePrice,
            /// <summary>
            /// Page:GeneralSaleSetting,
            /// Messager: Bảng giá này đang được sử dụng không thể xóa.
            /// Title: Cảnh báo
            /// </summary>
            TablePriceIsused,
            /// <summary>
            /// Page:GeneralSaleSetting,
            /// Messager: Quá trình duyệt bị lỗi.
            /// Title: Cảnh báo
            /// </summary>
            ApproveFalse,
            /// <summary>
            /// Page:GeneralSaleSetting,
            /// Messager: Quá trình hủy duyệt duyệt bị lỗi.
            /// Title: Cảnh báo
            /// </summary>
            UnApproveFalse,
            /// <summary>
            /// Page:GeneralSaleSetting,
            /// Messager: Chứng từ này đã được duyệt.
            /// Title: Cảnh báo
            /// </summary>
            IsApproved,
            /// <summary>
            /// Page:GeneralSaleSetting,
            /// Messager: Đã có bảng giá sử dụng cho loai hình kinh doanh: 
            /// Title: Cảnh báo
            /// </summary>
            BussinessTypeUsed,
            /// <summary>
            /// Page:GeneralSaleSetting,
            /// Messager: Chưa chọn loại hình kinh doanh cho bản giá.
            /// Title: Cảnh báo
            /// </summary>
            BussinessTypeNull,
            /// <summary>
            /// Page:TimeType,
            /// Messager: Loại hình kinh doanh không thể trống
            /// Title: Cảnh báo
            /// </summary>
            BussinessTypeNoTNull,
            /// <summary>
            /// Page:GeneralSaleSetting,
            /// Messager: Loại hình kinh doanh đã được thiết lập giá bạn có muốn tiếp tục hủy bỏ hay không?
            /// Title: Cảnh báo
            /// </summary>
            RequestBussinessType,
            /// <summary>
            /// Page:GeneralSaleSetting,
            /// Messager: Cột giá
            /// Title: Cảnh báo
            /// </summary>
            ColumnPrice,
            /// <summary>
            /// Page:ucDiscountType
            /// Messager: Loại hình kinh doanh
            /// Title: Dữ liệu
            /// </summary>
            BussinessType,
            /// <summary>
            /// Page:All,
            /// Messager: Có lỗi trong quá trình thao tác xin hãy sử lại. 
            /// Title: Cảnh báo
            /// </summary>
            SystemError,
            /// <summary>
            /// Page:All,
            /// Messager: Chưa nhập mã thẻ hoặc mã hẻ đã tồn tại trong hệ thống.
            /// Title: Cảnh báo
            /// </summary>
            NotorExistsVipCard,

            /// <summary>
            /// Page:All,
            /// Messager: Chưa nhập mã khách hàng hoặc khách hàng chưa tồn tại trong hệ thống.
            /// Title: Cảnh báo
            /// </summary>
            NotorNotExistsCustomer,

            /// <summary>
            /// Page:All,
            /// Messager: Loại thẻ chưa chính xác.
            /// Title: Cảnh báo
            /// </summary>
            NotVipCardType,


            /// <summary>
            /// Page:Item,
            /// Messager: Giá bán lẻ phải lớn hơn 0.
            /// Title: Cảnh báo
            /// </summary>
            RetailsPrice,
            /// <summary>
            /// Page:Item,
            /// Messager: Giá bán chung phải lớn hơn 0.
            /// Title: Cảnh báo
            /// </summary>
            GeneralPriceError,
            /// <summary>
            /// Page:Item,
            /// Messager: Giá nội bộ không được nhỏ hơn 0
            /// Title: Cảnh báo
            /// </summary>
            InternalPriceError,
            /// <summary>
            /// Messager: Nhập dữ liệu thành công.
            /// Title: Thông Báo
            /// </summary>
            InsertSuccessful,
            /// <summary>
            /// Messager: Thông tin cần thiết chưa chính xác
            /// Title: Thông Báo
            /// </summary>
            InfomationError,
            /// <summary>
            /// Messager: Bạn có muốn cập nhật cho những dự liệu bị trùng?
            /// Title: Thông Báo
            /// </summary>
            UpdateSameData,
            /// <summary>
            /// page :ObjList 
            /// Messager: Thông tin mặt hàng.
            /// Title: Thông Báo
            /// </summary>
            TitleItem,
            /// <summary>
            /// page :ObjList 
            /// Messager: Nhập dữ liệu thất bại, xin kiểm tra lại.
            /// Title: Thông Báo
            /// </summary>
            InsertFailed,
            /// <summary>
            /// Messager: Cập nhật thành công !
            /// Title: Thông Báo
            /// </summary>
            UpDateSuccess,
            /// <summary>
            /// Messager: Lưu thất bại, xin kiểm tra lại dữ liệu nhập vào.
            /// Title: Lỗi
            /// </summary>
            UpDateFailed,
            /// <summary>
            /// Messager: Bạn có muốn xóa tất cả dữ liệu đã nhập?  
            /// Title: Cảnh báo
            /// </summary>
            ClearAll,
            /// <summary>
            /// Dùng Messager và Title để làm nội dung cho các Button cho hộp thoại xác nhận.
            /// Cách sử dụng: khai báo hai biến: ok, cancel, và dùng phương thức BasePage.GetMessager().
            /// Messager: Huỷ
            /// Title: Đồng ý
            /// </summary>
            OkCancelButton,
            /// <summary>
            /// Page: ItemsList.aspx
            /// Messager: Phải chọn một nhóm để tạo mới hàng hóa (dịch vụ).
            /// Title: Thông báo
            /// </summary>
            NoGroupSelected,
            /// <summary>
            /// Page: DocumentConfig.aspx
            /// Messager: ngàythángnăm (12022010)
            /// Title: Thông báo
            /// </summary>
            DateTypeFull,
            /// <summary>
            /// Page: DocumentConfig.aspx
            /// Messager: ngàytháng (1202)
            /// Title: Thông báo
            /// </summary>
            DateTypeShort,

            /// <summary>
            /// Page: DocumentConfig.aspx
            /// Messager: Phân đoạn 1 không được để trống.
            /// Title: Thông báo
            /// </summary>
            PartEmpty,
            /// <summary>
            /// Page: DocumentConfig.aspx
            /// Messager: Phân đoạn 1 không được trùng.
            /// Title: Thông báo
            /// </summary>
            PartSame,

            /// <summary>
            /// Page: DocumentConfig.aspx
            /// Messager: Trùng phân hệ.
            /// Title: Thông báo
            /// </summary>
            SubsSame,

            /// <summary>
            /// Page: GeneralSaleSetting.aspx
            /// Messager: Sao chép giá thất bại
            /// Title: Thông báo
            /// </summary>
            CopyPriceFailure,

            /// <summary>
            /// Page: GeneralSaleSetting.aspx
            /// Messager: Sao chép từ bảng giá :
            /// Title: Thông báo
            /// </summary>
            CopyFrom,

            /// <summary>
            /// Page: GeneralSaleSetting.aspx
            /// Messager: Tăng giá (lớn hơn 100%, số tiền lớn hơn 0), giảm giá (nhỏ hơn 100%, số tiền nhỏ hơn 0).
            /// Title: Thông báo
            /// </summary>
            NoteCopy,


            /// <summary>
            /// Page: ucItems.aspx
            /// Messager: Tạo mới hàng hóa
            /// Title: Thông báo
            /// </summary>
            NewItem,
            /// <summary>
            /// Page: ucServices.aspx
            /// Messager: Tạo mới dịch vụ
            /// Title: Thông báo
            /// </summary>
            NewService,
            /// <summary>
            /// Page: ItemsList.aspx
            /// Messager: Bạn phải lưu thông tin hàng hoá trước khi thiết lập thuộc tính.
            /// Title: Lỗi
            /// </summary>
            SaveItemBeforeSetup,
            /// <summary>
            /// Page: ItemsList.aspx
            /// Messager: Tên và mã mặt hàng không được trống.
            /// Title: Thông báo
            /// </summary>
            ItemNameNotnull,
            /// <summary>
            /// Page: ItemsList.aspx
            /// Messager: Tên và mã nhóm không được trống.
            /// Title: Thông báo
            /// </summary>
            ItemGroupNotnull,
            /// <summary>
            /// Page: ItemsList.aspx
            /// Messager: Mã nhóm không được trùng
            /// Title: Thông báo
            /// </summary>
            ItemGroupSame,
            /// <summary>
            /// Page: ItemsList.aspx
            /// Messager: Mã mặt hàng không được để trống hoặc trùng với mã của mặt hàng khác.
            /// Title: Thông báo
            /// </summary>
            ItemNoIsSameOrBlank,
            /// <summary>
            /// Page: ItemsList.aspx
            /// Messager:Đơn vị tính chưa chính xác.
            /// Title: Thông báo
            /// </summary>
            ItemUOMError,
            /// <summary>
            /// Page: ItemsList.aspx
            /// Messager: Danh sách mặt hàng
            /// Title: Thông báo
            /// </summary>
            Itemlist,
            /// <summary>
            /// Page: ItemsList.aspx
            /// Messager: Mã hàng hóa chưa chính xác.
            /// Title: Thông báo
            /// </summary>
            ItemGroupError,
            /// <summary>
            /// Page: ucItem.ascx
            /// Messager: Thông tin nhà hàng bị lỗi.
            /// Title: Thông báo
            /// </summary>
            Restaurant,
            /// <summary>
            /// Page: ucItem.ascx
            /// Messager: Nhóm thực bị lỗi.
            /// Title: Thông báo
            /// </summary>
            ResSetMenu,
            /// <summary>
            /// Page: ucItem.ascx
            /// Messager: Giá bán chung bị lỗi.
            /// Title: Thông báo
            /// </summary>
            GeneralSale,
            /// <summary>
            /// Page: ucItem.ascx
            /// Messager: Giá bán nhà hàng bị lỗi.
            /// Title: Thông báo
            /// </summary>
            RestaurentSale,
            /// <summary>
            /// Messager: Đã có lỗi xảy ra khi hệ thống xử lý yêu cầu, xin thử lại sau.
            /// Title: Lỗi
            /// </summary>
            UnexpectedError,
            /// <summary>
            /// Messager:  Không thể xoá nghiệp vụ đã ghi sổ!
            /// Title: Lỗi
            /// </summary>
            UnSavePostedDocument,
            /// <summary>
            /// Page:Business.aspx
            /// Messager: Vui lòng nhập đầy đủ thông tin!
            /// Title: Thông báo
            /// Nguoi tạo: sonnt    
            /// Ngay tạo: 15/7/2009
            /// </summary>
            NotBlankRequisite,

            /// <summary>
            /// Page:Business.aspx
            /// Messager: Vui lòng kiểm tra lại định khoản.
            /// Title: Thông báo
            /// Nguoi tạo: sonnt    
            /// Ngay tạo: 15/7/2009
            /// </summary>
            CheckEntryRequisite,

            /// <summary>
            /// Page:Business.aspx
            /// Messager: Nhà cung cấp không được để trống.
            /// Title: Thông báo
            /// Nguoi tạo: sonnt    
            /// Ngay tạo: 15/7/2009
            /// </summary>
            SuplierRequisite,
            /// <summary>
            /// Page:
            /// Messager: Sổ kho.
            /// Title: Thông báo
            /// Nguoi tạo: Kienlv
            /// Ngay tạo: 2010/05/06
            /// </summary>
            BookStoreError,
            /// <summary>
            /// Page:
            /// Messager: Chứng từ nháp.
            /// Title: Thông báo
            /// Nguoi tạo: Tondb    
            /// Ngay tạo: 16/11/2010
            /// </summary>
            ICDocumentDrap,
            /// <summary>
            /// Page: InWardStock
            /// Message: Chi phí phân bổ
            /// Create By: Kienlv
            /// Description: Title chi phí phân bổ
            /// </summary>
            OtherCost,
            /// <summary>
            /// Page: ICOtherCost
            /// Message: Chi phí phân bổ
            /// Create By: Kienlv
            /// Description: Loại phân bổ - Phân bổ theo số lượng hoặc theo giá trị
            /// </summary>
            OtherCostType,
            /// <summary>
            /// Page:
            /// Messager: Đối tượng.
            /// Title: Tiêu đề
            /// Create by: Tondb    
            /// Create date: 18/11/2010
            /// Description:Dùng thay cho trường hợp đối tượng không bắt buộc
            /// </summary>
            FieldLabelObject,
            /// <summary>
            /// Page:POBusiness.aspx
            /// Messager: Xóa nhà cung cấp sẽ xóa hết chi tiết đơn hàng.
            /// Title: Thông báo
            /// Nguoi tạo: Vinh    
            /// Ngay tạo: 2010/05/06
            /// </summary>
            DeleteSuplier,
            /// <summary>
            /// Page:POBusiness.aspx
            /// Messager: Ngày kí không được để trống.
            /// Title: Thông báo
            /// Nguoi tạo: Vinh    
            /// </summary>
            SignatureDate,
            /// <summary>
            /// Page:ArBusiness.aspx
            /// Messager: Khách hàng không được để trống.
            /// Title: Thông báo
            /// Nguoi tạo: sonnt    
            /// Ngay tạo: 15/7/2009
            /// </summary>
            CustomerRequisite,

            /// <summary>
            /// Page:AMDecrease.aspx
            /// Messager: Khách hàng hoặc nhà đối tác không được trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 16/04/2010
            /// </summary>
            ObjectIsRequired,


            /// <summary>
            /// Page:Invoice.aspx
            /// Messager: Hóa đơn này đã được tạo phiếu thanh toán.
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq
            /// Ngay tạo: 01/04/2011
            /// </summary>
            InvoicePaymented,
            /// <summary>
            /// Page:Assembly.aspx
            /// Messager: Vui lòng chọn chi tiết cần xóa?
            /// Title: Thông báo
            /// Nguoi tạo: Tondb    
            /// Ngay tạo: 12/05/2010
            /// </summary>
            ChooseDeleteAssemblyDetail,
            /// <summary>
            /// Page:Assembly.aspx
            /// Messager: Bạn có chắc mún bỏ qua Chi tiết này?
            /// Title: Thông báo
            /// Nguoi tạo: Tondb    
            /// Ngay tạo: 12/05/2010
            /// </summary>
            IngoreAssemblyDetail,
            /// <summary>
            /// Page:Assembly.aspx
            /// Messager: Vui lòng kiểm tra số lượng lưu kho
            /// Title: Thông báo
            /// Nguoi tạo: Tondb    
            /// Ngay tạo: 12/05/2010
            /// </summary>
            QuantityAssemblyDetail,
            /// <summary>
            /// Page:Assembly.aspx
            /// Messager: Vui lòng kiểm tra dữ liệu chi tiết
            /// Title: Thông báo
            /// Nguoi tạo: Tondb    
            /// Ngay tạo: 12/05/2010
            /// </summary>
            CheckDataDetail,
            /// <summary>
            /// Page:Assembly.aspx
            /// Messager: Mặt hàng lắp ghép chưa có chi tiết
            /// Title: Thông báo
            /// Nguoi tạo: Tondb    
            /// Ngay tạo: 12/05/2010
            /// </summary>
            CheckDataSubDetail,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Vui lòng chọn đối tác của hợp đồng
            /// Title: Thông báo
            /// Create by: Tondb    
            /// Date: 22/07/2010
            /// </summary>
            OBJ_CTM,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Vui lòng hợp đồng cần thao tác
            /// Title: Thông báo
            /// Create by: Tondb    
            /// Date: 26/07/2010
            /// </summary>
            ChooseContract,
            /// <summary>
            /// Page:ICPLot.aspx
            /// Messager:Lô hàng đã được tạo!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 13/05/2010
            /// </summary>
            ICPLotCreated,
            /// <summary>
            /// Page:Shipping.aspx
            /// Messager:Vận chuyển đã được tạo!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 01/06/2010
            /// </summary>
            ShippingCreated,
            /// <summary>
            /// Page:Shipping.aspx
            /// Messager:Vận chuyển chưa được tạo!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 01/06/2010
            /// </summary>
            ShippingUnCreated,
            /// <summary>
            /// Page:Shipping.aspx
            /// Messager:Chọn Vận chuyển!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 01/06/2010
            /// </summary>
            ChooseShipping,
            /// <summary>
            /// Page:Shipping.aspx
            /// Messager:Chi phi vận chuyển phải>0
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 09/06/2010
            /// </summary>
            CheckExpense,
            /// <summary>
            /// QuickDecision ERP - chìa khóa đi đến thành công
            /// </summary>
            SystemTitle,
            /// <summary>
            /// Bắt đầu
            /// </summary>
            Starbutton,
            /// <summary>
            /// Page:StopPepreciation
            /// Content:Bắt đầu khấu hao
            /// Create by:Tondb
            /// Create date:22/12/2011
            /// </summary>
            StartPepreciation,
            /// <summary>
            /// Page:StopPepreciation
            /// Content:Ngừng khấu hao
            /// Create by:Tondb
            /// Create date:22/12/2011
            /// </summary>
            StopPepreciation,
            /// <summary>
            /// Page:Control.aspx
            /// Messager:Control đã được tạo!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/05/2010
            /// </summary>
            ControlCreated,
            /// <summary>
            /// Page:UomConvertBase.aspx
            /// Messager:Đơn vị căn bản đã được tạo!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 20/05/2010
            /// </summary>
            UOMCreated,
            /// <summary>
            /// Page:CodeTemplate.aspx
            /// Messager:Mã vạch thiết lập thành công!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 25/05/2010
            /// </summary>
            BarCodeCreated,
            /// <summary>
            /// Page:CodeTemplate.aspx
            /// Messager:Mã vạch thiết lập không thành công!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 25/05/2010
            /// </summary>
            BarCodeUnCreated,
            /// <summary>
            /// Page:CodeTemplate.aspx
            /// Messager:Chọn Mã vạch cần thao tác!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 26/05/2010
            /// </summary>
            ChooseBarCode,
            /// <summary>
            /// Page:UomConvertBase.aspx
            /// Messager:Đơn vị căn bản chưa được tạo!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 20/05/2010
            /// </summary>
            UOMUnCreated,
            /// <summary>
            /// Page:UomConvertBase.aspx
            /// Messager:Chọn Đơn vị cần thao tác!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 20/05/2010
            /// </summary>
            ChooseUOM,
            /// <summary>
            /// Page:UomConvertBase.aspx
            /// Messager:Bạn có chắc muốn xóa đơn vị tính này?
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/08/2011
            /// </summary>
            ConfirmUOM,
            /// <summary>
            /// Page:UomConvertItem.aspx
            /// Messager:Chọn Item cần thao tác!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 31/05/2010
            /// </summary>
            ChooseItem,
            /// <summary>
            /// Page:ResolvePOPR.aspx
            /// Messager:Xử lý yêu cầu mua hàng thành công!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 12/07/2010
            /// </summary>
            ResolvePRSuccessfull,
            /// <summary>
            /// Page:ResolvePOPR.aspx
            /// Messager:Xử lý yêu cầu mua hàng không thành công!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 12/07/2010
            /// </summary>
            ResolvePRFail,
            /// <summary>
            /// Page:All
            /// Messager:Nhập dữ liệu thành công
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq    
            /// Ngay tạo: 29/07/2011
            /// </summary>
            ImportSuccessful,
            /// <summary>
            /// Page:Itemslist
            /// Messager: Chưa có đơn vị tính trong hệ thống. Bạn không thể tạo mặt hàng
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq    
            /// Ngay tạo: 24/08/2011
            /// </summary>
            DontHaveUominSystem,

            /// <summary>
            /// Page:All
            /// Messager:Trùng dữ liệu trong file
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq    
            /// Ngay tạo: 29/07/2011
            /// </summary>
            SameDatainFile,


            /// <summary>
            /// Page:ResolvePOPR.aspx
            /// Messager:Số lượng đặt không được >0 và => số lượng duyệt!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 12/07/2010
            /// </summary>
            ResolvePRQuantity,

            /// <summary>
            /// Page:al'
            /// Messager:Số lượng phải lớn hơn 0.
            /// Title: Thông báo
            /// Nguoi tạo: Vinhlq    
            /// Ngay tạo: 18/01/2011
            /// </summary>
            ErrorQuantity,
            /// <summary>
            /// Page:Contract.aspx
            /// Messager:Bạn chưa chọn nhóm hợp đồng cần thao tác
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 20/07/2010
            /// </summary>
            ChooseContractGroup,
            /// <summary>
            /// Page:ResolvePOPR.aspx
            /// Messager:Chưa chọn nhà cung cấp
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 12/07/2010
            /// </summary>
            ResolvePROBJECT,

            /// <summary>
            /// Page:Control.aspx
            /// Messager:Control chưa được tạo!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/05/2010
            /// </summary>
            ControlUnCreated,
            /// <summary>
            /// Page:Control.aspx
            /// Messager:Chọn Control cần thay đổi!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/05/2010
            /// </summary>
            ChooseControl,
            /// <summary>
            /// Page:TaxList.aspx
            /// Messager:Chọn loại thuế cần thay đổi!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 04/06/2010
            /// </summary>
            ChooseTaxRate,
            /// <summary>
            /// Page:TaxList.aspx
            /// Messager:Thông tin các loại thuế
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/08/2011
            /// </summary>
            TaxInformation,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager:Chọn NGÂN hàng cần thay đổi!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 08/06/2010
            /// </summary>
            ChooseBank,
            /// <summary>
            /// Page:Page.aspx
            /// Messager:Chọn trang cần thiết lập!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 13/08/2010
            /// </summary>
            ChoosePageSetup,
            /// <summary>
            /// Page:Page.aspx
            /// Messager:Mã trang ứng dụng {0} không được trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 21/10/2010
            /// </summary>
            PageIDNotNull,
            /// <summary>
            /// Page:Country.aspx
            /// Messager:Chọn quốc gia cần thay đổi!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 14/06/2010
            /// </summary>
            ChooseCountry,
            /// <summary>
            /// Page:CardType.aspx
            /// Messager:Chọn loại thẻ cần thay đổi!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 14/06/2010
            /// </summary>
            ChooseCardType,
            /// <summary>
            /// Page:CreateUser.aspx
            /// Messager: Tên nhóm người dùng không thể để trống.
            /// Title: Thông báo
            /// Nguoi tạo: Vinh    
            /// Ngay tạo: 15/07/2010
            /// </summary>
            GroupUserName,
            /// <summary>
            /// Page:CreateUser.aspx
            /// Messager: Hãy chọn nhóm người dùng để thao tác.
            /// Title: Thông báo
            /// Nguoi tạo: Vinh    
            /// Ngay tạo: 15/07/2010
            /// </summary>
            SelectGroupUser,
            /// <summary>
            /// Page:CreateUser.aspx
            /// Messager: Nhóm này không thể xóa.
            /// Title: Thông báo
            /// Nguoi tạo: Vinh    
            /// Ngay tạo: 15/07/2010
            /// </summary>
            GroupUserCantDelete,
            /// <summary>
            /// Page:CreateUser.aspx
            /// Messager: Tên đăng nhập không được để trống.
            /// Title: Thông báo
            /// Nguoi tạo: Vinh    
            /// Ngay tạo: 15/07/2010
            /// </summary>
            UserNameEmpty,

            /// <summary>
            /// Page:CreateUser.aspx
            /// Messager: Mật khẩu chưa chính xác.
            /// Title: Thông báo
            /// Nguoi tạo: Vinh    
            /// Ngay tạo: 15/07/2010
            /// </summary>
            PasswordError,
            /// <summary>
            /// Page:CardType.aspx
            /// Messager:Không thể xóa thẻ này!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 17/06/2010
            /// </summary>
            DeleteCardType,
            /// <summary>
            /// Page:CardType.aspx
            /// Messager:Mã thẻ đã tồn tại!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 17/06/2010
            /// </summary>
            CheckCardNO,
            /// <summary>
            /// Page:CardType.aspx
            /// Messager:Mã thẻ không được rỗng!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 17/06/2010
            /// </summary>
            CheckCardNONull,
            /// <summary>
            /// Page:CardType.aspx
            /// Messager:% Giảm giá không được lớn hơn 100%!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 17/06/2010
            /// </summary>
            CheckCardPercent,
            /// <summary>
            /// Page:AttributeUnit.aspx
            /// Messager:Tên thuộc tính không được trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/06/2010
            /// </summary>
            CheckNameAttUnit,
            /// <summary>
            /// Page:AttributeUnit.aspx
            /// Messager:Thuộc tính không được xóa
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/06/2010
            /// </summary>
            DeleteAttUnit,
            /// <summary>
            /// Page:AttributeUnit.aspx
            /// Messager:Chọn Thuộc tính cần thao tác
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/06/2010
            /// </summary>
            ChooseAttUnit,
            /// <summary>
            /// Page:AttributeType.aspx
            /// Messager:Tên loại thuộc tính không được trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/06/2010
            /// </summary>
            CheckNameAttType,
            /// <summary>
            /// Page:ucItem
            /// Messager: Công thức chế biến bị lỗi.
            /// Title: Thông báo
            /// </summary>
            RecipesError,
            /// <summary>
            /// Page:ucItem
            /// Messager: Công thức chế biến
            /// Title: Thông báo
            /// </summary>
            Recipe,
            /// <summary>
            /// Page:ucItem
            /// Messager: Thiết lập thuộc tính bị lỗi.
            /// Title: Thông báo
            /// </summary>
            AttError,
            /// <summary>
            /// Page:ucItem
            /// Messager: Thuộc tính hàng hóa.
            /// Title: Thông báo
            /// </summary>
            AttItem,
            /// <summary>
            /// Page:ucItem
            /// Messager: Thuộc tính đã bị thay đổi bởi một người dùng khác. 
            /// Title: Thông báo
            /// </summary>
            AttChange,
            /// <summary>
            /// Page:ucItem
            /// Messager: Giá trị thuộc tính.
            /// Title: Thông báo
            /// </summary>
            ValueOfAtt,
            /// <summary>
            /// Page:ucItem
            /// Messager: Không thể xóa thuộc tính đã được sử dụng.
            /// Title: Thông báo
            /// </summary>
            AttIsUsed,
            /// <summary>
            /// Page:ucItem
            /// Messager: Thiét lập nhà sản xuất bị lỗi.
            /// Title: Thông báo
            /// </summary>
            ManuError,
            /// <summary>
            /// Page:SetMenu
            /// Messager: Xóa hết tất cả SetMenu nếu hủy. Bạn muốn thực hiện thao tác này?
            /// Title: Thông báo
            /// </summary>
            UncheckSetMenu,
            /// <summary>
            /// Page:SetMenu
            /// Messager: Loại lựa chọn
            /// Title: Thông báo
            /// </summary>
            ChoiceType,
            /// <summary>
            /// Page:ucItem
            /// Messager: Chưa thiết lập được nhóm cho người dùng.
            /// Title: Thông báo
            /// </summary>
            UpdateUserGroupError,
            /// <summary>
            /// Page:CreateUser
            /// Messager: Trùng tên đăng nhập.
            /// Title: Thông báo
            /// </summary>
            UserNameSame,
            /// <summary>
            /// Page:CreateUser
            /// Messager: Tên nhóm người dùng này đã được sử dụng.
            /// Title: Thông báo
            /// </summary>
            GroupUserNameSame,
            /// <summary>
            /// Page:CreateUser
            /// Messager: Chưa thiết lập nhóm cho người dùng.
            /// Title: Thông báo
            /// </summary>
            NoGroupUser,
            /// <summary>
            /// Page:ucItem
            /// Messager: Thiết lập nhà cung cấp bị lỗi.
            /// Title: Thông báo
            /// </summary>
            SupError,
            /// <summary>
            /// Page:ucItem
            /// Messager: Thiết lập nhóm phụ bị lỗi.
            /// Title: Thông báo
            /// </summary>
            SubGroupError,
            /// <summary>
            /// Page:ucItem
            /// Messager: Nhóm phụ
            /// Title: dữ liệu
            /// </summary>
            SubGroup,
            /// <summary>
            /// Page:AttributeType.aspx
            /// Messager:Loại thuộc tính không thể xóa
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/06/2010
            /// </summary>
            DeleteAttType,
            /// <summary>
            /// Page:AttributeType.aspx
            /// Messager:Chọn loại thuộc tính cần thao tác
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/06/2010
            /// </summary>
            ChooseAttType,
            /// <summary>
            /// Page:AttributeType.aspx
            /// Messager:Tên loại thuộc tính không được trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/06/2010
            /// </summary>
            CheckNameAttInfo,
            /// <summary>
            /// Page:AttributeType.aspx
            /// Messager:Tên loại thuộc tính không được trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/06/2010
            /// </summary>
            CheckNOAttInfo,
            /// <summary>
            /// Page:AttributeType.aspx
            /// Messager:Mã thuộc tính đã tồn tại
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/06/2010
            /// </summary>
            AttInfoNOExists,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager:Chọn phương thức cần thay đổi!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 09/06/2010
            /// </summary>
            ChoosePaymentMethod,
            /// <summary>
            /// Page:WarrantyCode.aspx
            /// Messager:Chọn nhãn bảo hành cần thay đổi!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 11/06/2010
            /// </summary>
            ChooseWarrantycode,
            /// <summary>
            /// Page:WarrantyCode.aspx
            /// Messager:Hiển thị ngày cho nhãn bảo hành!
            /// Title: Thông báo
            /// Nguoi tạo: mainta    
            /// Ngay tạo: 01/09/2010
            /// </summary>
            RenderDay,
            /// <summary>            
            /// Messager:Tháng
            /// Title: Month            
            /// </summary>
            RenderMonth,
            /// <summary>
            /// Page:WarrantyCode.aspx
            /// Messager:Tuần!
            /// Title:Tuần            
            /// </summary>
            RenderWeek,

            /// <summary>
            /// Page:WarrantyCode.aspx
            /// Messager: Vui lòng nhập mã nhãn bảo hành!
            /// Title: Thông báo
            /// Nguoi tạo: mainta    
            /// Ngay tạo: 01/09/2010
            /// </summary>
            CheckData,
            /// <summary>
            /// Page:WarrantyCode.aspx
            /// Messager: Vui lòng kiểm tra dữ liệu
            /// Title: Thông báo
            /// Nguoi tạo: mainta    
            /// Ngay tạo: 01/09/2010
            /// </summary>

            EmptyWarrantyNo,

            /// <summary>
            /// Page:WarrantyCode.aspx
            /// Messager: Vui lòng chọn thời gian!
            /// Title: Thông báo
            /// Nguoi tạo: mainta    
            /// Ngay tạo: 01/09/2010
            /// </summary>
            EmptyWarrantyTime,

            /// <summary>
            /// Page:WarrantyCode.aspx
            /// Messager: Vui lòng chọn loại thời gian!
            /// Title: Thông báo
            /// Nguoi tạo: mainta    
            /// Ngay tạo: 01/09/2010
            /// </summary>
            EmptyWarrantyTimeType,

            /// <summary>
            /// Page:WarrantyCode.aspx
            /// Messager:Hiển thị năm cho nhãn bảo hành!
            /// Title: Thông báo
            /// Nguoi tạo: mainta    
            /// Ngay tạo: 01/09/2010
            /// </summary>
            RenderYear,
            /// <summary>
            /// Page:ucItem
            /// Messager: Thời gian bảo hành chưa chính xác.
            /// Title: Thông báo
            /// Nguoi tạo: Vinh
            /// Ngay tạo: 5/07/2010
            /// </summary>
            WarrantyTime,
            /// <summary>
            /// Page:ItemsList.aspx
            /// Messager: Giá trị không thể để trống.
            /// Title: Thông báo
            /// Nguoi tao: VINH
            /// Ngay tao: 22/06/2010
            /// </summary>
            ValueNotBlank,
            /// <summary>
            /// Page:Pricecondition.aspx
            /// Messager:Cấu trúc không chính xác
            /// Title: Thông báo
            /// Nguoi tao: VINH
            /// Ngay tao: 22/06/2010
            /// </summary>
            NotStructure,


            /// <summary>
            /// Create by:Tondb
            /// Create date:01-10-2010
            /// Page:CreateUser
            /// Messager: Nhóm chính {0} không thể xóa!
            /// Title: Thông báo
            /// </summary>
            MainGroupNotRemove,
            /// <summary>
            /// Create by:Tondb
            /// Create date:01-10-2010
            /// Page:CreateUser
            /// Messager: Nhóm {0} đã tồn tại người dùng.
            /// Title: Thông báo
            /// </summary>
            UserInGroup,
            /// <summary>
            /// Create by:Tondb
            /// Create date:01-10-2010
            /// Page:CreateUser
            /// Messager: Chi tiết người dùng
            /// Title: Thông báo
            /// </summary>
            TitleDetailUser,
            /// <summary>
            /// Create by:Vinhlq
            /// Create date:10/11/2011
            /// Page:MoveStock
            /// Messager: Cùng kho không thể chuyển.
            /// Title: Thông báo
            /// </summary>
            SameStock,
            /// <summary>
            /// Create by:Tondb
            /// Create date:09-12-2010
            /// Page:CreateUser
            /// Messager:{0} đã được tạo tài khoản ở chi nhánh khác.Bạn có muốn sử dụng?
            /// Title: Thông báo
            /// </summary>
            AccUserNameExist,
            /// <summary>
            /// Create by:Tondb
            /// Create date:09-12-2010
            /// Page:CreateUser
            /// Messager: Danh sách tài khoản
            /// Title: Thông báo
            /// </summary>
            TitleAccUserName,
            /// <summary>
            /// Create by:Tondb
            /// Create date:11-12-2010
            /// Page:CreateUser
            /// Messager: Nhóm {0} được tạo ở chi nhánh khác.Bạn không có quyền thay đổi.
            /// Title: Thông báo
            /// </summary>
            CheckRoleUpdateUserGroup,
            /// <summary>
            /// Create by:Tondb
            /// Create date:11-12-2010
            /// Page:CreateUser
            /// Messager:Bạn không có quyền thao tác cho nhóm {0}.
            /// Title: Thông báo
            /// </summary>
            CheckRoleDeniedUserGroup,
            /// <summary>
            /// Create by:Tondb
            /// Create date:11-12-2010
            /// Page:CreateUser
            /// Messager:Bạn không có quyền thao tác người dùng {0}.
            /// Title: Thông báo
            /// </summary>
            CheckRoleDeniedUser,
            /// <summary>
            /// Create by:Tondb
            /// Create date:09-05-2011
            /// Page:CreateUser
            /// Messager:Người dùng mặc định không thể xóa.
            /// Title: Thông báo
            /// </summary>
            ISDEFAULTUSER,
            /// <summary>
            /// Create by:Tondb
            /// Create date:09-05-2011
            /// Page:CreateUser
            /// Messager:Người dùng mặc định không thể sửa.
            /// Title: Thông báo
            /// </summary>
            ISDEFAULTUSEREDIT,
            /// <summary>
            /// Create by:Tondb
            /// Create date:16-12-2010
            /// Page:CreateUser
            /// Messager: Bạn chưa chọn phân hệ cần thiết lập
            /// Title: Thông báo
            /// </summary>
            ChooseModuleOnUseGroup,
            /// <summary>
            /// Page:ItemsList.aspx
            /// Messager: Thuộc tính chưa có giá trị.
            /// Title: Thông báo
            /// Nguoi tao: VINH
            /// Ngay tao: 22/06/2010
            /// </summary>
            AttributeNotValue,
            /// <summary>
            /// Page:TaxList.aspx
            /// Messager:Vui lòng kiểm tra dữ liệu!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 04/06/2010
            /// </summary>
            CheckDataTaxRate,


            /// <summary>
            /// Page:TaxList.aspx
            /// Messager:Mã loại thuế không được rỗng!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 16/06/2010
            /// </summary>
            CheckTaxNO,
            /// <summary>
            /// Page:TaxList.aspx
            /// Messager:Phần trăm thuế lớn hơn 0 và nhỏ hon 1000
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 16/06/2010
            /// </summary>
            CheckPercent,
            /// <summary>
            /// Page:TaxList.aspx
            /// Messager:Phần trăm thuế trùng nhau
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 16/06/2010
            /// </summary>
            DuplicatePercent,
            /// <summary>
            /// Page:UomConvertBase.aspx
            /// Messager:Bạn chưa nhập đơn vị cần thiết lập!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 11/06/2010
            /// </summary>
            CheckUomName,
            /// <summary>
            /// Page:UomConvertBase.aspx
            /// Messager:Kiểm tra lại số lượng quy đổi!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 12/06/2010
            /// </summary>
            CheckUomQuantity,
            /// <summary>
            /// Page:UomConvertBase.aspx
            /// Messager:Bạn chưa chọn đơn vị cần quy đổi
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 12/06/2010
            /// </summary>
            CheckUomID,
            /// <summary>
            /// Page:PaymentTerm.aspx
            /// Messager:Vui lòng kiểm ngày tháng năm!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 10/06/2010
            /// </summary>
            ValidateDatetime,
            /// <summary>
            /// Page:PaymentTerm.aspx
            /// Messager: Tổng phần trăm( % )thực hiện không được vượt quá 100%!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 10/06/2010
            /// </summary>
            ValidateTotal,
            /// <summary>
            /// Page:PaymentTerm.aspx
            /// Messager: Tổng phần trăm( % )thực hiện chưa đủ 100%!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 15/06/2010
            /// </summary>
            ValidatePercent,
            /// <summary>
            /// Page:PaymentTerm.aspx
            /// Messager: Ngày thanh toán phải nhỏ hoặc bằng ngày cam kết!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 15/06/2010
            /// </summary>
            ValidateDatePayin,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager: Kiểm tra lại ngày kết thúc hợp đồng!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            ValidateEndDate,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Bạn có muốn lưu trước khi đóng form!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            ValidateBeforeSave,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager: Kiểm tra lại ngày tạo!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 26/08/2010
            /// </summary>
            ValidateCreateDate,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager: Kiểm tra lại ngày ký!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 26/08/2010
            /// </summary>
            ValidateSignDate,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager: Kiểm tra lại ngày hiệu lực!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 26/08/2010
            /// </summary>
            ValidateValidDate,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager: Kiểm tra lại ngày hết hạn!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 26/08/2010
            /// </summary>
            ValidateExpiredDate,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager: Hợp đồng không ở trạng thái được sửa!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            ValidateBeforeEdit,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager: Chờ duyệt(Trạng thái)
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            StatusWaitingApproved,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Duyệt(Trạng thái)
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            StatusApproved,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Không Duyệt(Trạng thái)
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            StatusNotApproved,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Sửa(Trạng thái)
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            StatusFixed,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Tạm ngưng(Trạng thái)
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            StatusStopping,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Đã thực hiện(Trạng thái)
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            StatusDone,
            /// <summary>   
            /// Page:ContractDetail.aspx
            /// Messager:Đang thực hiện(Trạng thái)
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            StatusDoing,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Thanh lý(Trạng thái)
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/08/2010
            /// </summary>
            Statusliquidation,
            /// <summary>
            /// Page:ICPLot.aspx
            /// Messager:Chọn lô cần thay đổi!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 13/05/2010
            /// </summary>
            ChooseICPlot,

            /// <summary>
            /// Page:ICPLot.aspx
            /// Messager:Tạo lô không thành công.Vui lòng kiểm tra.
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 13/05/2010
            /// </summary>
            ICPLotUnsaved,
            /// <summary>
            /// Page:ICPLot.aspx
            /// Messager:Bạn có thật sự muốn bỏ qua!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 13/05/2010
            /// </summary>
            ICPLotIngoreDetail,
            /// <summary>
            /// Page:Assembly.aspx
            /// Messager:Vui lòng kiểm tra lại số lượng Serial cần xuất kho!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 21/04/2010
            /// </summary>
            SerialNoOutWardStock,
            /// <summary>
            /// Page:Assembly.aspx
            /// Messager:Số Serial của mặt hàng này đã hết!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 28/04/2010
            /// </summary>
            SerialNoOutOfWardStock,
            /// <summary>
            /// Page:AMDecrease.aspx
            /// Messager:Cần chi tiết cho chứng từ ghi giảm
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 21/04/2010
            /// </summary>
            IsRequiredDetail,
            /// <summary>
            /// Page:Balance.aspx
            /// Messager:Chọn GL cần thao tác!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 24/05/2010
            /// </summary>
            ChooseGL,

            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager:Số lượng 1 >0
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 24/06/2010
            /// </summary>
            StockQuanity1,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Phiếu bán lẻ
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            TicketRetail,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Phiếu bán hàng nhà hàng
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            TicketRes,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Phiếu thu
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            TicketReceipt,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Phiếu chi
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            TicketPayment,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Phiếu nhập
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            TicketInwardStock,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Phiếu xuất
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            TicketOutwardStock,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Phiếu hóa đơn
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            TicketInvoice,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Phiếu công nợ phải thu
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            TicketCMP,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Phiếu công nợ phải thu
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            TicketCMR,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Kỳ tài chính đang đóng,không thể thao tác.Bạn có muốn mở kỳ này?
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            WarningFiciClose,
            /// <summary>
            /// Page:PubdocumentBlocked
            /// Messager:Mở kỳ tài chính không thành công
            /// Create by:Tondb
            /// Create date:17-01-2011
            /// </summary>
            FiciCloseFailed,
            /// <summary>
            /// Page:PriceType
            /// Messager:Giá ngày lễ
            /// Create by:Tondb
            /// Create date:19-01-2011
            /// </summary>
            DateHoliday,
            /// <summary>
            /// Page:PriceType
            /// Messager:Giá ngày lễ
            /// Create by:Tondb
            /// Create date:19-01-2011
            /// </summary>
            DateNewYear,
            /// <summary>
            /// Page:All
            /// Messager: Số lượng 1 phải lớn hơn 0
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq
            /// Ngay tạo: 10/11/2010
            /// </summary>
            Quanity1,

            /// <summary>
            /// Page:All
            /// Messager: Số lượng tối thiểu phải lớn hơn 0
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq
            /// Ngay tạo: 10/11/2010
            /// </summary>
            RateQuantity,

            /// <summary>
            /// Page:All
            /// Messager: Nguyên vật liệu chưa được chọn.
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq
            /// Ngay tạo: 10/11/2010
            /// </summary>
            ChoiceMaterial,


            /// <summary>
            /// Page:All
            /// Messager: Chưa có kì để thao tác.
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq
            /// Ngay tạo: 6/12/2010
            /// </summary>
            NoFicical,

            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager:Số lượng 2 >0
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 24/06/2010
            /// </summary>
            StockQuanity2,
            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager:Số lượng Serial đã đủ.Không thể tạo thêm!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 24/06/2010
            /// </summary>
            Stock1EqualSerial,
            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager:Vui lòng chọn lô hàng cho mặt hàng theo dõi theo lô
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 24/06/2010
            /// </summary>
            NotChoosePlot,
            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager:Vui lòng kiểm tra Serial cho mặt hàng Serial
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 24/06/2010
            /// </summary>
            SerialItems,
            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager:Serial này đã tồn tại. Bạn phải chọn Serial khác
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 24/06/2010
            /// </summary>            
            SerialExits,
            /// <summary>
            /// Page:InWardStock.aspx
            /// Messager:Hệ thống chưa khởi tạo chi nhánh ,kỳ tài chính hoặc tiền tệ.
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 09/03/2011
            /// </summary>            
            BrandFiciCurrInValid,
            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager: Mặt hàng đã đánh số đủ Serial 
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 24/06/2010
            /// </summary>            
            Serial,
            /// <summary>
            /// Page:Balance.aspx
            /// Messager:Mặt hàng đã được đánh Seri nếu chọn lại mặt hàng sẽ xóa hết Seri bạn có muốn thực hiện ?
            /// Title: Thông báo
            /// Nguoi tạo: Vinhlq    
            /// Ngay tạo: 18/02/2011
            /// </summary>            
            ClearSerial,
            /// <summary>
            /// Page:InwardStock.aspx
            /// Messager:In phiếu nhập kho
            /// Title:In phiếu nhập kho
            /// Nguoi tạo: Tondb
            /// Ngay tạo: 02/08/2011
            /// </summary>            
            PrintInwardReceipt,
            /// <summary>
            /// Page:InwardStock.aspx
            /// Messager:In phiếu xuất kho
            /// Title:In phiếu xuất kho
            /// Nguoi tạo: Tondb
            /// Ngay tạo: 02/08/2011
            /// </summary>            
            PrintOutwardReceipt,
            /// <summary>
            /// Page:InwardStock.aspx
            /// Messager:In Barcode
            /// Title:In Barcode
            /// Nguoi tạo: Tondb
            /// Ngay tạo: 02/08/2011
            /// </summary>            
            PrintBarcode,
            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager:Đơn giá phải >=0
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 24/06/2010
            /// </summary>
            CheckUnitPrice,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Số lượng phải lớn hơn 0
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/07/2010
            /// </summary>
            CheckQuantity,
            /// <summary>
            /// Page:ContractDetail.aspx
            /// Messager:Bạn không thể lưu khi chưa có chi tiết hợp đồng
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 27/07/2010
            /// </summary>
            CheckContractDetail,
            /// <summary>
            /// Page:All
            /// Messager: Chứng từ chưa có chi tiết
            /// Title: Thông báo
            /// Nguoi tạo: Vinhl    
            /// Ngay tạo: 2011/12/27
            /// </summary>
            NotDetail,

            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager:Bạn chưa chọn SerialNO
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 26/06/2010
            /// </summary>
            ChooseSerialItems,
            /// <summary>
            /// Page:BeginItemBalance.aspx
            /// Messager:Item bạn chọn chưa được thiết lập
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 26/06/2010
            /// </summary>
            NotSetupItems,
            /// <summary>
            /// Page:AMDecrease.aspx
            /// Messager:Vui lòng chọn dòng cần xóa
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 21/04/2010
            /// </summary>
            NoSelection,

            /// <summary>
            /// Page:All
            /// Messager:Nhập kho chi tiền mặt
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq    
            /// Ngay tạo: 28/03/2011
            /// </summary>
            InStockCash,
            /// <summary>
            /// Page:All
            /// Messager:Xuất kho chi tiền mặt
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq    
            /// Ngay tạo: 28/03/2011
            /// </summary>
            OutStockCash,

            /// <summary>
            /// Page:CM
            /// Messager: Những chứng từ :
            /// Title: Thông báo
            /// Nguoi tạo: vinhlq    
            /// Ngay tạo: 29/03/2011
            /// </summary>
            Documents,

            /// <summary>
            /// Page:AMDecrease.aspx
            /// Messager:Dữ liệu không được rỗng
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 21/04/2010
            /// </summary>
            IsRequired,
            /// <summary>
            /// Page:SetupStock.aspx.cs
            /// Messager:Vị trí của kho{0} đã được sử dụng nên không thể xóa!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 07/09/2010
            /// </summary>
            PositionHaveAlready,
            /// <summary>
            /// Page:SetupStock.aspx.cs
            /// Messager:Kho{0} đã được sử dụng nên không thể xóa!
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 07/09/2010
            /// </summary>
            WarehouseHaveAlready,
            /// <summary>
            /// Page:SetupStock.aspx.cs
            /// Messager:Mã kho không thể trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/10/2010
            /// </summary>
            StockNOIsValid,
            /// <summary>
            /// Page:SetupStock.aspx.cs
            /// Messager:Tên kho không thể trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/10/2010
            /// </summary>
            StockNAMEIsValid,
            /// <summary>
            /// Page:SetupStock.aspx.cs
            /// Messager:Loại kho không thể trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/10/2010
            /// </summary>
            StockTYPEIsValid,
            /// <summary>
            /// Page:SetupStock.aspx.cs
            /// Messager:Thủ kho không được trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/10/2010
            /// </summary>
            StockManager,
            /// <summary>
            /// Page:SetupStock.aspx.cs
            /// Messager:Tên vị trí theo kho không được trống
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 18/10/2010
            /// </summary>
            PositionHouse,
            /// <summary>
            /// Page:SetupStock.aspx.cs
            /// Messager:Thêm mới dữ liệu
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/08/2011
            /// </summary>
            NewDetail,
            /// <summary>
            /// Page:SetupStock.aspx.cs
            /// Messager:Cập nhật dữ liệu
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/08/2011
            /// </summary>
            UpdateDetail,
            /// <summary>
            /// Page:ucPacking.aspx.cs
            /// Messager:Chưa chọn thông tin bao bì cần thao tác
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/10/2010
            /// </summary>
            PackingNoSelect,
            /// <summary>
            /// Page:ucPacking.aspx.cs
            /// Messager:Có sự thay đổi dữ liệu.Bạn có muốn lưu?
            /// Title: Thông báo
            /// Nguoi tạo: tondb    
            /// Ngay tạo: 19/10/2010
            /// </summary>
            SaveBeforeCancel,
            /// <summary>
            /// Page:Business.aspx
            /// Messager: Giá trị trong {0} này không hợp lệ!?
            /// Title: Thông báo
            /// Nguoi tạo: sonnt    
            /// Ngay tạo: 15/7/2009
            /// </summary>
            InvalidValueInCell,

            /// <summary>
            /// Page:Business.aspx
            /// Messager: Bạn có thực sự muốn thay đổi nghiệp vụ?
            /// Title: Thông báo
            /// Nguoi tạo: sonnt    
            /// Ngay tạo: 15/7/2009
            /// </summary>
            ChangeBusinessAlert,
            /// <summary>
            /// Page:ContractType.aspx
            /// Messager: Dữ liệu không được rỗng!  
            /// Title: Thông báo        
            /// </summary>
            DataNotNull,
            /// <summary>
            /// Page:ContractType.aspx
            /// Messager: Tên khách hàng chưa nhập!  
            /// Title: Thông báo        
            /// </summary>
            CustomerNotNull,

            /// <summary>
            /// Page:Contract.aspx
            /// Messager: Mã hợp đồng này đã được sử dụng  
            /// Title: Thông báo
            /// Nguoi tạo: Nguyen Hai Duong
            /// Ngay tạo: 10/4/2009
            /// </summary>
            DuplicateContractNo,
            /// <summary>
            /// Page:Project.aspx
            /// Messager: Mã dự án này đã được sử dụng  
            /// Title: Thông báo
            /// Nguoi tạo: Nguyen Hai Duong
            /// Ngay tạo: 15/4/2009
            /// </summary>
            DuplicateProjectNo,
            /// <summary>
            /// Messager: Chứng từ này đã được sử dụng không thể xóa.
            /// Title: Thông báo
            /// Nguoi tạo: Lê Quốc Vinh
            /// Ngay tạo: 20/07/2010
            /// </summary>
            DuplicateDocument,
            /// <summary>
            /// Page:AddObject.aspx
            /// Messager: Mã đối tượng này đã được sử dụng  
            /// Title: Thông báo
            /// Nguoi tạo: Nguyen Hai Duong
            /// Ngay tạo: 23/4/2009
            /// </summary>
            DuplicateObjectNo,
            /// <summary>
            /// Page: Declaration.aspx
            /// Messager: Số tờ khai đã tồn tại, xin kiểm tra lại.
            /// Title: Lỗi
            /// </summary>
            DuplicateDeclarationNo,
            /// <summary>
            /// Page: Declaration.aspx
            /// Messager: Thông tin tờ khai không hợp lệ, xin kiểm tra lại.
            /// Title: Lỗi
            /// </summary>
            InvalidDeclaration,
            /// <summary>
            /// Page: Declaration.aspx
            /// Messager: Lưu thông tin tờ khai thành công.
            /// Title: Thông báo
            /// </summary>
            DeclaredSuccessfully,

            /// <summary>
            /// Page: Declaration.aspx
            /// Messager: Đã có lỗi xảy ra khi hệ thống xử lý tờ khai, xin hãy thử lại sau.
            /// Title: Lỗi
            /// </summary>
            DeclarationTransactionFailed,
            /// <summary>
            /// Page: ChartOfAccounts.aspx
            /// Messager: Lưu thông tin tài khoản thành công.
            /// Title: Thông báo
            /// </summary>
            AccountCreatedSuccessfully,
            /// <summary>
            /// Page: ChartOfAccounts.aspx
            /// Messager: Lưu thông tin tài khoản thất bại, xin kiểm tra lại dữ liệu nhập vào.
            /// Title: Lỗi
            /// </summary>
            AccountCreatedFailed,
            /// <summary>
            /// Page: ChartOfAccounts.aspx
            /// Messager: Xoá tài khoản thành công.
            /// Title: Thông báo
            /// </summary>
            AccountDeletedSuccessfully,
            /// <summary>
            /// Page: ChartOfAccounts.aspx
            /// Messager: Xoá tài khoản thất bại, xin kiểm tra lại tài khoản được chọn.
            /// Title: Lỗi
            /// </summary>
            AccountDeletedFailed,
            /// <summary>
            /// Page: BusinessEntryInvoice.aspx
            /// Messager: Mã chứng từ đã tồn tại, xin kiểm tra lại.
            /// Title: Lỗi
            /// </summary>
            DuplicateBusinessNo,
            /// <summary>
            /// Page: BusinessEntryInvoice.aspx
            /// Messager: Thông tin nghiệp vụ không hợp lệ, xin kiểm tra lại.
            /// Title: Lỗi
            /// </summary>
            InvalidBusiness,
            /// <summary>
            /// Page: GL/BusinessList.aspx
            /// Messager: Ghi sổ thành công.
            /// Title: Thông báo
            /// </summary>
            BusinessRecordSuccessful,
            /// <summary>
            /// Page: GL/BusinessList.aspx
            /// Messager: Ghi sổ thất bại, xin kiểm tra lại dữ liệu đã nhập.
            /// Title: Thông báo
            /// </summary>
            BusinessRecordFailed,
            /// <summary>
            /// Page:all
            /// Messager: Chưa ghi sổ.
            /// Title: Thông báo
            /// </summary>
            NotBusiness,
            /// <summary>
            /// Page: BusinessEntryInvoice.aspx
            /// Messager: Lưu nghiệp vụ thành công.
            /// Title: Thông báo
            /// </summary>
            BusinessTransactionSuccessful,
            /// <summary>
            /// Page: BusinessEntryInvoice.aspx
            /// Messager: Đã có lỗi xảy ra khi hệ thống xử lý nghiệp vụ, xin hãy thử lại sau.
            /// Title: Lỗi
            /// </summary>
            BusinessTransactionFailed,

            /// <summary>
            /// Page: BusinessEntryInvoice.aspx
            /// Messager: Tổng hạch toán có và hạch toán nợ không cân xứng, bạn có chắc chắn muốn lưu?
            /// Title: Cảnh báo
            /// </summary>
            NotEqualCreditDebit,
            /// <summary>
            /// Page: GL/BusinessList.aspx
            /// Messager: Tạo lô theo dõi thành công.
            /// Title: Thông báo
            /// </summary>
            AddBatchSuccessful,
            /// <summary>
            /// Page: GL/BusinessList.aspx
            /// Messager: Tạo lô theo dõi thất bại, xin kiểm tra lại dữ liệu đã nhập.
            /// Title: Thông báo
            /// </summary>
            AddBatchFailed,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Vui lòng nhập tên viết tắt?!
            /// Title: Lỗi
            /// </summary>
            TitleSub,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Vui lòng nhập tên ngân hàng?!
            /// Title: Lỗi
            /// </summary>
            TitleBank,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Vui lòng nhập địa chỉ ngân hàng?!
            /// Title: Lỗi
            /// </summary>
            AddressBank,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Vui lòng nhập vào số điện thoại ngân hàng?!
            /// Title: Lỗi
            /// </summary>
            PhoneBank,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Vui lòng nhập vào số Fax ngân hàng?!
            /// Title: Lỗi
            /// </summary>
            FaxBank,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Vui lòng nhập vào Email ngân hàng?!
            /// Title: Lỗi
            /// </summary>
            EmailBank,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Vui lòng nhập vào website ngân hàng?!
            /// Title: Lỗi
            /// </summary>
            WebsiteBank,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Tài khoản tham chiếu không hợp lệ?!
            /// Title: Lỗi
            /// </summary>
            AccountValid,
            /// <summary>
            /// Page:MetaConfig.aspx
            ///  Create date:02/07-2010
            /// Messager: Tài khoản điều chỉnh không hợp lệ?!
            /// Title: Lỗi
            /// </summary>
            AccountNOValid,
            /// <summary>
            /// Page:MetaConfig.aspx
            ///  Create date:02/07-2010
            /// Messager:Module Tài sản có tài khoản {0}{1}{2} không tồn tại?!
            /// Title: Lỗi
            /// </summary>
            AMAccountNOValid,
            /// <summary>
            /// Page:MetaConfig.aspx
            /// Create date:02/07-2010
            /// Messager:Module Tài sản có tài khoản {0}{1}{2} không tồn tại?!
            /// Title: Lỗi
            /// </summary>
            CMAccountNOValid,
            /// <summary>
            /// Page:MetaConfig.aspx
            /// Create date:03/07-2010
            /// Messager:Yêu cầu{0} không thuộc trạng thái cho phép xử lý!
            /// Title: Lỗi
            /// </summary>
            PRNotValid,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Vui lòng nhập vào người liên hệ?!
            /// Title: Lỗi
            /// </summary>
            ContactPersonBank,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Vui lòng chọn tỉnh thành?!
            /// Title: Lỗi
            /// </summary> 
            ProvinceBank,
            /// <summary>
            /// Page:BankList.aspx
            /// Messager: Kiểm tra tên, tên viết tắt, địa chỉ, điện thoại, email và tỉnh thành.
            /// Title: Thông báo
            /// </summary> 
            RequiredBankInfo,
            /// <summary>
            /// Page:DocumentConfig.aspx
            /// Messager: Vui lòng nhập vào mã loại phiếu.
            /// Title: Thông báo
            /// </summary>
            Subs_AutoID,
            /// <summary>
            /// Page:DocumentConfig.aspx
            /// Messager: Chữ số hiện hành không vượt quá 4 ký tự.
            /// Title: Thông báo
            /// </summary>  
            Current_Number,
            /// <summary>
            /// Page:PurposeUse.aspx
            /// Messager: Tên không được để trống.
            /// Title: Thông báo
            /// </summary>               
            InsertName,
            /// <summary>
            /// Page:PurposeUse.aspx
            /// Messager: Vui lòng nhập thông tin mô tả.
            /// Title: Thông báo
            /// </summary> 
            InsertDescription,

            /// <summary>
            /// Page:Material.aspx
            /// Messager: Vui lòng nhập vào mã.
            /// Title: Thông báo
            /// </summary>
            MaterialNo,
            /// <summary>
            /// Page:Packing.aspx
            /// Messager: Vui lòng chọn loại.
            /// Title: Thông báo
            /// </summary>
            PackingType,
            /// <summary>
            /// Page:MaterialLO.aspx
            /// Messager: Vui lòng chọn mã kho hàng.
            /// Title: Thông báo
            /// </summary>
            Wh_AutoID,
            /// <summary>
            /// Page:MaterialLO.aspx
            /// Messager: Vui lòng chọn Tài liệu quản lý.
            /// Title: Thông báo
            /// </summary>
            DocumentID,
            /// <summary>
            /// Page:MaterialLO.aspx
            /// Messager: Vui lòng nhập số lưọng.
            /// Title: Thông báo
            /// </summary>
            Quantity,

            /// <summary>
            /// Page:ArtributeInfo.aspx
            /// Messager: vui lòng nhập vào mã!?.
            /// Title: Thông báo
            /// </summary>
            ArtributeNo,
            /// <summary>
            /// Page:ArtributeInfo.aspx
            /// Messager: vui lòng nhập vào tên?.
            /// Title: Thông báo
            /// </summary> 
            ArtributeName,
            /// <summary>
            /// Page:WareHouse.aspx
            /// Messager: vui lòng nhập vào tên vị trí?.
            /// Title: Thông báo
            /// </summary>      
            De_HouseNamePO,

            /// <summary>
            /// Page:ucDiscountType.aspx
            /// Messager: Kho
            /// Title: Dữ liệu
            /// </summary>   
            WareHouse,
            /// <summary>
            /// Page:WareHouse.aspx
            /// Messager: vui lòng nhập vào tên kho?.
            /// Title: Thông báo
            /// </summary>   
            WareHouseName,
            /// <summary>
            /// Page:Taxlist.aspx
            /// Messager: vui lòng nhập vào mã thuế?.
            /// Title: Thông báo
            /// </summary> 
            TaxNo,
            /// <summary>
            /// Page:Taxlist.aspx
            /// Messager: vui lòng nhập thuế xuất?.
            /// Title: Thông báo
            /// </summary>
            TaxPercent,
            /// <summary>
            /// Page:Taxlist.aspx
            /// Messager: vui lòng chon tai khoan?.
            /// Title: Thông báo
            /// </summary>   
            AccountNo,
            /// <summary>
            /// Page:Taxlist.aspx
            /// Messager: Vui lòng kiểm tra Mã loại thuế, Tài khoản và thuế suất chi tiết. Không được để trống.
            /// Title: Lỗi
            /// </summary>   
            TaxListErrorClient,
            /// <summary>
            /// Page:Province.aspx
            /// Messager: Tên tỉnh thành và quốc gia không được để trống.
            /// Title: Lỗi
            /// </summary>   
            ProvinceErrorClient,
            /// <summary>
            /// Page:Province.aspx
            /// Messager: Khu vực không được trống.
            /// Title: Lỗi
            /// </summary>   
            PlaceForProvineNull,
            /// <summary>
            /// Page:Province.aspx
            /// Messager: Xóa quôc gia này?.
            /// Title: Xác nhận
            /// </summary>   
            DeleteProvince,
            /// <summary>
            /// Page:PaymentTerm.aspx
            /// Messager:ngày thanh toán phải nhỏ hơn ngày kết thúc .
            /// Title: Thông báo
            /// </summary> 
            PaymentTermDate,

            /// <summary>
            /// Page:Messager.aspx
            /// Messager:Từ khoá không đựoc rỗng.
            /// Title: Thông báo
            /// </summary>
            KeySearch,
            /// <summary>
            /// Page:Messager.aspx
            /// Messager:Tiêu đề không đựoc rỗng.
            /// Title: Thông báo
            /// </summary>
            TitleMessager,
            /// <summary>
            /// Page:Messager.aspx
            /// Messager:Nội dung không đựoc rỗng.
            /// Title: Thông báo
            /// </summary>
            NameMessage,
            /// <summary>
            /// Page:Messager.aspx
            /// Messager:Vui lòng chọn ngôn ngử.
            /// Title: Thông báo
            /// </summary>
            LangMessage,
            /// <summary>
            /// Page:
            /// Messager:Vui lòng chọn khu.
            /// Title:
            /// </summary>
            RareaMessage,
            /// <summary>
            /// Page:Page.aspx
            /// Messager:Vui lòng chọn phân hệ.
            /// Title: Thông báo
            /// </summary>
            SubAutoID,
            /// <summary>
            /// Page:User.aspx
            /// Messager:Vui lòng nhập tên đăng nhập.
            /// Title: Thông báo
            /// </summary>
            UserName,
            /// <summary>
            /// Page:User.aspx
            /// Messager:Vui lòng nhập mật khẩu.
            /// Title: Thông báo
            /// </summary>
            PassWord,
            /// <summary>
            /// Page:User.aspx
            /// Messager:Đối tượng không đuợc để trống.
            /// Title: Thông báo
            /// </summary>
            PubObject,
            /// <summary>
            /// Page:User.aspx
            /// Messager:Vui lòng chon nhóm.
            /// Title: Thông báo
            /// </summary>
            UserGroup,
            /// <summary>
            /// Page:Balance.aspx
            /// Messager:Đối tượng không phải là khách hàng.
            /// Title: Thông báo
            /// </summary>
            ObjIsNotCustomer,
            /// <summary>
            /// Page:Atribulte.aspx
            /// Messager:vui lòng nhập tên thuộc tính.
            /// Title: Thông báo
            /// </summary>
            AtriblteName,
            /// <summary>
            /// Page:Atribulte.aspx
            /// Messager:Vui lòng nhập thông tin diễn giải.
            /// Title: Thông báo
            /// </summary>
            AtriblteDes,
            /// <summary>
            /// Page:Atribulte.aspx
            /// Messager:Vui lòng nhập tên chi tiết thuộc tính.
            /// Title: Thông báo
            /// </summary>
            AtriblteNameCT,
            /// <summary>
            /// Page:Atribulte.aspx
            /// Messager:Vui lòng nhập thông tin diễn giải chi tiết thuộc tính.
            /// Title: Thông báo
            /// </summary>
            AtriblteNameCTDes,
            /// <summary>
            /// Page:Atribulte.aspx
            /// Messager:Vui lòng nhập tooltip.
            /// Title: Thông báo
            /// </summary>
            AtriblteNameCTToltip,
            /// <summary>
            /// Page:Atribulte.aspx
            /// Messager:Vui lòng chọn loại thuộc tính.
            /// Title: Thông báo
            /// </summary>
            AtriblteNameCTType,
            /// <summary>
            /// Page:Atribulte.aspx
            /// Messager:Vui lòng chọn ngôn ngử.
            /// Title: Thông báo
            /// </summary>  
            AtriblteNameLanguege,

            /// <summary>
            /// Page:Control.aspx
            /// Messager:Vui lòng nhập controlID.
            /// Title: Thông báo
            /// </summary>
            ControlID,
            /// <summary>
            /// Page:Control.aspx
            /// Messager:Vui lòng nhập diễn giải.
            /// Title: Thông báo
            /// </summary>
            ControlDes,
            /// <summary>
            /// Page:Control.aspx
            /// Messager:Vui lòng chọn loại control.
            /// Title: Thông báo
            /// </summary> 
            ControlType,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Trùng mã hóa đơn
            /// Title: Cảnh báo
            /// </summary>
            DuplicateInvoiceNo,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Vui lòng nhập mã hóa đơn
            /// Title: Cảnh báo
            /// </summary>
            NullInvoiceNo,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Hóa đơn đã sử dụng, không thẻ sửa.
            /// Title: Cảnh báo
            /// </summary>
            InvoiceUsed,
            /// <summary>
            /// Page: All
            /// Messager: Trùng mã.
            /// Title: Cảnh báo
            /// </summary>
            SameNo,
            /// <summary>
            /// Page: Itemlist
            /// Messager: Mặt hàng này đã được sử dụng không thể xóa.
            /// Title: Cảnh báo
            /// </summary>
            ItemUsed,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Hóa đơn có liên quan đến các tài liệu khác, không thể xóa.
            /// Title: Cảnh báo
            /// </summary>
            InvoiceHasRelation,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Hóa đơn này đã bị xóa, vui lòng tìm kiềm lại.
            /// Title: Cảnh báo
            /// </summary>
            InvoiceDeleted,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Thuế nhập khẩu
            /// Title của column trên lưới
            /// </summary>
            ImportTax,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Thuế xuất khẩu
            /// Title của column trên lưới
            /// </summary>
            ExportTax,

            /// <summary>
            /// Page: BatchTransfer.aspx
            /// Messager: Mã lô không được để trống.
            /// Title: Cảnh báo
            /// </summary>
            NoBatchNull,

            /// <summary>
            /// Page: CmrList.aspx
            /// Ngày hóa đơn.
            /// </summary>
            InvoiceDate,

            /// <summary>
            /// Page: BatchList.aspx
            /// Messager: Mã lô này đã tồn tại.
            /// Title: Cảnh báo
            /// </summary>
            DuplicateBatchNo,


            ///</sumary>
            ///Page:Balance
            ///Messager:Vui lòng chọn tài khoản!?
            ///title:thông báo
            ///</Sunary>
            ACC_Name,
            ///</sumary>
            ///Page:Balance
            ///Messager:Vui lòng nhap vao nguyên tệ có hoặc nguyên tệ nợ.
            ///title:thông báo
            ///</Sunary>
            CreditDebtor,
            ///</sumary>
            ///Page:Balance
            ///Messager: Vui lòng chọn loại tiền.
            ///title:thông báo
            ///</Sunary>
            Money,
            ///</sumary>
            ///Page:Balance
            ///Messager:Vui lòng nhap ty gia!?
            ///title:thông báo
            ///</Sunary>
            extchangeMoney,
            ///</sumary>
            ///Page:Balance,InwardStock
            ///Messager:Vui lòng chọn đối tượng.
            ///title:thông báo
            ///</Sunary>
            OBJ_NAME,
            ///</sumary>
            ///Page:Balance
            ///Messager:Vui lòng chon giá thành.
            ///title:thông báo
            ///</Sunary>
            COST_NAME,
            /// <summary>
            ///Page:Balance
            ///Messager: Số dư nguyên tệ có phải lớn hơn không.
            ///title:thông báo
            /// </summary>
            DebCredit,
            /// <summary>
            ///Page:Balance
            ///Messager: Số dư nguyên tệ nợ phải lớn hơn không.
            ///title:thông báo
            /// </summary>
            Debtor,
            /// <summary>
            /// Page: ItemGroups.aspx
            /// Messager: Không được xoá nhóm mặt hàng có chứa nhóm phụ.
            /// Title: Lỗi
            /// </summary>
            ItemGroupHaveChild,

            /// <summary>
            /// Page: ItemGroups.aspx
            /// Messager: Không được xoá nhóm dịch vụ có chứa nhóm phụ.
            /// Title: Lỗi
            /// </summary>
            ServiceGroupHaveChild,

            /// <summary>
            /// Page: ItemGroups.aspx
            /// Messager: Chưa chọn nhóm cha.
            /// Title: Lỗi
            /// </summary>
            ErrorParentGroup,
            /// <summary>
            /// Page: ItemGroups.aspx
            /// Messager: Tạo mới nhóm hàng hóa
            /// Title: Lỗi
            /// </summary>
            NewItemGroupTitle,
            /// <summary>
            /// Page: ItemGroups.aspx
            /// Messager: Tạo mới nhóm hàng hóa
            /// Title: Lỗi
            /// </summary>
            NewServiceGroupTitle,
            /// <summary>
            /// Page: ItemGroups.aspx
            /// Messager: Lưu thông tin thất bại, xin kiểm tra lại dữ liệu nhập.
            /// Title: Lỗi
            /// </summary>
            InforRequired,
            /// <summary>
            /// Page: ItemGroups.aspx
            /// Messager: Nhóm gốc không được trùng với nhóm hiện tại?
            /// Title: Lỗi
            InvalidParentGroup,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Chưa chọn đối tượng?
            /// Title: Lỗi.
            ObjectMissing,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Đối tượng không được để trống.
            /// Title: Lỗi.
            ObjectRequired,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Hóa đơn phải có chi tiết.
            /// Title: Lỗi 
            IVDetailRequired,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Thay đổi loại tiền
            /// Title: Thông báo. 
            CurrencyChange,
            /// <summary>
            /// Page: Invoice.aspx
            /// Messager: Kiểm tra dữ liệu chi tiết, tên mặt hàng không được để trống
            /// Title: Lỗi  
            /// </summary>
            DetailsInformationRequired,
            /// <summary>
            /// Page: CreateUser.aspx
            /// Messager: Tên đăng nhập đã tồn tại?
            /// Title: Thông báo
            DuplicateUsername,
            /// <summary>
            /// Page: BatchTransfer.aspx
            /// Messager: Tổng tỷ lệ phân bổ không đựơc > 100 (%)
            /// Title: Lỗi
            TotalApportion,
            /// <summary>
            /// Page: BatchTransfer.aspx
            /// Messager:Có mã bị trùng
            /// Title: Thông báo
            GLBatchDuplicateNo,
            /// <summary>
            /// Login
            /// Messager: Tài khoản chưa kích hoạt
            /// Title: Thông báo
            NonActive,
            /// <summary>
            /// Connection
            /// Messager: Lỗi kết nối máy chủ
            /// Title: Thông báo
            ConnectionFail,
            /// <summary>
            /// frmLogin
            /// Messager: Tên đăng nhập hoặc password không có dữ liệu
            /// Title: Thông báo
            /// </summary>
            UserNameOrPasswordEmpty,
            /// <summary>
            /// frmLogin
            /// Message: Cài đặt lại đường dẫn kết nối
            /// Title: Thông báo
            /// </summary>
            ReIntal,
            /// <summary>
            /// Page: All
            /// Message: Chưa điều chỉnh mặt hàng
            /// Title: Lỗi
            /// </summary>
            NotAjustment,
            /// <summary>
            /// Page: All
            /// Message:Chưa có ký hiệu
            /// Title: Lỗi
            /// </summary>
            NotSymbol,
            /// <summary>
            /// Page: All
            /// Message: Tên mặt hàng không được để trống.
            /// Title: Lỗi
            /// </summary>
            EmptyItemName,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Số lượng yêu cầu phải lớn hơn 0.
            /// Title: Lỗi
            /// </summary>
            NumberRequestError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Số lượng chấp nhận phải lớn hơn hoặc bằng 0 và nhỏ hơn số lượng yêu cầu.
            /// Title: Lỗi
            /// </summary>
            NumberAcceptError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Đơn gía phải lớn hơn 0.
            /// Title: Lỗi
            /// </summary>
            UnitPriceError,
            /// <summary>
            /// Page:Items.aspx
            /// Message: Đơn gíá không được nhỏ hơn 0.
            /// Title: Lỗi
            /// </summary>
            UnitSalePriceError,
            /// <summary>
            /// Page:Items.aspx
            /// Message: Dữ liệu này đã được thiết lập.
            /// Title: Lỗi
            /// </summary>
            SameValue,
            /// <summary>
            /// Page: All
            /// Message: Chứng từ chưa có thông tin chi tiết.
            /// Title: Lỗi
            /// </summary>
            EmptyDetail,
            /// <summary>
            /// Page: GeneralSaleSetting
            /// Message: Mã hoặc tên của bảng giá không được để trống.
            /// Title: Lỗi
            /// </summary>
            NameorNoTablePrice,
            /// <summary>
            /// Page: GeneralSaleSetting
            /// Message: Mã bảng giá không được trùng.
            /// Title: Lỗi
            /// </summary>
            NoTablePriceisSame,
            /// <summary>
            /// Page: PriceType.aspx
            /// Message:Kiểm tra lại ngày hết hạn của bảng giá
            /// Title: Lỗi
            /// Create date:23-02-2011
            /// </summary>
            ValidExpiredDatePrice,
            /// <summary>
            /// Page: all
            /// Message: Có lỗi trong quá trình thêm mới dữ liệu.
            /// Title: Lỗi
            /// </summary>
            AddFailed,
            /// <summary>
            /// Page: all
            /// Message: Có lỗi trong quá trình cập nhật dữ liệu.
            /// Title: Lỗi
            /// </summary>
            EditFailed,
            /// <summary>
            /// Page: all
            /// Message: Có lỗi trong quá trình hủy bỏ thao tác.
            /// Title: Lỗi
            /// </summary>
            CancelFailed,
            /// <summary>
            /// Page: All
            /// Message: Xin hãy chọn dữ liệu bạn muốn thao tác.
            /// Title: Lỗi
            /// </summary>
            NotSelectItem,
            /// <summary>
            /// Page: All
            /// Message: Chứng từ chọn chưa được duyệt.
            /// Title: Lỗi
            /// </summary>
            DOCISNOTAPP,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Tỷ giá phải lơn hơn 0.
            /// Title: Lỗi
            /// </summary>
            ExchangerateError,
            /// <summary>
            /// Page: CmpBusiness.aspx
            /// Message: Số tiền nhập vào lớn hơn số tiền cần phải trả.
            /// Title: Lỗi
            /// </summary>
            GreatthanDebt,
            /// <summary>
            /// Page: CmpBusiness.aspx
            /// Message: Tài khoản không đủ tiền để chi.
            /// Title: Lỗi
            /// </summary>
            AccNotEnoughMoney,
            /// <summary>
            /// Page: POList.aspx
            /// Message: Các chứng từ phải cùng loại, cùng đối tượng, loại tiền và tỷ giá.
            /// Title: Lỗi
            /// </summary>
            DocumentSame,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Số lượng phải lớn hơn 0.
            /// Title: Lỗi
            /// </summary>
            NumberError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: % Thuế VAT phải lớn hơn hoặc bằng 0 và nhỏ hơn 100.
            /// Title: Lỗi
            /// </summary>
            VatPerError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: % Thuế nhập khẩu phải lớn hơn hoặc bằng 0 và nhỏ hơn 100.
            /// Title: Lỗi
            /// </summary>
            ImportPerError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: % Giảm giá phải lớn hơn hoặc bằng 0 và nhỏ hơn 100.
            /// Title: Lỗi
            /// </summary>
            ReduePerError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: % Thuế tiêu thụ đặc biệt phải lớn hơn hoặc bằng 0 và nhỏ hơn 1000.
            /// Title: Lỗi
            /// </summary>
            ExciseTaxPerError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: % Thuế xuất khẩu phải lớn hơn hoặc bằng 0 và nhỏ hơn 100.
            /// Title: Lỗi
            /// </summary>
            ExportTaxPerError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Kho nhập không thể để trống.
            /// Title: Lỗi
            /// </summary>
            ImportWarehouseError,

            /// <summary>
            /// Page: CM.aspx
            /// Message: Nhập kho bán thành phẩm.
            /// Title: Lỗi
            /// </summary>
            InStockSemiProduct,
            /// <summary>
            /// Page: GeneralSaleSetting.aspx
            /// Message: Loại tiền chưa tồn tại trong hệ thống
            /// Title: Lỗi
            /// </summary>
            EmptyCurrency,


            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Thu hóa đơn.
            /// Title: Lỗi
            /// </summary>
            CMRInvoice,

            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Thu công nợ.
            /// Title: Lỗi
            /// </summary>
            CMRDebt,
            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Thu trước.
            /// Title: Lỗi
            /// </summary>
            CMRFirst,
            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Thu khác.
            /// Title: Lỗi
            /// </summary>
            CMROrther,
            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Thu từ phiếu xuất.
            /// Title: Lỗi
            /// </summary>
            CMRIC,

            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Chi hóa đơn.
            /// Title: Lỗi
            /// </summary>
            CMPInvoice,
            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Chi công nợ.
            /// Title: Lỗi
            /// </summary>
            CMPDebt,
            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Chi trước.
            /// Title: Lỗi
            /// </summary>
            CMPFirst,
            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Chi khác.
            /// Title: Lỗi
            /// </summary>
            CMPOrther,
            /// <summary>
            /// Page: CMLIST.aspx
            /// Message: Chi từ phiếu nhập.
            /// Title: Lỗi
            /// </summary>
            CMPIC,
            /// <summary>
            /// Page: all
            /// Message: Thu đặt cọc
            /// Title: dữ liệu
            /// </summary>
            RevenueBond,
            /// <summary>
            /// Page: all
            /// Message: Thu khách nợ
            /// Title: dữ liệu
            /// </summary>
            IncomeDebtors,
            /// <summary>
            /// Page: all
            /// Message: Chi nợ
            /// Title: dữ liệu
            /// </summary>
            PaymentDebt,



            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Ngày giao hàng không thể nhỏ hơn ngày chứng từ.
            /// Title: Lỗi
            /// </summary>
            DelieverDateError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Người liên hệ không được để trống.
            /// Title: Lỗi
            /// </summary>
            ContactError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: % Chiết khấu phải lớn hơn hoặc bằng 0 và nhỏ hơn 100.
            /// Title: Lỗi
            /// </summary>
            DiscountPerError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Ngày đáo hạn không thể nhỏ hơn ngày chứng từ
            /// Title: Lỗi
            /// </summary>
            EffectiveDateError,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Ngày hiệu lực phải lớn hơn ngày kí
            /// Title: Lỗi
            /// </summary>
            EffectLessSignDate,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Người đại diện không được để trống.
            /// Title: Lỗi
            /// </summary>
            RepresentativePerson,
            /// <summary>
            /// Page: POBusiness.aspx
            /// Message: Địa chỉ giao hàng không được để trống.
            /// Title: Lỗi
            /// </summary>
            DeliveryAddress,

            /// <summary>
            /// Page :ObjList
            /// title: thông báo
            ///Mesasger: Bạn phải xoá hết Đối tượng trước khi xoá nhóm
            /// </summary>
            BeforDeleteObject,
            /// <summary>
            /// Page :ObjList
            /// title: Lỗi
            ///Mesasger: Bạn không thể Xoá nhóm gốc
            /// </summary>
            NotDeleteNodeRoot,
            /// <summary>
            /// Page :ObjList,Organization
            /// title: Lỗi
            ///Mesasger: Phải xóa hết con trước khi xóa cha
            /// </summary>
            NotDeleteNodeParrent,
            /// <summary>
            /// Page :ObjList
            /// title:Thông báo
            ///Mesasger:Không thể thêm nhóm vào nhóm gốc
            /// </summary>
            NotInsertNodeRoot,
            /// <summary>
            /// Create by:Tondb
            /// Create date:11-11-2010
            /// Page :FinancyCycle
            /// title:Thông báo
            ///Mesasger:Năm tài chính đã kết sổ không thể xóa
            /// </summary>
            YearFinancialIsClose,
            /// <summary>
            /// Create by:Tondb
            /// Create date:08-03-2011
            /// Page :FinancyCycle
            /// title:Thông báo
            ///Mesasger:Kỳ tài chính {0} hiện đang mở
            /// </summary>
            FiciIsOpen,
            /// <summary>
            /// Create by:Tondb
            /// Create date:04-10-2011
            /// Page :BusinessResult
            /// title:Tiêu đề
            ///Mesasger:Kỳ này
            /// </summary>
            ThisFiCi,
            /// <summary>
            /// Create by:Tondb
            /// Create date:04-10-2011
            /// Page :BusinessResult
            /// title:Tiêu đề
            ///Mesasger:Kỳ trước
            /// </summary>
            PreFiCi,
            /// <summary>
            /// Create by:Tondb
            /// Create date:04-10-2011
            /// Page :BusinessResult
            /// title:Tiêu đề
            ///Mesasger:Năm này
            /// </summary>
            ThisYear,
            /// <summary>
            /// Create by:Tondb
            /// Create date:04-10-2011
            /// Page :BusinessResult
            /// title:Tiêu đề
            ///Mesasger:Năm trước
            /// </summary>
            PreYear,
            /// <summary>
            /// Create by:Tondb
            /// Create date:04-10-2011
            /// Page :BusinessResult
            /// title:Tiêu đề
            ///Mesasger:(*) Chỉ tiêu này chỉ áp dụng đối với công ty cổ phần
            /// </summary>
            NoteBusinessResult,
            /// <summary>
            /// Create by:Tondb
            /// Create date:08-03-2011
            /// Page :FinancyCycle
            /// title:Thông báo
            ///Mesasger:Kỳ tài chính {0} không thể mở vì kỳ tiếp theo đang đóng.
            /// </summary>
            InValidFiciIsOpen,
            /// <summary>
            /// Create by:Tondb
            /// Create date:14-03-2011
            /// Page :FinancyCycle
            /// title:Thông báo
            ///Mesasger:Bạn có chắc muốn mở sổ kỳ tài chính {0}?
            /// </summary>
            ConfirmFiciIsOpen,
            /// <summary>
            /// Create by:Tondb
            /// Create date:08-03-2011
            /// Page :FinancyCycle
            /// title:Thông báo
            ///Mesasger:Bạn chưa chọn kỳ tài chính để thao tác
            /// </summary>
            ChooseFici,
            /// <summary>
            /// Create by:Tondb
            /// Create date:2011/12/27
            /// Page :All
            /// title:Thông báo
            ///Mesasger:Chưa có Kỳ để thao tác
            /// </summary>
            NotFici,
            /// <summary>
            /// Create by:Tondb
            /// Create date:08-03-2011
            /// Page :FinancyCycle
            /// title:Thông báo
            ///Mesasger:Kì tiếp theo chưa tồn tại, không thể kết chuyển.
            /// </summary>
            NotHaveNextFici,
            /// <summary>
            /// Create by:Tondb
            /// Create date:08-03-2011
            /// Page :FinancyCycle
            /// title:Thông báo
            ///Mesasger:Không thể xóa 
            /// </summary>
            DoNotDelete,
            /// <summary>
            /// Page :ObjList
            /// title:Thông báo
            ///Mesasger:chọn nhóm trước khi thêm đối tượng
            /// </summary>
            ChoiGrouptBeforCreateObject,
            /// <summary>
            /// Page :ObjList
            /// title:Thông báo
            ///Mesasger:Không được thêm đối tượng vào nhóm gốc
            /// </summary>
            NotInserObjectToRoot,
            /// <summary>
            /// Page :ucObject
            /// title:Lỗi
            ///Mesasger:Mã không được Null
            /// </summary>
            IdNotNull,
            /// <summary>
            /// Page :ucObject
            /// title:Lỗi
            ///Mesasger:Tên không được chống
            /// </summary>
            NamenotNull,
            /// <summary>
            /// Page :All
            /// title:Lỗi
            ///Mesasger: Tên này đã được sử dụng.
            /// </summary>
            SameName,
            /// <summary>
            /// Page :ucObject
            /// title:Lỗi
            ///Mesasger: Tab Nhóm Phụ {0} dòng {1} {2} không được để chống
            /// </summary>
            UcObjectTabOtherNotnull,
            /// <summary>
            /// Page :ucObject
            /// title:Lỗi
            ///Mesasger: Tab người Liên hệ  {0} dòng {1}{2} không được để chống
            /// </summary>
            UcObjectTabContactNotnull,
            /// <summary>
            /// Page :ARList, 
            /// title: Thông báo
            ///Mesasger: Đã có lô chứng từ, bạn có muốn thay đổi.
            /// </summary>
            HasPubbatch,
            /// <summary>
            /// Page :ucObject
            /// title:Lỗi
            ///Mesasger:Tab thuộc tổ chức {0} dòng {1}{2} không được để chống
            /// </summary>
            UcObjectTabOrgNotnull,
            /// <summary>
            /// Page :ObjList
            /// title:Thông báo
            ///Mesasger:chọn đối tượng trước khi xoá
            /// </summary>
            ChoiObjectBeforDelete,
            /// <summary>
            /// Page :ucObject
            /// title:Thông báo
            ///Mesasger:Thêm mới Đối tượng
            /// </summary>
            UcObjectInsertWindowTitle,
            /// <summary>
            /// Page :ucObject
            /// title:Thông báo
            ///Mesasger:Cập nhật Đối tượng'
            /// </summary>
            UcObjectUpDateWindowTitle,
            /// <summary>
            /// Page :ucObject
            /// title:Thông báo
            ///Mesasger:Tìm kiếm Tài khoản
            /// </summary>
            WindowTitleFinderAccount,
            /// <summary>
            /// Form : TableMap
            /// Chọn làm bàn chính 
            /// </summary>
            SetUpMainTable,
            /// <summary>
            /// Form  : TableMap
            /// Chọn bàn để ghép
            /// </summary>
            ChooseTableToLink,
            /// <summary>
            /// Form  : TableMap
            /// Chọn bàn trống
            /// </summary>
            ChooseEmptyTable,
            /// <summary>
            /// Form  : TableMap
            /// Chọn bàn phụ
            /// </summary>
            ChooseSubTable,

            /// <summary>
            /// Form : TableMap
            /// Chọn bàn
            /// </summary>
            ChooseTable,
            /// <summary>
            /// Form : PaymentMethod
            /// Không đủ tiền
            /// </summary>
            NotEnoughMoney,
            /// <summary>
            /// Form : TableMap
            /// Bạn có muốn chuyển bàn hay không
            /// </summary>
            ChooseTheDestinationTable,
            /// <summary>
            /// Form  : TableMap
            /// Phiếu đã được chọn
            /// </summary>
            ChooseBillAlready,

            /// <summary>
            /// Form  : TableMap
            /// Chọn quản liếu
            /// </summary>
            ChooseManager,

            /// <summary>
            /// Page :ApBusiness
            /// title:Thông báo
            ///Mesasger: Tiền hàng.
            /// </summary>
            Rankmoney,
            /// <summary>
            /// Page :ApBusiness
            /// title:Thông báo
            ///Mesasger: Thuế tiêu thụ đặc biệt.
            /// </summary>
            Excisetax,
            /// <summary>
            /// Page :ApBusiness
            /// title:Thông báo
            ///Mesasger: Thuế VAT
            /// </summary>
            Vattax,
            /// <summary>
            /// Page :ApBusiness
            /// title:Thông báo
            ///Mesasger: Chiết khấu
            /// </summary>
            Discount,
            /// <summary>
            /// form: frmVoidItem
            /// title: Thông Báo
            /// Mesasger: Đã hoàn tất
            /// </summary>
            ItemIsFinished,
            /// <summary>
            /// form: frmTicketInfo
            /// title: Thông báo
            /// Mesasger: Chưa chọn nhân viên phục vụ
            /// </summary>
            WaiterIsEmpty,
            /// <summary>
            /// Page :InwardStock
            /// title:Thông báo
            ///Mesasger: Số lượng thay đổi, cần tạo lại Serial.
            /// </summary>
            SerialChange,
            /// <summary>
            /// Page :PriceCondition
            /// title:Thông báo
            ///Mesasger: Chưa thiết lập điều kiện.
            /// </summary>
            NotHaveCondition,
            /// <summary>
            /// Page :InwardStock
            /// title:Thông báo
            ///Mesasger: Chấp nhận thay đổi tỷ giá?
            /// </summary>
            ChangeCurrencyRate,
            /// <summary>
            ///Page :ApBusiness
            ///title:Thông báo
            ///Mesasger: Tài khoản nợ chưa chính xác.
            /// </summary>
            DebtorAccount,
            /// <summary>
            ///Page :ApBusiness
            ///title:Thông báo
            ///Mesasger: Tài khoản có chưa chính xác.
            /// </summary>
            CreditAccount,
            /// <summary>
            ///Page :ApBusiness
            ///title:Thông báo
            ///Mesasger: Nếu bạn chọn đối tượng khác sẽ xóa danh sách hóa đơn.
            /// </summary>
            DeleteInvoice,
            /// <summary>
            ///Page :Organization
            ///title:Thông báo
            ///Mesasger: Tổ chức hiện tại có chi nhánh.
            /// </summary>
            OrgHasChild,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Nhóm hàng hóa hiện tại đang có nhóm con.
            /// </summary>
            ItgHasChild,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Nhóm hàng hóa hiện tại đang có mặt hàng mặc định.
            /// </summary>
            ItgHasItemDefault,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Nhóm hàng hóa hiện tại đang có mặt hàng .
            /// </summary>
            ItgHasItem,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Tài khoản nhóm chưa chính xác .
            /// </summary>
            GroupAccount,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Nhóm hoặc tài khoản nhóm chưa chính xác .
            /// </summary>
            GroupAndAccount,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Thuộc tính chưa có giá trị.
            /// </summary>
            AttNoValue,
            /// <summary>
            ///Page :ucItem
            ///title:Thông báo
            ///Mesasger: Giá trị của thuộc tính bị lỗi.
            /// </summary>
            ValueError,

            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Bình Quân.
            /// </summary>
            Average,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: First In First Out.
            /// </summary>
            FIFO,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Last In First Out.
            /// </summary>
            LIFO,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Ngày
            /// </summary>
            Day,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Tháng.
            /// </summary>
            month,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Năm.
            /// </summary>
            Year,
            /// <summary>
            ///Page :ItemsInstock.aspx
            ///title:Thông báo
            ///Mesasger: Có
            /// </summary>
            Yes,
            /// <summary>
            ///Page :ItemsInstock.aspx
            ///title:Thông báo
            ///Mesasger: Không
            /// </summary>
            No,
            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Tuần
            /// </summary>
            Week,

            /// <summary>
            ///Page :ItemsList
            ///title:Thông báo
            ///Mesasger: Nhóm gốc không thể thay đổi.
            /// </summary>
            ItgisRoot,
            /// <summary>
            /// Page : frmLogin Nhà hàng
            /// Hệ thống định dạng không đúng, vui lòng chạy lại chương trình
            /// </summary>
            FormatSystemNotValid,
            /// <summary>
            /// Cảnh báo
            /// Lựa chọn lại đối tượng sẽ thay đổi thông tin định khoản hiện tại
            /// </summary>
            ObjChangedWarning1,
            /// <summary>
            /// Cảnh báo
            /// Lựa chọn lại đối tượng sẽ mất hết thông tin chứng từ và định khoản hiện tại
            /// </summary>
            ObjChangedWarning2,
            /// <summary>
            /// Lỗi
            /// Kỳ tài chính đã đóng. Không thể thao tác
            /// </summary>
            WarningRecall,
            /// <summary>
            /// Đơn hàng đã thanh toán hoặc đã xuất hóa đơn, xuất kho
            /// </summary>

            /// <summary>
            /// Kỳ tài chính đã đóng, không thể thao tác
            /// </summary>
            FiciClose,


            /// <summary>
            /// Lỗi
            /// Chưa chọn hóa đơn
            /// </summary>
            NoIVInfo,
            /// <summary>
            /// Lỗi
            /// Chưa chọn phiếu nhập
            /// </summary>
            NoICInInfo,
            /// <summary>
            /// Lỗi
            /// Chưa chọn phiếu xuất
            /// </summary>
            NoICOutInfo,
            /// <summary>
            /// Lỗi
            /// Thông tin định khoản chưa có
            /// </summary>
            NoEntryInfo,
            /// <summary>
            /// Lỗi
            /// Chưa nhập tài khoản có
            /// </summary>
            NoCreAcc,
            /// <summary>
            /// Lỗi
            /// Chưa nhập tài khoản nợ
            /// </summary>
            NoDepAcc,
            /// <summary>
            /// Lỗi
            /// Chưa nhập tài khoản nợ
            /// </summary>
            NoDocSelect,
            /// <summary>
            /// Lỗi
            /// Chưa nhập tiền
            /// </summary>
            NoMoneyInfo,
            /// <summary>
            /// Tiêu đề
            /// Phiếu chi
            /// </summary>
            PrintCMP,
            /// <summary>
            /// Tiêu đề
            /// Phiếu thu
            /// </summary>
            PrintCMR,
            /// <summary>
            /// Tiêu đề
            /// Không thể tạo phiếu chi cho các chứng từ sau:
            /// </summary>
            CantCreateCMPFor,
            /// <summary>
            /// Tiêu đề
            /// Một số chứng từ đã được tạo phiếu chi. Xin bạn kiểm tra lại
            /// </summary>
            RelationCMP,
            /// <summary>
            /// Tiêu đề
            /// Một số chứng từ đã được tạo phiếu thu. Xin bạn kiểm tra lại
            /// </summary>
            RelationCMR,
            /// <summary>
            /// Tiêu đề
            /// Không thể tạo phiếu thu cho các chứng từ sau:
            /// </summary>
            CantCreateCMRFor,
            /// <summary>
            /// Tiêu đề
            /// Tìm hóa đơn
            /// </summary>
            CMP_BTNSEARCH_INVOICE,
            /// <summary>
            /// Tiêu đề
            /// Tìm kiếm đơn hàng
            /// </summary>
            SEARCH_POSO,
            /// <summary>
            /// Tiêu đề
            /// Tìm chứng từ công nợ
            /// </summary>
            CMP_BTNSEARCH_AP,
            /// <summary>
            /// Tiêu đề
            /// Tìm phiếu thu
            /// </summary>
            CMP_BTNSEARCH_IC,
            /// <summary>
            /// Tiêu đề
            /// Tìm phiếu nhập
            /// </summary>
            CMP_BTNCMPSEARCH_IC,
            /// <summary>
            /// Tiêu đề
            /// Tìm phiếu xuất
            /// </summary>
            CMP_BTNCMRSEARCH_IC,
            /// <summary>
            /// Thông báo
            /// món ăn đã làm xong
            /// </summary>
            Cooked,
            /// <summary>
            /// Thông báo
            /// Đây là bản ghi cuối cùng...!
            /// </summary>
            LastRecord,

            /// <summary>
            /// Thông báo
            /// Đây là bản ghi đầu tiên
            /// </summary>
            FirstRecord,

            /// <summary>
            /// Thông báo
            /// Ghi sổ tạm thất bại.
            /// </summary>
            PostingGLTemporaryFailed,
            /// <summary>
            /// Thông báo
            /// Ghi sổ chính thất bại.
            /// </summary>
            PostingGLMainFailed,
            /// <summary>
            /// Thông báo
            /// Ghi sổ thành công
            /// </summary>
            PostingGLSuccess,
            /// <summary>
            /// Thông báo
            /// Ghi sổ thất bại
            /// </summary>
            PostingGLFailed,
            /// <summary>
            /// Cảnh báo
            /// Số lượng không được trống
            /// </summary>
            QuantityNotEmpty,
            /// <summary>
            /// Thông báo
            /// Vui lòng chọn dòng để xóa
            /// </summary>
            NotHasSelection,

            /// <summary>
            /// Thông báo
            /// Chưa chọn nghiệp vụ cần ghi sổ.
            /// </summary>
            ChoosePostingRecord,
            /// <summary>
            /// Title:Thông báo
            /// Message:Chưa chọn nghiệp vụ cần tạo lô theo dõi
            /// Create by:Tondb
            /// Create date:20-03-2011
            /// Page:BussinessList.aspx
            /// </summary>
            chooseDocumentBatch,
            /// <summary>
            /// Title:Thông báo
            /// Message:Chứng từ {0} đã được ghi sổ
            /// Create by:Tondb
            /// Create date:20-03-2011
            /// Page:BussinessList.aspx
            /// </summary>
            AlreadyPosting,
            /// <summary>
            /// Title:Thông báo
            /// Message:Sổ kho không được báo lỗi
            /// Create by:Tondb
            /// Create date:25-03-2011
            /// Page:BussinessList.aspx
            /// </summary>
            NotErrorStock,
            /// <summary>
            /// Title:Thông báo
            /// Message:Chứng từ {0} đã được ghi sổ chính
            /// Create by:Tondb
            /// Create date:25-03-2011
            /// Page:BussinessList.aspx
            /// </summary>
            DocumentMainPosted,
            /// <summary>
            /// Title:Thông báo
            /// Message:Chứng từ {0} đã được ghi sổ tạm
            /// Create by:Tondb
            /// Create date:25-03-2011
            /// Page:BussinessList.aspx
            /// </summary>
            DocumentTempPosted,
            /// <summary>
            /// Title:Thông báo
            /// Message:Kiểm tra lại dữ liệu trước khi ghi sổ
            /// Create by:Tondb
            /// Create date:25-03-2011
            /// Page:BussinessList.aspx
            /// </summary>
            CheckDataDocumentPosted,
            /// <summary>
            /// Title:Thông báo
            /// Message:Phiếu {0} đã có hóa đơn xuất
            /// Create by:Tondb
            /// Create date:25-03-2011
            /// Page:BussinessList.aspx
            /// </summary>
            DocumentIsInvoiceExt,
            /// <summary>
            /// Title:Thông báo
            /// Message:Phiếu {0} tổng hợp không cho phép xuất hóa đơn
            /// Create by:Tondb
            /// Create date:25-03-2011
            /// Page:BussinessList.aspx
            /// </summary>
            GeneralICNoInvoiceExt,
            /// <summary>
            /// Title:Thông báo
            /// Message:Xuất hóa đơn không thành công
            /// Create by:Tondb
            /// Create date:25-03-2011
            /// Page:BussinessList.aspx
            /// </summary>
            UnsavedInvoiceExt,
            /// <summary>
            /// Title: Tổng hợp
            /// Page:Business.aspx
            /// Create date: 14-01-2012
            /// </summary>
            GeneralInward,
            /// <summary>
            /// Title:Bán thành phẩm
            /// Page:Business.aspx
            /// Create date: 14-01-2011
            /// </summary>
            Semifinished,
            /// <summary>
            /// Title: Chuyển kho
            /// Page:Business.aspx
            /// Create date: 14-01-2011
            /// </summary>
            Stockmovement,
            /// <summary>
            /// Title: Nhà hàng/Bán lẻ
            /// Page:Business.aspx
            /// Create date: 14-01-2011
            /// </summary>
            RetailRestaurant,
            /// <summary>
            /// Title: Thanh toán ngay
            /// Page:Business.aspx
            /// Create date: 14-01-2011
            /// </summary>
            PayDebt,
            /// <summary>
            /// Title: Công nợ
            /// Page:Business.aspx
            /// Create date: 14-01-2011
            /// </summary>
            ByPayable,
            /// <summary>
            /// Title:Nhập kho bán thành phẩm
            /// Page:Business.aspx
            /// Create date: 14-01-2011
            /// </summary>
            SemifinishedProductReceipt,
            /// <summary>
            /// Title:Xuất kho hàng bán
            /// Page:Business.aspx
            /// Create date: 14-01-2011
            /// </summary>
            OutStockItemRetail,
            /// <summary>
            /// Title: Nhập kho hàng bán trả lại
            /// Page:Business.aspx
            /// Create date: 14-01-2011
            /// </summary>
            InwardStockItemReturn,
            /// <summary>
            /// Title: In phiếu kho
            /// Page:Business.aspx
            /// Create date: 14-01-2011
            /// </summary>
            PrintStockReceipt,
            /// <summary>
            /// Thông báo
            /// Chứng từ đã được ghi sổ.
            /// </summary>
            DocumentPosted,

            /// <summary>
            /// Thông báo
            /// Các chứng từ đã được ghi sổ chính
            /// </summary>
            MainPosted,

            /// <summary>
            /// Thông báo
            /// Các chứng từ đã được ghi sổ tạm
            /// </summary>
            TempPosted,

            /// <summary>
            /// Thông báo
            /// Các chứng từ đã được ghi thành công
            /// </summary>
            SuccessfulPosted,

            /// <summary>
            /// Thông báo
            /// Bạn không có quyền đăng nhập vào hệ thống ! Vui lòng liên hệ với Admin để được cấp quyền.
            /// </summary>
            NotRoleLogin,

            /// <summary>
            /// Thông báo
            /// Các chứng từ đã được ghi không thành công
            /// </summary>
            UnsuccessfulPosted,
            /// <summary>
            /// Thông báo
            /// Trạng thái Sổ kho
            /// </summary>            
            StatusStockJoin,
            /// <summary>
            /// Dữ liệu
            /// Sổ kho
            /// </summary>            
            BookStock,
            /// <summary>
            /// Dữ liệu
            /// Sổ kế toán
            /// </summary>            
            BookAccount,
            /// <summary>
            /// Thông báo
            /// Sổ kho
            /// </summary>            
            StockPosted,
            /// <summary>
            /// Thông báo
            /// Tạo mới
            /// </summary>

            OnListCustomer,
            /// <summary>
            /// In List
            /// </summary>

            Used,
            /// <summary>
            /// Voucher/Coupon
            /// da du`ng
            /// </summary>

            NotUsed,
            /// <summary>
            /// Voucher/Coupon
            /// chưa du`ng
            /// </summary>

            Expired,
            /// <summary>
            /// Voucher/Coupon
            /// het chan su dung
            /// </summary>
            /// 
            Usable,
            /// <summary>
            /// Voucher/Coupon
            /// Chua het chan su dung
            /// </summary
            NotListedCustomer,
            /// <summary>
            /// Not Listed
            /// </summary>

            /// <summary>
            /// Phần % giảm vượt quá mức cho phép
            /// </summary>
            InvalidPercent,

            /// <summary>
            /// In và kết thúc
            /// </summary>
            PrintAndFinish,

            /// <summary>
            /// In tạm tính
            /// </summary>
            Print,
            /// <summary>
            /// Tạo mới
            /// </summary>
            NewStatus,
            /// <summary>
            /// Đang khấu hao
            /// </summary>
            Depreciating,
            /// <summary>
            /// Ngừng khấu hao
            /// </summary>
            StopDepreciation,
            /// <summary>
            /// Khấu hao xong
            /// </summary>
            Depreciation,
            /// <summary>
            /// Thanh lý
            /// </summary>
            Clearance,
            /// <summary>
            /// Ngày bắt đầu
            /// </summary>
            BeginDate,
            /// <summary>
            /// Ngày tạm ngưng
            /// </summary>
            StopDate,
            /// <summary>
            /// Bắt đầu khấu hao
            /// </summary>
            BeginDepreciation,
            /// <summary>
            /// Message: Tổng nguồn vốn phải bằng nguyên giá tài sản
            /// Page:AmAssetItemDetail.aspx
            /// Create by:Tondb
            /// Create date:24-11-2011
            /// </summary>
            GrandofAmountNotEquaOrginalAmount,
            /// <summary>
            /// Message: Tỷ lệ (%) không được để trống
            /// Page:AMAllocation.aspx
            /// Create by:Vinhlq
            /// Create date:15-12-2011
            /// </summary>
            NotPercent,
            /// <summary>
            /// Message: Tài khoản chi phí không được trống.
            /// Page:AMAllocation.aspx
            /// Create by:Vinhlq
            /// Create date:15-12-2011
            /// </summary>
            NotCostAccount,
            /// <summary>
            /// Message: Chưa chọn đối tượng chi phí
            /// Page:AMAllocation.aspx
            /// Create by:Vinhlq
            /// Create date:15-12-2011
            /// </summary>
            NotCostObjects,
            /// <summary>
            /// Message:Chưa chọn chứng từ cần ghi lỗi
            /// Page:GLBussiness.aspx
            /// Create by:Tondb
            /// Create date:23-03-2011
            /// </summary>
            ChooseDocumentError,
            /// <summary>
            /// Message:Chứng từ {0} đang bị lỗi
            /// Page:GLBussiness.aspx
            /// Create by:Tondb
            /// Create date:23-03-2011
            /// </summary>
            DocumentError,
            /// <summary>
            /// Message:Chứng từ {0} không thuộc trạng thái cho báo lỗi
            /// Page:GLBussiness.aspx
            /// Create by:Tondb
            /// Create date:23-03-2011
            /// </summary>
            DocumentNew,
            /// <summary>
            /// Message:Bạn chưa nhập nội dung lỗi
            /// Page:GLBussiness.aspx
            /// Create by:Tondb
            /// Create date:23-03-2011
            /// </summary>
            DescriptionError,
            /// <summary>
            /// Message:Kiểm tra lại dữ liệu muốn báo lỗi
            /// Page:GLBussiness.aspx
            /// Create by:Tondb
            /// Create date:23-03-2011
            /// </summary>
            InvalidDescriptionError,
            /// <summary>
            /// Thông báo
            /// Duyệt
            /// </summary>
            Approve,
            /// <summary>
            /// Thông báo
            /// Không duyệt
            /// </summary>
            NotApprove,
            /// <summary>
            /// Thông báo
            /// Sửa
            /// </summary>
            RequestFix,
            /// <summary>
            /// Thông báo
            /// Đã sửa lại
            /// </summary>
            FixBug,

            /// <summary>
            /// Thông báo
            /// Các chứng từ đã được ghi sổ tạm thành công
            /// </summary>
            TempBook,

            /// <summary>
            /// Thông báo
            /// Các chứng từ đã được ghi sổ chính thành công
            /// </summary>
            MainBook,
            /// <summary>
            /// Tiêu đề
            /// Số Chính
            /// AccountBalance.aspx
            /// </summary>
            BookMain,
            /// <summary>
            /// Tiêu đề
            /// Số tạm
            /// AccountBalance.aspx
            /// </summary>
            BookTemp,
            /// <summary>
            /// Thông báo
            /// Trạng thái lỗi
            /// </summary>
            Error,

            /// <summary>
            /// Thông báo
            /// Chưa chọn mặt hàng
            /// </summary>
            EmptyItemNo,

            /// <summary>
            /// Thông báo
            /// Chưa nhập ngày bắt đầu.
            /// </summary>
            EmptyDateFrom,

            /// <summary>
            /// Thông báo
            /// Số lượng nhập không đúng, hãy nhập lại.
            /// </summary>
            EmptyInputQuantity,

            /// <summary>
            /// Thông báo
            /// Chưa chọn phân loại cho mặt hàng.
            /// </summary>
            EmptyItemType,

            /// <summary>
            /// Thông báo
            /// Chưa chọn đơn vị tính cho mặt hàng.
            /// </summary>
            EmptyUnit,

            /// <summary>
            /// Thông báo
            /// Đơn giá nhập không đúng, hãy nhập lại.
            /// </summary>
            EmptyPrice,

            /// <summary>
            /// Thông báo
            /// Số lượng căn bản 1 nhập không đúng, hãy nhập lại.
            /// </summary>
            EmptyBaseQuantity1,

            /// <summary>
            /// Thông báo
            /// Số lượng căn bản 2 nhập không đúng, hãy nhập lại.
            /// </summary>
            EmptyBaseQuantity2,

            /// <summary>
            /// Thông báo
            /// Tỷ lệ qui đổi 2 nhập không đúng, hãy nhập lại.
            /// </summary>
            EmptyRateQuantity1,

            /// <summary>
            /// Thông báo
            /// Tỷ lệ qui đổi 2 nhập không đúng, hãy nhập lại.
            /// </summary>
            EmptyRateQuantity2,

            /// <summary>
            /// Thông báo
            /// Số lượng lưu kho 1 nhập không đúng, hãy nhập lại.
            /// </summary>
            EmptyStoreQuantity1,

            /// <summary>
            /// Thông báo
            /// Số lượng lưu kho 2 nhập không đúng, hãy nhập lại.
            /// </summary>
            EmptyStoreQuantity2,
            /// <summary>
            /// Create by:Tondb
            /// Create date:27-10-2010
            /// Page:ChartOfAccount.aspx
            /// Description:Tài khoản đã tồn tại hoặc rỗng
            /// </summary>
            AccountExist,
            /// <summary>
            /// Create by:Tondb
            /// Create date:27-10-2010
            /// Page:ChartOfAccount.aspx
            /// Description:Loại tài khoản không tồn tại
            /// </summary>
            AccountTypeNotExits,
            /// <summary>
            /// Create by:Tondb
            /// Create date:27-10-2010
            /// Page:ChartOfAccount.aspx
            /// Description:Nhóm tài khoản không tồn tại
            /// </summary>
            AccountGroupNotExits,
            /// <summary>
            /// Create by:Tondb
            /// Create date:27-10-2010
            /// Page:ChartOfAccount.aspx
            /// Description:Không tìm thấy máy in
            /// </summary>
            NotFoundPrinter,
            /// <summary>
            /// Create by:Tondb
            /// Create date:20-01-2011
            /// Page:PriceType.aspx
            /// Description:Giá phải lớn hoặc bằng 0
            /// </summary>
            IsValidPriceService,
            /// <summary>
            /// Create by:Tondb
            /// Create date:22-01-2011
            /// Page:PriceType.aspx
            /// Description:Bảng giá đã bị xóa
            /// </summary>
            DeletePriceType,
            /// <summary>
            /// Create by:Tondb
            /// Create date:22-01-2011
            /// Page:PriceType.aspx
            /// Description:Loại bàn đã bị xóa
            /// </summary>
            DeleteTableType,
            /// <summary>
            /// Create by:Tondb
            /// Create date:22-01-2011
            /// Page:PriceType.aspx
            /// Description:Loại giờ đã bị xóa
            /// </summary>
            DeleteTimeType,
            /// <summary>
            /// Create by:Vinhlq
            /// Create date:22/06/2011
            /// Page:ucDiscountType.aspx
            /// Description:Chưa chọn loại giờ.
            /// </summary>
            ChoiceTimeType,

            /// <summary>
            /// Thông báo
            /// CHưa chọn kho nhập
            /// </summary>
            EmptyWarehouse,

            /// <summary>
            /// thông báo
            /// chưa chọn ngôn ngữa
            /// </summary>
            EmptyLanguage,

            /// <summary>
            /// Thông báo
            /// Chưa chọn nhập vị trí
            /// </summary>
            EmptyPosition,

            /// <summary>
            /// Thông báo
            /// Vị trí của kho chưa chính xác.
            /// </summary>
            PositionNotCorrect,
            /// <summary>
            /// Thông báo
            /// Kho chưa chính xác.
            /// </summary>
            WarehouseNotCorrect,
            /// <summary>
            /// Thông báo
            /// Vị trí kho không thuộc kho hiện tại.
            /// </summary>
            PositionNotinWarehouse,

            /// <summary>
            /// Thông báo
            /// Chưa chọn lô hàng
            /// </summary>
            EmptyPlot,

            /// <summary>
            /// Thông báo
            /// Vận chuyển
            /// </summary>
            TransportTitle,

            /// <summary>
            /// Thông báo
            /// Tài khoản sai
            /// </summary>
            BadAccount,

            /// <summary>
            /// Thông báo
            /// Còn tồn tại chứng từ của kỳ sau không thể thao tác.
            /// </summary>
            NotActionExistDocument,

            /// <summary>
            /// Thông báo
            /// Không được sửa khi đã ghi bảng tạm
            /// </summary>
            NotEditTempPosted,

            /// <summary>
            /// Thông báo
            /// Không được sửa khi đã ghi bảng chính
            /// </summary>
            NotEditMainPosted,
            /// <summary>
            /// Nguyên giá điều chỉnh phải lớn hơn 0
            /// </summary>
            AdjustAmount,
            /// <summary>
            /// Ngày bắt đầu điều chỉnh không được trống
            /// </summary>
            AdjustBeginDate,
            /// <summary>
            /// Số kỳ khấu hao phải lớn hơn 0
            /// </summary>
            ValidFiciNumber,
            /// <summary>
            /// Kiểm tra lại ngày chứng từ
            /// </summary>
            ValidDocumentDate,
            /// <summary>
            /// Thông báo
            /// Không được xóa khi đã ghi bảng chính
            /// </summary>
            NotDeleteMainPosted,

            /// <summary>
            /// Thông báo hết hàng mặt hàng
            /// </summary>
            ItemOutOfStock,

            /// <summary>
            /// " chỉ bán được "
            /// </summary>
            CanSell,

            /// <summary>
            /// Thông báo
            /// Không được xóa khi đã ghi bảng tạm
            /// </summary>
            NotDeleteTempPosted,

            /// <summary>
            /// Thông báo
            /// Ngày chứng từ chưa đúng
            /// </summary>
            DocumentDate,

            /// <summary>
            /// Thông báo
            /// Ngày đáo hạn chưa đúng
            /// </summary>
            MaturityDate,

            /// <summary>
            /// Thông báo
            /// Ngày đáo hạn không được rỗng
            /// </summary>
            EmptyExpireDate,
            /// <summary>
            /// Thông báo
            /// Chưa tạo serial
            /// </summary>
            EmptySerial,
            /// <summary>
            /// Thông báo
            /// Mặt hàng cấu hình Serial, số lượng phải nguyên
            /// </summary>
            SerialInteger,
            /// <summary>
            /// Thông báo
            /// Chưa tạo plot
            /// </summary>
            EmptyPlots,


            /// <summary>
            /// Thông báo
            /// Không chọn phần tử nào trong combobox
            /// </summary>
            NoneSelect,


            /// <summary>
            /// Thông báo
            /// Mặt hàng này không có trong danh sách mặt hàng
            /// </summary>
            ItemNotExist,

            /// <summary>
            /// Thông báo
            /// Điều chỉnh tăng thì giá trị điều chỉnh không thể giảm.
            /// </summary>
            InCreaseValueAdjustment,

            /// <summary>
            /// Thông báo
            /// Điều chỉnh giảm thì giá trị điều chỉnh không thể tăng.
            /// </summary>
            DecreaseValueAdjustment,
            /// <summary>
            /// Thông báo
            /// Điều chỉnh giảm thì số lượng 2 không thể tăng.
            /// </summary>
            InCreaseQuatityAdjustment,
            /// <summary>
            /// Thông báo
            /// Điều chỉnh tăng thì số lượng 2 không thể giảm.
            /// </summary>
            DecreaseQuatityAdjustment,
            /// <summary>
            /// Thông báo
            /// Điều chỉnh tăng thì số lượng 2 không thể giảm.
            /// </summary>
            Adjustment,
            /// <summary>
            /// Thông báo
            /// Điều chỉnh giảm thì giá trị điều chỉnh không thể tăng.
            /// </summary>
            OnlyBatchGL,

            /// <summary>
            /// Thông báo
            /// Điều chỉnh giảm thì giá trị điều chỉnh không thể tăng.
            /// </summary>
            NotBatchGL,
            /// <summary>
            /// Thông báo
            /// Tồn đầu kỳ ĐVT 1
            /// </summary>
            BeginFinan1,
            /// <summary>
            /// Thông báo
            /// Tồn đầu kỳ ĐVT 2
            /// </summary>
            BeginFinan2,
            /// <summary>
            /// Thông báo
            /// Tồn đầu kỳ ĐVT 1
            /// </summary>
            EndFinan1,
            /// <summary>
            /// Thông báo
            /// Tồn đầu kỳ ĐVT 2
            /// </summary>
            EndFinan2,

            /// <summary>
            /// Thông báo
            /// Nhập Đơn Vị Tính 1
            /// </summary>
            InputQuantity1,
            /// <summary>
            /// Thông báo
            /// Nhập Đơn Vị Tính 2
            /// </summary>
            InputQuantity2,
            /// <summary>
            /// Thông báo
            /// Xuất Đơn Vị Tính 1
            /// </summary>
            OutputQuantity1,
            /// <summary>
            /// Thông báo
            /// Xuất Đơn Vị Tính 2
            /// </summary>
            OutputQuantity2,
            /// <summary>
            /// Đơn Vị Tính 1
            /// </summary>
            TitleUom1,
            /// <summary>
            /// Đơn Vị Tính 2
            /// </summary>
            TitleUom2,
            /// <summary>
            /// Không tồn
            /// </summary>
            NotQuantity,
            /// <summary>
            /// Tồn âm
            /// </summary>
            NegativeTitle,
            /// <summary>
            /// Tồn dương
            /// </summary>
            PostiveTitle,
            /// <summary>
            /// Thông báo
            /// Mã thẻ không hợp lệ
            /// </summary>
            InvalidCardNumber,

            /// <summary>
            /// Lỗi
            /// Chưa có thông tin chứng từ công nợ
            /// </summary>
            NoDepInfo,

            /// Page :Area
            /// title:
            ///Mesasger:Chưa chọn trung tâm
            NotCenter,

            /// Page :Area
            /// title:
            ///Mesasger:Khu không được để trống
            NotArea,

            /// Page :Area
            /// title:
            ///Mesasger:Mã không được để trống
            NotDocNo,


            /// Page :Area
            /// title:
            ///Mesasger:Tên không được để trống
            NotName,

            /// <summary>
            /// Page :Table
            /// title:
            ///Mesasger:Mã này đã tồn tại, vui lòng chọn mã khác
            /// </summary>
            DuplicateCode,

            /// Page :Table
            /// title:
            ///Mesasger:Số chỗ ngồi không được để trống
            NotSeat,

            /// Page :Table
            /// title:
            ///Mesasger:Tọa độ X k được bỏ trống
            NotCoorDinateX,

            /// Page :Table
            /// title:
            ///Mesasger:Độ trong suốt không được bỏ trống
            NotTransparent,

            /// Page :Table
            /// title:
            ///Mesasger:Tọa độ X k được bỏ trống
            NotCoorDinateY,

            /// Page :Table
            /// title:
            ///Mesasger:Loại bàn không được để trống
            NotTableType,

            /// Page :Print
            /// title:
            ///Mesasger:Máy in không tìm thấy
            PrinterNotFound,

            /// <summary>
            /// Vuông
            /// </summary>
            Square,

            /// <summary>
            /// Tròn
            /// </summary>
            Circle,

            /// <summary>
            /// phiếu chưa được khởi tạo
            /// </summary>
            NoTicket,

            /// <summary>
            /// giá trị tiền nhập không đúng
            /// </summary>
            InvalidMoneyFormat,

            /// <summary>
            /// Chưa có phiếu để thanh toán
            /// </summary>
            NoTicketForPayment,

            /// <summary>
            /// Tìm kiếm
            /// </summary>
            Search,

            /// <summary>
            /// Chọn ít nhất phải > 0
            /// </summary>
            MinChoiceLargerZero,

            /// <summary>
            /// Thứ tự trình bày nhập chưa đúng
            /// </summary>
            DisplayOrder,

            /// <summary>
            /// Chọn nhiều nhất phải > 0
            /// </summary>
            MaxChoiceLargerZero,

            /// <summary>
            /// Chọn ít nhất phải <= nhiều nhất
            /// </summary>
            MinChoiceNotLargerMaxChoice,

            /// <summary>
            /// Ngày tạo phải không lớn hơn ngày hết hạn
            /// </summary>
            CreateDateNonLargerExpireDate,

            /// <summary>
            /// Sao chép giá bán
            /// </summary>
            CopyPrice,

            /// <summary>
            /// Ngày thường
            /// </summary>
            NormalDate,

            /// <summary>
            /// Thứ 7
            /// </summary>
            Saturday,

            /// <summary>
            /// Chủ nhật
            /// </summary>
            Sunday,


            /// <summary>
            /// Thứ 4
            /// </summary>
            Wednesday,

            /// <summary>
            /// Tạo mới dữ liệu
            /// </summary>
            AddNewData,

            /// <summary>
            /// Cập nhật
            /// </summary>
            Update,

            /// <summary>
            /// Số lượng yêu cầu nhập không đủ
            /// </summary>
            InsufficientNumberOFRequests,

            /// <summary>
            /// Chứng từ đã được tạo phiếu chi, bạn không có quyền sửa.
            /// </summary>
            IsCreatedCMP,

            /// <summary>
            /// Packing này đã được sử dụng --> không được xóa
            /// </summary>
            UnsuccessfullDeletePacking,

            /// <summary>
            /// Ưu tiên
            /// </summary>
            Priority,

            /// <summary>
            /// Món mở
            /// </summary>
            OpenItem,

            /// <summary>
            /// Tất cả
            /// </summary>
            All,
            /// <summary>
            /// Không theo lô
            /// </summary>
            NoBatch,
            /// <summary>
            /// Theo lô
            /// </summary>
            HaveBatch,
            /// <summary>
            /// Không Menu
            /// </summary>
            NoMenu,
            /// <summary>
            /// Có Menu
            /// </summary>
            HaveMenu,
            /// <summary>
            /// Không có Seri
            /// </summary>
            NoSeri,
            /// <summary>
            /// Có Seri
            /// </summary>
            HaveSeri,
            /// <summary>
            /// Kích hoạt
            /// </summary>
            Active,
            /// <summary>
            /// Không kích hoạt
            /// </summary>
            NoActive,

            /// <summary>
            /// Thu khác
            /// </summary>
            PayIn,

            /// <summary>
            /// Khách nợ
            /// </summary>
            CustomerDebt,

            /// <summary>
            /// giảm tiền quá giá trị của mặt hàng
            /// </summary>
            InvalidMoneyDiscount,

            /// <summary>
            /// Đặt cọc
            /// </summary>
            Deposit,
            /// <summary>
            /// Chưa nhập thông tin ngân hàng
            /// </summary>
            BankInfoRequired,

            /// <summary>
            /// Số món đã đủ, bạn không thể chọn thêm
            /// </summary>
            ChoiceSetMenuIsMax,

            /// <summary>
            /// Số món chưa đủ, mời bạn chọn thêm
            /// </summary>
            ChoiceSetMenuIsMin,
            /// <summary>
            /// Bàn dài
            /// </summary>
            LongTable,
            /// <summary>
            /// Bàn tròn
            /// </summary>
            CircleTable,
            /// <summary>
            /// Mã bảo hiểm không được rỗng
            /// </summary>
            EmptyInsurance,

            /// <summary>
            /// Mã tài sản không được rỗng
            /// </summary>
            EmptyAssetsNo,


            /// <summary>
            /// Tài sản đã bị thay đổi
            /// </summary>
            ChangeAsset,

            /// <summary>
            /// Chưa chọn tài sản
            /// </summary>
            EmptyAsset,

            /// <summary>
            /// Công cụ dụng cụ
            /// </summary>
            ToolData,
            /// <summary>
            /// Tài sản cố định
            /// </summary>
            AssetData,
            /// <summary>
            /// Bạn không thể thao tác vì đã có chứng từ tác động nguyên giá tài sản.
            /// </summary>
            NotSavePepreciation,
            /// <summary>
            /// Mặt hàng không tồn tại trong phiếu bán hàng
            /// </summary>
            SystemErrorVoid,

            /// <summary>
            /// Loại bảo hiểm không được rỗng
            /// </summary>
            EmptyInsuranceType,

            /// <summary>
            /// Ngày hiệu lực không được rỗng
            /// </summary>
            EmptyValidDate,

            /// <summary>
            /// Ngày áp dụng không được rỗng
            /// </summary>
            EmptyApplyDate,
            /// <summary>
            /// Create by:Tondb
            /// Create date:11-03-2011
            /// Message:Số tiền của voucher phải lớn hơn 0
            /// Page:GiftCardType.aspx
            /// </summary>
            VoucherMoney,
            /// <summary>
            /// Create by:Tondb
            /// Create date:11-03-2011
            /// Message:Bạn phải chọn loại hình kinh doanh cho voucher
            /// Page:GiftCardType.aspx
            /// </summary>
            VoucherBusinessType,
            /// <summary>
            /// Create by:Tondb
            /// Create date:11-03-2011
            /// Message:Bạn phải chọn chính sách giảm giá cho coupon
            /// Page:GiftCardType.aspx
            /// </summary>
            VoucherDiscountType,
            /// <summary>
            /// Create by:Tondb
            /// Create date:11-03-2011
            /// Message:Không thể xóa khi có chi tiết
            /// Page:GiftCardType.aspx
            /// </summary>
            DeleteParent,
            /// <summary>
            /// Ngày hết hạn không được rỗng
            /// </summary>
            EmptyExpiredDate,

            /// <summary>
            /// Số tiền bảo hiểm không được rỗng
            /// </summary>
            EmptyInsuranceMoney,

            /// <summary>
            /// Số tiền bảo hiểm tối đa không được rỗng
            /// </summary>
            EmptyInsuranceMaxMoney,

            /// <summary>
            /// Số tiền bảo hiểm tối thiểu không được rỗng
            /// </summary>
            EmptyInsuranceMinMoney,

            /// <summary>
            /// Bạn phải in phiếu trước khi kết thúc, bạn có muốn in?
            /// </summary>
            TicketNotPrinted,

            /// <summary>
            /// Có món chưa order, bạn có muốn order?
            /// </summary>
            WantToOrder,

            /// <summary>
            /// Thông tin tài khoản không hợp lệ.
            /// </summary>
            IncorrectAccount,

            /// <summary>
            /// Số tài khoản đã tồn tại, xin kiểm tra lại.
            /// </summary>
            DupplicateAccount,

            /// <summary>
            /// Không được xoá tài khoản có chứa tài khoản phụ.
            /// </summary>
            CantDeleteAccount,

            /// <summary>
            /// Thông tin tài khoản không hợp lệ.
            /// </summary>
            EmptySelectionAccount,

            /// <summary>
            /// Phiếu chưa được thanh toán, bạn có muốn lưu phiếu?
            /// </summary>
            TicketNotPayment,

            /// <summary>
            /// Don hang da dc tao hop dong
            /// </summary>
            SoCreateCot,
            /// <summary>
            /// Don hang da dc tao hoa don
            /// </summary>
            SoCreateIV,
            /// <summary>
            /// Tao tac bi loi, vui long thu lai sau
            /// </summary>
            ProcessingDBFailed,
            /// <summary>
            /// Có quầy đã thuộc khu khác
            /// </summary>
            CounterOfDifferentArea,
            /// <summary>
            /// Nhập trùng ngày áp dụng
            /// </summary>
            InputDuplicateApplyDate,
            /// <summary>
            /// Bạn có muốn sử dụng chức năng giao hàng
            /// </summary>
            isShippingFunction,
            /// <summary>
            /// Tiền mặt
            /// </summary>
            Cash,
            /// <summary>
            /// Nhập mặt hàng
            /// </summary>
            ItemInput,
            /// <summary>
            /// Giảm giá phiếu
            /// </summary>
            DiscountTicketTitle,
            /// <summary>
            /// Giảm giá mặt hàng
            /// </summary>
            DiscountItemTitle,
            /// <summary>
            /// Nhập số tiền khác
            /// </summary>
            OtherMoneyNumber,

            /// <summary>
            /// Chưa nhập người yêu cầu thanh toán
            /// </summary>
            PP_PUROPOSEPAYBY,

            /// <summary>
            /// Chưa nhập người nhận/nộp
            /// </summary>
            PP_RECEIVEBY,

            /// <summary>
            /// Ngày yêu cầu thanh toán chưa đúng
            /// </summary>
            PP_PAYDATE,

            /// <summary>
            /// Chưa chọn phòng ban
            /// </summary>
            ORG_DEPARTMENTID,

            /// <summary>
            /// Tổng tiền yêu cầu phải lớn hơn 0
            /// </summary>
            PPD_AMOUNT,

            /// <summary>
            /// Tổng tiền duyệt phải lớn hơn 0
            /// </summary>
            PPD_APPAMOUNT,
            /// <summary>
            /// Bạn có muốn giữ phiếu
            /// </summary>
            isHold,
            /// <summary>
            /// Chưa có người nộp tiền
            /// </summary>
            CMRContactRequired,
            /// <summary>
            /// Chưa có người nhận tiền
            /// </summary>
            CMPContactRequired,
            /// <summary>
            /// Message:Tên loại thẻ không được rỗng!
            /// Create by:Tondb
            /// Create date:10-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            CardNameIsNull,
            /// <summary>
            /// Message:Điểm định mức không được rỗng!
            /// Create by:Tondb
            /// Create date:10-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            BasePointIsNull,
            /// <summary>
            /// Message:Thứ tự cấp không được rỗng!
            /// Create by:Tondb
            /// Create date:10-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            LevelIsNull,
            /// <summary>
            /// Message:Bạn có muốn lưu trước khi bỏ qua?!
            /// Create by:Tondb
            /// Create date:11-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            CancelToSaveorIngore,
            /// <summary>
            /// Message:Đã có sự thay đổi từ người khác,bạn có muốn ghi đè ?!
            /// Create by:Tondb
            /// Create date:11-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            WarningUserChanged,
            /// <summary>
            /// Message:Loại thẻ VIP đang thao tác đã
            /// Create by:Tondb
            /// Create date:11-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            VIPCardTypeDeleted,
            /// <summary>
            /// Message:Dữ liệu loại hình áp dụng thẻ VIP trùng nhau!
            /// Create by:Tondb
            /// Create date:13-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            ApplyVIPCardDuplicate,
            /// <summary>
            /// Message:Loại hình kinh doanh không được rỗng!
            /// Create by:Tondb
            /// Create date:10-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            TypeBussIsNull,
            /// <summary>
            /// Message:Loại giảm giá không được rỗng!
            /// Create by:Tondb
            /// Create date:10-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            TypeReduceNull,
            /// <summary>
            /// Message:Loại giảm giá không được rỗng!
            /// Create by:Tondb
            /// Create date:10-09-2010
            /// Page:VIPCardType.aspx
            /// </summary>
            TypeDiscountNull,
            /// <summary>
            /// Bạn có muốn xử lý nợ và kết thúc phiếu
            /// </summary>
            isDept,

            /// <summary>
            /// Ngày áp dụng nhập chưa đúng
            /// </summary>
            SP_BEGINDATE,

            /// <summary>
            /// Bỏ qua
            /// </summary>
            resBack,

            /// <summary>
            /// Gia
            /// </summary>
            Price,

            /// <summary>
            /// Chấp nhận
            /// </summary>
            Accept,
            /// <summary>
            /// Không Chấp nhận
            /// </summary>
            NotAccept,

            /// <summary>
            /// Thanh toán
            /// </summary>
            Payment,
            /// <summary>
            /// DS.Hàng bán
            /// </summary>
            LisItem,
            /// <summary>
            /// DS.Trả hàng
            /// </summary>
            ListVoiceItem,
            /// <summary>
            /// Tiền khác
            /// </summary>
            OtherMoney,
            /// <summary>
            /// Bạn không có quyền thực hiện chức năng này!
            /// </summary>
            NotRole,
            /// <summary>
            /// Phòng ban
            /// </summary>
            Department,
            /// <summary>
            /// Xác nhận hóa đơn?
            /// </summary>
            ConfirmInvoice,
            /// <summary>
            /// Bạn chưa nhập mã khách hàng
            /// </summary>
            NotCustomerCode,

            /// <summary>
            /// Bạn sử dụng phiếu này để tiếp khách ?
            /// </summary>
            UseForGuestTicket,

            /// <summary>
            /// Sản phẩm này không cho sửa giá
            /// </summary>
            NotAlowToEditPrice,

            /// <summary>
            /// Giảm giá mặt hàng
            /// </summary>
            DiscountItem,

            /// <summary>
            /// Giảm giá % mặt hàng
            /// </summary>
            DiscountItemPer,

            /// <summary>
            /// Giảm giá phiếu
            /// </summary>
            DiscountTicket,

            /// <summary>
            /// Giảm giá % trên phiếu
            /// </summary>
            DiscountTicketPer,

            /// <summary>
            /// Xuất hóa đơn không thành công
            /// </summary>
            ExportInvoivesUnsuccessful,

            /// <summary>
            /// Xuất hóa đơn thành công
            /// </summary>
            ExportInvoivesSuccessful,

            /// <summary>
            /// Chưa chọn phiếu để xuất hóa đơn
            /// </summary>
            EmptyTicket,

            /// <summary>
            /// Nhập mã thẻ khách hàng
            /// </summary>
            CustomerCardInput,

            /// <summary>
            /// Nhập mã thẻ tặng
            /// </summary>
            GiftCardInput,

            /// <summary>
            /// Thông tin khách hàng
            /// </summary>
            CustomerInfo,

            /// <summary>
            /// Đang kiểm tra kết nối
            /// </summary>
            CheckingConnect,

            /// <summary>
            /// Sản phẩm đã trả hết
            /// </summary>
            ItemIsEmpty,

            /// <summary>
            /// Tổng tiền quy đổi
            /// </summary>
            TotalMoney,

            /// <summary>
            /// Sửa giá
            /// </summary>
            EditPrice,

            /// <summary>
            /// Xóa KH
            /// </summary>
            DeleteCustomer,

            /// <summary>
            /// Máy POS
            /// </summary>
            POSName,
            /// <summary>
            /// Chưa chọn POS
            /// </summary>
            NotChoosePOS,
            /// <summary>
            /// Dữ liệu không hợp lệ
            /// </summary>
            InvalidData,

            /// <summary>
            /// Số liệu không hợp lệ. Bạn không thể kết chuyển kỳ tiếp theo
            /// </summary>
            InvalidDataTranfer,
            /// <summary>
            /// Chưa có công thức
            /// </summary>
            EmptyRecipe,

            /// <summary>
            /// Chưa có giá
            /// </summary>
            NotSetUpPrice,


            /// <summary>
            /// Mặt hàng này không thuộc nhóm có thể thiết lập giá.
            /// </summary>
            CanNotSetPrice,

            /// <summary>
            /// Thứ 2
            /// </summary>
            Monday,
            /// <summary>
            /// Thứ 3
            /// </summary>
            Tuesday,
            /// <summary>
            /// Thứ 4
            /// </summary>
            Webnesday,
            /// <summary>
            /// Thứ 5
            /// </summary>
            Thursday,
            /// <summary>
            /// Thứ 6
            /// </summary>
            Friday,
            /// <summary>
            /// khu
            /// </summary>
            Area,
            /// <summary>
            /// Thứ
            /// </summary>
            DayofWeek,
            /// <summary>
            /// Thời gian
            /// </summary>
            Time,
            /// <summary>
            /// Đăng nhập lúc
            /// Page:Desktop.aspx
            /// </summary>
            LoginTime,
            /// <summary>
            /// Thời gian ngày hôm sau
            /// </summary>
            TimeTomorrow,
            /// <summary>
            /// Có giá
            /// </summary>
            SetUpPrice,

            /// <summary>
            /// Chưa nhập người nhận
            /// </summary>
            EmptyICC_REPAYBY,

            /// <summary>
            /// Chưa chọn phương thức thanh toán
            /// </summary>
            EmptyPUBPAYMENTMETHOD,

            /// <summary>
            /// Chưa chọn ngân hàng
            /// </summary>
            EmptyPUBBANK,

            /// <summary>
            /// Chưa chọn tài khoản ngân hàng
            /// </summary>
            EmptyBAK_ACCOUNT,

            /// <summary>
            /// Chưa chọn tài khoản tham chiếu
            /// </summary>
            EmptyACC_CODE,

            /// <summary>
            /// Chưa chọn loại thẻ
            /// </summary>
            EmptyCARDTYPE,

            /// <summary>
            /// Chưa nhập số thẻ
            /// </summary>
            EmptyICC_CARDNUM,
            /// <summary>
            /// Chưa chọn ngày để phân tích
            /// </summary>
            NoDateToAnalyze,

            /// <summary>
            /// Chứng từ đã được tạo phiếu xuất
            /// </summary>
            IsCreatedOutwardStock,

            /// <summary>
            /// Dữ liệu đã bị thay đổi. Bạn có muốn ghi đè lên không?
            /// </summary>
            ConfirmRowVersion,

            /// <summary>
            /// Điểm hiện hành không hợp lệ
            /// </summary>
            PointCurInvalid,

            /// <summary>
            /// Tạo KH
            /// </summary>
            CreateCustomer,

            /// <summary>
            /// Dòng số
            /// </summary>
            Line,

            /// <summary>
            /// Mã
            /// </summary>
            Code,

            /// <summary>
            /// Tên
            /// </summary>
            Name,

            /// <summary>
            /// Phiếu thu
            /// </summary>
            Receipt,

            /// <summary>
            /// Phiếu chi
            /// </summary>
            PaymentList,

            /// <summary>
            /// Danh sách nợ
            /// </summary>
            Debt,

            /// <summary>
            /// Báo cáo phiếu
            /// </summary>
            TicketReport,

            /// <summary>
            /// Báo cáo tổng thể
            /// </summary>
            GeneralReport,

            /// <summary>
            /// Nhân viên vào ra ca
            /// </summary>
            ObjShift,

            /// <summary>
            /// Vào ca
            /// </summary>
            CheckIn,

            /// <summary>
            /// Ra ca
            /// </summary>
            CheckOut,

            /// <summary>
            /// Thống kê theo ngày
            /// </summary>
            DailyReport,

            /// <summary>
            /// Thống kê theo tháng
            /// </summary>
            MonthlyReport,

            /// <summary>
            /// Thống kê theo năm
            /// </summary>
            YearlyReport,

            /// <summary>
            /// Từ năm
            /// </summary>
            FromYear,

            /// <summary>
            /// CHọn tháng/năm
            /// </summary>
            ChooseDatetime,

            /// <summary>
            /// Doanh thu
            /// </summary>
            Revenue,

            /// <summary>
            /// Record đã bị xóa, hãy cập nhật lại dữ liệu mới nhất
            /// </summary>
            RecordDeleted,

            /// <summary>
            /// Danh mục
            /// </summary>
            FieldITG_Name,

            /// <summary>
            /// Sản phẩm
            /// </summary>
            FieldProductName,

            /// <summary>
            /// Số lượng
            /// </summary>
            FieldQuantity,

            /// <summary>
            /// Doanh thu
            /// </summary>
            FieldPaymentAmount,

            /// <summary>
            /// Năm
            /// </summary>
            FieldYear,

            /// <summary>
            /// Quý
            /// </summary>
            FieldQuarter,

            /// <summary>
            /// Báo cáo doanh số bán hàng
            /// </summary>
            rSALEITEM,

            /// <summary>
            /// Tổng
            /// </summary>
            GrandTotal,

            /// <summary>
            /// Mã vạch
            /// </summary>
            BarCode,

            /// <summary>
            /// Hiển thị theo cột
            /// </summary>
            ShowColumn,

            /// <summary>
            /// Cách hiển thị bàn NGANG
            /// </summary>
            Horizontal,

            /// <summary>
            /// Cách hiển thị bàn DOC
            /// </summary>
            Vertical,

            /// <summary>
            /// Barcode nhập vào không đúng
            /// </summary>
            BarCodeInvalid,

            /// <summary>
            /// Trùng barcode.
            /// </summary>
            BarCodeSame,

            /// <summary>
            /// Độ dài BarCode không đúng
            /// </summary>
            BarCodeLengthInvalid,

            /// <summary>
            /// Hiển thị theo dòng
            /// </summary>
            ShowRow,

            /// <summary>
            /// Ngày tạo
            /// </summary>
            CreateDate,
            /// <summary>
            /// Ngày ghi sổ
            /// </summary>
            PostingDate,
            /// <summary>
            /// Có hóa đơn
            /// </summary>
            HaveReceipt,
            /// <summary>
            /// Không hóa đơn
            /// </summary>
            NoReceipt,
            /// <summary>
            /// Ngày chứng từ
            /// </summary>
            DocDate,
            /// <summary>
            /// Ngày đóng
            /// </summary>
            ClosingDate,

            /// <summary>
            /// Khách theo dõi
            /// </summary>
            TrackedCustomer,

            /// <summary>
            /// khách hàng bán lẻ
            /// </summary>
            RetailCustomer,

            /// <summary>
            /// chưa xuất
            /// </summary>
            NonExport,

            /// <summary>
            /// đã xuất
            /// </summary>
            Exported,

            /// <summary>
            /// chưa hủy
            /// </summary>
            NonDestroy,

            /// <summary>
            /// hủy
            /// </summary>
            Destroy,

            /// <summary>
            /// bạn có muốn tặng phiếu này
            /// </summary>
            Voucher,

            /// <summary>
            /// Form tặng phiếu
            /// </summary>
            frmVoucher,

            /// <summary>
            /// Xác nhận quyền tặng phiếu
            /// </summary>
            SafeVoucher,

            /// <summary>
            /// Xác nhận ghi nợ
            /// </summary>
            SafeDebit,

            /// <summary>
            /// Đăng nhập
            /// </summary>
            Login,

            /// <summary>
            /// Xác nhận hủy phiếu
            /// </summary>
            SafeCancelVote,

            /// <summary>
            /// Xác nhận trả hàng
            /// </summary>
            SafeVoidItem,

            /// <summary>
            /// Chưa nhập tên máy POS
            /// </summary>
            ResPosNameMissing,

            /// <summary>
            /// Hàng trong kho không đủ
            /// </summary>
            OutOfStock,

            /// <summary>
            /// Số lượng trả nhiều hơn số lượng mua
            /// </summary>
            OutOfBuy,
            #endregion
            #region STATUS
            /// <summary>
            /// Tạo mới
            /// </summary>
            STATUS_1,
            /// <summary>
            /// Duyệt
            /// </summary>
            STATUS_2,
            /// <summary>
            /// Không duyệt
            /// </summary>
            STATUS_3,
            /// <summary>
            /// FeedBack
            /// </summary>
            STATUS_4,
            /// <summary>
            /// Khách hàng chấp nhận
            /// </summary>
            STATUS_5,
            /// <summary>
            /// Khách hàng không chấp nhận
            /// </summary>
            STATUS_6,
            /// <summary>
            /// Created PO
            /// </summary>
            STATUS_7,
            /// <summary>
            /// Created SO
            /// </summary>
            STATUS_8,
            /// <summary>
            /// Completed
            /// </summary>
            STATUS_9,
            /// <summary>
            /// Đóng
            /// </summary>
            STATUS_10,
            /// <summary>
            /// Cập nhật
            /// </summary>
            STATUS_11,
            /// <summary>
            /// Ghi sổ chính
            /// </summary>
            STATUS_12,
            /// <summary>
            /// Ghi sổ tạm
            /// </summary>
            STATUS_13,
            /// <summary>
            /// Lỗi
            /// </summary>
            STATUS_14,
            /// <summary>
            /// Khách hàng từ chối
            /// </summary>
            STATUS_15,
            /// <summary>
            /// Đã sửa lỗi
            /// </summary>
            STATUS_16,
            /// <summary>
            /// Đã thanh toán
            /// </summary>
            STATUS_17,
            /// <summary>
            /// Đang thực hiện
            /// </summary>
            STATUS_18,
            /// <summary>
            /// Hủy
            /// </summary>
            STATUS_19,
            /// <summary>
            /// đã xong chua thanh ly
            /// </summary>
            STATUS_20,
            /// <summary>
            /// đã thanh lý
            /// </summary>
            STATUS_21,
            /// <summary>
            /// Hủy bỏ
            /// </summary>
            STATUS_22,
            /// <summary>
            /// Yêu cầu sửa lại
            /// </summary>
            STATUS_23,
            /// <summary>
            /// Đã sửa lại
            /// </summary>
            STATUS_24,
            /// <summary>
            /// Chưa phân bổ
            /// </summary>
            STATUS_25,
            /// <summary>
            /// Đã phân bổ
            /// </summary>
            STATUS_26,
            /// <summary>
            /// Phân bổ lại
            /// </summary>
            STATUS_27,
            /// <summary>
            /// Ngừng phân bổ
            /// </summary>
            STATUS_28,
            /// <summary>
            /// Được điều chỉnh
            /// </summary>
            STATUS_29,
            /// <summary>
            /// Yêu cầu điều chỉnh
            /// </summary>
            STATUS_30,
            /// <summary>
            /// Drap
            /// </summary>
            STATUS_31,
            /// <summary>
            /// Invoice
            /// </summary>
            STATUS_32,
            /// <summary>
            /// Xử lý
            /// </summary>
            STATUS_33,
            /// <summary>
            /// Kết thúc
            /// </summary>
            STATUS_34,
            /// <summary>
            /// Trễ kế hoạch
            /// </summary>
            STATUS_35,
            /// <summary>
            /// Khấu hao
            /// </summary>
            STATUS_36,
            /// <summary>
            /// Ngừng khấu hao
            /// </summary>
            STATUS_37,
            /// <summary>
            /// Sản phẩm này không thể trả lại
            /// </summary>
            NoItemToInvoid,
            /// <summary>
            /// Chưa chọn cơ sở dữ liệu
            /// </summary>
            NoDatabase,
            /// <summary>
            /// Chưa chọn nhân viên quản lý
            /// </summary>
            NoManager,
            /// <summary>
            /// Vui lòng nhập ghi chú
            /// </summary>
            NotePlease,
            /// <summary>
            /// Xuất file thành công
            /// </summary>
            ExportSuccessfully,
            /// <summary>
            /// Mật khẩu không được để trống
            /// </summary>
            NoEmptyPass,
            /// <summary>
            /// Tài khoản đang hoạt động
            /// </summary>
            AccountInwork,
            /// <summary>
            /// Nhập lại số lượng sản phẩm
            /// </summary>
            ReWriteQuantity,
            /// <summary>
            /// Vui lòng nhập giá
            /// </summary>
            EnterPrice,
            /// <summary>
            /// Phiếu đã được thanh toán
            /// </summary>
            CashedTicket,
            /// <summary>
            /// Chưa có tài khoản trong hệ thống
            /// </summary>
            NoAccount,
            /// <summary>
            /// Chưa có thông tin người trả
            /// </summary>
            NoInfoPayee,
            /// <summary>
            /// Số tiền phải lớn hơn 0
            /// </summary>
            MoneyMustThanZero,
            /// <summary>
            /// Số lượng khách hàng phải lớn hơn 0
            /// </summary>
            CusQuanMustThanZero,
            /// <summary>
            /// Backup dữ liệu thành công
            /// </summary>
            BackupSuccessfully,
            /// <summary>
            /// Restore dữ liệu thành công
            /// </summary>
            RestoreSuccessfully,

            /// <summary>
            /// Duyệt
            /// </summary>
            APPROVED,

            /// <summary>
            /// Được điều chỉnh
            /// </summary>
            EDITED,

            /// <summary>
            /// Cần điều chỉnh
            /// </summary>
            REQUESTEDIT,

            /// <summary>
            /// Không Duyệt
            /// </summary>
            NOTAPPROVED,

            /// <summary>
            /// Bỏ qua
            /// </summary>
            Cancel,

            /// <summary>
            /// Thoát
            /// </summary>
            Exit,

            /// <summary>
            /// Tên đăng nhập hoặc mật khẩu không đúng
            /// </summary>
            UserNameOrPassNotCorrect,

            /// <summary>
            /// D.S phiếu
            /// </summary>
            TicketList,

            /// <summary>
            /// Số lượng bàn
            /// </summary>
            QuantityTable,

            /// <summary>
            /// Chi phí
            /// </summary>
            Cost,

            /// <summary>
            /// Số phiếu
            /// </summary>
            TicketNo,

            /// <summary>
            /// Số tiền
            /// </summary>
            MoneyAmount,

            /// <summary>
            /// Thời gian tạo
            /// </summary>
            TimeCreate,

            /// <summary>
            /// Thời gian chờ 
            /// </summary>
            TimeWaiting,

            /// <summary>
            /// Huỷ món
            /// </summary>
            CancelItem,

            /// <summary>
            /// Trả hàng
            /// </summary>
            VoidItem,

            /// <summary>
            /// Số lượng khách
            /// </summary>
            QuantityCustomer,

            /// <summary>
            /// Tiền bo
            /// </summary>
            Tip,

            /// <summary>
            /// Kết nối thành công
            /// </summary>
            ConnectSuccess,

            /// <summary>
            /// Còn phiếu chưa thanh toán!Bạn có muốn ra ca không?
            /// </summary>
            TicketNotTender,

            /// <summary>
            /// Có in báo cáo không?
            /// </summary>
            WantPrintReport,

            /// <summary>
            /// Đã hủy
            /// </summary>
            Canceled,

            /// <summary>
            /// Chưa thanh toán
            /// </summary>
            NotPayment,

            /// <summary>
            /// Đã thanh toán
            /// </summary>
            Paid,

            /// <summary>
            /// Đang giữ
            /// </summary>
            Hold,

            /// <summary>
            /// Nhà hàng
            /// </summary>
            Res,

            /// <summary>
            /// Bán lẻ
            /// </summary>
            Retail,

            /// <summary>
            /// Lịch sử sửa phiếu
            /// </summary>
            HistoryChangeTicket,

            /// <summary>
            /// Lịch sử đăng nhập
            /// </summary>
            HistoryLogin,
            #endregion
            /// <summary>
            /// Title:Thông báo
            /// Content:Mật khẩu mới không giống nhau,<br/> vui lòng nhập lại!
            /// </summary>
            NotSameNewPassword,
            /// <summary>
            /// Title:Thông báo
            ///Content: Vui lòng nhập trường bắt buộc trước khi thao tác
            /// </summary>
            EnterReqfieldsBfOperation,
            /// <summary>
            /// Title: Vui lòng chờ trong giây lát
            ///Messeger: Hệ thống đang xử lý
            ///
            /// </summary>
            Processing,
            /// <summary>
            /// Mặt hàng
            /// </summary>
            Item,
            /// <summary>
            /// Nam
            /// </summary>
            Male,
            /// <summary>
            /// Nữ
            /// </summary>
            Female,
            /// <summary>
            /// Không set menu
            /// </summary>
            NotSetMenu,
            /// <summary>
            /// Không set menu
            /// </summary>
            SetMenu,
            /// <summary>
            /// Tổ chức
            /// </summary>
            Organization,
            /// <summary>
            /// Cá nhân
            /// </summary>
            Individual,

            /// <summary>
            /// Dịch vụ
            /// </summary>
            Service,

            /// <summary>
            /// Giờ
            /// </summary>
            Hour,

            /// <summary>
            /// Chi tiết phiếu
            /// </summary>
            TicketDetail,

            /// <summary>
            /// Phiếu đã xuất hóa đơn
            /// </summary>
            TicketExportInvoice,

            /// <summary>
            /// Phiếu đã xuất kho
            /// </summary>
            TicketExportStock,

            /// <summary>
            /// Phiếu đã xuất hóa đơn hoặc xuất kho
            /// </summary>
            TicketExportACC,

            /// <summary>
            /// Số lượng Order ít hơn số lượng trả hàng
            /// </summary>
            QuantityOrderLessVoidItem,

            /// <summary>
            /// Kết nối với thiết bị cân bị lỗi
            /// </summary>
            WeightError,

            /// <summary>
            /// Bạn phải nhập ghi chú.
            /// </summary>
            InputNote,

            /// <summary>
            /// Nhân viên
            /// </summary>
            StaffTitle,

            /// <summary>
            /// Có
            /// </summary>
            Have,

            /// <summary>
            /// Không
            /// </summary>
            Not,

            /// <summary>
            /// Loại thẻ
            /// </summary>
            CardType,

            /// <summary>
            /// Ngày hết hạn
            /// </summary>
            ExpireDate,

            /// <summary>
            /// Phiếu chưa thanh toán hoặc đã hủy
            /// </summary>
            TicketNotCashOrCancel,

            /// <summary>
            /// Ngày trả phải lớn hơn hiện tại
            /// </summary>
            PayDateMustLargerNow,

            /// <summary>
            /// Chưa chọn chi nhánh, trung tâm
            /// </summary>
            NotChooseORG,

            /// <summary>
            /// Chưa chọn quầy
            /// </summary>
            NotChooseCounter,

            /// <summary>
            /// Chưa nhập tên tổ chức
            /// </summary>
            NotAddBussiness,

            /// <summary>
            /// Đơn hàng đã xuất hóa đơn, không thể hủy
            /// </summary>
            Billhasoutput,

            /// <summary>
            /// Đơn hàng chưa xuất hóa đơn, nhưng đã xuất kho
            /// </summary>
            Billhaswarehouse,

            /// <summary>
            /// Chưa nhập thời gian vào
            /// </summary>
            NotAddDateCreate,

            /// <summary>
            /// Số lượng khách nước ngoài không hợp lệ
            /// </summary>
            InvalidAmountForeign,

            /// <summary>
            /// Mã khách hàng này đã tồn tại 
            /// </summary>
            ExistCustomerCode,

            /// <summary>
            /// Chứng từ đã khóa sổ
            /// </summary>
            DocumentLocked,
            /// <summary>
            /// Ngày làm việc đã khóa sổ,không thể tạo phiếu
            /// </summary>
            DocumentDateLocked,
            /// <summary>
            /// Danh sách mặt hàng trừ kho
            /// -Create by:Tondb
            /// -Create date:01-06
            /// </summary>
            ReducingItemsList,
            /// <summary>
            /// Phiếu tặng
            /// </summary>
            GiftTicket,

            /// <summary>
            /// Trả đủ tiền
            /// </summary>
            CashEnough,

            /// <summary>
            /// Trả thiếu tiền
            /// </summary>
            CashDebt,

            /// <summary>
            /// Chưa trả tiền
            /// </summary>
            NotCash,
            /// <summary>
            /// Create by:Tondb
            /// Create date:10-09-2011
            /// Description:Đã tồn tại phiếu xuất bán hàng cùng điều kiện hiện tại.Bạn có muốn tạo mới phiếu xuất?
            /// </summary>
            ExistDataExportItem,
            /// <summary>
            /// Create by:Tondb
            /// Create date:31-10-2011
            /// Description:Mặt hàng không cho phép trừ kho
            /// </summary>
            DenyItemOutStock,
            /// <summary>
            /// Bạn có chắc muốn hủy áp dụng thẻ Voucher không ?
            /// </summary>
            DeleteVoucherCard,

            /// <summary>
            ///  Địa chỉ thư điện tử không đúng
            /// </summary>
            InvalidMail,

            /// <summary>
            ///  Kết nối thành công
            /// </summary>
            ConnectSucess,

            /// <summary>
            /// Đã vào ca
            /// </summary>
            CheckedIn,

            /// <summary>
            /// Quầy
            /// </summary>
            Counter,

            /// <summary>
            /// Khác
            /// </summary>
            Other,

            /// <summary>
            /// Trong danh sách
            /// </summary>
            InList,

            /// <summary>
            /// Vui lòng bỏ chọn những phiếu bị lỗi ! Để tiếp tục xuất hóa đơn
            /// </summary>
            CancelChooseTicketErrorForExportInvoce,

            /// <summary>
            /// Chưa chọn phiếu
            /// </summary>
            NotChooseTicket,
            /// <summary>
            /// Message:Mặt hàng {0} không thuộc diện được sửa giá
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:09-02-2011
            /// </summary>
            ItemPriceNoEditPrice,
            /// <summary>
            /// Message:Tách phiếu từ
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:16-02-2011
            /// </summary>
            SplitTicketFrom,
            /// <summary>
            /// Message:Tách đến phiếu
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:16-02-2011
            /// </summary>
            SplitTicketTo,
            /// <summary>
            /// Message:Ghép phiếu
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:18-02-2011
            /// </summary>
            MixTicketTo,
            /// <summary>
            /// Message:Phiếu bạn chọn ghép đã bị hủy hoặc không còn tồn tại
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:18-02-2011
            /// </summary>
            ERRMixTicket,
            /// <summary>
            /// Message:Chưa có phiếu thỏa điều kiện để ghép phiếu
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:21-02-2011
            /// </summary>
            NoMixTicket,
            /// <summary>
            /// Message:Số lượng mặt hàng tách phải lớn 0 và nhỏ hoặc bằng số lượng ban đầu
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:21-02-2011
            /// </summary>
            QuantitySplitTicket,
            /// <summary>
            /// Message:Phiếu {0} không còn mặt hàng để tách
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:21-02-2011
            /// </summary>
            NoItemToSplit,
            /// <summary>
            /// Message:Phiếu {0} không thuộc trạng thái cho phép sửa
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:21-02-2011
            /// </summary>
            NoStatustoEdit,
            /// <summary>
            /// Message:Phiếu {0} không thuộc trạng thái cho phép ghép
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:21-02-2011
            /// </summary>
            NoStatustoMix,
            /// <summary>
            /// Message:Phiếu {0} không thuộc trạng thái cho phép tách
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:21-02-2011
            /// </summary>
            NoStatustoSplit,
            /// <summary>
            /// Message:Bạn phải chọn mặt hàng cho {0} theo mỗi lựa chọn.
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:21-02-2011
            /// </summary>
            NoSelectedItemSetChoice,
            /// <summary>
            /// Message:Bạn chọn mặt hàng chưa đủ cho {0} theo mỗi lựa chọn.
            /// Title:Thông báo
            /// Page:TicketDetailRes.apsx
            /// Create by:Tondb
            /// Create date:21-02-2011
            /// </summary>
            NoMinSelectedItemSetChoice,
            /// <summary>
            /// Message:Thông tin tách mặt hàng trùng với mặt hàng gốc
            /// Title:Thông báo
            /// Page:Inventory.apsx
            /// Create by:Tondb
            /// Create date:25-05-2011
            /// </summary>
            SplitDuplicateData,
            /// <summary>
            /// Message:Đã tồn tại phiếu kiểm kho cùng ngày kiểm kho và kho 
            /// Title:Thông báo
            /// Page:Inventory.apsx
            /// Create by:Tondb
            /// Create date:15-07-2011
            /// </summary>
            DuplicateDataDocument,
            /// <summary>
            /// Message:Chưa giao hàng
            /// Title:Dữ liệu
            /// Page:TisketDetail.apsx
            /// Create by:Vinhlq
            /// Create date:24-08-2011
            /// </summary>
            NonDelivery,
            /// <summary>
            /// Message:Đã giao hàng
            /// Title:Dữ liệu
            /// Page:TisketDetail.apsx
            /// Create by:Vinhlq
            /// Create date:24-08-2011
            /// </summary>
            HasDelivered,
            /// <summary>
            /// Message:Chứng từ đã được xử lý.Bạn không thể thao tác
            /// Title:Thông báo
            /// Page:Inventory.apsx
            /// Create by:Tondb
            /// Create date:04-08-2011
            /// </summary>
            TreatedDocument,
            /// <summary>
            /// Message: Chứng từ này không thuộc chi nhánh {0}
            /// Title:Thông báo
            /// Page:All
            /// Create by:Vinh
            /// Create date:09-08-2011
            /// </summary>
            NotBelongToBranch,
            /// <summary>
            /// Message:Chứng từ không thuộc trạng thái cho phép sửa
            /// Title:Thông báo
            /// Page:Inventory.apsx
            /// Create by:Tondb
            /// Create date:04-08-2011
            /// </summary>
            LimitEditDocument,
            /// <summary>
            /// Message:Mặt hàng chưa được nhập kiểm kho
            /// Title:Thông báo
            /// Page:Inventory.apsx
            /// Create by:Tondb
            /// Create date:09-11-2011
            /// </summary>
            InValidItemIventory,
            /// <summary>
            /// Message:Chứng từ đã được duyệt.Bạn không thể duyệt lại.
            /// Title:Thông báo
            /// Page:Inventory.apsx
            /// Create by:Tondb
            /// Create date:04-08-2011
            /// </summary>
            ApprovedDocument,
            /// <summary>
            /// Message:Chi tiết phiếu kiểm kho
            /// Title:Thông báo
            /// Page:Inventory.apsx
            /// Create by:Tondb
            /// Create date:04-08-2011
            /// </summary>
            InventoryDetail,
            /// <summary>
            /// Message:Không thể tách mặt hàng khi số lượng bằng 1
            /// Title:Thông báo
            /// Page:Inventory.apsx
            /// Create by:Tondb
            /// Create date:25-05-2011
            /// </summary>
            QuantitySplitItem,
            /// <summary>
            /// Tồn tại level
            /// </summary>
            ExitLevel,

            /// <summary>
            /// Điểm định mức không hợp lệ
            /// </summary>
            PointNormInvalid,

            /// <summary>
            /// Phải có ít nhất một thẻ
            /// </summary>
            ZeroCard,

            /// <summary>
            /// Đầu số mã thẻ không được để trống
            /// <summary>
            NotPrefixName,

            /// <summary>
            /// Đuôi số mã thẻ không được để trống
            /// <summary>
            NotSuffixName,

            /// <summary>
            /// Nhap vao ma the Voucher
            /// </summary>
            VoucherCardInput,
            /// <summary>
            ///  Danh sách hóa đơn
            /// </summary>
            ListOfInvoice,
            /// <summary>
            ///  Công nợ phải trả hàng hóa
            /// </summary>
            AccountingPayablesGoods,
            /// <summary>
            ///  Danh sách công nợ phải trả
            /// </summary>
            ListOfAP,
            /// <summary>
            ///  Phân tích tuổi nợ phải trả
            /// </summary>
            DebtAnalysisPayable,
            /// <summary>
            ///  Báo cáo chi tiết công nợ phải trả
            /// </summary>
            DetailReportPayable,
            /// <summary>
            ///  Danh sách nhà cung cấp
            /// </summary>
            ListofSupplier,
            /// <summary>
            ///  Báo cáo tổng hợp phải thu
            /// </summary>
            ARGeneralReport,
            /// <summary>
            ///  Danh Sách chứng từ công nợ phải thu
            /// </summary>
            ListOfAR,
            /// <summary>
            ///  Phân tích công nợ phải thu
            /// </summary>
            DebtAnlysisAR,
            /// <summary>
            ///  Công nợ phải thu hàng hoá
            /// </summary>
            ARGoods,
            /// <summary>
            ///  Báo cáo tổng chi tiết công nợ phải thu
            /// </summary>
            DetailReportAR,
            /// <summary>
            ///  Danh sách khách hàng
            /// </summary>
            Listofcustomer,
            /// <summary>
            ///  Điều khoản thanh toán
            /// </summary>
            PaymentTerm,
            /// <summary>
            /// Bàn đang chọn
            /// </summary>
            TableSelected,

            /// <summary>
            /// Phiếu
            /// </summary>
            Ticket,

            /// <summary>
            /// Thông tin khu và bàn
            /// </summary>
            InforAreaAndTable,

            /// <summary>
            /// Thao tác bàn và phiếu
            /// </summary>
            ActionTableAndTicket,

            /// <summary>
            /// Vui lòng chọn bàn!
            /// </summary>
            PleaseChooseTable,

            /// <summary>
            /// Không thể hủy món này
            /// </summary>
            NotCancelItem,

            /// <summary>
            /// Lý do rồng
            /// </summary>
            ReasonEmpty,

            /// <summary>
            /// Chọn bàn khác
            /// </summary>
            SelectAnotherTable,

            /// <summary>
            /// Số lượng không hợp lệ
            /// </summary>
            NumberInvalid,

            /// <summary>
            /// Số phiếu tách phải lớn hơn hoặc bằng 2
            /// </summary>
            InvalidNumberBillSeparate,

            /// <summary>
            /// Thanh toán bàn phụ
            /// </summary>
            PaySubTable,

            /// <summary>
            /// Cập nhật thông tin cho bàn
            /// </summary>
            UpdateInfoTable,

            /// <summary>
            /// Thanh toán Phiếu được chọn
            /// </summary>
            PayChosenTicket,

            /// <summary>
            /// Ghép bàn
            /// </summary>
            LinkTable,

            /// <summary>
            /// Ngừng ghép bàn
            /// </summary>
            StopLinkingTable,

            /// <summary>
            /// Chuyển bàn
            /// </summary>
            MoveTable,

            /// <summary>
            /// Ngừng chuyển bàn
            /// </summary>
            StopMovingTable,

            /// <summary>
            /// Ghép phiếu
            /// </summary>
            LinkTicket,

            /// <summary>
            /// Bàn này đã có phiếu. Bạn có muốn ghép với các phiếu trên bàn này không ?
            /// </summary>
            ChooseUpdateOrNewTicket,

            /// <summary>
            /// Ngừng ghép phiếu
            /// </summary>
            StopLinkingTicket,

            /// <summary>
            /// Tách phiếu
            /// </summary>
            SeparateTicket,

            /// <summary>
            /// Bàn bạn đang chọn đã được sử dụng ở phiếu khác
            /// </summary>
            Tableused,

            /// <summary>
            /// Ngừng tách phiếu
            /// </summary>
            StopSeparatingTicket,

            /// <summary>
            /// Hủy phiếu ghép
            /// </summary>
            CancelLinkTableSub,

            /// <summary>
            /// Nhóm
            /// </summary>
            Group,

            /// <summary>
            /// Bạn chưa chọn mặt hàng nào ! Vui lòng chọn mặt hàng.
            /// </summary>
            ItemsSelectedNull,

            /// <summary>
            /// Lỗi kết thúc ca có thể do ngày giờ không đúng, vui lòng kiểm tra lại!
            /// </summary>
            ErrorCashierOut,
            /// <summary>
            ///Message: Chào bạn
            ///Title:Thông báo
            ///Page:Desktop.aspx
            ///Create by:Tondb
            ///Create date:17-03-2011
            /// </summary>
            WellcomeTo,
            /// <summary>
            ///Message: Doanh thu mặt hàng theo nhóm
            ///Title:Dữ liệu
            ///Page:ItemTurnoverChartCircle.aspx
            ///Create by:Vinhlq
            ///Create date:21/04/2011
            /// </summary>
            ChartPieItemTurnover,
            /// <summary>
            ///Message: Số người đang truy cập
            ///Title:Thông báo
            ///Page:Desktop.aspx
            ///Create by:Tondb
            ///Create date:17-03-2011
            /// </summary>
            OnlineUser,
            /// <summary>
            ///Message:Máy đăng nhập
            ///Title:Thông báo
            ///Page:Desktop.aspx
            ///Create by:Tondb
            ///Create date:17-03-2011
            /// </summary>
            PCName,
            /// <summary>
            ///Message:Địa chỉ IP
            ///Title:Thông báo
            ///Page:Desktop.aspx
            ///Create by:Tondb
            ///Create date:17-03-2011
            /// </summary>
            IPAddress,
            /// <summary>
            ///Message:Kỳ tài chính
            ///Title:Thông báo
            ///Page:Desktop.aspx
            ///Create by:Tondb
            ///Create date:17-03-2011
            /// </summary>
            FiciName,
            /// <summary>
            ///Message:Ngày làm việc
            ///Title:Thông báo
            ///Page:Desktop.aspx
            ///Create by:Tondb
            ///Create date:17-03-2011
            /// </summary>
            DocumentDateLogin,
            /// <summary>
            /// Chi nhánh
            /// </summary>
            Branch,
            /// <summary>
            /// Số lượng phải > 0
            /// </summary>
            QuantityMustGreaterZero,

            /// <summary>
            /// Tiền hàng nhỏ hơn giảm giá
            /// </summary>
            TotalAmountLessDiscount,

            /// <summary>
            /// Số lượng trả không hợp lệ.Có thể nhân viên khác đang trả hàng.Vui lòng kiểm tra lại.
            /// </summary>
            InvalidVoidItemOrObjVoiding,

            /// <summary>
            /// Chưa chọn loại món mở.
            /// </summary>
            NotChooseTypeOpenItem
            , /// <summary>
            /// Message:Tổng hợp khác
            /// Title:Tiêu đề
            /// Create by:tondb
            /// Create date:25-03-2011
            /// </summary>
            GLGeneralOther,
            /// <summary>
            /// Message:Ngoài bảng
            /// Title:Tiêu đề
            /// Create by:tondb
            /// Create date:25-03-2011
            /// </summary>
            GLExternal,

            /// <summary>
            /// Giá trước VAT
            /// </summary>
            PriceBeforeVAT,

            /// <summary>
            /// Giá sau VAT
            /// </summary>
            PriceAfterVAT,

            /// <summary>
            /// Trừ kho
            /// </summary>
            WareHouseCheck,

            /// <summary>
            /// Kho mặc định
            /// </summary>
            WareHouseDefault,

            /// <summary>
            /// Nhóm phiếu
            /// </summary>
            GroupBill,

            /// <summary>
            /// Tách phiếu
            /// </summary>
            SeparateBill,

            /// <summary>
            /// Ghép phiếu
            /// </summary>
            LinkBill,

            /// <summary>
            /// Hủy nhóm phiếu
            /// </summary>
            CancelGroupBill,

            /// <summary>
            /// Ngừng chuyển bàn
            /// </summary>
            CancelMoveTable,

            /// <summary>
            /// Ngừng tách phiếu
            /// </summary>
            CancelSeparateBill,

            /// <summary>
            /// Ngừng ghép phiếu
            /// </summary>
            CancelLinkBill,

            /// <summary>
            /// Phiếu đã in nhiều lần, liên hệ quản lý để biết thêm chi tiết!
            /// </summary>
            TicketPrintedMutil,

            /// <summary>
            /// Bạn muốn tách vào phiếu mới?
            /// </summary>
            SeperateNewBill,

            /// <summary>
            /// Chỉ được tách tối đa
            /// </summary>
            QuantitySeparateMax,

            /// <summary>
            /// Số lượng trả tối đa chỉ bằng
            /// </summary>
            QuantityVoidItemMax,

            /// <summary>
            /// In lại xuống bếp
            /// </summary>
            ReprintToKitchen,
            /// <summary>
            /// Máy in bếp
            /// </summary>
            PrinterKitchen,
            /// <summary>
            /// Máy in thu ngân
            /// </summary>
            PrinterCashier,
            /// <summary>
            /// Tạm thoát
            /// </summary>
            SafeMode,

            /// <summary>
            /// Mở két tiền
            /// </summary>
            OpenCashier,

            /// <summary>
            /// Hủy phiếu
            /// </summary>
            CancelTicket,

            /// <summary>
            /// Áp dụng Voucher
            /// </summary>
            AppVoucher,

            /// <summary>
            /// Áp dụng thẻ VIP
            /// </summary>
            AppVIPCard,

            /// <summary>
            /// Xác nhận quyền lặp lại
            /// </summary>
            SafeRepeat,

            /// <summary>
            /// Lưu ý: Phiếu này đang dùng để tiếp khách.
            /// Bạn có muốn kết thúc hay hủy trạng thái tiếp khách?
            /// </summary>
            IsCashOrCancelGuest,

            /// <summary>
            /// Bạn có chắc hủy hình thức thanh toán này không?
            /// </summary>
            IsCancelPaymentMethod,

            /// <summary>
            /// Ngày giờ hệ thống máy chủ có thể bị sai.Vui lòng kiểm tra lại!
            /// </summary>
            DataTimeServerIsInValid,

            /// <summary>
            /// Chưa chọn loại bàn!
            /// </summary>
            NotChooseTableType,

            /// <summary>
            /// Chưa chọn khu!
            /// </summary>
            NotChooseArea,
            /// <summary>
            /// Chưa chọn tài sản cần thao tác
            /// </summary>
            NotChooseAsset,
            /// <summary>
            /// Chưa nhập số ghế!
            /// </summary>
            NotInputChairNumber,

            /// <summary>
            /// Chưa nhập chiều dài!
            /// </summary>
            NotInputLong,

            /// <summary>
            /// Chưa nhập chiều rộng!
            /// </summary>
            NotChooseWidth,

            /// <summary>
            /// Nhập mặt hàng trả
            /// </summary>
            ItemInputVoid,

            /// <summary>
            /// Sử dụng cân
            /// </summary>
            UseBalance,

            /// <summary>
            /// Viết tắt
            /// </summary>
            Abbreviation,

            /// <summary>
            /// CMND
            /// </summary>
            IdentityID,

            /// <summary>
            /// Thư điện tử
            /// </summary>
            Email,

            /// <summary>
            /// Phiếu đã in bạn không có quyền giảm giá, liên hệ quản lý để biết thêm chi tiết!
            /// </summary>
            TicketPrinted,

            /// <summary>
            /// Lưu ý: Bạn có chắc in tất cả các phiếu không?
            /// </summary>
            Areyousureprintallbill,

            /// <summary>
            /// Giữ phiếu
            /// </summary>
            HoldBill,

            /// <summary>
            /// Bạn chưa chọn nhân viên order.Bạn có muốn sử dụng tên bạn làm nhân viên order?
            /// </summary>
            YouNotChooseOrderer,


            /// <summary>
            /// Tiêu đề
            /// </summary>
            Title,

            /// <summary>
            /// Dùng cho form bán lẻ : tiếng việt là bỏ qua, tiếng anh là Finish 
            /// </summary>
            CancelFinish,

            /// <summary>
            /// Chưa nhập mật khẩu mới!
            /// </summary>
            NotInputNewPass,

            /// <summary>
            /// Chưa nhập xác nhận mật khẩu mới!
            /// </summary>
            NotInputNewPassConfirm,

            /// <summary>
            /// Tổng tiền đang = 0
            /// </summary>
            TotalAmountIsZero,

            /// <summary>
            /// Kéo tiêu đề cột vào đây để nhóm bởi cột đó
            /// </summary>
            DragAColumnHeaderHereToGroupByThatColumn,

            /// <summary>
            /// Tổng tiền đang = 0.Bạn có muốn kết thúc phiếu không?
            /// </summary>
            TotalAmountIsZeroDoyouwantFinishBill,

            /// <summary>
            /// Số lượng có thể bị âm.Bạn vui lòng kiểm tra lại!
            /// </summary>
            QuantityCanNegativePleaseYouCheckAgain,

            /// <summary>
            /// Không tìm thấy dữ liệu.Vui lòng kiểm tra lại!
            /// </summary>
            DataNotFoundPleaseCheckAgain,

            /// <summary>
            /// Tuần của tháng
            /// </summary>
            WeekOfMonth,

            /// <summary>
            /// Thả các cột để lọc vào đây
            /// </summary>
            DropFilterFieldsHere,

            /// <summary>
            /// Sắp xếp tăng dần
            /// </summary>
            SortAscending,

            /// <summary>
            /// Sắp xếp giảm dần
            /// </summary>
            SortDescending,

            /// <summary>
            /// Xóa sắp xếp
            /// </summary>
            ClearSorting,

            /// <summary>
            /// Nhóm bởi cột này
            /// </summary>
            GroupByThisColumn,

            /// <summary>
            /// Hiển thị phần nhóm cột
            /// </summary>
            ShowGroupPanel,

            /// <summary>
            /// Hiển thị phần chọn cột
            /// </summary>
            ShowColumnChooser,

            /// <summary>
            /// Best Fit
            /// </summary>
            BestFit,

            /// <summary>
            /// Best Fit (tất cả cột)
            /// </summary>
            BestFitColumns,

            /// <summary>
            /// Soạn thảo phần lọc
            /// </summary>
            FilterEditor,

            /// <summary>
            /// Chọn cột
            /// </summary>
            ColumnChooser,

            /// <summary>
            /// Kéo một cột vào đây để tùy chỉnh giao diện
            /// </summary>
            Dragacolumnheretocustomizelayout,

            /// <summary>
            /// Xóa lọc
            /// </summary>
            ClearFilter,

            /// <summary>
            /// Ẩn phần chọn cột
            /// </summary>
            HideColumnChooser,

            /// <summary>
            /// Ẩn phần nhóm
            /// </summary>
            HideGroupPanel,

            /// <summary>
            /// Không nhóm
            /// </summary>
            UnGroup,

            /// <summary>
            /// Xóa nhóm
            /// </summary>
            ClearGrouping,

            /// <summary>
            /// Thu gọn tất cả
            /// </summary>
            FullCollapse,

            /// <summary>
            /// Mở rộng tất cả
            /// </summary>
            FullExpand,

            /// <summary>
            /// Sắp xếp nhóm bởi tổng
            /// </summary>
            SortGroupBySummary,

            /// <summary>
            /// Soạn thảo nhóm tổng
            /// </summary>
            GroupSummaryEditor,

            /// <summary>
            /// Thiết lập lại sắp xếp tổng nhóm
            /// </summary>
            ResetGroupSummarySort,

            /// <summary>
            /// Các mục
            /// </summary>
            Items,

            /// <summary>
            /// Thứ tự
            /// </summary>
            Orders,

            /// <summary>
            /// Soạn thảo phần tổng
            /// </summary>
            TotalSummaryEditor,

            /// <summary>
            /// Di chuyển xuống mục dưới
            /// </summary>
            MoveItemDown,

            /// <summary>
            /// Di chuyển lên mục trên
            /// </summary>
            MoveItemUp,

            /// <summary>
            /// Lọc tất cả
            /// </summary>
            FilterAll,

            /// <summary>
            /// Lọc phần trống
            /// </summary>
            FilterBlanks,

            /// <summary>
            /// Lọc phần không trống
            /// </summary>
            FilterNonBlanks,

            /// <summary>
            /// Tăng dần
            /// </summary>
            Ascending,

            /// <summary>
            /// Giảm dần
            /// </summary>
            Descending,

            /// <summary>
            /// Tổng
            /// </summary>
            TotalSum,

            /// <summary>
            /// Đếm
            /// </summary>
            Count,

            /// <summary>
            /// Lớn nhất
            /// </summary>
            Max,

            /// <summary>
            /// Nhỏ nhất
            /// </summary>
            Min,

            /// <summary>
            /// Tùy chỉnh
            /// </summary>
            Customize,

            /// <summary>
            /// Tải lại dữ liệu
            /// </summary>
            ReloadData,

            /// <summary>
            /// Hiển thị danh sách cột
            /// </summary>
            ShowFieldList,

            /// <summary>
            /// Hiển thị bộ lọc trước
            /// </summary>
            ShowPrefilter,

            /// <summary>
            /// Bộ lọc trước
            /// </summary>
            Prefilter,

            /// <summary>
            /// Danh sách cột
            /// </summary>
            FieldList,

            /// <summary>
            /// Đồng ý
            /// </summary>
            OK,

            /// <summary>
            /// Thu gọn
            /// </summary>
            Collapse,

            /// <summary>
            /// Mở rộng
            /// </summary>
            Expand,

            /// <summary>
            /// Sắp xếp {0} bởi cột này
            /// </summary>
            SortFieldByColumn,

            /// <summary>
            /// Sắp xếp {0} bởi dòng này
            /// </summary>
            SortFieldByRow,

            /// <summary>
            /// Ẩn
            /// </summary>
            Hidden,

            /// <summary>
            /// Di chuyển đến đầu
            /// </summary>
            MovetoBeginning,

            /// <summary>
            /// Di chuyển sang trái
            /// </summary>
            MovetoLeft,

            /// <summary>
            /// Di chuyển sang phải
            /// </summary>
            MovetoRight,

            /// <summary>
            /// Di chuyển đến cuối
            /// </summary>
            MovetoEnd,

            /// <summary>
            /// Order này đã được gửi bởi người khác.Vui lòng kiểm tra lại!
            /// </summary>
            ThisOrderWasSentByOtherStaff,

            /// <summary>
            /// Order này đã được xử lý bởi người khác.Vui lòng kiểm tra lại!
            /// </summary>
            ThisOrderWasProcessByOtherStaff,

            /// <summary>
            /// Mã khách hàng hay mã thẻ VIP đã tồn tại trong hệ thống!
            /// </summary>
            CustomerCodeOrVipCardCodeExists,

            /// <summary>
            /// Thông tin này đã được trung tâm xử lý!
            /// </summary>
            ThisInforIsProcessedByCenter,

            /// <summary>
            /// Ngày sinh
            /// </summary>
            Birthday,

            /// <summary>
            /// Ngày áp dụng
            /// </summary>
            ApplyDate,

            /// <summary>
            /// Phiếu này đã có phiếu trả hàng!
            /// </summary>
            ThisBillHadBillVoid,

            /// <summary>
            /// Máy in hết giấy
            /// </summary>
            PrinterOutOfPaper,

            /// <summary>
            /// Lỗi máy in bếp.Vui lòng kiểm tra lại!
            /// </summary>
            PrinterError,

            /// <summary>
            /// Máy in bếp bị tắt.Vui lòng kiểm tra lại!
            /// </summary>
            PrinterOffline,

            /// <summary>
            /// Tách phiếu
            /// </summary>
            SplitBill,

            /// <summary>
            /// In tam tính
            /// </summary>
            PrintTemp,

            /// <summary>
            /// Tách phiếu sau khi in
            /// </summary>
            SplitBillAfterPrinted,

            /// <summary>
            /// Danh sách chọn
            /// </summary>
            ChooseList,

            /// <summary>
            /// Phục vụ
            /// </summary>
            Waiter,

            /// <summary>
            /// Quản lý
            /// </summary>
            ManagerRes,

            /// <summary>
            /// In chi tiết
            /// </summary>
            PrintDetail,

            /// <summary>
            /// In không chi tiết
            /// </summary>
            PrintNotDetail,

            /// <summary>
            /// Phiếu này đã in hóa đơn.Bạn có muốn lưu lại thông tin mới?
            /// </summary>
            ThisBillPrintedInvoiceDoYouWantToSaveNewInfor,

            /// <summary>
            /// Số hóa đơn này đã được sử dụng.Bạn cần kiểm tra lại số hóa đơn
            /// </summary>
            ThisInvoiceNumberUsedYouMustRecheckInvoiceNumber,

            /// <summary>
            /// Lưu không thành công do số hóa đơn đã được sử dụng.Chương trình sẽ cấp số hóa đơn mới, xin thao tác lần nữa.
            /// </summary>
            SaveUnsuccessfulByInvoiceNumberUsedProgramWillNewInvoiceNumberPleaseAgain,

            /// <summary>
            /// Bạn có muốn lưu trước khi xem?
            /// </summary>
            DoYouWantSaveBeforeView,

            /// <summary>
            /// Số lượng voucher không đủ
            /// </summary>
            QuantityVoucherNotEnough,

            /// <summary>
            /// Bàn
            /// </summary>
            Table,

            /// <summary>
            /// Vui lòng nhập lý do giảm giá!
            /// </summary>
            PleaseInputReasonDiscount,

            /// <summary>
            /// Phiếu này đang order!
            /// </summary>
            ThisBillHavingOrder,

            /// <summary>
            /// Thẻ này đã được sử dụng
            /// </summary>
            ThisCardHasBeenUsed,

            /// <summary>
            /// Thẻ này không áp dụng cho chi nhánh này
            /// </summary>
            ThisCardDoesNotApplyToThisBranch,

            /// <summary>
            /// Thẻ này không còn trong thời gian áp dụng
            /// </summary>
            ThisCardIsNotAppliedDuring,

            /// <summary>
            /// Hàng hóa
            /// </summary>
            Goods,

            /// <summary>
            /// Ngày duyệt
            /// </summary>
            ApprovedDate,

            /// <summary>
            /// Ngày thanh toán
            /// </summary>
            PaymentDate,

            /// <summary>
            /// Máy in bếp
            /// </summary>
            KitchenPrinter,

            /// <summary>
            /// Thu ngân
            /// </summary>
            Cashiers,

            /// <summary>
            /// Cơ cấu 1
            /// </summary>
            Struct1,

            /// <summary>
            /// Cơ cấu 2
            /// </summary>
            Struct2,

            /// <summary>
            /// Cơ cấu 3
            /// </summary>
            Struct3,

            /// <summary>
            /// Chi tiết
            /// </summary>
            Detail,

            /// <summary>
            /// Trung tính
            /// </summary>
            Bisexual,

            /// <summary>
            /// Không có số dư
            /// </summary>
            EmptyBalance,

            /// <summary>
            /// Tăng
            /// </summary>
            Up,

            /// <summary>
            /// Giảm
            /// </summary>
            Down,

            /// <summary>
            /// Đánh giá
            /// </summary>
            Assessment
        }
    }

}
