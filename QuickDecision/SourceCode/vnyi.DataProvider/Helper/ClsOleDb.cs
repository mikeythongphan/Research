/*	File			:	OLE.cs
 *	Creator			:	sinhhn
 *	Creation date	:	25/11/2004
 *	Description		:	OLE DB Utilities
 *	History			:
 */

using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace vnyi.DataProvider
{
    public class ClsOleDb
	{
		private static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath+ @"\Configs\vnyi.mdb;Jet OLEDB:Database Password= qlnhmdb";
		
		/// <summary>
		/// Query the database , return a dataset
		/// </summary>
		/// <param name="cmdText">Query command</param>
		public static DataSet executeDataSet(string cmdText)
		{
			DataSet ds = new DataSet();
			OleDbDataAdapter da = new OleDbDataAdapter(cmdText,connString);
			da.Fill(ds);
			return ds;
		}

		/// <summary>
		/// Query the database , return a datatable
		/// </summary>
		/// <param name="cmdText">Query command</param>
		public static DataTable executeTable(string cmdText)
		{
			DataSet ds = new DataSet();
			OleDbDataAdapter da = new OleDbDataAdapter(cmdText,connString);
			da.Fill(ds);
			return ds.Tables[0];
		}

		/// <summary>
		/// Run a command
		/// </summary>
		/// <param name="cmdText">Command text</param>
		public static void executeNonQuery(string cmdText)
		{
			OleDbConnection conn = new OleDbConnection(connString);
			conn.Open();
			OleDbCommand cmd = new OleDbCommand(cmdText,conn);
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		/// <summary>
		/// Query the database , return the first record
		/// </summary>
		/// <param name="cmdText">Command text</param>
		public static object executeScalar(string cmdText)
		{
			OleDbConnection conn = new OleDbConnection(connString);
			conn.Open();
			OleDbCommand cmd = new OleDbCommand(cmdText,conn);
			object res = cmd.ExecuteScalar();
			conn.Close();
			return res;
		}
	}
}
