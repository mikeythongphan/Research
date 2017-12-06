using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using vnyi.DataProvider;
using System.Web;
using System.Web.SessionState;
using System.IO;
using System.Xml;
using System.Xml.Xsl;
using System.Threading;
using vnyi.Utility;
using System.Configuration;
using GemBox.Spreadsheet;
using Ext.Net;
using System.Globalization;
using System.Web.Hosting;

namespace vnyi.Utility
{
    
    /// <summary>
    /// Export class;
    /// </summary>
    public sealed class Export
    {
        /// <summary>
        /// Xuất ra file theo dataSet
        /// </summary>
        /// <param name="ds">Data set</param>
        /// <param name="fileName">Tên file xuất ra</param>
        /// <param name="type">
        /// các dạng file có thể xuất
        /// [StringValue("XLS")]
        /// Excel_97_2003 = 1,           
        /// Excel_2007 = 2, 
        /// Comma_Separated_Values = 5,               
        /// OpenOffice_Spreadsheet = 6,              
        /// Hyper_Text_Markup_Language = 7,
        /// </param>
        public static void Flush(DataSet ds, string fileName, string SheetName, FileType type)
        {
            fileName += "." + type.GetStringValue();
            ExcelHelper.ToExcel(ds, fileName, SheetName, type);
        }
        
        /// <summary>
        /// thực hiện xuất file theo store
        /// </summary>
        /// <param name="store">Tên store lấy Data</param>
        /// <param name="SheetName">Tên Sheet trên file Excel</param>       
        /// <param name="fileNameExport">Tên file xuất ra</param>
        /// <param name="type">
        /// các dạng file có thể xuất
        /// [StringValue("XLS")]
        /// Excel_97_2003 = 1,           
        /// Excel_2007 = 2, 
        /// Comma_Separated_Values = 5,               
        /// OpenOffice_Spreadsheet = 6,              
        /// Hyper_Text_Markup_Language = 7,
        /// </param>
        /// <param name="FileMashName">Tên file Mash
        /// FileMash: là file map giưa các columnName và header hiển thị trên file Excel
        /// </param>
        /// <param name="paras">
        /// Danh sách parramter chuyền vào cho store
        /// </param>
        public static void Flush(string store, string SheetName, string fileNameExport, FileType type, string FileMashName, params object[] paras)
        {
            string FileMashPath = ExcelHelper.GetFileMashFullPath(FileMashName);
            fileNameExport += "." + type.GetStringValue();
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, store, paras);
            List<ExportMash> lstMash = ListMash(FileMashPath);
            List<DataColumn> clRemove = new List<DataColumn>();
            bool CheckColumn;
            foreach (DataColumn item in ds.Tables[0].Columns)
            {
                CheckColumn = false;
                foreach (ExportMash Maitem in lstMash)
                    if (item.ColumnName == Maitem.ColumName)
                    {
                        item.ColumnName = Maitem.MashName.Trim();
                        CheckColumn = true;
                        break;
                    }
                if (!CheckColumn)
                {
                    clRemove.Add(item);
                }

            }
            foreach (DataColumn dr in clRemove)
                ds.Tables[0].Columns.Remove(dr);
            ExcelHelper.ToExcel(ds, fileNameExport, SheetName, type);
        }
        /// <summary>
        /// thực hiện xuất file theo store
        /// </summary>
        /// <param name="store">Tên store lấy Data</param>
        /// <param name="SheetName">Tên Sheet trên file Excel</param>       
        /// <param name="fileNameExport">Tên file xuất ra</param>
        /// <param name="Filetype">
        /// đuôi file muốn xuất ra hỗ trợ mộ số loại
        /// XLS
        /// XLSX       
        /// CSV      
        /// ODS
        /// HTML
        /// <param name="paras">
        /// Danh sách parramter chuyền vào cho store
        /// </param>
        public static void Flush(string store, string SheetName, string fileNameExport, string Filetype, string FileMashName, params object[] paras)
        {
            FileType type = GetFileType(Filetype.ToUpper());
            string FileMashPath = ExcelHelper.GetFileMashFullPath(FileMashName);
            fileNameExport += "." + type.GetStringValue();
            DataSet ds = new DataSet();
            SqlHelper.ExecuteDataset(ds, store, paras);
            List<ExportMash> lstMash = ListMash(FileMashPath);
            DataTable tmp = ds.Tables[0].Copy();
            ds.Tables[0].Constraints.Clear();
            foreach (DataColumn item in tmp.Columns)
            {
                IEnumerable<ExportMash> results = (
                 from obj in lstMash
                 where obj.ColumName == item.ColumnName
                 select obj);
                if (results.Count<ExportMash>() <= 0)
                {
                    ds.Tables[0].Columns[item.ColumnName].AllowDBNull = true;
                    ds.Tables[0].Columns.Remove(item.ColumnName);
                }
            }
            foreach (DataColumn item in ds.Tables[0].Columns)
            {
                IEnumerable<ExportMash> results = (
                from obj in lstMash
                where obj.ColumName == item.ColumnName
                select obj);
                if (results.Count<ExportMash>() > 0)
                {
                    item.ColumnName = results.Single().MashName.Trim();
                }
            }
            ExcelHelper.ToExcel(ds, fileNameExport, SheetName, type);
        }
        public static void Flush(DataSet ds, string SheetName, string fileNameExport, string Filetype, string FileMashName)
        {
            FileType type = GetFileType(Filetype.ToUpper());
            string FileMashPath = ExcelHelper.GetFileMashFullPath(FileMashName);
            fileNameExport += "." + type.GetStringValue();
            List<ExportMash> lstMash = ListMash(FileMashPath);
            DataTable tmp = ds.Tables[0].Copy();
            ds.Tables[0].Constraints.Clear();
            if (lstMash.Count > 0)
            {
                foreach (DataColumn item in tmp.Columns)
                {
                    IEnumerable<ExportMash> results = (
                     from obj in lstMash
                     where obj.ColumName == item.ColumnName
                     select obj);
                    if (results.Count<ExportMash>() <= 0)
                    {
                        ds.Tables[0].Columns[item.ColumnName].AllowDBNull = true;
                        ds.Tables[0].Columns.Remove(item.ColumnName);
                    }
                }
                foreach (DataColumn item in ds.Tables[0].Columns)
                {
                    IEnumerable<ExportMash> results = (
                    from obj in lstMash
                    where obj.ColumName == item.ColumnName
                    select obj);
                    if (results.Count<ExportMash>() > 0)
                    {
                        item.ColumnName = results.Single().MashName.Trim();
                    }
                }
            }
            ExcelHelper.ToExcel(ds, fileNameExport, SheetName, type);
        }
        /// <summary>
        /// Trả về list danh tên cột dưới database , tên cột trong template, kiểu dữ liệu và trạng thái imp 
        /// </summary>
        /// <param name="pathXml">truyền vào đường dẫn full của file xml</param>
        /// <returns></returns>
        public static List<ExportMash> ListMash(string pathXml)
        {
            List<ExportMash> MyList = new List<ExportMash>(); ;
            try
            {
                XmlDocument MyDoc = new XmlDocument();
                MyDoc.Load(pathXml);
                XmlNode root = MyDoc.SelectSingleNode("root");
                XmlNodeList entryNode = root.SelectNodes("Colum");
                foreach (XmlNode node in entryNode)
                {
                    ExportMash Info = new ExportMash();

                    XmlNode ColumName = node.SelectSingleNode("ColumName");
                    XmlNode MashName = node.SelectSingleNode("MashName");
                    XmlNode DataType = node.SelectSingleNode("DataType");
                    XmlNode IsInsert = node.SelectSingleNode("IsInsert");
                    Info.ColumName = ColumName.InnerText;
                    Info.MashName = MashName.InnerText;
                    Info.DataType = DataType.InnerText;
                    if (IsInsert.InnerText != string.Empty)
                        Info.IsInsert = clsFormat.BooleanConvert(IsInsert.InnerText.Trim());
                    else Info.IsInsert = true;
                    MyList.Add(Info);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return MyList;
        }


        /// <summary>
        ///  Trả về đuôi của các kiểu dữ liệu
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public static FileType GetFileType(string TypeName)
        {
            FileType file = new FileType();
            switch (TypeName)
            {
                case "XLS":
                    {
                        file = FileType.Excel_97_2003;
                    }
                    break;
                case "XLSX":
                    {
                        file = FileType.Excel_97_2003;
                        //file = FileType.Excel_2007;
                    }
                    break;
                case "CSV":
                    {
                        file = FileType.Comma_Separated_Values;
                    }
                    break;
                case "ODS":
                    {
                        file = FileType.OpenOffice_Spreadsheet;
                    }
                    break;
                case "HTML":
                    {
                        file = FileType.Hyper_Text_Markup_Language;
                    }
                    break;
            }
            return file;
        }
    }

    /// <summary>
    /// Import class
    /// </summary>
    public sealed class Import
    {
        /// <summary>
        /// trả về danh sách các record trong file excel 
        /// </summary>
        /// <param name="file">có thể lấ từ thuộc tính của fileuploadfield (fufImport.PostedFile)</param>
        /// <param name="fileNameMash">truyền vào tên của file xml để lấy template</param>
        /// <returns></returns>
        public static List<object> ListObjImport(HttpPostedFile file, string FileMashName)
        {
            List<object> listReturn = new List<object>();
            DataSet ds = Import.GetData(file);
            string FileMash = ExcelHelper.GetFileMashFullPath(FileMashName);
            List<ExportMash> lstmash = Export.ListMash(FileMash);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                List<object> Param = new List<object>();
                foreach (ExportMash ExMash in lstmash)
                {
                    if (ExMash.IsInsert)
                        Param.Add(Import.ConvertType(row[ExMash.MashName].ToString(), ExMash.DataType));
                }
                listReturn.Add(Param);
            }
            return listReturn;
        }

        /// <summary>
        /// Lấy parramter dành cho inport
        /// trả về 3 tham số 
        /// 0: chuỗi kiểm tra đã tồn tại bảng tạm chưa nếu tồn tại rồi thì xóa đi
        /// 1: chuổi lấy dữ liệu từ file xml ra đưa vào bảng tạm
        /// 2: Đường dẫn file xml ( dùng để xóa file khi import thành công )
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fileNameMash"></param>
        /// <param name="TableTmp"></param>
        /// <param name="langID"></param>
        /// <returns></returns>
        public static List<string> GetParramterImport(HttpPostedFile file, string FileMashName, string TableTmp, Int16? langID, out string FilePath)
        {
            List<string> list = new List<string>();
            list.Add("IF EXISTS ( SELECT name FROM  sysobjects WHERE name = N'" + TableTmp + "') DROP TABLE " + TableTmp + " ");
            FilePath = string.Empty;
            string Resul = " Declare @xml VARCHAR(MAX) Declare @i as int select @xml=BulkColumn from openrowset(bulk '", TableName = string.Empty, strWhere = " Where ";
            string FileMash = ExcelHelper.GetFileMashFullPath(FileMashName);
            if (string.IsNullOrEmpty(FileMash))
                return list;
            List<ExportMash> lstmash = Export.ListMash(FileMash);
            FilePath = ExcelHelper.SaveFileExcelToXml(file, lstmash, out TableName);
            if (string.IsNullOrEmpty(FilePath))
                return list;

            Resul += FilePath + "', single_clob) as cse EXEC sp_xml_preparedocument @i OUTPUT,@xml "
                + "Select * INTO " + TableTmp + " From OpenXML(@i,'/NewDataSet/" + TableName + "',2) With(";
            if (lstmash.Count > 0)
            {
                foreach (ExportMash ExMash in lstmash)
                {
                    if (ExMash.IsInsert)
                    {
                        Resul += ExMash.ColumName + " " + ExMash.DataType + ",";
                        strWhere += " " + ExMash.ColumName + " IS NOT NULL or";
                    }
                }
                strWhere = strWhere.Trim();
                strWhere = strWhere.Substring(0, strWhere.Length - 2);
                Resul = Resul.Trim(',');
                Resul += ")";
                list.Add(Resul + strWhere);
                list.Add(FilePath);
                return list;
            }
            return list;
        }
        /// <summary>
        ///  Convret thành kiểu dữ liệu cần thiết để insert xuống database convert null nếu như chuỗi rỗng
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="type">kiểu convert viết đúng như trong .net</param>
        /// <returns></returns>
        public static object ConvertType(string Value, string type)
        {
            object obj = new object();
            switch (type)
            {
                case "int":
                    {
                        if (Value.Trim().Length == 0)
                            obj = clsFormat.IntConvertNull(Value);
                        else
                            obj = clsFormat.IntConvert(Value);
                    }
                    break;
                case "Int16":
                    {
                        if (Value.Trim().Length == 0)
                            obj = clsFormat.Int16ConvertNull(Value);
                        else
                            obj = clsFormat.Int16Convert(Value);
                    }
                    break;
                case "Int32":
                    {
                        if (Value.Trim().Length == 0)
                            obj = clsFormat.IntConvertNull(Value);
                        else
                            obj = clsFormat.IntConvert(Value);
                    }
                    break;
                case "Int64":
                    {
                        if (Value.Trim().Length == 0)
                            obj = clsFormat.Int64ConvertNull(Value);
                        else
                            obj = clsFormat.Int64Convert(Value);
                    }
                    break;
                case "string":
                    {
                        obj = clsFormat.StringConvert(Value.Trim());
                    }
                    break;
                case "decimal":
                    {
                        if (Value.Trim().Length == 0)
                            obj = clsFormat.DecimalConvertNull(Value);
                        else
                            obj = clsFormat.DecimalConvert(Value);
                    }
                    break;
                case "DateTime":
                    {
                        if (Value.Trim().Length == 0)
                            obj = clsFormat.DateConvertNull(Value);
                        else
                            obj = clsFormat.DateConvert(Value);
                    }
                    break;
                case "bool":
                    {
                        if (Value.Trim().Length == 0)
                            obj = clsFormat.BooleanConvertNull(Value);
                        else
                            obj = clsFormat.BooleanConvert(Value);
                    }
                    break;
                case "byte":
                    {
                        if (Value.Trim().Length == 0)
                            obj = clsFormat.ByteConvertNull(Value);
                        else
                            obj = clsFormat.ByteConvert(Value);
                    }
                    break;

            }
            return obj;
        }


        /// <summary>
        /// Thực hiện lưu file về server và đọc file ra DataSet
        /// đọc xong sẽ tự đông xóa file này
        /// </summary>
        /// <param name="file">HttpPostedFile</param>
        /// <returns>DataSet nếu không có file thì sẽ return null</returns>
        public static DataSet GetData(HttpPostedFile file)
        {
            string folder = HttpContext.Current.Server.MapPath(@"..\\" + ConfigurationManager.AppSettings["importFolder"].ToString());
            DataSet ds = new DataSet();
            string fileName = file.FileName;
            if (fileName == string.Empty)
                return null;
            fileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
            try
            {
                if (!System.IO.Directory.Exists(folder))
                    System.IO.Directory.CreateDirectory(folder);
                if (File.Exists(folder + "\\" + fileName))
                    File.Delete(folder + "\\" + fileName);
                file.SaveAs(folder + "\\" + fileName);
                ds = ExcelHelper.getDataSet(folder + "\\" + fileName, true);
                return ds;
            }
            catch (Exception e)
            {
                if (File.Exists(folder + "\\" + fileName))
                    File.Delete(folder + "\\" + fileName);
                return null;
            }
        }
    }



    /// <summary>
    /// hỗ trợ một số hàm xuất và nhập file 
    /// </summary>
    class ExcelHelper
    {

        /// <summary>
        /// Lấy đường dần của file mash
        /// </summary>
        /// <param name="FileMashName">tên gốc của file mash</param>
        /// <returns></returns>
        public static string GetFileMashFullPath(string FileMashName)
        {
            FileMashName = FileMashName.Replace(".xml", "").Replace(".XML", "");
            string FullPath = HttpContext.Current.Server.MapPath(@"~\\Resources\\Export\\FileMash") + "\\" + FileMashName;
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["ImExLanguage"]))
                FullPath += ConfigurationManager.AppSettings["ImExLanguage"];
            FullPath += ".xml";
            return FullPath;
        }
        /// <summary>
        /// Xuất ra file excel
        /// </summary>
        /// <param name="dsInput">DataSet có data muốn xuất</param>
        /// <param name="filename">Tên file</param>
        /// <param name="SheetName">Tên Sheet trên file Excel</param>
        /// <param name="filetype">Loại file muốn xuất</param>
        public static void ToExcel(DataSet dsInput, string filename, string SheetName, FileType filetype)
        {
            DataTable da = dsInput.Tables[0];
            // Create excel file.
            ExcelFile ef = new ExcelFile();
            string[] ListSheetName = SheetName.Trim().Split(';');
            int i = 0;

            foreach (DataTable table in dsInput.Tables)
            {

                ExcelWorksheet ws = ef.Worksheets.Add(ListSheetName[i]);
                ws.InsertDataTable(table, 0, 0, true);
                i++;
                //foreach (ExcelColumn cl in ws.Columns)
                //{
                //    cl.AutoFit();                    
                //}
            }

            HttpResponse Response = HttpContext.Current.Response;
            Response.Clear();

            // Stream file to browser, in required type.
            switch (filetype.GetStringValue())
            {
                case "XLS":
                    Response.ContentType = "application/vnd.ms-excel";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + filename.Trim());
                    ef.SaveXls(Response.OutputStream);
                    break;
                case "XLSX":
                    Response.ContentType = "application/vnd.ms-excel";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + filename.Replace("XLSX", "XLS").Trim());
                    ef.SaveXls(Response.OutputStream);
                    break;
                case "CSV":
                    Response.ContentType = "text/csv";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + filename.Trim());
                    ef.SaveCsv(Response.OutputStream, CsvType.CommaDelimited);
                    break;

                //case "XLSX":
                //    Response.ContentType = "application/vnd.openxmlformats";
                //    Response.AddHeader("Content-Disposition", "attachment; filename=" + filename.Trim());
                //    // With XLSX it is a bit more complicated as MS Packaging API can't write
                //    // directly to Response.OutputStream. Therefore we use temporary MemoryStream.
                //    MemoryStream ms = new MemoryStream();
                //    ef.SaveXlsx(ms);
                //    ms.WriteTo(Response.OutputStream);
                //    break;

                case "ODS":
                    Response.ContentType = "application/vnd.oasis.opendocument.spreadsheet";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + filename.Trim());
                    ef.SaveOds(Response.OutputStream);
                    break;

                case "HTML":
                    Response.ContentType = "text/html";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + filename.Trim());
                    XmlTextWriter writer = new XmlTextWriter(Response.OutputStream, new UTF8Encoding(false));
                    ef.SaveHtml(writer, null, true);
                    writer.Close();
                    break;
            }

            Response.End();


        }

        /// <summary>
        /// lay ra chuoi connectiostring phu hop voi file excel (xls, xlsx)
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string getConnectionString(string fileName)
        {
            FileType ext = ((FileType)clsStringEnum.Parse(typeof(FileType), fileName.Substring(fileName.LastIndexOf('.') + 1).ToUpper()));
            string strConect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";";
            switch (ext)
            {
                case FileType.Excel_97_2003:
                    if (System.Configuration.ConfigurationManager.ConnectionStrings != null)
                        if (System.Configuration.ConfigurationManager.ConnectionStrings.Count >= 0)
                            if (System.Configuration.ConfigurationManager.ConnectionStrings["ConectToExcel2003"] != null)
                                strConect = System.Configuration.ConfigurationManager.ConnectionStrings["ConectToExcel2003"].ConnectionString;
                    break;
                case FileType.Excel_2007:
                    strConect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";
                    break;
            }
            strConect = string.Format(strConect, fileName);
            return strConect;
        }

        /// <summary>
        /// Lấy Dataset hoặc Schemel 
        /// </summary>
        /// <param name="strFileName"></param>
        /// <param name="isGetData"></param>
        /// <returns></returns>
        public static DataSet getDataSet(string strFileName, bool isGetData)
        {
            DataSet ds = new DataSet();
            try
            {
                string strCon = getConnectionString(strFileName);

                DataTable dt = SchemaTable(strFileName);
                OleDbDataAdapter OlDbDaA;
                if (dt.Rows.Count == 0) return null;
                else
                {
                    if (!isGetData)
                    {
                        ds.Tables.Add(dt);
                        return ds;
                    }
                    else
                    {
                        //foreach (DataRow dr in dt.Rows)
                        //{
                        OlDbDaA = new OleDbDataAdapter(string.Format("SELECT DISTINCT * FROM [{0}] ", dt.Rows[0]["TABLE_NAME"]), strCon);
                        DataTable _dt = new DataTable();
                        OlDbDaA.Fill(_dt);
                        ds.Tables.Add(_dt);
                        //}                 
                    }
                }
                File.Delete(strFileName);
            }
            catch (Exception ex)
            {
                if (File.Exists(strFileName))
                    File.Delete(strFileName);
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Chuyen file tu data set qua xml
        /// </summary>
        /// <param name="file"></param>
        /// <param name="objMash"></param>
        /// <returns></returns>
        public static string SaveFileExcelToXml(HttpPostedFile file, List<ExportMash> objMash, out string TableName)
        {
            TableName = string.Empty;
            string filePath = string.Empty;
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["virtualImFolder"]))
                filePath = ConfigurationManager.AppSettings["virtualImFolder"].TrimEnd('\\');
            else
                filePath = HostingEnvironment.MapPath("~") + "Resources\\ImportFolder";
            //ConfigurationManager.AppSettings["importFolder"];
            string fileName = string.Empty;
            if (string.IsNullOrEmpty(file.FileName))
                return string.Empty;
            else
                fileName = file.FileName.Substring(file.FileName.LastIndexOf("\\") + 1);

            string directoryName = filePath + "\\" + fileName;
            if (!System.IO.Directory.Exists(filePath))
                System.IO.Directory.CreateDirectory(filePath);
            if (File.Exists(directoryName))
                File.Delete(directoryName);
            file.SaveAs(directoryName);
            DataSet ds = ExcelHelper.getDataSet(directoryName, true);
            if (ds != null && ds.Tables.Count > 0)
            {
                ds.Locale = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

                //ds.ExtendedProperties["UTCDifference"] = TimeZone.CurrentTimeZone.StandardName;
                foreach (ExportMash mas in objMash)
                {
                    if (ds.Tables[0].Columns.Contains(mas.MashName) && mas.IsInsert)
                        ds.Tables[0].Columns[mas.MashName].ColumnName = mas.ColumName;
                }

                SetUtcDateTime(ref ds);
                TableName = "Table1";
                filePath += "\\" + System.Guid.NewGuid() + ".xml";
                ds.Tables[0].TableName = TableName;
                // SaveDataSet(ds, filePath);
                ds.WriteXml(filePath);
                return filePath;
            }
            return string.Empty;

        }
        private static void SetUtcDateTime(ref DataSet dsDistin)
        {
            var ds = new DataSet { Locale = CultureInfo.InvariantCulture };

            foreach (DataTable source in dsDistin.Tables)
            {
                bool containsDate = false;
                var target = source.Clone();

                foreach (DataColumn col in target.Columns)
                {
                    if (col.DataType == System.Type.GetType("System.DateTime"))
                    {
                        col.DateTimeMode = DataSetDateTime.Utc;
                        containsDate = true;
                    }
                }

                if (containsDate)
                {
                    foreach (DataRow row in source.Rows)
                        target.ImportRow(row);
                    ds.Tables.Add(target);
                }
                else
                {
                    ds.Tables.Add(source.Copy());
                }
            }
            dsDistin.Tables.Clear();
            dsDistin = ds;
        }
        private static void SaveDataSet(DataSet ds, string FilePath)
        {
            //XMLTextReader
            //Reads the Xml data generated by DataSet
            XmlTextReader XTReader = new XmlTextReader(ds.GetXml(), XmlNodeType.Element, null);
            //XMLTextWriter
            //To write data into xml file
            XmlTextWriter XTWriter = new XmlTextWriter(FilePath, Encoding.UTF8);
            XTWriter.WriteStartDocument();
            string fieldName = "";
            while (XTReader.Read())
            {
                switch (XTReader.NodeType)
                {
                    //Check for the Node Name
                    case XmlNodeType.Element:
                        XTWriter.WriteStartElement(XTReader.Name);
                        fieldName = XTReader.Name;
                        break;
                    //Check for the Node Value
                    case XmlNodeType.Text:
                        if (string.IsNullOrEmpty(XTReader.Value))
                            XTWriter.WriteString(string.Empty);
                        else
                        {
                            if (ds.Tables[0].Columns[fieldName].DataType == typeof(DateTime))
                            {

                                string strData = clsFormat.DateConvert(XTReader.Value).ToString(new CultureInfo("en-US"));
                                XTWriter.WriteString(strData);
                            }
                            else
                                XTWriter.WriteString(XTReader.Value);
                        }
                        break;
                    case XmlNodeType.EndElement:
                        XTWriter.WriteEndElement();
                        break;
                }
            }
            XTWriter.Close();
        }
        /// <summary>
        /// Lấy file Name từ Đata set
        /// </summary>
        /// <param name="strFileName"></param>
        /// <returns></returns>
        public static DataTable SchemaTable(string strFileName)
        {
            string strCon = getConnectionString(strFileName);

            OleDbConnection OleDbConn = new OleDbConnection(strCon);
            OleDbConn.Open();
            DataTable dt = OleDbConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            OleDbConn.Close();
            return dt;
        }
    }

    public class ExportMash
    {
        /// <summary>
        /// Tên cột dưới Data Base
        /// </summary>
        public string ColumName // Tên của colum dưới database
        {
            get;
            set;
        }
        /// <summary>
        /// Tên Trên file cần Map        
        /// </summary>
        public string MashName // Tên của colum trong XML
        {
            get;
            set;
        }
        public string DataType // Loại kiểu dữ liệu của data
        {
            get;
            set;
        }
        public bool IsInsert // Cột này có được import (insert ) hay không
        {
            get;
            set;
        }
    }
    /// <summary>
    /// Loại file xuất ra
    /// </summary>
    public enum FileType
    {
        [StringValue("XLS")]
        Excel_97_2003 = 1,
        [StringValue("XLSX")]
        Excel_2007 = 2,
        [StringValue("CSV")]
        Comma_Separated_Values = 5,
        [StringValue("ODS")]
        OpenOffice_Spreadsheet = 6,
        [StringValue("HTML")]
        Hyper_Text_Markup_Language = 7,
    }
}
