///////////////////////////////////////////////////////////////////////////
// Description:vnyi.DLL.DataObject class for the 'DECLARATION'
// Generated by vnyi GenTool.
// Copyright (c) YI. All rights reserved.
///////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using vnyi.DataProvider;

namespace vnyi.Library.COMON.IV
{
    public class DECLARATIONDAO
    {
        #region generated code
        /// <summary>
        /// Insert declaration into DECLARATION / DECLARATIONtmp
        /// </summary>
        /// <param name="declaration"></param>
        /// <param name="isTmp"></param>
        /// <returns></returns>
        public static bool Insert(DECLARATION declaration, bool isTmp)
        {
            string procedure = isTmp ? "spDECLARATIONtmpInsert" : "spDECLARATIONInsert";
            int i = SqlHelper.ExecuteNonQuery(procedure,
                declaration.DEC_DOCUMENTID,
                declaration.CUR_AUTOID,
                declaration.CON_AUTOID,
                declaration.FICI_AUTOID,
                declaration.DOTY_AUTOID,
                declaration.PPT_AUTOID,
                declaration.SMT_AUTOID,
                declaration.OBJ_AUTOID,
                declaration.DEC_INVOICENO,
                declaration.DEC_INVOICEDATE,
                declaration.DEC_AMOUNT,
                declaration.DEC_BASEAMOUNT,
                declaration.DEC_REGISTEROFFICIAL,
                declaration.OBJ_HANDLE,
                declaration.DEC_IMPORTHARBOUR,
                declaration.DEC_EXPORTHARBOUR,
                declaration.DEC_ARRIVALDATE,
                declaration.DEC_BALANCE,
                declaration.DEC_BOARDCUSTOMS,
                declaration.DEC_BRANCHOFFICE,
                declaration.DEC_DELIVERYINVOICE,
                declaration.DEC_DELIVERYDATE,
                declaration.DEC_COMMUNNO,
                declaration.DEC_COMMUDATE,
                declaration.DEC_COMMUNCONTENT,
                declaration.DEC_ISUSE,
                declaration.PTE_AUTOID,
                declaration.PTE_DUEDATE,
                declaration.DEC_CURRENCYRATE);
            if (i > 0) return true; return false;
        }

        /// <summary>
        /// Update declaration from DECLARATION / DECLARATIONtmp
        /// </summary>
        /// <param name="declaration"></param>
        /// <param name="isTmp"></param>
        /// <returns></returns>
        public static bool Update(DECLARATION declaration, bool isTmp)
        {
            string procedure = isTmp ? "spDECLARATIONtmpUpdate" : "spDECLARATIONUpdate";
            int i = SqlHelper.ExecuteNonQuery(procedure,
                declaration.DEC_DOCUMENTID,
                declaration.CUR_AUTOID,
                declaration.CON_AUTOID,
                declaration.FICI_AUTOID,
                declaration.DOTY_AUTOID,
                declaration.PPT_AUTOID,
                declaration.SMT_AUTOID,
                declaration.OBJ_AUTOID,
                declaration.DEC_INVOICENO,
                declaration.DEC_INVOICEDATE,
                declaration.DEC_AMOUNT,
                declaration.DEC_BASEAMOUNT,
                declaration.DEC_REGISTEROFFICIAL,
                declaration.OBJ_HANDLE,
                declaration.DEC_IMPORTHARBOUR,
                declaration.DEC_EXPORTHARBOUR,
                declaration.DEC_ARRIVALDATE,
                declaration.DEC_BALANCE,
                declaration.DEC_BOARDCUSTOMS,
                declaration.DEC_BRANCHOFFICE,
                declaration.DEC_DELIVERYINVOICE,
                declaration.DEC_DELIVERYDATE,
                declaration.DEC_COMMUNNO,
                declaration.DEC_COMMUDATE,
                declaration.DEC_COMMUNCONTENT,
                declaration.DEC_ISUSE,
                declaration.PTE_AUTOID,
                declaration.PTE_DUEDATE,
                declaration.DEC_CURRENCYRATE);
            if (i > 0) return true; return false;
        }

        /// <summary>
        /// Delete data full for table DECLARATION
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="DEC_DOCUMENTID"> type of DEC_DOCUMENTID</param>
        public static bool Delete(Int64 DEC_DOCUMENTID)
        {
            int i = SqlHelper.ExecuteNonQuery("spDECLARATIONDelete", DEC_DOCUMENTID);
            if (i > 0) return true; return false;
        }

        /// <summary>
        /// Lay trong bang tam hoac bang chinh
        /// </summary>
        /// <param name="DEC_DOCUMENTID"></param>
        /// <param name="isTmp"></param>
        /// <returns></returns>
        public static DECLARATION SelectByID(Int64 DEC_DOCUMENTID, bool isTmp)
        {
            string _strProc = "";
            if (isTmp)
                _strProc = "spDECLARATIONtempGetByID";
            else
                _strProc = "spDECLARATIONGetByID";
            DataSet ds = new DataSet();
            DECLARATION result = new DECLARATION();
            SqlHelper.ExecuteDataset(ds, _strProc, DEC_DOCUMENTID);
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                    result = new DECLARATION(ds.Tables[0].Rows[0]);
            ds.Dispose();
            return result;
        }

        /// <summary>
        /// Get all DECLARATION and Paging 
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="page"> type of int is current page that want view </param>
        /// <param name="rowNum"> type of int is number rows in one page that want select  </param>
        /// <param name="total"> type of int is param output value. return is Total row that select</param>
        public static List<DECLARATION> GetAllPaging(int page, int rowNum, out int total)
        {
            total = 0;
            SqlParameter Page = new SqlParameter("@Page", page);
            SqlParameter RowNum = new SqlParameter("@RowNum", rowNum);
            SqlParameter Total = new SqlParameter("@Total", total) { Direction = ParameterDirection.Output };
            DataSet ds = new DataSet();
            List<DECLARATION> result = new List<DECLARATION>();
            SqlHelper.ExecuteDataset(ds,CommandType.StoredProcedure, "spDECLARATIONSelectAllPaging", Page, RowNum, Total);
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                    foreach (DataRow dr in ds.Tables[0].Rows)
                        result.Add(new DECLARATION(dr));
            total = int.Parse(Total.Value.ToString());
            ds.Dispose();
            return result;
        }

        /// <summary>
        /// GetAll data for table DECLARATION
        /// Return Object is List<DECLARATION> obj
        /// </summary>
        public static List<DECLARATION> GetAllDECLARATION()
        {
            DataSet ds = new DataSet();
            List<DECLARATION> result = new List<DECLARATION>();
            SqlHelper.ExecuteDataset(ds, "spDECLARATIONSelectAll");
            if (ds.Tables.Count > 0)
                if (ds.Tables[0].Rows.Count > 0)
                    foreach (DataRow dr in ds.Tables[0].Rows)
                        result.Add(new DECLARATION(dr));
            ds.Dispose();
            return result;
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="docNo"></param>
       /// <param name="dec"></param>
       /// <param name="invoiceDate"></param>
       /// <param name="invoiceNo"></param>
       /// <param name="objID"></param>
       /// <param name="isuse"></param>
       /// <param name="type"></param>
       /// <returns></returns>
        public static DataTable SearchForFinder(string docNo,string dec,DateTime invoiceDate,string invoiceNo,int objID,bool isuse,short type)
        {
            DataSet ds = new DataSet();

             invoiceDate = invoiceDate == DateTime.MinValue ? SqlDateTime.MinValue.Value : invoiceDate;
            SqlHelper.ExecuteDataset(ds, "spDeclarationSearch", docNo, dec, invoiceDate, invoiceNo,  objID, isuse, type);
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        return ds.Tables[0];
            return null;
        }
        #endregion

        #region extended code
        /// <summary>
        /// Author       : lamnq
        /// Created date : 9:01 AM 6/19/2009
        /// Purpose      : Commit all declaration information from temp table into main table.
        /// </summary>
        public static Int64 CommitData(long ? DEC_DOCUMENTID, int ? CURRENTUSERID)
        {
            object result = SqlHelper.ExecuteScalar("spDECLARATIONCommitTmp", DEC_DOCUMENTID, CURRENTUSERID);
            return Convert.ToInt64(result);
        }

        /// <summary>
        /// Author       : lamnq
        /// Created date : 4:19 PM 6/19/2009
        /// Purpose      : copy all required data from main tables to temp tables to initialize for updating.
        /// IMPORTANT    : return value is DOC_DOCUMENTID of DOCUMENTtmp table.
        /// </summary>
        public static Int64 PrepareTmpData(long DOCUMENTID, int CURRENTUSERID)
        {
            object result = SqlHelper.ExecuteScalar("spDECLARATIONPrepareTmpData", DOCUMENTID, CURRENTUSERID);
            return Convert.ToInt64(result);
        }
        public static DataSet GetByDocument(long DEC_DOCUMENTID, bool update)
        {
            DataSet ds = new DataSet();
            string procedure = update ? "spDECLARATIONPrepareTmpData" : "spDECLARATIONGetByDocument";
            SqlHelper.ExecuteDataset(ds, procedure, DEC_DOCUMENTID);
            return ds;
        }
        public static DataSet GetNavigator(long DEC_DOCUMENTID, int FICI_AUTOID, string DIRECTION)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "spDECLARATIONGetNavigator", DEC_DOCUMENTID, FICI_AUTOID, DIRECTION);
            return ds;
        }
        /// <summary>
        /// Nguyen Nin
        /// Search Delaration IMPORT
        /// </summary>
        /// <param name="storName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet SearchDelarationI(string storName, params object[] paras)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds,storName,paras);
            return ds;
        }
        /// <summary>
        /// Nguyen Nin
        /// Search Delaration EXPORT
        /// </summary>
        /// <param name="storName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet SearchDelarationE(string storName, params object[] paras)
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds,storName,paras);
            return ds;
        }
        #endregion
    }
}
