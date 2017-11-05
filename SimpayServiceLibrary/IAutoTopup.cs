using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace SimpayServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAutoTopup" in both code and config file together.
    [ServiceContract]
    public interface IAutoTopup
    {
        [OperationContract]
        List<Librarys.CRM.AGENT> CRM_AGENT_GetAllAGENTList();

        [OperationContract]
        DataSet CRM_AGENT_GetAllAGENTData();

        [OperationContract]
        List<Librarys.CRM.AGENT> CRM_AGENT_GetAllAGENTListIsActive();

        [OperationContract]
        DataSet CRM_AGENT_GetAllAGENTDataIsActive();

        [OperationContract]
        List<Librarys.CRM.AGENT> CRM_AGENT_GetAllAGENTListById(Int64 AGENTID);

        [OperationContract]
        DataSet CRM_AGENT_GetAllAGENTDataById(Int64 AGENTID);

        [OperationContract]
        List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGList();

        [OperationContract]
        DataSet CRM_PURCHASING_GetAllPURCHASINGData();

        [OperationContract]
        List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGListIsActive();

        [OperationContract]
        DataSet CRM_PURCHASING_GetAllPURCHASINGDataIsActive();

        [OperationContract]
        List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGListIsActiveById(Int64 PURCHASING_AUTOID);

        [OperationContract]
        DataSet CRM_PURCHASING_GetAllPURCHASINGDataIsActiveById(Int64 PURCHASING_AUTOID);

        [OperationContract]
        DataSet CRM_PURCHASING_GetAllPURCHASINGSearchData(params object[] param);

        [OperationContract]
        DataSet CRM_PURCHASING_GetAllPURCHASINGSearchDataPurchaseHistory(params object[] param);

        [OperationContract]
        List<Librarys.CRM.BANK> CRM_BANK_GetAllBANKList();

        [OperationContract]
        DataSet CRM_BANK_GetAllBANKData();

        [OperationContract]
        List<Librarys.CRM.BANK> CRM_BANK_GetAllBANKListIsActive();

        [OperationContract]
        DataSet CRM_BANK_GetAllBANKDataIsActive();

        [OperationContract]
        List<Librarys.CRM.BANK> CRM_BANK_GetAllBANKListIsActiveById(Int64 BANK_AUTOID);

        [OperationContract]
        DataSet CRM_BANK_GetAllBANKDataIsActiveById(Int64 BANK_AUTOID);

        [OperationContract]
        List<Librarys.CRM.BANKACCOUNT> CRM_BANKACCOUNT_GetAllBANKACCOUNTList();

        [OperationContract]
        DataSet CRM_BANKACCOUNT_GetAllBANKACCOUNTData();

        [OperationContract]
        List<Librarys.CRM.BANKACCOUNT> CRM_BANKACCOUNT_GetAllBANKACCOUNTListIsActive();

        [OperationContract]
        DataSet CRM_BANKACCOUNT_GetAllBANKACCOUNTDataIsActive();

        [OperationContract]
        List<Librarys.CRM.BANKACCOUNT> CRM_BANKACCOUNT_GetAllBANKACCOUNTListIsActiveById(Int64 BANKACC_AUTOID);

        [OperationContract]
        DataSet CRM_BANKACCOUNT_GetAllBANKACCOUNTDataIsActiveById(Int64 BANKACC_AUTOID);

        [OperationContract]
        List<Librarys.CRM.BANKBRANCH> CRM_BANKBRANCH_GetAllBANKBRANCHList();

        [OperationContract]
        DataSet CRM_BANKBRANCH_GetAllBANKBRANCHData();

        [OperationContract]
        List<Librarys.CRM.BANKBRANCH> CRM_BANKBRANCH_GetAllBANKBRANCHListIsActive();

        [OperationContract]
        DataSet CRM_BANKBRANCH_GetAllBANKBRANCHDataIsActive();

        [OperationContract]
        List<Librarys.CRM.BANKBRANCH> CRM_BANKBRANCH_GetAllBANKBRANCHListIsActiveById(Int64 BANKBRA_AUTOID);

        [OperationContract]
        DataSet CRM_BANKBRANCH_GetAllBANKBRANCHDataIsActiveById(Int64 BANKBRA_AUTOID);

        [OperationContract]
        List<Librarys.CRM.PAYMENTTYPE> CRM_PAYMENTTYPE_GetAllPAYMENTTYPEList();

        [OperationContract]
        DataSet CRM_PAYMENTTYPE_GetAllPAYMENTTYPEData();

        [OperationContract]
        List<Librarys.CRM.PAYMENTTYPE> CRM_PAYMENTTYPE_GetAllPAYMENTTYPEListIsActive();

        [OperationContract]
        DataSet CRM_PAYMENTTYPE_GetAllPAYMENTTYPEDataIsActive();

        [OperationContract]
        List<Librarys.CRM.PAYMENTTYPE> CRM_PAYMENTTYPE_GetAllPAYMENTTYPEListIsActiveById(Int64 PAYTYPE_AUTOID);

        [OperationContract]
        DataSet CRM_PAYMENTTYPE_GetAllPAYMENTTYPEDataIsActiveById(Int64 PAYTYPE_AUTOID);

        [OperationContract]
        List<Librarys.CRM.COMPANY> CRM_COMPANY_GetAllCOMPANYList();

        [OperationContract]
        DataSet CRM_COMPANY_GetAllCOMPANYData();

        [OperationContract]
        List<Librarys.CRM.COMPANY> CRM_COMPANY_GetAllCOMPANYListIsActive();

        [OperationContract]
        DataSet CRM_COMPANY_GetAllCOMPANYDataIsActive();

        [OperationContract]
        List<Librarys.CRM.COMPANY> CRM_COMPANY_GetAllCOMPANYListIsActiveById(Int64 COMP_AUTOID);

        [OperationContract]
        DataSet CRM_COMPANY_GetAllCOMPANYDataIsActiveById(Int64 COMP_AUTOID);

        [OperationContract]
        List<Librarys.CRM.BANKSMS> CRM_BANKSMS_GetAllBANKSMSList();

        [OperationContract]
        DataSet CRM_BANKSMS_GetAllBANKSMSData();

        [OperationContract]
        List<Librarys.CRM.BANKSMS> CRM_BANKSMS_GetAllBANKSMSListIsActive();

        [OperationContract]
        DataSet CRM_BANKSMS_GetAllBANKSMSDataIsActive();

        [OperationContract]
        List<Librarys.CRM.BANKSMS> CRM_BANKSMS_GetAllBANKSMSListIsActiveById(Int64 BANKSMS_AUTOID);

        [OperationContract]
        DataSet CRM_BANKSMS_GetAllBANKSMSDataIsActiveById(Int64 BANKSMS_AUTOID);

        [OperationContract]
        List<Librarys.CRM.SMSMESSAGE> CRM_SMSMESSAGE_GetAllSMSMESSAGEList();

        [OperationContract]
        DataSet CRM_SMSMESSAGE_GetAllSMSMESSAGEData();

        [OperationContract]
        List<Librarys.CRM.SMSMESSAGE> CRM_SMSMESSAGE_GetAllSMSMESSAGEListIsActive();

        [OperationContract]
        DataSet CRM_SMSMESSAGE_GetAllSMSMESSAGEDataIsActive();

        [OperationContract]
        List<Librarys.CRM.SMSMESSAGE> CRM_SMSMESSAGE_GetAllSMSMESSAGEListIsActiveById(Int64 SMSMESS_AUTOID);

        [OperationContract]
        DataSet CRM_SMSMESSAGE_GetAllSMSMESSAGEDataIsActiveById(Int64 SMSMESS_AUTOID);

        [OperationContract]
        DataSet CRM_BANKACCOUNT_GetAllBANKACCOUNTDataIsActiveByBankId(Int64 BANK_AUTOID, Int64 COMP_AUTOID);

        [OperationContract]
        DataSet CRM_TRANSFERHISTORY_GetAllTRANSFERHISTORYSearchData(params object[] param);

        [OperationContract]
        DataSet CRM_PURCHASING_GetAllPURCHASINGDataCodeByAgentId(Int64 AGENT_ID);

        [OperationContract]
        List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGListIsConfirmed();

        [OperationContract]
        DataSet CRM_PURCHASING_GetAllPURCHASINGDataIsConfirmed();

        [OperationContract]
        List<Librarys.CRM.PURCHASING> CRM_PURCHASING_GetAllPURCHASINGListIsActiveByPayTypeId(Int64 PAYTYPE_AUTOID);

        [OperationContract]
        DataSet CRM_PURCHASING_GetAllPURCHASINGDataIsActiveByPayTypeId(Int64 PAYTYPE_AUTOID);

        [OperationContract]
        DataSet CRM_BANKSMS_GetAllBANKSMSSearchData(params object[] param);

        [OperationContract]
        List<Librarys.CRM.CONFIGURATION> CRM_CONFIGURATION_GetAllCONFIGURATIONListIsActiveById(Int64 AUTOID);

        [OperationContract]
        DataSet CRM_CONFIGURATION_GetAllCONFIGURATIONDataIsActiveById(Int64 AUTOID);

        [OperationContract]
        List<Librarys.CRM.CONFIGURATION> CRM_CONFIGURATION_GetAllCONFIGURATIONListByTypeId(int TYPEID);

        [OperationContract]
        DataSet CRM_CONFIGURATION_GetAllCONFIGURATIONDataByTypeId(int TYPEID);

        [OperationContract]
        DataSet CRM_SMS_GetAllSMSData();

        [OperationContract]
        List<Librarys.CRM.SMS> CRM_SMS_GetAllSMSList();

        [OperationContract]
        List<Librarys.CRM.SMS> CRM_SMS_GetAllSMSListIsActiveById(int AUTOID);

        [OperationContract]
        DataSet CRM_SMS_GetAllSMSDataIsActiveById(int AUTOID);

        [OperationContract]
        DataSet CRM_SMS_SearchData(params object[] param);

        [OperationContract]
        DataSet CRM_SMSTYPE_GetAllSMSTYPEData();

        [OperationContract]
        List<Librarys.CRM.SMSTYPE> CRM_SMSTYPE_GetAllSMSTYPEList();

        [OperationContract]
        DataSet CRM_SMSTYPE_GetAllSMSTYPEDataIsActive();

        [OperationContract]
        List<Librarys.CRM.SMSTYPE> CRM_SMSTYPE_GetAllSMSTYPEListIsActive();

        [OperationContract]
        List<Librarys.CRM.SMSTYPE> CRM_SMSTYPE_GetAllSMSTYPEListIsActiveById(int AUTOID);

        [OperationContract]
        DataSet CRM_SMSTYPE_GetAllSMSTYPEDataIsActiveById(int AUTOID);

        [OperationContract]
        bool CRM_PURCHASING_InsertUpdate(Librarys.CRM.PURCHASING obj);

        [OperationContract]
        Int64 CRM_PURCHASING_InsertPurchasing(Librarys.CRM.PURCHASING obj);

        [OperationContract]
        bool CRM_PURCHASING_DeleteById(Int64 PURCHASING_AUTOID);

        [OperationContract]
        bool CRM_AGENT_InsertUpdate(Librarys.CRM.AGENT obj);

        [OperationContract]
        bool CRM_AGENT_DeleteById(Int64 AGENT_AUTOID);

        [OperationContract]
        bool CRM_BANKACCOUNT_InsertUpdate(Librarys.CRM.BANKACCOUNT obj);

        [OperationContract]
        bool CRM_BANKACCOUNT_DeleteById(Int64 BANKACCOUNT_AUTOID);

        [OperationContract]
        bool CRM_BANKBRANCH_InsertUpdate(Librarys.CRM.BANKBRANCH obj);

        [OperationContract]
        bool CRM_BANKBRANCH_DeleteById(Int64 BANKBRANCH_AUTOID);

        [OperationContract]
        bool CRM_BANK_InsertUpdate(Librarys.CRM.BANK obj);

        [OperationContract]
        bool CRM_BANK_DeleteById(Int64 BANK_AUTOID);

        [OperationContract]
        bool CRM_BANKSMS_InsertUpdate(Librarys.CRM.BANKSMS obj);

        [OperationContract]
        bool CRM_BANKSMS_DeleteById(Int64 BANKSMS_AUTOID);

        [OperationContract]
        bool CRM_COMPANY_InsertUpdate(Librarys.CRM.COMPANY obj);

        [OperationContract]
        bool CRM_COMPANY_DeleteById(Int64 COMPANY_AUTOID);

        [OperationContract]
        bool CRM_PAYMENTTYPE_InsertUpdate(Librarys.CRM.PAYMENTTYPE obj);

        [OperationContract]
        bool CRM_PAYMENTTYPE_DeleteById(Int64 PAYMENTTYPE_AUTOID);

        [OperationContract]
        bool CRM_SMSMESSAGE_InsertUpdate(Librarys.CRM.SMSMESSAGE obj);

        [OperationContract]
        bool CRM_SMSMESSAGE_DeleteById(Int64 SMSMESSAGE_AUTOID);

        [OperationContract]
        bool CRM_TRANSFERHISTORY_InsertUpdate(Librarys.CRM.TRANSFERHISTORY obj);

        [OperationContract]
        bool CRM_SMS_InsertUpdate(Librarys.CRM.SMS obj);

        [OperationContract]
        bool CRM_SMSTYPE_InsertUpdate(Librarys.CRM.SMSTYPE obj);
    }
}
