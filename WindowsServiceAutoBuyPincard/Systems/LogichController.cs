using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Logich;
using WSLogic;
using System.Configuration;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public class LogichController
    {
        PartnerService wsLogic = new PartnerService(ConfigurationManager.AppSettings["WSLogich"]);
        public string SessionID { get; set; }

        public LogichController()
        {
            SessionID = string.Empty;
        }

        public string ResponseLogin()
        {
            response objResponse = new response();
            string sessionID = string.Empty;
            objResponse.requestBase64 = Logich.Tools.base64Encode(RequestToLogic.RequestLogin(ConfigurationManager.AppSettings["UserNameLogich"], ConfigurationManager.AppSettings["appid"], ConfigurationManager.AppSettings["PasswordLogich"], ConfigurationManager.AppSettings["Version"], ConfigurationManager.AppSettings["partnercode"]));
            objResponse.resultEnCode = wsLogic.UserRequest(objResponse.requestBase64);
            objResponse = response.ParseResult(Logich.Tools.base64Decode(objResponse.resultEnCode));
            if (objResponse.state == "0")
                sessionID = objResponse.sessionid;
            return sessionID;
        }

        public response ResponsePincode(string cost)
        {
            var newObjresponse = new response();
            //check balance
            var objResponseBalance = ResponseBalance();
            if (objResponseBalance.state != "0")
            {
                SessionID = ResponseLogin();
                objResponseBalance = ResponseBalance();
            }
            double balance = Convert.ToDouble(objResponseBalance.balance);
            if (!string.IsNullOrEmpty(SessionID))
            {
                if (balance > 0)
                {

                    newObjresponse.requestBase64 =
                        Logich.Tools.base64Encode(RequestToLogic.RequestPrepaid(SessionID, cost.Trim(), "1"));
                    newObjresponse.resultEnCode = wsLogic.UserRequest(newObjresponse.requestBase64);
                    string resultFromLogic = newObjresponse.resultEnCode;
                    newObjresponse = response.ParseResult(Logich.Tools.base64Decode(newObjresponse.resultEnCode));
                    if (newObjresponse.state == "0")
                    {
                        XmlElement xmlElement = XMLHelper.GetElement(Logich.Tools.base64Decode(resultFromLogic));
                        newObjresponse.products[0].code = xmlElement.GetElementsByTagName("code")[0].InnerXml;
                        newObjresponse.products[0].serial = xmlElement.GetElementsByTagName("serial")[0].InnerXml;
                        newObjresponse.products[0].expdate = xmlElement.GetElementsByTagName("expdate")[0].InnerXml;
                    }
                }
                else
                {
                    Tools.Logger("So du hien tai khong du de thuc hien thanh toanh", "ResponsePinCode", "ResponePinCode");
                }
            }
            return newObjresponse;
        }

        public response ResponseBalance()
        {
            response objResponse = new response();
            string requestBalance = RequestToLogic.RequestBalance(SessionID);
            objResponse.requestBase64 = Logich.Tools.base64Encode(requestBalance);
            objResponse.resultEnCode = wsLogic.UserRequest(objResponse.requestBase64);
            objResponse = response.ParseResult(Logich.Tools.base64Decode(objResponse.resultEnCode));
            return objResponse;
        }

        public response ResponseSumReport(string sessionID, string fromdate, string todate)
        {
            response objResponse = new response();
            string requestSumReport = RequestToLogic.RequestSumReport(sessionID, fromdate, todate);

            objResponse.requestBase64 = Logich.Tools.base64Encode(requestSumReport);
            objResponse.resultEnCode = wsLogic.UserRequest(objResponse.requestBase64);
            objResponse = response.ParseResult(Logich.Tools.base64Decode(objResponse.resultEnCode));
            return objResponse;
        }

        public response ResponseDetailReport(string sessionID, string fromdate, string todate)
        {
            response objResponse = new response();
            string requestSumReport = RequestToLogic.RequestDetailReport(sessionID, fromdate, todate);

            objResponse.requestBase64 = Logich.Tools.base64Encode(requestSumReport);
            objResponse.resultEnCode = wsLogic.UserRequest(objResponse.requestBase64);
            objResponse = response.ParseResult(Logich.Tools.base64Decode(objResponse.resultEnCode));
            return objResponse;
        }

        public string ResponseLogout(string sessionID)
        {
            var newObjresponse = new response();
            newObjresponse.requestBase64 = Logich.Tools.base64Encode(RequestToLogic.RequestLogout(sessionID));
            newObjresponse.resultEnCode = wsLogic.UserRequest(newObjresponse.requestBase64);
            newObjresponse = response.ParseResult(Logich.Tools.base64Decode(newObjresponse.resultEnCode));
            return newObjresponse.message;
        }
    }
}
