using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
//using Rs232;
using System.Text.RegularExpressions;
using app = System.Windows.Forms;
using vnyi.DataProvider;
using System.Reflection;
using vnyi.Library.RES;
using vnyi.Library.Meta.ACC;
using vnyi.Library.Meta.OBJ;
using System.IO.Ports;

namespace vnyi.Utility.RES
{
    public class clsGlobal
    {
        #region Configs
        /// <summary>
        /// Phân hệ
        /// </summary>
        public static short H_MODULE = 0;

        #region Login Infor TouchScreen
        /// <summary>
        /// Liên kết web
        /// </summary>
        public static string S_LINKWEB = "";

        /// <summary>
        /// Chi nhánh
        /// </summary>
        public static int I_ORG_AUTOID = 3;

        /// <summary>
        /// Loại hình KD
        /// </summary>
        public static int I_BUSINESSTYPE = 1;

        public static bool B_TRIAL = false;
        public static DateTime T_TRIALDATE = DateTime.Today.AddYears(1);

        /// <summary>
        /// % VAT
        /// </summary>
        public static int I_VAT = 10;

        /// <summary>
        /// % phí dịch vụ
        /// </summary>
        public static int I_SERVICEPER = 5;

        /// <summary>
        /// VAT mặc định
        /// </summary>
        public static bool B_VATDEFAULT = false;

        /// <summary>
        /// In phiếu xuống bếp
        /// </summary>
        public static bool B_PRINTTICKETTOKITCHEN = false;

        public static bool B_USEDPOCKET = false;
        public static int I_PERIODPRINTTOKITCHEN = 10000;

        /// <summary>
        /// Máy in két tiền
        /// </summary>
        public static string S_PRINTERDRAWERNAME = string.Empty;

        /// <summary>
        /// Máy in bill
        /// </summary>
        public static string S_PRINTERBILLNAME = string.Empty;

        /// <summary>
        /// Quầy
        /// </summary>
        public static int I_COUNTER = 0; //Quầy

        /// <summary>
        /// Sử dụng ngân hàng ảo
        /// </summary>
        public static bool B_USEVIRTUALBANK = false;

        /// <summary>
        /// Sử dụng màn hình 2
        /// </summary>
        public static bool B_USEEXTENDDISPLAY = false;

        /// <summary>
        /// Sử dụng sơ đồ bàn
        /// </summary>
        public static bool B_USETABLEMAP = false;

        /// <summary>
        /// Sử dụng thẻ từ
        /// </summary>
        public static bool B_USEMAGNETICCARD = false;

        /// <summary>
        /// Kí tự đầu thẻ VIP
        /// </summary>
        public static string S_FRISTCHARMAGCARDVIP = "%";

        /// <summary>
        /// Số dòng thẻ VIP
        /// </summary>
        public static int I_NUMBERROWMAGCARDVIP = 0;

        /// <summary>
        /// Kí tự phân cách thẻ từ
        /// </summary>
        public static string S_CHARSEPARATEMAGCARD = ";";

        /// <summary>
        /// Cảnh báo hết hàng
        /// </summary>
        public static bool B_USEALERTEMPTYITEM = false;

        /// <summary>
        /// Sử dụng cân
        /// </summary>
        public static bool B_USEELECTRONICBALANCE = false;

        /// <summary>
        /// Sử dụng POCKET
        /// </summary>
        public static bool B_USEPOCKET = false;

        /// <summary>
        /// Thời gian in POCKET
        /// </summary>
        public static int I_PRINTPOCKETTIME = 0;

        /// <summary>
        /// Sử dụng order mặc định
        /// </summary>
        public static bool B_USEORDERDEFAULT = false;

        /// <summary>
        /// Khu
        /// </summary>
        public static int? I_AREA; //Khu bán hàng

        /// <summary>
        /// Giao hàng
        /// </summary>
        public static bool B_DELIVERY = false;

        /// <summary>
        /// Tạo thông tin khách hàng (Bán lẻ)
        /// </summary>
        public static bool B_RETAIL_CREATECUSTOMER = false;

        /// <summary>
        /// Nhập thông tin trả hàng (Bán lẻ)
        /// </summary>
        public static bool B_RETAIL_INPUTINFOREASOMVOIDITEM = false;

        /// <summary>
        /// Nhập thông tin hủy phiếu (Bán lẻ)
        /// </summary>
        public static bool B_RETAIL_INPUTCANCELTICKET = false;

        /// <summary>
        /// Tạm thoát
        /// </summary>
        public static bool B_RETAIL_SAFEMODE = false;

        /// <summary>
        /// Nhà hàng
        /// </summary>
        public static bool B_RESTAURANT = true;

        /// <summary>
        /// Bán lẻ
        /// </summary>
        public static bool B_RETAIL = true;

        /// <summary>
        /// Karaoke
        /// </summary>
        public static bool B_KARAOKE = false;

        /// <summary>
        /// Internet
        /// </summary>
        public static bool B_INTERNET = false;

        /// <summary>
        /// Cafe
        /// </summary>
        public static bool B_CAFE = false;

        /// <summary>
        /// Bar
        /// </summary>
        public static bool B_BAR = false;

        /// <summary>
        /// Bida
        /// </summary>
        public static bool B_BIDA = false;

        /// <summary>
        /// Chi khác
        /// </summary>
        public static bool B_PAYOUT = true;
        /// <summary>
        /// Thu khác
        /// </summary>
        public static bool B_PAYIN = true;

        /// <summary>
        ///  In hoa don VAT 
        /// </summary>
        public static bool B_PRINTINVOICE = true;

        /// <summary>
        /// Quản lý bếp
        /// </summary>
        public static bool B_MANAGEKITCHEN = true;

        /// <summary>
        /// Thời gian check kết nối với Server
        /// </summary>
        public static int I_TIMECHECKCONNSERVER = 5;

        /// <summary>
        /// Khoảng thời gian chờ tăng tiền giờ Karaoke
        /// </summary>
        public static int I_TIMEWAITFORKARAOKE = 5;

        /// <summary>
        /// Vào bàn tự động 
        /// </summary>
        public static bool B_AUTODINEIN = false;

        /// <summary>
        ///  Hủy phiếu nếu không order 
        /// </summary>
        public static bool B_CANCELIFNOTORDER = false;

        /// <summary>
        /// Nhập thông tin order
        /// </summary>
        public static bool B_INPUTINFORORDER = false;

        /// <summary>
        /// Thanh toan ngay 
        /// </summary>
        public static bool B_QUICKPAY = false;

        /// <summary>
        /// Thanh toán nhanh (Bán lẻ)
        /// </summary>
        public static bool B_RETAIL_QUICKPAY = false;

        /// <summary>
        ///  Ưu tiên thanh toán thẻ 
        /// </summary>
        public static bool B_QUICKPAYPRIORITY = false;

        /// <summary>
        /// In tạm tính
        /// </summary>
        public static bool B_PRINTTEMP = true;

        /// <summary>
        /// Số lần in tạm tính 
        /// </summary>
        public static int I_NUMBERSOFPRINTTEMP = 3;

        /// <summary>
        /// Chuyển bàn
        /// </summary>
        public static bool B_TRANFERTABLE = true;

        /// <summary>
        ///  Ghép phiếu
        /// </summary>
        public static bool B_LINKBILL = true;

        /// <summary>
        /// Nhóm phiếu 
        /// </summary>
        public static bool B_GROUPBILL = true;

        /// <summary>
        /// Tách phiếu
        /// </summary>
        public static bool B_SEPERATEBILL = true;

        /// <summary>
        /// Sử dụng tiếp khách 
        /// </summary>
        public static bool B_RECEPTION = true;

        /// <summary>
        /// sử dụng tiền boa
        /// </summary>
        public static bool B_TIP = true;

        /// <summary>
        /// Sửa giá 
        /// </summary>
        public static bool B_RETAIL_EDITPRICE = true;

        /// <summary>
        /// Thẻ khách hàng
        /// </summary>
        public static bool B_RETAIL_CUSTOMERCARD = true;

        /// <summary>
        /// Thẻ khách hàng 
        /// </summary>
        public static bool B_RETAIL_CUSTOMER = true;

        /// <summary>
        /// Giảm giá
        /// </summary>
        public static bool B_RETAIL_DISCOUNT = true;

        /// <summary>
        /// Thanh Toán Thẻ
        /// </summary>
        public static bool B_RETAIL_PAYMENTCARD = true;

        /// <summary>
        /// Thanh toán
        /// </summary>
        public static bool B_PAYMENT = true;

        /// <summary>
        /// Sử dụng thẻ VIP
        /// </summary>
        public static bool B_VIPCARD = true;

        /// <summary>
        /// Sử dụng Voucher
        /// </summary>
        public static bool B_VOUCHER = true;

        /// <summary>
        /// Sử dụng Coupon
        /// </summary>
        public static bool B_COUPON = true;

        /// <summary>
        /// Sử dụng phiếu tặng
        /// </summary>
        public static bool B_TICKETGIFT = true;

        /// <summary>
        ///  Chuỗi kết nối cho VIPCard 
        /// </summary>
        public static string S_CONNECTIONSTRINGFORVIPCARD;

        /// <summary>
        /// Âm thanh bếp
        /// </summary>
        public static string S_SOUNDKITCHEN;

        /// <summary>
        /// Âm thanh nhắc nhở
        /// </summary>
        public static string S_REMINDKITCHEN;

        /// <summary>
        /// Thời gian báo hàng mới
        /// </summary>
        public static int I_TIMEALERTNEWITEM = 1;

        /// <summary>
        /// Thời gian nhắc hàng trễ
        /// </summary>
        public static int I_TIMEALERTLATEITEM = 1;
        #endregion

        #region Information Card
        /// <summary>
        /// Số dòng thẻ nhân viên
        /// </summary>
        public static int I_NUMBERROWSTAFFCARD = 1;

        /// <summary>
        /// Kí tự đầu thẻ nhân viên
        /// </summary>
        public static string S_FIRSTCHAROFSTAFFCARD = "%";

        #endregion

        #region Infor Restaurant
        /// <summary>
        /// Khách hàng
        /// </summary>
        public static string S_CUSTOMER = string.Empty;

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public static string S_ADDRESS = string.Empty;

        /// <summary>
        /// Điện thoại
        /// </summary>
        public static string S_PHONE = string.Empty;

        /// <summary>
        /// Fax
        /// </summary>
        public static string S_FAX = string.Empty;

        /// <summary>
        /// Thư điện tử
        /// </summary>
        public static string S_EMAIL = string.Empty;

        /// <summary>
        /// Mã số thuế
        /// </summary>
        public static string S_TAXID = null;
        #endregion

        #region Infor Comport
        //public static ComPort CP_COM = new ComPort();
        /// <summary>
        /// Sử dụng LCD
        /// </summary>
        public static bool B_USERLCDCOMPORT = false;

        /// <summary>
        /// Chiều dài LCD
        /// </summary>
        public static int I_LCDLEN = 20;

        /// <summary>
        /// Khoảng cách
        /// </summary>
        public static int I_DISTANCE = 4;

        /// <summary>
        /// Số cổng COM
        /// </summary>
        public static int I_COMPORTNUMBER = 1;

        /// <summary>
        /// Tốc độ thay đổi trạng thái
        /// </summary>
        public static int I_BAUDRATE = 9600;

        /// <summary>
        /// Tiều đề LCD
        /// </summary>
        public static string S_LCDTITLE = string.Empty;
        #endregion

        #region "Infor Need Card"
        public static bool B_USECARD = false;
        /// <summary>
        /// Cổng COM EPB
        /// </summary>
        public static int I_EPBCOMPORT = 0;

        /// <summary>
        /// Cổng EPB
        /// </summary>
        public static int I_EPB_PORT = 2;

        /// <summary>
        /// Tốc độ thay đổi trạng thái EBP
        /// </summary>
        public static int I_EBP_BAUDRATE = 9600;
        #endregion

        /// <summary>
        /// IN HÓA ĐƠN KÈM THEO BILL
        /// </summary>
        public static bool B_PRINTINVOICEFORBILL = false;

        /// <summary>
        /// VAT
        /// </summary>
        public static bool B_ISVAT = true;

        /// <summary>
        /// Màn hình bán hàng mở rộng
        /// </summary>
        public static bool B_ISZOOM = true;

        /// <summary>
        /// Loại tiền
        /// </summary>
        public static Int16 I_CURRENCY = 1;

        /// <summary>
        /// Sử dụng thông báo
        /// </summary>
        public static bool B_ISMESSAGE = true;

        /// <summary>
        /// Nhiều phiếu 1 bàn
        /// </summary>
        public static bool B_MULTIBILLINTALBE = true;

        /// <summary>
        /// Chế độ an toàn
        /// </summary>
        public static bool B_ISSAFE = true;

        /// <summary>
        /// ID Ngôn ngữ 
        /// </summary>
        public static short I_LANGID = 1;

        /// <summary>
        /// Đường dẫn tập tin kết nối
        /// </summary>
        public static string S_FILECONNECT = app.Application.StartupPath + @"\Configs\Connect.xml";

        /// <summary>
        ///  Đường dẫn tập tin cấu hình
        /// </summary>
        public static string S_FILECONFIG = app.Application.StartupPath + @"\Configs\configs.xml";

        /// <summary>
        ///  Đường dẫn tập tin lưu layout của cái grid
        /// </summary>
        public static string S_FOLDERLAYOUTGRID = app.Application.StartupPath + @"\Layout\";

        #region Chiều rộng, cao của button nhóm và mặt hàng
        /// <summary>
        /// Chiều rộng nhóm hàng
        /// </summary>
        public static double D_WIDTHBTNGROUPITEM = 0;

        /// <summary>
        /// Chiều rộng choice
        /// </summary>
        public static double D_WIDTHBTNCHOICEITEM = 0;

        /// <summary>
        /// Chiều cao của choice
        /// </summary>
        public static double D_HEIGHTBTNCHOICEITEM = 0;

        /// <summary>
        /// Chiều cao của set
        /// </summary>
        public static double D_HEIGHTBTNITEMSET = 0;

        /// <summary>
        /// Chiều rộng của set
        /// </summary>
        public static double D_WIDTHBTNITEMSET = 0;

        /// <summary>
        /// Chiều cao nhóm hàng
        /// </summary>
        public static double D_HEIGHTBTNGROUPITEM = 0;

        /// <summary>
        /// Chiều rộng mặt hàng
        /// </summary>
        public static double D_WIDTHBTNITEM = 0;

        /// <summary>
        /// Chiều cao mặt hàng
        /// </summary>
        public static double D_HEIGHTBTNITEM = 0;

        /// <summary>
        /// Khoảng cách trên nhóm
        /// </summary>
        public static double D_TOPBTNGROUPITEM = 0;

        /// <summary>
        /// Khoảng cách trái nhóm
        /// </summary>
        public static double D_LEFTBTNGROUPITEM = 0;

        /// <summary>
        /// Khoảng cách trên mặt hàng
        /// </summary>
        public static double D_TOPBTNITEM = 0;

        /// <summary>
        /// Khoảng cách trái mặt hàng
        /// </summary>
        public static double D_LEFTBTNITEM = 0;

        /// <summary>
        /// Màu nền nhóm 1
        /// </summary>
        public static string S_BACKGROUNDBTNGROUPITEM1 = string.Empty;

        /// <summary>
        /// Màu nền nhóm 2
        /// </summary>
        public static string S_BACKGROUNDBTNGROUPITEM2 = string.Empty;

        /// <summary>
        /// Màu nền mặt hàng
        /// </summary>
        public static string S_BACKGROUNDBTNITEM = string.Empty;

        /// <summary>
        /// Kích thước font nhóm 1
        /// </summary>
        public static double D_FONTSIZEBTNGROUPITEM1 = 0;

        /// <summary>
        /// Kích thước font nhóm 2
        /// </summary>
        public static double D_FONTSIZEBTNGROUPITEM2 = 0;

        /// <summary>
        /// Kích thước font mặt hàng
        /// </summary>
        public static double D_FONTSIZEBTNITEM = 0;

        /// <summary>
        /// Khoảng cách trái của bàn
        /// </summary>
        public static double D_MARGINLEFTTABLE = 2;

        /// <summary>
        /// Khoảng cách trên của bàn
        /// </summary>
        public static double D_MARGINTOPTABLE = 3;

        #endregion

        /// <summary>
        /// Hiển thị hình mặt hàng
        /// </summary>
        public static bool B_USEIMAGEITEM = false;

        /// <summary>
        /// Hiển thị mã hàng
        /// </summary>
        public static bool B_USEITEMNO = false;

        /// <summary>
        /// Hiển thị mã nhóm
        /// </summary>
        public static bool B_USEGROUPNO = false;

        /// <summary>
        /// Màu chữ nhóm 1
        /// </summary>
        public static string S_FONTCOLORGROUP1 = string.Empty;

        /// <summary>
        /// Màu chữ nhóm 2
        /// </summary>
        public static string S_FONTCOLORGROUP2 = string.Empty;

        /// <summary>
        /// Màu chữ mặt hàng
        /// </summary>
        public static string S_FONTCOLORITEM = string.Empty;

        /// <summary>
        /// Font chữ
        /// </summary>
        public static string S_FONTFAMILY = string.Empty;

        /// <summary>
        /// Màu bàn có nhiều bill
        /// </summary>
        public static string S_COLORTABLEMULTIBILL = string.Empty;//mau ban co nhieu bill

        /// <summary>
        /// Màu bàn đã in
        /// </summary>
        public static string S_COLORTABLEPRINTED = string.Empty;

        /// <summary>
        /// màu bàn in nhiều lần
        /// </summary>
        public static string S_COLORTABLEPPRINTMANY = string.Empty;

        /// <summary>
        /// Màu chữ bàn có nhiều bill
        /// </summary>
        public static string S_FORECOLORTABLEMULTIBILL = string.Empty;

        /// <summary>
        /// Màu chữ bàn trống
        /// </summary>
        public static string S_FORECOLOREMPTYTABLE = string.Empty;

        /// <summary>
        /// Màu chữ bàn có khách
        /// </summary>
        public static string S_FORECOLORCUSTABLE = string.Empty;

        /// <summary>
        /// Màu chữ bàn đã in
        /// </summary>
        public static string S_FORECOLORCUSTABLEPRINTED = string.Empty;

        /// <summary>
        /// Màu chữu bàn in nhiều lần
        /// </summary>
        public static string S_FORECOLORCUSPRINTMANY = string.Empty;

        /// <summary>
        /// Màu chữ tên khách trên bàn
        /// </summary>
        public static string S_FORECOLORCUSTOMER = "#EEECE1";

        /// <summary>
        /// Màu chữ thời gian order trên bàn
        /// </summary>
        public static string S_FORECOLORTIMEORDER = "#EEECE1";

        /// <summary>
        /// Màu chữ tổng tiền trên bàn
        /// </summary>
        public static string S_FORECOLORAMOUNT = "#EEECE1";

        /// <summary>
        /// Cách hiển thị mặt hàng(ngang hay dọc)
        /// </summary>
        public static ShowMethod I_SHOWMETHOD = ShowMethod.Column;

        /// <summary>
        /// //Cách hiển thị bàn (ngang, dọc)
        /// </summary>
        public static ViewTypeTable I_VIEWTYPETABLE = ViewTypeTable.Horizontal;

        /// <summary>
        /// Tự động chạy chương trình cùng window
        /// </summary>
        public static bool B_USEAUTOSTARTWITHWINDOW = false;

        /// <summary>
        /// Sử dụng chi tiết hàng
        /// </summary>
        public static bool B_ITEMDETAIL = false;

        #region Cac key barcode thanh toan
        /// <summary>
        /// Key để thanh toán nhanh bằng barcode
        /// </summary>
        public static string S_KEYBARCODE_CASH = "#TT#";

        #endregion

        /// <summary>
        /// Số bản in phiếu tính tiền
        /// </summary>
        public static int I_NUMBERSOFPRINTBILL = 1;

        /// <summary>
        /// Sử dụng giao ca
        /// </summary>
        public static bool B_USESHIFT = true;

        /// <summary>
        /// In hàng bán khi gửi order
        /// </summary>
        public static bool B_PRINTITEMAFTERORDER = false;

        /// <summary>
        /// Nhập đúng mã thẻ khi thanh toán bằng thẻ?
        /// </summary>
        public static bool B_INPUTINFORCARD = false;

        /// <summary>
        /// Thời gian khóa màn hình
        /// </summary>
        public static int I_TIMELOCKSCREEN = 600;

        /// <summary>
        /// ID của máy POS
        /// </summary>
        public static int I_RSP_POSID = 1;

        /// <summary>
        /// Sử dụng COM khác
        /// </summary>
        public static bool B_USECOM3 = false;

        /// <summary>
        /// Sử dụng Đặt cọc
        /// </summary>
        public static bool B_USEDEPOSIT = true;

        /// <summary>
        /// KI TU NHAN DIEN BAN DUNG DE GIAO HANG
        /// </summary>
        public static string S_TABLEDELIVERY = string.Empty;

        /// <summary>
        /// Tên Process của chương trình đang chạy trong task manager
        /// </summary>
        public static string S_PROCESSNAME = System.Diagnostics.Process.GetCurrentProcess().ProcessName;

        /// <summary>
        /// ID của Process của chương trình đang chạy trong task manager
        /// </summary>
        public static int I_PROCESSID = System.Diagnostics.Process.GetCurrentProcess().Id;

        /// <summary>
        /// Tên đăng nhập cơ sở dữ liệu
        /// </summary>
        public static string S_UID = string.Empty;

        /// <summary>
        /// Số bản in phiếu kết thúc
        /// </summary>
        public static int I_NUMPRINTCOPYBILLFINISH = 1;

        /// <summary>
        /// Mở két tiền khi vào ca
        /// </summary>
        public static bool B_OPENCASHDRAWERWHENCASHIERIN = false;

        /// <summary>
        /// Mở két tiền khi ra ca
        /// </summary>
        public static bool B_OPENCASHDRAWERWHENCASHIEROUT = false;

        /// <summary>
        /// Mở két tiền khi áp dụng voucher
        /// </summary>
        public static bool B_OPENCASHDRAWERWHENAPPVOUCHER = false;

        /// <summary>
        /// Mở két tiền khi trả tiền mặt
        /// </summary>
        public static bool B_OPENCASHDRAWERWHENCASH = false;

        /// <summary>
        /// Hiện nút kết thúc phiếu nhà hàng
        /// </summary>
        public static bool B_SHOWFINISHBILLRES = true;

        /// <summary>
        /// Hiện nút thanh toán nhà hàng
        /// </summary>
        public static bool B_SHOWPAYMENTRES = true;

        /// <summary>
        /// Hiện nút in và kết thúc nhà hàng
        /// </summary>
        public static bool B_SHOWPRINTANDFINISHRES = true;

        /// <summary>
        /// Hiện nút "sửa số lượng" sau khi đã mặt hàng đó đã order
        /// </summary>
        public static bool B_EDITQTYAFTERORDERED = false;
        #endregion

        #region Functions

        #region Connection
        public static void SetConnectionForService(string Server, string Database, string UID, string Pass,int TimeOut)
        {            
            SqlHelper.ConnectString = String.Format("Server={0};Database={1};" +
                                                "uid={2};pwd={3};Connection Timeout={4}", Server, Database, UID, Pass, TimeOut);
        }

        public static void SetConnection(string Server, string Database, string UID, string Pass)
        {
            S_UID = UID;
            SqlHelper.ConnectString = String.Format("Server={0};Database={1};" +
                                                "uid={2};pwd={3};Connection Timeout=1", Server, Database, UID, Pass);
        }

        public static bool CheckConnection(string Server, string Database, string UID, string Pass)
        {
            try
            {
                string str = String.Format("Server={0};Database={1};" +
                                    "uid={2};pwd={3};Connection Timeout=1", Server, Database, UID, Pass);
                SqlConnection sql = new SqlConnection(str);
                switch (sql.State)
                {
                    case ConnectionState.Open:
                        return true;
                    case ConnectionState.Closed:
                        sql.Dispose();
                        sql = new SqlConnection(str);
                        try
                        {
                            sql.Open();
                            return true;
                        }
                        catch { }
                        return false;
                }
            }
            catch { }
            return false;
        }

        public static bool CheckConnection(string str)
        {
            try
            {
                SqlConnection sql = new SqlConnection(str);
                switch (sql.State)
                {
                    case ConnectionState.Open:
                        return true;
                    case ConnectionState.Closed:
                        sql.Dispose();
                        sql = new SqlConnection(str);
                        try
                        {
                            sql.Open();
                            return true;
                        }
                        catch { }
                        return false;
                }
            }
            catch { }
            return false;
        }
        #endregion

        public static bool FormatDateInRegional()
        {
            string ret = string.Empty;
            ret = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\International", true).GetValue("sShortdate").ToString();
            if (ret.Trim().ToUpper() != "DD/MM/YYYY")
            {
                ret = "dd/MM/yyyy";
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\International", true).SetValue("sShortdate", ret);
                return false;
            }
            return true;
        }

        public static bool FormatDecimalNumberInRegion()
        {
            string ret = string.Empty;

            ret = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\International", true).GetValue("sDecimal").ToString();
            if (ret != ".")
            {
                ret = ".";
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\International", true).SetValue("sDecimal", ret);
                return false;
            }

            ret = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\International", true).GetValue("sThousand").ToString();

            if (ret != ",")
            {
                ret = ",";
                Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\International", true).SetValue("sThousand", ret);
                return false;
            }

            return true;
        }

        public static object ReturnIfNull(object pValue, object pValueReturn)
        {
            if (pValue == null)
                return pValueReturn;
            if (pValue.ToString().Length == 0)
                return pValueReturn;
            return pValue;
        }

        public static bool DateIsNull(string pDate)
        {
            if (pDate == clsConstant.DATETIME_NULL)
                return true;
            else
                return false;
        }

        public static bool isNum(object strCheck)
        {
            try
            {
                Convert.ToDouble(strCheck);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNumber(String strNumber)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");
            return !objNotNumberPattern.IsMatch(strNumber) &&
            !objTwoDotPattern.IsMatch(strNumber) &&
            !objTwoMinusPattern.IsMatch(strNumber) &&
            objNumberPattern.IsMatch(strNumber);
        }

        /// <summary>
        /// Định dạng giá trị cột tiền để hiển thị lên form
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FormatMoney(object value)
        {
            return String.Format("{0:" + S_FORMATNUMBER + "}", value);
        }

        /// <summary>
        /// Định dạng giá trị tiền
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FormatMoneyForAll(object value)
        {
            return String.Format("{0:#,###,###,###.#####}", value);
        }

        /// <summary>
        /// Định dạng giá trị cột tiền để hiển thị lên form
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FormatMoney(decimal value, bool Decimal)
        {
            return clsFormat.DecimalToString(value, Decimal);
        }

        public static string FormatValueInUserControl(decimal value)
        {
            if (value > 0 && value < 1)
                return String.Format("{0:0.#####}", value);
            else
                if (value == 0)
                    return "0";
                else
                    return String.Format("{0:#,###.#####}", value);
        }

        /// <summary>
        /// Định dạng giá trị số lượng để hiển thị lên form
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FormatQuantity(decimal value)
        {
            //return String.Format("{0:" + S_FORMATUOM + "}", value);
            return String.Format("{0:0.#####}", value);
        }

        #region Format Date Time
        public static string FormatDate(DateTime dt)
        {
            return String.Format("{0:" + clsGlobal.S_FORMATDATE + "}", dt);
        }

        public static string GetCurrentTime()
        {
            return String.Format("{0:HH:mm:ss}", DateTime.Now);
        }

        public static string GetCurrentDateTime()
        {
            return String.Format("{0:" + clsGlobal.S_FORMATDATETIME + "}", DateTime.Now);
        }

        public static string FormatDateTime(DateTime dt)
        {
            return String.Format("{0:" + clsGlobal.S_FORMATDATETIME + "}", dt);
        }

        #endregion

        public static void GetInforUse(bool isWeb)
        {
            if (isWeb)
                clsGlobal.I_RSP_POSID = clsFormat.IntConvert(System.Configuration.ConfigurationManager.AppSettings[ConfigName.I_POSID.ToString()]);
            else
                I_RSP_POSID = clsFormat.IntConvert(clsSysUtils.ReadSetting(clsGlobal.S_FILECONFIG, ConfigName.I_POSID.ToString()));

            DataSet ds = new DataSet();
            DataTable dtConfig = new DataTable();

            ds = RESPOSCONFIGDAO.GetConfigValue(I_RSP_POSID);

            if (dtConfig.Rows.Count <= 0)
            {
                DataRow newrow = dtConfig.NewRow();
                dtConfig.Rows.Add(newrow);
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row[RESPOSCONFIG.COLUMN_RPOC_CODE].ToString().Substring(0, 2) == "B_")
                    dtConfig.Columns.Add(row[RESPOSCONFIG.COLUMN_RPOC_CODE].ToString(), typeof(Boolean));
                else
                    dtConfig.Columns.Add(row[RESPOSCONFIG.COLUMN_RPOC_CODE].ToString(), typeof(string));

                if (row[RESPOSCONFIG.COLUMN_RPOC_CODE].ToString().Substring(0, 2) == "B_")
                    dtConfig.Rows[0][row[RESPOSCONFIG.COLUMN_RPOC_CODE].ToString()] = clsFormat.BooleanConvert(row["VALUE"]);
                else
                    dtConfig.Rows[0][row[RESPOSCONFIG.COLUMN_RPOC_CODE].ToString()] = row["VALUE"].ToString();
            }
            try
            {
                clsGlobal.S_IPSERVERREMOTE = (dtConfig.Rows[0][ConfigName.S_IPSERVERREMOTE.ToString()]).ToString();
            }
            catch { }
            try
            {
                clsGlobal.I_SERVERPORTREMOTE = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_SERVERPORTREMOTE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.S_FORECOLORAMOUNT = (dtConfig.Rows[0][ConfigName.S_FORECOLORAMOUNT.ToString()]).ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_FORECOLORTIMEORDER = (dtConfig.Rows[0][ConfigName.S_FORECOLORTIMEORDER.ToString()]).ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_FORECOLORCUSTOMER = (dtConfig.Rows[0][ConfigName.S_FORECOLORCUSTOMER.ToString()]).ToString();
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_CUSTOMER = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_CUSTOMER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_TIMEALERTLATEITEM = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_TIMEALERTLATEITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_TIMEALERTNEWITEM = clsFormat.IntConvert((dtConfig.Rows[0][ConfigName.I_TIMEALERTNEWITEM.ToString()]));
            }
            catch { }
            try
            {
                clsGlobal.S_SOUNDKITCHEN = (dtConfig.Rows[0][ConfigName.S_SOUNDKITCHEN.ToString()]).ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_REMINDKITCHEN = (dtConfig.Rows[0][ConfigName.S_REMINDKITCHEN.ToString()]).ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_CONNECTIONSTRINGFORVIPCARD = (dtConfig.Rows[0][ConfigName.S_CONNECTIONSTRINGFORVIPCARD.ToString()]).ToString();
            }
            catch { }
            try
            {
                clsGlobal.B_VIPCARD = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_VIPCARD.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_VOUCHER = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_VOUCHER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_COUPON = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_COUPON.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_TICKETGIFT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_TICKETGIFT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_EDITPRICE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_EDITPRICE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_CUSTOMERCARD = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_CUSTOMERCARD.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_DISCOUNT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_DISCOUNT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_CREATECUSTOMER = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_CREATECUSTOMER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_INPUTINFOREASOMVOIDITEM = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_INPUTINFOREASOMVOIDITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_PAYMENTCARD = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_PAYMENTCARD.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_PAYMENT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PAYMENT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_TIP = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_TIP.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RECEPTION = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RECEPTION.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_SEPERATEBILL = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_SEPERATEBILL.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_GROUPBILL = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_GROUPBILL.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_LINKBILL = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_LINKBILL.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_TRANFERTABLE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_TRANFERTABLE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_NUMBERSOFPRINTTEMP = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_NUMBERSOFPRINTTEMP.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_PRINTTEMP = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PRINTTEMP.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_QUICKPAYPRIORITY = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_QUICKPAYPRIORITY.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_QUICKPAY = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_QUICKPAY.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_QUICKPAY = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_QUICKPAY.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_INPUTINFORORDER = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_INPUTINFORORDER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_CANCELIFNOTORDER = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_CANCELIFNOTORDER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_AUTODINEIN = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_AUTODINEIN.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_TIMEWAITFORKARAOKE = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_TIMEWAITFORKARAOKE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_TIMECHECKCONNSERVER = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_TIMECHECKCONNSERVER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_PRINTINVOICE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PRINTINVOICE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_MANAGEKITCHEN = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_MANAGEKITCHEN.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_PAYIN = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PAYIN.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_PAYOUT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PAYOUT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RESTAURANT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RESTAURANT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_KARAOKE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_KARAOKE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_INTERNET = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_INTERNET.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_CAFE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_CAFE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_BAR = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_BAR.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_BIDA = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_BIDA.ToString()]);
            }
            catch { }
            try
            { clsGlobal.S_LINKWEB = dtConfig.Rows[0][ConfigName.S_LINKWEB.ToString()].ToString().Trim(); }
            catch { }
            try
            {
                clsGlobal.I_BUSINESSTYPE = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_BUSINESSTYPE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USEEXTENDDISPLAY = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEEXTENDDISPLAY.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_ORG_AUTOID = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_ORG_AUTOID.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USETABLEMAP = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USETABLEMAP.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USEMAGNETICCARD = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEMAGNETICCARD.ToString()]);
            }
            catch { }
            try
            { clsGlobal.S_FIRSTCHAROFSTAFFCARD = dtConfig.Rows[0][ConfigName.S_FIRSTCHAROFSTAFFCARD.ToString()].ToString(); }
            catch { }
            try
            { clsGlobal.I_NUMBERROWSTAFFCARD = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_NUMBERROWSTAFFCARD.ToString()]); }
            catch { }
            try
            {
                clsGlobal.S_FRISTCHARMAGCARDVIP = dtConfig.Rows[0][ConfigName.S_FRISTCHARMAGCARDVIP.ToString()].ToString();
            }
            catch { }
            try
            { clsGlobal.I_NUMBERROWMAGCARDVIP = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_NUMBERROWMAGCARDVIP.ToString()]); }
            catch { } try
            {
                clsGlobal.S_CHARSEPARATEMAGCARD = dtConfig.Rows[0][ConfigName.S_CHARSEPARATEMAGCARD.ToString()].ToString();
            }
            catch { }
            try
            { clsGlobal.B_USEALERTEMPTYITEM = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEALERTEMPTYITEM.ToString()]); }
            catch { }
            try
            {
                clsGlobal.B_USEELECTRONICBALANCE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEELECTRONICBALANCE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_EPBCOMPORT = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_EPBCOMPORT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_EPB_PORT = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_EPB_PORT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_EBP_BAUDRATE = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_EBP_BAUDRATE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USERLCDCOMPORT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USERLCDCOMPORT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_LCDLEN = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_LCDLEN.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_DISTANCE = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_DISTANCE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_COMPORTNUMBER = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_COMPORTNUMBER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_BAUDRATE = clsFormat.Int16Convert(dtConfig.Rows[0][ConfigName.I_BAUDRATE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.S_LCDTITLE = dtConfig.Rows[0][ConfigName.S_LCDTITLE.ToString()].ToString().Trim();
            }
            catch { }
            try
            {
                clsGlobal.B_USEIMAGEITEM = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEIMAGEITEM.ToString()].ToString());
            }
            catch { }
            try
            {
                clsGlobal.B_USEITEMNO = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEITEMNO.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USEGROUPNO = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEGROUPNO.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.S_FONTCOLORGROUP1 = dtConfig.Rows[0][ConfigName.S_FONTCOLORGROUP1.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_FONTCOLORGROUP2 = dtConfig.Rows[0][ConfigName.S_FONTCOLORGROUP2.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_FONTCOLORITEM = dtConfig.Rows[0][ConfigName.S_FONTCOLORITEM.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_FONTFAMILY = dtConfig.Rows[0][ConfigName.S_FONTFAMILY.ToString()].ToString();
            }
            catch { }
            try
            {
                if (clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_SHOWMETHOD.ToString()]) ==
                    clsFormat.IntConvert(ShowMethod.Row.GetStringValue()))
                    clsGlobal.I_SHOWMETHOD = ShowMethod.Row;
                else
                    clsGlobal.I_SHOWMETHOD = ShowMethod.Column;
            }
            catch { }
            try
            {
                if (clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_VIEWTYPETABLE.ToString()]) ==
                    clsFormat.IntConvert(ViewTypeTable.Horizontal.GetStringValue()))
                    clsGlobal.I_VIEWTYPETABLE = ViewTypeTable.Horizontal;
                else
                    clsGlobal.I_VIEWTYPETABLE = ViewTypeTable.Vertical;
            }
            catch { }
            try
            {
                DataSet dst = PUBOBJECTDAO.GetInforOfOrg(clsGlobal.I_ORG_AUTOID);
                if (dst.Tables.Count > 0)
                    if (dst.Tables[0].Rows.Count > 0)
                    {
                        clsGlobal.S_CUSTOMER = dst.Tables[0].Rows[0][PUBOBJECTORG.COLUMN_OBJ_BUSSINESSNAME].ToString();
                        clsGlobal.S_ADDRESS = dst.Tables[0].Rows[0][PUBOBJECT.COLUMN_OBJ_ADDRESS].ToString();
                        clsGlobal.S_PHONE = dst.Tables[0].Rows[0][PUBOBJECTORG.COLUMN_OBJ_PHONE].ToString();
                        clsGlobal.S_FAX = dst.Tables[0].Rows[0][PUBOBJECT.COLUMN_OBJ_FAX].ToString();
                        clsGlobal.S_EMAIL = dst.Tables[0].Rows[0][PUBOBJECT.COLUMN_OBJ_EMAIL].ToString();
                        clsGlobal.S_TAXID = dst.Tables[0].Rows[0][PUBOBJECT.COLUMN_OBJ_TAXID].ToString();
                    }
            }
            catch { }
            //clsGlobal.S_CUSTOMER = dtConfig.Rows[0][ConfigName.S_CUSTOMER.ToString()].ToString().Trim();
            //clsGlobal.S_ADDRESS = dtConfig.Rows[0][ConfigName.S_ADDRESS.ToString()].ToString().Trim();
            //clsGlobal.S_PHONE = dtConfig.Rows[0][ConfigName.S_PHONE.ToString()].ToString().Trim();
            //clsGlobal.S_FAX = dtConfig.Rows[0][ConfigName.S_FAX.ToString()].ToString().Trim();
            //clsGlobal.S_EMAIL = dtConfig.Rows[0][ConfigName.S_EMAIL.ToString()].ToString().Trim();
            //clsGlobal.S_TAXID = dtConfig.Rows[0][ConfigName.S_TAXID.ToString()].ToString().Trim();
            try
            { clsGlobal.B_USEPOCKET = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEPOCKET.ToString()]); }
            catch { }
            try
            {
                clsGlobal.B_VATDEFAULT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_VATDEFAULT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_VAT = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_VAT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_SERVICEPER = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_SERVICEPER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.S_PRINTERDRAWERNAME = dtConfig.Rows[0][ConfigName.S_PRINTERDRAWERNAME.ToString()].ToString().Trim();
            }
            catch { }
            try
            {
                clsGlobal.S_PRINTERBILLNAME = dtConfig.Rows[0][ConfigName.S_PRINTERBILLNAME.ToString()].ToString().Trim();
            }
            catch { }
            try
            {
                clsGlobal.B_PRINTTICKETTOKITCHEN = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PRINTTICKETTOKITCHEN.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_PRINTPOCKETTIME = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_PRINTPOCKETTIME.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_COUNTER = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_COUNTER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USEORDERDEFAULT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEORDERDEFAULT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_ISVAT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_ISVAT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_PRINTINVOICEFORBILL = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PRINTINVOICEFORBILL.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_ISZOOM = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_ISZOOM.ToString()]);
            }
            catch { }
            try
            {

                clsGlobal.I_CURRENCY = clsFormat.Int16Convert(dtConfig.Rows[0][ConfigName.I_CURRENCY.ToString()]);
            }
            catch { }
            try
            {
                PUBCURRENCY obj = PUBCURRENCYDAO.SelectByID(clsGlobal.I_CURRENCY);
                clsGlobal.S_DECIMALPOINT = obj.CUR_DECIMALPOINT;
                clsGlobal.S_SEPARATECHAR = obj.CUR_SEPARATE;
                if (obj.CUR_ROUNDNUMBER >= 0)
                {
                    clsGlobal.S_FORMATNUMBER = "###" + obj.CUR_SEPARATE + "###";
                }
                else
                {
                    clsGlobal.S_FORMATNUMBER = "###" + obj.CUR_SEPARATE + "###" + obj.CUR_DECIMALPOINT;
                    for (int i = 0; i < Math.Abs((short)obj.CUR_ROUNDNUMBER); i++)
                    {
                        clsGlobal.S_FORMATNUMBER += "#";
                    }
                }
                //clsGlobal.S_FORMATUOM = "###" + obj.CUR_SEPARATE + "###"
                //        + obj.CUR_DECIMALPOINT + "#####";
                clsGlobal.S_FORMATUOM = "0" + obj.CUR_DECIMALPOINT + "#####";

            }
            catch
            {
                clsGlobal.S_DECIMALPOINT = ".";
                clsGlobal.S_SEPARATECHAR = ",";
                clsGlobal.S_FORMATNUMBER = "##,###,###";
                //clsGlobal.S_FORMATUOM = "##,###,###.#####";
                clsGlobal.S_FORMATUOM = "0.#####";
            }
            try
            {
                clsGlobal.B_ISMESSAGE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_ISMESSAGE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_MULTIBILLINTALBE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_MULTIBILLINTALBE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_ISSAFE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_ISSAFE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_LANGID = clsFormat.Int16Convert(dtConfig.Rows[0][ConfigName.I_LANGID.ToString()]);
            }
            catch { }
            clsLoginInfo.Culture = clsGlobal.I_LANGID;
            try
            {
                clsGlobal.D_WIDTHBTNGROUPITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_WIDTHBTNGROUPITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_WIDTHBTNITEMSET = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_WIDTHBTNITEMSET.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_HEIGHTBTNITEMSET = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_HEIGHTBTNITEMSET.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_HEIGHTBTNCHOICEITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_HEIGHTBTNCHOICEITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_WIDTHBTNCHOICEITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_WIDTHBTNCHOICEITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_HEIGHTBTNGROUPITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_HEIGHTBTNGROUPITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_WIDTHBTNITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_WIDTHBTNITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_HEIGHTBTNITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_HEIGHTBTNITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_TOPBTNGROUPITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_TOPBTNGROUPITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_LEFTBTNGROUPITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_LEFTBTNGROUPITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_TOPBTNITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_TOPBTNITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_LEFTBTNITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_LEFTBTNITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.S_BACKGROUNDBTNGROUPITEM1 = dtConfig.Rows[0][ConfigName.S_BACKGROUNDBTNGROUPITEM1.ToString()].ToString().Trim();
            }
            catch { }
            try
            {
                clsGlobal.S_BACKGROUNDBTNGROUPITEM2 = dtConfig.Rows[0][ConfigName.S_BACKGROUNDBTNGROUPITEM2.ToString()].ToString().Trim();
            }
            catch { }
            try
            {
                clsGlobal.S_BACKGROUNDBTNITEM = dtConfig.Rows[0][ConfigName.S_BACKGROUNDBTNITEM.ToString()].ToString().Trim();
            }
            catch { }
            try
            {
                clsGlobal.D_FONTSIZEBTNGROUPITEM1 = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_FONTSIZEBTNGROUPITEM1.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_FONTSIZEBTNGROUPITEM2 = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_FONTSIZEBTNGROUPITEM2.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_MARGINLEFTTABLE = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_MARGINLEFTTABLE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_MARGINTOPTABLE = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_MARGINTOPTABLE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_FONTSIZEBTNITEM = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_FONTSIZEBTNITEM.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USEVIRTUALBANK = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEVIRTUALBANK.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USEAUTOSTARTWITHWINDOW = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEAUTOSTARTWITHWINDOW.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_ITEMDETAIL = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_ITEMDETAIL.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_AREA = clsFormat.Int16ConvertNull(dtConfig.Rows[0][ConfigName.I_AREA.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_DELIVERY = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_DELIVERY.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_SAFEMODE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_SAFEMODE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_RETAIL_INPUTCANCELTICKET = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_RETAIL_INPUTCANCELTICKET.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.S_COLOREMPTYTABLE = dtConfig.Rows[0][ConfigName.S_COLOREMPTYTABLE.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_COLORCUSTABLE = dtConfig.Rows[0][ConfigName.S_COLORCUSTABLE.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_COLORTABLEMULTIBILL = dtConfig.Rows[0][ConfigName.S_COLORTABLEMULTIBILL.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_COLORTABLEPRINTED = dtConfig.Rows[0][ConfigName.S_COLORCUSTABLEPRINTED.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_COLORTABLEPPRINTMANY = dtConfig.Rows[0][ConfigName.S_COLORTABLEPPRINTMANY.ToString()].ToString();
            }
            catch { }
            //mau chu cho tung trang thai cua nhom
            try
            {
                clsGlobal.S_FORECOLORTABLEMULTIBILL = dtConfig.Rows[0][ConfigName.S_FORECOLORTABLEMULTIBILL.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_FORECOLOREMPTYTABLE = dtConfig.Rows[0][ConfigName.S_FORECOLOREMPTYTABLE.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_FORECOLORCUSTABLE = dtConfig.Rows[0][ConfigName.S_FORECOLORCUSTABLE.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_FORECOLORCUSTABLEPRINTED = dtConfig.Rows[0][ConfigName.S_FORECOLORCUSTABLEPRINTED.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.S_FORECOLORCUSPRINTMANY = dtConfig.Rows[0][ConfigName.S_FORECOLORCUSPRINTMANY.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.B_PRINTITEMAFTERORDER = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PRINTITEMAFTERORDER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USESHIFT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USESHIFT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_NUMBERSOFPRINTBILL = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_NUMBERSOFPRINTBILL.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_PRINTORDERAFTERSPLITTABLE = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PRINTORDERAFTERSPLITTABLE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_INPUTINFORCARD = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_INPUTINFORCARD.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_LEVELGROUP = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_LEVELGROUP.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_EXPORTSTOCKWHENCASHIEROUT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_EXPORTSTOCKWHENCASHIEROUT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_TIMELOCKSCREEN = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_TIMELOCKSCREEN.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USECOM3 = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USECOM3.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_USEDEPOSIT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_USEDEPOSIT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.S_TABLEDELIVERY = dtConfig.Rows[0][ConfigName.S_TABLEDELIVERY.ToString()].ToString();
            }
            catch { }
            try
            {
                clsGlobal.D_WIDTHNEWTABLE = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_WIDTHNEWTABLE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.D_LONGNEWTABLE = clsFormat.DoubleConvert(dtConfig.Rows[0][ConfigName.D_LONGNEWTABLE.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_PRINTTICKETVOID = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_PRINTTICKETVOID.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.I_NUMPRINTCOPYBILLFINISH = clsFormat.IntConvert(dtConfig.Rows[0][ConfigName.I_NUMPRINTCOPYBILLFINISH.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_OPENCASHDRAWERWHENCASHIERIN = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_OPENCASHDRAWERWHENCASHIERIN.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_OPENCASHDRAWERWHENCASHIEROUT = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_OPENCASHDRAWERWHENCASHIEROUT.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_OPENCASHDRAWERWHENAPPVOUCHER = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_OPENCASHDRAWERWHENAPPVOUCHER.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_OPENCASHDRAWERWHENCASH = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_OPENCASHDRAWERWHENCASH.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_SHOWFINISHBILLRES = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_SHOWFINISHBILLRES.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_SHOWPAYMENTRES = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_SHOWPAYMENTRES.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_SHOWPRINTANDFINISHRES = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_SHOWPRINTANDFINISHRES.ToString()]);
            }
            catch { }
            try
            {
                clsGlobal.B_EDITQTYAFTERORDERED = clsFormat.BooleanConvert(dtConfig.Rows[0][ConfigName.B_EDITQTYAFTERORDERED.ToString()]);
            }
            catch { }
        }

        public static string LinkSaveLayOutGrid(string filename)
        {
            if (!Directory.Exists(S_FOLDERLAYOUTGRID))
                System.IO.Directory.CreateDirectory(S_FOLDERLAYOUTGRID);
            return S_FOLDERLAYOUTGRID + "\\" + filename + ".xml";
        }

        public static void InitComportLCD()
        {
            ComPortLCD = new SerialPort();
            ComPortLCD.PortName = "COM" + clsGlobal.I_COMPORTNUMBER.ToString();
            ComPortLCD.BaudRate = clsGlobal.I_BAUDRATE;
            ComPortLCD.Parity = Parity.None;
            ComPortLCD.DataBits = 8;
            ComPortLCD.StopBits = StopBits.One;
            ComPortLCD.ReadBufferSize = 1024;
            ComPortLCD.Open();
            ComPortLCD.Write(new byte[] { 12 }, 0, 1);
            ComPortLCD.Write(clsMisc.RejectDiacritic(clsGlobal.S_LCDTITLE));
        }

        #endregion

        /// <summary>
        /// Định dạng hiển thị kiểu số tiền tệ
        /// </summary>
        public static string S_FORMATNUMBER = "#,###,###";

        /// <summary>
        /// Định dạng hiển thị kiểu số integer
        /// </summary>
        public static string S_FORMATINTEGER = "#,###,###";

        /// <summary>
        /// Định dạng hiển thị kiểu số ty gia
        /// </summary>
        public static string S_FORMATRATE = "#,###,###.###";

        /// <summary>
        /// Kí tự phân cách thập phân
        /// </summary>
        public static string S_DECIMALPOINT = ".";

        /// <summary>
        /// Kí tự phân cách phần nghìn của Số
        /// </summary>
        public static string S_SEPARATECHAR = ",";

        /// <summary>
        /// format kieu so cho don vi tinh
        /// </summary>
        public static string S_FORMATUOM = "0.#####"; //"#,###,###.#####";

        /// <summary>
        /// Định dạng hiển thị ngày
        /// </summary>
        public static string S_FORMATDATE = "dd/MM/yyyy";

        /// <summary>
        /// Định dạng hiển thị gio
        /// </summary>
        public static string S_FORMATTIME = "HH:mm:ss";

        /// <summary>
        /// Định dạng hiển thị ngày giờ
        /// </summary>
        public static string S_FORMATDATETIME = "dd/MM/yyyy HH:mm:ss";

        /// <summary>
        /// Định dạng hiển thị tháng
        /// </summary>
        public static string S_FORMATMONTHYEAR = "MM/yyyy";

        /// <summary>
        /// Màu bàn trống
        /// </summary>
        public static string S_COLOREMPTYTABLE = string.Empty;

        /// <summary>
        /// Màu bàn có khách
        /// </summary>
        public static string S_COLORCUSTABLE = string.Empty;

        /// <summary>
        /// IP của server
        /// </summary>
        public static string S_IPSERVERREMOTE = "192.168.183.5";

        /// <summary>
        /// port để kết nối vào server
        /// </summary>
        public static int I_SERVERPORTREMOTE = 8000;

        /// <summary>
        /// In order khi tách bàn
        /// </summary>
        public static bool B_PRINTORDERAFTERSPLITTABLE = false;

        /// <summary>
        /// Thời gian bắt đầu của ngày (để tính doanh thu)
        /// mặc định là 5 giờ sáng
        /// </summary>
        public static int I_STARTTIMEOFDAY = 5;

        /// <summary>
        /// Thời gian bắt đầu của ngày (để tính doanh thu)
        /// mặc định là 5 giờ sáng
        /// </summary>
        public static string S_STARTTIMEOFDAY = " 5:00:00";

        /// <summary>
        /// Cấp để load danh sách nhóm cha bên phần bán hàng (mặc định cấp 1 là load các nhóm con của nhóm hàng hóa)
        /// </summary>
        public static int I_LEVELGROUP = 1;

        /// <summary>
        /// Có thực hiện thao tác trừ kho khi ra ca hay không?
        /// </summary>
        public static bool B_EXPORTSTOCKWHENCASHIEROUT = true;

        /// <summary>
        /// Chiều rộng của bàn tạo mới tự động
        /// </summary>
        public static double D_WIDTHNEWTABLE = 85;

        /// <summary>
        /// Chiều cao của bàn tạo mới tự động
        /// </summary>
        public static double D_LONGNEWTABLE = 92;

        /// <summary>
        /// Comport của màn hình LCD
        /// </summary>
        public static SerialPort ComPortLCD;

        /// <summary>
        /// Có in phiếu trả hàng bán lẻ không
        /// </summary>
        public static bool B_PRINTTICKETVOID = true;
    }

    #region enum

    #region Report
    public enum KeyReport
    {
        [StringValue("rCASHIEROUT")]
        rCASHIEROUT,

        [StringValue("rAllRevenue")]
        rAllRevenue,

        [StringValue("rCOMPAREKITCHEN")]
        rCOMPAREKITCHEN,

        /// <summary>
        /// Hóa đơn
        /// </summary>
        [StringValue("rINVOICE")]
        rINVOICE,

        [StringValue("rORDER")]
        rORDER,

        [StringValue("rOVERALSALEREVENUE")]
        rOVERALSALEREVENUE,

        /// <summary>
        /// Phiếu chi
        /// </summary>
        [StringValue("rPAYMENT")]
        rPAYMENT,

        /// <summary>
        /// Phiếu thu
        /// </summary>
        [StringValue("rRECEIPT")]
        rRECEIPT,

        [StringValue("rSALEREVENUE")]
        rSALEREVENUE,

        [StringValue("rTICKET")]
        rTICKET,

        /// <summary>
        /// Bill tính tiền của bán lẻ
        /// </summary>
        [StringValue("rTICKETRETAIL")]
        rTICKETRETAIL,

        [StringValue("rVOIDITEM")]
        rVOIDITEM,

        /// <summary>
        /// Báo cáo danh sách phiếu
        /// </summary>
        [StringValue("rTICKETREPORT")]
        rTICKETREPORT,

        /// <summary>
        /// Danh sách khách nợ
        /// </summary>
        [StringValue("rDEPTLIST")]
        rDEPTLIST,

        /// <summary>
        /// Danh sách thao tác phiếu
        /// </summary>
        [StringValue("rHISTORYCHANGELIST")]
        rHISTORYCHANGELIST,

        /// <summary>
        /// Lịch sử đăng nhập
        /// </summary>
        [StringValue("rHISTORYLOGIN")]
        rHISTORYLOGIN,

        /// <summary>
        /// Danh sách vào, ra ca
        /// </summary>
        [StringValue("rOBJSHIFT")]
        rOBJSHIFT,

        /// <summary>
        /// Danh sách phiếu chi
        /// </summary>
        [StringValue("rPAYMENTLIST")]
        rPAYMENTLIST,

        /// <summary>
        /// Danh sách phiếu thu
        /// </summary>
        [StringValue("rRECEIPTLIST")]
        rRECEIPTLIST,

        /// <summary>
        /// Tin nhắn bếp
        /// </summary>
        [StringValue("rKITCHENMESSAGE")]
        rKITCHENMESSAGE,

        /// <summary>
        /// Phiếu in lại
        /// </summary>
        [StringValue("rREPRINT")]
        rREPRINT,

        /// <summary>
        /// Ghi chú chuyển ghép
        /// </summary>
        [StringValue("rTRANFERLINKNOTE")]
        rTRANFERLINKNOTE,

        /// <summary>
        /// Bao cáo chi tiết hàng
        /// </summary>
        [StringValue("rREVENUEITEMDETAIL")]
        rREVENUEITEMDETAIL,

        /// <summary>
        /// In order ngay tại quầy khi gửi order
        /// </summary>
        [StringValue("rPRINTITEMAFTERORDER")]
        rPRINTITEMAFTERORDER,

        /// <summary>
        /// Bản sao in xuống bếp
        /// </summary>
        [StringValue("rORDERCOPY")]
        rORDERCOPY,

        /// <summary>
        /// Danh sách các phiếu đã hóa đơn
        /// </summary>
        [StringValue("rINVOICELIST")]
        rINVOICELIST,

        /// <summary>
        /// Báo cáo doanh thu theo ca
        /// </summary>
        [StringValue("rREVENUESHIFT")]
        rREVENUESHIFT,

        /// <summary>
        /// Báo cáo doanh thu theo ngày
        /// </summary>
        [StringValue("rREVENUEDAY")]
        rREVENUEDAY,

        /// <summary>
        /// Doanh thu cho thức ăn và thức uống
        /// </summary>
        [StringValue("rTICKETFOODANDDRINK")]
        rTICKETFOODANDDRINK,

        /// <summary>
        /// Khuyến mãi giảm giá 
        /// </summary>
        [StringValue("rPROMOTION")]
        rPROMOTION,

        /// <summary>
        /// Khuyến mãi theo năm tháng ngày (thời gian)
        /// </summary>
        [StringValue("rPROMOTIONBYYEARMONTHDAY")]
        rPROMOTIONBYYEARMONTHDAY,

        /// <summary>
        /// Doanh số mặt hàng
        /// </summary>
        [StringValue("rSALEITEM")]
        rSALEITEM,

        /// <summary>
        /// Doanh số phiếu theo ngày giờ
        /// </summary>
        [StringValue("rREVENUEBILLFORDATETIME")]
        rREVENUEBILLFORDATETIME,

        /// <summary>
        /// Thống kê theo chính sách giảm giá
        /// </summary>
        [StringValue("rDISCOUNTTYPE")]
        rDISCOUNTTYPE,

        /// <summary>
        /// Thống kê theo giảm giá thẻ VIP
        /// </summary>
        [StringValue("rVIPPROMOTION")]
        rVIPPROMOTION,

        /// <summary>
        /// Thống kê doanh số bán hàng theo khách hàng
        /// </summary>
        [StringValue("rCUSTOMERSALESREPORT")]
        rCUSTOMER,

        /// <summary>
        /// Thống kê danh sách voucher khách hàng
        /// </summary>
        [StringValue("rVOUCHERLIST")]
        rVOUCHERLIST,

        /// <summary>
        /// danh sách hàng trả lại
        /// </summary>
        [StringValue("rVOIDITEMDETAIL")]
        rVOIDITEMDETAIL,

        /// <summary>
        /// danh sách hàng trả lại
        /// </summary>
        [StringValue("rGENERAL")]
        rGENERAL,

        /// <summary>
        /// danh sách hàng trả lại
        /// </summary>
        [StringValue("rWARNINGABOUTCUSTOMER")]
        rWARNINGABOUTCUSTOMER,

        /// <summary>
        /// danh sách hàng trả lại
        /// </summary>
        [StringValue("rLEGACYCUSTOMERSALE")]
        rLEGACYCUSTOMERSALE,

        /// <summary>
        /// danh sách hàng trả lại
        /// </summary>
        [StringValue("rSLOWSALELIST")]
        rSLOWSALELIST,

        /// <summary>
        /// bao cao hang ban theo nhom hang
        /// </summary>
        [StringValue("rREVENUEITEMGROUP")]
        rREVENUEITEMGROUP,

        /// <summary>
        /// bao cao hang ban theo mat hang
        /// theo nhom rREVENUEITEMGROUP
        /// </summary>
        [StringValue("rREVENUEITEMGROUPDETAIL")]
        rREVENUEITEMGROUPDETAIL,

        /// <summary>
        /// Bill trả hàng của bán lẻ
        /// </summary>
        [StringValue("rTICKETVOIDRETAIL")]
        rTICKETVOIDRETAIL,

        /// <summary>
        /// Hóa đơn in chi tiết
        /// </summary>
        [StringValue("rINVOICEPRINTDETAIL")]
        rINVOICEPRINTDETAIL,

        /// <summary>
        /// Hóa đơn in không chi tiết
        /// </summary>
        [StringValue("rINVOICENOTPRINTDETAIL")]
        rINVOICENOTPRINTDETAIL
    }

    /// <summary>
    /// Phần hệ báo cáo nằm trong bảng RESREPORTS
    /// </summary>
    public enum ReportModule
    {
        /// <summary>
        /// General
        /// </summary>
        [StringValue("GEN")]
        GEN,

        [StringValue("RECEIVE")]
        RECEIVE,
    }

    /// <summary>
    /// Nhóm bao cáo nằm trong bảng RESREPORTS
    /// </summary>
    public enum ReportGroup
    {
        [StringValue("SALE")]
        SALE,

        /// <summary>
        /// 
        /// </summary>
        [StringValue("US")]
        US,
    }

    #endregion

    /// <summary>
    /// Loại thu
    /// </summary>
    public enum TypePayInOut
    {
        [StringValue("Thu khác")]
        TK,
        [StringValue("Thu khách nợ")]
        TKN,
        [StringValue("Thu đặt cọc")]
        TDC,
        [StringValue("Chi khác")]
        CK,
    }

    /// <summary>
    /// Loại nhom
    /// </summary>
    public enum TypeGroup
    {
        [StringValue("Thức ăn")]
        TA = 0,
        [StringValue("Thức uống")]
        TU = 1,
        [StringValue("Loại khác")]
        LK = 2
    }

    /// <summary>
    /// Loại tài liệu trong bảng RESDOCUMENT
    /// </summary>
    public enum TypeDocument
    {
        /// <summary>
        /// Receipt : thu khác
        /// </summary>
        [StringValue("TK")]
        TK,

        /// <summary>
        /// Payment : chi khác
        /// </summary>
        [StringValue("CK")]
        CK,

        /// <summary>
        /// Customer Debt: thu Khách nợ
        /// </summary>
        [StringValue("TKN")]
        TKN,
    }

    /// <summary>
    /// Trạng thái phiếu bán hàng
    /// </summary>
    public enum TicketStatus
    {
        /// <summary>
        /// tat ca cac phieu
        /// </summary>
        /// <summary>
        /// Đã hủy
        /// </summary>
        Canceled = 1,

        /// <summary>
        /// Chưa thanh toán
        /// </summary>
        NotPayment = 5,

        /// <summary>
        /// Đã thanh toán
        /// </summary>
        Paid = 3,

        /// <summary>
        /// Đang giữ
        /// </summary>
        Hold = 6,

        /// <summary>
        /// Tặng
        /// </summary>
        Guest = 2,

        /// <summary>
        /// Tiền thiếu
        /// </summary>
        MoneyMissing = 4,
    }

    /// <summary>
    /// Loại hình kinh doanh
    /// </summary>
    public enum BusinessType
    {
        Restaurant = 1,
        Retail = 2,
        Karaoke = 3,
        Internet = 4,
        Cafe = 5,
        Bar = 6,
        Bida = 7
    }

    /// <summary>
    /// Loại phiếu
    /// </summary>
    public enum TicketType
    {
        Restaurant = 0,
        Retail = 1
    }

    /// <summary>
    /// Trạng thái mặt hàng
    /// </summary>
    public enum StatusOrder : short
    {
        /// <summary>
        /// Mua
        /// </summary>
        Order = 0,

        /// <summary>
        /// Trả lại
        /// </summary>
        Void = 1
    }

    /// <summary>
    /// Loại thẻ bên bảng RESPROMOCARD
    /// </summary>
    public enum CardType
    {
        VIP = 1,
        Gift = 2,
        Buffet = 3,
        Customer = 4
    }

    #region Config
    /// <summary>
    /// Nhóm cấu hình
    /// </summary>
    public enum ConfigGroup
    {
        [StringValue("OR")]
        ORDER,
        [StringValue("POC")]
        POCKET,
        [StringValue("PRINT")]
        PRINT,
        [StringValue("DIS")]
        DISPLAY,
        [StringValue("GE")]
        GENERAL,
        [StringValue("CA")]
        CARD,
        [StringValue("HA")]
        HARDWARE
    }

    public enum ConfigName
    {
        /// <summary>
        /// Phân hệ
        /// </summary>
        H_MODULE,

        /// <summary>
        /// Liên kết web
        /// </summary>
        S_LINKWEB,

        /// <summary>
        /// Loại hình KD
        /// </summary>
        I_BUSINESSTYPE,

        /// <summary>
        /// Sử dụng màn hình 2
        /// </summary>
        B_USEEXTENDDISPLAY,

        /// <summary>
        /// Chi nhánh
        /// </summary>
        I_ORG_AUTOID,

        /// <summary>
        /// Sử dụng sơ đồ bàn
        /// </summary>
        B_USETABLEMAP,

        /// <summary>
        /// Sử dụng thẻ từ
        /// </summary>
        B_USEMAGNETICCARD,

        /// <summary>
        /// Giao hàng
        /// </summary>
        B_DELIVERY,

        /// <summary>
        /// Kí tự đầu thẻ nhân viên
        /// </summary>
        S_FIRSTCHAROFSTAFFCARD,

        /// <summary>
        /// Số dòng thẻ nhân viên
        /// </summary>
        I_NUMBERROWSTAFFCARD,

        /// <summary>
        /// Kí tự đầu thẻ VIP
        /// </summary>
        S_FRISTCHARMAGCARDVIP,

        /// <summary>
        /// Số dòng thẻ VIP
        /// </summary>
        I_NUMBERROWMAGCARDVIP,

        /// <summary>
        /// Kí tự phân cách thẻ từ
        /// </summary>
        S_CHARSEPARATEMAGCARD,

        /// <summary>
        /// Cảnh báo hết hàng
        /// </summary>
        B_USEALERTEMPTYITEM,

        /// <summary>
        /// Sử dụng cân
        /// </summary>
        B_USEELECTRONICBALANCE,

        /// <summary>
        /// Cổng COM EPB
        /// </summary>
        I_EPBCOMPORT,

        /// <summary>
        /// Cổng EPB
        /// </summary>
        I_EPB_PORT,

        /// <summary>
        /// Tốc độ thay đổi trạng thái EBP
        /// </summary>
        I_EBP_BAUDRATE,

        /// <summary>
        /// Sử dụng LCD
        /// </summary>
        B_USERLCDCOMPORT,

        /// <summary>
        /// Chiều dài LCD
        /// </summary>
        I_LCDLEN,

        /// <summary>
        /// Khoảng cách
        /// </summary>
        I_DISTANCE,

        /// <summary>
        /// Số cổng COM
        /// </summary>
        I_COMPORTNUMBER,

        /// <summary>
        /// Tốc độ thay đổi trạng thái
        /// </summary>
        I_BAUDRATE,

        /// <summary>
        /// Tiều đề LCD
        /// </summary>
        S_LCDTITLE,

        /// <summary>
        /// Khách hàng
        /// </summary>
        S_CUSTOMER,

        /// <summary>
        /// Địa chỉ
        /// </summary>
        S_ADDRESS,

        /// <summary>
        /// Điện thoại
        /// </summary>
        S_PHONE,

        /// <summary>
        /// Fax
        /// </summary>
        S_FAX,

        /// <summary>
        /// Thư điện tử
        /// </summary>
        S_EMAIL,

        /// <summary>
        /// Mã số thuế
        /// </summary>
        S_TAXID,

        /// <summary>
        /// Sử dụng POCKET
        /// </summary>
        B_USEPOCKET,

        /// <summary>
        /// VAT mặc định
        /// </summary>
        B_VATDEFAULT,

        /// <summary>
        /// VAT
        /// </summary>
        I_VAT,

        /// <summary>
        /// % phí dịch vụ
        /// </summary>
        I_SERVICEPER,

        /// <summary>
        /// Máy in két tiền
        /// </summary>
        S_PRINTERDRAWERNAME,

        /// <summary>
        /// Máy in bill
        /// </summary>
        S_PRINTERBILLNAME,

        /// <summary>
        /// In phiếu xuống bếp
        /// </summary>
        B_PRINTTICKETTOKITCHEN,

        /// <summary>
        /// Thời gian in POCKET
        /// </summary>
        I_PRINTPOCKETTIME,

        /// <summary>
        /// Quầy
        /// </summary>
        I_COUNTER,

        /// <summary>
        /// Sử dụng order mặc định
        /// </summary>
        B_USEORDERDEFAULT,

        /// <summary>
        /// VAT
        /// </summary>
        B_ISVAT,

        /// <summary>
        /// in hóa đơn kèm theo bill
        /// </summary>
        B_PRINTINVOICEFORBILL,

        /// <summary>
        /// Màn hình bán hàng mở rộng
        /// </summary>
        B_ISZOOM,

        /// <summary>
        /// Loại tiền
        /// </summary>
        I_CURRENCY,

        /// <summary>
        /// Sử dụng thông báo
        /// </summary>
        B_ISMESSAGE,

        /// <summary>
        /// Sử dụng thông báo
        /// </summary>
        B_MULTIBILLINTALBE,

        /// <summary>
        /// Chế độ an toàn
        /// </summary>
        B_ISSAFE,

        /// <summary>
        /// Ngôn ngữ
        /// </summary>
        I_LANGID,

        /// <summary>
        /// Nhập thông tin hủy phiếu (Bán lẻ)
        /// </summary>
        B_RETAIL_INPUTCANCELTICKET,

        /// <summary>
        /// Tạm thoát
        /// </summary>
        B_RETAIL_SAFEMODE,

        /// <summary>
        /// Chiều rộng nhóm hàng
        /// </summary>
        D_WIDTHBTNGROUPITEM,

        /// <summary>
        /// Chiều cao nhóm hàng
        /// </summary>
        D_HEIGHTBTNGROUPITEM,

        /// <summary>
        /// Chiều rộng choice
        /// </summary>
        D_WIDTHBTNCHOICEITEM,

        /// <summary>
        /// Chiều cao choice
        /// </summary>
        D_HEIGHTBTNCHOICEITEM,

        /// <summary>
        /// Chiều cao Set
        /// </summary>
        D_HEIGHTBTNITEMSET,

        /// <summary>
        /// Chiều rộng set
        /// </summary>
        D_WIDTHBTNITEMSET,

        /// <summary>
        /// Chiều rộng mặt hàng
        /// </summary>
        D_WIDTHBTNITEM,

        /// <summary>
        /// Chiều cao mặt hàng
        /// </summary>
        D_HEIGHTBTNITEM,

        /// <summary>
        /// Khoảng cách trên nhóm
        /// </summary>
        D_TOPBTNGROUPITEM,

        /// <summary>
        /// Khoảng cách trái nhóm
        /// </summary>
        D_LEFTBTNGROUPITEM,

        /// <summary>
        /// Khoảng cách trên mặt hàng
        /// </summary>
        D_TOPBTNITEM,

        /// <summary>
        /// Khoảng cách trái mặt hàng
        /// </summary>
        D_LEFTBTNITEM,

        /// <summary>
        /// Màu nền nhóm 1
        /// </summary>
        S_BACKGROUNDBTNGROUPITEM1,

        /// <summary>
        /// Màu nền nhóm 2
        /// </summary>
        S_BACKGROUNDBTNGROUPITEM2,

        /// <summary>
        /// Màu nền mặt hàng
        /// </summary>
        S_BACKGROUNDBTNITEM,

        /// <summary>
        /// Kích thước font nhóm 1
        /// </summary>
        D_FONTSIZEBTNGROUPITEM1,

        /// <summary>
        /// Kích thước font nhóm 2
        /// </summary>
        D_FONTSIZEBTNGROUPITEM2,

        /// <summary>
        /// Kích thước font mặt hàng
        /// </summary>
        D_FONTSIZEBTNITEM,

        /// <summary>
        /// Khoảng cách trái của bàn
        /// </summary>
        D_MARGINLEFTTABLE,

        /// <summary>
        /// Khoảng cách trên của bàn
        /// </summary>
        D_MARGINTOPTABLE,

        /// <summary>
        /// Khởi động cùng window
        /// </summary>
        B_USEAUTOSTARTWITHWINDOW,

        /// <summary>
        /// Sử dụng ngân hàng ảo
        /// </summary>
        B_USEVIRTUALBANK,

        I_POSID,

        /// <summary>
        /// Hiển thị hình mặt hàng
        /// </summary>
        B_USEIMAGEITEM,

        /// <summary>
        /// Hiển thị mã hàng
        /// </summary>
        B_USEITEMNO,

        /// <summary>
        /// Hiển thị mã nhóm
        /// </summary>
        B_USEGROUPNO,

        /// <summary>
        /// Màu chữ nhóm 1
        /// </summary>
        S_FONTCOLORGROUP1,

        /// <summary>
        /// Màu chữ nhóm 2
        /// </summary>
        S_FONTCOLORGROUP2,

        /// <summary>
        /// Màu chữ mặt hàng
        /// </summary>
        S_FONTCOLORITEM,

        /// <summary>
        /// Font chữ
        /// </summary>
        S_FONTFAMILY,

        /// <summary>
        /// Cách hiển thị mặt hàng(ngang hay dọc)
        /// </summary>
        I_SHOWMETHOD,

        /// <summary>
        /// Sử dụng chi tiết hàng
        /// </summary>
        B_ITEMDETAIL,

        /// <summary>
        /// Khu
        /// </summary>
        I_AREA,

        /// <summary>
        /// Màu bàn trống
        /// </summary>
        S_COLOREMPTYTABLE,

        /// <summary>
        /// Màu bàn có khách
        /// </summary>
        S_COLORCUSTABLE,

        /// <summary>
        /// Màu bàn đã in
        /// </summary>
        S_COLORCUSTABLEPRINTED,

        /// <summary>
        /// Màu bàn in nhiều lần
        /// </summary>
        S_COLORTABLEPPRINTMANY,

        /// <summary>
        /// Màu bàn có nhiều bill
        /// </summary>
        S_COLORTABLEMULTIBILL,

        /// <summary>
        /// Màu chữ bàn trống
        /// </summary>
        S_FORECOLOREMPTYTABLE,

        /// <summary>
        /// Màu chữ bàn có khách
        /// </summary>
        S_FORECOLORCUSTABLE,

        /// <summary>
        /// Màu chữ bàn nhiều phiếu
        /// </summary>
        S_FORECOLORTABLEMULTIBILL,

        /// <summary>
        /// Màu chữ bàn in nhiều lần
        /// </summary>
        S_FORECOLORCUSPRINTMANY,

        /// <summary>
        /// Màu chữ bàn đã in
        /// </summary>
        S_FORECOLORCUSTABLEPRINTED,

        /// <summary>
        /// Màu chữ tên khách trên bàn
        /// </summary>
        S_FORECOLORCUSTOMER,

        /// <summary>
        /// Màu chữ thời gian order trên bàn
        /// </summary>
        S_FORECOLORTIMEORDER,

        /// <summary>
        /// Màu chữ tổng tiền trên bàn
        /// </summary>
        S_FORECOLORAMOUNT,

        /// <summary>
        /// port để kết nối vào server
        /// </summary>
        I_SERVERPORTREMOTE,

        /// <summary>
        /// IP của server
        /// </summary>
        S_IPSERVERREMOTE,

        /// <summary>
        /// Nhà hàng
        /// </summary>
        B_RESTAURANT,

        /// <summary>
        /// bán lẻ
        /// </summary>
        B_RETAIL,

        /// <summary>
        /// karaoke
        /// </summary>
        B_KARAOKE,

        /// <summary>
        /// internet
        /// </summary>
        B_INTERNET,

        /// <summary>
        /// cafe
        /// </summary>
        B_CAFE,

        /// <summary>
        /// bar
        /// </summary>
        B_BAR,

        /// <summary>
        /// bida
        /// </summary>
        B_BIDA,

        /// <summary>
        /// chi khác
        /// </summary>
        B_PAYOUT,

        /// <summary>
        /// thu khác
        /// </summary>
        B_PAYIN,

        /// <summary>
        /// quản lý bếp
        /// </summary>
        B_MANAGEKITCHEN,

        /// <summary>
        /// In hóa đơn VAT
        /// </summary>
        B_PRINTINVOICE,

        /// <summary>
        /// Thời gian check kết nối với Server
        /// </summary>
        I_TIMECHECKCONNSERVER,

        /// <summary>
        /// Vào bàn tự động
        /// </summary>
        B_AUTODINEIN,

        /// <summary>
        /// Hủy phiếu nếu không order
        /// </summary>
        B_CANCELIFNOTORDER,

        /// <summary>
        /// Nhập thông tin order
        /// </summary>
        B_INPUTINFORORDER,

        /// <summary>
        /// Thanh toán ngay
        /// </summary>
        B_QUICKPAY,

        /// <summary>
        /// Thanh toán nhanh (Bán lẻ)
        /// </summary>
        B_RETAIL_QUICKPAY,

        /// <summary>
        /// Tạo thông tin khách hàng (Bán lẻ)
        /// </summary>
        B_RETAIL_CREATECUSTOMER,

        /// <summary>
        /// Nhập thông tin trả hàng (Bán lẻ)
        /// </summary>
        B_RETAIL_INPUTINFOREASOMVOIDITEM,

        /// <summary>
        /// Ưu tiên thanh toán thẻ
        /// </summary>
        B_QUICKPAYPRIORITY,

        /// <summary>
        /// In tạm tính
        /// </summary>
        B_PRINTTEMP,

        /// <summary>
        /// Số lần in tạm tính
        /// </summary>
        I_NUMBERSOFPRINTTEMP,

        /// <summary>
        /// Chuyển bàn
        /// </summary>
        B_TRANFERTABLE,

        /// <summary>
        /// Ghép phiếu
        /// </summary>
        B_LINKBILL,

        /// <summary>
        /// Nhóm phiếu
        /// </summary>
        B_GROUPBILL,

        /// <summary>
        /// Tách phiếu
        /// </summary>
        B_SEPERATEBILL,

        /// <summary>
        /// Sử dụng tiếp khách
        /// </summary>
        B_RECEPTION,

        /// <summary>
        /// Sử dụng tiền Boa
        /// </summary>
        B_TIP,

        /// <summary>
        /// Cách hiển thị bàn
        /// </summary>
        I_VIEWTYPETABLE,

        /// <summary>
        /// Sửa giá 
        /// </summary>
        B_RETAIL_EDITPRICE,

        /// <summary>
        /// Thẻ khách hàng
        /// </summary>
        B_RETAIL_CUSTOMERCARD,

        /// <summary>
        /// Thông tin khách hàng
        /// </summary>
        B_RETAIL_CUSTOMER,

        /// <summary>
        /// Giảm giá
        /// </summary>
        B_RETAIL_DISCOUNT,

        /// <summary>
        /// Thanh Toán Thẻ
        /// </summary>
        B_RETAIL_PAYMENTCARD,

        /// <summary>
        /// Thanh toán
        /// </summary>
        B_PAYMENT,

        /// <summary>
        /// Sử dụng Vipcard
        /// </summary>
        B_VIPCARD,

        /// <summary>
        /// Sử dụng Voucher
        /// </summary>
        B_VOUCHER,

        /// <summary>
        /// Sử dụng Coupon
        /// </summary>
        B_COUPON,

        /// <summary>
        /// Sử dụng Gift
        /// </summary>
        B_TICKETGIFT,

        /// <summary>
        /// Chuỗi kết nối VipCard
        /// </summary>
        S_CONNECTIONSTRINGFORVIPCARD,

        /// <summary>
        /// Âm thanh bếp
        /// </summary>
        S_SOUNDKITCHEN,

        /// <summary>
        /// Âm thanh nhắc nhở
        /// </summary>
        S_REMINDKITCHEN,

        /// <summary>
        /// Khoảng thời gian chờ tăng tiền giờ Karaoke
        /// </summary>
        I_TIMEWAITFORKARAOKE,

        /// <summary>
        /// Thời gian nhắc hàng mới
        /// </summary>
        I_TIMEALERTNEWITEM,

        /// <summary>
        /// Thời gian nhắc hàng trễ
        /// </summary>
        I_TIMEALERTLATEITEM,

        /// <summary>
        /// Số bản in phiếu tính tiền
        /// </summary>
        I_NUMBERSOFPRINTBILL,

        /// <summary>
        /// Sử dụng giao ca
        /// </summary>
        B_USESHIFT,

        /// <summary>
        /// In hàng bán khi gửi order
        /// </summary>
        B_PRINTITEMAFTERORDER,

        /// <summary>
        /// In order khi tách bàn
        /// </summary>
        B_PRINTORDERAFTERSPLITTABLE,

        /// <summary>
        /// Nhập thông tin thẻ khi thanh toán bằng thẻ
        /// </summary>
        B_INPUTINFORCARD,

        /// <summary>
        /// Cấp để load danh sách nhóm cha
        /// </summary>
        I_LEVELGROUP,

        /// <summary>
        /// Có thực hiện thao tác trừ kho khi ra ca hay không?
        /// </summary>
        B_EXPORTSTOCKWHENCASHIEROUT,

        /// <summary>
        /// Thời gian khóa màn hình
        /// </summary>
        I_TIMELOCKSCREEN,

        /// <summary>
        /// Sử dụng COM khác
        /// </summary>
        B_USECOM3,

        /// <summary>
        /// Sử dụng Đặt cọc
        /// </summary>
        B_USEDEPOSIT,

        /// <summary>
        /// Mã bàn giao hàng
        /// </summary>
        S_TABLEDELIVERY,

        /// <summary>
        /// Chiều rộng của bàn tạo mới tự động
        /// </summary>
        D_WIDTHNEWTABLE,

        /// <summary>
        /// Chiều cao của bàn tạo mới tự động
        /// </summary>
        D_LONGNEWTABLE,

        /// <summary>
        /// In phiếu trả hàng
        /// </summary>
        B_PRINTTICKETVOID,

        /// <summary>
        /// Số bản in bill khi kết thúc phiếu
        /// </summary>
        I_NUMPRINTCOPYBILLFINISH,

         /// <summary>
        /// Mở két tiền khi vào ca
        /// </summary>
        B_OPENCASHDRAWERWHENCASHIERIN,

        /// <summary>
        /// Mở két tiền khi ra ca
        /// </summary>
        B_OPENCASHDRAWERWHENCASHIEROUT,

        /// <summary>
        /// Mở két tiền khi áp dụng voucher
        /// </summary>
        B_OPENCASHDRAWERWHENAPPVOUCHER,

        /// <summary>
        /// Mở két tiền khi trả tiền mặt
        /// </summary>
        B_OPENCASHDRAWERWHENCASH,

        /// <summary>
        /// Hiện nút kết thúc phiếu nhà hàng
        /// </summary>
        B_SHOWFINISHBILLRES,

        /// <summary>
        /// Hiện nút thanh toán nhà hàng
        /// </summary>
        B_SHOWPAYMENTRES,

        /// <summary>
        /// Hiện nút in và kết thúc nhà hàng
        /// </summary>
        B_SHOWPRINTANDFINISHRES,

        /// <summary>
        /// Hiện nút "sửa số lượng" sau khi đã mặt hàng đó đã order
        /// </summary>
        B_EDITQTYAFTERORDERED
    }

    public enum ShowMethod
    {
        [StringValue("1")]
        Column = 1,
        [StringValue("2")]
        Row = 2,
    }

    public enum ViewTypeTable
    {
        [StringValue("0")]
        Horizontal = 0,
        [StringValue("1")]
        Vertical = 1,
    }

    public enum ConfigDataType
    {
        text = 1,
        number = 2,
        bit = 3,
        color = 4,
        lstorg = 5,
        lstBusiness = 6,
        lstCounter = 7,
        lstCurrency = 8,
        lstLang = 9,
        lstShowMethod = 10
    }
    #endregion

    /// <summary>
    /// Các hình thức áp dụng giảm giá trong bảng RESDISCOUNTAPP
    /// </summary>
    public enum DiscountApp : byte
    {
        /// <summary>
        /// Hàng bán
        /// </summary>
        ITEM = 1,

        /// <summary>
        /// Phiếu bán hàng
        /// </summary>
        TICKET = 2,

        /// <summary>
        /// Số lượng bán
        /// </summary>
        QTY = 3,

        /// <summary>
        /// Số lượng hàng tồn kho
        /// </summary>
        STOCK = 4,

        /// <summary>
        /// Khách hàng
        /// </summary>
        CUSTOMER = 5,

        /// <summary>
        /// Tiền giờ
        /// </summary>
        HOUR = 6
    }

    /// <summary>
    /// Loại barcode hệ thống sử dụng
    /// </summary>
    public enum TypeBarCode : byte
    {
        /// <summary>
        /// Nhà sản xuất
        /// </summary>
        MANU = 0,

        /// <summary>
        /// Có số lượng
        /// </summary>
        QUANTITY = 1,

        /// <summary>
        /// Có thuộc tính
        /// </summary>
        ATDIMENSION = 2,

        /// <summary>
        /// Có ICSTOCK AUTOID của kho
        /// </summary>
        STOCK = 3,

        /// <summary>
        /// BarCode có đơn vị tính
        /// </summary>
        UOM = 4,
    }

    public enum TypeActionTicket
    {
        [StringValue("Áp dụng chính sách Giảm giá")]
        APPCS,

        [StringValue("Áp dụng chính sách thẻ vip")]
        APPVIPCARD,

        [StringValue("Áp dụng thẻ Voucher")]
        APVOUCHER,

        [StringValue("Chuyển bàn")]
        CB,

        [StringValue("Nhóm phiếu")]
        GB,

        [StringValue("Ngừng chuyển bàn")]
        NCB,

        [StringValue("Ngừng ghép bàn")]
        NGB,

        [StringValue("Giảm giá")]
        GG,

        [StringValue("Gọi lại phiếu")]
        GLP,

        [StringValue("Giữ phiếu")]
        GP,

        [StringValue("Hủy Phiếu")]
        HP,

        [StringValue("Kết thúc")]
        KT,

        [StringValue("In")]
        LI,

        [StringValue("Phiếu tặng")]
        PT,

        [StringValue("Sửa Giá")]
        SG,

        [StringValue("Sửa thông tin KH")]
        STTKH,

        [StringValue("Tạo")]
        TA,

        [StringValue("Tách bàn")]
        TB,

        [StringValue("Thay đổi hình thức thanh toán")]
        TDHTTT,

        [StringValue("Trả hàng")]
        TH,

        [StringValue("Tiền boa")]
        TIP,

        [StringValue("Thêm món")]
        TM,

        [StringValue("Thanh Toán")]
        TT,

        [StringValue("Thẻ VIP")]
        TV,

        [StringValue("Xóa chi tiết thanh toán")]
        XCHTT,

        [StringValue("Xóa thông tin Vip Card")]
        XOAVIPCARD,

        [StringValue("Xóa thông tin khách hàng")]
        XTTKH,

        [StringValue("Tách phiếu")]
        TP,

        [StringValue("Ghép phiếu")]
        GHP,

        [StringValue("Ngừng tách phiếu")]
        NTP,

        [StringValue("Ngừng ghép phiếu")]
        NGHP,

        [StringValue("Hủy nhóm phiếu")]
        HGB
    }

    public enum SendSocket
    {
        /// <summary>
        /// Client ket noi den server
        /// </summary>
        CONN,

        /// <summary>
        /// Server tra loi den client ket noi thanh cong
        /// </summary>
        ACCEPT,

        /// <summary>
        /// Tin nhắn mới tu client -> client khac
        /// </summary>
        MSG,

        /// <summary>
        /// Có thay đổi sơ đồ bàn
        /// </summary>
        SDB,

        /// <summary>
        /// May tram thoat chuong trinh
        /// </summary>
        EXIT,

        /// <summary>
        /// Annoucement : Co Thông báo tu he thong goi den cac may tram
        /// </summary>
        ANN,

        /// <summary>
        /// Truyền số liệu
        /// </summary>
        TRANFER,

        /// <summary>
        /// Dich vu tren Server đã dừng
        /// </summary>
        SERVERSTOP
    }

    /// <summary>
    /// Loại thông báo
    /// </summary>
    public enum TypeMess
    {
        /// <summary>
        /// RESANNOUNCEMENT
        /// </summary>
        Announcement,

        /// <summary>
        /// RESMESSAGE
        /// </summary>
        Message
    }

    public enum ItemStatus : int
    {
        /// <summary>
        /// Chưa làm
        /// </summary>
        [StringValue("NOTMAKING")]
        NOTMAKING = 0,

        /// <summary>
        /// Đang làm
        /// </summary>
        [StringValue("MAKING")]
        MAKING = 1,

        /// <summary>
        /// Xong
        /// </summary>
        [StringValue("FINISH")]
        FINISH = 2,

        /// <summary>
        /// Trả hàng
        /// </summary>
        [StringValue("VOID")]
        VOID = 3,

        /// <summary>
        /// Không xử lý
        /// </summary>
        [StringValue("KXL")]
        KXL = 4,

        /// <summary>
        /// Hết hàng
        /// </summary>
        [StringValue("SOLDOUT")]
        SOLDOUT = 5,

        /// <summary>
        /// Trễ
        /// </summary>
        [StringValue("LATE")]
        LATE = 6,
    }

    /// <summary>
    /// Trạng thái của phiếu order
    /// </summary>
    public enum StatusBillOrder : int
    {
        /// <summary>
        /// Chưa gửi
        /// </summary>
        NotSend = 0,

        /// <summary>
        /// Đã gửi
        /// </summary>
        Sended = 1,

        /// <summary>
        /// Đã hủy
        /// </summary>
        Canceled = 2
    }

    /// <summary>
    /// Trạng thái lưu lỗi
    /// </summary>
    public enum StatusSaveError
    {
        /// <summary>
        /// Chưa lưu được
        /// </summary>
        None,

        /// <summary>
        /// Đã ghi vào sql 
        /// </summary>
        Sql,

        /// <summary>
        /// Ghi vào file
        /// </summary>
        File
    }

    /// <summary>
    /// Loại treeview để hiển thị trên giao diện bán hàng
    /// </summary>
    public enum TypeTreeView
    {
        /// <summary>
        /// Nhóm hàng
        /// </summary>
        ItemGroup,

        /// <summary>
        /// Nhóm khách hàng
        /// </summary>
        CustomerGroup,

        /// <summary>
        /// Khu
        /// </summary>
        Area
    }
    #endregion
}