using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using ManagePincards.UPGControlService;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public class UPGRequest
    {
        static string userName = ConfigurationManager.AppSettings["userNameWebservice"].ToString();
        static string pass = ConfigurationManager.AppSettings["pass"].ToString();

        static UPGControlService upg = new UPGControlService(ConfigurationManager.AppSettings["upgService"]);
        /// <summary>
        /// get payment from upg
        /// </summary>
        /// <returns>Xml string</returns>
        public static string upgGetPayments()
        {
            #region config
            int selectTop = 100;
            int remainDay = -1;
            try
            {
                selectTop = int.Parse(ConfigurationManager.AppSettings["top"]);
            }
            catch
            {
                //Tools.Logger("Wrong config selectTop in web.config", "UPGRequest", "upgGetPayments");
            }
            try
            {
                remainDay = int.Parse(ConfigurationManager.AppSettings["remainDay"]);

            }
            catch
            {
                //Tools.Logger("Wrong config remainDay in web.config", "UPGRequest", "upgGetPayments");
            }
            #endregion
            try
            {
                var result = upg.GetPayments(userName, pass, null, null, null, String.Empty, DateTime.Now.AddDays(remainDay), DateTime.Now.AddHours(1), selectTop);
                return result.SetOfData.GetXml();
            }
            catch (Exception ex)
            {
                //Tools.Logger(ex.Message, "UPGRequest", "upgGetPayments");
                return null;
            }
        }
        /// <summary>
        /// get top payment with status
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static string upgGetPaymentWithStatus(byte status)
        {
            #region config
            int selectTop = 100;
            int remainDay = -1;
            try
            {
                selectTop = int.Parse(ConfigurationManager.AppSettings["top"]);
            }
            catch
            {
                //Tools.Logger("Wrong config selectTop in web.config", "UPGRequest", "upgGetPaymentWithStatus");
            }
            try
            {
                remainDay = int.Parse(ConfigurationManager.AppSettings["remainDay"]);
            }
            catch
            {
                //Tools.Logger("Wrong config remainDay in web.config", "UPGRequest", "upgGetPaymentWithStatus");
            }
            #endregion
            try
            {
                var result = upg.GetPayments(userName, pass, null, null, status, String.Empty, DateTime.Now.AddDays(remainDay), DateTime.Now.AddHours(1), selectTop);
                return result.SetOfData.GetXml();
            }
            catch (Exception ex)
            {
                //Tools.Logger(ex.Message, "UPGRequest", "upgGetPaymentWithStatus");
                return null;
            }
        }
        /// <summary>
        /// gettable data from upg
        /// </summary>
        /// <param name="tableName"> name tablw</param>
        /// <param name="primaryID"> primary key </param>
        /// <returns>string xml </returns>
        public static string upgGetTable(string tableName, int? primaryID)
        {
            try
            {
                return upg.GetTable(userName, pass, tableName, primaryID).SetOfData.GetXml();
            }
            catch (Exception ex)
            {
                //Tools.Logger(ex.Message, "UPGRequest.cs", "upgGetTable");
                return null;
            }
        }
        /// <summary>
        /// find log of idportal (AgentPayMentID)
        /// </summary>
        /// <param name="idPortal">AgentPayment ID</param>
        /// <param name="protocolID">Protocol id</param>
        /// <returns>xml string </returns>
        public static string findLogString(decimal idPortal, int protocolID, DateTime PayDate)
        {
            #region config
            string charset = "";
            int spreadLines = 1;
            bool caseSensitive = false;
            int fileType = 1;
            int maxLine = 100;
            charset = ConfigurationManager.AppSettings["charset"].ToString();
            try
            {
                spreadLines = int.Parse(ConfigurationManager.AppSettings["SpreadLines"]);
            }
            catch
            {
                //Tools.Logger("Wrong config spreadLines in web.config", "findLogString", "UPGRequest");
            }
            try
            {
                caseSensitive = bool.Parse(ConfigurationManager.AppSettings["CaseSensitive"]);
            }
            catch
            {
                //Tools.Logger("Wrong config caseSensitive in web.config", "findLogString", "UPGRequest");
            }
            try
            {
                fileType = int.Parse(ConfigurationManager.AppSettings["FileType"]);
            }
            catch
            {
                //Tools.Logger("Wrong config fileType in web.config", "findLogString", "UPGRequest");
            }
            try
            {
                maxLine = int.Parse(ConfigurationManager.AppSettings["Maxline"]);
            }
            catch
            {
                //Tools.Logger("Wrong config maxLine in web.config", "findLogString", "UPGRequest");
            }
            string strDate = PayDate.ToString("yyyy-MM-dd");
            #endregion
            try
            {
                return upg.FindLogString(userName, pass, protocolID, strDate, string.Empty, string.Empty, idPortal.ToString(), charset, spreadLines, caseSensitive, fileType, maxLine).SetOfData.GetXml();
            }
            catch (Exception ex)
            {
                //Tools.Logger("Khong tim thay log ProtocolID = " + protocolID.ToString() + " , idPortal = :" + idPortal.ToString(), "UPGRequest", "findLogString");
                //Tools.Logger(ex.Message, "UPGRequest.cs", "findLogString");
                return null;
            }
        }
        /// <summary>
        /// get all payment in queue
        /// </summary>
        /// <returns> xml string</returns>
        public static string getPaymentQueue()
        {
            try
            {
                return upg.GetPaymentsQueues(userName, pass).SetOfData.GetXml();
            }
            catch (Exception ex)
            {
                //can't not connect to upg
                //Tools.Logger(ex.Message, "UPGRequest.cs", "getPaymentQueue");
                return null;
            }

        }
        /// <summary>
        /// get all available pin card in store from upg
        /// </summary>
        /// <returns>xml string </returns>
        public static string getAvailablePinCard()
        {
            try
            {
                return upg.GetAvailablePinCards(userName, pass).SetOfData.GetXml();
            }
            catch (Exception ex)
            {
                //Tools.Logger(ex.Message, "UPGRequest.cs", "getAvailablePinCard");
                return null;
            }
        }
        /// <summary>
        /// Search payment with number 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string searchPaymentWithNumber(string number)
        {
            try
            {
                int remainDaySearch = -1095;//search 3 year ago
                int countSearch = 100;//show 100 record
                var result = upg.GetPayments(userName, pass, null, null, null, number, DateTime.Now.AddDays(remainDaySearch), DateTime.Now.AddHours(1), countSearch);
                return result.SetOfData.GetXml();
            }
            catch (Exception ex)
            {
                //Tools.Logger(ex.Message, "UPGRequest", "searchPaymentWithNumber");
                return null;
            }
        }
    }
}
