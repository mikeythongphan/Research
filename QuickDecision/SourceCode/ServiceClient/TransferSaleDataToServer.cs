using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Timers;
using System.IO;
using vnyi.Utility;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Discovery;

namespace vnyi.ServiceClient
{
    public class TransferSaleDataToServer
    {
        private static bool isTransferFileRun = false, isGetScriptProcess = false;                
        private static ServerTransfer.ITransferService Tranfer
        {
            get
            {               
                    string Url = Utility.GetConfigValue(SettingsKey.ServiceUrl);
                    ServerTransfer.TransferServiceClient client = new ServerTransfer.TransferServiceClient();
                    if (!string.IsNullOrEmpty(Url))
                        client.Endpoint.Address = new EndpointAddress(Url);          
                    return client;
            }
        }
        public static void TransferFileDataToServer()
        {
            if (isTransferFileRun)
                return;            
            try
            {                
                isTransferFileRun = true;
                Int64 ClientAutoID = 0;
                string FilePath = string.Empty;
                DataSet ds = vnyi.Library.PUB.TranferData.GetFilePlustToDataBase(1);
              //  Logger.TranferDataLog("Row Count " + ds.Tables[0].Rows.Count.ToString());
                if (ds != null)
                    if (ds.Tables.Count > 0)
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow item in ds.Tables[0].Rows)
                            {
                                try
                                {
                                    if (item["FilePath"] != null)
                                        FilePath = item["FilePath"].ToString();
                                    if (item["AUTOID"] != null)
                                        ClientAutoID = clsFormat.Int64Convert(item["AUTOID"]);
                                   // Logger.TranferDataLog(" Read file " + FilePath);
                                    if (!string.IsNullOrEmpty(FilePath))
                                        if (File.Exists(FilePath))
                                        {
                                            bool isSucess = false;
                                            do
                                                isSucess = TransferFile(FilePath);
                                            while (!isSucess);
                                            if (isSucess)
                                            {
                                                do
                                                    isSucess = vnyi.Library.PUB.TranferData.UpdateFileExcuted(ClientAutoID);
                                                while (!isSucess);
                                                File.Delete(FilePath);
                                            }
                                        }
                                        else
                                            Logger.TranferDataLog(" not exit File " + FilePath);
                                }
                                catch (Exception ex)
                                {
                                    Logger.TranferDataLog("Transfer File  " + FilePath + Environment.NewLine + ex.ToString());
                                    break;
                                }
                            }
                        }
            }
            catch (Exception ex)
            {
                Logger.TranferDataLog("Transfer File Error " + ex.ToString());
            }
            finally
            {
                isTransferFileRun = false;
            }

        }
    /// <summary>
    /// Tạo ra file Delete voi những dòng delete
    /// </summary>
    /// <param name="Toprecord"></param>
        public static void SaveFileDelete(int Toprecord)
        {
            try
            {
                int Total = 0;
                Int64 maxID = 0;
                string filePath = string.Empty, Directory = Utility.SaveFilePath, FileName = FileReplace("Delete", "sql");
                DataSet ds = vnyi.Library.PUB.TranferData.GetScriptClientForTransfer(Toprecord, out maxID, out Total);
                if (!File.Exists(Directory))
                    System.IO.Directory.CreateDirectory(Directory);
                filePath = Path.Combine(Directory, FileName);
                if (File.Exists(filePath))
                    File.Delete(filePath);
                if (ds != null)
                    if (ds.Tables.Count > 0)
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            StreamWriter WriteFile = new StreamWriter(filePath, true, Encoding.UTF8);
                            foreach (DataRow item in ds.Tables[0].Rows)
                            {

                                string Script = item["Script"].ToString();
                                if (!string.IsNullOrEmpty(Script))
                                {
                                    Script = Script.Replace("'", "''");
                                    string strScript = "DECLARE @Script NVARCHAR(max) ='" + Script + "'" + "BEGIN TRY EXEC(@Script) END TRY BEGIN CATCH print @Script EXEC dbo.sp_UserRaisError NULL,NULL,NULL,NULL END CATCH";
                                    WriteFile.Write(strScript);
                                    WriteFile.WriteLine();
                                    WriteFile.Write(" go ");
                                    WriteFile.WriteLine();
                                }
                            }
                            WriteFile.Flush();
                            WriteFile.Close();
                            WriteFile.Dispose();
                            bool resul = false;
                            int Run = 1;
                            do
                            {
                                resul = vnyi.Library.PUB.TranferData.UpdateLogClientDelete(filePath, maxID);
                                Run++;
                            }
                            while (!resul && Run < 100);
                            if (Total > maxID)
                                SaveFileDelete(Total);
                        }
            }
            catch (Exception ex)
            {
                Logger.TranferDataLog("Save File Delete Error " + ex.ToString());
            }
        }
        private static int SaveFileFromTable(string TableName, int TopRecord, bool isDelete)
        {
            int Total = 0, RowVersion=0;
            bool resul = true;
            try
            {
                DataSet data = vnyi.Library.PUB.TranferData.getdataforTransfer(TableName, TopRecord, out Total, out RowVersion);
                string Directory = Utility.SaveFilePath, FileName = FileReplace(TableName, "xml");
                
                if (isDelete)
                    TableName = "Delete_" + TableName;
                if (data != null)
                    if (data.Tables.Count > 0)
                        if (data.Tables[0].Rows.Count > 0)
                        {
                            string FilePath = System.IO.Path.Combine(Directory, FileName);
                           // Logger.TranferDataLog("RowVersion " + RowVersion.ToString());
                               string filePath= SaveFileClient(Directory, FileName, data);
                              // Logger.TranferDataLog("Save File " + FileName);
                               int Run = 1;
                               do
                               {
                                   resul = vnyi.Library.PUB.TranferData.UpdateLogClient(TableName, FilePath, RowVersion);
                                   Run++;
                               }
                               while (!resul && Run < 100);
                        }
            }
            catch (Exception ex)
            {
                Logger.TranferDataLog("Transfer " + TableName + " Error:" + ex.ToString());
                resul = false;
            }
            if (Total > TopRecord)
                return SaveFileFromTable(TableName, TopRecord, isDelete);
            else
                return Total;
        }

        /// <summary>
        /// Thực hiện chuyền số liệu
        /// </summary>
        public static void SaveFileAndLog()
        {
            try
            {

                string TableName = string.Empty;
                int TopRecord = clsFormat.IntConvert(Utility.GetConfigValue(SettingsKey.TOPRECORD));
                SaveFileDelete(TopRecord);            
                DataSet ds = vnyi.Library.PUB.TranferData.getTableTransferData();
                if (ds != null)
                    if (ds.Tables.Count > 0)
                        if (ds.Tables[0].Rows.Count > 0)
                            foreach (DataRow item in ds.Tables[0].Rows)
                            {                          
                                TableName = item["TableName"].ToString();                        
                                SaveFileFromTable(TableName, TopRecord, false);
                            }               
            }
            catch (Exception ex)
            {
                Logger.TranferDataLog(" TransferFileToServer Error :" + ex.ToString());
            }
        }
        public static bool SaveStreamToFile(string FilePath, ServerTransfer.RemoteFileInfo Infor)
        {
            try
            {
                FileStream targetStream = null;
                Stream sourceStream = Infor.FileByteStream;
                if (File.Exists(FilePath))
                    File.Delete(FilePath);
                using (targetStream = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    const int bufferLen = 65000;
                    byte[] buffer = new byte[bufferLen];
                    int count = 0;
                    while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
                    {
                        targetStream.Write(buffer, 0, count);
                    }
                    targetStream.Flush();
                    targetStream.Close();
                    sourceStream.Close();
                    sourceStream.Dispose();
                    sourceStream.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.TranferDataLog("SaveStreamToFile Error " + ex.ToString());
                return false;
            }
        }
        private static bool isRunscriptFile = false;
        /// <summary>
        /// Thực hiện chạy file 
        /// </summary>
        public static void RunScripFile()
        {
            if (isRunscriptFile)
                return;
            try
            {
                isRunscriptFile = true;
                DataSet ds = vnyi.Library.PUB.TranferData.GetFilePlustToDataBase(2);
                if (ds != null)
                    if (ds.Tables.Count > 0)
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow item in ds.Tables[0].Rows)
                            {

                                string FilePath = item["FilePath"].ToString();
                                if (File.Exists(FilePath))
                                {
                                    Int64 AutoID = clsFormat.Int64Convert(item["AUTOID"]);                                   
                                   Logger.TranferDataLog("Excuse file  " + FilePath);
                                    Conection conect = Utility.getConection();
                                    string command = "/c sqlcmd -S " + conect.ServerName + " -U " + conect.Uid + " -P " + conect.Pwd + " -d " + conect.DataBase + " -i \"" + FilePath + "\"";// -o \"" + fileOutPut + "\"";
                                    ProcessStartInfo info = new ProcessStartInfo("cmd", command);
                                    info.UseShellExecute = false;
                                    info.CreateNoWindow = true;
                                    info.WindowStyle = ProcessWindowStyle.Hidden;
                                    info.WorkingDirectory = System.IO.Path.GetTempPath();
                                    info.RedirectStandardOutput = true;
                                    info.RedirectStandardError = true;
                                    Process p = new Process();
                                    p.StartInfo = info;
                                    p.Start();                                    
                                    string OutPut = p.StandardOutput.ReadToEnd();
                                    if (!string.IsNullOrEmpty(OutPut))
                                        Logger.TranferDataLog(OutPut);
                                    OutPut = p.StandardError.ReadToEnd();                                    
                                    p.WaitForExit();
                                    bool isUpdateSucess = false;
                                    do
                                        isUpdateSucess = vnyi.Library.PUB.TranferData.UpdateFileExcuted(AutoID);
                                    while (!isUpdateSucess);
                                   File.Delete(FilePath);
                                }
                            }
                        }
            }
            catch (Exception ex)
            {
                Logger.TranferDataLog("Excuce Script Error :" + ex.ToString());
            }
            finally
            {
                isRunscriptFile = false;
            }
         
        }        
       /// <summary>
       /// DowLoad file từ Server Ve Client
       /// </summary>
        public static void GetScriptAndFlusToDataBase()
        {
           // Logger.TranferDataLog(isGetScriptProcess.ToString() + "Runing time " + DateTime.Now.ToString());
            if (isGetScriptProcess)
                return;
            try
            {
                isGetScriptProcess = true;
                int TopRecord = clsFormat.IntConvert(Utility.GetConfigValue(SettingsKey.TOPRECORD));
                Logger.TranferDataLog("--------------------------------------------------------");

                ServerTransfer.DownloadRequest requestData = new ServerTransfer.DownloadRequest();
                ServerTransfer.RemoteFileInfo fileInfo = new ServerTransfer.RemoteFileInfo();
                requestData.TopRecord = TopRecord;
                requestData.Key = Utility.getKey;
                requestData.IPAddress = vnyi.Utility.RES.clsMisc.GetIP();
                requestData.Type = "script";
                fileInfo = Tranfer.DownloadFile(requestData);

                if (fileInfo.isSuccess)
                {
                    string Directory = Utility.SaveFilePath;
                    if (!File.Exists(Directory))
                        System.IO.Directory.CreateDirectory(Directory);
                    string FilePath = System.IO.Path.Combine(Directory, fileInfo.FileName);
                    if (File.Exists(FilePath))
                        File.Delete(FilePath);
                    if (SaveStreamToFile(FilePath, fileInfo))
                    {
                        bool isInsertLogFile = false;
                        do
                            isInsertLogFile = vnyi.Library.PUB.TranferData.transferInsertQueue(new Guid(Utility.getKey), FilePath, 2);
                        while (!isInsertLogFile);
                        ServerTransfer.MessegerResquest request = new ServerTransfer.MessegerResquest
                        {
                            FileName = fileInfo.FileName,
                            FilePath = fileInfo.FilePath,
                            Status = Meta.log.Status.Success,
                            Title = "Get File Success " + fileInfo.FileName,
                            Type = 2,
                            Key = Utility.getKey
                        };
                        if (fileInfo.RowVersion > 0)
                            request.RowVersionLog = fileInfo.RowVersion;
                        Logger.TranferDataLog("RowVersion" + fileInfo.RowVersion.ToString());
                        ServerTransfer.Status st = null;
                        do
                            st = Tranfer.LogerMesseger(request);
                        while (!st.isSucess);
                        if (fileInfo.TotalRecord > TopRecord)
                            GetScriptAndFlusToDataBase();
                    }
                }
            }
            catch (Exception ex)
            {

                Logger.TranferDataLog("Get Script Error " + ex.ToString());
            }
            finally
            {

                isGetScriptProcess = false;
            }
        }

        #region Chuyền phiếu bán hàng và thông tin liên quan


        /// <summary>
        /// Chuyển file Lên server
        /// </summary>
        /// <param name="Directory">Thư mục chứa file</param>
        /// <param name="FileName">Tên file</param>
        /// <param name="ds">Data set</param>
        /// <returns>bool = true thành công else thất bại</returns>
        private static string SaveFileClient(string Directory, string FileName, DataSet ds)
        {
            try
            {
                if (!File.Exists(Utility.SaveFilePath))
                    System.IO.Directory.CreateDirectory(Directory);
                string FilePath = System.IO.Path.Combine(Directory, FileName);
                if (File.Exists(FilePath))
                    File.Delete(FilePath);
                using (System.IO.FileStream stream = System.IO.File.Create(FilePath, 1024))
                    ds.WriteXml(stream);

                return FilePath;
                //  Logger.TranferDataLog("transfering " + FileName);
            }
            catch (Exception ex)
            {
                Logger.TranferDataLog("TranferFile Error FileName " + FileName + Environment.NewLine + ex.ToString());
                return string.Empty;
            }
        }
        /// <summary>
        /// Chuyen so lieu
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        public static bool TransferFile(string FilePath)
        {
            try
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(FilePath);
                ServerTransfer.RemoteFileInfo uploadRequestInfo = new ServerTransfer.RemoteFileInfo();
                using (System.IO.FileStream stream = new System.IO.FileStream(FilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    uploadRequestInfo.FileName = fileInfo.Name;
                    uploadRequestInfo.Length = fileInfo.Length;
                    uploadRequestInfo.FileByteStream = stream;
                    uploadRequestInfo.Key = Utility.getKey;
                    ServerTransfer.Status resul = Tranfer.UploadFile(uploadRequestInfo);
                    return resul.isSucess;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Tạo ra tên file 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="subfix"></param>
        /// <returns></returns>
        private static string FileReplace(string TableName, string subfix)
        {    
            return TableName + "&" + System.Guid.NewGuid().ToString() +"." + subfix;
        }
        #endregion
        #region chuyền những record bị xóa ở client
        private static void DeleteData()
        {
            DataSet ds = vnyi.Library.PUB.TranferData.getListDataDeleteForTransfer();

            //int Type;
            //if (ds != null)
            //    if (ds.Tables.Count > 0)
            //        if (ds.Tables[0].Rows.Count > 0)
            //        {
            //            foreach (DataRow item in ds.Tables[0].Rows)
            //            {
            //                try
            //                {
            //                    ClientID = clsFormat.IntConvert(item["ClientID"]);
            //                    ServerID = clsFormat.IntConvert(item["ServerID"]);
            //                    Type = clsFormat.IntConvert(item["TYPE"]);
            //                    if (ServerID > 0)
            //                    {
            //                        if (Tranfer.DeleteData(ServerID, Type))
            //                        {
            //                            bool isSucess = ServerTransfer.UpdateLogClient(ServerID, ClientID, 1, Type);
            //                            while (!isSucess)
            //                                isSucess = ServerTransfer.UpdateLogClient(ServerID, ClientID, 1, Type);
            //                        }
            //                    }
            //                }
            //                catch (Exception ex)
            //                {
            //                    Logger.TranferDataLog("Delete Error  ware Error" + ex.Message);
            //                }
            //            }

            //        }
        }
        /// <summary>
        /// Dọn rác ở client xóa tất cả những thông tin liên quan chi sừ dụng trong vòng 24 tiếng khách
        /// </summary>
        private static void garbageDataClient()
        {
            //try
            //{
            //    int resul = vnyi.Library.PUB.TranferData.garbageDataClient(DateTime.Now);
            //    //   Logger.TranferDataLog("record garbage" + resul.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Logger.TranferDataLog("garbageDataClient Error" + DateTime.Now.ToString() + ex.ToString());
            //}
        }
        #endregion
    }
}