using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Librarys.SYSTEMWARNING;
using WarningLibrary;
using Helpers;
using System.Configuration;
using Bases;
using System.Data;
using Utilities;

namespace SimpayWcfLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SystemWarning" in both code and config file together.
    public class SystemWarning : ISystemWarning
    {

        public void Balance_Simpay(long providerID, decimal balance)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_SystemWarning"].ConnectionString;
            WarningLibrary.SystemWarning sw = new WarningLibrary.SystemWarning();

            //list chua KQ check Rules
            List<LOGSEND> result = sw.Balance_Simpay(providerID, balance);
            //dataset chua Logsend
            DataSet dsLogSend = new DataSet();
            //bien thong tin message
            Int64 intLOGSEND_AUTOID = 0;
            Int64 intRULE_AUTOID = 0;
            Int64 intACTION_AUTOID = 0;
            Int64 intUSERSEND_AUTOID = 0;
            Boolean blExist = false;

            //bien thoi gian
            DateTime dtNow;
            DateTime dtRULE_CREATEDATE;
            TimeSpan tsDiff;
            Int64 intDiff;
            //config dang Giay
            Int64 intInterval = Convert.ToInt64(ConfigurationManager.AppSettings["interval"]);

            //kiem tra trung message
            if (result.Count() > 0)
            {
                //kiem tra tung message
                foreach (LOGSEND log in result)
                {
                    dsLogSend.Clear();
                    Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_SystemWarning"].ConnectionString;
                    dsLogSend = DataOut.SW_LOGSEND_Select_All();

                    //neu dsLogSend co message - set tung message trong Logsend
                    if (dsLogSend.Tables[0].Rows.Count > 0)
                    {
                        blExist = false;
                        //kiem tra ton tai message
                        for (int i = 0; i < dsLogSend.Tables[0].Rows.Count; i++)
                        {
                            //lay thong tin message
                            intLOGSEND_AUTOID = Convert.ToInt64(dsLogSend.Tables[0].Rows[i][LOGSEND.COLUMN_LOGSEND_AUTOID].ToString().Trim());
                            intRULE_AUTOID = Convert.ToInt64(dsLogSend.Tables[0].Rows[i][LOGSEND.COLUMN_RULE_AUTOID].ToString().Trim());
                            intACTION_AUTOID = Convert.ToInt64(dsLogSend.Tables[0].Rows[i][LOGSEND.COLUMN_ACTION_AUTOID].ToString().Trim());
                            intUSERSEND_AUTOID = Convert.ToInt64(dsLogSend.Tables[0].Rows[i][LOGSEND.COLUMN_USERSEND_AUTOID].ToString().Trim());
                            //truong hop ton tai message (cung [RULE_AUTOID], [ACTION_AUTOID], [USERSEND_AUTOID])
                            if (log.RULE_AUTOID == intRULE_AUTOID && log.ACTION_AUTOID == intACTION_AUTOID && log.USERSEND_AUTOID == intUSERSEND_AUTOID)
                            {
                                blExist = true;
                                break;
                            }
                            else
                            {
                                blExist = false;
                            }
                        }
                        //truong hop ton tai message
                        if (blExist)
                        {
                            dtNow = DateTime.Now;
                            dtRULE_CREATEDATE = Convert.ToDateTime(DataOut.SW_LOGSEND_SelectByID(intLOGSEND_AUTOID).Tables[0].Rows[0][LOGSEND.COLUMN_RULE_CREATEDATE].ToString().Trim());
                            tsDiff = dtNow - dtRULE_CREATEDATE;
                            intDiff = (tsDiff.Days * 24 * 60 * 60) + (tsDiff.Hours * 60 * 60) + (tsDiff.Minutes * 60) + tsDiff.Seconds;

                            //truong hop <= config
                            if (intDiff <= intInterval)
                            {
                                //cap nhat thoi gian message
                                //DataIn.SW_LOGSEND_UpdateByID(intLOGSEND_AUTOID);
                            }
                            else
                            {
                                //cap nhat thoi gian message
                                DataIn.SW_LOGSEND_UpdateByID(intLOGSEND_AUTOID);
                                //thuc hien gui
                                Balance_Simpay_Insert_Send(log, balance);
                            }
                        }
                        //truong hop khong ton tai message
                        else
                        {
                            //insert Logsend
                            DataIn.SW_LOGSEND_Insert(log);
                            //thuc hien gui
                            Balance_Simpay_Insert_Send(log, balance);
                        }
                    }
                    //neu dsLogSend khong co message - insert va gui luon
                    else
                    {
                        //insert Logsend
                        DataIn.SW_LOGSEND_Insert(log);
                        //thuc hien gui
                        Balance_Simpay_Insert_Send(log, balance);
                    }
                }
            }
        }

        private void Balance_Simpay_Insert_Send(LOGSEND log, decimal balance)
        {
            //thoi gian he thong
            string strNow = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            string strNowTitle = string.Format("{0:yyyy-MM-dd}", DateTime.Now);

            //lay title Email la ruleName
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_SystemWarning"].ConnectionString;
            string titleEmail = DataOut.SW_RULES_SelectByID(log.RULE_AUTOID).Tables[0].Rows[0][RULE.COLUMN_RULE_NAME].ToString().Trim();
            titleEmail += " " + strNowTitle;

            //lay noi dung gui la gia tri cua cac conditions
            string strContentSend = null;
            DataSet dsContent = new DataSet();
            dsContent = DataOut.SW_RULEDETAIL_BALANCESSIMPAY_All(log.RULE_AUTOID);

            for (int i = 0; i < dsContent.Tables[0].Rows.Count; i++)
            {
                //chi lay cac conditions da Active
                if (Convert.ToBoolean(dsContent.Tables[0].Rows[i][RULEDETAIL.COLUMN_RULEDETAIL_ISACTIVE].ToString().Trim()) == true)
                {
                    //truong hop condition "so du tai khoan"
                    if (Convert.ToInt64(dsContent.Tables[0].Rows[i][RULEDETAIL.COLUMN_CONDITION_AUTOID].ToString().Trim()) == 3)
                    {
                        strContentSend += (dsContent.Tables[0].Rows[i]["CONDITION_NAME"].ToString().Trim()) + ": " + balance.ToString("#,##0 VNĐ") + " " + (dsContent.Tables[0].Rows[i]["KEY_NOTE2"].ToString().Trim())
                            + " " + Convert.ToDecimal(dsContent.Tables[0].Rows[i]["KEYVALUE"].ToString().Trim()).ToString("#,##0 VNĐ") + "; ";
                    }
                    //truong hop condition "nha cung cap"
                    else if (Convert.ToInt64(dsContent.Tables[0].Rows[i][RULEDETAIL.COLUMN_CONDITION_AUTOID].ToString().Trim()) == 2)
                    {
                        strContentSend += (dsContent.Tables[0].Rows[i]["CONDITION_NAME"].ToString().Trim()) + ": " + (dsContent.Tables[0].Rows[i]["KEYVALUE"].ToString().Trim()) + "; ";
                    }
                    //truong hop condition "thoi diem"        
                    else if (Convert.ToInt64(dsContent.Tables[0].Rows[i][RULEDETAIL.COLUMN_CONDITION_AUTOID].ToString().Trim()) == 4)
                    {
                        //truong hop la ngay co dinh
                        if (Convert.ToInt64(dsContent.Tables[0].Rows[i][RULEDETAIL.COLUMN_RULEDETAIL_TYPE].ToString().Trim()) == 3)
                        {
                            strContentSend += (dsContent.Tables[0].Rows[i]["CONDITION_NAME"].ToString().Trim()) + ": " + (dsContent.Tables[0].Rows[i]["KEYVALUE"].ToString().Trim()) + "; ";
                        }
                        //truong hop chon thu
                        else
                        {
                            strContentSend += (dsContent.Tables[0].Rows[i]["CONDITION_NAME"].ToString().Trim()) + ": " + (dsContent.Tables[0].Rows[i]["CONDITIONDETAIL_VALUE"].ToString().Trim()) + "; ";
                        }
                    }
                }
            }


            //send message
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            //SMS
            if (log.ACTION_AUTOID == 1)
            {
                //insert vao DB SMS
                Librarys.CRM.TRANSACTION trans = new Librarys.CRM.TRANSACTION();
                trans.RECEIVEACCOUNT = log.USERSEND_HANDPHONE;
                trans.FROMACCOUNT = "";
                trans.LASTUPDATE = DateTime.Now;
                trans.CODE = 1;
                trans.STATUS = 1;
                trans.VALUE = Protect.RemoveVNString(strContentSend).Trim();
                trans.TRANSTYPECODE = 4;
                trans.RECEIVEID = DateTime.Now.Ticks.ToString();
                trans.COMSIMID = 0;
                DataIn.CRM_TRANSACTION_InsertUpdate(trans);
            }
            //EMAIL
            else if (log.ACTION_AUTOID == 2)
            {
                //insert vao DB EMAIL
                Librarys.CRM.TRANSACTION trans = new Librarys.CRM.TRANSACTION();
                trans.RECEIVEACCOUNT = log.USERSEND_EMAIL;
                trans.FROMACCOUNT = "simpaynoreply@simpay.com.vn";
                trans.LASTUPDATE = DateTime.Now;
                trans.CODE = 1;
                trans.STATUS = 1;
                trans.VALUE = string.Format("{0}##{1}", titleEmail, strNow + "; " + strContentSend);
                trans.TRANSTYPECODE = 10;
                trans.RECEIVEID = "<" + Guid.NewGuid().ToString() + "@simpay.com.vn>";
                trans.COMSIMID = 0;
                DataIn.CRM_TRANSACTION_InsertUpdate(trans);
            }
        }


    }
}
