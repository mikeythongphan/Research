using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ClassLibraryData
{
    public class WITHDRAW : DataObject
    {
        public static string COLUMN_ID = "ID";
        public static string COLUMN_DATE = "DATE";
        public static string COLUMN_AMOUNT = "AMOUNT";
        public static string COLUMN_PAYMENT_ID = "PAYMENT_ID";
        public static string COLUMN_AGENT_ID = "AGENT_ID";
        public static string COLUMN_DATECREATE = "DATECREATE";
        public static string COLUMN_DATEUPDATE = "DATEUPDATE";
        public static string COLUMN_USER_AUTOID = "USER_AUTOID";
        public static string COLUMN_STATUS = "STATUS";
        public static string COLUMN_CUST_BANK_NAME = "CUST_BANK_NAME";
        public static string COLUMN_CUST_BANK_ACCOUNT_NUMBER = "CUST_BANK_ACCOUNT_NUMBER";
        public static string COLUMN_CUST_BANK_ACCOUNT_NAME = "CUST_BANK_ACCOUNT_NAME";
        public static string COLUMN_CODE = "CODE";

        public static string TABLE_NAME = "WITHDRAW";

        public Nullable<Int64> ID
        {
            get
            {
                return ConvertToInt64(_dataRow[COLUMN_ID]);
            }
            set
            {
                _dataRow[COLUMN_ID] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<Int64> PAYMENT_ID
        {
            get
            {
                return ConvertToInt64(_dataRow[COLUMN_PAYMENT_ID]);
            }
            set
            {
                _dataRow[COLUMN_PAYMENT_ID] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<Int64> AGENT_ID
        {
            get
            {
                return ConvertToInt64(_dataRow[COLUMN_AGENT_ID]);
            }
            set
            {
                _dataRow[COLUMN_AGENT_ID] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<DateTime> DATE
        {
            get
            {
                return ConvertToDateTime(_dataRow[COLUMN_DATE]);
            }
            set
            {
                _dataRow[COLUMN_DATE] = value;
            }
        }
        public Nullable<DateTime> DATECREATE
        {
            get
            {
                return ConvertToDateTime(_dataRow[COLUMN_DATECREATE]);
            }
            set
            {
                _dataRow[COLUMN_DATECREATE] = value;
            }
        }
        public Nullable<DateTime> DATEUPDATE
        {
            get
            {
                return ConvertToDateTime(_dataRow[COLUMN_DATEUPDATE]);
            }
            set
            {
                _dataRow[COLUMN_DATEUPDATE] = value;
            }
        }
        public Nullable<Decimal> AMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_AMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_AMOUNT] = value;
            }
        }
        public string CUST_BANK_NAME
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_CUST_BANK_NAME], null));
            }
            set
            {
                _dataRow[COLUMN_CUST_BANK_NAME] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public string CUST_BANK_ACCOUNT_NUMBER
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_CUST_BANK_ACCOUNT_NUMBER], null));
            }
            set
            {
                _dataRow[COLUMN_CUST_BANK_ACCOUNT_NUMBER] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public string CUST_BANK_ACCOUNT_NAME
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_CUST_BANK_ACCOUNT_NAME], null));
            }
            set
            {
                _dataRow[COLUMN_CUST_BANK_ACCOUNT_NAME] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public Nullable<int> STATUS
        {
            get
            {
                return ConvertToInt(_dataRow[COLUMN_STATUS]);
            }
            set
            {
                _dataRow[COLUMN_STATUS] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<int> CODE
        {
            get
            {
                return ConvertToInt(_dataRow[COLUMN_CODE]);
            }
            set
            {
                _dataRow[COLUMN_CODE] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<Int64> USER_AUTOID
        {
            get
            {
                return ConvertToInt64(_dataRow[COLUMN_USER_AUTOID]);
            }
            set
            {
                _dataRow[COLUMN_USER_AUTOID] = GetSafeObjectValue(value, -1);
            }
        }

        public WITHDRAW(IDataReader RederObject) : base(RederObject, TABLE_NAME) { }
        public WITHDRAW(DataRow row) : base(row, TABLE_NAME) { }
        public WITHDRAW()
            : base(TABLE_NAME,
                    COLUMN_AGENT_ID,
                    COLUMN_AMOUNT,
                    COLUMN_CODE,
                    COLUMN_CUST_BANK_ACCOUNT_NAME,
                    COLUMN_CUST_BANK_ACCOUNT_NUMBER,
                    COLUMN_CUST_BANK_NAME,
                    COLUMN_DATE,
                    COLUMN_DATECREATE,
                    COLUMN_DATEUPDATE,
                    COLUMN_ID,
                    COLUMN_STATUS,
                    COLUMN_PAYMENT_ID,
                    COLUMN_USER_AUTOID
                ) { }
    }
}
