using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Ext.Net;
using vnyi.Library.Meta.ACC;
using vnyi.Library.Meta.OBJ;
using vnyi.Library.Meta.Extent;
using vnyi.Library.Meta.Item;
using vnyi.Library.DOC;

using vnyi.Library.RES;
using vnyi.Utility.CatchingManager;
using vnyi.Library.AM;

namespace vnyi.Utility
{
    public partial class Finder
    {
        private void initFinder(string findertype, Int16? Culture)
        {
            switch (findertype)
            {
                case "none":

                    break;
                #region PUBBATCH
                case "PUBBATCH":
                    {
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã",
                            ID = "txtID",
                            ControlType = ControlType.TextField,
                            IsControlGetValue = true,
                            DataType = DataType.String,
                            QueryString = "PubBatch",
                            IsFocus = true
                        });

                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtName",
                            ControlType = ControlType.TextField,
                            IsControlGetValue = true,
                            DataType = DataType.String
                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Ngày tạo",
                            ID = "dfCreateDate",
                            ControlType = ControlType.DateField,
                            IsControlGetValue = true,
                            DataType = DataType.Date
                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Phân hệ",
                            ID = "hdModul",
                            ControlType = ControlType.HiddenField,
                            IsControlGetValue = true,
                            DataType = DataType.String,
                            QueryString = clsName.MODULE
                        });
                        this.LabelWidth = 60;
                        this.StoreName = "spPUBBATCHSearch";
                        this.GridFinder = new GridFinder
                        {
                            ID = "grBatchList",
                            Title = "Danh sách lô",
                            Mutiple = false

                        };
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clAutoID",
                            DataIndex = "PUBAT_AUTOID",
                            Header = "Mã tự tăng",
                            RecordField = "PUBAT_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true,
                            Sortable = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            DataIndex = "PUBAT_DOCUMENTNO",
                            Header = "Mã",
                            RecordField = "PUBAT_DOCUMENTNO",
                            IsReturnValue = true,
                            Width = 100,
                            Sortable = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clName",
                            DataIndex = "PUBAT_BATCHNAME",
                            Header = "Tên",
                            RecordField = "PUBAT_BATCHNAME",
                            AutoExpandColumn = true,
                            Sortable = true

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clCreateDate",
                            DataIndex = "PUBAT_CREATEDATE",
                            Header = "Ngày tạo",
                            RecordField = "PUBAT_CREATEDATE",
                            IsReturnValue = true,
                            Width = 80,
                            Sortable = true
                        });
                    }
                    break;

                #endregion

                //Create by Phongvt
                //Create date 11/03/2009
                //Edit date: 
                //Decsription: Khởi tạo Finder cho danh sách Item
                #region ItemForProposePayment
                case "ItemForProposePayment":
                    {
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã",
                            ID = "txtID",
                            ControlType = ControlType.TextField,
                            IsControlGetValue = true,
                            DataType = DataType.String
                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtName",
                            ControlType = ControlType.TextField,
                            IsControlGetValue = true,
                            DataType = DataType.String
                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Loại",
                            ID = "hdType",
                            ControlType = ControlType.HiddenField,
                            IsControlGetValue = true,
                            DataType = DataType.String,
                            QueryString = "typeid"
                        });
                        this.StoreName = "spFinderItemsFroProposePayment";

                        this.GridFinder = new GridFinder
                        {
                            ID = "grProductList",
                            Title = "Danh sách sản phẩm",
                            Mutiple = false
                        };

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clIDAuto",
                            DataIndex = "PIT_AUTOID",
                            Header = "Mã Tự tăng",
                            RecordField = "PIT_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            DataIndex = "PIT_ITEMNO",
                            Header = "Mã",
                            RecordField = "PIT_ITEMNO",
                            IsReturnValue = true,
                            Width = 100
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clName",
                            DataIndex = "PIT_NAME",
                            Header = "Tên",
                            RecordField = "PIT_NAME",
                            IsReturnValue = true,
                            Width = 200
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clUom",
                            DataIndex = "PIT_UOMID1",
                            Header = "Mã đơn vị tính",
                            RecordField = "PIT_UOMID1",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clWhID",
                            DataIndex = "WH_AUTOID",
                            RecordField = "WH_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clCatergory",
                            DataIndex = "ITET_AUTOID",
                            RecordField = "ITET_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clPacking",
                            DataIndex = "PK_AUTOID",
                            RecordField = "PK_AUTOID",
                            Header = "Mã quy cách bao bì",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clSalePrice",
                            Header = "Đơn giá bán",
                            Width = 200,
                            Sortable = true,
                            RecordField = "PIT_SOPRICE1",
                            Renderer = string.Empty,
                            DataIndex = "PIT_SOPRICE1",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add("PIT_POPRICE", "Đơn giá mua", 200, true, "PIT_POPRICE", string.Empty, "PIT_POPRICE", true, true);//8
                        this.GridFinder.Add("CUR_AUTOID", "", 100, false, "CUR_AUTOID", string.Empty, "CUR_AUTOID", true, true);//9
                        this.GridFinder.Add("PIT_WHACCOUNT", "", 100, false, "PIT_WHACCOUNT", string.Empty, "PIT_WHACCOUNT", true, true);//10
                        this.GridFinder.Add("PIT_ASSETACCOUNT", "", 100, false, "PIT_ASSETACCOUNT", string.Empty, "PIT_ASSETACCOUNT", true, true);//101

                        this.GridFinder.Add("Kho mặc định", 200, true, "WH_NAME", string.Empty, "WH_NAME", false);
                        this.GridFinder.Add("Phân loại", 0, true, "ITET_NAME", string.Empty, "ITET_NAME", false);
                        this.GridFinder.Add("Quy cách bao bì", 0, true, "PK_NAME", string.Empty, "PK_NAME", false);
                        this.GridFinder.Add("Đơn vị tính", 200, true, "UOM_NAME", string.Empty, "UOM_NAME", false);




                    }
                    break;

                #endregion
                //Create by Phongvt
                //Create date 10/03/2009
                //Edit date: 10/03/2009
                //Decsription: Khởi tạo Finder cho Phương thức thanh toán
                #region ObjectForInvoice
                case "ObjectForInvoice":
                    {
                        ControlFinder ctrll = new ControlFinder("Loại đối tượng", ControlType.HiddenField, DataType.String, "OBJ_TYPE", true);
                        ctrll.QueryString = "objtype";
                        this.ListControl.Add(ctrll);
                        ControlFinder ctrl = new ControlFinder("Mã đối tượng", ControlType.TextField, DataType.Int, "txtID", true);
                        ctrl.IsControlGetValue = true;
                        ctrl.QueryString = "id";

                        this.ListControl.Add(ctrl);
                        this.ListControl.Add("Tên đối tượng", ControlType.TextField, DataType.String, "txtName");
                        this.ListControl.Add("Mã số thuế", ControlType.NumberField, DataType.String, "txtSerialTax");
                        this.ListControl.Add("Địa chỉ", ControlType.TextField, DataType.String, "txtAdress");

                        this.StoreName = "spFinderObjectForInvoice";

                        this.GridFinder = new GridFinder("Danh sách nhà cung cấp", false);

                        this.GridFinder.Add("OBJ_AUTOID", "Mã hệ thống", 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        this.GridFinder.Add("Tên đối tượng", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("Mã đối tượng", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        this.GridFinder.Add("Địa chỉ", 200, true, "OBJ_ADDRESS", string.Empty, "OBJ_ADDRESS", true);
                        this.GridFinder.Add("Số điện thoại", 100, true, "OBJ_PHONENUMBER", string.Empty, "OBJ_PHONENUMBER", true);
                        this.GridFinder.Add("Mã số thuế", 100, true, "OBJ_SERIALTAX", string.Empty, "OBJ_SERIALTAX", true);
                        this.GridFinder.Add("Tài khoản mặc định", 100, true, "ACC_CODE", string.Empty, "ACC_CODE", true);
                        EventbtnNews = "openPageForFinder('ADDOBJECT', 'Danh Mục Đối Tượng', '/Meta/AddObject.aspx', true)";
                        IsEventbtn = true;
                    }
                    break;
                #endregion

                #region TablePrice
                case "TablePrice":
                    {
                        ControlFinder ctrl = new ControlFinder("Mã hoặc tên",
                            ControlType.TextField,
                            DataType.Int,
                            "txtNoandName",
                            true);
                        ctrl.IsControlGetValue = true;
                        ctrl.QueryString = "norn";
                        this.ListControl.Add(ctrl);
                        ListControl.Add(new ControlFinder
                        {
                            ControlType = ControlType.DateField,
                            DataType = DataType.Date,
                            ID = "dfFromDate",
                            FieldLabel = "Từ ngày"
                        });

                        ListControl.Add(new ControlFinder
                        {
                            ControlType = ControlType.DateField,
                            DataType = DataType.Date,
                            ID = "dfToDate",
                            FieldLabel = "Đến ngày"
                        });
                        DataSource.Add(new DataItem(Messager.getMessagerByKey(keyWord.MessagerKey.Approve, Culture).Messager, "2"));
                        DataSource.Add(new DataItem(Messager.getMessagerByKey(keyWord.MessagerKey.StatusWaitingApproved, Culture).Messager, "7"));
                        DataSource.Add(new DataItem(Messager.getMessagerByKey(keyWord.MessagerKey.All, Culture).Messager, "2,7"));
                        this.ListControl.Add(new ControlFinder
                        {
                            ControlType = ControlType.Combobox,
                            DataType = DataType.String,
                            ID = "cboStatus",
                            DataSource = DataSource,
                            FieldLabel = "Trạng thái"

                        }
                        );
                        ListControl.Add(new ControlFinder
                        {
                            ControlType = ControlType.HiddenField,
                            DataValueField = DateTime.Now.Date.ToString(),
                        });
                        ListControl.Add(new ControlFinder
                       {
                           ControlType = ControlType.HiddenField,
                           DataValueField = null
                       });

                        this.StoreName = "SP_SO_GETALL_TABLEPRICE";

                        this.GridFinder = new GridFinder("Danh sách nhà cung cấp", false);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            DataIndex = "TBP_AUTOID",
                            Header = "Mã tự tăng",
                            RecordField = "TBP_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true,
                            Sortable = false
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clNo",
                            DataIndex = "TBP_DOCNO",
                            Header = "Mã",
                            RecordField = "TBP_DOCNO",
                            IsReturnValue = true,
                            IsHidden = false,
                            Sortable = true,
                            Width = 100
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên",
                            Width = 200,
                            Sortable = true,
                            DataIndex = "TBP_NAME",
                            ColumnId = "clName",
                            IsHidden = false,
                            AutoExpandColumn = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clCreateDate",
                            DataIndex = "TBP_CREATEDATE",
                            Header = "Ngày tạo",
                            RecordField = "TBP_CREATEDATE",
                            IsReturnValue = true,
                            IsHidden = false,
                            Sortable = true,
                            Width = 80,
                            Renderer = "return fmDateTime(value);",
                            datatype = RecordFieldType.Date
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clApproveBy",
                            DataIndex = "APPROVEBY_NAME",
                            Header = "Người duyệt",
                            RecordField = "APPROVEBY_NAME",
                            IsReturnValue = true,
                            IsHidden = false,
                            Sortable = true,
                            Width = 100
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clApproveDate",
                            DataIndex = "TBP_APPROVEDATE",
                            Header = "Ngày duyệt",
                            RecordField = "TBP_APPROVEDATE",
                            IsReturnValue = true,
                            IsHidden = false,
                            Sortable = true,
                            Width = 80,
                            Renderer = "return fmDateTime(value);",
                            datatype = RecordFieldType.Date
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clIsUsed",
                            Header = "Sử dụng",
                            Width = 30,
                            Sortable = true,
                            DataIndex = "TBP_ISUSE",
                            RecordField = "TBP_ISUSE",
                            IsReturnValue = true,
                            datatype = RecordFieldType.Boolean
                        });
                        IsEventbtn = true;
                    }
                    break;
                #endregion


                #region Customer
                case "customer":
                    {
                        //this.ListControl.Add("Mã khách hàng", ControlType.NumberField, DataType.Int, "txtID", true);
                        ControlFinder ctrl = new ControlFinder("Mã khách hàng", ControlType.TextField, DataType.Int, "txtID", true);
                        ctrl.IsControlGetValue = true;
                        ctrl.QueryString = "id";

                        this.ListControl.Add(ctrl);
                        this.ListControl.Add("Tên khách hàng", ControlType.TextField, DataType.String, "txtName");
                        this.ListControl.Add("Mã số thuế", ControlType.NumberField, DataType.String, "txtSerialTax");
                        this.ListControl.Add("Địa chỉ", ControlType.TextField, DataType.String, "txtAdress");

                        this.StoreName = "spFinderCustomer";

                        this.GridFinder = new GridFinder("Danh sách khách hàng", false);

                        this.GridFinder.Add("OBJ_AUTOID", "Mã hệ thống", 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        this.GridFinder.Add("Tên khách hàng", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("Mã khách hàng", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        this.GridFinder.Add("Địa chỉ", 200, true, "OBJ_ADDRESS", string.Empty, "OBJ_ADDRESS", true);
                        this.GridFinder.Add("Số điện thoại", 100, true, "OBJ_PHONENUMBER", string.Empty, "OBJ_PHONENUMBER", true);
                        this.GridFinder.Add("Mã số thuế", 100, true, "OBJ_SERIALTAX", string.Empty, "OBJ_SERIALTAX", true);
                        this.GridFinder.Add("Tài khoản mặc định", 100, true, "ACC_CODE", string.Empty, "ACC_CODE", true);

                        GridFinder.Add("Phương thức thanh toán", 200, true, "PAY_NAME", string.Empty, "PAY_NAME", false);
                        GridFinder.Add("Phương thức vận chuyển", 200, true, "SMT_NAME", string.Empty, "SMT_NAME", false);
                        GridFinder.Add("Điều khoản thanh toán", 200, true, "PTE_DESCRIPTION", string.Empty, "PTE_DESCRIPTION", false);

                        GridFinder.Add("PAY_AUTOID", "Mã Phương thức thanh toán", 200, true, "PAY_AUTOID", string.Empty, "PAY_AUTOID", true, true);
                        GridFinder.Add("SMT_AUTOID", "Mã Phương thức vận chuyển", 200, true, "SMT_AUTOID", string.Empty, "SMT_AUTOID", true, true);
                        GridFinder.Add("PTE_AUTOID", "Mã Điều khoản thanh toán", 200, true, "PTE_AUTOID", string.Empty, "PTE_AUTOID", true, true);
                        GridFinder.Add("Người liên hệ", 200, true, "CON_NAME", string.Empty, "CON_NAME", true);
                        GridFinder.Add("Tỉnh thành", 200, true, "PRVCON", string.Empty, "PRVCON", true);
                        EventbtnNews = "openPageForFinder('ADDOBJECT', 'Danh Mục Đối Tượng', '/Meta/AddObject.aspx', true)";
                        IsEventbtn = true;

                    }


                    break;
                #endregion
                //Create by Duongnh
                //Create date 09/09/2009
                //Edit date: 08/03/2010
                //Edit by: Vinhlq
                //Decsription: Khởi tạo Finder cho Nhà cung cấp
                #region SupplierFinder
                case "supplier_":
                    {
                        //this.ListControl.Add("Mã khách hàng", ControlType.NumberField, DataType.Int, "txtID", true);
                        ControlFinder ctrl = new ControlFinder("Mã nhà cung cấp", ControlType.TextField, DataType.Int, "txtID", true);
                        ctrl.IsControlGetValue = true;
                        ctrl.QueryString = "id";

                        this.ListControl.Add(ctrl);
                        this.ListControl.Add("Tên nhà cung cấp", ControlType.TextField, DataType.String, "txtName");
                        this.ListControl.Add("Mã số thuế", ControlType.NumberField, DataType.String, "txtSerialTax");
                        this.ListControl.Add("Địa chỉ", ControlType.TextField, DataType.String, "txtAdress");

                        this.StoreName = "SP_PO_FinderSupplier";

                        this.GridFinder = new GridFinder("Danh sách nhà cung cấp", false);

                        this.GridFinder.Add("OBJ_AUTOID", "Mã hệ thống", 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        this.GridFinder.Add("Tên nhà cung cấp", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("Mã nhà cung cấp", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        this.GridFinder.Add("Mã số thuế", 100, true, "OBJ_SERIALTAX", string.Empty, "OBJ_SERIALTAX", true);
                        this.GridFinder.Add("Tài khoản mặc định", 100, true, "ACC_CODE", string.Empty, "ACC_CODE", true);
                        this.GridFinder.Add("Diễn giải", 100, true, "OBJ_DESCRIPTION", string.Empty, "OBJ_DESCRIPTION", true);
                        EventbtnNews = "openPageForFinder('ADDOBJECT', 'Danh Mục Đối Tượng', '/Meta/AddObject.aspx', true)";
                        IsEventbtn = true;

                    }


                    break;
                #endregion
                //Create by Phongvt
                //Motify by: Pham Tuan Anh (finder object follow Object Type)
                //Motify date: 25/06/2009
                //Create date 10/03/2009
                //Edit date: 10/03/2009
                //Decsription: Khởi tạo Finder cho đối tượng
                #region Object
                case "object":
                    {
                        /*
                         * Chú ý:
                         * Bạn nào muốn làm finder đối tượng theo loại đối tượng cho phù hợp với nghiêp vụ thì:
                         *   - Tạo 1 finder riêng và truyền 1 hidden field chứa mã của loại đối tượng cần finder
                         *   - vẫn sử dụng lại store spFinderObject
                         * Bạn nào không muốn sử dụng lại store spFinderObject thì không quan tâm cái này, làm từ đầu đi
                         * */
                        this.ListControl.Add("Mã đối tượng", ControlType.TextField, DataType.Int, "txtID", true);
                        this.ListControl.Add("Tên đối tượng", ControlType.TextField, DataType.String, "txtName");
                        this.ListControl.Add("Mã số thuế", ControlType.NumberField, DataType.String, "txtSerialTax");
                        this.ListControl.Add("Địa chỉ", ControlType.TextField, DataType.String, "txtAdress");
                        // List<PUBOBJECTTYPE> lstObjectType = PUBOBJECTTYPEDAO.GetAllPUBOBJECTTYPEACTIVE();
                        //for (int i = 0; i < lstObjectType.Count; i++)
                        //{
                        //    DataSource.Add(new DataItem(lstObjectType[i].OBJT_NAME, lstObjectType[i].OBJT_AUTOID));
                        //}
                        this.ListControl.Add("Loại", ControlType.Combobox, DataType.String, "cboObjectType", true, DataSource);

                        this.StoreName = "spFinderObject";

                        this.GridFinder = new GridFinder("Danh sách đối tượng", true);

                        this.GridFinder.Add("OBJ_AUTOID", "Mã hệ thống", 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        this.GridFinder.Add("Tên đối tượng", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("Mã đối tượng", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        this.GridFinder.Add("TK đối tượng", 100, true, "ACC_CODE", string.Empty, "ACC_CODE", true);
                        this.GridFinder.Add("Loại đối tượng", 200, true, "OBJT_NAME", string.Empty, "OBJT_NAME", true);
                        this.GridFinder.Add("Địa chỉ", 200, true, "OBJ_ADDRESS", string.Empty, "OBJ_ADDRESS", true);
                        this.GridFinder.Add("Số điện thoại", 100, true, "OBJ_PHONENUMBER", string.Empty, "OBJ_PHONENUMBER", true);
                        this.GridFinder.Add("Mã số thuế", 100, true, "OBJ_SERIALTAX", string.Empty, "OBJ_SERIALTAX", true);
                        EventbtnNews = "openPageForFinder('ADDOBJECT', 'Danh Mục Đối Tượng', '/Meta/AddObject.aspx', true)";
                        IsEventbtn = true;
                    }


                    break;
                #endregion

                #region RSP_POS
                //Create by Chuongdx
                //Create date 20/12/2010
                //Edit date: 20/12/2010
                //Decsription: Khởi tạo Finder cho Thông tin máy POS
                case "RSP_POS":
                    {
                        this.ListControl.Add("Tên máy", ControlType.TextField, DataType.String, "txtRSP_NAME");
                        this.ListControl.Add("Loại", ControlType.TextField, DataType.String, "txtRSP_POSTYPE");
                        this.ListControl.Add("Mẫu", ControlType.TextField, DataType.String, "txtRSP_POSMODEL");
                        this.ListControl.Add("Số sê-ri", ControlType.TextField, DataType.String, "txtRSP_POSSERIAL");

                        this.StoreName = "sp_RES_Load_RESPOS";

                        this.GridFinder = new GridFinder("Danh sách máy POS", false);

                        this.GridFinder.Add("RSP_POSID", "Mã hệ thống", 100, true, "RSP_POSID", string.Empty, "RSP_POSID", true, true);
                        this.GridFinder.Add("Tên máy", 200, true, "RSP_NAME", string.Empty, "RSP_NAME", true);
                        this.GridFinder.Add("Loại", 100, true, "RSP_POSTYPE", string.Empty, "RSP_POSTYPE", true);
                        this.GridFinder.Add("Mẫu", 100, true, "RSP_POSMODEL", string.Empty, "RSP_POSMODEL", true);
                        this.GridFinder.Add("Số sê-ri", 200, true, "RSP_POSSERIAL", string.Empty, "RSP_POSSERIAL", true);
                    }
                    break;
                #endregion
                //Create by Phongvt
                //Create date 10/03/2009
                //Edit date: 10/03/2009
                //Decsription: Khởi tạo Finder cho Phương thức thanh toán
                #region PaymentMethod
                case "paymentmethod":
                    {
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtName",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });
                        this.StoreName = "spFinderPaymentMethod";
                        this.GridFinder = new GridFinder("Danh sách phương thức thanh toán", false);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            Header = "Mã",
                            Sortable = true,
                            DataIndex = "PAY_AUTOID",
                            RecordField = "PAY_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true,
                            datatype = RecordFieldType.Int
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clName",
                            Header = "Tên",
                            Sortable = true,
                            DataIndex = "PAY_NAME",
                            RecordField = "PAY_NAME",
                            IsReturnValue = true,
                            AutoExpandColumn = true,
                            datatype = RecordFieldType.String
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clValidDate",
                            Header = "Ngày hiệu lực",
                            Sortable = true,
                            DataIndex = "PAY_EFFECTIVEDATE",
                            RecordField = "PAY_EFFECTIVEDATE",
                            IsReturnValue = true,
                            datatype = RecordFieldType.Date
                        });
                        IsEventbtn = true;
                    }
                    break;
                #endregion

                //Create by Phongvt
                //Create date 10/03/2009
                //Edit date: 10/03/2009
                //Decsription: Khởi tạo Finder cho Vận chuyển
                #region ShipMethod
                case "ShipMethod":
                    {
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtName",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });

                        this.StoreName = "spFinderShipMethod";

                        this.GridFinder = new GridFinder("Danh sách phương thức vận chuyển", false);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            Header = "Mã",
                            Sortable = true,
                            DataIndex = "SMT_AUTOID",
                            RecordField = "SMT_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true,
                            datatype = RecordFieldType.Int
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clName",
                            Header = "Tên",
                            Sortable = true,
                            DataIndex = "SMT_NAME",
                            RecordField = "SMT_NAME",
                            IsReturnValue = true,
                            AutoExpandColumn = true,
                            datatype = RecordFieldType.String
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clDescription",
                            Header = "Ngày hiệu lực",
                            Sortable = true,
                            DataIndex = "SMT_DESCRIPTION",
                            RecordField = "SMT_DESCRIPTION",
                            IsReturnValue = true,
                            datatype = RecordFieldType.String
                        });
                        IsEventbtn = true;
                    }
                    break;
                #endregion

                //Create by Phongvt
                //Create date 10/03/2009
                //Edit date: 10/03/2009
                //Decsription: Khởi tạo Finder cho Điều khoản thanh toán
                #region PaymentTerm

                case "paymentterm":
                    {
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtName",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });

                        DataSource.Add(new DataItem(Messager.getMessagerByKey(keyWord.MessagerKey.Accept, Culture).Messager, 1));
                        DataSource.Add(new DataItem(Messager.getMessagerByKey(keyWord.MessagerKey.NotAccept, Culture).Messager, 2));
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Loại",
                            ID = "cboType",
                            ControlType = ControlType.Combobox,
                            DataType = DataType.Int,
                            IsControlGetValue = true,
                            DataSource = DataSource
                        });

                        this.StoreName = "spFinderPaymentTerm";

                        this.GridFinder = new GridFinder("Danh sách điều khoản thanh toán", true);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            Header = "Mã",
                            Sortable = true,
                            DataIndex = "PTE_AUTOID",
                            RecordField = "PTE_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true,
                            datatype = RecordFieldType.Int
                        });

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clDescription",
                            Header = "Tên",
                            Sortable = true,
                            DataIndex = "PTE_DESCRIPTION",
                            RecordField = "PTE_DESCRIPTION",
                            IsReturnValue = true,
                            AutoExpandColumn = true,
                            datatype = RecordFieldType.String
                        });
                        IsEventbtn = true;
                    }
                    break;
                #endregion
                //Create by Phongvt
                //Create date 11/03/2009
                //Edit date: 
                //Decsription: Khởi tạo Finder cho danh sách Item
                #region AmassetItem
                case "amassetitem":
                    {

                        this.ListControl.Add("Mã sản phẩm", ControlType.TextField, DataType.String, "txtItemId", true);
                        this.ListControl.Add("Tên sản phẩm", ControlType.TextField, DataType.String, "txtItemName", true);

                        this.StoreName = "spFinderAmassetitems";

                        this.GridFinder = new GridFinder("Danh sách sản phẩm", false);
                        //0
                        this.GridFinder.Add("ASI_AUTOID", "Mã AUTO", 100, true, "ASI_AUTOID", string.Empty, "ASI_AUTOID", true, true);
                        //1
                        this.GridFinder.Add("Mã tài sản", 100, true, "ASI_ASSETITEMNO", string.Empty, "ASI_ASSETITEMNO", true);
                        //2
                        this.GridFinder.Add("Mã sản phẩm", 100, true, "PIT_ITEMNO", string.Empty, "PIT_ITEMNO", true);
                        //3
                        this.GridFinder.Add("Tên tài sản", 200, true, "PIT_ITEMNAME", string.Empty, "PIT_ITEMNAME", true);
                    }
                    break;

                #endregion

                //Create by Phongvt
                //Create date 20/04/2009
                //Edit date: 20/04/2009
                //Decsription: Khởi tạo Finder cho đối tượng shippng
                case "ShippingObject":
                    #region ShippingObject
                    {
                        //List<PUBOBJECTTYPE> lstObjType = new List<PUBOBJECTTYPE>();
                        //lstObjType = PUBOBJECTTYPEDAO.GetAllPUBOBJECTTYPEACTIVE();

                        //for (int i = 0; i < lstObjType.Count; i++)
                        //{
                        //    DataSource.Add(new DataItem(lstObjType[i].OBJT_NAME, lstObjType[i].OBJT_AUTOID));
                        //}


                        this.ListControl.Add("Mã Đối tượng ", ControlType.TextField, DataType.String, "txtAutoID");
                        this.ListControl.Add("Loại Đối tượng", ControlType.Combobox, DataType.String, "cboOBJTYPE", true, DataSource);

                        this.StoreName = "spObjWithContact";

                        this.GridFinder = new GridFinder("Danh sách shipper", true);

                        this.GridFinder.Add("ID", "OBJ_AUTOID", 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        this.GridFinder.Add("Mã đối tượng", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        this.GridFinder.Add("Tên đối tượng", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("CON_AUTOID", 200, true, "CON_AUTOID", string.Empty, "CON_AUTOID", true);
                        this.GridFinder.Add("Địa chỉ", 200, true, "CON_ADDRESS1", string.Empty, "CON_ADDRESS1", true);
                        this.GridFinder.Add("Điện thoại", 200, true, "CON_PHONENUMBER1", string.Empty, "CON_PHONENUMBER1", true);
                        this.GridFinder.Add("Số Fax", 200, true, "CON_FAXNO", string.Empty, "CON_FAXNO", true);
                        this.GridFinder.Add("Mã số thuế", 200, true, "OBJ_SERIALTAX", string.Empty, "OBJ_SERIALTAX", true);
                        this.GridFinder.Add("Tài khoản", 200, true, "ACD_CODE", string.Empty, "ACD_CODE", true);
                    }
                    #endregion
                    break;


                case "Shipperobject":
                    #region ShippingObject
                    {
                        //List<PUBOBJGROUP> lstObjType = new List<PUBOBJGROUP>();
                        //lstObjType = PUBOBJGROUPDAO.GetPUBOBJGROUPbyType(5);

                        //for (int i = 0; i < lstObjType.Count; i++)
                        //{
                        //    DataSource.Add(new DataItem(lstObjType[i].POG_NAME, lstObjType[i].POG_AUTOID));
                        //}


                        this.ListControl.Add("Tên nhà Vận chuyển ", ControlType.TextField, DataType.String, "txtShipper");
                        this.ListControl.Add("Nhóm vận chuyển", ControlType.Combobox, DataType.String, "cboShipperGroup", true, DataSource);

                        this.StoreName = "ShipperObject";

                        this.GridFinder = new GridFinder("Danh sách nhà vận chuyển", true);

                        this.GridFinder.Add("ID", "OBJ_AUTOID", 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        this.GridFinder.Add("Mã đối tượng", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        this.GridFinder.Add("Tên đối tượng", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("CON_AUTOID", 200, true, "CON_AUTOID", string.Empty, "CON_AUTOID", true);
                        this.GridFinder.Add("Địa chỉ", 200, true, "CON_ADDRESS1", string.Empty, "CON_ADDRESS1", true);
                        this.GridFinder.Add("Điện thoại", 200, true, "CON_PHONENUMBER1", string.Empty, "CON_PHONENUMBER1", true);
                        this.GridFinder.Add("Số Fax", 200, true, "CON_FAXNO", string.Empty, "CON_FAXNO", true);
                        this.GridFinder.Add("Mã số thuế", 200, true, "OBJ_SERIALTAX", string.Empty, "OBJ_SERIALTAX", true);
                        this.GridFinder.Add("Tài khoản", 200, true, "ACD_CODE", string.Empty, "ACD_CODE", true);
                    }
                    #endregion
                    break;
                //Create by Phongvt
                //Create date 10/03/2009
                //Edit date: 10/03/2009
                //Decsription: Khởi tạo Finder cho Chi nhánh    
                #region Organization
                case "organization":
                    {
                        //DataTable dt = new DataTable();
                        //dt.Columns.Add("textfield");
                        //dt.Columns.Add("datafield");
                        //DataRow dr = dt.NewRow();
                        //dr["textfield"]="Chấp nhận";
                        //dr["datafield"]="1";
                        //dt.Rows.Add(dr);

                        //dr = dt.NewRow();
                        //dr["textfield"] = "Không chấp nhận";
                        //dr["datafield"] = "2";
                        //dt.Rows.Add(dr);DataItemControlFinder("Chấp nhận", 1));
                        //this._datasource.Add(new DataItemControlFinder("Không chấp nhận", 2));

                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã",
                            ID = "txtID",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtName",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });
                        //this.ListControl.Add("Tên chi nhánh", ControlType.TextField, DataType.String, "txtName", false, this._datasource , "DataTextField", "DataValueField");
                        //this.ListControl.Add("Tên chi nhánh", ControlType.combobox, DataType.String, "txtName",false,this._datasource,"DataTextField","DataValueField");

                        //this.ListControl.Add("Mã số thuế", ControlType.textbox, DataType.String, "txtSerialTax");
                        //this.ListControl.Add("Địa chỉ", ControlType.textbox, DataType.String, "txtAdress");

                        this.StoreName = "spOrganizationFinder";

                        this.GridFinder = new GridFinder("Danh sách chi nhánh", true);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            Header = "Mã",
                            Sortable = true,
                            DataIndex = "ORG_AUTOID",
                            RecordField = "ORG_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true,
                            datatype = RecordFieldType.Int
                        });

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clName",
                            Header = "Tên",
                            Sortable = true,
                            DataIndex = "ORG_NAME",
                            RecordField = "ORG_NAME",
                            IsReturnValue = true,
                            AutoExpandColumn = true,
                            datatype = RecordFieldType.String
                        });
                        IsEventbtn = true;
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clName",
                            Header = "Tên",
                            Sortable = true,
                            DataIndex = "OBJ_SERIALTAX",
                            RecordField = "OBJ_SERIALTAX",
                            IsReturnValue = true,
                            datatype = RecordFieldType.String
                        });
                        IsEventbtn = true;
                    }


                    break;
                #endregion

                //Create by Phongvt
                //Create date 11/03/2009
                //Edit date: 
                //Decsription: Khởi tạo Finder cho Danh sách báo giá
                #region ListQuote
                case "listquote":
                    {
                        this.ListControl.Add("Báo giá", ControlType.TextField, DataType.Int, "txtName", true);


                        DataSource.Add(new DataItem("Chấp nhận", 1));
                        DataSource.Add(new DataItem("Không chấp nhận", 2));
                        this.ListControl.Add("cbo", ControlType.Combobox, DataType.Int, "cbo", true, DataSource);

                        this.StoreName = "spFinderPaymentTerm";

                        this.GridFinder = new GridFinder("Danh sách điều khoản thanh toán", false);

                        this.GridFinder.Add("PTE_AUTOID", "Mã điều khoản thanh toán", 100, true, "PTE_AUTOID", string.Empty, "PTE_AUTOID", true);
                        this.GridFinder.Add("Tên điều khoản thanh toán", 200, true, "PTE_DESCRIPTION", string.Empty, "PTE_DESCRIPTION", true);
                    }
                    break;

                #endregion

                // Author       : Vinh
                // Created date : 25/01/2010
                // Purpose      : Tìm kiếm BOM để thêm version hoặc copy bom.    
                case "BomID":
                    #region BomID
                    {
                        ListControl.Add("BOM ID", ControlType.TextField, DataType.String, "BOM_BOMNO", true);

                        this.StoreName = "spPUBBOM_SelectByBOMID";

                        this.GridFinder.Add("BOM_AUTOID", "Mã AUTO", 100, true, "BOM_AUTOID", string.Empty, "BOM_AUTOID", true, true);//0
                        this.GridFinder.Add("BOM ID", 100, true, "BOM_BOMNO", string.Empty, "BOM_BOMNO", true);//1
                        this.GridFinder.Add("Version BOM", 50, true, "PBV_NAME", string.Empty, "PBV_NAME", true);//2
                        this.GridFinder.Add("Loại BOM", 50, true, "DOTY_NAME", string.Empty, "DOTY_NAME", true);//2
                        this.GridFinder.Add("PBV_AUTOID", "Version BOMID", 50, true, "PBV_AUTOID", string.Empty, "PBV_AUTOID", true, true);//8
                        this.GridFinder.Add("Lý do thiết lập", 100, true, "BOM_REASON", string.Empty, "BOM_REASON", true);//3       
                        this.GridFinder.Add("Ngày thiết lập", 100, true, "BOM_CREATEDATE", string.Empty, "BOM_CREATEDATE", true);//4
                        this.GridFinder.Add("Ngày Cập nhật", 100, true, "BOM_UPDATEDATE", string.Empty, "BOM_UPDATEDATE", true);//5
                        this.GridFinder.Add("BOM_LIMITQUANTITY", "Số lượng hạn mức sx", 50, true, "BOM_LIMITQUANTITY", string.Empty, "BOM_LIMITQUANTITY", true);//6
                        this.GridFinder.Add("BOM_APPDATETO", "Đến ngày", 50, true, "BOM_APPDATETO", string.Empty, "BOM_APPDATETO", true, true);//7
                        this.GridFinder.Add("BOM_APPDATEFROM", "Từ ngày", 50, true, "BOM_APPDATEFROM", string.Empty, "BOM_APPDATEFROM", true, true);//8
                        this.GridFinder.Add("BOM_APROVEDATE", "Ngày xác nhận", 50, true, "BOM_APROVEDATE", string.Empty, "BOM_APROVEDATE", true, true);//9
                        this.GridFinder.Add("ST_AUTOID", "Trạng thái", 10, true, "ST_AUTOID", string.Empty, "ST_AUTOID", true, true);//10
                        this.GridFinder.Add("BOM_DESCRIPTION", "Diễn giải", 50, true, "BOM_DESCRIPTION", string.Empty, "BOM_DESCRIPTION", true, true);//11
                        this.GridFinder.Add("UOM_AUTOID1", "Đơn vị tính 1", 50, true, "UOM_AUTOID1", string.Empty, "UOM_AUTOID1", true, true);//11
                        this.GridFinder.Add("UOM_AUTOID2", "Đơn vị tính 2", 50, true, "UOM_AUTOID2", string.Empty, "UOM_AUTOID2", true, true);//11
                        this.GridFinder.Add("OBJ_CREATEBY", "Người thiết lập", 50, true, "OBJ_CREATEBY", string.Empty, "OBJ_CREATEBY", true, true);//11
                        this.GridFinder.Add("OBJ_UPDATEBY", "Người cập nhật", 50, true, "OBJ_UPDATEBY", string.Empty, "OBJ_UPDATEBY", true, true);//11
                        this.GridFinder.Add("OBJ_APROVEBY", "Người xác nhận", 50, true, "OBJ_APROVEBY", string.Empty, "OBJ_APROVEBY", true, true);//11
                        this.GridFinder.Add("BOM_LIMITQUANTITY", "SL hạn mức sx", 50, true, "BOM_LIMITQUANTITY", string.Empty, "BOM_LIMITQUANTITY", true, true);//11
                        this.GridFinder.Add("DOTY_AUTOID", "Loại Bom", 50, true, "DOTY_AUTOID", string.Empty, "DOTY_AUTOID", true, true);//11
                        this.GridFinder.Add("PIT_AUTOID", "Mặt hàng", 50, true, "PIT_AUTOID", string.Empty, "PIT_AUTOID", true, true);//11
                        this.GridFinder.Add("BOM_QUANTITY1", "Loại Bom", 50, true, "BOM_QUANTITY1", string.Empty, "BOM_QUANTITY1", true, true);//11
                        this.GridFinder.Add("BOM_QUANTITY1", "Loại Bom", 50, true, "BOM_QUANTITY1", string.Empty, "BOM_QUANTITY1", true, true);//11
                    }
                    #endregion
                    break;

                // Author       : Vinh
                // Created date : 19/02/2010
                // Purpose      : Tìm kiếm Các mặt hàng của BOM
                case "ItemTypeNo":
                    #region ItemTypeNo
                    {
                        ListControl.Add("Mã mặt hàng", ControlType.TextField, DataType.String, "PIT_ITEMNO", true);
                        ListControl.Add("Tên mặt hàng", ControlType.TextField, DataType.String, "PIT_NAME", true);

                        this.StoreName = "SP_IC_SelectByNoandName_PUBITEMS";

                        this.GridFinder.Add("PIT_AUTOID", "Mã AUTO", 100, true, "PIT_AUTOID", string.Empty, "PIT_AUTOID", true, true);//0
                        this.GridFinder.Add("Mã mặt hàng", 50, true, "PIT_ITEMNO", string.Empty, "PIT_ITEMNO", true);//1
                        this.GridFinder.Add("Tên mặt hàng", 100, true, "PIT_NAME", string.Empty, "PIT_NAME", true);//2
                        this.GridFinder.Add("Diễn giải", 50, true, "PIT_DESCRIPTION", string.Empty, "PIT_DESCRIPTION", true);//2
                        this.GridFinder.Add("PIT_UOMID1", "Đơn vị tính 1", 100, true, "PIT_UOMID1", string.Empty, "PIT_UOMID1", true, true);//0
                        this.GridFinder.Add("PIT_UOMID2", "Đơn vị tính 2", 100, true, "PIT_UOMID2", string.Empty, "PIT_UOMID2", true, true);//0
                        this.GridFinder.Add("PK_AUTOID", "Quy cách bao bì", 100, true, "PK_AUTOID", string.Empty, "PK_AUTOID", true, true);//0
                    }
                    #endregion
                    break;


                //Create by Phongvt
                //Create date 11/03/2009
                //Edit date: 
                //Decsription: Khởi tạo Finder cho danh sách Item
                #region Items
                case "items":
                    {
                        ControlFinder ctrl2 = new ControlFinder("Danh mục sản phẩm", ControlType.HiddenField, DataType.String, "txtItemCate", true);
                        ctrl2.QueryString = "pic";
                        ListControl.Add(ctrl2);
                        ControlFinder ctrl = new ControlFinder("Loại sản phẩm", ControlType.HiddenField, DataType.String, "txtItemType", true);
                        ctrl.QueryString = "itemtype";

                        ControlFinder curautoid = new ControlFinder("Loại tiền", ControlType.HiddenField, DataType.String, "txtCUR_AUTOID", true);
                        curautoid.QueryString = "curautoid";

                        this.ListControl.Add("Mã sản phẩm", ControlType.TextField, DataType.String, "txtItemId", true);

                        ListControl.Add(ctrl);

                        this.ListControl.Add("Tên sản phẩm", ControlType.TextField, DataType.String, "txtItemName", true);
                        ListControl.Add(curautoid);



                        this.StoreName = "spFinderItems";

                        this.GridFinder = new GridFinder("Danh sách sản phẩm", false);
                        //0
                        this.GridFinder.Add("PIT_AUTOID", "Mã AUTO", 100, true, "PIT_AUTOID", string.Empty, "PIT_AUTOID", true, true);
                        //1
                        this.GridFinder.Add("Mã sản phẩm", 100, true, "PIT_ITEMNO", string.Empty, "PIT_ITEMNO", true);
                        //2
                        this.GridFinder.Add("Tên sản phẩm", 200, true, "PIT_NAME", string.Empty, "PIT_NAME", true);
                        //3
                        this.GridFinder.Add("PIT_UOMID1", "Mã đơn vị tính", 0, true, "PIT_UOMID1", string.Empty, "PIT_UOMID1", true, true);
                        //4
                        this.GridFinder.Add("WH_AUTOID", "Mã kho mặc định", 200, true, "WH_AUTOID", string.Empty, "WH_AUTOID", true, true);
                        //5
                        this.GridFinder.Add("PIC_AUTOID", "Mã phân loại", 0, true, "PIC_AUTOID", string.Empty, "PIC_AUTOID", true, true);
                        //6
                        this.GridFinder.Add("PK_AUTOID", "Mã quy cách bao bì", 0, true, "PK_AUTOID", string.Empty, "PK_AUTOID", true, true);
                        //7
                        this.GridFinder.Add("PIT_SOPRICE1", "Đơn giá bán", 200, true, "PIT_SOPRICE1", string.Empty, "PIT_SOPRICE1", true, true);
                        //8
                        this.GridFinder.Add("PIT_POPRICE", "Đơn giá mua", 200, true, "PIT_POPRICE", string.Empty, "PIT_POPRICE", true, true);
                        //9
                        this.GridFinder.Add("TR_AUTOID", "", 100, false, "TR_AUTOID", string.Empty, "TR_AUTOID", true, true);
                        //10
                        this.GridFinder.Add("PIT_VATTAXPER", "", 100, false, "PIT_VATTAXPER", string.Empty, "PIT_VATTAXPER", true, true);
                        //11
                        this.GridFinder.Add("PIT_EXPORTTAXPER", "", 100, false, "PIT_EXPORTTAXPER", string.Empty, "PIT_EXPORTTAXPER", true, true);
                        this.GridFinder.Add("PIT_IMPORTTAXPER", "", 100, false, "PIT_IMPORTTAXPER", string.Empty, "PIT_IMPORTTAXPER", true, true);
                        this.GridFinder.Add("PIT_EXCISETAXPER", "", 100, false, "PIT_EXCISETAXPER", string.Empty, "PIT_EXCISETAXPER", true, true);
                        //12
                        this.GridFinder.Add("PIT_POPERREDUCE", "", 100, false, "PIT_POPERREDUCE", string.Empty, "PIT_POPERREDUCE", true, true);
                        //13
                        this.GridFinder.Add("PIT_SOPERREDUCE", "", 100, false, "PIT_SOPERREDUCE", string.Empty, "PIT_SOPERREDUCE", true, true);
                        //14                       
                        this.GridFinder.Add("PIT_PODESCRIPTION", "", 100, false, "PIT_PODESCRIPTION", string.Empty, "PIT_PODESCRIPTION", true, true);
                        //17
                        this.GridFinder.Add("PIT_SODESCRIPTION", "", 100, false, "PIT_SODESCRIPTION", string.Empty, "PIT_SODESCRIPTION", true, true);
                        //18
                        this.GridFinder.Add("PIC_AUTOID", "", 100, false, "PIC_AUTOID", string.Empty, "PIC_AUTOID", true, true);
                        //19
                        this.GridFinder.Add("PIT_ASSETACCOUNT", "", 100, false, "PIT_ASSETACCOUNT", string.Empty, "PIT_ASSETACCOUNT", true, true);
                        //20
                        this.GridFinder.Add("CUR_AUTOID", "", 100, false, "CUR_AUTOID", string.Empty, "CUR_AUTOID", true, true);


                        this.GridFinder.Add("Kho mặc định", 200, true, "WH_NAME", string.Empty, "WH_NAME", false);
                        this.GridFinder.Add("Phân loại", 0, true, "PIC_NAME", string.Empty, "PIC_NAME", false);
                        this.GridFinder.Add("Quy cách bao bì", 0, true, "PK_NAME", string.Empty, "PK_NAME", false);
                        this.GridFinder.Add("Đơn vị tính", 200, true, "UOM_NAME", string.Empty, "UOM_NAME", false);

                    }
                    break;

                #endregion

                //Create by Phongvt
                //Create date 27/03/2009
                //Edit date: 
                //Decsription: Khởi tạo Finder cho Tỷ giá
                #region CurRate
                case "currate":
                    {
                        DataSet dsCURRENCY = new DataSet();
                        dsCURRENCY = PUBCURRENCYDAO.GetAllACTIVEPUBCURRENCY();
                        DataRow dr = dsCURRENCY.Tables[0].Rows[0];

                        for (int i = 0; i < dsCURRENCY.Tables[0].Rows.Count; i++)
                        {
                            DataSource.Add(new DataItem(dsCURRENCY.Tables[0].Rows[i]["CUR_NAME"], dsCURRENCY.Tables[0].Rows[i]["CUR_AUTOID"]));
                        }
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tiền gốc",
                            ID = "cboPrincipalMoney",
                            ControlType = ControlType.Combobox,
                            DataType = DataType.Int,
                            IsControlGetValue = true,
                            DataSource = DataSource,
                            DefaultValue = "1"

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tiền chuyển đổi",
                            ID = "cboConvertMoney",
                            ControlType = ControlType.Combobox,
                            DataType = DataType.Int,
                            IsControlGetValue = true,
                            DataSource = DataSource,
                            DefaultValue = "1"

                        });

                        this.StoreName = "spFinderCurrencyRate";

                        this.GridFinder = new GridFinder(" Tỷ giá ", true);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clCurrencyRate",
                            Header = "Tỷ giá",
                            Sortable = true,
                            DataIndex = "CRRD_CURRENTCYRATE",
                            RecordField = "CRRD_CURRENTCYRATE",
                            IsReturnValue = true,
                            AutoExpandColumn = true,
                            Renderer = "return setView(value)",
                            datatype = RecordFieldType.Float
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clCreatedate",
                            Header = "Ngày tạo",
                            Sortable = true,
                            DataIndex = "CRRD_CREATEDATE",
                            RecordField = "CRRD_CREATEDATE",
                            IsReturnValue = true,
                            Renderer = "return fmDateTime(value);",
                            datatype = RecordFieldType.Date,
                            Width = 200
                        });
                        IsEventbtn = true;
                    }
                    break;
                #endregion

                //Create by Phongvt
                //Create date 27/03/2009
                //Edit date: 
                //Decsription: Khởi tạo Finder cho SO Detail
                #region SO Detail
                case "sodetail":
                    {
                        this.ListControl.Add("Mã đơn hàng", ControlType.TextField, DataType.String, "txtItemId", true);

                        this.StoreName = "spFinderSODeatail";

                        this.GridFinder = new GridFinder("Chi tiết đơn hàng", true);
                        this.GridFinder.Add("Tỷ giá ", 100, true, "CRRD_CURRENTCYRATE", string.Empty, "CRRD_CURRENTCYRATE", true);
                        this.GridFinder.Add("Ngày ", 200, true, "CRRD_CREATEDATE", string.Empty, "CRRD_CREATEDATE");
                    }
                    break;
                #endregion

                //Create by Phongvt
                //Create date 27/03/2009
                //Edit date: 
                //Decsription: Khởi tạo Finder lay danh sach Invoice cho PO
                #region List Invoice
                case "listinvoice":
                    {
                        this.ListControl.Add("Mã hóa đơn", ControlType.TextField, DataType.String, "txtInvoiceID", true);

                        this.StoreName = "spFinderListInvoice";

                        this.GridFinder = new GridFinder("Danh sách hóa đơn", true);
                        this.GridFinder.Add("Mã hóa đơn", 100, true, "CRRD_CURRENTCYRATE", string.Empty, "CRRD_CURRENTCYRATE", true);
                        this.GridFinder.Add("Ngày tạo ", 200, true, "CRRD_CREATEDATE", string.Empty, "CRRD_CREATEDATE");
                    }
                    EventbtnNews = "openPageForFinder('CMINVOIEN', 'Hóa Đơn', '/Common/Invoice.aspx?OFSYSTEM=3&OFSUBSYSTEM=-1', true)";
                    IsEventbtn = true;
                    break;
                #endregion
                //Create by Phongvt
                //Create date 12/08/2009
                //Edit date: 12/08/2009
                //Decsription: Khởi tạo Finder cho Tỉnh thành/ quoc gia
                #region Province/Country
                case "provincecountry":
                    {
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã",
                            ID = "txtID",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtName",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tỉnh thành",
                            ID = "txtProvince",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Quốc gia",
                            ID = "txtCountry",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });
                        this.StoreName = "spFinderProvinceCountry";

                        this.GridFinder = new GridFinder("Danh sách tỉnh thành quốc gia", false);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            Header = "Mã",
                            Sortable = true,
                            DataIndex = "PRV_AUTOID",
                            RecordField = "PRV_AUTOID",
                            IsReturnValue = true,
                            AutoExpandColumn = true,
                            IsHidden = true,
                            datatype = RecordFieldType.Int
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clProvince",
                            Header = "Tỉnh thành",
                            Sortable = true,
                            DataIndex = "PRV_NAME",
                            RecordField = "PRV_NAME",
                            IsReturnValue = true,
                            AutoExpandColumn = true,
                            datatype = RecordFieldType.String
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clCountry",
                            Header = "Quốc gia",
                            Sortable = true,
                            DataIndex = "TRY_NAME",
                            RecordField = "TRY_NAME",
                            IsReturnValue = true,
                            Width = 200,
                            datatype = RecordFieldType.String
                        });
                        IsEventbtn = true;
                    }
                    break;
                #endregion

                //============================================================================================================
                case "invoice":
                    #region Invoice
                    {
                        this.ListControl.Add("DocumentID", ControlType.NumberField, DataType.Int, "txtID", true);
                        this.ListControl.Add("Số CT", ControlType.TextField, DataType.String, "txtDocumentNum");
                        this.ListControl.Add("Số HD", ControlType.TextField, DataType.String, "txtInvoiceNum");
                        this.ListControl.Add("Diễn giải", ControlType.TextField, DataType.String, "txtDes");
                        this.ListControl.Add("Ngày HD", ControlType.DateField, DataType.String, "txtDocumentDate");
                        this.ListControl.Add("Đối tượng", ControlType.TextField, DataType.String, "txtObject");
                        this.ListControl.Add("Tổng tiền", ControlType.NumberField, DataType.String, "txtAmount");
                        this.ListControl.Add("Tổng tiền trước thuế", ControlType.NumberField, DataType.String, "txtBeAmount");
                        this.ListControl.Add("MST", ControlType.TextField, DataType.String, "txtTaxSerial");
                        this.ListControl.Add("Cho PO/SO", ControlType.TextField, DataType.String, "txtFORPOSO");

                        this.StoreName = "spInvoiceSearch";

                        this.GridFinder = new GridFinder("Danh sách hóa đơn", true);
                        //0
                        this.GridFinder.Add("IV_DOCUMENTID", "DocumentID", 100, true, "IV_DOCUMENTID", string.Empty, "IV_DOCUMENTID", true);
                        //1
                        this.GridFinder.Add("Số CT", 200, true, "IV_DOCUMENTNUM", string.Empty, "IV_DOCUMENTNUM", true);
                        //2
                        this.GridFinder.Add("Số HD", 200, true, "IV_INVOICENUM", string.Empty, "IV_INVOICENUM", true);
                        //3
                        this.GridFinder.Add("Diễn giải", 100, true, "IV_DESCRIPTION", string.Empty, "IV_DESCRIPTION", true);
                        //4
                        this.GridFinder.Add("Ngày HD", 100, true, "DOC_DOCUMENTDATE", "return fmDateTime(value);", "DOC_DOCUMENTDATE", true, RecordFieldType.Date);
                        //5
                        this.GridFinder.Add("Đối tượng", 100, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        //6
                        this.GridFinder.Add("Tổng tiền", 100, true, "IV_AMOUNT", "return GetView(value, ',')", "IV_AMOUNT", true);
                        //7
                        this.GridFinder.Add("Tổng tiền trước thuế", 100, true, "IV_BEAMOUNT", string.Empty, "IV_BEAMOUNT", true);
                        //8
                        this.GridFinder.Add("Cho PO/SO", 100, true, "ForPOSO", string.Empty, "ForPOSO", true);
                        //9
                        this.GridFinder.Add("MST", 100, true, "OBJ_SERIALTAX", string.Empty, "OBJ_SERIALTAX", true);
                        //10
                        this.GridFinder.Add("Chứng từ", 200, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        //11
                        this.GridFinder.Add("Diễn giải chứng từ", 200, true, "DOC_DESCRIPTION", string.Empty, "DOC_DESCRIPTION", true);

                        //this.GridFinder.Add("DOC_DOCUMENTNO", "DOC_DOCUMENTNO", 100, true, "DOC_DOCUMENTNO", string.Empty, "IV_DOCUMENTID", true);



                    }
                    #endregion
                    break;

                case "declaration":
                    #region Declaration
                    {
                        this.ListControl.Add("Mã tờ khai", ControlType.NumberField, DataType.Int, "txtID", true);
                        this.ListControl.Add("Diễn giải", ControlType.TextField, DataType.String, "txtDes");
                        this.ListControl.Add("Ngày lập", ControlType.DateField, DataType.String, "txtDateCreate");
                        this.ListControl.Add("Đơn hàng bán", ControlType.TextField, DataType.String, "txtInvoice");
                        this.ListControl.Add("Tiền nguyên tệ", ControlType.TextField, DataType.String, "txtAmount");
                        this.ListControl.Add("Tiền hoạch toán", ControlType.TextField, DataType.String, "txtAfAmount");
                        this.ListControl.Add("Đối tượng", ControlType.DateField, DataType.String, "txtObject");
                        this.ListControl.Add("% Chiết khấu", ControlType.TextField, DataType.String, "txtTaxSerial");


                        this.StoreName = "spDeclarationSearch";

                        this.GridFinder = new GridFinder("Danh sách tờ khai", true);

                        this.GridFinder.Add("DEC_DOCUMENTID", "Mã tờ khai", 100, true, "DEC_DOCUMENTID", string.Empty, "DEC_DOCUMENTID", true);
                        this.GridFinder.Add("Diễn giải", 200, true, "DOC_DESCRIPTION", string.Empty, "DOC_DESCRIPTION", true);
                        this.GridFinder.Add("Ngày lập", 200, true, "DEC_CREATEDATE", string.Empty, "DEC_CREATEDATE", true);
                        this.GridFinder.Add("Đơn hàng bán", 100, true, "SELL_INVOICE", string.Empty, "SELL_INVOICE", true);
                        this.GridFinder.Add("Tiền hoạch toán", 100, true, "DEC_AMOUNT", string.Empty, "DEC_AMOUNT", true);
                        this.GridFinder.Add("Tiền nguyên tệ", 100, true, "DEC_AFAMOUNT", string.Empty, "DEC_AFAMOUNT", true);
                        this.GridFinder.Add("Đối tượng", 100, true, "DEC_OBJECTNAME", string.Empty, "DEC_OBJECTNAME", true);
                        this.GridFinder.Add("% Chiết khấu", 100, true, "DEC_PERDISCOUNT", string.Empty, "DEC_PERDISCOUNT", true);

                    }
                    #endregion
                    break;

                /*
                 * Create by: Pham Tuan Anh
                 * 9 methods
                 * create from date: 2009-01-17 12:00
                 * */
                case "po_so":
                    #region po_so
                    {

                        this.ListControl.Add("Người tạo", ControlType.NumberField, DataType.String, "txtCreateBy");
                        this.ListControl.Add("Mã chứng từ", ControlType.TextField, DataType.String, "txtDocumentNo");
                        this.ListControl.Add("Số tiền từ", ControlType.NumberField, DataType.String, "txtFromAmount");
                        this.ListControl.Add("Đến", ControlType.NumberField, DataType.String, "txtToAmount");
                        this.ListControl.Add("Ngày tạo từ", ControlType.DateField, DataType.String, "dtFromdate");
                        this.ListControl.Add("Đến", ControlType.DateField, DataType.String, "dtTodate");

                        this.StoreName = "spFinderPOSOforInvoice";

                        this.GridFinder = new GridFinder("Danh sách PO/SO", true);

                        this.GridFinder.Add("DOC_DOCUMENTID", "Document ID", 100, true, "DOC_DOCUMENTID", string.Empty, "DOC_DOCUMENTID", true);
                        this.GridFinder.Add("Mã chứng từ", 100, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        this.GridFinder.Add("Loại chứng từ", 200, true, "TYPE", string.Empty, "TYPE", true);
                        this.GridFinder.Add("Ngày tạo", 200, true, "DOC_CREATEDATE", string.Empty, "DOC_CREATEDATE", true);
                        this.GridFinder.Add("Đối tượng mua/bán", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("Tổng tiền", 100, true, "POD_TOTALAMOUNT", string.Empty, "POD_TOTALAMOUNT", true);
                        this.GridFinder.Add("Kỳ tài chính", 100, true, "FICI_NAME", string.Empty, "FICI_NAME", true);
                    }
                    #endregion
                    break;
                case "so":
                    #region so
                    {
                        //init control
                        this.ListControl.Add("Mã nhân viên", ControlType.NumberField, DataType.Int, "txtCreateBy");
                        this.ListControl.Add("Đối tượng mua", ControlType.TextField, DataType.String, "txtObjectName");
                        this.ListControl.Add("Giá từ", ControlType.NumberField, DataType.Int, "txtFromPrice");
                        this.ListControl.Add("Đến", ControlType.NumberField, DataType.Int, "txtToPrice");
                        this.ListControl.Add("Mã chứng từ", ControlType.TextField, DataType.String, "txtDocumentNo", true);
                        List<FINANCYCICLE> lstFinanCycle = FINANCYCICLEDAO.GetAllFINANCYCICLENotClose();
                        for (int i = 0; i < lstFinanCycle.Count; i++)
                        {
                            DataSource.Add(new DataItem(lstFinanCycle[i].FICI_NAME, lstFinanCycle[i].FICI_AUTOID));
                        }
                        this.ListControl.Add("Kỳ tài chính", ControlType.Combobox, DataType.Int, "cboFinanCycle", true, DataSource);
                        ControlFinder IsReturn = new ControlFinder("", ControlType.HiddenField, DataType.String, "txtIsreturn");
                        IsReturn.DefaultValue = "False";// SO
                        this.ListControl.Add(IsReturn);

                        //store DB
                        this.StoreName = "spFinderSOforCM";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách đơn hàng", true);

                        this.GridFinder.Add("SO_DOCUMENTID", "Mã hệ thống", 100, true, "SO_DOCUMENTID", string.Empty, "SO_DOCUMENTID", true);
                        this.GridFinder.Add("Mã chứng từ", 100, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        this.GridFinder.Add("Đối tượng mua", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME");
                        this.GridFinder.Add("Giá", 100, true, "SALD_TOTALAMOUNT", string.Empty, "SALD_TOTALAMOUNT");
                        this.GridFinder.Add("Kỳ tài chính", 100, true, "FICI_NAME", string.Empty, "FICI_NAME");
                    }
                    #endregion
                    break;

                case "returnso":
                    #region returnso
                    {
                        //init control
                        this.ListControl.Add("Mã nhân viên", ControlType.TextField, DataType.String, "txtCreateBy");
                        this.ListControl.Add("Đối tượng mua", ControlType.TextField, DataType.String, "txtObjectName");
                        this.ListControl.Add("Giá từ", ControlType.NumberField, DataType.Int, "txtFromPrice");
                        this.ListControl.Add("Đến", ControlType.NumberField, DataType.Int, "txtToPrice");
                        this.ListControl.Add("Mã chứng từ", ControlType.TextField, DataType.String, "txtDocumentID", true);
                        this.ListControl.Add("Kỳ tài chính", ControlType.Combobox, DataType.String, "cboFinanceCycle");
                        ControlFinder IsReturn = new ControlFinder("", ControlType.HiddenField, DataType.String, "txtIsreturn");
                        IsReturn.DefaultValue = "True";// Return SO
                        this.ListControl.Add(IsReturn);

                        //store DB
                        this.StoreName = "spSearchSOforCM";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách hàng bán trả lại", true);

                        this.GridFinder.Add("SO_DOCUMENTID", "Mã chứng từ", 100, true, "SO_DOCUMENTID", string.Empty, "SO_DOCUMENTID", true);
                        this.GridFinder.Add("Đối tượng mua", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME");
                        this.GridFinder.Add("Giá", 100, true, "SALD_TOTALAMOUNT", string.Empty, "SALD_TOTALAMOUNT");
                        this.GridFinder.Add("Kỳ tài chính", 100, true, "FICI_NAME", string.Empty, "FICI_NAME");
                    }
                    #endregion
                    break;

                case "po":
                    #region po
                    {
                        //init control
                        this.ListControl.Add("Mã nhân viên", ControlType.TextField, DataType.String, "txtCreateBy");
                        this.ListControl.Add("Đối tượng bán", ControlType.TextField, DataType.String, "txtObjectName");
                        this.ListControl.Add("Giá từ", ControlType.NumberField, DataType.Int, "txtFromPrice");
                        this.ListControl.Add("Đến", ControlType.NumberField, DataType.Int, "txtToPrice");
                        this.ListControl.Add("Mã chứng từ", ControlType.TextField, DataType.String, "txtDocumentID", true);
                        List<FINANCYCICLE> lstFinanCycle = FINANCYCICLEDAO.GetAllFINANCYCICLENotClose();
                        for (int i = 0; i < lstFinanCycle.Count; i++)
                        {
                            DataSource.Add(new DataItem(lstFinanCycle[i].FICI_NAME, lstFinanCycle[i].FICI_AUTOID));
                        }
                        this.ListControl.Add("Kỳ tài chính", ControlType.Combobox, DataType.String, "cboFinanCycle", true, DataSource);

                        ControlFinder IsReturn = new ControlFinder("", ControlType.HiddenField, DataType.String, "txtIsreturn");
                        IsReturn.DefaultValue = "False";// PO
                        this.ListControl.Add(IsReturn);

                        //store DB
                        this.StoreName = "spFinderPOforCM";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách đơn hàng", true);

                        this.GridFinder.Add("PURO_DOCUMENTID", "AutoID", 100, true, "PURO_DOCUMENTID", string.Empty, "PURO_DOCUMENTID", true);
                        this.GridFinder.Add("Mã chứng từ", 100, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        this.GridFinder.Add("Đối tượng bán", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME");
                        this.GridFinder.Add("Giá", 100, true, "POD_TOTALAMOUNT", string.Empty, "POD_TOTALAMOUNT");
                        this.GridFinder.Add("Kỳ tài chính", 100, true, "FICI_NAME", string.Empty, "FICI_NAME");
                    }
                    #endregion
                    break;
                case "invoiceforap":
                    #region invoiceforap
                    {
                        //init control
                        this.ListControl.Add("Đến", ControlType.NumberField, DataType.Int, "txtToPrice");
                        this.ListControl.Add("Giá từ", ControlType.NumberField, DataType.Int, "txtFromPrice");
                        this.ListControl.Add("Đến ngày", ControlType.DateField, DataType.Date, "txtToDate");
                        this.ListControl.Add("Từ ngày", ControlType.DateField, DataType.Date, "txtFromDate");
                        this.ListControl.Add("Mã hóa đơn", ControlType.TextField, DataType.String, "txtInvoiceNum", true);
                        ControlFinder IsReturn = new ControlFinder("", ControlType.HiddenField, DataType.String, "txtType");
                        IsReturn.DefaultValue = "0";// AP
                        this.ListControl.Add(IsReturn);
                        ControlFinder SupplierID = new ControlFinder("", ControlType.HiddenField, DataType.Int, "SupplierID", true);
                        SupplierID.QueryString = "supplierid";// 
                        this.ListControl.Add(SupplierID);
                        //store DB
                        this.StoreName = "SP_INVOICEforAP";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách hóa đơn công nợ phải trả", true);

                        this.GridFinder.Add("IV_DOCUMENTID", "Mã hóa đơn", 100, true, "DOCUMENTID", string.Empty, "DOCUMENTID", true, true);
                        this.GridFinder.Add("OBJ_AUTOID", "Mã đối tượng", 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        this.GridFinder.Add("Số chứng từ", 200, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        this.GridFinder.Add("Số hóa đơn", 200, true, "IV_DOCUMENTNUM", string.Empty, "IV_DOCUMENTNUM", true);
                        this.GridFinder.Add("Diễn giải", 100, true, "DOC_DESCRIPTION", string.Empty, "DOC_DESCRIPTION", true);
                        this.GridFinder.Add("Ngày hóa đơn", 100, true, "DOC_DOCUMENTDATE", "return fmDateTime(value);", "DOC_DOCUMENTDATE", true, RecordFieldType.Date);
                        this.GridFinder.Add("Tổng tiền", 100, true, "IV_AMOUNT", string.Empty, "IV_AMOUNT", true);
                        this.GridFinder.Add("Đối tượng", 100, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("Mã số thuế", 100, true, "OBJ_TAXID", string.Empty, "OBJ_TAXID", true);
                    }
                    #endregion
                    break;
                case "PaymentMethod":
                    #region PaymentMethod
                    {
                        //init control
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtName",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            IsControlGetValue = true,

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Từ ngày",
                            ID = "dfFromDate",
                            ControlType = ControlType.DateField,
                            DataType = DataType.Date,
                            IsControlGetValue = true,

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Đến ngày",
                            ID = "dfToDate",
                            ControlType = ControlType.DateField,
                            DataType = DataType.Date,
                            IsControlGetValue = true,

                        });

                        //store DB
                        this.StoreName = "spSearchPaymentMethodforCM";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách phương thức thanh toán", true);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            Header = "Mã",
                            Sortable = true,
                            DataIndex = "PRV_AUTOID",
                            RecordField = "PRV_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true,
                            datatype = RecordFieldType.Int
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clName",
                            Header = "Tên",
                            Sortable = true,
                            DataIndex = "PAY_NAME",
                            RecordField = "PAY_NAME",
                            IsReturnValue = true,
                            datatype = RecordFieldType.String
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clDescription",
                            Header = "Tên",
                            Sortable = true,
                            DataIndex = "PAY_DESCRIPTION",
                            RecordField = "PAY_DESCRIPTION",
                            IsReturnValue = true,
                            datatype = RecordFieldType.String
                        });
                        IsEventbtn = true;
                    }
                    #endregion
                    break;
                case "ProposePaymentandInvoice":
                    #region PaymentMethod
                    {
                        //init control
                        this.ListControl.Add("Mã nhân viên", ControlType.NumberField, DataType.Int, "txtCreateby", true);
                        this.ListControl.Add("Số tiền từ", ControlType.NumberField, DataType.Float, "dtFromAmount");
                        this.ListControl.Add("Đến", ControlType.NumberField, DataType.Float, "dtToAmount");
                        this.ListControl.Add("Mã đề xuất", ControlType.NumberField, DataType.Int, "txtDocumentID");
                        ControlFinder IsType = new ControlFinder("", ControlType.HiddenField, DataType.String, "txtType");
                        IsType.DefaultValue = "1";// PO
                        this.ListControl.Add(IsType);

                        //store DB
                        this.StoreName = "spSearchProposePaymentforCM";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách hóa đơn của đề xuất thanh toán", true);

                        this.GridFinder.Add("PPAY_DOCUMENTID", "Mã đề xuất", 100, true, "PPAY_DOCUMENTID", string.Empty, "PPAY_DOCUMENTID", true);
                        this.GridFinder.Add("Mã hóa đơn", 200, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        this.GridFinder.Add("Số tiền đề xuất/hóa đơn", 200, true, "TOTALAMOUNT", string.Empty, "TOTALAMOUNT");
                        this.GridFinder.Add("Số tiền còn lại (hóa đơn)", 200, true, "BALANCE", string.Empty, "BALANCE");
                        this.GridFinder.Add("Người lập đề xuất", 100, true, "DOC_CREATEBY", string.Empty, "DOC_CREATEBY");
                        this.GridFinder.Add("Ngày tạo", 200, true, "DOC_CREATEDATE", string.Empty, "DOC_CREATEDATE");
                        this.GridFinder.Add("Ngày duyệt", 200, true, "DOC_APPROVEDATE", string.Empty, "DOC_APPROVEDATE");
                    }
                    #endregion
                    break;

                case "ReturnSOorPO0":
                    #region ReturnSO
                    {
                        ReturnSOorPO(0);
                    }
                    #endregion
                    break;
                case "ReturnSOorPO1":
                    #region ReturnPO
                    {
                        ReturnSOorPO(1);
                    }
                    #endregion
                    break;
                case "ProposePaymentCM0":
                    #region ProposePaymentCM Receipt
                    {
                        ProposePaymentCM(0);
                    }
                    #endregion
                    break;
                case "ProposePaymentCM1":
                    #region ProposePaymentCM Payment
                    {
                        ProposePaymentCM(1);
                    }
                    #endregion
                    break;
                case "DocumentForApportion":
                    #region DocumentForApportion
                    {
                        //init control
                        this.ListControl.Add("Mã chứng từ", ControlType.TextField, DataType.Int, "txtDocmuentNo", true);
                        this.ListControl.Add("Mã nhân viên tạo", ControlType.NumberField, DataType.Float, "txtCreateby");
                        this.ListControl.Add("Định khoản từ", ControlType.DateField, DataType.Float, "dtFromdate");
                        this.ListControl.Add("Đến", ControlType.DateField, DataType.Int, "dtTodate");
                        List<FINANCYCICLE> lstFinanCycle = FINANCYCICLEDAO.GetAllFINANCYCICLENotClose();
                        for (int i = 0; i < lstFinanCycle.Count; i++)
                        {
                            DataSource.Add(new DataItem(lstFinanCycle[i].FICI_NAME, lstFinanCycle[i].FICI_AUTOID));
                        }
                        this.ListControl.Add("Kỳ tài chính", ControlType.Combobox, DataType.String, "cboFinanCycle", true, DataSource);
                        //store DB
                        this.StoreName = "spFinderDocumentforApportion";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách chứng từ gốc cần phân bổ", true);

                        this.GridFinder.Add("DOCUMENTID", "DOCUMENTID", 100, true, "DOC_DOCUMENTID", string.Empty, "DOC_DOCUMENTID", true);
                        this.GridFinder.Add("ENTRYID", "Mã định khoản", 100, true, "GLE_ENTRYID", string.Empty, "GLE_ENTRYID", true);
                        this.GridFinder.Add("Mã chứng từ", 200, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        this.GridFinder.Add("Ngày định khoản", 200, true, "DOC_CREATEDATE", string.Empty, "DOC_CREATEDATE");
                        this.GridFinder.Add("Người tạo", 200, true, "DOC_CREATEBY", string.Empty, "DOC_CREATEBY");
                        this.GridFinder.Add("Tổng tiền", 100, true, "GLE_TOTALAMOUNT", string.Empty, "GLE_TOTALAMOUNT", true);
                    }
                    #endregion
                    break;
                case "RefDocument":
                    #region RefDocument
                    {
                        //init control
                        this.ListControl.Add("Mã chứng từ", ControlType.TextField, DataType.String, "txtDocmuentNo", true);
                        this.ListControl.Add("Mã nhân viên tạo", ControlType.NumberField, DataType.Float, "txtCreateby");
                        this.ListControl.Add("Định khoản từ", ControlType.DateField, DataType.Float, "dtFromdate");
                        this.ListControl.Add("Đến", ControlType.DateField, DataType.Int, "dtTodate");
                        List<FINANCYCICLE> lstFinanCycle = FINANCYCICLEDAO.GetAllFINANCYCICLENotClose();
                        for (int i = 0; i < lstFinanCycle.Count; i++)
                        {
                            DataSource.Add(new DataItem(lstFinanCycle[i].FICI_NAME, lstFinanCycle[i].FICI_AUTOID));
                        }
                        this.ListControl.Add("Kỳ tài chính", ControlType.Combobox, DataType.String, "cboFinanCycle", true, DataSource);
                        //store DB
                        this.StoreName = "spFinderRefDocument";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách chứng từ ", true);

                        this.GridFinder.Add("DOCUMENTID", "DOCUMENTID", 100, true, "DOC_DOCUMENTID", string.Empty, "DOC_DOCUMENTID", true);
                        this.GridFinder.Add("Mã chứng từ", 200, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        this.GridFinder.Add("Ngày tạo", 200, true, "DOC_CREATEDATE", string.Empty, "DOC_CREATEDATE");
                        this.GridFinder.Add("Người tạo", 200, true, "DOC_CREATEBY", string.Empty, "DOC_CREATEBY");

                    }
                    #endregion
                    break;
                case "ContractforApportion":
                    #region ContractforApportion
                    {
                        //init control
                        this.ListControl.Add("Mã hợp đồng", ControlType.TextField, DataType.Int, "txtContractNo", true);
                        this.ListControl.Add("Ngày ký từ", ControlType.DateField, DataType.Float, "dtFromdate");
                        this.ListControl.Add("Đến", ControlType.DateField, DataType.Float, "dtTodate");
                        this.ListControl.Add("Diễn giải", ControlType.TextField, DataType.Int, "txtDescription");
                        //ControlFinder ctrlCur = new ControlFinder("Loại tiền", ControlType.HiddenField, DataType.Int, "txtCurency", true);
                        //ctrlCur.QueryString = "curautoid";
                        //this.ListControl.Add(ctrlCur);

                        List<PUBCURRENCY> lstCur = PUBCURRENCYDAO.GetAllPUBCURRENCY();
                        for (int i = 0; i < lstCur.Count; i++)
                        {
                            DataSource.Add(new DataItem(lstCur[i].CUR_NAME, lstCur[i].CUR_AUTOID));
                        }
                        DataSource.Insert(0, new DataItem("Tất cả", "-1"));

                        this.ListControl.Add("Loại tiền", ControlType.Combobox, DataType.String, "cboCur", false, DataSource);

                        //store DB
                        this.StoreName = "spFinderContractforApportion";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách hợp đồng", true);

                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "COT_DOCUMENTID", string.Empty, "COT_DOCUMENTID", true, true);
                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "DOCA_DOCUMENTID", string.Empty, "DOCA_DOCUMENTID", true, true);
                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "PAY_AUTOID", string.Empty, "PAY_AUTOID", true, true);
                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "PTE_AUTOID", string.Empty, "PTE_AUTOID", true, true);
                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "CTG_AUTOID", string.Empty, "CTG_AUTOID", true, true);
                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "CUR_AUTOID", string.Empty, "CUR_AUTOID", true, true);
                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "ST_AUTOID", string.Empty, "ST_AUTOID", true, true);
                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "COT_CONTRACTTYPE", string.Empty, "COT_CONTRACTTYPE", true, true);
                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "BAK_AUTOID", string.Empty, "BAK_AUTOID", true, true);
                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "POS_AUTOID", string.Empty, "POS_AUTOID", true, true);
                        this.GridFinder.Add("Mã hợp đồng", 200, true, "DOCA_DOCUMENTNO", string.Empty, "DOCA_DOCUMENTNO", true);
                        this.GridFinder.Add("Loại tiền", 100, true, "CUR_NAME", string.Empty, "CUR_NAME", true);
                        this.GridFinder.Add("Ngày ký", 200, true, "COT_ASIGNDATE", "return fmDateTime(value);", "COT_ASIGNDATE", true);
                        this.GridFinder.Add("Ngày hết hạn", 200, true, "COT_EXPIREDATE", "return fmDateTime(value);", "COT_EXPIREDATE", true);
                        this.GridFinder.Add("Diễn giải", 100, true, "COT_DESCRIPTION", string.Empty, "COT_DESCRIPTION", true);
                    }
                    #endregion
                    break;
                case "contractwithcurrency":
                    #region contractwithcurrency
                    {
                        //init control
                        this.ListControl.Add("Mã hợp đồng", ControlType.TextField, DataType.Int, "txtContractNo", true);
                        this.ListControl.Add("Ngày ký từ", ControlType.DateField, DataType.Float, "dtFromdate");
                        this.ListControl.Add("Đến", ControlType.DateField, DataType.Float, "dtTodate");
                        this.ListControl.Add("Diễn giải", ControlType.TextField, DataType.Int, "txtDescription");
                        ControlFinder ctrlCur = new ControlFinder("Loại tiền", ControlType.HiddenField, DataType.Int, "txtCurency", true);
                        ctrlCur.QueryString = "curautoid";
                        this.ListControl.Add(ctrlCur);

                        //store DB
                        this.StoreName = "spFinderContractforApportion";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách hợp đồng", true);

                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "COT_AUTOID", string.Empty, "COT_AUTOID", true, true);
                        this.GridFinder.Add("Mã hợp đồng", 200, true, "COT_CONTRACTNO", string.Empty, "COT_CONTRACTNO", true);
                        this.GridFinder.Add("Ngày ký", 200, true, "COT_ASIGNDATE", string.Empty, "COT_ASIGNDATE");
                        this.GridFinder.Add("Ngày hết hạn", 200, true, "COT_EXPIREDATE", string.Empty, "COT_EXPIREDATE");
                        this.GridFinder.Add("Diễn giải", 100, true, "COT_DESCRIPTION", string.Empty, "COT_DESCRIPTION");
                    }
                    #endregion
                    break;
                case "finderbank":
                    #region finderbank
                    {
                        //init control
                        this.ListControl.Add("Tên viết tắt", ControlType.TextField, DataType.String, "txtSubBankName");
                        this.ListControl.Add("Tên ngân hàng", ControlType.TextField, DataType.String, "txtBankName");
                        this.ListControl.Add("Địa chỉ", ControlType.TextField, DataType.String, "txtAddress");
                        this.ListControl.Add("Website", ControlType.TextField, DataType.String, "txtWebsite");

                        //store DB
                        this.StoreName = "spfinderBank";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách ngân hàng", true);

                        this.GridFinder.Add("BAK_AUTOID", "Mã hệ thống", 100, true, "BAK_AUTOID", string.Empty, "BAK_AUTOID", true);
                        this.GridFinder.Add("Mã ngân hàng", 100, true, "BAK_SUBNAME", string.Empty, "BAK_SUBNAME", true);
                        this.GridFinder.Add("Tên ngân hàng", 200, true, "BAK_NAME", string.Empty, "BAK_NAME", true);
                        this.GridFinder.Add("TK ngân hàng", 200, true, "BAK_ACCOUNT", string.Empty, "BAK_ACCOUNT", true);
                        this.GridFinder.Add("TK tham chiếu", 200, true, "ACC_CODE", string.Empty, "ACC_CODE", true);
                        this.GridFinder.Add("Địa chỉ", 500, true, "BAK_ADDRESS", string.Empty, "BAK_ADDRESS");
                        this.GridFinder.Add("Số điện thoại", 100, true, "BAK_PHONE", string.Empty, "BAK_PHONE");
                        this.GridFinder.Add("Số fax", 100, true, "BAK_FAX", string.Empty, "BAK_FAX");
                        this.GridFinder.Add("Email", 200, true, "BAK_EMAIL", string.Empty, "BAK_EMAIL");
                        this.GridFinder.Add("Website", 200, true, "BAK_WEBSITE", string.Empty, "BAK_WEBSITE");
                    }
                    #endregion
                    break;
                //end add
                //su dung tim kiem tai khoan theo modul and chi nhanh
                //thong qua querry string "ubsid"
                //querry string la  hidden field. duoc gang ben finder.js(finderAccount_modul:SUBS_NAME)
                //SUBS_NAME la ten   hidden field.
                case "account":
                    #region account
                    {

                        this.LabelWidth = 100;
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tài khoản",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtAccount",
                            QueryString = "acod",
                            IsFocus = true
                        });
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tài khoản cha",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtParrentAccount"
                        });
                        List<DataItem> ds1 = new List<DataItem>();
                        List<PUBACCOUNTTYPE> lstAccount_type = PUBACCOUNTTYPEDAO.GetAllPUBACCOUNTTYPE();
                        for (int i = 0; i < lstAccount_type.Count; i++)
                        {
                            ds1.Add(new DataItem(lstAccount_type[i].ACCT_NAME, lstAccount_type[i].ACCT_AUTOID));
                        }
                        ds1.Insert(0, new DataItem("  ", ""));
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Loại",
                            ControlType = ControlType.Combobox,
                            DataType = DataType.String,
                            ID = "cboType",
                            IsControlGetValue = true,
                            DataSource = ds1,
                            QueryString = "AcctId"
                            // OnRender = "if(getQueryString(AcctId)=='2') cboType.setDisabled(true);"

                        });

                        List<DataItem> ds2 = new List<DataItem>();
                        List<PUBACCOUNTGROUP> lstAccount_Group = PUBACCOUNTGROUPDAO.GetAllAccountGroup();
                        DataSource = new List<DataItem>();
                        for (int i = 0; i < lstAccount_Group.Count; i++)
                        {
                            ds2.Add(new DataItem(lstAccount_Group[i].ACCG_NAME, lstAccount_Group[i].ACCG_AUTOID));
                        }
                        ds2.Insert(0, new DataItem("  ", ""));
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Nhóm",
                            ControlType = ControlType.Combobox,
                            DataType = DataType.String,
                            ID = "cboGroup",
                            IsControlGetValue = true,
                            DataSource = ds2

                        });

                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Phân hệ",
                            ControlType = ControlType.HiddenField,
                            DataType = DataType.String,
                            ID = "hdSubID",
                            IsControlGetValue = true,
                            QueryString = "subsid"
                        });
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tìm tất cả",
                            ControlType = ControlType.HiddenField,
                            DataType = DataType.String,
                            ID = "hdSearchAll",
                            IsControlGetValue = true,
                            QueryString = "isAll"
                        });
                        this.StoreName = "spFinderAccount_Modul";
                        this.GridFinder = new GridFinder("Danh sách tài khoản", true);

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tài khoản",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "ACC_CODE",
                            Renderer = string.Empty,
                            RecordField = "ACC_CODE",
                            ColumnId = "clAccount",
                            IsReturnValue = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên",
                            Sortable = true,
                            DataIndex = "ACC_NAME",
                            Renderer = string.Empty,
                            RecordField = "ACC_NAME",
                            IsReturnValue = false,
                            ColumnId = "clName",
                            AutoExpandColumn = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Nhóm",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "ACCG_NAME",
                            Renderer = string.Empty,
                            RecordField = "ACCG_NAME",
                            ColumnId = "clGroup",
                            IsReturnValue = false
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Loại",
                            Width = 100,
                            Sortable = true,
                            DataIndex = "ACCT_NAME",
                            Renderer = string.Empty,
                            RecordField = "ACCT_NAME",
                            ColumnId = "clType",
                            IsReturnValue = false
                        });
                        IsEventbtn = true;
                    }
                    #endregion
                    break;
                case "shipping":
                    #region SHIPPING
                    {

                        this.ListControl.Add("Mã vận chuyển", ControlType.TextField, DataType.String, "txtAutoID");
                        this.ListControl.Add("Tên", ControlType.TextField, DataType.String, "txtName");
                        this.ListControl.Add("Địa chỉ", ControlType.TextField, DataType.String, "txtAddress");
                        this.ListControl.Add("Số điện thoại", ControlType.TextField, DataType.String, "txtPhone");
                        this.ListControl.Add("Số Fax", ControlType.TextField, DataType.String, "txtFax");
                        this.ListControl.Add("Ngày mong đợi nhận hàng", ControlType.TextField, DataType.String, "txtExpectedDate");
                        this.ListControl.Add("ngày đơn vị vận chuyển hứa", ControlType.TextField, DataType.String, "txtPromisedDate");
                        this.ListControl.Add("Thời gian vận chuyển", ControlType.TextField, DataType.String, "txtTransportDate");
                        this.ListControl.Add("Phương thức vận chuyển", ControlType.TextField, DataType.String, "txtMode");
                        this.ListControl.Add("Chi phi vận chuyển ", ControlType.TextField, DataType.String, "txtCost");
                        this.ListControl.Add("Lần thứ mấy  ", ControlType.TextField, DataType.String, "txtTime");
                        this.ListControl.Add("Loại ", ControlType.TextField, DataType.String, "txtType");




                        this.StoreName = "spShippingSearch";

                        this.GridFinder = new GridFinder("Danh sách vận chuyển", true);

                        this.GridFinder.Add("SP_AutoID", "ID", 100, true, "SP_AutoID", string.Empty, "SP_AutoID", false);
                        this.GridFinder.Add("Tên", 200, true, "SP_AutoID", string.Empty, "SP_AutoID", true);
                        this.GridFinder.Add("Địa chỉ", 200, true, "SP_Address", string.Empty, "SP_Address", false);
                        this.GridFinder.Add("Số điện thoại", 200, true, "SP_PhoneNo", string.Empty, "SP_PhoneNo", false);
                        this.GridFinder.Add("Số Fax", 100, true, "SP_FaxNo", string.Empty, "SP_FaxNo", false);
                        this.GridFinder.Add("Ngày mong đợi nhận hàng", 100, true, "SP_ExpectedDate", string.Empty, "SP_ExpectedDate", false);
                        this.GridFinder.Add("Ngày đơn vị vận chuyển hứa", 100, true, "SP_PromisedDate", string.Empty, "SP_PromisedDate", false);
                        this.GridFinder.Add("Thời gian vận chuyển", 100, true, "SP_TransportTime", string.Empty, "SP_TransportTime", false);
                        this.GridFinder.Add("Phương thức vận chuyển", 100, true, "SP_Mode", string.Empty, "SP_Mode", false);
                        this.GridFinder.Add("Mô tã vắn tắt ", 100, true, "SP_Summary", string.Empty, "SP_Summary", false);
                        this.GridFinder.Add("Chi phí vận chuyển", 100, true, "SP_Cost", string.Empty, "SP_Cost", false);
                        this.GridFinder.Add("Làm thứ mầy", 100, true, "SP_Time", string.Empty, "SP_Time", false);
                        this.GridFinder.Add("Loại", 100, true, "SP_Type", string.Empty, "SP_Type", false);

                    }
                    #endregion
                    break;
                #region "Nhóm thực tập META"
                case "Province":
                    #region Province
                    {
                        this.ListControl.Add("Mã Tỉnh ", ControlType.TextField, DataType.String, "txtAutoId");
                        this.ListControl.Add("Tên Tỉnh ", ControlType.TextField, DataType.String, "txtName");


                        List<PUBCOUNTRY> lstCountry = PUBCOUNTRYDAO.GetAllActive();
                        for (int i = 0; i < lstCountry.Count; i++)
                        {
                            DataSource.Add(new DataItem(lstCountry[i].TRY_NAME, lstCountry[i].TRY_AUTOID));
                        }
                        DataSource.Insert(0, new DataItem("Tất cả", ""));

                        this.ListControl.Add("Quốc Gia ", ControlType.Combobox, DataType.String, "cboCountry", false, DataSource);

                        this.StoreName = "spFinderProvince";

                        this.GridFinder = new GridFinder("Danh sách các tỉnh thành", true);

                        this.GridFinder.Add("PRV_AUTOID", "ID", 100, true, "PRV_AUTOID", string.Empty, "PRV_AUTOID", true);
                        this.GridFinder.Add("PRV_NAME", 200, true, "PRV_NAME", string.Empty, "PRV_NAME", true);
                        this.GridFinder.Add("TRY_NAME", 200, true, "TRY_NAME", string.Empty, "TRY_NAME", true);
                        this.GridFinder.Add("PRV_DESCRIPTION", 200, true, "PRV_DESCRIPTION", string.Empty, "PRV_DESCRIPTION", false);
                    }
                    #endregion
                    break;

                ///Creator: duongnh
                ///date: 23/03/2009
                ///Dien giai: Tim kiem to Organization
                case "ORG":
                    #region ORG
                    {
                        this.ListControl.Add("Mã Tổ chức ", ControlType.NumberField, DataType.String, "txtAutoID");
                        this.ListControl.Add("Tổ chức ", ControlType.Combobox, DataType.String, "cboORG", false, DataSource);


                        //List<PUBORGANIZATION> lstORGANIZATION = PUBORGANIZATIONDAO.GetAllPUBORGANIZATION();
                        //for (int i = 0; i < lstORGANIZATION.Count; i++)
                        //{
                        //    DataSource.Add(new DataItem(lstORGANIZATION[i].ORG_NAME, lstORGANIZATION[i].ORG_AUTOID));
                        //}

                        this.StoreName = "spFinderORG";

                        this.GridFinder = new GridFinder("Danh sách tổ chức", true);

                        this.GridFinder.Add("Mã tổ chức", 100, true, "ORG_AUTOID", string.Empty, "ORG_AUTOID", true);
                        this.GridFinder.Add("Tên tổ chức", 200, true, "ORG_NAME", string.Empty, "ORG_NAME", true);
                        this.GridFinder.Add("Diễn giải", 200, true, "ORG_DESCRIPTION", string.Empty, "ORG_DESCRIPTION", false);
                    }
                    #endregion
                    break;

                ///Creator: Vinh
                ///date: 09/03/2010
                ///Dien giai: Tim kiem to Employee
                case "Employee":
                    #region FindEmployee
                    {

                        this.ListControl.Add("Mã Nhân viên ", ControlType.TextField, DataType.String, "txtAutoID");
                        this.ListControl.Add("Tên nhân viên ", ControlType.TextField, DataType.String, "txtName");
                        this.StoreName = "SP_PO_FinderEmployee";

                        this.GridFinder = new GridFinder("Danh sách nhân viên", true);
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        this.GridFinder.Add("Mã nhân viên", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        this.GridFinder.Add("Tên nhân viên", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("Email", 200, true, "OBJ_EMAIL", string.Empty, "OBJ_EMAIL", true);
                    }
                    #endregion
                    break;
                ///Creator: duongnh
                ///date: 25/03/2009
                ///Dien giai: Tim kiem to Employee cua ORG
                case "EMP":
                    #region EMPItemTypeNo
                    {

                        this.ListControl.Add("Mã Nhân viên ", ControlType.TextField, DataType.String, "txtAutoID");
                        this.ListControl.Add("Tên nhân viên ", ControlType.TextField, DataType.String, "txtName");

                        //List<PUBORGANIZATION> lstORGANIZATION = PUBORGANIZATIONDAO.GetAllPUBORGANIZATION();
                        //for (int i = 0; i < lstORGANIZATION.Count; i++)
                        //{
                        //    DataSource.Add(new DataItem(lstORGANIZATION[i].ORG_NAME, lstORGANIZATION[i].ORG_AUTOID));
                        //}

                        this.ListControl.Add("Tổ chức", ControlType.Combobox, DataType.String, "cboORG", true, DataSource);

                        this.StoreName = "spFinderEmployeeByORG";

                        this.GridFinder = new GridFinder("Danh sách nhân viên", true);
                        this.GridFinder.Add("OBJ_AUTOID", 100, false, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true);
                        this.GridFinder.Add("Mã nhân viên", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        this.GridFinder.Add("Tên nhân viên", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("POS_AUTOID", 200, true, "POS_AUTOID", string.Empty, "POS_AUTOID", true);
                        this.GridFinder.Add("Chức vụ", 200, true, "POS_NAME", string.Empty, "POS_NAME", true);
                    }
                    #endregion
                    break;

                ///Creator: duongnh
                ///date: 30/03/2009
                ///Dien giai: Tim kiem dai dien cua partner
                case "Partner":
                    #region Partner
                    {

                        this.ListControl.Add("Mã Đối tượng ", ControlType.NumberField, DataType.String, "txtAutoID");
                        this.ListControl.Add("Tên Đối tượng ", ControlType.TextField, DataType.String, "txtName");

                        //List<PUBOBJECTTYPE> lstObjType = new List<PUBOBJECTTYPE>();
                        //lstObjType = PUBOBJECTTYPEDAO.GetAllPUBOBJECTTYPEACTIVE();

                        //for (int i = 0; i < lstObjType.Count; i++)
                        //{
                        //    DataSource.Add(new DataItem(lstObjType[i].OBJT_NAME, lstObjType[i].OBJT_AUTOID));
                        //}
                        this.ListControl.Add("Loại Đối tượng", ControlType.Combobox, DataType.String, "cboOBJTYPE", true, DataSource);

                        this.StoreName = "spFinderObjWithPos";

                        this.GridFinder = new GridFinder("Danh sách đại diện", true);

                        this.GridFinder.Add("Tên nhân viên", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("POS_AUTOID", 200, true, "POS_AUTOID", string.Empty, "POS_AUTOID", true);
                        this.GridFinder.Add("Chức vụ", 200, true, "POS_NAME", string.Empty, "POS_NAME", true);
                    }
                    #endregion
                    break;

                ///Creator: duongnh
                ///date: 30/03/2009
                ///Dien giai: Tim kiem parnter
                case "PartnerObject":
                    #region PartnerObject
                    {
                        //List<PUBOBJECTTYPE> lstObjType = new List<PUBOBJECTTYPE>();
                        //lstObjType = PUBOBJECTTYPEDAO.GetAllPUBOBJECTTYPEACTIVE();

                        //for (int i = 0; i < lstObjType.Count; i++)
                        //{
                        //    DataSource.Add(new DataItem(lstObjType[i].OBJT_NAME, lstObjType[i].OBJT_AUTOID));
                        //}


                        this.ListControl.Add("Mã Đối tượng ", ControlType.TextField, DataType.String, "txtAutoID");
                        this.ListControl.Add("Loại Đối tượng", ControlType.Combobox, DataType.String, "cboOBJTYPE", true, DataSource);

                        this.StoreName = "spObjWithContact";

                        this.GridFinder = new GridFinder("Danh sách các đối tác", true);

                        this.GridFinder.Add("1", "OBJ_AUTOID", 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        this.GridFinder.Add("2", "Mã đối tượng", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true, false);
                        this.GridFinder.Add("3", "Tên đối tượng", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true, false);
                        this.GridFinder.Add("4", "CON_AUTOID", 200, true, "CON_AUTOID", string.Empty, "CON_AUTOID", true, true);
                        this.GridFinder.Add("5", "Địa chỉ", 200, true, "CON_ADDRESS1", string.Empty, "CON_ADDRESS1", true, false);
                        this.GridFinder.Add("6", "Điện thoại", 200, true, "CON_PHONENUMBER1", string.Empty, "CON_PHONENUMBER1", true, false);
                        this.GridFinder.Add("7", "Số Fax", 200, true, "CON_FAXNO", string.Empty, "CON_FAXNO", true, false);
                        this.GridFinder.Add("8", "Mã số thuế", 200, true, "OBJ_SERIALTAX", string.Empty, "OBJ_SERIALTAX", true, false);
                        this.GridFinder.Add("9", "Tài khoản", 200, true, "ACC_CODE", string.Empty, "ACC_CODE", true, false);
                        this.GridFinder.Add("10", "Tên người liên lạc", 200, true, "CON_NAME", string.Empty, "CON_NAME", true, false);
                        this.GridFinder.Add("11", "Chức vụ người liên lạc", 200, true, "CON_POSITIONNAME", string.Empty, "CON_POSITIONNAME", true, false);
                    }
                    #endregion
                    break;

                ///Creator: duongnh
                ///date: 27/03/2009
                ///Dien giai: Tim kiem CURRENCY RATE obj
                case "CURRATE":
                    #region CURRATE
                    {
                        DataSet dsCURRENCY = new DataSet();
                        dsCURRENCY = PUBCURRENCYDAO.GetAllACTIVEPUBCURRENCY();

                        for (int i = 0; i < dsCURRENCY.Tables[0].Rows.Count; i++)
                        {
                            DataSource.Add(new DataItem(dsCURRENCY.Tables[0].Rows[i]["CUR_NAME"], dsCURRENCY.Tables[0].Rows[i]["CUR_AUTOID"]));
                        }

                        ControlFinder cbo1 = new ControlFinder("Tiền gốc", ControlType.Combobox, DataType.Int, "cboCUR1");
                        cbo1.DefaultValue = "1";
                        cbo1.DataSource = DataSource;

                        ControlFinder cbo2 = new ControlFinder("Tiền chuyển đổi", ControlType.Combobox, DataType.Int, "cboCUR2");
                        cbo2.DefaultValue = "1";
                        cbo2.DataSource = DataSource;

                        this.ListControl.Add(cbo1);
                        this.ListControl.Add(cbo2);

                        this.StoreName = "spFinderCurrencyRate";

                        this.GridFinder = new GridFinder(" Tỷ giá ", true);
                        this.GridFinder.Add(" Tỷ giá ", 100, true, "CRRD_CURRENTCYRATE", string.Empty, "CRRD_CURRENTCYRATE", true);
                        this.GridFinder.Add(" Ngày ", 200, true, "CRRD_CREATEDATE", string.Empty, "CRRD_CREATEDATE");
                    }
                    #endregion
                    break;

                ///Creator: duongnh
                ///date: 27/03/2009
                ///Dien giai: Tim kiem CURRENCY RATE obj
                case "Project":
                    #region Project
                    {
                        this.ListControl.Add("Mã dự án", ControlType.TextField, DataType.String, "txtPRJ_PROJECTNO");
                        this.ListControl.Add("Tên dự án", ControlType.TextField, DataType.String, "txtPRJ_NAME");

                        this.StoreName = "spActiveProject";

                        this.GridFinder = new GridFinder("Dự án", true);
                        this.GridFinder.Add("PRJ_AUTOID", 100, true, "PRJ_AUTOID", string.Empty, "PRJ_AUTOID", true);
                        this.GridFinder.Add("Mã dự án", 200, true, "PRJ_PROJECTNO", string.Empty, "PRJ_PROJECTNO", true);
                        this.GridFinder.Add("Tên dự án", 200, true, "PRJ_NAME", string.Empty, "PRJ_NAME", true);

                    }
                    #endregion
                    break;
                ///Creator: duongnh
                ///date: 09/05/2009
                ///Dien giai: Career, tra ve mot list
                case "Career":
                    #region Carrer
                    {
                        this.ListControl.Add("Mã nghề nghiệp", ControlType.TextField, DataType.String, "txtCAR_AUTOID");
                        this.ListControl.Add("Nghề nghiệp", ControlType.TextField, DataType.String, "txtCAR_NAME");

                        this.StoreName = "spActiveCareer";

                        this.GridFinder = new GridFinder("Nghề nghiệp", true);
                        this.GridFinder.Add("CAR_AUTOID", 10, true, "CAR_AUTOID", string.Empty, "CAR_AUTOID", true);
                        this.GridFinder.Add("Nghề nghiệp", 100, true, "CAR_NAME", string.Empty, "CAR_NAME", true);
                        this.GridFinder.Add("Diễn giải", 200, true, "CAR_DESCRIPTION", string.Empty, "CAR_DESCRIPTION", false);
                    }
                    #endregion
                    break;


                #endregion

                // Author       : lamnq
                // Created date : 8:14 AM 4/24/2009
                // Purpose      : create finder for the PUBWAREHOUSE
                case "Warehouse":
                    #region warehouse finder
                    {
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtNo",
                            IsControlGetValue = true,

                        });
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtName",
                            IsControlGetValue = true,

                        });

                        StoreName = "spFinderWarehouse";

                        GridFinder = new GridFinder("Danh sách các kho hàng", true);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "WH_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "WH_AUTOID",
                            ColumnId = "clID",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã kho",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "WH_DEFINEID",
                            Renderer = string.Empty,
                            RecordField = "WH_DEFINEID",
                            ColumnId = "clNo",
                            IsReturnValue = true

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên kho",
                            AutoExpandColumn = true,
                            Sortable = true,
                            DataIndex = "WH_NAME",
                            Renderer = string.Empty,
                            RecordField = "WH_NAME",
                            ColumnId = "clName",
                            IsReturnValue = true

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Diễn giải",
                            Sortable = true,
                            DataIndex = "WH_DESCRIPTION",
                            Renderer = string.Empty,
                            RecordField = "WH_DESCRIPTION",
                            ColumnId = "clDescription",
                            IsReturnValue = true

                        });
                        IsEventbtn = true;
                    }
                    #endregion
                    break;
                // Author       : lamnq
                // Created date : 1:54 PM 4/24/2009
                // Purpose      : create finder for the PUBMANUFACTURER
                case "Manufacturer":
                    #region manufacturer finder
                    {
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtName",
                            IsControlGetValue = true,

                        });

                        StoreName = "spFinderManufacturer";
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "MANU_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "MANU_AUTOID",
                            ColumnId = "clID",
                            IsReturnValue = true,
                            IsHidden = true
                        });

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên kho",
                            AutoExpandColumn = true,
                            Sortable = true,
                            DataIndex = "MANU_NAME",
                            Renderer = string.Empty,
                            RecordField = "MANU_NAME",
                            ColumnId = "clName",
                            IsReturnValue = true

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Diễn giải",
                            Sortable = true,
                            DataIndex = "MANU_DESCRIPTION",
                            Renderer = string.Empty,
                            RecordField = "MANU_DESCRIPTION",
                            ColumnId = "clDescription",
                            IsReturnValue = true

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Địa chỉ",
                            Sortable = true,
                            DataIndex = "MANU_ADDRESS",
                            Renderer = string.Empty,
                            RecordField = "MANU_ADDRESS",
                            ColumnId = "clAddress",
                            IsReturnValue = true

                        });
                        IsEventbtn = true;
                    }
                    #endregion
                    break;
                // Author       : lamnq
                // Created date : 3:59 PM 4/27/2009
                // Update by    : phongvt
                // Update date  : 3:26 PM 09/01/2009
                // Purpose      : create finder for the PUBOBJECT(Supplier)
                case "Supplier":
                    #region supplier finder
                    {
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtID",
                            IsControlGetValue = true,

                        });
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtName",
                            IsControlGetValue = true,

                        });

                        StoreName = "SP_FINDER_SUPPLIER";
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "OBJ_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "OBJ_AUTOID",
                            datatype = RecordFieldType.Int,
                            ColumnId = "clID",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã",
                            AutoExpandColumn = true,
                            Sortable = true,
                            DataIndex = "OBJ_OBJECTNO",
                            Renderer = string.Empty,
                            RecordField = "OBJ_OBJECTNO",
                            datatype = RecordFieldType.String,
                            ColumnId = "clNo",
                            IsReturnValue = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên",
                            AutoExpandColumn = true,
                            Sortable = true,
                            DataIndex = "OBJ_NAME",
                            Renderer = string.Empty,
                            RecordField = "OBJ_NAME",
                            datatype = RecordFieldType.String,
                            ColumnId = "clName",
                            IsReturnValue = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã số thuế",
                            Width = 70,
                            Sortable = true,
                            DataIndex = "OBJ_TAXID",
                            Renderer = string.Empty,
                            RecordField = "OBJ_TAXID",
                            datatype = RecordFieldType.String,
                            ColumnId = "clTaxID",
                            IsReturnValue = true
                        });

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tỉnh thành",
                            Width = 100,
                            Sortable = true,
                            DataIndex = "PRV_NAME",
                            Renderer = string.Empty,
                            RecordField = "PRV_NAME",
                            datatype = RecordFieldType.String,
                            ColumnId = "clProvince",
                            IsReturnValue = true
                        });

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Quốc gia",
                            Width = 70,
                            Sortable = true,
                            DataIndex = "TRY_NAME",
                            Renderer = string.Empty,
                            RecordField = "TRY_NAME",
                            datatype = RecordFieldType.String,
                            ColumnId = "clCountry",
                            IsReturnValue = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Quốc gia",
                            Width = 200,
                            Sortable = true,
                            DataIndex = "TRY_CONTINENT",
                            Renderer = string.Empty,
                            RecordField = "TRY_CONTINENT",
                            datatype = RecordFieldType.String,
                            ColumnId = "clContinents",
                            IsReturnValue = true
                        });
                        IsEventbtn = true;
                    }
                    #endregion
                    break;
                // Author       : Vinhlq
                // Created date : 19/02/2011
                // Update by    : 
                // Update date  : 
                case "CostPrice":
                    #region Cosprice finder
                    {
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã và tên",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtNoandName",
                            IsControlGetValue = true,

                        });
                        StoreName = "SP_FINDER_COSPRICE";
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "CP_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "CP_AUTOID",
                            datatype = RecordFieldType.Int,
                            ColumnId = "clID",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "CP_DOCNO",
                            Renderer = string.Empty,
                            RecordField = "CP_DOCNO",
                            datatype = RecordFieldType.String,
                            ColumnId = "clNo",
                            IsReturnValue = true,

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên",
                            AutoExpandColumn = true,
                            Sortable = true,
                            DataIndex = "CP_NAME",
                            Renderer = string.Empty,
                            RecordField = "CP_NAME",
                            datatype = RecordFieldType.String,
                            ColumnId = "clName",
                            IsReturnValue = true,

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Cha",
                            Width = 200,
                            Sortable = true,
                            DataIndex = "PARENT_NAME",
                            Renderer = string.Empty,
                            RecordField = "PARENT_NAME",
                            datatype = RecordFieldType.String,
                            ColumnId = "clParent",
                            IsReturnValue = true,

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Dễn gỉai",
                            Width = 200,
                            Sortable = true,
                            DataIndex = "CP_DECRIPTION",
                            Renderer = string.Empty,
                            RecordField = "CP_DECRIPTION",
                            datatype = RecordFieldType.String,
                            ColumnId = "clDescription",
                            IsReturnValue = true,

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Sortable = true,
                            DataIndex = "OBJ_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "OBJ_AUTOID",
                            datatype = RecordFieldType.Int,
                            IsHidden = true,
                            IsReturnValue = true,

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Sortable = true,
                            DataIndex = "CP_PARRENTID",
                            Renderer = string.Empty,
                            RecordField = "CP_PARRENTID",
                            datatype = RecordFieldType.Int,
                            IsHidden = true,
                            IsReturnValue = true,

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Sortable = true,
                            DataIndex = "PRJ_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "PRJ_AUTOID",
                            datatype = RecordFieldType.Int,
                            IsHidden = true,
                            IsReturnValue = true,

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Sortable = true,
                            DataIndex = "COT_DOCUMENTID",
                            Renderer = string.Empty,
                            RecordField = "COT_DOCUMENTID",
                            datatype = RecordFieldType.Int,
                            IsHidden = true,
                            IsReturnValue = true,

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Sortable = true,
                            DataIndex = "CPT_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "CPT_AUTOID",
                            datatype = RecordFieldType.Int,
                            IsHidden = true,
                            IsReturnValue = true,

                        });

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Sortable = true,
                            DataIndex = "CPM_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "CPM_AUTOID",
                            datatype = RecordFieldType.Int,
                            IsHidden = true,
                            IsReturnValue = true,

                        });

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Sortable = true,
                            DataIndex = "CP_ENDDATE",
                            Renderer = string.Empty,
                            RecordField = "CP_ENDDATE",
                            datatype = RecordFieldType.Date,
                            IsHidden = true,
                            IsReturnValue = true,

                        });

                        IsEventbtn = true;
                    }
                    #endregion
                    break;
                // Author       : Vinh
                // Created date : 12/03/2010
                // Purpose      : create finder Employee
                case "EmployeePO":
                    #region EMP
                    {
                        ListControl.Add("Mã nhân viên", ControlType.TextField, DataType.String, "txtOBJ_OBJECTNO");
                        ListControl.Add("Tên nhân viên", ControlType.TextField, DataType.String, "txtOBJ_NAME");

                        StoreName = "SP_FINDER_EMPLOYEE";
                        GridFinder.Add("ID", 50, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true);//0
                        GridFinder.Add("Mã nhân viên", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);//1
                        GridFinder.Add("Tên nhân viên", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);//2
                        GridFinder.Add("Email", 100, true, "OBJ_EMAIL", string.Empty, "OBJ_EMAIL", true);//3
                        GridFinder.Add("Địa chỉ", 70, true, "OBJ_ADDRESS", string.Empty, "OBJ_ADDRESS", true);//3
                    }
                    #endregion
                    break;
                // Author       : VInh
                // Created date : 12/03/2010
                // Purpose      : create finder for the Contract
                case "Contract":
                    #region contract finder
                    {
                        this.ListControl.Add(new ControlFinder
                        {

                            ControlType = ControlType.HiddenField,
                            DataType = DataType.Int,
                            ID = "ORG",
                            QueryString = "org",
                            IsControlGetValue = true,

                        });
                        this.ListControl.Add(new ControlFinder
                        {

                            ControlType = ControlType.HiddenField,
                            DataType = DataType.Int,
                            ID = "OBJ",
                            QueryString = "obj",
                            IsControlGetValue = true,

                        });

                        this.ListControl.Add(new ControlFinder
                        {

                            ControlType = ControlType.HiddenField,
                            DataType = DataType.Int,
                            ID = "BUY",
                            QueryString = "isbuy",
                            IsControlGetValue = true,

                        });
                        this.ListControl.Add(new ControlFinder
                        {

                            ControlType = ControlType.HiddenField,
                            DataType = DataType.Int,
                            ID = "TYPE",
                            QueryString = "isit",
                            IsControlGetValue = true,

                        });
                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã hợp đồng",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtContractNo",
                            IsControlGetValue = true,

                        });

                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã đối tượng",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtOBJECTNO",
                            IsControlGetValue = true,

                        });

                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên đối tượng",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtObjectName",
                            IsControlGetValue = true,

                        });


                        this.ListControl.Add(new ControlFinder
                        {

                            ControlType = ControlType.HiddenField,
                            DataType = DataType.Int,
                            ID = "GROUP",
                            QueryString = "ctg",
                            IsControlGetValue = true,

                        });


                        StoreName = "SP_FINDER_CONTRACT";
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "COT_DOCUMENTID",
                            Renderer = string.Empty,
                            RecordField = "COT_DOCUMENTID",
                            datatype = RecordFieldType.Int,
                            ColumnId = "clID",
                            IsReturnValue = true,
                            IsHidden = true
                        });

                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã tiền",
                            Width = 50,
                            Sortable = true,
                            DataIndex = "CUR_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "CUR_AUTOID",
                            datatype = RecordFieldType.Int,
                            ColumnId = "clCurrency",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Loại tiền",
                            AutoExpandColumn = true,
                            Sortable = true,
                            DataIndex = "CUR_NAME",
                            Renderer = string.Empty,
                            RecordField = "CUR_NAME",
                            datatype = RecordFieldType.String,
                            ColumnId = "clCurrencyType",
                            IsReturnValue = true

                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tiền nguyên tệ",
                            AutoExpandColumn = true,
                            Sortable = true,
                            DataIndex = "COT_BASEAMOUNT",
                            Renderer = "return setView(value)",
                            RecordField = "COT_BASEAMOUNT",
                            datatype = RecordFieldType.Float,
                            ColumnId = "clOriginalAmount",
                            IsReturnValue = true


                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "CTG_AUTOID",
                            Sortable = true,
                            DataIndex = "CTG_AUTOID",
                            RecordField = "CTG_AUTOID",
                            datatype = RecordFieldType.Float,
                            ColumnId = "CTG_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "COT_CONTRACTTYPE",
                            Sortable = true,
                            DataIndex = "COT_CONTRACTTYPE",
                            RecordField = "COT_CONTRACTTYPE",
                            datatype = RecordFieldType.Float,
                            ColumnId = "COT_CONTRACTTYPE",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        IsEventbtn = true;
                    }
                    #endregion
                    break;
                // Author       : Vinhlq
                // Created date : 4:30AM 17/3/2010
                // Purpose      : create finder for the Project
                case "Pro":
                    #region Project finder
                    {
                        ListControl.Add("Mã hợp đồng", ControlType.TextField, DataType.String, "txtPRJ_PROJECTNO");
                        ListControl.Add("Tên đối tượng", ControlType.TextField, DataType.String, "txtOBJ_NAME");
                        ListControl.Add("Tên dự án", ControlType.TextField, DataType.String, "txtPRJ_NAME ");

                        StoreName = "SP_FINDER_PROJECT";
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "PRJ_AUTOID", string.Empty, "PRJ_AUTOID", true, true);
                        GridFinder.Add("Mã đự án", 100, true, "PRJ_PROJECTNO", string.Empty, "PRJ_PROJECTNO", true);//1
                        GridFinder.Add("Tên dự án", 100, true, "PRJ_NAME", string.Empty, "PRJ_NAME", true);//1
                        GridFinder.Add("Loại dự án", 100, true, "PROT_NAME", string.Empty, "PROT_NAME", true);//2
                        GridFinder.Add("Tên đối tượng", 100, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);//3
                    }
                    #endregion
                    break;
                // Author       : lamnq
                // Created date : 12:31 PM 4/28/2009
                // Purpose      : create finder for the PUBLOATTRIBUTEINFO
                case "LoaAttribute":
                    #region loaattributeinfo finder
                    {
                        ListControl.Add("Mã thuộc tính", ControlType.TextField, DataType.String, "txtLOA_IDNO");
                        ListControl.Add("Tên thuộc tính", ControlType.TextField, DataType.String, "txtLOA_NAME");

                        List<PUBATTRIBUTEUNIT> lstAttributeUnit = PUBATTRIBUTEUNITDAO.GetAllActive();
                        if (lstAttributeUnit != null)
                            foreach (PUBATTRIBUTEUNIT p in lstAttributeUnit)
                                DataSource.Add(new DataItem(p.PATU_NAME, p.PATU_AUTOID));
                        ListControl.Add("Đơn vị tính", ControlType.Combobox, DataType.Int, "cboPATU_NAME", true, DataSource);

                        List<DataItem> dsAttributeType = null;
                        List<PUBATTRIBUTETYPE> lstAttributeType = PUBATTRIBUTETYPEDAO.GetAllActive();
                        if (lstAttributeType != null)
                        {
                            dsAttributeType = new List<DataItem>(lstAttributeType.Count);
                            foreach (PUBATTRIBUTETYPE p in lstAttributeType)
                                dsAttributeType.Add(new DataItem(p.PAT_NAME, p.PAT_AUTOID));
                        }
                        ListControl.Add("Loại thuộc tính", ControlType.Combobox, DataType.Int, "cboPAT_NAME", true, dsAttributeType);

                        StoreName = "spFinderLoaAttributeInfo";
                        GridFinder = new GridFinder("Danh sách thuộc tính", true);
                        GridFinder.Add("LOA_AUTOID", string.Empty, 10, true, "LOA_AUTOID", string.Empty, "LOA_AUTOID", true, true);
                        GridFinder.Add("LOA_IDNO", string.Empty, 100, true, "LOA_IDNO", string.Empty, "LOA_IDNO", true);
                        GridFinder.Add("Tên thuộc tính", 200, true, "LOA_NAME", string.Empty, "LOA_NAME", true);
                        GridFinder.Add("Đơn vị tính", 100, true, "PATU_NAME", string.Empty, "PATU_NAME", true);
                        GridFinder.Add("Loại thuộc tính", 100, true, "PAT_NAME", string.Empty, "PAT_NAME", true);
                    }
                    #endregion
                    break;
                // Author       : lamnq
                // Created date : 8:10 AM 4/29/2009
                // Purpose      : create finder for the ITEMSPOSITION
                case "ItemsPosition":
                    #region itemsposition finder
                    {
                        ListControl.Add("Tên vị trí", ControlType.TextField, DataType.String, "txtITP_NAME");

                        List<PUBWAREHOUSE> lstWarehouse = PUBWAREHOUSEDAO.GetAllActive(null, null);
                        if (lstWarehouse != null)
                            foreach (PUBWAREHOUSE p in lstWarehouse)
                                DataSource.Add(new DataItem(p.WH_NAME, p.WH_AUTOID));

                        ControlFinder cfWarehouse = new ControlFinder("Tên kho", ControlType.Combobox, DataType.Int, "cboWH_AUTOID", true, DataSource);
                        cfWarehouse.QueryString = "whid";
                        ListControl.Add(cfWarehouse);

                        StoreName = "spFinderItemsPosition";
                        GridFinder.Add("Mã vị trí", 50, true, "ITP_AUTOID", string.Empty, "ITP_AUTOID", true);
                        GridFinder.Add("Mã kho", 50, true, "WH_AUTOID", string.Empty, "WH_AUTOID", true);
                        GridFinder.Add("Tên vị trí", 200, true, "ITP_NAME", string.Empty, "ITP_NAME", true);
                        GridFinder.Add("Ghi chú", 200, true, "ITP_DESCRIPTION", string.Empty, "ITP_DESCRIPTION", false);
                        GridFinder.Add("Thuộc kho", 200, true, "WH_NAME", string.Empty, "WH_NAME", false);
                        GridFinder.ListColumn[0].IsHidden = true;
                        GridFinder.ListColumn[1].IsHidden = true;
                    }
                    #endregion
                    break;
                // Author       : lamnq
                // Created date : 2:29 PM 5/12/2009
                // Purpose      : create finder for the PUBACCOUNT, utilize for internally managing accounts only (copied from account).
                case "Accounts":
                    #region pubaccount finder
                    {
                        ListControl.Add("Số tài khoản", ControlType.TextField, DataType.String, "ACC_CODE");
                        ListControl.Add("Tên tài khoản", ControlType.TextField, DataType.String, "ACC_NAME");

                        StoreName = "spFinderAccount";

                        GridFinder = new GridFinder("Danh sách tài khoản", false);

                        GridFinder.Add("Số tài khoản", 120, true, "ACC_CODE", string.Empty, "ACC_CODE", true);
                        GridFinder.Add("Tên tài khoản", 200, true, "ACC_NAME", string.Empty, "ACC_NAME", false);
                        GridFinder.Add("Ghi chú", 100, true, "ACC_DESCRIPTION", string.Empty, "ACC_DESCRIPTION", false);
                        GridFinder.Add("Ngày tạo", 200, true, "ACC_CREATEDATE", string.Empty, "ACC_CREATEDATE", false);
                    }
                    #endregion
                    break;
                // Author       : lamnq
                // Created date : 2:29 PM 5/12/2009
                // Purpose      : create finder for the PUBACCOUNT, utilize for internally managing accounts only (copied from account).
                case "LastAccounts":
                    #region pubaccount finder
                    {
                        ListControl.Add("Số tài khoản", ControlType.TextField, DataType.String, "ACC_CODE");
                        ListControl.Add("Tên tài khoản", ControlType.TextField, DataType.String, "ACC_NAME");
                        ControlFinder subs = new ControlFinder("Phân hệ", ControlType.HiddenField, DataType.Int, "SUBS_AUTOID", true);
                        subs.QueryString = "sub";
                        this.ListControl.Add(subs);
                        StoreName = "SP_META_LastAccount_PUBACCOUNT";

                        GridFinder = new GridFinder("Danh sách tài khoản", false);

                        GridFinder.Add("Số tài khoản", 120, true, "ACC_CODE", string.Empty, "ACC_CODE", true);
                        GridFinder.Add("Tên tài khoản", 200, true, "ACC_NAME", string.Empty, "ACC_NAME", false);
                        GridFinder.Add("Nhóm tài khoản", 200, true, "ACCG_NAME", string.Empty, "ACCG_NAME", false);
                        GridFinder.Add("Loại tài khoản", 200, true, "ACCT_NAME", string.Empty, "ACCT_NAME", false);
                        GridFinder.Add("Ghi chú", 100, true, "ACC_DESCRIPTION", string.Empty, "ACC_DESCRIPTION", false);
                        GridFinder.Add("Ngày tạo", 200, true, "ACC_CREATEDATE", string.Empty, "ACC_CREATEDATE", false);
                    }
                    #endregion
                    break;
                // Author       : lamnq
                // Created date : 4:08 PM 5/12/2009
                // Purpose      : create finder for the PUBORGANIZATION, utilize for internally managing accounts only.                
                case "Organizations":
                    #region puborganization finder
                    {
                        ListControl.Add("Mã tổ chức", ControlType.TextField, DataType.String, "ORG_BUSINESSNO");
                        ListControl.Add("Tên tổ chức", ControlType.TextField, DataType.String, "ORG_NAME");

                        StoreName = "spFinderOrganization";

                        GridFinder = new GridFinder("Danh sách tổ chức", true);
                        GridFinder.Add("ORG_AUTOID", "", 50, true, "ORG_AUTOID", string.Empty, "ORG_AUTOID", true, true);
                        GridFinder.Add("Mã tổ chức", 100, true, "ORG_BUSSINESSNO", string.Empty, "ORG_BUSSINESSNO", false);
                        GridFinder.Add("Tên tổ chức", 200, true, "ORG_NAME", string.Empty, "ORG_NAME", true);
                        GridFinder.Add("Ghi chú", 200, true, "ORG_DESCRIPTION", string.Empty, "ORG_DESCRIPTION", false);
                    }
                    #endregion
                    break;

                case "PubItems":
                    #region pubitems finder
                    {
                        ListControl.Add("Mã sản phẩm", ControlType.TextField, DataType.String, "PIT_ITEMNO", true);
                        ListControl.Add("Tên sản phẩm", ControlType.TextField, DataType.String, "PIT_ITEMNAME", true);
                        ControlFinder ctrl = new ControlFinder("Loại sản phẩm", ControlType.HiddenField, DataType.String, "ITET_AUTOID", true);
                        ctrl.QueryString = "typeid";
                        ListControl.Add(ctrl);
                        ControlFinder ctrl2 = new ControlFinder("Loại item", ControlType.HiddenField, DataType.Int, "PIT_ISITEM", true);
                        ctrl2.QueryString = "itemtype";
                        ListControl.Add(ctrl2);

                        //StoreName = "spFinderPubItems1";
                        StoreName = "spFinderPubItems2";

                        GridFinder = new GridFinder("Danh sách sản phẩm", false);

                        GridFinder.Add("PIT_AUTOID", string.Empty, 100, true, "PIT_AUTOID", string.Empty, "PIT_AUTOID", true, true);
                        GridFinder.Add("Mã sản phẩm", 100, true, "PIT_ITEMNO", string.Empty, "PIT_ITEMNO", true);
                        GridFinder.Add("Tên sản phẩm", 200, true, "PIT_NAME", string.Empty, "PIT_NAME", true);
                        GridFinder.Add("Nhóm sản phẩm", 200, true, "ITG_NAME", string.Empty, "ITG_NAME", false);
                        GridFinder.Add("Loại sản phẩm", 200, true, "PIC_NAME", string.Empty, "PIC_NAME", false);
                        GridFinder.Add("2 đơn vị tính", string.Empty, 100, true, "PIT_ISTWOUOM", string.Empty, "PIT_ISTWOUOM", true, true);
                        GridFinder.Add("Đối tượng thuế SO", string.Empty, 0, false, "TR_SOVAT", string.Empty, "TR_SOVAT", true, true);
                        GridFinder.Add("Đối tượng thuế PO", string.Empty, 0, false, "TR_POVAT", string.Empty, "TR_POVAT", true, true);
                        GridFinder.Add("% thuế", string.Empty, 0, false, "PIT_VATTAXPER", string.Empty, "PIT_VATTAXPER", true, true);
                        GridFinder.Add("Đối tượng thuế TTĐB SO", string.Empty, 0, false, "TR_SOEXCISETAX", string.Empty, "TR_SOEXCISETAX", true, true);
                        GridFinder.Add("Đối tượng thuế TTĐB PO", string.Empty, 0, false, "TR_POEXCISETAX", string.Empty, "TR_POEXCISETAX", true, true);
                        GridFinder.Add("% thuế TTĐB", string.Empty, 0, false, "PIT_EXCISETAXPER", string.Empty, "PIT_EXCISETAXPER", true, true);
                        GridFinder.Add("Đối tượng thuế xuất khẩu", string.Empty, 0, false, "TR_EXPORTTAX", string.Empty, "TR_EXPORTTAX", true, true);
                        GridFinder.Add("% thuế xuất khẩu", string.Empty, 0, false, "PIT_EXPORTTAXPER", string.Empty, "PIT_EXPORTTAXPER", true, true);
                        GridFinder.Add("Đối tượng thuế nhập khẩu", string.Empty, 0, false, "TR_IMPORTTAX", string.Empty, "TR_IMPORTTAX", true, true);
                        GridFinder.Add("% thuế nhập khẩu", string.Empty, 0, false, "PIT_IMPORTTAXPER", string.Empty, "PIT_IMPORTTAXPER", true, true);
                        GridFinder.Add("Đơn vị tính 1", string.Empty, 0, false, "PIT_UOMID1", string.Empty, "PIT_UOMID1", true, true);
                        GridFinder.Add("Giá 1", string.Empty, 0, false, "PIT_SOPRICE1", string.Empty, "PIT_SOPRICE1", true, true);
                        GridFinder.Add("Đơn vị tính 2", string.Empty, 0, false, "PIT_UOMID2", string.Empty, "PIT_UOMID2", true, true);
                        GridFinder.Add("Tên đơn vị 2", string.Empty, 0, false, "UOM_NAME2", string.Empty, "UOM_NAME2", true, true);
                        GridFinder.Add("Tên đơn vị 1", string.Empty, 0, false, "UOM_NAME1", string.Empty, "UOM_NAME1", true, true);
                    }
                    #endregion
                    break;

                case "PubItemsForInvoice":
                    #region pubitems finder
                    {
                        ListControl.Add("Mã sản phẩm", ControlType.TextField, DataType.String, "PIT_ITEMNO", true);
                        ListControl.Add("Tên sản phẩm", ControlType.TextField, DataType.String, "PIT_ITEMNAME", true);
                        ControlFinder ctrl2 = new ControlFinder("Loại item", ControlType.HiddenField, DataType.Int, "PIT_ISITEM", true);
                        ctrl2.QueryString = "itemtype";
                        ListControl.Add(ctrl2);

                        StoreName = "spFinderPubItemForInvoice";

                        GridFinder = new GridFinder("Danh sách sản phẩm", false);

                        GridFinder.Add("PIT_AUTOID", string.Empty, 100, true, "PIT_AUTOID", string.Empty, "PIT_AUTOID", true, true);
                        GridFinder.Add("Mã sản phẩm", 100, true, "PIT_ITEMNO", string.Empty, "PIT_ITEMNO", true);
                        GridFinder.Add("Tên sản phẩm", 200, true, "PIT_NAME", string.Empty, "PIT_NAME", true);
                        //GridFinder.Add("Nhóm sản phẩm", 200, true, "ITG_NAME", string.Empty, "ITG_NAME", false);
                        GridFinder.Add("Loại sản phẩm", 200, true, "PIC_NAME", string.Empty, "PIC_NAME", false);
                        GridFinder.Add("2 đơn vị tính", string.Empty, 100, true, "PIT_ISTWOUOM", string.Empty, "PIT_ISTWOUOM", true, true);
                        GridFinder.Add("Đối tượng thuế SO", string.Empty, 0, false, "TR_SOVAT", string.Empty, "TR_SOVAT", true, true);
                        GridFinder.Add("Đối tượng thuế PO", string.Empty, 0, false, "TR_POVAT", string.Empty, "TR_POVAT", true, true);
                        GridFinder.Add("% thuế", string.Empty, 0, false, "PIT_VATTAXPER", string.Empty, "PIT_VATTAXPER", true, true);
                        GridFinder.Add("Đối tượng thuế TTĐB SO", string.Empty, 0, false, "TR_SOEXCISETAX", string.Empty, "TR_SOEXCISETAX", true, true);
                        GridFinder.Add("Đối tượng thuế TTĐB PO", string.Empty, 0, false, "TR_POEXCISETAX", string.Empty, "TR_POEXCISETAX", true, true);
                        GridFinder.Add("% thuế TTĐB", string.Empty, 0, false, "PIT_EXCISETAXPER", string.Empty, "PIT_EXCISETAXPER", true, true);
                        GridFinder.Add("Đối tượng thuế xuất khẩu", string.Empty, 0, false, "TR_EXPORTTAX", string.Empty, "TR_EXPORTTAX", true, true);
                        GridFinder.Add("% thuế xuất khẩu", string.Empty, 0, false, "PIT_EXPORTTAXPER", string.Empty, "PIT_EXPORTTAXPER", true, true);
                        GridFinder.Add("Đối tượng thuế nhập khẩu", string.Empty, 0, false, "TR_IMPORTTAX", string.Empty, "TR_IMPORTTAX", true, true);
                        GridFinder.Add("% thuế nhập khẩu", string.Empty, 0, false, "PIT_IMPORTTAXPER", string.Empty, "PIT_IMPORTTAXPER", true, true);
                        GridFinder.Add("Đơn vị tính 1", string.Empty, 0, false, "PIT_UOMID1", string.Empty, "PIT_UOMID1", true, true);
                        GridFinder.Add("Giá 1", string.Empty, 0, false, "PIT_SOPRICE1", string.Empty, "PIT_SOPRICE1", true, true);
                        GridFinder.Add("ITG_AUTOID", string.Empty, 0, false, "ITG_AUTOID", string.Empty, "ITG_AUTOID", true, true);
                        GridFinder.Add("Phân loại", 200, true, "ITG_NAME", string.Empty, "ITG_NAME", false);

                        #region Tannv
                        GridFinder.Add("PIT_ISPLOT", string.Empty, 100, false, "PIT_ISPLOT", string.Empty, "PIT_ISPLOT", true, true);
                        GridFinder.Add("PIT_ISSERIAL", string.Empty, 100, false, "PIT_ISSERIAL", string.Empty, "PIT_ISSERIAL", true, true);
                        GridFinder.Add("Đơn vị tính 1", string.Empty, 100, false, "PIT_UOMID2", string.Empty, "PIT_UOMID2", true, true);
                        GridFinder.Add("Mã kho", string.Empty, 100, false, "WH_AUTOID", string.Empty, "WH_AUTOID", true, true);
                        GridFinder.Add("Tên kho", string.Empty, 100, false, "WH_NAME", string.Empty, "WH_NAME", true, true);
                        GridFinder.Add("Mã vị trí", string.Empty, 100, false, "ITP_AUTOID", string.Empty, "ITP_AUTOID", true, true);
                        GridFinder.Add("Tên vị trí", string.Empty, 100, false, "ITP_NAME", string.Empty, "ITP_NAME", true, true);

                        // Thêm cho kho xuất 
                        GridFinder.Add("Đơn vị tính ", string.Empty, 100, false, "UOM_AUTOID", string.Empty, "UOM_AUTOID", true, true);
                        GridFinder.Add("Loại tiền", string.Empty, 0, false, "CUR_AUTOID", string.Empty, "CUR_AUTOID", true, true);
                        #endregion
                    }
                    #endregion
                    break;

                // Author       : lamnq
                // Created date : 8:59 AM 5/27/2009
                // Purpose      : create finder for the PUBITEMSGROUP.
                case "ItemGroups":
                    #region pubitemgroup finder
                    {
                        ListControl.Add("Mã nhóm", ControlType.TextField, DataType.String, "ITG_GROUPNO");
                        ListControl.Add("Tên nhóm", ControlType.TextField, DataType.String, "ITG_NAME");
                        ControlFinder cfr = new ControlFinder("Nhóm chính", ControlType.HiddenField, DataType.Int, "ITG_TYPE", true);
                        cfr.QueryString = "itgtype";
                        ListControl.Add(cfr);

                        StoreName = "SP_FinderItemGroup_PUBITEMSGROUP";

                        GridFinder.Add("ITG_AUTOID", string.Empty, 10, true, "ITG_AUTOID", string.Empty, "ITG_AUTOID", true, true);
                        GridFinder.Add("Mã nhóm", 100, true, "ITG_GROUPNO", string.Empty, "ITG_GROUPNO", true);
                        GridFinder.Add("Tên nhóm", 100, true, "ITG_NAME", string.Empty, "ITG_NAME", true);
                        GridFinder.Add("Tài khoản nhóm", 100, true, "ACC_CLASSIFIED", string.Empty, "ACC_CLASSIFIED", true);
                        GridFinder.Add("Ghi chú", 200, true, "ITG_DESCRIPTION", string.Empty, "ITG_DESCRIPTION", false);
                    }
                    #endregion
                    break;
                case "PubObjects":
                    #region pubobject finder
                    {
                        ListControl.Add("Mã đối tượng", ControlType.TextField, DataType.String, "txtOBJ_OBJECTNO");
                        ListControl.Add("Tên đối tượng", ControlType.TextField, DataType.String, "txtOBJ_NAME");
                        //List<PUBOBJECTTYPE> lstObjectTypes = PUBOBJECTTYPEDAO.GetAllPUBOBJECTTYPEACTIVE();
                        //if (lstObjectTypes.Count > 0)
                        //    foreach (PUBOBJECTTYPE objtype in lstObjectTypes)
                        //        DataSource.Add(new DataItem(objtype.OBJT_NAME, objtype.OBJT_AUTOID));
                        ListControl.Add("Thuộc nhóm", ControlType.Combobox, DataType.Int, "OBJT_AUTOID", true, DataSource);

                        StoreName = "spFinderPubObject";

                        GridFinder.Add(string.Empty, string.Empty, 10, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        GridFinder.Add("Mã đối tượng", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        GridFinder.Add("Tên đối tượng", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        GridFinder.Add("Thuộc nhóm", 200, true, "OBJT_NAME", string.Empty, "OBJT_NAME", false);
                        GridFinder.Add("Tài khoản", 200, true, "ACC_CODE", string.Empty, "ACC_CODE", false);
                    }
                    #endregion
                    break;
                case "PurOrder":
                    #region purchasing order finder
                    {
                        List<PUBDOCUMENTTYPE> lstDocType = PUBDOCUMENTTYPEDAO.GetDocumentType("DOTY_ISPO = 1", 6, 1);
                        if (lstDocType.Count > 0)
                            foreach (PUBDOCUMENTTYPE doctype in lstDocType)
                                DataSource.Add(new DataItem(doctype.DOTY_NAME, doctype.DOTY_AUTOID));
                        ControlFinder cfr = new ControlFinder("Loại chứng từ", ControlType.Combobox, DataType.Int, "txtDOTY_AUTOID", true, DataSource)
                        {
                            QueryString = "DOTY_AUTOID"
                        };
                        ListControl.Add(cfr);
                        ListControl.Add("Mã chứng từ", ControlType.TextField, DataType.String, "txtDOC_DOCUMENTNO");
                        ListControl.Add("Ngày chứng từ", ControlType.DateField, DataType.Date, "txtDOC_DOCUMENTDATE");
                        ListControl.Add("Ngày ghi sổ", ControlType.DateField, DataType.Date, "txtDOC_POSTTINGDATE");

                        StoreName = "spFinderPurOrder";
                        GridFinder = new GridFinder("Danh sách hoá đơn nhập khẩu", false);
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "DOC_DOCUMENTID", string.Empty, "DOC_DOCUMENTID", true, true);
                        GridFinder.Add("Mã chứng từ", 100, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", false);
                        GridFinder.Add("Ngày chứng từ", 150, true, "DOC_DOCUMENTDATE", string.Empty, "DOC_DOCUMENTDATE", false);
                        GridFinder.Add("Ngày ghi sổ", 150, true, "DOC_POSTTINGDATE", string.Empty, "DOC_POSTTINGDATE", false);
                        GridFinder.Add("Ghi chú", 200, true, "DOC_DESCRIPTION", string.Empty, "DOC_DESCRIPTION", false);

                        GridFinder.Add(string.Empty, 100, true, "CUR_AUTOID", string.Empty, "CUR_AUTOID", true);
                        GridFinder.Add(string.Empty, 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true);
                        GridFinder.Add(string.Empty, 100, true, "PURO_EXCHANGERATE", string.Empty, "PURO_EXCHANGERATE", true);
                        for (int i = 6; i < GridFinder.ListColumn.Count; i++)
                            GridFinder.ListColumn[i].IsHidden = true;
                    }
                    #endregion
                    break;
                case "IV":
                    #region Invoice finder
                    {
                        /*List<PUBDOCUMENTTYPE> lstDocType = PUBDOCUMENTTYPEDAO.GetByInvoice();
                        if (lstDocType.Count > 0)
                            foreach (PUBDOCUMENTTYPE doctype in lstDocType)
                                DataSource.Add(new DataItem(doctype.DOTY_NAME, doctype.DOTY_AUTOID));
                        ControlFinder cfr = new ControlFinder("Loại chứng từ", ControlType.Combobox, DataType.Int, "txtDOTY_AUTOID", true, DataSource);*/
                        ListControl.Add("Mã chứng từ", ControlType.TextField, DataType.String, "txtDOC_DOCUMENTNO");
                        ListControl.Add("Số hoá đơn", ControlType.TextField, DataType.String, "txtIV_DOCUMENTNUM");
                        ListControl.Add("Ngày chứng từ", ControlType.DateField, DataType.Date, "txtDOC_DOCUMENTDATE");
                        ListControl.Add("Ngày ghi sổ", ControlType.DateField, DataType.Date, "txtDOC_POSTTINGDATE");
                        ControlFinder cfr = new ControlFinder(string.Empty, ControlType.HiddenField, DataType.Int, "txtDOTY_AUTOID", true)
                        {
                            QueryString = "DOTY_AUTOID"
                        };
                        ListControl.Add(cfr);

                        StoreName = "spFinderIV";

                        GridFinder = new GridFinder("Danh sách hoá xuat khẩu", false);
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "DOC_DOCUMENTID", string.Empty, "DOC_DOCUMENTID", true, true);
                        GridFinder.Add("Mã chứng từ", 100, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", false);
                        GridFinder.Add("Số hoá đơn", 100, true, "IV_DOCUMENTNUM", string.Empty, "IV_DOCUMENTNUM", true);
                        GridFinder.Add("Ngày chứng từ", 150, true, "DOC_DOCUMENTDATE", string.Empty, "DOC_DOCUMENTDATE", true);
                        GridFinder.Add("Ngày ghi sổ", 150, true, "DOC_POSTTINGDATE", string.Empty, "DOC_POSTTINGDATE", false);
                        GridFinder.Add("Ghi chú", 200, true, "DOC_DESCRIPTION", string.Empty, "DOC_DESCRIPTION", false);

                        GridFinder.Add(string.Empty, 100, true, "CUR_AUTOID", string.Empty, "CUR_AUTOID", true);
                        GridFinder.Add(string.Empty, 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true);
                        GridFinder.Add(string.Empty, 100, true, "IV_CURENTCYRATE", string.Empty, "IV_CURENTCYRATE", true);
                        GridFinder.Add(string.Empty, 100, true, "PTE_DUEDATE", string.Empty, "PTE_DUEDATE", true);
                        for (int i = 6; i < GridFinder.ListColumn.Count; i++)
                            GridFinder.ListColumn[i].IsHidden = true;
                    }
                    #endregion
                    break;
                case "PubProject":
                    #region project finder
                    {
                        ListControl.Add("Mã dự án", ControlType.TextField, DataType.String, "txtPRJ_PROJECTNO");
                        ListControl.Add("Tên dự án", ControlType.TextField, DataType.String, "txtPRJ_NAME");
                        ListControl.Add("Ngày tạo", ControlType.DateField, DataType.Date, "txtPRJ_CREATEDATE");

                        StoreName = "spPUBOBJECTFilter";

                        GridFinder = new GridFinder("Danh sách dự án", false);
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "PRJ_AUTOID", string.Empty, "PRJ_AUTOID", true, true);
                        GridFinder.Add("Mã dự án", 100, true, "PRJ_PROJECTNO", string.Empty, "PRJ_PROJECTNO", true);
                        GridFinder.Add("Tên dự án", 200, true, "PRJ_NAME", string.Empty, "PRJ_NAME", true);
                        GridFinder.Add("Ngày tạo", 200, true, "PRJ_CREATEDATE", string.Empty, "PRJ_CREATEDATE", false);
                        GridFinder.Add("Ghi chú", 200, true, "PRJ_DESCRIPTION", string.Empty, "PRJ_DESCRIPTION", false);
                    }
                    #endregion
                    break;
                case "PubError":
                    #region puberror finder
                    {
                        ListControl.Add("Mã lỗi", ControlType.TextField, DataType.String, "txtERR_ERRORID");
                        ListControl.Add("Tên lỗi", ControlType.TextField, DataType.String, "txtERR_NAME");

                        StoreName = "spFinderError";

                        GridFinder = new GridFinder("Danh sách lỗi", false);
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "ERR_AUTOID", string.Empty, "ERR_AUTOID", true, true);
                        GridFinder.Add("Mã lỗi", 100, true, "ERR_ERRORID", string.Empty, "ERR_ERRORID", true);
                        GridFinder.Add("Tên lỗi", 200, true, "ERR_NAME", string.Empty, "ERR_NAME", true);
                        GridFinder.Add("Ghi chú", 300, true, "ERR_DESCRIPTION", string.Empty, "ERR_DESCRIPTION", false);
                    }
                    #endregion
                    break;
                case "Contact":
                    #region pubcontact finder
                    {
                        ControlFinder finder = new ControlFinder(string.Empty, ControlType.HiddenField, DataType.Int, "txtOBJ_AUTOID", true)
                        {
                            QueryString = "OBJ_AUTOID"
                        };
                        ListControl.Add(finder);
                        ListControl.Add("Tên liên hệ", ControlType.TextField, DataType.String, "txtCON_NAME");
                        ListControl.Add("Email", ControlType.TextField, DataType.String, "txtCON_EMAIL");

                        StoreName = "spFinderContact";
                        GridFinder = new GridFinder("Danh sách liên hệ", false);

                        GridFinder.Add(string.Empty, string.Empty, 10, true, "CON_AUTOID", string.Empty, "CON_AUTOID", true, true);
                        GridFinder.Add("Tên liên hệ", 150, true, "CON_NAME", string.Empty, "CON_NAME", true);
                        GridFinder.Add("Điện thoại", 100, true, "CON_PHONENUMBER1", string.Empty, "CON_PHONENUMBER1");
                        GridFinder.Add("Fax", 100, true, "CON_FAXNO", string.Empty, "CON_FAXNO");
                        GridFinder.Add("Email", 100, true, "CON_EMAIL", string.Empty, "CON_EMAIL");
                        GridFinder.Add("Địa chỉ", 100, true, "CON_ADDRESS1", string.Empty, "CON_ADDRESS1");
                    }
                    #endregion
                    break;
                //Author  :ninnt
                //Create date :11:30 AM 11/05/09
                //Purpost  : create finder for the PubOject
                case "PubOject":
                    #region OjectFinder
                    {
                        this.ListControl.Add("Mã Người chi", ControlType.TextField, DataType.String, "txtOBJ_OBJECTNO");
                        this.ListControl.Add("Tên người chi", ControlType.TextField, DataType.String, "txtOBJ_NAME");

                        this.StoreName = "spFinderOject";
                        this.GridFinder.Add("Mã hệ thống", 50, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true);
                        this.GridFinder.Add("Mã Người chi", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", false);
                        this.GridFinder.Add("Tên Người chi", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                    }
                    #endregion OjectFinder
                    break;
                case "ObjectGL":
                    #region finder objectID
                    {
                        ControlFinder ctrl = new ControlFinder("Đối tượng", ControlType.HiddenField, DataType.String, "OBJ_AUTOID", true);
                        ctrl.QueryString = "ObjID";
                        ListControl.Add(ctrl);
                        StoreName = "spFinderOjectGL";

                        GridFinder = new GridFinder("Danh sách đối tượng", false);
                        this.GridFinder.Add("Mã hệ thống", 50, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true);
                        //this.GridFinder.Add("Mã Người chi", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", false);
                        this.GridFinder.Add("Tên Người chi", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        this.GridFinder.Add("Loại đối tượng", 200, true, "OBJT_NAME", string.Empty, "OBJT_NAME", true);
                        this.GridFinder.Add("Mã Loại đối tượng", 50, true, "OBJT_AUTOID", string.Empty, "OBJT_AUTOID", true);
                    }
                    #endregion
                    break;

                //Ninnt
                //FinderAccountGL
                case "AccountGL":
                    #region pubaccount finder
                    {
                        ControlFinder ctrl = new ControlFinder("Tài khoản", ControlType.HiddenField, DataType.String, "ACC_CODE", true);
                        ctrl.QueryString = "AccID";
                        ListControl.Add(ctrl);
                        StoreName = "spFinderAccountGL";

                        GridFinder = new GridFinder("Danh sách tài khoản", false);
                        // GridFinder.Add("PIT_AUTOID", string.Empty, 100, true, "PIT_AUTOID", string.Empty, "PIT_AUTOID", true, true);
                        GridFinder.Add("Số tài khoản", string.Empty, 120, true, "ACC_CODE", string.Empty, "ACC_CODE", true);
                        GridFinder.Add("Tên tài khoản", 200, true, "ACC_NAME", string.Empty, "ACC_NAME", false);
                        GridFinder.Add("Mã đối chi nhánh", 100, true, "ORG_AUTOID", string.Empty, "ORG_AUTOID", false);
                        GridFinder.Add("Tên chi nhánh", 200, true, "ORG_NAME", string.Empty, "ORG_NAME", false);
                    }
                    #endregion
                    break;
                //Tannv
                case "Menu":
                    #region Menu
                    {
                        ListControl.Add("Tên và ID", ControlType.TextField, DataType.String, "IDANDNAME");
                        StoreName = "spMenu";
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "MenuAutoID", string.Empty, "MenuAutoID", true, true);
                        GridFinder.Add("ID Menu", 100, true, "ID", string.Empty, "ID", true);
                        GridFinder.Add("Tên Menu", 100, true, "NAME", string.Empty, "NAME", true);
                        GridFinder.Add("Đường dẫn", 200, true, "URL", string.Empty, "URL", true);
                        GridFinder.Add("Chú thích", 200, true, "DESCRIPTION", string.Empty, "DESCRIPTION", false);
                    }
                    break;
                    #endregion
                case "Page":
                    #region Page
                    {
                        ListControl.Add("Tên và ID", ControlType.TextField, DataType.String, "IDANDNAME");
                        StoreName = "SP_META_FINDERPAGE";
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "PA_AUTOID", string.Empty, "PA_AUTOID", true, true);
                        GridFinder.Add("ID trang", 150, true, "PA_PAGEID", string.Empty, "PA_PAGEID", true);
                        GridFinder.Add("Tên trang", 150, true, "PA_PAGENAME", string.Empty, "PA_PAGENAME", true);
                        GridFinder.Add("Phân hệ", 80, true, "SUBS_NAME", string.Empty, "SUBS_NAME", true);
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "PA_ISACTIVE", string.Empty, "PA_ISACTIVE", true, true);
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "SUBS_AUTOID", string.Empty, "SUBS_AUTOID", true, true);
                        GridFinder.Add(string.Empty, string.Empty, 10, true, "PA_ISCHECKROLE", string.Empty, "PA_ISCHECKROLE", true, true);
                    }
                    break;
                    #endregion
                //Tannv
                case "PhanHe":
                    #region PhanHe
                    {
                        StoreName = "spbSubSystem4Finder";

                        GridFinder.Add(string.Empty, string.Empty, 10, true, "SUBS_AUTOID", string.Empty, "SUBS_AUTOID", true, true);
                        GridFinder.Add("Tên phân hệ", 100, true, "SUBS_NAME", string.Empty, "SUBS_NAME", true);
                        GridFinder.Add("Chú thích", 100, true, "SUBS_DESCRIPTION", string.Empty, "SUBS_DESCRIPTION", true);
                    }
                    break;
                    #endregion
                //Tannv
                case "NgonNgu":
                    #region NgonNgu
                    {
                        StoreName = "spLanguage";

                        GridFinder.Add(string.Empty, string.Empty, 10, true, "LANG_AUTOID", string.Empty, "LANG_AUTOID", true, true);
                        GridFinder.Add("Tên ngôn ngữ", 100, true, "LANG_NAME", string.Empty, "LANG_NAME", true);
                        GridFinder.Add("Chú thích", 100, true, "LANG_DESCRIPTION", string.Empty, "LANG_DESCRIPTION", true);
                    }
                    break;
                    #endregion
                //Tannv
                case "NhomTaiSan":
                    #region NhomTaiSan
                    {
                        ListControl.Add("Tên nhóm", ControlType.TextField, DataType.String, "ACIG_NAME");
                        ListControl.Add("Mô tả", ControlType.TextField, DataType.String, "ACIG_DESCRIPTION");
                        StoreName = "spAmAssetGroup";

                        GridFinder.Add(string.Empty, "ACIG_AUTOID", 10, true, "ACIG_AUTOID", string.Empty, "ACIG_AUTOID", true, true);
                        GridFinder.Add("Tên nhóm", 100, true, "ACIG_NAME", string.Empty, "ACIG_NAME", true);
                        GridFinder.Add("Mô tả", 100, true, "ACIG_DESCRIPTION", string.Empty, "ACIG_DESCRIPTION", true);
                    }
                    #endregion
                    break;
                //Mục đích sử dụng
                case "PurposeUse":
                    #region PurposeUse
                    {
                        ListControl.Add("Tên mục đích", ControlType.TextField, DataType.String, "PPU_NAME");
                        ListControl.Add("Diễn giải", ControlType.TextField, DataType.String, "PPU_DESCRIPTION");

                        StoreName = "spIcPurposeSelectActived";

                        GridFinder.Add(string.Empty, string.Empty, 10, true, "PPU_AUTOID", string.Empty, "PPU_AUTOID", true, true);
                        GridFinder.Add("Tên mục đích", 100, true, "PPU_NAME", string.Empty, "PPU_NAME", true);
                        GridFinder.Add("Diễn giải", 100, true, "PPU_DESCRIPTION", string.Empty, "PPU_DESCRIPTION", false);
                    }
                    break;
                    #endregion
                case "ObjectContact":
                    #region Menu
                    {
                        ListControl.Add(new ControlFinder
                       {
                           FieldLabel = "Mã",
                           ID = "txtID",
                           ControlType = ControlType.TextField,
                           IsControlGetValue = true,
                           DataType = DataType.String,
                           //  QueryString = "ObjContact",
                           //  IsFocus = true
                       });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtObjName",
                            ControlType = ControlType.TextField,
                            IsControlGetValue = true,
                            DataType = DataType.String,
                            // QueryString = "ObjContact",
                            //  IsFocus = true
                        });

                        //ListControl.Add("Menu Id", ControlType.TextField, DataType.String, "ID");
                        //ListControl.Add("Tên menu", ControlType.TextField, DataType.String, "NAME");
                        ControlFinder ctrl2 = new ControlFinder("", ControlType.HiddenField, DataType.Int, "OBJID", true);
                        ctrl2.QueryString = "OBJID";
                        ListControl.Add(ctrl2);
                        StoreName = "SP_META_FINDCONTACTBYID_PUBOBJECT";

                        GridFinder.Add("AUTOID", string.Empty, 10, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        GridFinder.Add("Tên đối tượng", 100, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        GridFinder.Add("Mã đối tượng", 100, true, "OBJ_OBJECTNO", string.Empty, "OBJ_OBJECTNO", true);
                        GridFinder.Add("Mã số thuế", 200, true, "OBJ_TAXID", string.Empty, "OBJ_TAXID", true);
                        GridFinder.Add("Địa chỉ", 200, true, "OBJ_ADDRESS", string.Empty, "OBJ_ADDRESS", false);
                    }
                    break;
                    #endregion

                //Tondb
                case "UserInfo":
                    #region UserInfo
                    {
                        this.ListControl.Add("Tên Nhân Viên", ControlType.TextField, DataType.String, "OBJ_NAME", true);
                        this.ListControl.Add("Số CMND", ControlType.TextField, DataType.String, "OBJ_IDENTIFYID", true);
                        this.StoreName = "spFinderUserinfo";

                        this.GridFinder = new GridFinder("Danh sách đối tượng", false);

                        this.GridFinder.Add("OBJ_AUTOID", "Mã AUTO", 100, true, "OBJ_AUTOID", string.Empty, "OBJ_AUTOID", true, true);
                        //1
                        this.GridFinder.Add("Tên đối tượng", 100, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        //2
                        this.GridFinder.Add("Ngày sinh", 100, true, "OBJ_BIRTHDAY", string.Empty, "OBJ_BIRTHDAY", true);
                        //3
                        this.GridFinder.Add("Mã Số Thuế", 100, true, "OBJ_SERIALTAX", string.Empty, "OBJ_SERIALTAX", true);
                        //4
                        this.GridFinder.Add("Số CMND", 100, true, "OBJ_IDENTIFYID", string.Empty, "OBJ_IDENTIFYID", true);

                    }
                    #endregion
                    break;

                //Tondb
                case "AsseitemNO":
                    {
                        #region AsseitemNO
                        ListControl.Add("Mã Tài Sản", ControlType.TextField, DataType.String, "ASI_ASSETITEMNO", true);
                        ListControl.Add("Tên Tài Sản", ControlType.TextField, DataType.String, "PIT_ITEMNO", true);

                        this.StoreName = "spFinderAsseitemNO";

                        this.GridFinder = new GridFinder("Danh sách  Tài Sản", false);

                        this.GridFinder.Add("ASI_AUTOID", "Mã AUTO", 100, true, "ASI_AUTOID", string.Empty, "ASI_AUTOID", true, true);//0
                        this.GridFinder.Add("Mã Tài Sản", 100, true, "ASI_ASSETITEMNO", string.Empty, "ASI_ASSETITEMNO", true);//1
                        this.GridFinder.Add("Mã Item", 100, true, "PIT_ITEMNO", string.Empty, "PIT_ITEMNO", true);//2       
                        this.GridFinder.Add("Tên Tài Sản", 100, true, "PIT_ITEMNAME", string.Empty, "PIT_ITEMNAME", true);//3

                        this.GridFinder.Add("Diễn Giải", 100, true, "ASI_DESCRIPTION", string.Empty, "ASI_DESCRIPTION", true);//4


                    }
                        #endregion
                    break;
                //Thanhdh
                case "AssetGroup":
                    #region Asset
                    {


                        this.ListControl.Add("Mã tài sản", ControlType.TextField, DataType.String, "ACIG_AUTOID");
                        this.ListControl.Add("Tên tài sản", ControlType.TextField, DataType.String, "ACIG_NAME");

                        this.StoreName = "spFinderAssetGroup";

                        this.GridFinder = new GridFinder("Dự án", true);
                        this.GridFinder.Add("Mã tài sản", 100, true, "ACIG_AUTOID", string.Empty, "ACIG_AUTOID", true);
                        this.GridFinder.Add("Tên tài sản", 200, true, "ACIG_NAME", string.Empty, "ACIG_NAME", true);
                        this.GridFinder.Add("Tài khoản nguyên giá", 200, true, "ACC_ORIACCOUNT", string.Empty, "ACC_ORIACCOUNT", true);
                        this.GridFinder.Add("Tài khoản hao mòn", 200, true, "ACC_WEARACCOUNT", string.Empty, "ACC_WEARACCOUNT", true);
                        this.GridFinder.Add("Tài khoản trích khấu hao", 200, true, "ACC_COSTPRICEACCOUNT", string.Empty, "ACC_COSTPRICEACCOUNT", true);



                    }
                    break;
                    #endregion
                ///Tondb
                ///Finder số tài khoản cho Module AM
                case "tangibleASSET":
                    #region MyRegion
                    {

                        ListControl.Add("Số TK", ControlType.TextField, DataType.String, "txtACC_CODE");
                        ListControl.Add("Tên TK", ControlType.TextField, DataType.String, "txtACC_NAME");
                        //ControlFinder ctl = new ControlFinder("Chi Nhánh", ControlType.HiddenField, DataType.String, "txtORG_AUTOID");
                        //ctl.QueryString = "orgid";

                        //ListControl.Add(ctl);
                        this.StoreName = "getAccount";
                        this.GridFinder = new GridFinder("Danh sách số tài khoản", false);
                        this.GridFinder.Add("Số Tài khoản", 100, true, "ACC_CODE", string.Empty, "ACC_CODE", true);
                        this.GridFinder.Add("Tên Tài khoản", 100, true, "ACC_NAME", string.Empty, "ACC_NAME", true);
                        this.GridFinder.Add("Loại Tài khoản", 100, true, "ACCT_NAME", string.Empty, "ACCT_NAME", true);
                        this.GridFinder.Add("Tài khoản cha", 100, true, "ACC_PARENTID", string.Empty, "ACC_PARENTID", true);
                    }
                    #endregion

                    break;
                //Tondb-AssemblySubDetail
                case "AssemblySubDetail":
                    #region MyRegion
                    {
                        ControlFinder ctrf = new ControlFinder("Tên BOM", ControlType.HiddenField, DataType.String, "BOM_BOMNO", true);
                        ctrf.QueryString = "BOMNO";
                        ListControl.Add(ctrf);
                        ListControl.Add("Mã vật tư", ControlType.TextField, DataType.String, "PIT_ITEMNO", true);
                        ListControl.Add("Tên Version", ControlType.TextField, DataType.String, "PBV_NAME", true);
                        //ControlFinder ctrl = new ControlFinder("Loại vật tư", ControlType.Combobox, DataType.String, "ITET_AUTOID", true);
                        //ctrl.QueryString = "typeid";
                        //ListControl.Add(ctrl);
                        List<PUBITEMSGROUP> lstClass = PUBITEMSGROUPDAO.GetAllActive();
                        if (lstClass.Count > 0)
                            foreach (PUBITEMSGROUP objClass in lstClass)
                                DataSource.Add(new DataItem(objClass.ITG_NAME, objClass.ITG_AUTOID));
                        ListControl.Add("Thuộc nhóm", ControlType.Combobox, DataType.Int, "ITG_AUTOID", true, DataSource);

                        StoreName = "spFinderAssemblySubDetail";
                        GridFinder = new GridFinder("Danh sách vât tư lắp ghép", false);
                        GridFinder.Add("BOMD_AUTOID", string.Empty, 100, true, "BOMD_AUTOID", string.Empty, "BOMD_AUTOID", true, true);
                        GridFinder.Add("BOM_AUTOID", string.Empty, 100, true, "BOM_AUTOID", string.Empty, "BOM_AUTOID", true, true);
                        GridFinder.Add("Tên BOM", 100, true, "BOM_BOMNO", string.Empty, "BOM_BOMNO", true);
                        GridFinder.Add("PIT_AUTOID", string.Empty, 100, true, "PIT_AUTOID", string.Empty, "PIT_AUTOID", true, true);//3
                        GridFinder.Add("Mã vật tư", 100, true, "PIT_ITEMNO", string.Empty, "PIT_ITEMNO", true);//4
                        GridFinder.Add("Tên vật tư", 100, true, "PIT_ITEMNAME", string.Empty, "PIT_ITEMNAME", true);
                        GridFinder.Add("Tên Version", 100, true, "PBV_NAME", string.Empty, "PBV_NAME", false);
                        GridFinder.Add("UOM_AUTOID", string.Empty, 100, true, "UOM_AUTOID", string.Empty, "UOM_AUTOID", true, true);//6
                        GridFinder.Add("SL theo BOM", 100, true, "BOMD_QUANTITY1", string.Empty, "BOMD_QUANTITY1", true);//7
                        GridFinder.Add("Đơn vị tính", 100, true, "UOM_NAME", string.Empty, "UOM_NAME", true);
                        GridFinder.Add("ITG_AUTOID", string.Empty, 100, true, "ITG_AUTOID", string.Empty, "ITG_AUTOID", true, true);
                        GridFinder.Add("Loại vật tư", 100, true, "ITG_NAME", string.Empty, "ITG_NAME", true);//10
                        GridFinder.Add("PIT_ISSERIAL", string.Empty, 100, true, "PIT_ISSERIAL", string.Empty, "PIT_ISSERIAL", true, true);
                        //GridFinder.Add("UOM_NAME", string.Empty, 100, true, "UOM_NAME", string.Empty, "UOM_NAME", true, true);//12

                    }

                    #endregion

                    break;
                //Tondb-PubBomDetail
                case "AssemblyItems":
                    #region MyRegion
                    {
                        ListControl.Add("Mã sản phẩm", ControlType.TextField, DataType.String, "PIT_ITEMNO", true);
                        ListControl.Add("Tên sản phẩm", ControlType.TextField, DataType.String, "PIT_ITEMNAME", true);
                        ListControl.Add("Theo BOM", ControlType.TextField, DataType.String, "BOM_BOMNO", true);
                        ListControl.Add("Phiên bản", ControlType.TextField, DataType.String, "PBV_NAME", true);
                        //ControlFinder ctrORG_ID = new ControlFinder("", ControlType.HiddenField, DataType.Int, "ORG_AUTOID", true);
                        //ctrORG_ID.QueryString = "ORGID";
                        //ListControl.Add(ctrORG_ID);
                        StoreName = "sp_IC_FinderItemsforAssembly";

                        GridFinder = new GridFinder("Danh sách sản phẩm", false);
                        GridFinder.Add("PIT_AUTOID", string.Empty, 100, true, "PIT_AUTOID", string.Empty, "PIT_AUTOID", true, true);
                        GridFinder.Add("Mã sản phẩm", 100, true, "PIT_ITEMNO", string.Empty, "PIT_ITEMNO", false);
                        GridFinder.Add("Tên sản phẩm", 200, true, "PIT_NAME", string.Empty, "PIT_NAME", false);
                        GridFinder.Add("", string.Empty, 100, true, "BOM_AUTOID", string.Empty, "BOM_AUTOID", true, true);
                        GridFinder.Add("Theo BOM", 200, true, "BOM_BOMNO", string.Empty, "BOM_BOMNO", false);
                        GridFinder.Add("", string.Empty, 100, true, "PBV_AUTOID", string.Empty, "PBV_AUTOID", true, true);
                        GridFinder.Add("Phiên bản", 200, true, "PBV_NAME", string.Empty, "PBV_NAME", false);
                        GridFinder.Add("Loại sản phẩm", 200, true, "ITG_NAME", string.Empty, "ITG_NAME", false);
                        GridFinder.Add("ITG_AUTOID", "Mã loại", 200, true, "ITG_AUTOID", string.Empty, "ITG_AUTOID", true, true);
                        GridFinder.Add("BOM_AUTOID", "BomID", 200, true, "BOM_AUTOID", string.Empty, "BOM_AUTOID", true, true);
                        GridFinder.Add("Theo Bom", 200, true, "BOM_BOMNO", string.Empty, "BOM_BOMNO", true);
                        GridFinder.Add("PBV_AUTOID", "VersionID", 200, true, "PBV_AUTOID", string.Empty, "PBV_AUTOID", true, false);
                        GridFinder.Add("", "Hai đơn vị tính", 200, false, "PIT_ISTWOUOM", string.Empty, "PIT_ISTWOUOM", true, true);//9
                        GridFinder.Add("", "Is Serial", 200, false, "PIT_ISSERIAL", string.Empty, "PIT_ISSERIAL", true, true);//10
                        GridFinder.Add("", "Theo Lô", 200, true, "PIT_ISPLOT", string.Empty, "PIT_ISPLOT", true, true);

                    }
                    #endregion

                    break;
                //Tondb-Contract
                case "contractwithcurrencyAss":
                    #region contractwithcurrency
                    {
                        //init control
                        this.ListControl.Add("Mã hợp đồng", ControlType.TextField, DataType.String, "txtContractNo", true);
                        this.ListControl.Add("Ngày ký từ", ControlType.DateField, DataType.Float, "dtFromdate");
                        this.ListControl.Add("Đến", ControlType.DateField, DataType.Float, "dtTodate");
                        this.ListControl.Add("Diễn giải", ControlType.TextField, DataType.String, "txtDescription");
                        ControlFinder ctrlCur = new ControlFinder("Loại tiền", ControlType.HiddenField, DataType.Int, "txtCurency", true);
                        ctrlCur.QueryString = "curautoid";
                        this.ListControl.Add(ctrlCur);

                        //store DB
                        this.StoreName = "spFinderContractforApportion";
                        //init Grid
                        this.GridFinder = new GridFinder("Danh sách hợp đồng", true);

                        this.GridFinder.Add(string.Empty, string.Empty, 10, true, "COT_AUTOID", string.Empty, "COT_AUTOID", true, true);
                        this.GridFinder.Add("Mã hợp đồng", 200, true, "COT_CONTRACTNO", string.Empty, "COT_CONTRACTNO", true);
                        this.GridFinder.Add("Ngày ký", 200, true, "COT_ASIGNDATE", string.Empty, "COT_ASIGNDATE");
                        this.GridFinder.Add("Ngày hết hạn", 200, true, "COT_EXPIREDATE", string.Empty, "COT_EXPIREDATE");
                        this.GridFinder.Add("Diễn giải", 100, true, "COT_DESCRIPTION", string.Empty, "COT_DESCRIPTION");
                    }
                    #endregion
                    break;
                //Tonbdb-Bomversion
                case "BomVersionAssembly":
                    #region MyRegion
                    {

                        ControlFinder ctrPIT_ID = new ControlFinder("", ControlType.HiddenField, DataType.Int, "PIT_AUTOID", true);
                        ctrPIT_ID.QueryString = "PIT_ID";
                        this.ListControl.Add(ctrPIT_ID);
                        ControlFinder ctrBom_No = new ControlFinder("", ControlType.HiddenField, DataType.String, "BOM_BOMNO", true);
                        ctrBom_No.QueryString = "BOM_NO";
                        this.ListControl.Add(ctrBom_No);
                        //ListControl.Add("Mã Bom", ControlType.TextField, DataType.String, "BOM_BOMNO", true);
                        // ListControl.Add("Mã Version", ControlType.TextField, DataType.String, "PBV_NAME", true);

                        StoreName = "spFinderBomVersionforAssembly";

                        GridFinder = new GridFinder("Danh sách Bom", false);

                        GridFinder.Add("BOM_AUTOID", "BomID", 200, true, "BOM_AUTOID", string.Empty, "BOM_AUTOID", true, true);
                        GridFinder.Add("Theo Bom", 200, true, "BOM_NAME", string.Empty, "BOM_NAME", true);
                        GridFinder.Add("PBV_AUTOID", "VersionID", 200, true, "PBV_AUTOID", string.Empty, "PBV_AUTOID", true, true);
                        GridFinder.Add("Version", 200, true, "PBV_NAME", string.Empty, "PBV_NAME", true);
                        GridFinder.Add("DIễn giải", 200, true, "PBV_DESCRIPTION", string.Empty, "PBV_DESCRIPTION", true);
                    }
                    #endregion
                    break;
                case "PositionByWhId":
                    #region WareHouse & Position 4 Ic
                    {
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên vị trí",
                            IsFocus = true,
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtPOSITION",
                            IsControlGetValue = true,
                            QueryString = "ptna"
                        });
                        ListControl.Add("Tên kho", ControlType.TextField, DataType.String, "txtITP_NAME", true);
                        ControlFinder ctrl = new ControlFinder("", ControlType.HiddenField, DataType.Int, "whId", true);
                        ctrl.QueryString = "whId";
                        ListControl.Add(ctrl);
                        StoreName = "sp_IC_Finder_PositionByWhId";
                        GridFinder = new GridFinder("Danh sách các vị trí trong kho", true);
                        GridFinder.Add("Mã vị trí", "ITP_AUTOID", 50, true, "ITP_AUTOID", string.Empty, "ITP_AUTOID", true, true);
                        GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "NAME",
                            DataIndex = "ITP_NAME",
                            RecordField = "ITP_NAME",
                            Width = 150,
                            Sortable = true,
                            Header = "Tên vị trí"
                        });
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Diễn giải",
                            ColumnId = "ITP_DESCRIPTION",
                            DataIndex = "ITP_DESCRIPTION",
                            RecordField = "ITP_DESCRIPTION",
                            Sortable = true,
                            AutoExpandColumn = true
                        });

                        GridFinder.ListColumn[0].IsHidden = true;
                    }
                    #endregion
                    break;
                case "COSTPRICE":
                    #region CostPrice
                    {
                        //ListControl.Add("Tên Lô", ControlType.TextField, DataType.String, "ICP_NAME", true);
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã ĐT tập hợp",
                            IsFocus = true,
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "CP_DOCNO",
                            IsControlGetValue = true,
                            QueryString = "COSTPRICE"

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên ĐT tập hợp",
                            IsFocus = true,
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "CP_NAME",
                            IsControlGetValue = true

                        });

                        StoreName = "sp_CP_Finder_COSTPRICE";
                        GridFinder = new GridFinder("Danh sách ĐT tập hợp", true);
                        GridFinder.Add("Mã ", "CP_AUTOID", 50, true, "CP_AUTOID", string.Empty, "CP_AUTOID", true, true);
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã ",
                            ColumnId = "CP_DOCNO",
                            DataIndex = "CP_DOCNO",
                            RecordField = "CP_DOCNO",
                            Width = 120,
                            Sortable = true

                        });
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên ",
                            ColumnId = "CP_NAME",
                            DataIndex = "CP_NAME",
                            RecordField = "CP_NAME",
                            Width = 150,
                            Sortable = true

                        });
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Diễn giải ",
                            ColumnId = "CP_DECRIPTION",
                            DataIndex = "CP_DECRIPTION",
                            RecordField = "CP_DECRIPTION",
                            Width = 150,
                            Sortable = true,
                            AutoExpandColumn = true
                        });

                    } break;

                    #endregion
                case "PROJECTS":
                    #region Projects
                    {

                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã",
                            IsFocus = true,
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "PRJ_PROJECTNO",
                            IsControlGetValue = true,
                            QueryString = "PROJECTS"

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            IsFocus = true,
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "PRJ_NAME",
                            IsControlGetValue = true

                        });

                        StoreName = "sp_CP_Finder_PUBPROJECT";
                        GridFinder = new GridFinder("Danh sách án", true);
                        GridFinder.Add("Mã ", "PRJ_AUTOID", 50, true, "PRJ_AUTOID", string.Empty, "PRJ_AUTOID", true, true);
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã ",
                            ColumnId = "PRJ_PROJECTNO",
                            DataIndex = "PRJ_PROJECTNO",
                            RecordField = "PRJ_PROJECTNO",
                            Width = 120,
                            Sortable = true

                        });
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên ",
                            ColumnId = "PRJ_NAME",
                            DataIndex = "PRJ_NAME",
                            RecordField = "PRJ_NAME",
                            Width = 150,
                            Sortable = true

                        });
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Diễn giải ",
                            ColumnId = "PRJ_DESCRIPTION",
                            DataIndex = "PRJ_DESCRIPTION",
                            RecordField = "PRJ_DESCRIPTION",
                            Width = 150,
                            Sortable = true,
                            AutoExpandColumn = true
                        });

                    } break;
                    #endregion
                //Tondb-ICPLot
                case "ItemPlot":
                    {
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            IsFocus = true,
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtName",
                            IsControlGetValue = true,
                            QueryString = "Plot"

                        });

                        StoreName = "sp_IC_Finder_ICPLOT";
                        GridFinder = new GridFinder();
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = string.Empty,
                            RecordField = "ICP_AUTOID",
                            Width = 50,
                            ColumnId = "clAutoID",
                            DataIndex = "ICP_AUTOID",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Mã",
                            RecordField = "ICP_DOCUMENTNO",
                            Width = 50,
                            ColumnId = "clID",
                            DataIndex = "ICP_DOCUMENTNO",
                            IsReturnValue = true
                        });
                        GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên",
                            RecordField = "ICP_NAME",
                            Width = 50,
                            ColumnId = "clName",
                            DataIndex = "ICP_NAME",
                            IsReturnValue = true,
                            AutoExpandColumn = true
                        });
                    } break;
                //Tondb-AssetItemNoDecrease
                case "ItemNoDecreate":
                    #region ItemNoDecreate
                    {
                        ListControl.Add("Mã Tài Sản", ControlType.TextField, DataType.String, "ASI_ASSETITEMNO", true);
                        ListControl.Add("Tên Tài Sản", ControlType.TextField, DataType.String, "PIT_ITEMNAME", true);
                        ControlFinder ctrFinder = new ControlFinder("", ControlType.HiddenField, DataType.Int, "ACIG", true);
                        ctrFinder.QueryString = "ACIG";
                        // ListControl.Add(ctrFinder);
                        List<AMASSETGROUP> lstAssGroup = AMASSETGROUPDAO.getAMAssetgroupByParent(clsFormat.Int16ConvertNull(0));
                        if (lstAssGroup.Count > 0)
                        {
                            foreach (AMASSETGROUP item in lstAssGroup)

                                DataSource.Add(new DataItem(item.ACIG_AUTOID, item.ACIG_NAME));
                        }
                        ListControl.Add("Nhóm TS", ControlType.Combobox, DataType.Int, "ACIG_AUTOID", true, DataSource);

                        List<vnyi.Library.Meta.STATUS.PUBSTATUS> lstStatus = AMDECREASEDETAILDAO.getStatusFinder();
                        if (lstStatus.Count > 0)
                        {
                            foreach (vnyi.Library.Meta.STATUS.PUBSTATUS item in lstStatus)
                                DataSource.Add(new DataItem(item.ST_NAME, item.ST_AUTOID));
                            ListControl.Add("Trạng thái", ControlType.Combobox, DataType.Int, "ST_AUTOID", true, DataSource);

                        }
                        this.StoreName = "sp_AM_FinderItemNo_AMAssetItem";

                        this.GridFinder = new GridFinder("Danh sách  Tài Sản", false);

                        this.GridFinder.Add("ASI_AUTOID", "Mã AUTO", 100, true, "ASI_AUTOID", string.Empty, "ASI_AUTOID", true, true);//0
                        this.GridFinder.Add("Mã Tài Sản", 100, true, "ASI_ASSETITEMNO", string.Empty, "ASI_ASSETITEMNO", true);//1
                        this.GridFinder.Add("Tên Tài Sản", 100, true, "PIT_ITEMNAME", string.Empty, "PIT_ITEMNAME", true);//3
                        this.GridFinder.Add("Nhóm tài sản", 100, true, "ACIG_NAME", string.Empty, "ACIG_NAME", false);//2 
                        this.GridFinder.Add("", "ACIG_AUTOID", 100, true, "ACIG_AUTOID", string.Empty, "ACIG_AUTOID", true, true);//2
                        this.GridFinder.Add("Số lượng", 100, true, "ASI_QUANTITY", string.Empty, "ASI_QUANTITY", true);
                        this.GridFinder.Add("Nguyên giá TS", 100, true, "ASI_UNITPRICE", string.Empty, "ASI_UNITPRICE", true);
                        this.GridFinder.Add("", "CUR_AUTOID", 100, true, "CUR_AUTOID", string.Empty, "CUR_AUTOID", true, true);
                        this.GridFinder.Add("", "CUR_RATE", 100, true, "CUR_RATE", string.Empty, "CUR_RATE", true, true);
                        this.GridFinder.Add("", "ST_AUTOID", 100, true, "ST_AUTOID", string.Empty, "ST_AUTOID", true, true);
                        this.GridFinder.Add("", "ST_NAME", 100, true, "ST_NAME", string.Empty, "ST_NAME", true, true);
                        this.GridFinder.Add("", "AMP_WEAR", 100, true, "AMP_WEAR", string.Empty, "AMP_WEAR", true, true);
                        this.GridFinder.Add("", "VALUE", 100, true, "VALUE", string.Empty, "VALUE", true, true);
                        this.GridFinder.Add("", "QUANTITY", 100, true, "QUANTITY", string.Empty, "QUANTITY", true, true);
                        this.GridFinder.Add("Diễn Giải", 100, true, "ASI_DESCRIPTION", string.Empty, "ASI_DESCRIPTION", true);//4
                    }
                    #endregion
                    break;

                case "DOC_NoForListInOutStock":
                    #region MyRegion
                    {
                        ListControl.Add("Số chứng từ", ControlType.TextField, DataType.String, "txtDocNo");
                        ListControl.Add("Người tạo", ControlType.TextField, DataType.String, "txtCreateBy");
                        ListControl.Add("Ngày tạo từ", ControlType.DateField, DataType.Date, "txtFromDate");
                        ListControl.Add("Đến ngày", ControlType.DateField, DataType.Date, "txtToDate");

                        this.StoreName = "spFinderDocumentNOForListBus";
                        this.GridFinder = new GridFinder("Danh sách chứng từ nhập xuất kho", false);

                        // this.GridFinder.Add("Mã Auto", 100, true, "DOC_DOCUMENTID", string.Empty, "DOC_DOCUMENTID", true, true);
                        this.GridFinder.Add("Mã chứng từ", 100, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        this.GridFinder.Add("Người tạo", 100, true, "DOC_CREATEBY", string.Empty, "DOC_CREATEBY", true);
                        this.GridFinder.Add("Ngày tạo", 100, true, "DOC_CREATEDATE", string.Empty, "DOC_CREATEDATE", true);
                        this.GridFinder.Add("Diễn giải", 100, true, "DOC_DESCRIPTION", string.Empty, "DOC_DESCRIPTION", true);

                    }
                    #endregion
                    break;

                case "TemplateQuote":
                    #region TemplateQuote
                    {
                        ListControl.Add("Mã báo giá", ControlType.TextField, DataType.String, "ICP_NAME", true);
                        ListControl.Add("Người tạo", ControlType.TextField, DataType.String, "OBJ_NAME", true);
                        ListControl.Add("Từ ngày", ControlType.DateField, DataType.Date, "DATEFROM", true);
                        ListControl.Add("Đến ngày", ControlType.DateField, DataType.Date, "DATETO", true);
                        StoreName = "SP_COMMON_FINDERTEMPLATEQUOTE_QUOTE";
                        GridFinder = new GridFinder("Danh sách báo giá mẫu", false);
                        GridFinder.Add("DOC_DOCUMENTID", "MÃ AUTO", 1, true, string.Empty, string.Empty, "DOC_DOCUMENTID", true, true);
                        GridFinder.Add("Mã báo giá", 100, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        GridFinder.Add("Người tạo", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
                        GridFinder.Add("Ngày tạo", 100, true, "DOC_CREATEDATE", string.Empty, "DOC_CREATEDATE", true);
                    }
                    #endregion
                    break;
                case "objectNew":
                    #region objectNew
                    {
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã",
                            ID = "txtID",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            QueryString = "objno",
                            IsFocus = true,
                            IsControlGetValue = true,

                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên",
                            ID = "txtName",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String
                        });
                        ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Mã số thuế",
                            ID = "txtTaxID",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String
                        });
                        ControlFinder cboObjType = new ControlFinder
                        {
                            FieldLabel = "Loại",
                            ID = "txtType",
                            ControlType = ControlType.Combobox,
                            DataType = DataType.String
                        };
                        List<DataItem> lstData = new List<DataItem>();

                        lstData.Add(new DataItem
                        {
                            DataTextField = CatchingManager.Messager.getMessagerByKey(CatchingManager.keyWord.MessagerKey.All, Culture.Value).Messager,
                            DataValueField = "0"
                        });
                        lstData.Add(new DataItem { DataTextField = "Tổ chức", DataValueField = "1" });
                        lstData.Add(new DataItem { DataTextField = "cá nhận", DataValueField = "2" });
                        cboObjType.DataSource = lstData;
                        ListControl.Add(cboObjType);
                        ControlFinder ctrl = new ControlFinder("Loại", ControlType.HiddenField, DataType.String, "POG_OBJTYPE", true);
                        ctrl.QueryString = clsName.OBJTYPE;
                        ListControl.Add(ctrl);
                        ControlFinder ctrNotInID = new ControlFinder("", ControlType.HiddenField, DataType.String, "NotinObjID", true);
                        ctrNotInID.IsRequest = true;
                        ctrNotInID.QueryString = clsName.LSTOBJECTID;
                        StoreName = "   ";
                        GridFinder = new GridFinder
                        {
                            Title = "Danh sách đối tượng",
                            Mutiple = false,

                        };
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clAutoID",
                            DataIndex = "AUTOID",
                            Header = "Mã tự tăng",
                            RecordField = "AUTOID",
                            IsReturnValue = true,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clID",
                            DataIndex = "OBJECTNO",
                            Header = "Mã",
                            RecordField = "OBJECTNO",
                            IsReturnValue = true,
                            IsHidden = false,
                            Width = 100
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clName",
                            DataIndex = "OBJECTNAME",
                            Header = "Tên",
                            RecordField = "OBJECTNAME",
                            IsReturnValue = true,
                            IsHidden = false,
                            Width = 200,
                            AutoExpandColumn = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "clTaxID",
                            DataIndex = "TAX",
                            Header = "Mã số thuế",
                            RecordField = "TAX",
                            IsReturnValue = true,
                            IsHidden = false,
                            Width = 200
                        });

                        GridFinder.Add("COUNTRY", "MÃ AUTO", 1, true, string.Empty, string.Empty, "COUNTRY", true, true);
                        GridFinder.Add("Quốc gia", 200, true, "COUNTRYNAME", string.Empty, "COUNTRYNAME", true);
                        GridFinder.Add("PROVINCE", "MÃ AUTO", 1, true, string.Empty, string.Empty, "PROVINCE", true, true);
                        GridFinder.Add("Tỉnh thành", 100, true, "PROVINCENAME", string.Empty, "PROVINCENAME", true);
                        GridFinder.Add("PLACE", "MÃ AUTO", 1, true, string.Empty, string.Empty, "PLACE", true, true);
                        //GridFinder.Add("Place", 100, true, "PLACENAME", string.Empty, "PLACENAME", true);
                        GridFinder.Add("EMAIL", 100, true, "EMAIL", string.Empty, "EMAIL", true);
                        GridFinder.Add("WEB", 100, true, "WEB", string.Empty, "WEB", true);
                        GridFinder.Add("GROUPID", "MÃ AUTO", 1, true, string.Empty, string.Empty, "OBJTYPE", true, true);
                        GridFinder.Add("Loại", 100, true, "GROUPNAME", string.Empty, "TYPENAME", true);
                        GridFinder.Add("OFORG", "MÃ AUTO", 1, true, string.Empty, string.Empty, "OFORG", true, true);
                        GridFinder.Add("Thuộc tổ chức", 100, true, "OFORGNAME", string.Empty, "OFORGNAME", true);
                        GridFinder.Add("Diễn giải", 100, true, "DESCRIPTION", string.Empty, "DESCRIPTION", true);
                        GridFinder.Add("ACCCODE", "ACCCODE", 1, true, string.Empty, string.Empty, "ACCCODE", true, true);
                        GridFinder.Add("BANKACC", "Account", 1, true, string.Empty, string.Empty, "BANKACC", true, true);
                        GridFinder.Add("BANKID", "MÃ AUTO", 1, true, string.Empty, string.Empty, "BANKID", true, true);
                        GridFinder.Add("CUR", "MÃ AUTO", 1, true, string.Empty, string.Empty, "CUR", true, true);
                        GridFinder.Add("PAYID", "MÃ AUTO", 1, true, string.Empty, string.Empty, "PAYID", true, true);
                        GridFinder.Add("PTEID", "MÃ AUTO", 1, true, string.Empty, string.Empty, "PTEID", true, true);
                        GridFinder.Add("SMTID", "MÃ AUTO", 1, true, string.Empty, string.Empty, "SMTID", true, true);
                        GridFinder.Add("OBJ_ADDRESS", "Địa chỉ", 1, true, string.Empty, string.Empty, "OBJ_ADDRESS", true, true);
                        GridFinder.Add("OBJ_PHONE", "Điện thoại", 1, true, string.Empty, string.Empty, "OBJ_PHONE", true, true);


                    }
                    #endregion
                    break;
                case "beforeCm":
                    #region beforeCm
                    {
                        ControlFinder objid = new ControlFinder("Mã đối tượng", ControlType.HiddenField, DataType.String, "OBJ_AUTOID", true);
                        objid.QueryString = clsName.OBJID;
                        ControlFinder curid = new ControlFinder("Loại tiền", ControlType.HiddenField, DataType.String, "CUR_AUTOID", true);
                        curid.QueryString = clsName.CURRENCYID;
                        ListControl.Add(objid);
                        ListControl.Add(curid);
                        ListControl.Add("Mã phiếu", ControlType.TextField, DataType.String, "DOC_DOCUMENTNO", true);
                        ListControl.Add("Số phiếu", ControlType.TextField, DataType.String, "DOC_DOCUMENTNU", true);
                        ControlFinder cm = new ControlFinder("Loại phiếu", ControlType.HiddenField, DataType.String, "cm", true);
                        cm.QueryString = clsName.CM;
                        ControlFinder docid = new ControlFinder("Mã chứng từ công nợ", ControlType.HiddenField, DataType.String, "busid", true);
                        docid.QueryString = clsName.BUSINESSID;
                        ControlFinder tmpid = new ControlFinder("Mã bảng tạm", ControlType.HiddenField, DataType.String, "tmpid", true);
                        tmpid.QueryString = clsName.TempID;
                        ControlFinder tmpMo = new ControlFinder("Tiền thanh toán tạm", ControlType.HiddenField, DataType.String, "tmpMo", true);
                        tmpMo.QueryString = clsName.TempMoney;
                        ListControl.Add(cm);
                        ListControl.Add(docid);
                        ListControl.Add(tmpid);
                        ListControl.Add(tmpMo);
                        StoreName = "SP_CM_FINDERBEFORECM_CM";
                        GridFinder = new GridFinder("Danh sách phiếu thu (chi) trước", false);
                        GridFinder.Add("DOCUMENTID", "MÃ AUTO", 1, true, "DOCUMENTID", string.Empty, "DOCUMENTID", true, true);
                        GridFinder.Add("Mã phiếu", 100, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
                        GridFinder.Add("Số phiếu", 200, true, "DOC_DESCRIPTION", string.Empty, "DOC_DESCRIPTION", true);
                        GridFinder.Add("Diễn giải", 200, true, "DOC_DOCUMENTNU", string.Empty, "DOC_DOCUMENTNU", true);
                        GridFinder.Add("Số tiền", 100, true, "AMOUNT", string.Empty, "AMOUNT", true);
                        GridFinder.Add("Loại tiền", 100, true, "CUR_NAME", string.Empty, "CUR_NAME", true);
                    }
                    #endregion
                    break;
                /*=========================Nhóm RES=========================*/
                /*=========================Start=========================*/
                #region Nhóm RES
                case "ChoiceCategory":
                    {
                        this.LabelWidth = 80;

                        this.ListControl.Add(new ControlFinder
                        {
                            FieldLabel = "Tên danh mục",
                            ControlType = ControlType.TextField,
                            DataType = DataType.String,
                            ID = "txtName",
                            IsFocus = true
                        });
                        //this.ListControl.Add(new ControlFinder
                        //{
                        //    FieldLabel = "Tên danh mục",
                        //    ControlType = ControlType.TextField,
                        //    DataType = DataType.String,
                        //    ID = "txtName1",
                        //     IsNotParramter=false
                        //});
                        this.StoreName = "sp_RES_Finder_CHOICECATEGORY";
                        this.GridFinder = new GridFinder("Danh mục", true);
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            ColumnId = "ID",
                            Sortable = true,
                            DataIndex = "RECC_AUTOID",
                            Renderer = string.Empty,
                            RecordField = "RECC_AUTOID",
                            IsReturnValue = false,
                            IsHidden = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Tên",
                            Width = 150,
                            Sortable = true,
                            DataIndex = "RECC_NAME",
                            Renderer = string.Empty,
                            ColumnId = "RECC_NAME",
                            IsReturnValue = true
                        });
                        this.GridFinder.Add(new ColumnGridFinder
                        {
                            Header = "Diễn giải",
                            ColumnId = "clDescription",
                            Sortable = true,
                            DataIndex = "RECC_NOTE",
                            Renderer = string.Empty,
                            IsReturnValue = true,
                            AutoExpandColumn = true
                        });

                        break;
                    }
                //case "CreateDefault":
                //    {
                //        ListControl.Add("Mã hàng bán", ControlType.TextField, DataType.String, "PIT_ITEMNO");


                //        List<PUBITEMSGROUP> lstItemsGroup = PUBITEMSGROUPDAO.GetAllPUBITEMSGROUP(null, LoginInfo.BranchID, LoginInfo.Culture);
                //        List<DataItem> dataSource = new List<DataItem>();
                //        for (int i = 0; i < lstItemsGroup.Count; i++)
                //        {
                //            dataSource.Add(new DataItem(lstItemsGroup[i].ITG_NAME, lstItemsGroup[i].ITG_AUTOID));
                //        }

                //        this.ListControl.Add("Nhóm", ControlType.Combobox, DataType.String, "cboItemGroup", true, dataSource);
                //        ListControl.Add("Tên hàng bán", ControlType.TextField, DataType.String, "PIT_NAME");

                //        List<PUBUOM> lstUOM = PUBUOMDAO.GetAllPUBUOM();
                //        List<DataItem> dataSource1 = new List<DataItem>();
                //        for (int i = 0; i < lstUOM.Count; i++)
                //        {
                //            dataSource1.Add(new DataItem(lstUOM[i].UOM_NAME, lstUOM[i].UOM_AUTOID));
                //        }

                //        this.ListControl.Add("Đơn vị tính", ControlType.Combobox, DataType.String, "cboUOM", true, dataSource1);
                //        this.StoreName = "sp_RES_Finder_CREATEDEFAULT";
                //        this.GridFinder = new GridFinder("Danh sách Hàng Hóa", true);
                //        this.GridFinder.Add("PIT_AUTOID", "Item ID", 100, true, "PIT_AUTOID", string.Empty, "PIT_AUTOID", true, true);
                //        this.GridFinder.Add("Mã Hàng Bán", 200, true, "PIT_ITEMNO", string.Empty, "PIT_ITEMNO", true);
                //        this.GridFinder.Add("Tên Hàng Bán", 200, true, "PIT_NAME", string.Empty, "PIT_NAME", true);
                //        this.GridFinder.Add("ITG_AUTOID", "Item Group ID", 100, true, "ITG_AUTOID", string.Empty, "ITG_AUTOID", true, true);
                //        this.GridFinder.Add("Nhóm", 100, true, "ITG_NAME", string.Empty, "ITG_NAME", true);
                //        this.GridFinder.Add("UOM_AUTOID", "DVT ID", 100, true, "UOM_AUTOID", string.Empty, "UOM_AUTOID", true, true);
                //        this.GridFinder.Add("Đơn vị tính", 200, true, "UOM_NAME", string.Empty, "UOM_NAME", true);
                //    }
                //    break;
                case "DEPOSIT":
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESDOCUMENT.COLUMN_RBT_AUTOID,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.TextField,
                        DataType = DataType.String,
                        ID = RESDOCUMENT.COLUMN_RDO_DOCUMENTNO,
                        IsControlGetValue = true,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESDOCUMENT.COLUMN_RDO_CREATEBY,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESDOCUMENT.COLUMN_RDO_UPDATEBY,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESDOCUMENT.COLUMN_RDO_DELETEBY,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESRECEIPT.COLUMN_RPCE_TYPE,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESRECEIPT.COLUMN_RPCE_PAYBY,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESRECEIPT.COLUMN_RPCE_RECEIPTBY,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESRECEIPT.COLUMN_PAY_AUTOID,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESRECEIPT.COLUMN_CT_CARDNO,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESRECEIPT.COLUMN_RPCE_CARDNUMBER,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = RESRECEIPT.COLUMN_RPCE_ISLOCAL,
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = "DATEFROM",
                        IsControlGetValue = false,
                    });
                    ListControl.Add(new ControlFinder
                    {
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.Int,
                        ID = "DATETO",
                        IsControlGetValue = false,
                    });
                    StoreName = "sp_RES_LoadDepositList_RESPAYMENT";
                    GridFinder = new GridFinder("Danh sách phiếu cọc", false);
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "AUTOID",
                        ColumnId = RESRECEIPT.COLUMN_RPCE_DOCUMENTID,
                        DataIndex = RESRECEIPT.COLUMN_RPCE_DOCUMENTID,
                        RecordField = RESRECEIPT.COLUMN_RPCE_DOCUMENTID,
                        Width = 100,
                        IsReturnValue = true,
                        IsHidden = true,
                        Sortable = true
                    });
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "Mã phiếu",
                        ColumnId = RESDOCUMENT.COLUMN_RDO_DOCUMENTNO,
                        DataIndex = RESDOCUMENT.COLUMN_RDO_DOCUMENTNO,
                        RecordField = RESDOCUMENT.COLUMN_RDO_DOCUMENTNO,
                        IsReturnValue = true,
                        Width = 100,
                        Sortable = true
                    });
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "Người đặt cọc",
                        ColumnId = RESRECEIPT.COLUMN_RPCE_RECEIPTNAME,
                        DataIndex = RESRECEIPT.COLUMN_RPCE_RECEIPTNAME,
                        RecordField = RESRECEIPT.COLUMN_RPCE_RECEIPTNAME,
                        Width = 150,
                        Sortable = true
                    });
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "Ngày đặt cọc",
                        ColumnId = RESDOCUMENT.COLUMN_RDO_CREATEDATE,
                        DataIndex = RESDOCUMENT.COLUMN_RDO_CREATEDATE,
                        RecordField = RESDOCUMENT.COLUMN_RDO_CREATEDATE,
                        Width = 60,
                        Sortable = true
                    });
                    break;
                case "RESPROMOCARD":
                    ListControl.Add(new ControlFinder
                    {
                        FieldLabel = "Số thẻ/Mã vạch",
                        ControlType = ControlType.TextField,
                        DataType = DataType.String,
                        ID = RESPROMOCARD.COLUMN_RPC_DEFINEID,
                        IsControlGetValue = true,
                    });
                    StoreName = "sp_RES_Load_RESPROMOCARD";
                    GridFinder = new GridFinder("Danh sách thẻ khuyến mãi", false);
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "AUTOID",
                        ColumnId = RESPROMOCARD.COLUMN_RPC_AUTOID,
                        DataIndex = RESPROMOCARD.COLUMN_RPC_AUTOID,
                        RecordField = RESPROMOCARD.COLUMN_RPC_AUTOID,
                        Width = 100,
                        IsReturnValue = true,
                        IsHidden = true,
                        Sortable = true
                    });
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "Mã thẻ",
                        ColumnId = RESPROMOCARD.COLUMN_RPC_DEFINEID,
                        DataIndex = RESPROMOCARD.COLUMN_RPC_DEFINEID,
                        RecordField = RESPROMOCARD.COLUMN_RPC_DEFINEID,
                        IsReturnValue = true,
                        Width = 100,
                        Sortable = true
                    });
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "Ngày áp dụng",
                        ColumnId = RESPROMOCARD.COLUMN_RPC_APPLYDATE,
                        DataIndex = RESPROMOCARD.COLUMN_RPC_APPLYDATE,
                        RecordField = RESPROMOCARD.COLUMN_RPC_APPLYDATE,
                        Width = 60,
                        Sortable = true
                    });
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "Ngày kết thúc",
                        ColumnId = RESPROMOCARD.COLUMN_RPC_ENDDATE,
                        DataIndex = RESPROMOCARD.COLUMN_RPC_ENDDATE,
                        RecordField = RESPROMOCARD.COLUMN_RPC_ENDDATE,
                        Width = 60,
                        Sortable = true
                    });
                    break;
                case "RESDISCOUNTTYPE":
                    ListControl.Add(new ControlFinder
                    {
                        FieldLabel = "Tên chính sách",
                        ControlType = ControlType.TextField,
                        DataType = DataType.String,
                        ID = RESDISCOUNTTYPE.COLUMN_REDT_NAME,
                        IsFocus = true
                        //IsControlGetValue = true
                    });

                    ListControl.Add(new ControlFinder
                    {
                        FieldLabel = "Chi nhánh",
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.String,
                        ID = RESDISCOUNT_OBJECT.COLUMN_OBJ_AUTOID,
                        IsControlGetValue = true,
                        DefaultValue = null
                    });
                    ListControl.Add(new ControlFinder
                    {
                        FieldLabel = "Loại hình",
                        ControlType = ControlType.HiddenField,
                        DataType = DataType.String,
                        ID = RESDISCOUNTTYPE_APP.COLUMN_RBT_AUTOID,
                        IsControlGetValue = true,
                        DefaultValue = null,
                        QueryString = "Busi"
                    });

                    StoreName = "sp_RES_LoadForFinder_RESDISCOUNTTYPE";
                    GridFinder = new GridFinder("Danh sách chính sách", false);
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "AUTOID",
                        ColumnId = RESDISCOUNTTYPE.COLUMN_REDT_AUTOID,
                        DataIndex = RESDISCOUNTTYPE.COLUMN_REDT_AUTOID,
                        RecordField = RESDISCOUNTTYPE.COLUMN_REDT_AUTOID,
                        IsReturnValue = true,
                        Width = 60,
                        IsHidden = true,
                    });
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "Chính sách",
                        ColumnId = RESDISCOUNTTYPE.COLUMN_REDT_NAME,
                        DataIndex = RESDISCOUNTTYPE.COLUMN_REDT_NAME,
                        RecordField = RESDISCOUNTTYPE.COLUMN_REDT_NAME,
                        IsReturnValue = true,
                        Width = 250,
                        Sortable = true
                    });
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "Ngày bắt đầu",
                        ColumnId = RESDISCOUNT_DATE.COLUMN_REDT_STARTDATE,
                        DataIndex = RESDISCOUNT_DATE.COLUMN_REDT_STARTDATE,
                        RecordField = RESDISCOUNT_DATE.COLUMN_REDT_STARTDATE,
                        IsReturnValue = true,
                        Width = 150,
                        Sortable = true,
                    });
                    GridFinder.Add(new ColumnGridFinder
                    {
                        Header = "Ngày kết thúc",
                        ColumnId = RESDISCOUNT_DATE.COLUMN_REDT_ENDDATE,
                        DataIndex = RESDISCOUNT_DATE.COLUMN_REDT_ENDDATE,
                        RecordField = RESDISCOUNT_DATE.COLUMN_REDT_ENDDATE,
                        IsReturnValue = true,
                        Width = 150,
                        Sortable = true
                    });
                    break;
                #endregion
                /*=========================End=========================*/
                /*=========================Nhóm RES=========================*/
                default:
                    break;
            }

        }
        /*
        * Create by: Pham Tuan Anh
        * 1 methods
        * create from date: 2009-01-18 14:50
        * */
        private void ReturnSOorPO(int iType)//0: SO, 1:PO
        {
            this.ListControl.Add("Người tạo", ControlType.NumberField, DataType.String, "txtCreateBy");
            this.ListControl.Add("Mã chứng từ", ControlType.TextField, DataType.String, "txtDocumentNo");
            this.ListControl.Add("Số tiền từ", ControlType.NumberField, DataType.String, "txtFromAmount");
            this.ListControl.Add("Đến", ControlType.NumberField, DataType.String, "txtToAmount");
            this.ListControl.Add("Ngày tạo từ", ControlType.DateField, DataType.String, "dtFromdate");
            this.ListControl.Add("Đến", ControlType.DateField, DataType.String, "dtTodate");
            ControlFinder IsType = new ControlFinder("", ControlType.HiddenField, DataType.String, "txtType");
            IsType.DefaultValue = iType.ToString();
            this.ListControl.Add(IsType);

            this.StoreName = "spFinderReturnPOReturnSOforInvoice";

            this.GridFinder = new GridFinder("Danh sách đơn hàng trả lại", true);

            this.GridFinder.Add("DOC_DOCUMENTID", "Document ID", 100, true, "DOC_DOCUMENTID", string.Empty, "DOC_DOCUMENTID", true);
            this.GridFinder.Add("Mã chứng từ", 100, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
            this.GridFinder.Add("Loại chứng từ", 200, true, "TYPE", string.Empty, "TYPE", true);
            this.GridFinder.Add("Ngày tạo", 200, true, "DOC_CREATEDATE", string.Empty, "DOC_CREATEDATE", true);
            this.GridFinder.Add("Đối tượng mua/bán", 200, true, "OBJ_NAME", string.Empty, "OBJ_NAME", true);
            this.GridFinder.Add("Tổng tiền", 100, true, "POD_TOTALAMOUNT", string.Empty, "POD_TOTALAMOUNT", true);
            this.GridFinder.Add("Kỳ tài chính", 100, true, "FICI_NAME", string.Empty, "FICI_NAME", true);
        }
        private void ProposePaymentCM(int iType)
        {
            //init control
            this.ListControl.Add("Mã nhân viên", ControlType.NumberField, DataType.Int, "txtCreateby", true);
            this.ListControl.Add("Số tiền từ", ControlType.NumberField, DataType.Float, "dtFromAmount");
            this.ListControl.Add("Đến", ControlType.NumberField, DataType.Float, "dtToAmount");
            this.ListControl.Add("Mã đề xuất", ControlType.TextField, DataType.Int, "txtDocumentNo");
            ControlFinder IsType = new ControlFinder("", ControlType.HiddenField, DataType.String, "txtType");
            IsType.DefaultValue = iType.ToString();
            this.ListControl.Add(IsType);

            //store DB
            this.StoreName = "spProposePaymentCM";
            //init Grid
            this.GridFinder = new GridFinder("Danh sách đề xuất thu/chi", true);

            this.GridFinder.Add("DOC_DOCUMENTID", "Mã hệ thống", 100, true, "DOC_DOCUMENTID", string.Empty, "DOC_DOCUMENTID", true);
            this.GridFinder.Add("Mã đề xuất", 200, true, "DOC_DOCUMENTNO", string.Empty, "DOC_DOCUMENTNO", true);
            this.GridFinder.Add("Số tiền đề xuất", 200, true, "PPAY_PURAMOUNT", string.Empty, "PPAY_PURAMOUNT");
            this.GridFinder.Add("Người lập đề xuất", 100, true, "DOC_CREATEBY", string.Empty, "DOC_CREATEBY");
            this.GridFinder.Add("Ngày tạo", 200, true, "DOC_CREATEDATE", string.Empty, "DOC_CREATEDATE");
            this.GridFinder.Add("Ngày duyệt", 200, true, "DOC_APPROVEDATE", string.Empty, "DOC_APPROVEDATE");
        }
        //end
    }
}
