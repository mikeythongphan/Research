using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using vnyi.DataProvider;
using System.Data.SqlClient;


namespace vnyi.DLL
{
    public  partial class DataObject
    {

        protected DataRow _dataRow;
        public DataObject() { }
        public DataObject(string tablename, params object[] tableColum)
        {
            if (tableColum.Length > 0)
            {
                DataTable table = new DataTable(tablename);
                foreach (object strCollum in tableColum)
                {
                    if (strCollum is object[])
                    {
                        object[] tableColum1 = (object[])strCollum; 
                        foreach (object StrCll in tableColum1)
                            table.Columns.Add(new DataColumn(StrCll.ToString()));
                    }
                    else
                        table.Columns.Add(new DataColumn(strCollum.ToString()));
                }
                _dataRow = table.NewRow();
            }
            else
            {
                SetSchema(tablename);
            }

        }     
        public DataObject(IDataReader RederObject, string tablename)
        {
            if (RederObject != null)
            {
                DataTable dataTable = new DataTable();               
                foreach (DataRow Row in RederObject.GetSchemaTable().Rows)
                {                
                    DataColumn column = new DataColumn(Row["ColumnName"].ToString(), (Type)Row["DataType"]);
                    dataTable.Columns.Add(column);
                }
                _dataRow = dataTable.NewRow();
                foreach (DataColumn collum in dataTable.Columns)
                    _dataRow[collum.ColumnName] = RederObject[collum.ColumnName];
                dataTable.Dispose();
            }


        }
        public DataObject(IDataReader RederObject)
        {
            if (RederObject != null)
            {
                DataTable dataTable = new DataTable();
                foreach (DataRow Row in RederObject.GetSchemaTable().Rows)
                {
                    DataColumn column = new DataColumn(Row["ColumnName"].ToString(), (Type)Row["DataType"]);
                    dataTable.Columns.Add(column);
                }
                _dataRow = dataTable.NewRow();
                foreach (DataColumn collum in dataTable.Columns)
                    _dataRow[collum.ColumnName] = RederObject[collum.ColumnName];
                dataTable.Dispose();
            }


        }
        public DataObject(string tablename)
        {
            SetSchema(tablename);
        }
        public DataObject(string sqlString, bool isSql)
        {
            if (isSql)
            {
                SetSchemaBySql(sqlString);
            }
            else
            {
                SetSchema(sqlString);
            }
        }
        private bool SetSchemaBySql(string sqlString)
        {
            if (sqlString.IndexOf("WHERE", 0, StringComparison.OrdinalIgnoreCase) == -1)
                sqlString += " WHERE 1=0";
            else
                sqlString += " AND 1=0";

            DataTable table = new DataTable();
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, CommandType.Text, sqlString);
            if (ds.Tables.Count == 0) return false;

            _dataRow = ds.Tables[0].NewRow();
            return true;
        }
        public DataObject(DataTable table)
        {
            _dataRow = table.NewRow();
        }
        public DataObject(DataRow row)
        {
            _dataRow = row;
        }
        public DataObject(DataRow row, string tablename)
        {
            _dataRow = row;
        }
        public DataObject(DataRow row, string tablename, bool isSql)
        {
            if (isSql)
            {
                SetSchemaBySql(tablename);
            }
            else
            {
                SetSchema(tablename);
            }
            _dataRow = row;
        }
        protected bool SetSchema(string tableName) 
  
        {
            bool flat = false;
            if (_dataRow == null)
            {

                DataTable table = new DataTable();
                DataSet ds = new DataSet(tableName);
                SqlHelper.ExecuteDataset(ds, CommandType.Text, String.Format("SELECT * FROM [{0}] WHERE 1=0", tableName));
                if (ds.Tables.Count == 0) return false;
                _dataRow = ds.Tables[0].NewRow();
                flat = true;
            }
            return flat;
        }
        /// <summary>
        /// Lấy DataRow của đối tượng
        /// </summary>
        /// <returns></returns>
        public DataRow GetDataRow()
        {
            return _dataRow;
        }
        /// <summary>
        /// Lấy Data trên một thuộc tính ngoài đối tượng ra
        /// </summary>
        /// <param name="ColumName"></param>
        /// <returns></returns>
        public String GetDataByCollumName(string ColumName)
        {
            if (!_dataRow.Table.Columns.Contains(ColumName))
                return string.Empty;                  
            String objResul = null;
            if (_dataRow != null)
                if (_dataRow[ColumName] != null)
                    objResul = _dataRow[ColumName].ToString();
            return objResul;
        }
        public bool CheckAttributeContent(string Attribute)
        {
            return _dataRow.Table.Columns.Contains(Attribute);
        }
        public object getEntityValue(string ColumName)
        {
            try
            {
                return _dataRow[ColumName];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Gán Data cho một thuộc tính bất kỳ
        /// </summary>
        /// <param name="PropertiesName">Tên thuộc tính muốn setValue</param>
        /// <param name="Value">giá trị muốn set vào thuộc tính</param>
        public void SetDataForEntity(string PropertiesName, object Value)
        {
            if (_dataRow != null)
                if (_dataRow[PropertiesName] != null)
                    _dataRow[PropertiesName] = Value;            
        }
        
        /// <summary>
        /// thêm một column vào Object
        /// </summary>
        /// <param name="EntityName">Tên của Entity</param>
        public void AddEntity(string EntityName)
        {
            _dataRow.Table.Columns.Add(EntityName);
        }
        /// <summary>
        ///  thêm một column vào Object
        /// </summary>
        /// <param name="EntityName">Tên của Entity</param>
        /// <param name="DataType">exam: System.Type.GetType("System.Decimal");</param>
        public void AddEntity(string EntityName,Type DataType)
        {
            DataColumn column = new DataColumn();
            column.DataType = DataType;
            column.AllowDBNull = true;
            column.Caption = EntityName;
            column.ColumnName = EntityName;
            _dataRow.Table.Columns.Add(column);
          
        }
        /// <summary>
        /// Chuyển đổi từ danh sách đối tượng qua Đối tượng chuẩn
        /// </summary>
        /// <param name="lstObject">Danh sách các đối tượng kế thùa từ DataObject</param>
        /// <returns>List<DataObject></returns>
        public static List<DataObject> GetList(List<object> lstObject)
        {
            List<DataObject> Resul = new List<DataObject>();
            foreach (var item in lstObject)
            {
                Resul.Add((DataObject)item);
            }
            return Resul;
        }
        /// <summary>
        /// Chuyển đổi từ danh sách đối tượng qua Đối tượng chuẩn
        /// </summary>
        /// <param name="dataset">DataSet chuyền vào</param>
        /// <param name="TableIndex">vị trí bảng trong dataset muốn chuyển</param>
        /// <returns>List<DataObject></returns>
        public static List<DataObject> GetList(DataSet dataset, int TableIndex)
        {

            List<DataObject> Resul = new List<DataObject>();
            if (dataset != null)
                if (dataset.Tables.Count > TableIndex)
                    foreach (DataRow item in dataset.Tables[TableIndex].Rows)
                    {
                        Resul.Add(new DataObject(item));
                    }
            return Resul;
        }
        /// <summary>
        /// Chuyển đổi từ danh sách đối tượng qua Đối tượng chuẩn
        /// </summary>
        /// <param name="table">DataTable chuyền vào</param>        
        /// <returns>List<DataObject></returns>
        public static List<DataObject> GetList(DataTable table)
        {
            List<DataObject> Resul = new List<DataObject>();
            if (table != null)
                foreach (DataRow item in table.Rows)
                {
                    Resul.Add(new DataObject(item));
                }
            return Resul;
        }
        /// <summary>
        /// Chuyển đổi từ danh sách đối tượng qua Đối tượng chuẩn
        /// </summary>
        /// <param name="table">DataTable chuyền vào</param>        
        /// <returns>List<DataObject></returns>
        public static List<DataObject> GetList(IDataReader IReader)
        {
            List<DataObject> Resul = new List<DataObject>();
            while (IReader.Read())
                Resul.Add(new DataObject(IReader));            
            return Resul;
        }
    }
    public enum NavigatorDir
    {
        /// <summary>
        /// Đẩu tiên
        /// </summary>
        First,
        /// <summary>
        /// Hiện Tại
        /// </summary>
        Current,
        /// <summary>
        /// Đằng sau
        /// </summary>
        Previous,
        /// <summary>
        /// tiếp theo
        /// </summary>
        Next,
        /// <summary>
        /// Cuối cùng
        /// </summary>
        Last

    }
}                    
