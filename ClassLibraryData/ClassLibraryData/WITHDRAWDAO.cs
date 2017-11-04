using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryData
{
    public class WITHDRAWDAO
    {
        /// <summary>
        /// Insert data full for table WITHDRAW
        /// you must set attribute at application tier
        /// </summary>
        /// <param name="obj"> type of WITHDRAW</param>
        /// <returns>bool</returns>
        public static bool InsertWithdraw(WITHDRAW obj)
        {
            SqlHelper.ConnectString = Connection.sConnectionString_EWallet;
            int i = SqlHelper.ExecuteNonQuery("SP_DB_EWALLET_WITHDRAW_InsertUpdate",
            obj.ID,
            obj.DATE,
            obj.PAYMENT_ID,
            obj.AGENT_ID,
            obj.CUST_BANK_NAME,
            obj.CUST_BANK_ACCOUNT_NUMBER,
            obj.CUST_BANK_ACCOUNT_NAME,
            obj.AMOUNT,
            0,
            obj.CODE,
            DateTime.Now,
            DateTime.Now,
            null
            );
            if (i > 0) return true; else return false;
        }
    }
}
