using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using SimpayWcfLibrary.Models;

namespace SimpayWcfLibrary
{
    [ServiceContract]
    public interface IFundManagement
    {
        [OperationContract]
        void ProcessingDistributeSMS();

        [OperationContract]
        List<Librarys.CRM.USER> GetAllUSerAvailable();

        [OperationContract]
        List<Librarys.CRM.USER> GetAllUSerSearchData(params object[] param);

        [OperationContract]
        List<Librarys.CRM.USER> GetUserForInsertRuleViewSMS();

        [OperationContract]
        bool USER_InsertUpdate(Librarys.CRM.USER obj);
        [OperationContract]
        bool USER_DeleteByID(Int64 USER_AUTOID);

        [OperationContract]
        List<Librarys.CRM.USERTYPE> GetAllUserType();

        [OperationContract]
        bool TRANSACTION_InsertUpdate(Librarys.CRM.TRANSACTION obj);

        [OperationContract]
        List<Librarys.CRM.BANK> GetAllBankActive();

        [OperationContract]
        List<Librarys.CRM.SMSTYPE> GetAllSmsTypeActive();

        [OperationContract]
        Librarys.CRM.MAPPING_BANK_SMSTYPE_USER GetMAPPING_BANK_SMSTYPE_USERByConditions(Int64 BANK_AUTOID, int SMSTYPE_AUTOID, Int64 USER_AUTOID);

        [OperationContract]
        bool MAPPING_BANK_SMSTYPE_USERInsertUpdate(Librarys.CRM.MAPPING_BANK_SMSTYPE_USER obj);

        [OperationContract]
        List<Librarys.CRM.RULECONTENTSMS> GetAllRuleContentSMSBySmsType(int SMSTYPE_AUTOID);

        [OperationContract]
        Librarys.CRM.USER_MAPPING_CONTENTSMS GetMappingRuleContentSMSByUserID_RuleContentID(Int64 USER_AUTOID, Int64 RULECONTENT_AUTOID);

        [OperationContract]
        bool USER_MAPPING_CONTENTSMS_InsertUpdate(Librarys.CRM.USER_MAPPING_CONTENTSMS obj);

        [OperationContract]
        List<Librarys.CRM.BANKSMS> GetAllBankSMS();

        [OperationContract]
        List<Librarys.CRM.BANKSMS> GetAllBANKSMSSearchData(params object[] param);

        [OperationContract]
        List<Librarys.CRM.SMS> GetAllSMSSearchData(params object[] param);

        [OperationContract]
        List<Librarys.CRM.TRANSACTION> GetAllTRANSACTIONSearchData(params object[] param);
        
        [OperationContract]
        List<Librarys.CRM.RULEVIEWBANKSMS> GetAllRuleViewBankSMS();

        [OperationContract]
        Librarys.CRM.RULEVIEWBANKSMS GetRuleViewBankSMSByUserName(string username);

        [OperationContract]
        bool RULEVIEWBANKSMS_InsertUpdate(Librarys.CRM.RULEVIEWBANKSMS obj);

        [OperationContract]
        bool RULECONTENTSMS_InsertUpdate(Librarys.CRM.RULECONTENTSMS obj);

        [OperationContract]
        List<Librarys.CRM.REGEXBANKSMSCONTENT> GetAllRegexContentSMSAvailable();

        [OperationContract]
        List<Librarys.CRM.REGEXBANKSMSCONTENT> GetAllRegexContentSMSByBankID(long? BANK_AUTOID);

        [OperationContract]
        bool REGEXBANKSMSCONTENT_InsertUpdate(Librarys.CRM.REGEXBANKSMSCONTENT obj);
    }
}
