using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vnyi.Utility
{
    /// <summary>
    /// chua cac ten dung chung cho he thong
    /// </summary>
    public class clsName
    {
        /// <summary>
        /// chua ten dung chung
        /// </summary>
        #region PUBLIC NAME
        public static string LANGUAGE = "Language";
        public static string COOKIE = "Cookie";
        public static string PAGE = "Page";
        public static string USER = "User";

        public static string LAST = "L";
        public static string NEXT = "N";
        public static string PRE = "P";
        public static string TOP = "T";

        public static string MODEVIEW = "MVIEW";
        public static string MODEEDIT = "MEDIT";
        public static string MODENEW = "MNEW";
        public static string MODEDELETE = "MDEL";
        #endregion
        /// <summary>
        /// chua querystring name
        /// </summary>
        #region QUERY STRING
        public static string MESSAGEPAGEQUERY = "p";
        public static string MESSAGETYPEQUERY = "t";
        public static string MESSAGENAMEQUERY = "n";
        public static string AP = "ap";
        public static string AR = "ar";
        public static string IC = "ic";
        public static string CM = "cm";
        public static string PO = "po";
        public static string SO = "so";
        public static string GL = "gl";
        public static string PROPOSEPAYMENT = "pp";
        public static string TempID = "tmp";
        public static string TempMoney = "tmpmo";
        /// <summary>
        /// Phân hệ
        /// </summary>
        public static string MODULE = "mod";
        /// <summary>
        /// Phân hệ con hay còn subOfsystem
        /// </summary>
        public static string SUBMODULE = "smod";
        public static string BUSINESSID = "bus";
        public static string NAME = "name";
        public static string IVTYPE = "ivty";
        public static string ID = "id";
        /// <summary>
        /// Loại report
        /// </summary>
        public static string REPORTTYPE = "rpt";
        public static string ITEMTYPE = "itt";
        /// <summary>
        /// Danh sách mã mặt hàng
        /// </summary>
        public static string LISTITEMID = "lsIID";
        public static string ITEMNAME = "itn";
        public static string MAINGROUP = "mgroup";
        /// <summary>
        /// ITEMGROUP
        ///     Neu dung trong finder item, co nghia la nhung group cha (group co PARENTID = -1),
        /// khi truyen qua thi truyen ITG_TYPE cua nhung nhom cha, dung truyen ITG_AUTOID
        ///     Neu dung trong cac truong hop khac thi nen chu thich o noi dung
        /// </summary>
        public static string ITEMGROUP = "itg";
        public static string ISITEM = "isit";
        public static string ISIMEX = "isimex";
        public static string ISBUY = "isbuy";

        public static string ITEMCATEGORY = "itc";
        public static string NEWIV = "newiv";
        public static string NEW = "new";
        public static string TYPE = "type";
        public static string TYPEMAIN = "typemain";
        public static string ISSEFT = "isse";
        /// <summary>
        /// Danh sách mã đối tượng cách nhau bởi dấu ;
        /// </summary>
        public static string LSTOBJECTID = "lstobjid";
        /// <summary>
        /// Loại nghiệp vụ
        /// </summary>
        public static string BUSINESSTYPE = "buty";
        public static string CREATEDBY = "cre";
        public static string RESTORE = "re";
        public static string RESTOREBUSINESS = "rebu";

        /// <summary>
        /// loai to chuc, vi du: "chi nhanh", "phong ban", "cong ty"... 
        /// </summary>
        public static string ORGTYPE = "orgt";

        public static string LISTDOCID = "ldocid";
        public static string ORGID = "orgid";
        public static string OBJID = "objid";
        public static string OBJNAME = "objname";
        public static string OBJTYPE = "objt";
        public static string ISORG = "isorg";
        public static string EXCID = "excid"; //exclude id, finder ko bao gom nhung id nay
        public static string DEPARTID = "depid"; //mã phòng ban
        public static string STATUS = "status";
        public static string CURRENCYID = "curid";
        public static string BYBANK = "bybank";
        public static string ISPAYMENT = "ispayment";
        public static string MODE = "mode";
        public static string QueryUrl = "urls";
        public static string assetId = "assetId";
        public static string ASIID = "asiid";
        public static string ASSETTYPE = "assettype";
        public static string ACC_CODE = "acc";
        public static string STATUSID = "sti";
        public static string WareHouseID = "whid";
        public static string CTMTYPE = "ctType";
        /// <summary>
        /// Mã năm tài chính
        /// </summary>
        public static string YearID = "yid";
        /// <summary>
        /// tien mat hay ko phai tien mat
        /// gia tri: true, false
        /// </summary>
        public static string ISCAS = "iscas";
        /// <summary>
        /// loai chung tu cong no(phai thu hoac phai tra)
        /// giai tri: pay, rec
        /// </summary>
        public static string DEPT = "dept";
        public static string FICI = "fici";
        public static string GLTYPE = "gltype";
        public static string GLDETAIL = "glbld";
        public static string POPRID = "poprid";


        #endregion

        #region LANGUAGE
        public static string VIETNAMESE = "vi_VN";
        public static string ENGLISH = "en_US";
        public static string FRANCE = "fr_FR";
        public static string DENMARK = "da_DK";
        public static string CHINESE = "zh_CN";
        public static string JAPANESE = "jp_JP";

        #endregion
    }
    public enum CookieName
    {
        /// <summary>
        /// Ngôn ngữ
        /// </summary>
        ErpLangugage,
        /// <summary>
        /// UserName
        /// </summary>
        ErpUserName,
        /// <summary>
        /// tổ chức
        /// </summary>
        Organization

    }
    public enum Mode : byte
    {
        /// <summary>
        /// Trạng thái View
        /// </summary>
        View = 1,
        /// <summary>
        /// Trạn thái Edit
        /// </summary>
        Edit = 2,
        /// <summary>
        /// Trạng thái New
        /// </summary>
        New = 3,
        /// <summary>
        /// Kỳ tài chính đã đóng
        /// </summary>
        Closed =4
    }
    public enum ControlTypes : short
    {
        TextFieldBase = 1,
        ComboBox = 2,
        Label = 3,
        Panel = 4,
        Button = 5,
        Checkbox = 6,
        ToolbarButton = 7,
        GridPanel = 8,
        ViewPort = 9,
        FieldSet = 10,
        DateField = 11,
        NumberField = 12,
        TabPanel = 13,
        Tab = 14,
        Radio = 15,
        ToolbarTextItem = 16,
        TriggerField = 17,
        TextBox = 18,
        ColumnBase = 19,
        TextBlock = 20,
        GridColumn = 21,
        GroupBox = 22,
        TreeGridColumn = 23,
        TreeGrid = 24,
        ColumnTree = 25,
        MenuTextItem = 27,
        RadioGroup = 28,
        FileUploadField = 29,
        CompositeField = 32,
        CheckboxGroup = 33,
        ToolTip = 34

    }

    public enum AttriubteTypes : short
    {
        Text = 1,
        Title = 2,
        Header = 3,
        Tooltip = 4,
        FieldLabel = 5,
        BoxLabel = 6,
    }

    public enum RefreshType : short
    {
        /// <summary>
        /// Nhóm đối tượng
        /// </summary>
        ObjGroup = 1,
        /// <summary>
        /// danh sách doi tượng
        /// </summary>
        ObjectList = 2,
        /// <summary>
        /// nhóm hàng hóa
        /// </summary>
        ItemGroupt = 3,
        /// <summary>
        /// Danh sách hàng hóa
        /// </summary>
        ITemList = 4,
        /// <summary>
        ///Đối tượng
        /// </summary>
        Object = 5,
        /// <summary>
        /// Dảnh cho doi tượng
        /// </summary>
        Document = 6,
        /// <summary>
        /// RESCOUNTER - Quầy
        /// </summary>
        RESCOUNTER = 7,
        /// <summary>
        /// RESSTYLE - định dạng
        /// </summary>
        RESSTYLE = 8,
        /// <summary>
        /// RESAREA - Khu
        /// </summary>
        RESAREA = 9,
        /// <summary>
        /// sự cố bán hàng
        /// </summary>
        RESINCIDENTSSALE = 10,
        /// <summary>
        /// Chính sách giảm giá
        /// </summary>
        RESDISCOUNTTYPE = 11,

        ///Thong bao
        RESANNOUNCEMENT = 12,

        /// <summary>
        /// CA
        /// </summary>
        RESSHIFT = 13,

        /// <summary>
        /// Loại thẻ VIP
        /// </summary>
        RESVIPCARDTYPE = 14,

        /// <summary>
        /// Loại thẻ
        /// </summary>
        RESPROMOCARD = 15,

        /// <summary>
        /// Danh sách bếp
        /// </summary>
        RESKITCHEN = 16,

        /// <summary>
        /// Loại thẻ tặng
        /// </summary>
        RESGIFTCARD = 17,
        /// <summary>
        /// Bàn-phòng
        /// </summary>
        RESTABLE = 18,
        /// <summary>
        /// Loại giờ
        /// </summary>
        RESTIMETYPE = 19,
        /// <summary>
        /// Phiếu bán hàng nhà hàng
        /// </summary>
        RESTICKET_RES = 21
    }
}
