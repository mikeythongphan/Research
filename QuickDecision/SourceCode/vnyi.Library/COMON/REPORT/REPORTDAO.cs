using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using vnyi.DataProvider;

namespace vnyi.Library.COMON.REPORT
{
    public class REPORTDAO
    {
        /// <summary>
        /// Lấy danh sách thanh toán và hóa đơn cho chứng từ công nợ
        /// </summary>
        /// <param name="iDOCUMENTID">Int64</param>
        /// <param name="strTYPE">string:AP-AR</param>
        /// <returns>DataSet</returns>
        public static DataSet getDataPaymentDetailDebt_AP(Int64 iDOCUMENTID, string strTYPE)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_CM_GetDataPaymentDetail_CMPAYMENT", iDOCUMENTID, strTYPE);
            return ds;
        }
        /// <summary>
        /// Lấy thông số lên form barcode
        /// </summary>
        /// <param name="Org"></param>
        /// <param name="ObjectID"></param>
        /// <returns></returns>
        public static IDataReader GetDataForBarcode(int? Org, int? ObjectID)
        {
            IDataReader iReader = SqlHelper.ExecuteReader("sp_Meta_GetDataForBarcode", Org, ObjectID);
            return iReader;
        }
        /// <summary>
        /// Cập nhật số lượng cho ChoicePriceDetail
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        public static bool UpdateChoicePriceDetail(Int64 ID, decimal Quantity)
        {
            int iReader = SqlHelper.ExecuteNonQuery("sp_Meta_Update_ChoicePriceDetail", ID, Quantity);
            if (iReader > 0)
                return true;
            else return false;
        }
        /// <summary>
        /// báo cáo thẻ kho
        /// </summary>
        /// <param name="ORG_AUTOID">chi nhành </param>
        /// <param name="FICI_AUTOID">kỳ tài chính</param>
        /// <param name="lstItemID">danh sách mặt hàng</param>
        /// <param name="WH_AUTOID">tại kho</param>
        /// <returns></returns>
        public static DataSet StoreBook(params object[] paras)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_StoreBook_Stock", paras);
            return ds;

        }
        /// <summary>
        /// Bảng cân đối kế toán
        /// </summary>
        /// <param name="Org">Chi nhánh </param>
        /// <param name="Fici">kỳ tài chính</param>
        /// <returns></returns>
        public static DataSet GetReport_GLBalance(int? OrgID, Int16? Fici)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_GetReport_GLBALANCE", OrgID, Fici);
            return ds;
        }
        /// <summary>
        /// test
        /// </summary>
        /// <param name="Org">Chi nhánh </param>
        /// <param name="Fici">kỳ tài chính</param>
        /// <returns></returns>
        public static DataSet test()
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "SP_REPORT_TEST");
            return ds;
        }

        /// <summary>
        /// In ra report của PO
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet PO_PrintReport(params object[] paras)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_PO_PrintReport_PURORDER", paras);
            return ds;
        }
        /// <summary>
        /// In ra report của SO
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet SO_PrintReport(params object[] paras)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_SO_PrintReport_SalOrder", paras);
            return ds;
        }
        /// <summary>
        /// Lấy thông tin để in phiếu chi
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet CmReceipt_PrintReport(params object[] paras)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_ReportPrint_Cmreciept", paras);
            return ds;
        }
        /// <summary>
        /// Lấy thông tin cho in phiếu chi
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet CmPayment_PrintReport(params object[] paras)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_ReportPrint_CmPayment", paras);
            return ds;
        }

        /// <summary>
        /// Lấy thông tin cho in Hóa đơn
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet IV_PrintReport(params object[] paras)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_IV_PrintReport_Invoice", paras);
            return ds;
        }
        /// <summary>
        /// In phiếu nhập xuất kho
        /// </summary>
        /// <param name="paras"></param>
        /// <returns>Dataset 2 table</returns>
        public static DataSet IC_PrintReport(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_ReportPrint_ICStock";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }
        /// <summary>
        /// Lấy danh sách để in 
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet IC_PrintListReport(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_getDataForPrintListIC";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }

        /// <summary>
        /// In phiếu chuyển kho
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet ICMove_PrintReport(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_ReportPrint_ICMoveStock";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }
        /// <summary>
        /// Báo cáo chi tiết tồn kho
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet ICStockJoin_PrintReport(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_ReportPrint_ICStockJoin";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }
        /// <summary>
        /// Description: Báo cáo tổng hợp mua hàng theo nhà cung cấp
        /// Description: Báo cáo tổng hợp mua hàng theo nhà mặt hàng 
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>

        public static DataSet GeneralInWardStockBySupply(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_Report_GeneralInWardStockBySupply";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }

        /// <summary>
        /// Báo cáo tổng hợp tồn trên một kho
        /// 
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet GenaralICStockJoin_PrintReport(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_ReportPrint_GenaralICStockJoin";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }
        /// <summary>
        /// Báo cáo tổng hợp tồn trên nhiều kho
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet GeneralItemsInStocks(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_Report_GeneralItemsInStocks";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }
        /// <summary>
        /// Description: Báo cáo chi tiết nhập kho
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet ReportInWardStockDetail(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_Report_InWardStockDetail";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }

        /// <summary>
        /// Description: Báo cáo tổng hợp kho
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet GeneralInStocks_Report(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_ReportPrint_GeneralStocksPrint";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }
        public static DataSet ReportCostPriceOutStock(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_ReportCostPriceOutStock";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }
        public static DataSet GeneralInStockByPlot_Report(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_Report_GeneralStocksByPLOT";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }
        /// <summary>
        /// Báo cáo số lượng nhập xuất
        /// </summary>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet QuantityStocksPrint_PrintReport(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_ReportPrint_QuantityStocksPrint";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }
        public static DataSet Adjustment_PrintReport(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_ReportPrint_Adjustment";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }

        public static DataSet ICStockJoin_ValuePrintReport(params object[] paras)
        {
            string strStoreName = "";
            DataSet ds = new DataSet();
            strStoreName = "sp_ReportPrint_ValueICStockJoin";
            SqlHelper.ExecuteDataset(ds, strStoreName, paras);

            return ds;
        }

        /// <summary>
        /// LẤY THÔNG TIN IN REPORT
        /// </summary>
        /// <param name="BusinessID"></param>
        /// <returns></returns>
        public static DataSet GenBarcode_ForSerialNO(Int64 BusinessID, Boolean Mode)
        {
            DataSet resul = new DataSet();
            SqlHelper.ExecuteDataset( resul, "sp_GenbarcodeSerial_Print", BusinessID, Mode);
            return resul;

        }
        /// <summary>
        /// LẤY THÔNG TIN IN REPORT CHO SERIALNO
        /// </summary>
        /// <param name="BusinessID"></param>
        /// <returns></returns>
        public static DataSet GenBarcode_ForInstock(Int64 DetailID)
        {
            DataSet resul = new DataSet();
            SqlHelper.ExecuteDataset( resul, "sp_Genbarcode_Print", DetailID);
            return resul;

        }
        /// <summary>
        /// Gen barcode với một số chuẩn quy định
        /// </summary>
        /// <param name="OrgID"></param>
        /// <param name="ObjID"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static DataSet GenBarcodeForItem(int? OrgID, int? ObjID, int Type, string sym)
        {
            DataSet resul = new DataSet();
            SqlHelper.ExecuteDataset( resul, "sp_Genbarcode_PrintOther", OrgID, ObjID, Type, sym);
            return resul;

        }
        /// <summary>
        /// Data cho báo cáo sổ chi tiết ngân hàng
        /// </summary>
        /// <param name="ACC_CODE"></param>
        /// <param name="FICI_AUTOID"></param>
        /// <param name="ORG_AUTOID"></param>
        /// <param name="status"></param>
        /// <param name="LoginObjectID"></param>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public static DataSet BookBankDetal(params object[] param)
        {

            DataSet dsResult = new DataSet();
            SqlHelper.ExecuteDataset( dsResult, "sp_Account_Report_BankDetail", param);
            return dsResult;
        }
        /// <summary>
        /// Thống tin cho Báo cáo chi tiết tài khoản
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataSet AccountDetail(params object[] param)
        {

            DataSet dsResult = new DataSet();
            SqlHelper.ExecuteDataset( dsResult, "sp_Account_Report_AccountDetail", param);
            return dsResult;
        }
        /// <summary>
        /// Lấy thông tin cho sổ quỹ tiền mặt
        /// </summary>
        /// <param name="ACC_CODE"></param>
        /// <param name="FICI_AUTOID"></param>
        /// <param name="ORG_AUTOID"></param>
        /// <param name="status"></param>
        /// <param name="LoginObjectID"></param>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public static DataSet CashBudget(params object[] param)
        {

            DataSet dsResult = new DataSet();
            SqlHelper.ExecuteDataset( dsResult, "sp_Account_Report_CashBudget", param);
            return dsResult;
        }
        /// <summary>
        /// Danh cho báo cáo SỔ CHI TIẾT QUỸ TIỀN MẶT
        /// </summary>
        /// <param name="ACC_CODE"></param>
        /// <param name="FICI_AUTOID"></param>
        /// <param name="ORG_AUTOID"></param>
        /// <param name="status"></param>
        /// <param name="LoginObjectID"></param>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public static DataSet CashBudgetDetail(params object[] param)
        {

            DataSet dsResult = new DataSet();
            SqlHelper.ExecuteDataset( dsResult, "sp_Account_Report_CashBudgetDetal", param);
            return dsResult;
        }
        /// <summary>
        /// Báo cáo sổ quỹ
        /// </summary>
        /// <param name="ACC_CODE">Mã tài khoản</param>
        /// <param name="FICI_AUTOID">Kỳ tài chính</param>
        /// <param name="ORG_AUTOID">Thuộc chi nhánh nào</param>
        /// <param name="ST_AUTOID">Trạng thái</param>
        /// <returns>
        /// Trả về DataSet cho report
        /// </returns>       
        public static DataSet ReportAccount(params object[] param)
        {

            DataSet dsResult = new DataSet();
            SqlHelper.ExecuteDataset( dsResult, "sp_Account_Report_GLENTRY", param);
            return dsResult;
        }

        /// <summary>
        /// Bao cao cong no phai tra
        /// </summary>
        /// <param name="ACC_CODE">Mã tài khoản</param>
        /// <param name="FICI_AUTOID">Kỳ tài chính</param>
        /// <param name="ORG_AUTOID">Thuộc chi nhánh nào</param>
        /// <param name="ST_AUTOID">Trạng thái</param>
        /// <returns>
        /// Trả về DataSet cho report
        /// </returns>
        public static DataSet APGeneral(params object[] param)
        {
            DataSet dsResult = new DataSet();
            SqlHelper.ExecuteDataset( dsResult, "SP_REPORT_APGENERAL_AP", param);
            return dsResult;
        }

        /// <summary>
        /// Báo cáo bảng kê báng hàng
        /// </summary>
        /// <param name="param">OBJ</param>
        /// <returns></returns>
        public static DataSet SaleList(params object[] param)
        {
            DataSet dsResult = new DataSet();
            SqlHelper.ExecuteDataset( dsResult, "SP_REPORT_SALELIST_SALDETAIL", param);
            return dsResult;
        }
        /// <summary>
        /// Lấy báo cáo chi tiết công nợ phải trả-Công nợ phải thu.
        /// Note:Có(-)Nợ
        /// </summary>
        /// <param name="param">object[]</param>
        /// <returns>Data</returns>
        public static DataSet AP_GeneralDetail(params  object[] param)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "SP_REPORT_APGENERALDETAIL_AP", param);
            return ds;
        }
        /// <summary>
        /// Bao cao tổng hợp công nợ phải thu
        /// </summary>
        /// <param name="ACC_CODE">string</param>
        /// <param name="FICI_AUTOID">Int</param>
        /// <param name="ORG_AUTOID">Int</param>
        /// <param name="ST_AUTOID">Trạng thái</param>
        /// <returns>DataSet</returns>
        public static DataSet ARGeneral(params object[] param)
        {
            DataSet dsResult = new DataSet();
            SqlHelper.ExecuteDataset( dsResult, "SP_REPORT_APGENERAL_AR", param);
            return dsResult;
        }
        /// <summary>
        /// Lấy báo cáo chi tiết công nợ phải thu.
        /// Note:Nơ(-)Có
        /// </summary>
        /// <param name="param">object[]</param>
        /// <returns>Data</returns>
        public static DataSet AR_GeneralDetail(params  object[] param)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "SP_REPORT_ARGENERALDETAIL_AR", param);
            return ds;
        }
        /// <summary>
        /// Báo cáo theo dõi thanh toán bằng ngoại tệ
        /// </summary>
        /// <param name="param">object[]</param>
        /// <returns>Data</returns>
        public static DataSet GL_BookPayForgeignCur(params  object[] param)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "SP_REPORT_BookPayForeignCur_GL", param);
            return ds;
        }
        /// <summary>
        /// Báo cáo theo dõi thanh toán bằng ngoại tệ
        /// </summary>
        /// <param name="param">object[]</param>
        /// <returns>Data</returns>
        public static DataSet TAX_ItemSellList(params  object[] param)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_REPORT_SellItemList_TAX", param);
            return ds;
        }

        /// <summary>
        /// Báo cáo theo dõi thanh toán bằng ngoại tệ
        /// </summary>
        /// @APAR VARCHAR(2) --'AP' HOAC 'AR'
        ///,@DATE DATE -- Ngay phan tich
        ///,@OBJG INT -- Nhom doi tuong
        ///,@OBJID INT = NULL -- Ma doi tuong
        ///,@DEBT SMALLINT -- Loai no
        ///,@DEBTDETAIL SMALLINT -- Chi tiet no (gioi han ngay)
        ///,@FICI SMALLINT -- Ki tai chinh
        ///,@ORG INT -- Chi nhanh
        ///,@PROCESSBY SMALLINT -- Phan tich "theo ngay dao han" (1) hoac "dieu khoan thanh toan" (2)
        public static DataSet analyzeDept(params  object[] param)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "SP_COMMON_DEBTANALYSIS_COMMON", param);
            return ds;
        }
        #region Báo cáo sổ cái
        /// <summary>
        /// Một số báo cáo tài chính dùng mask
        /// </summary>
        /// <param name="param">object[]</param>
        /// <returns>Data</returns>
        public static DataSet GL_financial_reports(params  object[] param)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_Common_financial_reports", param);
            return ds;
        }
        /// <summary>
        /// Lấy số liệu cho : BẢNG CÂN ĐỐI PHÁT SINH
        /// </summary>
        /// <param name="param">
        /// param : Gồm 
        /// </param>
        /// <returns>DataSet gồm :</returns>
        public static DataSet BalanceArising(params  object[] param)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_Common_BalanceArising", param);
            return ds;
        }
        /// <summary>
        /// Lấy số liệu cho : SỔ NHẬT KÝ CHUNG
        /// </summary>
        /// <param name="param">param: Gồm 
        /// 1 :chi nhánh
        /// 2: Kỳ 
        /// 3 : trạng thái Sồ chính(12), sổ tmp(12;13)
        /// 3 : Người Login         
        /// </param>
        /// <returns>DataSet</returns>
        public static DataSet GeneralJournal(params  object[] param)
        {

            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_Common_GeneralJournal", param);
            return ds;
        }

        #endregion
        /// <summary>
        /// Số liệu cho tờ khai thuế giá trị gia tăng theo mẫu 01-Tondb
        /// </summary>
        /// <param name="param"><para/></param>
        /// <returns></returns>
        public static DataSet TAX_GetDataDeclarationVAT(params object[] param)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "sp_REPORT_DECLARATIONVATTAX_REPORTTAXMARK", param);
            return ds;
        }
    }
}
