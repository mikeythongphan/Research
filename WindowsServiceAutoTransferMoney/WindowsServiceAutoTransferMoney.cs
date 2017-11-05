using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using WindowsServiceAutoTransferMoney.Systems;
using System.Threading;
using System.Configuration;
using Librarys.REPORTSPAYMENT;
using Librarys.SYSTEM.CONFIGURATION;
using Librarys.CRM;
using Utilities;
using System.Xml;
using Bases;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections;
using XmlLibrary;
using XmlProtocolLibrary;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace WindowsServiceAutoTransferMoney
{
    partial class WindowsServiceAutoTransferMoney : ServiceBase
    {
        private System.Timers.Timer ACS_Timer;
        private static int TimerCounting = 0;
        private static int PoolCounting = 0;
        private object lockPoolCounting = new object();
        protected static int MaxTryCount = 10;
        protected static int MaxPool = 1;
        protected static int IntervalSeconds = 30;
        protected static int DelaySeconds = 60;
        protected static bool IsStop = false;
        private static int MAX_POOL = 1000;
        private static int MAX_NUMBERS = 10000;
        private DateTime BeginTime = DateTime.Now;
        private DateTime EndTime = DateTime.Now;

        public WindowsServiceAutoTransferMoney()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            this.Run();
        }

        void Run()
        {
            Logger.Log(Environment.NewLine + "_____Service Timer starting...");
            MaxPool = MAX_POOL;
            MaxTryCount = 1000;
            IntervalSeconds = 30;
            DelaySeconds = 60;
            IsStop = false;
            ACS_Timer = new System.Timers.Timer(IntervalSeconds * 1000);
            ACS_Timer.Elapsed += new ElapsedEventHandler(Service_Timer_Function);
            ACS_Timer.Enabled = true;
            ACS_Timer.Start();
        }

        private void Service_Timer_Function(object obj, ElapsedEventArgs e)
        {
            try
            {
                if (!IsStop)
                {
                    try
                    {
                        if (TimerCounting % 100 == 0)
                        {
                            if (TimerCounting > 1000)
                                TimerCounting = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Log("TimerCounting : " + ex.Message);
                        Logger.Log("TimerCounting : " + ex.StackTrace);
                        Logger.Log("TimerCounting : " + ex.InnerException);
                    }
                    TimerCounting++;
                    Logger.Log("_____Service Timer started");
                    Logger.Log("TimerCounting: \t" + TimerCounting.ToString());
                    Logger.Log("PoolCounting: \t" + PoolCounting.ToString());

                    Logger.Log("Get Payment from Database:______________________________________________");

                    #region Find BankSMS for Purchase Order
                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                    List<PURCHASING> lstPurchasing1 = DataOut.CRM_PURCHASING_GetAllPURCHASINGListNew();
                    Logger.Log("Get Purchasing list from Database to auto confirm transfer money:______________________________________________" + lstPurchasing1.Count);
                    if (lstPurchasing1.Count > 0)
                    {
                        foreach (PURCHASING Payment in lstPurchasing1)
                        {
                            Logger.Log("PURCHASING AUTOID : " + Payment.PURCHASE_AUTOID);
                            DateTime PayDate = DateTime.Now;
                            Int64? PurchasingID = Payment.PURCHASE_AUTOID;
                            string PurchasingCode = Payment.PURCHASE_CODE;
                            string AgentID = clsFormat.StringConvert(Payment.AGENTID);
                            List<BANKSMS> lstBankSms = DataOut.CRM_BANKSMS_GetAllBANKSMSAmountInListToMapPurchasing();
                            if (lstBankSms.Count > 0)
                            {
                                foreach (BANKSMS banksms in lstBankSms)
                                {
                                    if (((banksms.BANKSMS_AMOUNTIN == Payment.PURCHASE_AMOUNT && banksms.AGENT_ID == Payment.AGENTID)
                                        || (banksms.BANKSMS_AMOUNTIN == Payment.PURCHASE_AMOUNT && banksms.AGENT_ID == null)
                                        || (banksms.BANKSMS_AMOUNTIN == Payment.PURCHASE_AMOUNT && banksms.AGENT_ID == 0))
                                        && banksms.BANKACC_AUTOID == Payment.BANKACC_AUTOID
                                        && banksms.BANKSMS_PAYMENTCODE == Payment.PURCHASE_CODE
                                        && banksms.BANKSMS_RECEIVEDATE >= Payment.PURCHASE_CREATEDATE)
                                    {
                                        List<BANKACCOUNT> lstBankAcc = DataOut.CRM_GetAllBANKACCOUNTListIsActive();
                                        if (lstBankAcc.Count > 0)
                                        {
                                            foreach (BANKACCOUNT bankacc in lstBankAcc)
                                            {
                                                if (banksms.BANKSMS_ACCOUNTRECEIVE == bankacc.BANKACC_NUMBER)
                                                {
                                                    banksms.BANKSMS_ISACTIVE = true;
                                                    Payment.BANKSMS_AUTOID = banksms.BANKSMS_AUTOID;
                                                    Payment.PURCHASE_ISACTIVE = true;
                                                    Payment.PURCHASE_ISDEFAULT = true;
                                                    Payment.PURCHASE_ISNOTCHANGE = false;
                                                    Payment.STT_AUTOID = 26;
                                                    if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                                        Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString() + " - Ðã tìm thấy tin nhắn.");
                                                    else
                                                        Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString() + " - Ðã tìm thấy tin nhắn.");
                                                    if (DataIn.CRM_BANKSMS_InsertUpdate(banksms))
                                                        Logger.Log("Banksms update status successful : " + banksms.BANKSMS_AUTOID.ToString());
                                                    else
                                                        Logger.Log("Banksms update status successful : " + banksms.BANKSMS_AUTOID.ToString());
                                                    if (banksms.AGENT_ID != Payment.AGENTID)
                                                    {
                                                        Payment.PURCHASE_ISACTIVE = true;
                                                        Payment.PURCHASE_ISDEFAULT = true;
                                                        Payment.PURCHASE_ISNOTCHANGE = false;
                                                        Payment.STT_AUTOID = 27;
                                                        if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                                            Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString() + " - Tin nhắn thiếu thông tin.");
                                                        else
                                                            Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString() + " - Tin nhắn thiếu thông tin.");
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    #endregion

                    #region Confirm Purchase Order
                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                    List<PURCHASING> lstPurchasing4 = DataOut.CRM_PURCHASING_GetAllPURCHASINGListIsConfirmedTranfer();
                    Logger.Log("Get Purchasing list from Database to auto confirm transfer money:______________________________________________" + lstPurchasing4.Count);
                    if (lstPurchasing4.Count > 0)
                    {
                        foreach (PURCHASING Payment in lstPurchasing4)
                        {
                            Logger.Log("PURCHASING AUTOID : " + Payment.PURCHASE_AUTOID);
                            DateTime PayDate = DateTime.Now;
                            Int64? PurchasingID = Payment.PURCHASE_AUTOID;
                            string PurchasingCode = Payment.PURCHASE_CODE;
                            string AgentID = clsFormat.StringConvert(Payment.AGENTID);
                            List<BANKSMS> lstBankSms = DataOut.CRM_BANKSMS_GetAllBANKSMSAmountInListIsActive();
                            if (lstBankSms.Count > 0)
                            {
                                foreach (BANKSMS banksms in lstBankSms)
                                {
                                    if (banksms.BANKSMS_AMOUNTIN == Payment.PURCHASE_AMOUNT 
                                        && banksms.AGENT_ID == Payment.AGENTID
                                        && banksms.BANKSMS_RECEIVEDATE >= Payment.PURCHASE_CREATEDATE 
                                        && banksms.BANKACC_AUTOID == Payment.BANKACC_AUTOID
                                        && banksms.BANKSMS_PAYMENTCODE == Payment.PURCHASE_CODE)
                                    {
                                        //Payment.PURCHASE_ISACTIVE = true;
                                        //Payment.PURCHASE_ISDEFAULT = true;
                                        //Payment.PURCHASE_ISNOTCHANGE = false;
                                        //Payment.STT_AUTOID = 19;
                                        //if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                        //    Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString() + " - Đại lý đã chuyển tiền.");
                                        //else
                                        //    Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString() + " - Đại lý đã chuyển tiền.");
                                        List<BANKACCOUNT> lstBankAcc = DataOut.CRM_GetAllBANKACCOUNTListIsActive();
                                        if (lstBankAcc.Count > 0)
                                        {
                                            foreach (BANKACCOUNT bankacc in lstBankAcc)
                                            {
                                                if (banksms.BANKSMS_ACCOUNTRECEIVE == bankacc.BANKACC_NUMBER)
                                                {
                                                    banksms.BANKSMS_ISACTIVE = true;
                                                    banksms.BANKSMS_PAYMENTCODE = Payment.PURCHASE_CODE;
                                                    banksms.STT_AUTOID = Payment.STT_AUTOID;
                                                    banksms.TYPE_AUTOID = Payment.TYPE_AUTOID;
                                                    Payment.BANKSMS_AUTOID = banksms.BANKSMS_AUTOID;
                                                    Payment.PURCHASE_ISACTIVE = true;
                                                    Payment.PURCHASE_ISDEFAULT = true;
                                                    Payment.PURCHASE_ISNOTCHANGE = false;
                                                    Payment.STT_AUTOID = 19;
                                                    if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                                        Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString() + " - Đã xác nhận.");
                                                    else
                                                        Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString() + " - Đã xác nhận.");
                                                    if (DataIn.CRM_BANKSMS_InsertUpdate(banksms))
                                                        Logger.Log("Banksms update status successful : " + banksms.BANKSMS_AUTOID.ToString());
                                                    else
                                                        Logger.Log("Banksms update status successful : " + banksms.BANKSMS_AUTOID.ToString());
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    #endregion

                    #region Auto Transfer Money
                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                    List<PURCHASING> lstPurchasing2 = DataOut.CRM_GetAllPURCHASINGListIsConfirmed();
                    Logger.Log("Get Purchasing list from Database to transfer money:______________________________________________" + lstPurchasing2.Count);
                    if (lstPurchasing2.Count > 0)
                    {
                        foreach (PURCHASING Payment in lstPurchasing2)
                        {
                            Logger.Log("PURCHASING AUTOID : " + Payment.PURCHASE_AUTOID);
                            DateTime PayDate = DateTime.Now;
                            bool IsCorrectTransfer = false;
                            int Target_Agent = clsFormat.IntConvert(ConfigurationManager.AppSettings["Target_Agent"]);
                            string Aut_User = ConfigurationManager.AppSettings["Aut_User"].ToString();
                            string Aut_Pass = ConfigurationManager.AppSettings["Aut_Pass"].ToString();
                            string Aut_Terminal = ConfigurationManager.AppSettings["Aut_Terminal"].ToString();
                            Int64? PurchasingID = Payment.PURCHASE_AUTOID;
                            string PurchasingCode = Payment.PURCHASE_CODE;
                            string AgentID = clsFormat.StringConvert(Payment.AGENTID);
                            double Amount = clsFormat.DoubleConvert(Payment.PURCHASE_AMOUNT);
                            if (Payment.STT_AUTOID == 17 && Amount > 0)
                                IsCorrectTransfer = true;
                            Logger.Log("Purchasing Get Payment Status  : IsCorrectTransfer" + PurchasingCode + " result " + IsCorrectTransfer);
                            if (IsCorrectTransfer)
                            {
                                Logger.Log("Purchasing Get Payment Status  : " + PurchasingCode);
                                string strRequestPaymentStatus = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                                     .sendRequest(new GroupProviders(GroupProvidersActionType.getPaymentStatus, PurchasingCode)
                                     .ToXML());
                                var res = (GetPaymentStatusReponse)ReponseFactory.GetResponse(new GateResponse(strRequestPaymentStatus).responseData);
                                Logger.Log("Purchasing Get Payment Status Reponse : " + PurchasingCode + " result " + res.result.ToString());
                                Logger.Log("Purchasing Get Payment Status Reponse : " + PurchasingCode + " status " + res.status.ToString());
                                if (res.status != "2")
                                {
                                    Logger.Log("Thuc Hien Chuyen Tien Cho Dai Ly  : " + PurchasingCode);
                                    string strRequestTranferMoney = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                                                .sendRequest(new GroupProviders(GroupProvidersActionType.addOfflinePayment, PurchasingCode,
                                                 XmlProtocolLibrary.ServiceType.ChuyenTienChoDaiLy, AgentID, Amount)
                                                .ToXML());
                                    var responce = (AddOfflinePaymentReponse)ReponseFactory.GetResponse(new GateResponse(strRequestTranferMoney).responseData);
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " result " + responce.result.ToString());
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " status " + responce.status.ToString());
                                    if (responce.status == "1" || responce.status == "2")
                                    {
                                        Payment.PURCHASE_ISACTIVE = false;
                                        Payment.PURCHASE_ISDEFAULT = true;
                                        Payment.PURCHASE_ISNOTCHANGE = true;
                                        Payment.STT_AUTOID = 25;
                                        Payment.USER_AUTOID = 1;
                                        if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                        {
                                            Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString() + " - Đang xử lý chuyển tiền.");
                                        }
                                        else
                                        {
                                            Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString() + " - Đang xử lý chuyển tiền.");
                                        }
                                    }
                                    else
                                    {
                                        Logger.Log("Purchasing auto transfer funs failure : " + Payment.PURCHASE_AUTOID.ToString());
                                    }
                                }
                                else
                                {
                                    Logger.Log("Purchasing Invalid Value : " + Payment.PURCHASE_AUTOID.ToString());
                                    Payment.PURCHASE_ISACTIVE = false;
                                    Payment.PURCHASE_ISDEFAULT = true;
                                    Payment.PURCHASE_ISNOTCHANGE = true;
                                    Payment.STT_AUTOID = 18;
                                    Payment.USER_AUTOID = 1;
                                    if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                    {
                                        Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString() + " - Đã chuyển tiền cho đại lý.");
                                    }
                                    else
                                    {
                                        Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString() + " - Đã chuyển tiền cho đại lý.");
                                    }
                                }
                            }
                            else
                            {
                                Logger.Log("Purchasing Invalid Value : " + Payment.PURCHASE_AUTOID.ToString());
                            }
                        }
                    }
                    #endregion

                    #region Auto Confirmed Transfer Money
                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                    List<PURCHASING> lstPurchasing3 = DataOut.CRM_PURCHASING_GetAllPURCHASINGListInProcessing();
                    Logger.Log("Get Purchasing list from Database to confirm transfer money:______________________________________________" + lstPurchasing3.Count);
                    if (lstPurchasing3.Count > 0)
                    {
                        foreach (PURCHASING Payment in lstPurchasing3)
                        {
                            Logger.Log("PURCHASING AUTOID : " + Payment.PURCHASE_AUTOID);
                            DateTime PayDate = DateTime.Now;
                            bool IsCorrectTransfer = false;
                            int Target_Agent = clsFormat.IntConvert(ConfigurationManager.AppSettings["Target_Agent"]);
                            string Aut_User = ConfigurationManager.AppSettings["Aut_User"].ToString();
                            string Aut_Pass = ConfigurationManager.AppSettings["Aut_Pass"].ToString();
                            string Aut_Terminal = ConfigurationManager.AppSettings["Aut_Terminal"].ToString();
                            string messageBody = string.Empty;
                            Int64? PurchasingID = Payment.PURCHASE_AUTOID;
                            string PurchasingCode = Payment.PURCHASE_CODE;
                            string AgentID = clsFormat.StringConvert(Payment.AGENTID);
                            double Amount = clsFormat.DoubleConvert(Payment.PURCHASE_AMOUNT);
                            if (Payment.STT_AUTOID == 25 && Amount > 0)
                                IsCorrectTransfer = true;
                            if (IsCorrectTransfer)
                            {
                                string strRequestPaymentStatus = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                                     .sendRequest(new GroupProviders(GroupProvidersActionType.getPaymentStatus, PurchasingCode)
                                     .ToXML());
                                var res = (GetPaymentStatusReponse)ReponseFactory.GetResponse(new GateResponse(strRequestPaymentStatus).responseData);
                                Logger.Log("Purchasing Get Payment Result Reponse : " + PurchasingCode + " result " + res.result.ToString());
                                Logger.Log("Purchasing Get Payment Status Reponse : " + PurchasingCode + " status " + res.status.ToString());
                                if (res.status == "2")
                                {
                                    #region Status == 2
                                    string strRequestTranferMoney = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                                               .sendRequest(new GroupProviders(GroupProvidersActionType.addOfflinePayment, PurchasingCode, XmlProtocolLibrary.ServiceType.ChuyenTienChoDaiLy, AgentID, Amount)
                                               .ToXML());
                                    var responce = (AddOfflinePaymentReponse)ReponseFactory.GetResponse(new GateResponse(strRequestTranferMoney).responseData);
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " result " + responce.result.ToString());
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " status " + responce.status.ToString());
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " uid " + responce.uid.ToString());
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " actionResult " + responce.actionResult.ToString());
                                    if (responce.status == "2")
                                    {
                                        Payment.PURCHASE_ISACTIVE = false;
                                        Payment.PURCHASE_ISDEFAULT = false;
                                        Payment.PURCHASE_ISNOTCHANGE = true;
                                        Payment.STT_AUTOID = 18;
                                        Payment.USER_AUTOID = 1;
                                        Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                        if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                        {
                                            Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString() + " - Đã chuyển tiền cho đại lý.");
                                            messageBody = "SIMPAY da nap " + clsFormat.DecimalConvert(Payment.PURCHASE_AMOUNT).ToString("#,##0")
                                                    + " dong thanh cong cho dai ly : " + Payment.AGENTID + ". Ma don hang : " + PurchasingCode
                                                    + ". Ma giao dich tren Potal : " + responce.uid.ToString();
                                            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_System"].ConnectionString;
                                            List<Librarys.SYSTEM.CONFIGURATION.CONFIGURATIONSERVICE> lstService = DataOut.SYSTEM_GetAllCONFIGURATIONSERVICEListIsActiveById(13);
                                            if (lstService.Count > 0)
                                            {
                                                foreach (Librarys.SYSTEM.CONFIGURATION.CONFIGURATIONSERVICE service in lstService)
                                                {
                                                    string PhoneReceive = service.CONSER_DESCRIPTION;
                                                    string[] sep = { ";" };
                                                    string[] strResult = PhoneReceive.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                                                    if (strResult.Length > 0)
                                                    {
                                                        foreach (string subString in strResult)
                                                        {
                                                            if (subString != string.Empty && subString != null)
                                                            {
                                                                SendMail(messageBody, subString.Trim());
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                            List<Librarys.CRM.AGENT> lstAgent = DataOut.CRM_GetAllAGENTListById(clsFormat.Int64Convert(Payment.AGENTID));
                                            if (lstAgent.Count > 0)
                                            {
                                                foreach (Librarys.CRM.AGENT agent in lstAgent)
                                                {
                                                    if (agent.AGENT_TELEPHONE != string.Empty && agent.AGENT_TELEPHONE != null)
                                                    {
                                                        SMSMESSAGE objsmsmess = new SMSMESSAGE();
                                                        objsmsmess.BANKACC_AUTOID = Payment.BANKACC_AUTOID;
                                                        objsmsmess.PURCHASE_AUTOID = Payment.PURCHASE_AUTOID;
                                                        objsmsmess.RECEIVEDATE = DateTime.Now;
                                                        objsmsmess.SMSMESS_BANKACCOUNT = string.Empty;
                                                        objsmsmess.SMSMESS_BANKNAME = string.Empty;
                                                        objsmsmess.SMSMESS_CREATEDATE = DateTime.Now;
                                                        objsmsmess.SMSMESS_DESCRIPTION = "Tin nhan thanh toan don hang " + Payment.PURCHASE_CODE + " cua dai ly " + AgentID + " so tien " + Payment.PURCHASE_AMOUNTINWORDS;
                                                        objsmsmess.SMSMESS_DETAIL = messageBody;
                                                        objsmsmess.SMSMESS_ISACTIVE = true;
                                                        objsmsmess.SMSMESS_ISDEFAULT = true;
                                                        objsmsmess.SMSMESS_ISNOTCHANGE = true;
                                                        objsmsmess.SMSMESS_SIMNUMBER = agent.AGENT_TELEPHONE;
                                                        objsmsmess.SMSTYPEID = 4;
                                                        objsmsmess.STT_AUTOID = Payment.STT_AUTOID;
                                                        objsmsmess.TYPE_AUTOID = Payment.TYPE_AUTOID;
                                                        objsmsmess.USER_AUTOID = Payment.USER_AUTOID;
                                                        objsmsmess.AGENT_ID = Payment.AGENTID;
                                                        Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                                        if (DataIn.CRM_SMSMESSAGE_InsertUpdate(objsmsmess))
                                                        {
                                                            Logger.Log("Insert SMSMESSAGE Successful : " + Payment.PURCHASE_AUTOID.ToString());
                                                        }
                                                        else
                                                        {
                                                            Logger.Log("Insert SMSMESSAGE failure : " + Payment.PURCHASE_AUTOID.ToString());
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString());
                                        }
                                        TRANSFERHISTORY objTransHis = new TRANSFERHISTORY();
                                        objTransHis.TRANSHIS_AMOUNT = Payment.PURCHASE_AMOUNT;
                                        objTransHis.TRANSHIS_CREATEDATE = DateTime.Now;
                                        objTransHis.TRANSHIS_FROMAGENTID = Target_Agent.ToString();
                                        objTransHis.TRANSHIS_INNERXML = responce.actionResult.ToString();
                                        objTransHis.TRANSHIS_NOTE = strRequestTranferMoney;
                                        objTransHis.TRANSHIS_PAYMENTID = Payment.PURCHASE_AUTOID.ToString();
                                        objTransHis.TRANSHIS_RESPONSEDATA = responce.status.ToString();
                                        objTransHis.TRANSHIS_RESPONSEPAYMENTID = responce.uid.ToString();
                                        objTransHis.TRANSHIS_RESULT = responce.result;
                                        objTransHis.TRANSHIS_TOAGENTID = Payment.AGENTID.ToString();
                                        objTransHis.TYPE_AUTOID = Payment.TYPE_AUTOID;
                                        objTransHis.STT_AUTOID = Payment.STT_AUTOID;
                                        Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                        if (DataIn.CRM_TRANSFERHISTORY_InsertUpdate(objTransHis))
                                        {
                                            Logger.Log("Insert TRANSFERHISTORY Successful : " + objTransHis.TRANSHIS_AUTOID.ToString());
                                        }
                                        else
                                        {
                                            Logger.Log("Update Transfer Money Failure : " + Payment.PURCHASE_AUTOID.ToString());
                                        }
                                    }
                                    else
                                    {
                                        Logger.Log("Update Transfer Money Failure : " + Payment.PURCHASE_AUTOID.ToString());
                                    }
                                    #endregion
                                }
                                else
                                {
                                    #region Status <> 2
                                    string strRequestTranferMoney = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                                               .sendRequest(new GroupProviders(GroupProvidersActionType.addOfflinePayment, PurchasingCode, XmlProtocolLibrary.ServiceType.ChuyenTienChoDaiLy, AgentID, Amount)
                                               .ToXML());
                                    var responce = (AddOfflinePaymentReponse)ReponseFactory.GetResponse(new GateResponse(strRequestTranferMoney).responseData);
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " result " + responce.result.ToString());
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " status " + responce.status.ToString());
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " uid " + responce.uid.ToString());
                                    Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " actionResult " + responce.actionResult.ToString());
                                    if (responce.status == "2")
                                    {
                                        Payment.PURCHASE_ISACTIVE = false;
                                        Payment.PURCHASE_ISDEFAULT = false;
                                        Payment.PURCHASE_ISNOTCHANGE = true;
                                        Payment.STT_AUTOID = 18;
                                        Payment.USER_AUTOID = 1;
                                        Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                        if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                        {
                                            Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString() + " - Đã chuyển tiền cho đại lý.");
                                            messageBody = "SIMPAY da nap " + clsFormat.DecimalConvert(Payment.PURCHASE_AMOUNT).ToString("#,##0")
                                                    + " dong cho dai ly : " + Payment.AGENTID + " thanh cong. Ma don hang : " + PurchasingCode
                                                    + ". Ma giao dich tren Potal : " + responce.uid.ToString();
                                            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_System"].ConnectionString;
                                            List<Librarys.SYSTEM.CONFIGURATION.CONFIGURATIONSERVICE> lstService = DataOut.SYSTEM_GetAllCONFIGURATIONSERVICEListIsActiveById(13);
                                            if (lstService.Count > 0)
                                            {
                                                foreach (Librarys.SYSTEM.CONFIGURATION.CONFIGURATIONSERVICE service in lstService)
                                                {
                                                    string PhoneReceive = service.CONSER_DESCRIPTION;
                                                    string[] sep = { ";" };
                                                    string[] strResult = PhoneReceive.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                                                    if (strResult.Length > 0)
                                                    {
                                                        foreach (string subString in strResult)
                                                        {
                                                            if (subString != string.Empty && subString != null)
                                                            {
                                                                SendMail(messageBody, subString.Trim());
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                            List<Librarys.CRM.AGENT> lstAgent = DataOut.CRM_GetAllAGENTListById(clsFormat.Int64Convert(Payment.AGENTID));
                                            if (lstAgent.Count > 0)
                                            {
                                                foreach (Librarys.CRM.AGENT agent in lstAgent)
                                                {
                                                    if (agent.AGENT_TELEPHONE != string.Empty && agent.AGENT_TELEPHONE != null)
                                                    {
                                                        SMSMESSAGE objsmsmess = new SMSMESSAGE();
                                                        objsmsmess.BANKACC_AUTOID = Payment.BANKACC_AUTOID;
                                                        objsmsmess.PURCHASE_AUTOID = Payment.PURCHASE_AUTOID;
                                                        objsmsmess.RECEIVEDATE = DateTime.Now;
                                                        objsmsmess.SMSMESS_BANKACCOUNT = string.Empty;
                                                        objsmsmess.SMSMESS_BANKNAME = string.Empty;
                                                        objsmsmess.SMSMESS_CREATEDATE = DateTime.Now;
                                                        objsmsmess.SMSMESS_DESCRIPTION = "Tin nhan thanh toan don hang " + Payment.PURCHASE_CODE + " cua dai ly " + AgentID + " so tien " + Payment.PURCHASE_AMOUNTINWORDS;
                                                        objsmsmess.SMSMESS_DETAIL = messageBody;
                                                        objsmsmess.SMSMESS_ISACTIVE = true;
                                                        objsmsmess.SMSMESS_ISDEFAULT = true;
                                                        objsmsmess.SMSMESS_ISNOTCHANGE = true;
                                                        objsmsmess.SMSMESS_SIMNUMBER = agent.AGENT_TELEPHONE;
                                                        objsmsmess.SMSTYPEID = 4;
                                                        objsmsmess.STT_AUTOID = Payment.STT_AUTOID;
                                                        objsmsmess.TYPE_AUTOID = Payment.TYPE_AUTOID;
                                                        objsmsmess.USER_AUTOID = Payment.USER_AUTOID;
                                                        objsmsmess.AGENT_ID = Payment.AGENTID;
                                                        Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                                        if (DataIn.CRM_SMSMESSAGE_InsertUpdate(objsmsmess))
                                                        {
                                                            Logger.Log("Insert SMSMESSAGE Successful : " + Payment.PURCHASE_AUTOID.ToString());
                                                        }
                                                        else
                                                        {
                                                            Logger.Log("Insert SMSMESSAGE failure : " + Payment.PURCHASE_AUTOID.ToString());
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString());
                                        }
                                        TRANSFERHISTORY objTransHis = new TRANSFERHISTORY();
                                        objTransHis.TRANSHIS_AMOUNT = Payment.PURCHASE_AMOUNT;
                                        objTransHis.TRANSHIS_CREATEDATE = DateTime.Now;
                                        objTransHis.TRANSHIS_FROMAGENTID = Target_Agent.ToString();
                                        objTransHis.TRANSHIS_INNERXML = responce.actionResult.ToString();
                                        objTransHis.TRANSHIS_NOTE = strRequestTranferMoney;
                                        objTransHis.TRANSHIS_PAYMENTID = Payment.PURCHASE_AUTOID.ToString();
                                        objTransHis.TRANSHIS_RESPONSEDATA = responce.status.ToString();
                                        objTransHis.TRANSHIS_RESPONSEPAYMENTID = responce.uid.ToString();
                                        objTransHis.TRANSHIS_RESULT = responce.result;
                                        objTransHis.TRANSHIS_TOAGENTID = Payment.AGENTID.ToString();
                                        objTransHis.TYPE_AUTOID = Payment.TYPE_AUTOID;
                                        objTransHis.STT_AUTOID = Payment.STT_AUTOID;
                                        Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                        if (DataIn.CRM_TRANSFERHISTORY_InsertUpdate(objTransHis))
                                        {
                                            Logger.Log("Insert TRANSFERHISTORY Successful : " + objTransHis.TRANSHIS_AUTOID.ToString());
                                        }
                                        else
                                        {
                                            Logger.Log("Update Transfer Money Failure : " + Payment.PURCHASE_AUTOID.ToString());
                                        }
                                    }
                                    else
                                    {
                                        Logger.Log("Purchasing Transfer Money Failure : " + Payment.PURCHASE_AUTOID.ToString());
                                    }
                                }
                                    #endregion
                            }
                            else
                            {
                                Logger.Log("Purchasing Invalid Value : " + Payment.PURCHASE_AUTOID.ToString());
                            }
                        }
                    }
                    #endregion
                }
                else
                {
                    Logger.Log("_____Service Timer Stopping...");
                    if (PoolCounting > 0)
                    {
                        Logger.Log("Waiting for " + PoolCounting.ToString() + " processing...");
                    }
                    else
                    {
                        ACS_Timer.Stop();
                        Logger.Log("_____ACS Timer Stopped");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Service_Timer_Function_ERROR: " + ex.Message);
                Logger.Log("Service_Timer_Function_ERROR: " + ex.StackTrace);
                Logger.Log("Service_Timer_Function_ERROR: " + ex.InnerException);
            }
        }

        public void UpdateStatusPayment(object pvPay)
        {
            DateTime PayDate = DateTime.Now;
            Int64? PurchasingID = 0;
            string PurchasingCode = string.Empty;
            string AgentID = string.Empty;
            try
            {
                lock (lockPoolCounting)
                {
                    PoolCounting++;
                }
                PURCHASING Payment = pvPay as PURCHASING;
                if (pvPay == null)
                {
                    return;
                }
                else
                {
                    PurchasingID = Payment.PURCHASE_AUTOID;
                    PurchasingCode = Payment.PURCHASE_CODE;
                    AgentID = clsFormat.StringConvert(Payment.AGENTID);
                }
                try
                {
                    Payment.PURCHASE_ISACTIVE = true;
                    Payment.PURCHASE_ISDEFAULT = true;
                    Payment.PURCHASE_ISNOTCHANGE = false;
                    Payment.STT_AUTOID = 25;//Đang xử lý
                    if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                    {
                        Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString());
                    }
                    else
                    {
                        Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString());
                    }
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    Logger.Log("WindowsServiceCheckPayment : Error " + ex.Message + " error GetBalance");
                    Logger.Log("WindowsServiceCheckPayment : Error " + ex.StackTrace + " error GetBalance");
                    Logger.Log("WindowsServiceCheckPayment : Error " + ex.InnerException + " error GetBalance");
                }
                lock (lockPoolCounting)
                {
                    PoolCounting--;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("ERROR: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.Message);
                Logger.Log("ERROR: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.StackTrace);
                Logger.Log("ERROR: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.InnerException);
                PoolCounting--;
            }
        }

        public void AnalysisPayment(object pvPay)
        {
            DateTime PayDate = DateTime.Now;
            Int64? PurchasingID = 0;
            string PurchasingCode = string.Empty;
            string AgentID = string.Empty;
            try
            {
                lock (lockPoolCounting)
                {
                    PoolCounting++;
                }
                PURCHASING Payment = pvPay as PURCHASING;
                if (pvPay == null)
                {
                    return;
                }
                else
                {
                    PurchasingID = Payment.PURCHASE_AUTOID;
                    PurchasingCode = Payment.PURCHASE_CODE;
                    AgentID = clsFormat.StringConvert(Payment.AGENTID);
                }
                try
                {
                    List<BANKSMS> lstBankSms = DataOut.CRM_BANKSMS_GetAllBANKSMSAmountInListIsActive();
                    if (lstBankSms.Count > 0)
                    {
                        foreach (BANKSMS banksms in lstBankSms)
                        {
                            if (banksms.BANKSMS_AMOUNTIN == Payment.PURCHASE_AMOUNT && banksms.AGENT_ID == Payment.AGENTID && banksms.BANKACC_AUTOID == Payment.BANKACC_AUTOID)
                            {
                                List<BANKACCOUNT> lstBankAcc = DataOut.CRM_GetAllBANKACCOUNTListIsActive();
                                if (lstBankAcc.Count > 0)
                                {
                                    foreach (BANKACCOUNT bankacc in lstBankAcc)
                                    {
                                        if (banksms.BANKSMS_ACCOUNTRECEIVE == bankacc.BANKACC_NUMBER)
                                        {
                                            banksms.BANKSMS_ISACTIVE = true;
                                            Payment.BANKSMS_AUTOID = banksms.BANKSMS_AUTOID;
                                            Payment.PURCHASE_ISACTIVE = true;
                                            Payment.PURCHASE_ISDEFAULT = true;
                                            Payment.PURCHASE_ISNOTCHANGE = false;
                                            Payment.STT_AUTOID = 19;//Đại lý đã nộp tiền
                                            if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                            {
                                                Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString());
                                                if (DataIn.CRM_BANKSMS_InsertUpdate(banksms))
                                                    Logger.Log("Banksms update status successful : " + banksms.BANKSMS_AUTOID.ToString());
                                                else
                                                    Logger.Log("Banksms update status successful : " + banksms.BANKSMS_AUTOID.ToString());
                                            }
                                            else
                                            {
                                                Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString());
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Logger.Log("Purchasing Invalid Value : " + Payment.PURCHASE_AUTOID.ToString());
                    }
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    Logger.Log("AnalysisPayment : Error " + ex.Message + " error AnalysisPayment");
                    Logger.Log("AnalysisPayment : Error " + ex.StackTrace + " error AnalysisPayment");
                    Logger.Log("AnalysisPayment : Error " + ex.InnerException + " error AnalysisPayment");
                }
                lock (lockPoolCounting)
                {
                    PoolCounting--;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("ERROR AnalysisPayment: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.Message);
                Logger.Log("ERROR AnalysisPayment: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.StackTrace);
                Logger.Log("ERROR AnalysisPayment: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.InnerException);
                PoolCounting--;
            }
        }

        public void AutoTransferFuns(object pvPay)
        {
            DateTime PayDate = DateTime.Now;
            bool IsCorrectTransfer = false;
            Int64? PurchasingID = 0;
            string PurchasingCode = string.Empty;
            string AgentID = string.Empty;
            double Amount = 0;
            int Target_Agent = clsFormat.IntConvert(ConfigurationManager.AppSettings["Target_Agent"]);
            string Aut_User = ConfigurationManager.AppSettings["Aut_User"].ToString();
            string Aut_Pass = ConfigurationManager.AppSettings["Aut_Pass"].ToString();
            string Aut_Terminal = ConfigurationManager.AppSettings["Aut_Terminal"].ToString();
            try
            {
                lock (lockPoolCounting)
                {
                    PoolCounting++;
                }
                PURCHASING Payment = pvPay as PURCHASING;
                if (pvPay == null)
                {
                    return;
                }
                else
                {
                    PurchasingID = Payment.PURCHASE_AUTOID;
                    PurchasingCode = Payment.PURCHASE_CODE;
                    AgentID = clsFormat.StringConvert(Payment.AGENTID);
                    Amount = clsFormat.DoubleConvert(Payment.PURCHASE_AMOUNT);
                    if (Payment.STT_AUTOID == 17 && Amount > 0)
                        IsCorrectTransfer = true;
                    Logger.Log("Purchasing Get Payment Status  : IsCorrectTransfer" + PurchasingCode + " result " + IsCorrectTransfer);
                }
                try
                {
                    if (IsCorrectTransfer)
                    {
                        Logger.Log("Purchasing Get Payment Status  : " + PurchasingCode);
                        string strRequestPaymentStatus = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                             .sendRequest(new GroupProviders(GroupProvidersActionType.getPaymentStatus, PurchasingCode)
                             .ToXML());
                        var res = (GetPaymentStatusReponse)ReponseFactory.GetResponse(new GateResponse(strRequestPaymentStatus).responseData);
                        Logger.Log("Purchasing Get Payment Status Reponse : " + PurchasingCode + " result " + res.result.ToString());
                        Logger.Log("Purchasing Get Payment Status Reponse : " + PurchasingCode + " status " + res.status.ToString());
                        if (res.status != "2")
                        {
                            Logger.Log("Thuc Hien Chuyen Tien Cho Dai Ly  : " + PurchasingCode);
                            string strRequestTranferMoney = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                                        .sendRequest(new GroupProviders(GroupProvidersActionType.addOfflinePayment, PurchasingCode,
                                         XmlProtocolLibrary.ServiceType.ChuyenTienChoDaiLy, AgentID, Amount)
                                        .ToXML());
                            var responce = (AddOfflinePaymentReponse)ReponseFactory.GetResponse(new GateResponse(strRequestTranferMoney).responseData);
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " result " + responce.result.ToString());
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " status " + responce.status.ToString());
                            if (responce.status == "1" || responce.status == "2")
                            {
                                Payment.PURCHASE_ISACTIVE = false;
                                Payment.PURCHASE_ISDEFAULT = true;
                                Payment.PURCHASE_ISNOTCHANGE = true;
                                Payment.STT_AUTOID = 25;//Đang xử lý chuyển tiền cho đại lý
                                Payment.USER_AUTOID = 1;// Admin
                                if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                {
                                    Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString());
                                }
                                else
                                {
                                    Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString());
                                }
                            }
                            else
                            {
                                Logger.Log("Purchasing auto transfer funs failure : " + Payment.PURCHASE_AUTOID.ToString());
                            }
                        }
                        else
                        {
                            Logger.Log("Purchasing Invalid Value : " + Payment.PURCHASE_AUTOID.ToString());
                            Payment.PURCHASE_ISACTIVE = false;
                            Payment.PURCHASE_ISDEFAULT = true;
                            Payment.PURCHASE_ISNOTCHANGE = true;
                            Payment.STT_AUTOID = 18;//Da chuyen tien cho dai ly
                            Payment.USER_AUTOID = 1;//Admin
                            if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                            {
                                Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString());
                            }
                            else
                            {
                                Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString());
                            }
                        }
                    }
                    else
                    {
                        Logger.Log("Purchasing Invalid Value : " + Payment.PURCHASE_AUTOID.ToString());
                    }
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    Logger.Log("AutoTransferFuns : Error " + ex.Message + " error AutoTransferFuns");
                    Logger.Log("AutoTransferFuns : Error " + ex.StackTrace + " error AutoTransferFuns");
                    Logger.Log("AutoTransferFuns : Error " + ex.InnerException + " error AutoTransferFuns");
                }
                lock (lockPoolCounting)
                {
                    PoolCounting--;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("ERROR AutoTransferFuns: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.Message);
                Logger.Log("ERROR AutoTransferFuns: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.StackTrace);
                Logger.Log("ERROR AutoTransferFuns: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.InnerException);
                PoolCounting--;
            }
        }

        public void ConfirmTransferFuns(object pvPay)
        {
            DateTime PayDate = DateTime.Now;
            bool IsCorrectTransfer = false;
            Int64? PurchasingID = 0;
            string PurchasingCode = string.Empty;
            string AgentID = string.Empty;
            double Amount = 0;
            int Target_Agent = clsFormat.IntConvert(ConfigurationManager.AppSettings["Target_Agent"]);
            string Aut_User = ConfigurationManager.AppSettings["Aut_User"].ToString();
            string Aut_Pass = ConfigurationManager.AppSettings["Aut_Pass"].ToString();
            string Aut_Terminal = ConfigurationManager.AppSettings["Aut_Terminal"].ToString();
            string messageBody = string.Empty;
            try
            {
                lock (lockPoolCounting)
                {
                    PoolCounting++;
                }
                PURCHASING Payment = pvPay as PURCHASING;
                if (pvPay == null)
                {
                    return;
                }
                else
                {
                    PurchasingID = Payment.PURCHASE_AUTOID;
                    PurchasingCode = Payment.PURCHASE_CODE;
                    AgentID = clsFormat.StringConvert(Payment.AGENTID);
                    Amount = clsFormat.DoubleConvert(Payment.PURCHASE_AMOUNT);
                    if (Payment.STT_AUTOID == 25 && Amount > 0)
                        IsCorrectTransfer = true;
                }
                try
                {
                    if (IsCorrectTransfer)
                    {
                        string strRequestPaymentStatus = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                             .sendRequest(new GroupProviders(GroupProvidersActionType.getPaymentStatus, PurchasingCode)
                             .ToXML());
                        var res = (GetPaymentStatusReponse)ReponseFactory.GetResponse(new GateResponse(strRequestPaymentStatus).responseData);
                        Logger.Log("Purchasing Get Payment Status Reponse : " + PurchasingCode + " result " + res.result.ToString());
                        Logger.Log("Purchasing Get Payment Status Reponse : " + PurchasingCode + " status " + res.status.ToString());
                        if (res.status == "2")
                        {
                            #region Status == 2
                            string strRequestTranferMoney = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                                       .sendRequest(new GroupProviders(GroupProvidersActionType.addOfflinePayment, PurchasingCode, XmlProtocolLibrary.ServiceType.ChuyenTienChoDaiLy, AgentID, Amount)
                                       .ToXML());
                            var responce = (AddOfflinePaymentReponse)ReponseFactory.GetResponse(new GateResponse(strRequestTranferMoney).responseData);
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " result " + responce.result.ToString());
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " status " + responce.status.ToString());
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " uid " + responce.uid.ToString());
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " actionResult " + responce.actionResult.ToString());
                            if (responce.status == "2")
                            {
                                Payment.PURCHASE_ISACTIVE = false;
                                Payment.PURCHASE_ISDEFAULT = false;
                                Payment.PURCHASE_ISNOTCHANGE = true;
                                Payment.STT_AUTOID = 18;//Đa chuyen tien thanh cong cho dai ly
                                Payment.USER_AUTOID = 1;// Admin
                                Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                {
                                    Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString());

                                    messageBody = "SIMPAY da nap " + clsFormat.DecimalConvert(Payment.PURCHASE_AMOUNT).ToString("#,##0")
                                            + " dong cho dai ly : " + Payment.AGENTID + " thanh cong. Ma don hang : " + PurchasingCode
                                            + ". Ma giao dich tren Potal : " + responce.uid.ToString();
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_System"].ConnectionString;
                                    List<Librarys.SYSTEM.CONFIGURATION.CONFIGURATIONSERVICE> lstService = DataOut.SYSTEM_GetAllCONFIGURATIONSERVICEListIsActiveById(13);
                                    if (lstService.Count > 0)
                                    {
                                        foreach (Librarys.SYSTEM.CONFIGURATION.CONFIGURATIONSERVICE service in lstService)
                                        {
                                            string PhoneReceive = service.CONSER_DESCRIPTION;
                                            string[] sep = { ";" };
                                            string[] strResult = PhoneReceive.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                                            if (strResult.Length > 0)
                                            {
                                                foreach (string subString in strResult)
                                                {
                                                    if (subString != string.Empty && subString != null)
                                                    {
                                                        SendMail(messageBody, subString.Trim());
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                    List<Librarys.CRM.AGENT> lstAgent = DataOut.CRM_GetAllAGENTListById(clsFormat.Int64Convert(Payment.AGENTID));
                                    if (lstAgent.Count > 0)
                                    {
                                        foreach (Librarys.CRM.AGENT agent in lstAgent)
                                        {
                                            if (agent.AGENT_TELEPHONE != string.Empty && agent.AGENT_TELEPHONE != null)
                                            {
                                                SMSMESSAGE objsmsmess = new SMSMESSAGE();
                                                objsmsmess.BANKACC_AUTOID = Payment.BANKACC_AUTOID;
                                                objsmsmess.PURCHASE_AUTOID = Payment.PURCHASE_AUTOID;
                                                objsmsmess.RECEIVEDATE = DateTime.Now;
                                                objsmsmess.SMSMESS_BANKACCOUNT = string.Empty;
                                                objsmsmess.SMSMESS_BANKNAME = string.Empty;
                                                objsmsmess.SMSMESS_CREATEDATE = DateTime.Now;
                                                objsmsmess.SMSMESS_DESCRIPTION = "Tin nhan thanh toan don hang " + Payment.PURCHASE_CODE + " cua dai ly " + AgentID + " so tien " + Payment.PURCHASE_AMOUNTINWORDS;
                                                objsmsmess.SMSMESS_DETAIL = messageBody;
                                                objsmsmess.SMSMESS_ISACTIVE = true;
                                                objsmsmess.SMSMESS_ISDEFAULT = true;
                                                objsmsmess.SMSMESS_ISNOTCHANGE = true;
                                                objsmsmess.SMSMESS_SIMNUMBER = agent.AGENT_TELEPHONE;
                                                objsmsmess.SMSTYPEID = 4;
                                                objsmsmess.STT_AUTOID = Payment.STT_AUTOID;
                                                objsmsmess.TYPE_AUTOID = Payment.TYPE_AUTOID;
                                                objsmsmess.USER_AUTOID = Payment.USER_AUTOID;
                                                objsmsmess.AGENT_ID = Payment.AGENTID;
                                                Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                                if (DataIn.CRM_SMSMESSAGE_InsertUpdate(objsmsmess))
                                                {
                                                    Logger.Log("Insert SMSMESSAGE Successful : " + Payment.PURCHASE_AUTOID.ToString());
                                                }
                                                else
                                                {
                                                    Logger.Log("Insert SMSMESSAGE failure : " + Payment.PURCHASE_AUTOID.ToString());
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString());
                                }
                                TRANSFERHISTORY objTransHis = new TRANSFERHISTORY();
                                objTransHis.TRANSHIS_AMOUNT = Payment.PURCHASE_AMOUNT;
                                objTransHis.TRANSHIS_CREATEDATE = DateTime.Now;
                                objTransHis.TRANSHIS_FROMAGENTID = Target_Agent.ToString();
                                objTransHis.TRANSHIS_INNERXML = responce.actionResult.ToString();
                                objTransHis.TRANSHIS_NOTE = strRequestTranferMoney;
                                objTransHis.TRANSHIS_PAYMENTID = Payment.PURCHASE_AUTOID.ToString();
                                objTransHis.TRANSHIS_RESPONSEDATA = responce.status.ToString();
                                objTransHis.TRANSHIS_RESPONSEPAYMENTID = responce.uid.ToString();
                                objTransHis.TRANSHIS_RESULT = responce.result;
                                objTransHis.TRANSHIS_TOAGENTID = Payment.AGENTID.ToString();
                                objTransHis.TYPE_AUTOID = Payment.TYPE_AUTOID;
                                objTransHis.STT_AUTOID = Payment.STT_AUTOID;
                                Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                if (DataIn.CRM_TRANSFERHISTORY_InsertUpdate(objTransHis))
                                {
                                    Logger.Log("Insert TRANSFERHISTORY Successful : " + objTransHis.TRANSHIS_AUTOID.ToString());
                                }
                                else
                                {
                                    Logger.Log("Update Transfer Money Failure : " + Payment.PURCHASE_AUTOID.ToString());
                                }
                            }
                            else
                            {
                                Logger.Log("Update Transfer Money Failure : " + Payment.PURCHASE_AUTOID.ToString());
                            }
                            #endregion
                        }
                        else
                        {
                            #region Status <> 2
                            string strRequestTranferMoney = new ActionRequest(Aut_User, Aut_Pass, Aut_Terminal, true)
                                       .sendRequest(new GroupProviders(GroupProvidersActionType.addOfflinePayment, PurchasingCode, XmlProtocolLibrary.ServiceType.ChuyenTienChoDaiLy, AgentID, Amount)
                                       .ToXML());
                            var responce = (AddOfflinePaymentReponse)ReponseFactory.GetResponse(new GateResponse(strRequestTranferMoney).responseData);
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " result " + responce.result.ToString());
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " status " + responce.status.ToString());
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " uid " + responce.uid.ToString());
                            Logger.Log("Purchasing Get Payment TranferFuns Reponse : " + PurchasingCode + " actionResult " + responce.actionResult.ToString());
                            if (responce.status == "2")
                            {
                                Payment.PURCHASE_ISACTIVE = false;
                                Payment.PURCHASE_ISDEFAULT = false;
                                Payment.PURCHASE_ISNOTCHANGE = true;
                                Payment.STT_AUTOID = 18;//Đa chuyen tien thanh cong cho dai ly
                                Payment.USER_AUTOID = 1;// Admin
                                Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                if (DataIn.CRM_PURCHASING_InsertUpdate(Payment))
                                {
                                    Logger.Log("Purchasing update status successful : " + Payment.PURCHASE_AUTOID.ToString());
                                    messageBody = "SIMPAY da nap " + clsFormat.DecimalConvert(Payment.PURCHASE_AMOUNT).ToString("#,##0")
                                            + " dong cho dai ly : " + Payment.AGENTID + " thanh cong. Ma don hang : " + PurchasingCode
                                            + ". Ma giao dich tren Potal : " + responce.uid.ToString();
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_System"].ConnectionString;
                                    List<Librarys.SYSTEM.CONFIGURATION.CONFIGURATIONSERVICE> lstService = DataOut.SYSTEM_GetAllCONFIGURATIONSERVICEListIsActiveById(13);
                                    if (lstService.Count > 0)
                                    {
                                        foreach (Librarys.SYSTEM.CONFIGURATION.CONFIGURATIONSERVICE service in lstService)
                                        {
                                            string PhoneReceive = service.CONSER_DESCRIPTION;
                                            string[] sep = { ";" };
                                            string[] strResult = PhoneReceive.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                                            if (strResult.Length > 0)
                                            {
                                                foreach (string subString in strResult)
                                                {
                                                    if (subString != string.Empty && subString != null)
                                                    {
                                                        SendMail(messageBody, subString.Trim());
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                    List<Librarys.CRM.AGENT> lstAgent = DataOut.CRM_GetAllAGENTListById(clsFormat.Int64Convert(Payment.AGENTID));
                                    if (lstAgent.Count > 0)
                                    {
                                        foreach (Librarys.CRM.AGENT agent in lstAgent)
                                        {
                                            if (agent.AGENT_TELEPHONE != string.Empty && agent.AGENT_TELEPHONE != null)
                                            {
                                                SMSMESSAGE objsmsmess = new SMSMESSAGE();
                                                objsmsmess.BANKACC_AUTOID = Payment.BANKACC_AUTOID;
                                                objsmsmess.PURCHASE_AUTOID = Payment.PURCHASE_AUTOID;
                                                objsmsmess.RECEIVEDATE = DateTime.Now;
                                                objsmsmess.SMSMESS_BANKACCOUNT = string.Empty;
                                                objsmsmess.SMSMESS_BANKNAME = string.Empty;
                                                objsmsmess.SMSMESS_CREATEDATE = DateTime.Now;
                                                objsmsmess.SMSMESS_DESCRIPTION = "Tin nhan thanh toan don hang " + Payment.PURCHASE_CODE + " cua dai ly " + AgentID + " so tien " + Payment.PURCHASE_AMOUNTINWORDS;
                                                objsmsmess.SMSMESS_DETAIL = messageBody;
                                                objsmsmess.SMSMESS_ISACTIVE = true;
                                                objsmsmess.SMSMESS_ISDEFAULT = true;
                                                objsmsmess.SMSMESS_ISNOTCHANGE = true;
                                                objsmsmess.SMSMESS_SIMNUMBER = agent.AGENT_TELEPHONE;
                                                objsmsmess.SMSTYPEID = 4;
                                                objsmsmess.STT_AUTOID = Payment.STT_AUTOID;
                                                objsmsmess.TYPE_AUTOID = Payment.TYPE_AUTOID;
                                                objsmsmess.USER_AUTOID = Payment.USER_AUTOID;
                                                objsmsmess.AGENT_ID = Payment.AGENTID;
                                                Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                                if (DataIn.CRM_SMSMESSAGE_InsertUpdate(objsmsmess))
                                                {
                                                    Logger.Log("Insert SMSMESSAGE Successful : " + Payment.PURCHASE_AUTOID.ToString());
                                                }
                                                else
                                                {
                                                    Logger.Log("Insert SMSMESSAGE failure : " + Payment.PURCHASE_AUTOID.ToString());
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Logger.Log("Purchasing update status failure : " + Payment.PURCHASE_AUTOID.ToString());
                                }
                                TRANSFERHISTORY objTransHis = new TRANSFERHISTORY();
                                objTransHis.TRANSHIS_AMOUNT = Payment.PURCHASE_AMOUNT;
                                objTransHis.TRANSHIS_CREATEDATE = DateTime.Now;
                                objTransHis.TRANSHIS_FROMAGENTID = Target_Agent.ToString();
                                objTransHis.TRANSHIS_INNERXML = responce.actionResult.ToString();
                                objTransHis.TRANSHIS_NOTE = strRequestTranferMoney;
                                objTransHis.TRANSHIS_PAYMENTID = Payment.PURCHASE_AUTOID.ToString();
                                objTransHis.TRANSHIS_RESPONSEDATA = responce.status.ToString();
                                objTransHis.TRANSHIS_RESPONSEPAYMENTID = responce.uid.ToString();
                                objTransHis.TRANSHIS_RESULT = responce.result;
                                objTransHis.TRANSHIS_TOAGENTID = Payment.AGENTID.ToString();
                                objTransHis.TYPE_AUTOID = Payment.TYPE_AUTOID;
                                objTransHis.STT_AUTOID = Payment.STT_AUTOID;
                                Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
                                if (DataIn.CRM_TRANSFERHISTORY_InsertUpdate(objTransHis))
                                {
                                    Logger.Log("Insert TRANSFERHISTORY Successful : " + objTransHis.TRANSHIS_AUTOID.ToString());
                                }
                                else
                                {
                                    Logger.Log("Update Transfer Money Failure : " + Payment.PURCHASE_AUTOID.ToString());
                                }
                            }
                            else
                            {
                                Logger.Log("Purchasing Transfer Money Failure : " + Payment.PURCHASE_AUTOID.ToString());
                            }
                        }
                            #endregion
                    }
                    else
                    {
                        Logger.Log("Purchasing Invalid Value : " + Payment.PURCHASE_AUTOID.ToString());
                    }
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    Logger.Log("ConfirmTransferFuns : Error " + ex.Message + " error ConfirmTransferFuns");
                    Logger.Log("ConfirmTransferFuns : Error " + ex.StackTrace + " error ConfirmTransferFuns");
                    Logger.Log("ConfirmTransferFuns : Error " + ex.InnerException + " error ConfirmTransferFuns");
                }
                lock (lockPoolCounting)
                {
                    PoolCounting--;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("ERROR ConfirmTransferFuns: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.Message);
                Logger.Log("ERROR ConfirmTransferFuns: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.StackTrace);
                Logger.Log("ERROR ConfirmTransferFuns: " + clsFormat.StringConvert(PurchasingID) + " - " + ex.InnerException);
                PoolCounting--;
            }
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.\
            this.ServiceStop();
        }

        private void ServiceStop()
        {
            Logger.Log("_____Service Timer stopped: ______________________________________________");
            IsStop = true;
        }

        public new void Dispose()
        {
            // Thực hiện công việc dọn dẹp
            // Yêu cầu bộ thu dọc GC trong thực hiện kết thúc
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        protected override void Finalize()
        {
            Dispose();
        }

        public void InsertSms(object pvPay)
        {
            string BankBranch = string.Empty;
            string BankPhone = string.Empty;
            try
            {
                lock (lockPoolCounting)
                {
                    PoolCounting++;
                }
                BANKBRANCH bank = pvPay as BANKBRANCH;
                if (pvPay == null)
                {
                    return;
                }
                else
                {
                    Logger.Log("Insert New SMS : " + bank.BANKBRA_AUTOID.ToString());
                    BankBranch = bank.BANKBRA_NAME;
                    BankPhone = bank.BANKBRA_PHONE;
                    ArrayList arryList = ObjSearch();
                    arryList.Add(bank.BANKBRA_PHONE);
                    //List<SMS> lstSms = DataOut.VIETTELSLAVE_GetAllSMSListBySomeCriteria(arryList.ToArray());
                    //Logger.Log("Load sms from database viettel_slave: " + lstSms.Count.ToString());
                    //if (lstSms.Count > 0)
                    //{
                    //    foreach (SMS sms in lstSms)
                    //    {
                    //        Logger.Log("SMS SimNumberFrom : " + sms.SimNumberFrom.ToString());
                    //        if (sms.SimNumberFrom.Contains(BankBranch) || sms.SimNumberFrom.Contains(BankPhone))
                    //        {
                    //            try
                    //            {
                    //                SMSMESSAGE obj = new SMSMESSAGE();
                    //                obj.PURCHASE_AUTOID = null;
                    //                obj.SMSMESS_AUTOID = null;
                    //                obj.SMSMESS_CREATEDATE = DateTime.Now;
                    //                obj.SMSMESS_DESCRIPTION = sms.Content;
                    //                obj.SMSMESS_DETAIL = sms.Content;
                    //                obj.SMSMESS_ISACTIVE = true;
                    //                obj.SMSMESS_ISDEFAULT = false;
                    //                obj.SMSMESS_ISNOTCHANGE = false;
                    //                obj.STT_AUTOID = 1;
                    //                obj.TYPE_AUTOID = 1;
                    //                obj.USER_AUTOID = 1;
                    //                obj.SMS_AUTOID = clsFormat.Int64ConvertNull(sms.ID);
                    //                obj.SIMNUMBERFROM = sms.SimNumberFrom;
                    //                obj.SIMNUMBERTO = sms.PhoneNumber;
                    //                obj.RECEIVEDATE = sms.ReceiveDate;
                    //                obj.SMSTYPEID = sms.SMSTypeID;
                    //                if (DataIn.CRM_SMSMESSAGE_InsertUpdate(obj))
                    //                {
                    //                    Logger.Log("Get SMS Successful : " + sms.ID.ToString());
                    //                }
                    //                else
                    //                {
                    //                    Logger.Log("Get SMS Failure : " + sms.ID.ToString());
                    //                }
                    //            }
                    //            catch (Exception ex)
                    //            {
                    //                Logger.Log("InsertSms : Error " + ex.Message + " error InsertSms");
                    //                Logger.Log("InsertSms : Error " + ex.StackTrace + " error InsertSms");
                    //                Logger.Log("InsertSms : Error " + ex.InnerException + " error InsertSms");
                    //            }
                    //        }
                    //    }
                    //}
                    Thread.Sleep(100);
                }
                lock (lockPoolCounting)
                {
                    PoolCounting--;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("InsertSms ERROR: " + ex.Message);
                Logger.Log("InsertSms ERROR: " + ex.StackTrace);
                Logger.Log("InsertSms ERROR: " + ex.InnerException);
                PoolCounting--;
            }
        }

        public void TransferMoney(object pvPay)
        {
            try
            {
                lock (lockPoolCounting)
                {
                    PoolCounting++;
                }
                PURCHASING Purchase = pvPay as PURCHASING;
                if (pvPay == null)
                {
                    return;
                }
                else
                {
                    string PurchaseCode = string.Empty;
                    long AgentID = 0;
                    int Target_Agent = 4662958;
                    string PaymentID = string.Empty;
                    decimal Amount = 0;
                    TRANSFERHISTORY objTransHis = new TRANSFERHISTORY();
                    Logger.Log("TransferMoney New Purchase : " + Purchase.PURCHASE_AUTOID.ToString());
                    PurchaseCode = Purchase.PURCHASE_CODE;
                    AgentID = clsFormat.Int64Convert(Purchase.AGENTID);
                    PaymentID = Purchase.PURCHASE_CODE;
                    Amount = clsFormat.DecimalConvert(Purchase.PURCHASE_AMOUNT);
                    DataTable dtAgent = DataOut.CRM_GetAllAGENTDataById(AgentID);
                    if (Amount <= 0 && AgentID <= 0 && PaymentID == string.Empty && PurchaseCode == string.Empty)
                    {
                        Logger.Log("Transfer Money : Invalid Amount" + Amount.ToString());
                        Logger.Log("Transfer Money : Invalid PurchaseCode" + PurchaseCode.ToString());
                        Logger.Log("Transfer Money : Invalid AgentID" + AgentID.ToString());
                        Logger.Log("Transfer Money : Invalid PaymentID" + PaymentID.ToString());
                    }
                    else
                    {
                        //XmlDocument xmlMainResponse = new XmlDocument();
                        //XMLGate.Authorization newAuthorization = new XMLGate.Authorization(Helpers.Authorization.terminalIDAgent, Helpers.Authorization.userIDAgent, Helpers.Authorization.passwordAgent, Helpers.Authorization.url);
                        //XMLGate.GateResponse response = XMLGate.TransferCommission(Target_Agent, PaymentID, newAuthorization, AgentID, Amount);
                        //XMLGate.GateResponse responsePaymentStatus = XMLGate.GetPaymentStatus(newAuthorization, PaymentID.ToString());
                        //xmlMainResponse.LoadXml(response.ResponseData);
                        //Logger.Log("ResponseResult : " + response.Result);
                        //Logger.Log("ResponseData : " + response.ResponseData);
                        //if (response.Result == "0")
                        if (Amount > 0)
                        {
                            Purchase.PURCHASE_ISACTIVE = false;
                            Purchase.PURCHASE_ISDEFAULT = true;
                            Purchase.PURCHASE_ISNOTCHANGE = true;
                            Purchase.STT_AUTOID = 18;
                            objTransHis.STT_AUTOID = Purchase.STT_AUTOID;
                            objTransHis.TRANSHIS_AMOUNT = Purchase.PURCHASE_AMOUNT;
                            objTransHis.TRANSHIS_CREATEDATE = DateTime.Now;
                            objTransHis.TRANSHIS_FROMAGENTID = Target_Agent.ToString();
                            objTransHis.TRANSHIS_INNERXML = string.Empty;
                            objTransHis.TRANSHIS_NOTE = string.Empty;
                            objTransHis.TRANSHIS_PAYMENTID = Purchase.PURCHASE_AUTOID.ToString();
                            objTransHis.TRANSHIS_RESPONSEDATA = string.Empty;
                            objTransHis.TRANSHIS_RESPONSEPAYMENTID = string.Empty;
                            objTransHis.TRANSHIS_RESULT = string.Empty;
                            objTransHis.TRANSHIS_TOAGENTID = Purchase.AGENTID.ToString();
                            objTransHis.TYPE_AUTOID = Purchase.TYPE_AUTOID;
                            objTransHis.STT_AUTOID = Purchase.STT_AUTOID;

                            List<BANKSMS> lstBankSms = DataOut.CRM_GetAllBANKSMSListIsActiveById(clsFormat.Int64Convert(Purchase.BANKSMS_AUTOID));
                            if (lstBankSms.Count > 0)
                            {
                                foreach (BANKSMS banksms in lstBankSms)
                                {
                                    banksms.STT_AUTOID = Purchase.STT_AUTOID;
                                    banksms.BANKSMS_ISACTIVE = Purchase.PURCHASE_ISACTIVE;
                                    banksms.BANKSMS_ISDEFAULT = Purchase.PURCHASE_ISDEFAULT;
                                    banksms.BANKSMS_ISNOTCHANGE = Purchase.PURCHASE_ISNOTCHANGE;
                                    DataIn.CRM_BANKSMS_InsertUpdate(banksms);
                                }
                            }

                            Logger.Log("TRANSFERHISTORY : " + objTransHis.TRANSHIS_AUTOID.ToString());
                            if (DataIn.CRM_TRANSFERHISTORY_InsertUpdate(objTransHis))
                            {
                                Logger.Log("Insert TRANSFERHISTORY Successful : " + objTransHis.TRANSHIS_AUTOID.ToString());
                                if (DataIn.CRM_PURCHASING_InsertUpdate(Purchase))
                                {
                                    Logger.Log("Update Transfer Money Successful : " + Purchase.PURCHASE_AUTOID.ToString());
                                    //SMS objSMS = new SMS();
                                    //objSMS.IndexSMS = 1;
                                    //objSMS.PhoneNumber = dtAgent.Rows[0]["AGENT_TELEPHONE"].ToString();
                                    //objSMS.ReceiveDate = DateTime.Now;
                                    //objSMS.SimNumberFrom = "0963780354";
                                    //objSMS.SMSTypeID = 5;
                                    //objSMS.Status = "REC UNREAD";
                                    //objSMS.TransactionID = 0;
                                    //objSMS.CreateDate = DateTime.Now;
                                    //objSMS.Content = "Nap tien topup cho [" + dtAgent.Rows[0]["AGENT_NAME"].ToString() + "] tài khoản [" + dtAgent.Rows[0]["AGENT_ID"].ToString() + "]"
                                    //    + "] mã đơn hàng [" + PurchaseCode + "]" + "] số tiền [" + Amount.ToString("#,##0") + "]";
                                    //if (DataIn.VIETTELSLAVE_SMS_InsertUpdate(objSMS))
                                    //{
                                    //    Logger.Log("Sent SMS Info Transfer Money Successful : " + Purchase.PURCHASE_AUTOID.ToString());
                                    //}
                                    //else
                                    //{
                                    //    Logger.Log("Sent SMS Info Transfer Money Failure : " + Purchase.PURCHASE_AUTOID.ToString());
                                    //}
                                }
                                else
                                {
                                    Logger.Log("Update Transfer Money Failure : " + Purchase.PURCHASE_AUTOID.ToString());
                                }
                            }
                            else
                            {
                                Logger.Log("Insert TRANSFERHISTORY Failure : " + Purchase.PURCHASE_AUTOID.ToString());
                            }
                        }
                        else
                        {
                            Logger.Log("Transfer Money Failure : " + Purchase.PURCHASE_AUTOID.ToString());
                        }
                    }
                }
                Thread.Sleep(100);
                lock (lockPoolCounting)
                {
                    PoolCounting--;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("TransferMoney ERROR: " + ex.Message);
                Logger.Log("TransferMoney ERROR: " + ex.StackTrace);
                Logger.Log("TransferMoney ERROR: " + ex.InnerException);
                PoolCounting--;
            }
        }

        public void AnalysisMessage(object pvPay)
        {
            try
            {
                lock (lockPoolCounting)
                {
                    PoolCounting++;
                }
                SMSMESSAGE sms = pvPay as SMSMESSAGE;
                if (pvPay == null)
                {
                    return;
                }
                else
                {
                    long AgentID = 0;

                    #region SMS with Purchase Order
                    Logger.Log("AnalysisMessage New SMS : " + sms.SMSMESS_AUTOID.ToString());
                    List<PURCHASING> lstPurchase = DataOut.CRM_GetAllPURCHASINGListIsActiveByPayTypeId(1);
                    if (lstPurchase.Count > 0)
                    {
                        foreach (PURCHASING purchase in lstPurchase)
                        {
                            // sms.SMSMESS_DETAIL.Contains(purchase.AGENTID.ToString()) && sms.SMSMESS_DETAIL.Contains(purchase.PURCHASE_CODE.ToString()) && 
                            if ((sms.SMSMESS_DETAIL.Contains(purchase.PURCHASE_AMOUNT.ToString()) || sms.SMSMESS_DETAIL.Contains(clsFormat.DecimalConvert(purchase.PURCHASE_AMOUNT).ToString("#,##0")))
                               && purchase.TYPE_AUTOID == 51 && purchase.STT_AUTOID == 16)
                            {
                                Logger.Log("Update SMS : " + sms.PURCHASE_AUTOID.ToString());
                                try
                                {
                                    DataTable dtBankAcc = DataOut.CRM_GetAllBANKACCOUNTDataIsActiveById(clsFormat.Int64Convert(purchase.BANKACC_AUTOID));
                                    DataTable dtAgent = DataOut.CRM_GetAllAGENTDataById(clsFormat.Int64Convert(purchase.AGENTID));
                                    if (dtBankAcc.Rows.Count > 0 && dtAgent.Rows.Count > 0)
                                    {
                                        BANKSMS objBankSms = new BANKSMS();
                                        objBankSms.AGENT_ID = purchase.AGENTID;
                                        objBankSms.BANKACC_AUTOID = purchase.BANKACC_AUTOID;
                                        objBankSms.BANKSMS_ACCEPTDATE = sms.SMSMESS_CREATEDATE;
                                        objBankSms.BANKSMS_ACCOUNTRECEIVE = dtBankAcc.Rows[0]["BANKACC_NUMBER"].ToString();
                                        objBankSms.BANKSMS_ACCOUNTSENT = dtAgent.Rows[0]["AGENT_BANKACCOUNT"].ToString();
                                        //objBankSms.BANKSMS_AMOUNT = purchase.PURCHASE_AMOUNT;
                                        objBankSms.BANKSMS_BANKSENT = dtBankAcc.Rows[0]["BANK_NAME"].ToString();
                                        objBankSms.BANKSMS_ISACTIVE = true;
                                        objBankSms.BANKSMS_ISDEFAULT = false;
                                        objBankSms.BANKSMS_ISNOTCHANGE = false;
                                        objBankSms.BANKSMS_MESSAGE = sms.SMSMESS_DETAIL;
                                        objBankSms.STT_AUTOID = 17;
                                        objBankSms.TYPE_AUTOID = 51;
                                        objBankSms.USER_AUTOID = purchase.PURCHASE_AUTOID;
                                        if (DataIn.CRM_BANKSMS_InsertUpdate(objBankSms))
                                        {
                                            sms.SMSMESS_ISACTIVE = false;
                                            sms.SMSMESS_ISDEFAULT = true;
                                            sms.SMSMESS_ISNOTCHANGE = true;
                                            sms.PURCHASE_AUTOID = purchase.PURCHASE_AUTOID;
                                            if (DataIn.CRM_SMSMESSAGE_InsertUpdate(sms))
                                            {
                                                Logger.Log("Update SMS Successful : " + sms.PURCHASE_AUTOID.ToString());
                                            }
                                            else
                                            {
                                                Logger.Log("Update SMS Failure : " + sms.PURCHASE_AUTOID.ToString());
                                            }
                                            Logger.Log("Update purchase Successful : " + sms.PURCHASE_AUTOID.ToString());
                                        }
                                        else
                                        {
                                            Logger.Log("Update purchase Failure : " + sms.PURCHASE_AUTOID.ToString());
                                        }
                                    }
                                    else
                                    {
                                        Logger.Log("Update purchase Failure : " + sms.PURCHASE_AUTOID.ToString());
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Logger.Log("AnalysisMessage : Error " + ex.Message + " error AnalysisMessage");
                                    Logger.Log("AnalysisMessage : Error " + ex.StackTrace + " error AnalysisMessage");
                                    Logger.Log("AnalysisMessage : Error " + ex.InnerException + " error AnalysisMessage");
                                }
                            }
                        }
                    }
                    #endregion

                    #region SMS without Purchase Order
                    //bool IsNotPurchasingOrder = false;
                    //List<AGENT> lstAgent = DataOut.CRM_GetAllAGENTListIsActive();
                    //if (lstAgent.Count > 0)
                    //{
                    //    foreach (AGENT agent in lstAgent)
                    //    {
                    //        if (sms.SMSMESS_DETAIL.Contains(agent.AGENT_ID.ToString()) || sms.SMSMESS_DETAIL.Contains(agent.AGENT_BANKACCOUNT.ToString()))
                    //        {
                    //            IsNotPurchasingOrder = true;
                    //            AgentID = clsFormat.Int64Convert(agent.AGENT_ID);
                    //            break;
                    //        }
                    //        else
                    //        {
                    //            IsNotPurchasingOrder = false;
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    IsNotPurchasingOrder = false;
                    //}

                    //List<BANKBRANCH> lstBankBranch = DataOut.CRM_GetAllBANKBRANCHListIsActive();
                    //if (lstBankBranch.Count > 0)
                    //{
                    //    foreach (BANKBRANCH bankbra in lstBankBranch)
                    //    {
                    //        if (sms.SIMNUMBERFROM.Contains(bankbra.BANKBRA_NAME) || sms.SIMNUMBERFROM.Contains(bankbra.BANKBRA_PHONE))
                    //        {
                    //            IsNotPurchasingOrder = true;
                    //            break;
                    //        }
                    //        else
                    //        {
                    //            IsNotPurchasingOrder = false;
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    IsNotPurchasingOrder = false;
                    //}
                    //List<BANKACCOUNT> lstBankAcc = DataOut.CRM_GetAllBANKACCOUNTListIsActive();
                    //if (lstBankAcc.Count > 0)
                    //{
                    //    foreach (BANKACCOUNT BankAcc in lstBankAcc)
                    //    {
                    //        if (sms.SMSMESS_DETAIL.Contains(BankAcc.BANKACC_NUMBER) || sms.SMSMESS_DETAIL.Contains(BankAcc.BANKACC_NAME))
                    //        {
                    //            IsNotPurchasingOrder = true;
                    //            break;
                    //        }
                    //        else
                    //        {
                    //            IsNotPurchasingOrder = false;
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    IsNotPurchasingOrder = false;
                    //}
                    //if (IsNotPurchasingOrder)
                    //{
                    //    PURCHASING objPurchase = new PURCHASING();
                    //    objPurchase.PURCHASE_AMOUNT = 0;
                    //    objPurchase.PURCHASE_AMOUNTINWORDS = Utilities.Algorithms.CommonFunction.DocTienBangChu(clsFormat.Int64Convert(objPurchase.PURCHASE_AMOUNT), "đồng");
                    //    objPurchase.PAYTYPE_AUTOID = 1;
                    //    objPurchase.PURCHASE_CREATEDATE = DateTime.Now;
                    //    objPurchase.PURCHASE_ISACTIVE = true;
                    //    objPurchase.PURCHASE_ISDEFAULT = false;
                    //    objPurchase.PURCHASE_ISNOTCHANGE = false;
                    //    objPurchase.PURCHASE_NARRATIVE = sms.SMSMESS_DETAIL;
                    //    objPurchase.STT_AUTOID = 19;
                    //    objPurchase.TYPE_AUTOID = 51;
                    //    objPurchase.USER_AUTOID = 1;
                    //    objPurchase.AGENTID = AgentID;
                    //    DataTable dt = DataOut.CRM_GetAllPURCHASINGDataCodeByAgentId(clsFormat.Int64Convert(objPurchase.AGENTID.ToString()));
                    //    if (dt.Rows.Count == 0)
                    //        objPurchase.PURCHASE_CODE = objPurchase.AGENTID.ToString() + DateTime.Now.Year.ToString("00")
                    //            + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + "000";
                    //    else
                    //        objPurchase.PURCHASE_CODE = (clsFormat.Int64Convert(dt.Rows[dt.Rows.Count - 1][1].ToString()) + 1).ToString();
                    //    if (DataIn.CRM_PURCHASING_InsertUpdate(objPurchase))
                    //    {
                    //        Logger.Log("Update purchase Successful : " + sms.PURCHASE_AUTOID.ToString());
                    //    }
                    //    else
                    //    {
                    //        Logger.Log("Update purchase Failure : " + sms.PURCHASE_AUTOID.ToString());
                    //    }
                    //}
                    #endregion

                    Thread.Sleep(100);
                }
                lock (lockPoolCounting)
                {
                    PoolCounting--;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("AnalysisMessage ERROR: " + ex.Message);
                Logger.Log("AnalysisMessage ERROR: " + ex.StackTrace);
                Logger.Log("AnalysisMessage ERROR: " + ex.InnerException);
                PoolCounting--;
            }
        }

        protected ArrayList ObjSearch()
        {
            ArrayList arrList = new ArrayList();

            DateTime dateFrom = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy") + " 00:00:00", "dd/MM/yyyy HH:mm:ss", null);
            DateTime dateTo = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy") + " 23:59:59", "dd/MM/yyyy HH:mm:ss", null);

            arrList.Add(dateFrom.AddDays(-5));
            arrList.Add(dateTo);

            return arrList;
        }

        public static string getNeedString(string message, string beginString, string endString)
        {
            string strOut = message.Substring(message.IndexOf(beginString) + beginString.Length, (message.IndexOf(endString) - (message.IndexOf(beginString) + beginString.Length)));
            return strOut;
        }

        public bool isAddressAvailable(string address)
        {
            Ping ping = new Ping();
            try
            {
                return ping.Send(address, 100).Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }

        private bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }

        protected bool isValidEmail(string inputEmail)
        {
            bool Result = true;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                Result = true;
            else
            {
                Result = false;
            }
            return Result;
        }

        public void SendMail(string messageBody, string Address)
        {
            var fromAddress = new MailAddress("simpaynoreply@simpay.com.vn", "Simpay");

            const string fromPassword = "sp123456";
            const string subject = "Thông tin đơn hàng yêu cầu chuyển tiền.";

            var smtp = new SmtpClient
            {
                Host = "mail.simpay.com.vn",
                Port = 25,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

            };

            string[] receivers = { Address };
            foreach (var receiver in receivers)
            {
                var toAddress = new MailAddress(receiver, "Agent");
                var mailMessage = new MailMessage();
                mailMessage.From = fromAddress;
                mailMessage.To.Add(toAddress);
                mailMessage.Subject = subject;
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = messageBody;
                smtp.Send(mailMessage);
            }
        }

    }
}
