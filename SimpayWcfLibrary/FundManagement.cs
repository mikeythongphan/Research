using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FundManagementLib;
using SimpayWcfLibrary.Models;
using System.Configuration;

namespace SimpayWcfLibrary
{
    public class FundManagement : IFundManagement
    {
        public void ProcessingDistributeSMS()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            FundManagementLib.FundManagementLib.ProcessingDistributeSMS();
        }

        public List<Librarys.CRM.USER> GetAllUSerAvailable()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllUSerAvailable();
        }

        public bool USER_InsertUpdate(Librarys.CRM.USER obj)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.UserInsertUpdate(obj);
        }

        public bool USER_DeleteByID(long USER_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.UserDeleteByID(USER_AUTOID);
        }

        public List<Librarys.CRM.USERTYPE> GetAllUserType()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllUSERTYPE();
        }

        /// <summary>
        /// Insert or update Transaction for send SMS
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool TRANSACTION_InsertUpdate(Librarys.CRM.TRANSACTION obj)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.TransactionInsertUpdate(obj);
        }

        /// <summary>
        /// Get All Bank Active 
        /// </summary>
        /// <returns></returns>
        public List<Librarys.CRM.BANK> GetAllBankActive()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllBankActive();
        }

        /// <summary>
        /// Get all sms Type Active
        /// </summary>
        /// <returns></returns>
        public List<Librarys.CRM.SMSTYPE> GetAllSmsTypeActive()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllSMSTypeActive();
        }

        /// <summary>
        /// GET MAPPING_BANK_SMSTYPE_USER by BANK_AUTOID,SMSTYPE_AUTOID,USER_AUTOID
        /// </summary>
        /// <param name="BANK_AUTOID"></param>
        /// <param name="SMSTYPE_AUTOID"></param>
        /// <param name="USER_AUTOID"></param>
        /// <returns></returns>
        public Librarys.CRM.MAPPING_BANK_SMSTYPE_USER GetMAPPING_BANK_SMSTYPE_USERByConditions(long BANK_AUTOID, int SMSTYPE_AUTOID, long USER_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetMAPPING_BANK_SMSTYPE_USERByConditions(BANK_AUTOID, SMSTYPE_AUTOID, USER_AUTOID);
        }

        /// <summary>
        /// insert or update MAPPING_BANK_SMSTYPE_USER object to db
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool MAPPING_BANK_SMSTYPE_USERInsertUpdate(Librarys.CRM.MAPPING_BANK_SMSTYPE_USER obj)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.MAPPING_BANK_SMSTYPE_USER_InsertUpdate(obj);
        }

        /// <summary>
        /// Get list Rule Content Sms by smsType ID
        /// </summary>
        /// <param name="SMSTYPE_AUTOID"></param>
        /// <returns></returns>
        public List<Librarys.CRM.RULECONTENTSMS> GetAllRuleContentSMSBySmsType(int SMSTYPE_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllRuleContentSMSBySmsType(SMSTYPE_AUTOID);
        }

        /// <summary>
        /// GEt USER_MAPPING_CONTENTSMS object by UserID &RuleContentSMSID
        /// </summary>
        /// <param name="USER_AUTOID"></param>
        /// <param name="RULECONTENT_AUTOID"></param>
        /// <returns></returns>
        public Librarys.CRM.USER_MAPPING_CONTENTSMS GetMappingRuleContentSMSByUserID_RuleContentID(long USER_AUTOID, long RULECONTENT_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetMappingRuleContentSMSByUserID_RuleContentID(USER_AUTOID, RULECONTENT_AUTOID);
        }

        /// <summary>
        /// Insert Or update USER_MAPPING_CONTENTSMS obj
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool USER_MAPPING_CONTENTSMS_InsertUpdate(Librarys.CRM.USER_MAPPING_CONTENTSMS obj)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.USER_MAPPING_CONTENTSMS_InsertUpdate(obj);
        }

        /// <summary>
        /// Get All Bank sms
        /// </summary>
        /// <returns></returns>
        public List<Librarys.CRM.BANKSMS> GetAllBankSMS()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllBankSMS();
        }

        /// <summary>
        /// Get all rule view Bank SMS contents
        /// </summary>
        /// <returns></returns>
        public List<Librarys.CRM.RULEVIEWBANKSMS> GetAllRuleViewBankSMS()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllRuleViewBankSMS();
        }

        /// <summary>
        /// Get rule view bank sms by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Librarys.CRM.RULEVIEWBANKSMS GetRuleViewBankSMSByUserName(string username)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetRuleViewBankSMSByUserName(username);
        }

        /// <summary>
        /// Insert rule view banks sms Content to db
        /// </summary>
        /// <param name="obj"> type of RULEVIEWBANKSMS</param>
        /// <returns>bool</returns>
        public bool RULEVIEWBANKSMS_InsertUpdate(Librarys.CRM.RULEVIEWBANKSMS obj)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.RULEVIEWBANKSMS_InsertUpdate(obj);
        }

        /// <summary>
        /// Get all user not use for RuleViewBAnksms
        /// </summary>
        /// <returns></returns>
        public List<Librarys.CRM.USER> GetUserForInsertRuleViewSMS()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetUserForInsertRuleViewSMS();
        }


        public List<Librarys.CRM.BANKSMS> GetAllBANKSMSSearchData(params object[] param)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllBANKSMSSearchData(param);
        }


        public bool RULECONTENTSMS_InsertUpdate(Librarys.CRM.RULECONTENTSMS obj)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.RULECONTENTSMS_InsertUpdate(obj);
        }


        public List<Librarys.CRM.SMS> GetAllSMSSearchData(params object[] param)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllSMSSearchData(param);
        }


        public List<Librarys.CRM.TRANSACTION> GetAllTRANSACTIONSearchData(params object[] param)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllTransactionSearchData(param);
        }


        public List<Librarys.CRM.REGEXBANKSMSCONTENT> GetAllRegexContentSMSAvailable()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllRegexContentSMSAvailable();
        }


        public bool REGEXBANKSMSCONTENT_InsertUpdate(Librarys.CRM.REGEXBANKSMSCONTENT obj)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.REGEXBANKSMSCONTENT_InsertUpdate(obj);
        }


        public List<Librarys.CRM.REGEXBANKSMSCONTENT> GetAllRegexContentSMSByBankID(long? BANK_AUTOID)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllRegexContentSMSByBankID(BANK_AUTOID);
        }


        public List<Librarys.CRM.USER> GetAllUSerSearchData(params object[] param)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            return FundManagementLib.FundManagementLib.GetAllUSerSearchData(param);
        }
    }
}
