using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace vnyi.Utility
{
    public static class ClsPublic
    {
        /// <summary>
        /// Uploads the file to Server (Hosting/FileUpload)
        /// Create by: Pham Tuan Anh
        /// Create  date: 2009-05-08
        /// </summary>
        /// <param name="filename">String filename</param>
        /// <returns>
        ///     <value>
        ///         1 : Upload sucessfull
        ///         -1: Upload Fail (Can not folder: "FileUpload" on server or can not file to upload or Network problem)
        ///         -2: The file size more than 4 MB
        ///     </value>
        /// </returns>
        public static int UploadFile(string FolderName, string filename)
        {
            try
            {
                String strFile = System.IO.Path.GetFileName(filename);
                FileInfo fInfo = new FileInfo(filename);
                long numBytes = fInfo.Length;
                double dLen = Convert.ToDouble(fInfo.Length / 1000000);
                // Default limit of 4 MB on web server              
                if (dLen < 4)
                {
                    FileStream fStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);
                    byte[] data = br.ReadBytes((int)numBytes);
                    br.Close();
                    try
                    {
                        string thisDir = System.Web.Hosting.HostingEnvironment.MapPath(String.Format("~/{0}", FolderName));
                        if (!System.IO.Directory.Exists(thisDir))
                            System.IO.Directory.CreateDirectory(thisDir);
                        MemoryStream ms = new MemoryStream(data);
                        FileStream fs = new FileStream(String.Format("{0}/{1}", thisDir, strFile), FileMode.Create);
                        ms.WriteTo(fs);
                        ms.Close();
                        fs.Close();
                        fs.Dispose();
                        return 1;
                    }
                    catch (Exception)
                    {
                        return -1;
                    }
                    finally
                    {
                        fStream.Close();
                        fStream.Dispose();
                    }
                }
                else
                {
                    return -2;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
    /*
        New = 1,//1 Document's status is New
        Approved,//2 Document's status is Approved
        NotApproved,//3 Document's status is NotApproved
        FeedBack,//4 Document's status is FeedBack
        CustomerApproved,//5 Document's status is CustomerApproved
        CustomerNotApproved,//6 Document's status is CustomerNotApproved
        CreatedPO,//7 Document Request PO's status is CreatedPO
        CreatedSO,//8 Document Request SO's status is CreatedSO
        Completed,//9 Document's status is Completed
        Closed,//10 Document's status Closed  
     * */
    public enum Status : int
    {
        //Remember to add more Status: Please add at lastest enum
        Draft = 31,//1 Document's status is New
        [StringValue("New")]//"white"
        New = 1,//1 Document's status is New
        [StringValue("Approved")]//"#006600"
        Approved = 2,//2 Document's status is Approved
        [StringValue("Not Approved")]//"#FF9900"
        NotApproved = 3,//3 Document's status is NotApproved
        [StringValue("FeedBack")]//"#F23D00"
        FeedBack = 4,//4 Document's status is FeedBack
        [StringValue("Customer Approved")]//"#006600"
        CustomerApproved = 5,//5 Document's status is CustomerApproved
        [StringValue("Customer Not Approved")]//"#FF9900"
        CustomerNotApproved = 6,//6 Document's status is CustomerNotApproved
        [StringValue("Created PO")]//"white"
        CreatedPO = 7,//7 Document Request PO's status is CreatedPO
        [StringValue("Created SO")]//"white"
        CreatedSO = 8,//8 Document Request SO's status is CreatedSO
        [StringValue("Completed")]//"#A6A6A6"
        Completed = 9,//9 Document's status is Completed
        [StringValue("Closed")]//"#A6A6A6"
        Closed = 10,//10 Document's status Closed       
        [StringValue("Updated")]//"#FF9900"
        Updated = 11,//11 Update from FeedBack
        [StringValue("Write MainBook")]//"#006600"
        WriteMainBook = 12,//12 Write to MainBook Accounting
        [StringValue("Write TempBook")]//"#0099FF"
        WriteTempBook = 13,//13 Write to TempBook Accounting
        [StringValue("Error")]//"#F23D00"
        Error = 14,//14 Error Accounting
        CreateInvoice = 15,//15
        FixedErrors = 16,//16 - Đã sửa lỗi
        [StringValue("Fixed Errors")]
        NotApportioned = 25,
        [StringValue("Apportioned")]
        Apportioned = 26,
        [StringValue("Re-Apportion")]
        ReApportion = 27,
        [StringValue("Stop-Apportion")]
        StopApportion = 28,
        Edited = 24,
        RequestEdit = 23,
        Liquidated = 21,//đã thanh lý0
        Dissolve = 22,//hủy bỏ
        Executing = 18,//Đang thực hiện
        WaitForLiquidate = 20//chờ thanh lý
    }

    //public  enum StatusColor : int
    //{
    //    //Remember to add more StatusColor: Please add at lastest enum
    //    [StringValue("white")]//"white"
    //    New = 1,//1 Document's status color is New
    //    [StringValue("#006600")]//"#006600"
    //    Approved,//2 Document's status color is Approved
    //    [StringValue("#FF9900")]//""
    //    NotApproved,//3 Document's status color is NotApproved
    //    [StringValue("#F23D00")]//"#F23D00"
    //    FeedBack ,//4 Document's status color is FeedBack
    //    [StringValue("#006600")]//""
    //    CustomerApproved,//5 Document's status color is CustomerApproved
    //    [StringValue("#FF9900")]//"#FF9900"
    //    CustomerNotApproved,//6 Document's status color is CustomerNotApproved
    //    [StringValue("white")]//"white"
    //    CreatedPO,//7 Document Request PO's status color is CreatedPO
    //    [StringValue("white")]//""
    //    CreatedSO,//8 Document Request SO's status color is CreatedSO
    //    [StringValue("#A6A6A6")]//""
    //    Completed,//9 Document's status color is Completed
    //    [StringValue("#A6A6A6")]//""
    //    Closed,//10 Document's status color Closed       
    //    [StringValue("#FF9900")]//""
    //    Updated,//11  color Update from FeedBack
    //    [StringValue("#006600")]//""
    //    WriteMainBook,//12  color Write to MainBook Accounting
    //    [StringValue("#0099FF")]//""
    //    WriteTempBook,//13  color Write to TempBook Accounting
    //    [StringValue("#F23D00")]//
    //    Error,//14  color Error Accounting
    //}

    public enum BatchType : int
    {
        //Remember to add more BatchType: Please add at lastest enum
        [StringValue("Bình thường")]
        Nomal = 1,//1 Nomal
        [StringValue("Ngoài bảng")]
        Extenal,//2 Extenal
    }

    public enum eziposModule : int
    {
        /// <summary>
        /// Đơn hàng mua
        /// </summary>
        PO = 1,
        /// <summary>
        /// Đơn hàng bán
        /// </summary>
        SO = 2,
        /// <summary>
        /// Phân hệ Tiền
        /// </summary>
        CM = 3,
        /// <summary>
        /// Phiếu Chi 
        /// </summary>
        CMP = 4,
        /// <summary>
        /// Phiếu thu
        /// </summary>
        CMR = 5,
        /// <summary>
        /// Phân hệ Tổng hợp
        /// </summary>
        GL = 6,
        /// <summary>
        /// Công nợ phải thu
        /// </summary>
        AR = 7,
        /// <summary>
        /// Công nợ phải trả
        /// </summary>
        AP = 8,
        /// <summary>
        /// Phân bổ tài sản
        /// </summary>
        AMPEPREBUS = 10,
        /// <summary>
        /// Phân hệ Kế toán kho
        /// </summary>
        IC = 11,
        /// <summary>
        ///Phân hệ Tài Sản
        /// </summary>
        AM = 13,
        /// <summary>
        /// Hóa đơn
        /// </summary>
        IV = 14,
        /// <summary>
        /// Tờ khai
        /// </summary>
        DEC = 15,
        /// <summary>
        ///Hợp Đồng
        /// </summary>
        COT = 16,
        /// <summary>
        ///  Giá thành
        /// </summary>
        CP = 17,
        /// <summary>
        /// MetaData
        /// </summary>
        MTA = 18,
        /// <summary>
        /// Yêu cầu mua hàng
        /// </summary>
        PR = 19,
        /// <summary>
        /// bán hàng trả lại
        /// </summary>
        RESO = 20,
        /// <summary>
        /// Yêu cầu Thanh toán
        /// </summary>
        PROSEPAY = 21,
        /// <summary>
        /// Báo Giá
        /// </summary>
        QUOTE = 22,
        /// <summary>
        /// Modul dự án
        /// </summary>        
        PRJ = 23,
        /// <summary>
        /// Modul Common
        /// </summary>
        COMMON = 24,
        /// <summary>
        /// Modul báo cáo
        /// </summary>
        REPORT = 25,
        /// <summary>
        ///Nghiệp vụ tác động
        /// </summary>
        AMEVALUATION = 28,
        /// <summary>
        /// Nghiệp vụ Tăng tài sản
        /// </summary>
        AMINCREASE = 29,
        /// <summary>
        /// Nghiệp vụ giảm tài sản
        /// </summary>
        AMDECREASE = 30,
        /// <summary>
        /// nghiệp vụ nhập kho
        /// </summary>
        ICINSTOCK = 31,
        /// <summary>
        /// nghiệp vụ xuất kho
        /// </summary>
        ICOUTSTOCK = 32,
        /// <summary>
        /// nghiệp vụ chuyển kho
        /// </summary>
        ICMOVE = 33,
        /// <summary>
        /// yêu cầu nhập kho
        /// </summary>
        ICREQUES = 34,
        /// <summary>
        /// kế hoạch kho
        /// </summary>
        ICPLAN = 35,
        /// <summary>
        /// Lắp ghép
        /// </summary>
        ICASSEMBLY = 36,
        /// <summary>
        /// tháo gỡ
        /// </summary>
        ICDEASSEMBLY = 37,
        /// <summary>
        /// công thức chế biến        
        /// </summary>
        ICBOM = 41,
        /// <summary>
        ///Tai san
        /// </summary>
        AMASSETITEM = 42,
        /// <summary>
        /// Quản Lý Nhà hàng
        /// </summary>
        EZIRES = 43,
        /// <summary>
        /// Quản Lý thuế
        /// </summary>
        TAX = 44,
        /// <summary>
        /// Quản Lý Sản Xuất
        /// </summary>
        MANU = 45,
        /// <summary>
        /// Quản Lý Dự Án
        /// </summary>
        PROJECT = 46,
        /// <summary>
        /// Quản Lý Nhân Sự
        /// </summary>
        HRM = 47,
        /// <summary>
        /// Vận chuyển
        /// </summary>
        SHIP = 48,
        /// <summary>
        /// Kiểm kho
        /// </summary>
        INVEN = 49,

        /// <summary>
        /// Phân hệ order trên PDA, Ipod 
        /// </summary>
        EZIRESWEB = 57

    }
    public enum DOCOFTYPE : short
    {
        /// <summary>
        /// Sản xuất
        /// </summary>
        Manufacture = 1,
        // Bán hàng=	2,
        // Dự phòng=	3,
        Domestic = 4,
        /// <summary>
        /// Xuất khẩu
        /// </summary>
        Export = 5,
        /// <summary>
        /// Nhập khẩu
        /// </summary>
        Import = 6,
        /// <summary>
        /// Mua 
        /// </summary>
        Buy = 8,
        /// <summary>
        /// Bán
        /// </summary>
        Sale = 9,
        BuyReturn = 10,
        SaleReturn = 11,
        DocImport = 18,
        DocExport = 19,
        Mixed = 12,
        //Ngoại bàng	13,
        CM = 14,
        //Công Nợ	15,
        // Chi Trước	16,
        // Thu trước	17,
        //Nhập Khẩu	18,
        //Xuất khẩu	19,
        Receive = 20,
        Payment = 21,
        AR = 22,
        AP = 23,
        /// <summary>
        /// Xuất kho hàng bán
        /// </summary>
        IcoSale = 44,
        /// <summary>
        /// Xuất kho hàng mua trả lại
        /// </summary>
        IcoBuyReturn = 46,
        /// <summary>
        /// Xuất kho tổng hợp
        /// </summary>
        IcoGeneral = 48,
        /// <summary>
        /// chi hóa đơn
        /// </summary>
        CMPIV = 57,
        /// <summary>
        /// chi công nợ
        /// </summary>
        CMPDEP = 58,
        /// <summary>
        /// chi trước
        /// </summary>
        CMPBEFOR = 59,
        /// <summary>
        /// chi khác
        /// </summary>
        CMPOTHER = 60,
        /// <summary>
        /// Chi từ phiếu nhập
        /// </summary>
        CMPIC = 63,
        /// <summary>
        /// thu hóa đơn
        /// </summary>
        CMRIV = 14,
        /// <summary>
        /// thu công nợ
        /// </summary>
        CMRDEP = 15,
        /// <summary>
        /// thu trước
        /// </summary>
        CMRBEFOR = 16,
        /// <summary>
        /// thu khác
        /// </summary>
        CMROTHER = 17,
        /// <summary>
        /// thu từ phiếu nhập
        /// </summary>
        CMRIC = 62,
    }
    public enum IVTYPE : short
    {
        [StringValue("Dịch vụ")]
        SERVICE = 1,
        [StringValue("Hàng hóa")]
        ITEM = 2,
    }
    /// <summary>
    /// AR business type
    /// </summary>
    /// 
    public enum ArBusType : int
    {
        /// <summary>
        /// BINH THUONG
        /// </summary>
        Normal = 0,
        /// <summary>
        /// Xuat khau
        /// </summary>
        Export = 1
    }
    public enum APBusType : int
    {
        /// <summary>
        /// Trong nước
        /// </summary>
        Domestic = 4,
        /// <summary>
        /// Ngoài nước
        /// </summary>
        Foreign = 6
    }



    /// <summary>
    /// Loai chung tu
    /// </summary>
    public enum VoucherType : int
    {
        /// <summary>
        /// Binh thuong
        /// </summary>
        Normal = 0,
        /// <summary>
        /// Mua hang  tra lai
        /// </summary>
        Return = 1
    }
    public enum WorkflowOption : int
    {
        /// <summary>
        /// Tao hoa don
        /// </summary>
        MakeInvoice = 1,

        /// <summary>
        /// tao hop dong
        /// </summary>
        MakeContract = 2,

        /// <summary>
        /// tao PaymentPropse
        /// </summary>
        MakeProposePayMent = 3
    }
    public enum WorkflowPara
    {
        [StringValue("MakeInvoce")]
        MakeInvoce,

        [StringValue("MakeContract")]
        MakeContract,

        [StringValue("MakeProposePayment")]
        MakeProposePayment,

        [StringValue("MakePO")]
        MakePO,

        [StringValue("MakeSO")]
        MakeSO
    }
    public enum WorkflowPO
    {
        [StringValue("OrgID")]
        OrgID,

        [StringValue("LdocID")]
        LdocID,

        [StringValue("ObjID")]
        ObjID,

        [StringValue("CurID")]
        CurID,

        [StringValue("Des")]
        Des,

        [StringValue("Status")]
        Status,

        [StringValue("DocType")]
        DocType,

        [StringValue("Module")]
        Module,

        [StringValue("Paras")]
        Paras
    }
    public enum WorkflowSO
    {
        [StringValue("OrgID")]
        OrgID,

        [StringValue("LdocID")]
        LdocID,

        [StringValue("ObjID")]
        ObjID,

        [StringValue("CurID")]
        CurID,

        [StringValue("Des")]
        Des,

        [StringValue("Status")]
        Status,

        [StringValue("DocType")]
        DocType,

        [StringValue("Module")]
        Module,

        [StringValue("Paras")]
        Paras
    }

    public enum TypeTree
    {
        /// <summary>
        /// Chi nhánh
        /// </summary>
        Branch,
        /// <summary>
        /// Tất cả nhóm hàng
        /// </summary>
        ItemGroupAll,
        /// <summary>
        /// Nhóm hàng loại trừ dịch vụ
        /// </summary>
        ItemGroupNoService,

        /// <summary>
        /// Nhóm hàng được bán (các nhóm thuộc hàng hóa, không bao gồm dịch vụ)
        /// </summary>
        ItemGroupSale,

        ///Khu
        Area,

        /// <summary>
        /// Kho
        /// </summary>
        WareHouse
    }

    /// <summary>
    /// Loai chung tu khoa so
    /// </summary>
    public enum TypeDocLock : int
    {
        /// <summary>
        /// Nha hang, ban le, karaoke, bida..
        /// </summary>
        POS = 1,

        /// <summary>
        /// Kho
        /// </summary>
        Stock = 2
    }
    /// <summary>
    /// Loại phiếu kiểm tra khóa sổ khi tạo mới-Tondb
    /// </summary>
    public enum TYPEDOCKNEW : int
    {
        /// <summary>
        /// Nhà hàng
        /// </summary>
        REST = 1,
        /// <summary>
        /// Bán lẻ
        /// </summary>
        RETAIL = 2
    }
    public enum TransferType : int
    {
        RESTICKET = 1,
        RESTICKETITEM = 2,
        RESTICKETITEMDETAIL = 3,
        RESDOCUMENT = 4,
        RESRECEIPT = 5,
        RESPAYMENT = 6,
        RESCUSTOMERSDEBT = 7,
        RESDOCUMENT_TICKET = 8,
        RESDOCUMENTRELATION = 9,
        RESTICKET_PAYMENTDETAILS = 10


    }

}
