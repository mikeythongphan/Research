using System;
using System.Data;
using System.Collections;
using vnyi.DataProvider;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace vnyi.Library.COMON.IV
{
    public class PUBENTRYTYPEDAO
    {
        public static List<PUBENTRYTYPE> getAll()
        {
            DataSet ds = new DataSet();
            List<PUBENTRYTYPE> result = new List<PUBENTRYTYPE>();
            IDataReader IReader = SqlHelper.ExecuteReader("SP_META_GETALLPUBENTRYTYPE_PUBENTRYTYPE");
            while (IReader.Read())
                result.Add(new PUBENTRYTYPE(IReader));
            return result;
        }

        public static List<PUBENTRYTYPE> getAllActive()
        {
            DataSet ds = new DataSet();
            List<PUBENTRYTYPE> result = new List<PUBENTRYTYPE>();
            IDataReader IReader = SqlHelper.ExecuteReader("SP_META_GETALLACTIVEPUBENTRYTYPE_PUBENTRYTYPE");
            while (IReader.Read())
                result.Add(new PUBENTRYTYPE(IReader));
            return result;
        }
        /// <summary>
        /// Lấy danh sách loại định khoản-Tondb
        /// </summary>
        /// <param name="iORG_AUTOID">int?</param>
        /// <param name="iLANG_AUTOID">int?</param>
        /// <returns>DataSet</returns>
        public static DataSet getDataEntryType(int? iORG_AUTOID, int? iLANG_AUTOID) {
            DataSet ds = new DataSet(); 
            SqlHelper.ExecuteDataset(ds, "sp_GL_GetDataEntryType_PUBENTRYTYPE", iORG_AUTOID, iLANG_AUTOID);
            return ds;
        }
    }
}