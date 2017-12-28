///////////////////////////////////////////////////////////////////////////
// Description: DataObject class for the 'PUBPLAN'
// Generated by vnyi GenTool.
// Copyright (c) YI. All rights reserved.
///////////////////////////////////////////////////////////////////////////


using System;
using System.Data;
using System.Collections;
using vnyi.DataProvider;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace vnyi.Library.PLA
{
    public class PUBPLANDAO
    {
        /// <summary>
        /// Insert data full for table PUBPLAN
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of PUBPLAN</param>
        public static bool Insert(PUBPLAN obj)
        {
            int i = SqlHelper.ExecuteNonQuery("spPUBPLANInsert"
                , obj.PLA_DOCUMENTID
                , obj.DOTY_AUTOID
                , obj.ST_AUTOID
                , obj.PLA_AMOUNTREAL 
                , obj.PLA_BEGINDATE
                , obj.PLA_ENDDATE
                , obj.PLA_AMOUNT
                , obj.OBJ_AUTOID
                , obj.PLA_RESION
                , obj.PLA_BASEAMOUNT
                , obj.CUR_AUTOID
                , obj.PLA_EXCHANGERATE
                );
            if (i > 0) return true; else return false;
        }
        /// <summary>
        /// Update data full for table PUBPLAN
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of PUBPLAN</param>
        public static bool Update(PUBPLAN Obj)
        {
            int i = SqlHelper.ExecuteNonQuery("spPUBPLANUpdate"
                , Obj.PLA_DOCUMENTID
                , Obj.DOTY_AUTOID
                , Obj.ST_AUTOID
                , Obj.PLA_AMOUNTREAL  
                , Obj.PLA_BEGINDATE
                , Obj.PLA_ENDDATE
                , Obj.PLA_AMOUNT
                , Obj.OBJ_AUTOID
                , Obj.PLA_RESION
                , Obj.PLA_BASEAMOUNT
                , Obj.CUR_AUTOID
                , Obj.PLA_EXCHANGERATE
                );
            if (i > 0) return true; return false;
        }


        /// <summary>
        /// Delete data full for table PUBPLAN
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="PLA_DOCUMENTID"> type of PLA_DOCUMENTID</param>

        public static bool Delete(Int64 PLA_DOCUMENTID)
        {
            int i = SqlHelper.ExecuteNonQuery("spPUBPLANDelete", PLA_DOCUMENTID);
            if (i > 0) return true; return false;
        }
        /// <summary>
        ///Select data full for table PUBPLAN
        /// return onePUBPLAN
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="PLA_DOCUMENTID"> type of PLA_DOCUMENTID</param>
        public static PUBPLAN SelectByID(Int64 PLA_DOCUMENTID)
        {
            DataSet ds = new DataSet();
            PUBPLAN result = new PUBPLAN();
            SqlHelper.ExecuteDataset(ds, "spPUBPLANGetByID", PLA_DOCUMENTID);
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        result = new PUBPLAN(ds.Tables[0].Rows[0]);
            return result;
        }
        /// <summary>
        /// Get all PUBPLAN and Paging 
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="page"> type of int is current page that want view </param>
        /// <param name="rowNum"> type of int is number rows in one page that want select  </param>
        /// <param name="total"> type of int is param output value. return is Total row that select</param>
        public static List<PUBPLAN> GetAllPaging(int page, int rowNum, out int total)
        {
            total = 0;
            SqlParameter Page = new SqlParameter("@Page", page); 
            SqlParameter RowNum = new SqlParameter("@RowNum", rowNum);
            SqlParameter Total = new SqlParameter("@Total", total);
            Total.Direction = ParameterDirection.Output;
            DataSet ds = new DataSet();
            List<PUBPLAN> result = new List<PUBPLAN>();
            SqlHelper.ExecuteDataset(ds,CommandType.StoredProcedure, "spPUBPLANSelectAllPaging", Page, RowNum, Total);
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        foreach (DataRow dr in ds.Tables[0].Rows)
                            result.Add(new PUBPLAN(dr));
            total = int.Parse(Total.Value.ToString());
            return result;
        }
        /// <summary>
        /// GetAll data for table PUBPLAN
        /// Return Object is List<PUBPLAN> obj
        /// </summary>
        public static List<PUBPLAN> GetAllPUBPLAN()
        {
            DataSet ds = new DataSet();
            List<PUBPLAN> result = new List<PUBPLAN>();
            SqlHelper.ExecuteDataset(ds, "spPUBPLANSelectAll");
            if (ds != null)
                if (ds.Tables.Count > 0)
                    if (ds.Tables[0].Rows.Count > 0)
                        foreach (DataRow dr in ds.Tables[0].Rows)
                            result.Add(new PUBPLAN(dr));
            return result;
        }

        /// <summary>
        /// Create by: Pham Tuan Anh
        /// Gets all PUBPLA nby status.
        /// </summary>
        /// <param name="status">The status.</param>
        /// <returns></returns>
        public static DataTable GetAllPUBPLANbyStatus(Int16 status, string DocumentNo, DateTime GreateFromdate, DateTime GreateTodate)
        {
            DataSet ds = new DataSet();
            List<PUBPLAN> result = new List<PUBPLAN>();
            SqlHelper.ExecuteDataset(ds, "spGetAllPUBPLANbyStatus", status, DocumentNo, GreateFromdate, GreateTodate);            
            return ds.Tables[0];
        }
        public static string MakeReceicePayment(long ProposeID,string des,short module,int objid,DateTime begindate, DateTime enddate,short status)
        {
           
            object objResult =SqlHelper.ExecuteScalar("spPUBPLANMakeReceicePayment", ProposeID, des, module,objid, begindate, enddate, status);
            if (objResult == null)
                return "";
            return objResult.ToString();
        }
        public static DataSet getAllInvoiPSO() 
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "getIDInvoicePSO");
            return ds;
        }
        public static DataSet getIDPOSO() 
        {
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, "getIDPOSO");
            return ds;
         }
    }
}