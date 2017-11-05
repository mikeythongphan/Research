using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace SimpayServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AutoTopup" in both code and config file together.
    public class AutoTopup : IAutoTopup
    {
        #region Data Out
        /// <summary>
        /// Get All data for table AGENT
        /// </summary>
        /// <returns>List<AGENT></returns>
        public List<Librarys.CRM.AGENT> CRM_AGENT_GetAllAGENTList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_AGENT_GetAllAGENTList();
        }
        /// <summary>
        /// Get All data for table AGENT
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_AGENT_GetAllAGENTData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_AGENT_GetAllAGENTData().DataSet;
        }
        /// <summary>
        /// Get All data for table AGENT
        /// </summary>
        /// <returns>List<AGENT></returns>
        public List<Librarys.CRM.AGENT> CRM_AGENT_GetAllAGENTListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_AGENT_GetAllAGENTListIsActive();
        }
        /// <summary>
        /// Get All data for table AGENT
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_AGENT_GetAllAGENTDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_AGENT_GetAllAGENTDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table AGENT
        /// </summary>
        /// <returns>List<AGENT></returns>
        public List<Librarys.CRM.AGENT> CRM_AGENT_GetAllAGENTListById(Int64 AGENTID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_AGENT_GetAllAGENTListById(AGENTID);
        }
        /// <summary>
        /// Get All data for table AGENT
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_AGENT_GetAllAGENTDataById(Int64 AGENTID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_AGENT_GetAllAGENTDataById(AGENTID).DataSet;
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <returns>List<PURCHASING></returns>
        public List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGList();
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_PURCHASING_GetAllPURCHASINGData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGData().DataSet;
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <returns>List<PURCHASING></returns>
        public List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGListIsActive();
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_PURCHASING_GetAllPURCHASINGDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <returns>List<PURCHASING></returns>
        public List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGListIsActiveById(Int64 PURCHASING_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGListIsActiveById(PURCHASING_AUTOID);
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_PURCHASING_GetAllPURCHASINGDataIsActiveById(Int64 PURCHASING_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGDataIsActiveById(PURCHASING_AUTOID).DataSet;
        }
        /// <summary>
        /// Search PURCHASING
        /// return one DataSet
        /// </summary>
        /// <rereturns>DataSet</rereturns>
        public DataSet CRM_PURCHASING_GetAllPURCHASINGSearchData(params object[] param)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGSearchData(param).DataSet;
        }
        /// <summary>
        /// Search PURCHASING
        /// return one DataSet
        /// </summary>
        /// <rereturns>DataSet</rereturns>
        public DataSet CRM_PURCHASING_GetAllPURCHASINGSearchDataPurchaseHistory(params object[] param)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGSearchDataPurchaseHistory(param).DataSet;
        }
        /// <summary>
        /// Get All data for table BANK
        /// </summary>
        /// <returns>List<BANK></returns>
        public List<Librarys.CRM.BANK> CRM_BANK_GetAllBANKList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANK_GetAllBANKList();
        }
        /// <summary>
        /// Get All data for table BANK
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANK_GetAllBANKData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANK_GetAllBANKData().DataSet;
        }
        /// <summary>
        /// Get All data for table BANK
        /// </summary>
        /// <returns>List<BANK></returns>
        public List<Librarys.CRM.BANK> CRM_BANK_GetAllBANKListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANK_GetAllBANKListIsActive();
        }
        /// <summary>
        /// Get All data for table BANK
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANK_GetAllBANKDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANK_GetAllBANKDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table BANK
        /// </summary>
        /// <returns>List<BANK></returns>
        public List<Librarys.CRM.BANK> CRM_BANK_GetAllBANKListIsActiveById(Int64 BANK_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANK_GetAllBANKListIsActiveById(BANK_AUTOID);
        }
        /// <summary>
        /// Get All data for table BANK
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANK_GetAllBANKDataIsActiveById(Int64 BANK_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANK_GetAllBANKDataIsActiveById(BANK_AUTOID).DataSet;
        }
        /// <summary>
        /// Get All data for table BANKACCOUNT
        /// </summary>
        /// <returns>List<BANK></returns>
        public List<Librarys.CRM.BANKACCOUNT> CRM_BANKACCOUNT_GetAllBANKACCOUNTList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKACCOUNT_GetAllBANKACCOUNTList();
        }
        /// <summary>
        /// Get All data for table BANKACCOUNT
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKACCOUNT_GetAllBANKACCOUNTData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKACCOUNT_GetAllBANKACCOUNTData().DataSet;
        }
        /// <summary>
        /// Get All data for table BANKACCOUNT
        /// </summary>
        /// <returns>List<BANKACCOUNT></returns>
        public List<Librarys.CRM.BANKACCOUNT> CRM_BANKACCOUNT_GetAllBANKACCOUNTListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKACCOUNT_GetAllBANKACCOUNTListIsActive();
        }
        /// <summary>
        /// Get All data for table BANKACCOUNT
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKACCOUNT_GetAllBANKACCOUNTDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKACCOUNT_GetAllBANKACCOUNTDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table BANKACCOUNT
        /// </summary>
        /// <returns>List<BANKACCOUNT></returns>
        public List<Librarys.CRM.BANKACCOUNT> CRM_BANKACCOUNT_GetAllBANKACCOUNTListIsActiveById(Int64 BANKACC_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKACCOUNT_GetAllBANKACCOUNTListIsActiveById(BANKACC_AUTOID);
        }
        /// <summary>
        /// Get All data for table BANKACCOUNT
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKACCOUNT_GetAllBANKACCOUNTDataIsActiveById(Int64 BANKACC_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKACCOUNT_GetAllBANKACCOUNTDataIsActiveById(BANKACC_AUTOID).DataSet;
        }
        /// <summary>
        /// Get All data for table BANKBRANCH
        /// </summary>
        /// <returns>List<BANKBRANCH></returns>
        public List<Librarys.CRM.BANKBRANCH> CRM_BANKBRANCH_GetAllBANKBRANCHList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKBRANCH_GetAllBANKBRANCHList();
        }
        /// <summary>
        /// Get All data for table BANKBRANCH
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKBRANCH_GetAllBANKBRANCHData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKBRANCH_GetAllBANKBRANCHData().DataSet;
        }
        /// <summary>
        /// Get All data for table BANKBRANCH
        /// </summary>
        /// <returns>List<BANKACCOUNT></returns>
        public List<Librarys.CRM.BANKBRANCH> CRM_BANKBRANCH_GetAllBANKBRANCHListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKBRANCH_GetAllBANKBRANCHListIsActive();
        }
        /// <summary>
        /// Get All data for table BANKBRANCH
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKBRANCH_GetAllBANKBRANCHDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKBRANCH_GetAllBANKBRANCHDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table BANKBRANCH
        /// </summary>
        /// <returns>List<BANKBRANCH></returns>
        public List<Librarys.CRM.BANKBRANCH> CRM_BANKBRANCH_GetAllBANKBRANCHListIsActiveById(Int64 BANKBRA_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKBRANCH_GetAllBANKBRANCHListIsActiveById(BANKBRA_AUTOID);
        }
        /// <summary>
        /// Get All data for table BANKBRANCH
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKBRANCH_GetAllBANKBRANCHDataIsActiveById(Int64 BANKBRA_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKBRANCH_GetAllBANKBRANCHDataIsActiveById(BANKBRA_AUTOID).DataSet;
        }
        /// <summary>
        /// Get All data for table BANKBRANCH
        /// </summary>
        /// <returns>List<PAYMENTTYPE></returns>
        public List<Librarys.CRM.PAYMENTTYPE> CRM_PAYMENTTYPE_GetAllPAYMENTTYPEList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PAYMENTTYPE_GetAllPAYMENTTYPEList();
        }
        /// <summary>
        /// Get All data for table PAYMENTTYPE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_PAYMENTTYPE_GetAllPAYMENTTYPEData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PAYMENTTYPE_GetAllPAYMENTTYPEData().DataSet;
        }
        /// <summary>
        /// Get All data for table PAYMENTTYPE
        /// </summary>
        /// <returns>List<PAYMENTTYPE></returns>
        public List<Librarys.CRM.PAYMENTTYPE> CRM_PAYMENTTYPE_GetAllPAYMENTTYPEListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PAYMENTTYPE_GetAllPAYMENTTYPEListIsActive();
        }
        /// <summary>
        /// Get All data for table PAYMENTTYPE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_PAYMENTTYPE_GetAllPAYMENTTYPEDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PAYMENTTYPE_GetAllPAYMENTTYPEDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table PAYMENTTYPE
        /// </summary>
        /// <returns>List<PAYMENTTYPE></returns>
        public List<Librarys.CRM.PAYMENTTYPE> CRM_PAYMENTTYPE_GetAllPAYMENTTYPEListIsActiveById(Int64 PAYTYPE_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PAYMENTTYPE_GetAllPAYMENTTYPEListIsActiveById(PAYTYPE_AUTOID);
        }
        /// <summary>
        /// Get All data for table PAYMENTTYPE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_PAYMENTTYPE_GetAllPAYMENTTYPEDataIsActiveById(Int64 PAYTYPE_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PAYMENTTYPE_GetAllPAYMENTTYPEDataIsActiveById(PAYTYPE_AUTOID).DataSet;
        }
        /// <summary>
        /// Get All data for table COMPANY
        /// </summary>
        /// <returns>List<COMPANY></returns>
        public List<Librarys.CRM.COMPANY> CRM_COMPANY_GetAllCOMPANYList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_COMPANY_GetAllCOMPANYList();
        }
        /// <summary>
        /// Get All data for table COMPANY
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_COMPANY_GetAllCOMPANYData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_COMPANY_GetAllCOMPANYData().DataSet;
        }
        /// <summary>
        /// Get All data for table COMPANY
        /// </summary>
        /// <returns>List<COMPANY></returns>
        public List<Librarys.CRM.COMPANY> CRM_COMPANY_GetAllCOMPANYListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_COMPANY_GetAllCOMPANYListIsActive();
        }
        /// <summary>
        /// Get All data for table COMPANY
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_COMPANY_GetAllCOMPANYDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_COMPANY_GetAllCOMPANYDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table COMPANY
        /// </summary>
        /// <returns>List<COMPANY></returns>
        public List<Librarys.CRM.COMPANY> CRM_COMPANY_GetAllCOMPANYListIsActiveById(Int64 COMP_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_COMPANY_GetAllCOMPANYListIsActiveById(COMP_AUTOID);
        }
        /// <summary>
        /// Get All data for table COMPANY
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_COMPANY_GetAllCOMPANYDataIsActiveById(Int64 COMP_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_COMPANY_GetAllCOMPANYDataIsActiveById(COMP_AUTOID).DataSet;
        }
        /// <summary>
        /// Get All data for table BANKSMS
        /// </summary>
        /// <returns>List<BANKSMS></returns>
        public List<Librarys.CRM.BANKSMS> CRM_BANKSMS_GetAllBANKSMSList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKSMS_GetAllBANKSMSList();
        }
        /// <summary>
        /// Get All data for table BANKSMS
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKSMS_GetAllBANKSMSData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKSMS_GetAllBANKSMSData().DataSet;
        }
        /// <summary>
        /// Get All data for table BANKSMS
        /// </summary>
        /// <returns>List<BANKSMS></returns>
        public List<Librarys.CRM.BANKSMS> CRM_BANKSMS_GetAllBANKSMSListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKSMS_GetAllBANKSMSListIsActive();
        }
        /// <summary>
        /// Get All data for table BANKSMS
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKSMS_GetAllBANKSMSDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKSMS_GetAllBANKSMSDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table BANKSMS
        /// </summary>
        /// <returns>List<BANKSMS></returns>
        public List<Librarys.CRM.BANKSMS> CRM_BANKSMS_GetAllBANKSMSListIsActiveById(Int64 BANKSMS_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKSMS_GetAllBANKSMSListIsActiveById(BANKSMS_AUTOID);
        }
        /// <summary>
        /// Get All data for table BANKSMS
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKSMS_GetAllBANKSMSDataIsActiveById(Int64 BANKSMS_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKSMS_GetAllBANKSMSDataIsActiveById(BANKSMS_AUTOID).DataSet;
        }
        /// <summary>
        /// Get All data for table SMSMESSAGE
        /// </summary>
        /// <returns>List<SMSMESSAGE></returns>
        public List<Librarys.CRM.SMSMESSAGE> CRM_SMSMESSAGE_GetAllSMSMESSAGEList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSMESSAGE_GetAllSMSMESSAGEList();
        }
        /// <summary>
        /// Get All data for table SMSMESSAGE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_SMSMESSAGE_GetAllSMSMESSAGEData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSMESSAGE_GetAllSMSMESSAGEData().DataSet;
        }
        /// <summary>
        /// Get All data for table SMSMESSAGE
        /// </summary>
        /// <returns>List<SMSMESSAGE></returns>
        public List<Librarys.CRM.SMSMESSAGE> CRM_SMSMESSAGE_GetAllSMSMESSAGEListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSMESSAGE_GetAllSMSMESSAGEListIsActive();
        }
        /// <summary>
        /// Get All data for table SMSMESSAGE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_SMSMESSAGE_GetAllSMSMESSAGEDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSMESSAGE_GetAllSMSMESSAGEDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table SMSMESSAGE
        /// </summary>
        /// <returns>List<SMSMESSAGE></returns>
        public List<Librarys.CRM.SMSMESSAGE> CRM_SMSMESSAGE_GetAllSMSMESSAGEListIsActiveById(Int64 SMSMESS_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSMESSAGE_GetAllSMSMESSAGEListIsActiveById(SMSMESS_AUTOID);
        }
        /// <summary>
        /// Get All data for table SMSMESSAGE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_SMSMESSAGE_GetAllSMSMESSAGEDataIsActiveById(Int64 SMSMESS_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSMESSAGE_GetAllSMSMESSAGEDataIsActiveById(SMSMESS_AUTOID).DataSet;
        }
        /// <summary>
        /// Get All data for table BANKACCOUNT
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_BANKACCOUNT_GetAllBANKACCOUNTDataIsActiveByBankId(Int64 BANK_AUTOID, Int64 COMP_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKACCOUNT_GetAllBANKACCOUNTDataIsActiveByBankId(BANK_AUTOID, COMP_AUTOID).DataSet;
        }
        /// <summary>
        /// Search TRANSFERHISTORY
        /// </summary>
        /// <param name="param">object</param>
        /// <rereturns>DataSet</rereturns>
        public DataSet CRM_TRANSFERHISTORY_GetAllTRANSFERHISTORYSearchData(params object[] param)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_TRANSFERHISTORY_GetAllTRANSFERHISTORYSearchData(param).DataSet;
        }
        /// <summary>
        /// Get All data for table SMSMESSAGE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_PURCHASING_GetAllPURCHASINGDataCodeByAgentId(Int64 AGENT_ID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGDataCodeByAgentId(AGENT_ID).DataSet;
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <returns>List<PURCHASING></returns>
        public List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGListIsConfirmed()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGListIsConfirmed();
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_PURCHASING_GetAllPURCHASINGDataIsConfirmed()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGDataIsConfirmed().DataSet;
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <returns>List<PURCHASING></returns>
        public List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGListIsActiveByPayTypeId(Int64 PAYTYPE_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGListIsActiveByPayTypeId(PAYTYPE_AUTOID);
        }
        /// <summary>
        /// Get All data for table PURCHASING
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_PURCHASING_GetAllPURCHASINGDataIsActiveByPayTypeId(Int64 PAYTYPE_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_PURCHASING_GetAllPURCHASINGDataIsActiveByPayTypeId(PAYTYPE_AUTOID).DataSet;
        }
        /// <summary>
        /// Search BANKSMS
        /// </summary>
        /// <rereturns>DataSet</rereturns>
        /// <param name="param">object</param>
        public DataSet CRM_BANKSMS_GetAllBANKSMSSearchData(params object[] param)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_BANKSMS_GetAllBANKSMSSearchData(param).DataSet;
        }
        /// <summary>
        /// Get All data for table CONFIGURATION
        /// </summary>
        /// <returns>List<CONFIGURATION></returns>
        public List<Librarys.CRM.CONFIGURATION> CRM_CONFIGURATION_GetAllCONFIGURATIONListIsActiveById(Int64 AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_CONFIGURATION_GetAllCONFIGURATIONListIsActiveById(AUTOID);
        }
        /// <summary>
        /// Get All data for table CONFIGURATION
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_CONFIGURATION_GetAllCONFIGURATIONDataIsActiveById(Int64 AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_CONFIGURATION_GetAllCONFIGURATIONDataIsActiveById(AUTOID).DataSet;
        }
        /// <summary>
        /// Get All data for table CONFIGURATION
        /// </summary>
        /// <returns>List<CONFIGURATION></returns>
        public List<Librarys.CRM.CONFIGURATION> CRM_CONFIGURATION_GetAllCONFIGURATIONListByTypeId(int TYPEID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_CONFIGURATION_GetAllCONFIGURATIONListByTypeId(TYPEID);
        }
        /// <summary>
        /// Get All data for table CONFIGURATION
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_CONFIGURATION_GetAllCONFIGURATIONDataByTypeId(int TYPEID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_CONFIGURATION_GetAllCONFIGURATIONDataByTypeId(TYPEID).DataSet;
        }
        /// <summary>
        /// Get All data for table SMS
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_SMS_GetAllSMSData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMS_GetAllSMSData().DataSet;
        }
        /// <summary>
        /// Get All data for table SMS
        /// </summary>
        /// <returns>List<SMS></returns>
        public List<Librarys.CRM.SMS> CRM_SMS_GetAllSMSList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMS_GetAllSMSList();
        }
        /// <summary>
        /// Get All data for table SMS
        /// </summary>
        /// <returns>List<SMS></returns>
        public List<Librarys.CRM.SMS> CRM_SMS_GetAllSMSListIsActiveById(int AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMS_GetAllSMSListIsActiveById(AUTOID);
        }
        /// <summary>
        /// Get All data for table SMS
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_SMS_GetAllSMSDataIsActiveById(int AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMS_GetAllSMSDataIsActiveById(AUTOID).DataSet;
        }
        /// <summary>
        /// Search SMS
        /// </summary>
        /// <rereturns>DataSet</rereturns>
        /// <param name="param">object</param>
        public DataSet CRM_SMS_SearchData(params object[] param)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMS_SearchData(param).DataSet;
        }
        /// <summary>
        /// Get All data for table SMSTYPE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_SMSTYPE_GetAllSMSTYPEData()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSTYPE_GetAllSMSTYPEData().DataSet;
        }
        /// <summary>
        /// Get All data for table SMSTYPE
        /// </summary>
        /// <returns>List<SMSTYPE></returns>
        public List<Librarys.CRM.SMSTYPE> CRM_SMSTYPE_GetAllSMSTYPEList()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSTYPE_GetAllSMSTYPEList();
        }
        /// <summary>
        /// Get All data for table SMSTYPE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_SMSTYPE_GetAllSMSTYPEDataIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSTYPE_GetAllSMSTYPEDataIsActive().DataSet;
        }
        /// <summary>
        /// Get All data for table SMSTYPE
        /// </summary>
        /// <returns>List<SMSTYPE></returns>
        public List<Librarys.CRM.SMSTYPE> CRM_SMSTYPE_GetAllSMSTYPEListIsActive()
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSTYPE_GetAllSMSTYPEListIsActive();
        }
        /// <summary>
        /// Get All data for table SMSTYPE
        /// </summary>
        /// <returns>List<SMSTYPE></returns>
        public List<Librarys.CRM.SMSTYPE> CRM_SMSTYPE_GetAllSMSTYPEListIsActiveById(int AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSTYPE_GetAllSMSTYPEListIsActiveById(AUTOID);
        }
        /// <summary>
        /// Get All data for table SMSTYPE
        /// </summary>
        /// <param name="param"></param>
        /// <returns>DataSet</returns>
        public DataSet CRM_SMSTYPE_GetAllSMSTYPEDataIsActiveById(int AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return ATMLibrary.ATMLibrary.CRM_SMSTYPE_GetAllSMSTYPEDataIsActiveById(AUTOID).DataSet;
        }
        #endregion

        #region Data In
        /// <summary>
        /// Insert data full for table PURCHASING
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of PURCHASING</param>
        /// <returns>bool</returns>
        public bool CRM_PURCHASING_InsertUpdate(Librarys.CRM.PURCHASING obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_PURCHASING_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table PURCHASING
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of PURCHASING</param>
        /// <returns>bool</returns>
        public Int64 CRM_PURCHASING_InsertPurchasing(Librarys.CRM.PURCHASING obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            Int64 i = ATMLibrary.ATMLibrary.CRM_PURCHASING_InsertPurchasing(obj);
            return i;
        }
        /// <summary>
        /// Delete data into table RULE by Id
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="PURCHASING_AUTOID">Int64</param>
        /// <returns>bool</returns>
        public bool CRM_PURCHASING_DeleteById(Int64 PURCHASING_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_PURCHASING_DeleteById(PURCHASING_AUTOID))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table AGENT
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of AGENT</param>
        /// <returns>bool</returns>
        public bool CRM_AGENT_InsertUpdate(Librarys.CRM.AGENT obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_AGENT_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Delete data into table AGENT by Id
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="AGENT_AUTOID">Int64</param>
        /// <returns>bool</returns>
        public bool CRM_AGENT_DeleteById(Int64 AGENT_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_AGENT_DeleteById(AGENT_AUTOID))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table BANKACCOUNT
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of BANKACCOUNT</param>
        /// <returns>bool</returns>
        public bool CRM_BANKACCOUNT_InsertUpdate(Librarys.CRM.BANKACCOUNT obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_BANKACCOUNT_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Delete data into table BANKACCOUNT by Id
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="BANKACCOUNT_AUTOID">Int64</param>
        /// <returns>bool</returns>
        public bool CRM_BANKACCOUNT_DeleteById(Int64 BANKACCOUNT_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_BANKACCOUNT_DeleteById(BANKACCOUNT_AUTOID))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table BANKBRANCH
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of BANKBRANCH</param>
        /// <returns>bool</returns>
        public bool CRM_BANKBRANCH_InsertUpdate(Librarys.CRM.BANKBRANCH obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_BANKBRANCH_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Delete data into table BANKBRANCH by Id
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="BANKBRANCH_AUTOID">Int64</param>
        /// <returns>bool</returns>
        public bool CRM_BANKBRANCH_DeleteById(Int64 BANKBRANCH_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_BANKBRANCH_DeleteById(BANKBRANCH_AUTOID))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table BANK
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of BANK</param>
        /// <returns>bool</returns>
        public bool CRM_BANK_InsertUpdate(Librarys.CRM.BANK obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_BANK_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Delete data into table BANK by Id
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="BANK_AUTOID">Int64</param>
        /// <returns>bool</returns>
        public bool CRM_BANK_DeleteById(Int64 BANK_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_BANK_DeleteById(BANK_AUTOID))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table BANKSMS
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of BANKSMS</param>
        /// <returns>bool</returns>
        public bool CRM_BANKSMS_InsertUpdate(Librarys.CRM.BANKSMS obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_BANKSMS_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Delete data into table BANKSMS by Id
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="BANKSMS_AUTOID">Int64</param>
        /// <returns>bool</returns>
        public bool CRM_BANKSMS_DeleteById(Int64 BANKSMS_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_BANKSMS_DeleteById(BANKSMS_AUTOID))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table COMPANY
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of COMPANY</param>
        /// <returns>bool</returns>
        public bool CRM_COMPANY_InsertUpdate(Librarys.CRM.COMPANY obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_COMPANY_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Delete data into table COMPANY by Id
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="COMPANY_AUTOID">Int64</param>
        /// <returns>bool</returns>
        public bool CRM_COMPANY_DeleteById(Int64 COMPANY_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_COMPANY_DeleteById(COMPANY_AUTOID))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table PAYMENTTYPE
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of PAYMENTTYPE</param>
        /// <returns>bool</returns>
        public bool CRM_PAYMENTTYPE_InsertUpdate(Librarys.CRM.PAYMENTTYPE obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_PAYMENTTYPE_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Delete data into table PAYMENTTYPE by Id
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="PAYMENTTYPE_AUTOID">Int64</param>
        /// <returns>bool</returns>
        public bool CRM_PAYMENTTYPE_DeleteById(Int64 PAYMENTTYPE_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_PAYMENTTYPE_DeleteById(PAYMENTTYPE_AUTOID))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table SMSMESSAGE
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of SMSMESSAGE</param>
        /// <returns>bool</returns>
        public bool CRM_SMSMESSAGE_InsertUpdate(Librarys.CRM.SMSMESSAGE obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_SMSMESSAGE_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Delete data into table SMSMESSAGE by Id
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="SMSMESSAGE_AUTOID">Int64</param>
        /// <returns>bool</returns>
        public bool CRM_SMSMESSAGE_DeleteById(Int64 SMSMESSAGE_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_SMSMESSAGE_DeleteById(SMSMESSAGE_AUTOID))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table TRANSFERHISTORY
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of TRANSFERHISTORY</param>
        /// <returns>bool</returns>
        public bool CRM_TRANSFERHISTORY_InsertUpdate(Librarys.CRM.TRANSFERHISTORY obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_TRANSFERHISTORY_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table SMS
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of SMS</param>
        /// <returns>bool</returns>
        public bool CRM_SMS_InsertUpdate(Librarys.CRM.SMS obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_SMS_InsertUpdate(obj))
                return true;
            else return false;
        }
        /// <summary>
        /// Insert data full for table SMSTYPE
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of SMSTYPE</param>
        /// <returns>bool</returns>
        public bool CRM_SMSTYPE_InsertUpdate(Librarys.CRM.SMSTYPE obj)
        {
            Helpers.Connection.sConnectionStringDatabase = System.Configuration.ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            if (ATMLibrary.ATMLibrary.CRM_SMSTYPE_InsertUpdate(obj))
                return true;
            else return false;
        }
        #endregion
    }
}
