///////////////////////////////////////////////////////////////////////////
// Description: Entity class for the 'DECLARATION'
// Generated by VNYI GenTool.
// Copyright (c) YI Corp. All rights reserved.// Design by ngocchinh.//email:ngocchinh4984@gmail.com
///////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

using System.Data;


namespace vnyi.Library.COMON.IV
{
    public class DECLARATION : vnyi.DLL.DataObject
    {

        public static string COLUMN_DEC_DOCUMENTID = "DEC_DOCUMENTID";
        public static string COLUMN_DEC_ISUSE = "DEC_ISUSE";
        public static string COLUMN_PTE_DUEDATE = "PTE_DUEDATE";
        public static string COLUMN_DEC_INVOICEDATE = "DEC_INVOICEDATE";
        public static string COLUMN_DEC_ARRIVALDATE = "DEC_ARRIVALDATE";
        public static string COLUMN_DEC_COMMUDATE = "DEC_COMMUDATE";
        public static string COLUMN_DEC_DELIVERYDATE = "DEC_DELIVERYDATE";
        public static string COLUMN_DEC_BASEAMOUNT = "DEC_BASEAMOUNT";
        public static string COLUMN_DEC_AMOUNT = "DEC_AMOUNT";
        public static string COLUMN_DEC_BALANCE = "DEC_BALANCE";
        public static string COLUMN_OBJ_HANDLE = "OBJ_HANDLE";
        public static string COLUMN_CON_AUTOID = "CON_AUTOID";
        public static string COLUMN_OBJ_AUTOID = "OBJ_AUTOID";
        public static string COLUMN_DEC_COMMUNCONTENT = "DEC_COMMUNCONTENT";
        public static string COLUMN_DEC_IMPORTHARBOUR = "DEC_IMPORTHARBOUR";
        public static string COLUMN_CUR_AUTOID = "CUR_AUTOID";
        public static string COLUMN_FICI_AUTOID = "FICI_AUTOID";
        public static string COLUMN_PTE_AUTOID = "PTE_AUTOID";
        public static string COLUMN_PPT_AUTOID = "PPT_AUTOID";
        public static string COLUMN_DOTY_AUTOID = "DOTY_AUTOID";
        public static string COLUMN_SMT_AUTOID = "SMT_AUTOID";
        public static string COLUMN_DEC_INVOICENO = "DEC_INVOICENO";
        public static string COLUMN_DEC_BOARDCUSTOMS = "DEC_BOARDCUSTOMS";
        public static string COLUMN_DEC_EXPORTHARBOUR = "DEC_EXPORTHARBOUR";
        public static string COLUMN_DEC_REGISTEROFFICIAL = "DEC_REGISTEROFFICIAL";
        public static string COLUMN_DEC_COMMUNNO = "DEC_COMMUNNO";
        public static string COLUMN_DEC_DELIVERYINVOICE = "DEC_DELIVERYINVOICE";
        public static string COLUMN_DEC_BRANCHOFFICE = "DEC_BRANCHOFFICE";
        public static string COLUMN_DEC_CURRENCYRATE = "DEC_CURRENCYRATE";

        public static string TABLE_NAME = "DECLARATION";

        public Nullable<Int64> DEC_DOCUMENTID
        {
            get
            {
                return ConvertToInt64(GetSafeObjectValue(_dataRow[COLUMN_DEC_DOCUMENTID], -1));
            }
            set
            {
                _dataRow[COLUMN_DEC_DOCUMENTID] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<Int16> CUR_AUTOID
        {
            get
            {
                return ConvertToInt16(GetSafeObjectValue(_dataRow[COLUMN_CUR_AUTOID], -1));
            }
            set
            {
                _dataRow[COLUMN_CUR_AUTOID] = GetSafeObjectValue(value, -1);
            }
        }
        public  Nullable<int> CON_AUTOID
        {
            get
            {
                return ConvertToInt32(GetSafeObjectValue(_dataRow[COLUMN_CON_AUTOID], -1));
            }
            set
            {
                _dataRow[COLUMN_CON_AUTOID] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<Int16> FICI_AUTOID
        {
            get
            {
                return ConvertToInt16(GetSafeObjectValue(_dataRow[COLUMN_FICI_AUTOID], -1));
            }
            set
            {
                _dataRow[COLUMN_FICI_AUTOID] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<Int16> DOTY_AUTOID
        {
            get
            {
                return ConvertToInt16(GetSafeObjectValue(_dataRow[COLUMN_DOTY_AUTOID], -1));
            }
            set
            {
                _dataRow[COLUMN_DOTY_AUTOID] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<Int16> PPT_AUTOID
        {
            get
            {
                return ConvertToInt16(GetSafeObjectValue(_dataRow[COLUMN_PPT_AUTOID], -1));
            }
            set
            {
                _dataRow[COLUMN_PPT_AUTOID] = GetSafeObjectValue(value, -1);
            }
        }
        public Nullable<Int16> SMT_AUTOID
        {
            get
            {
                return ConvertToInt16(GetSafeObjectValue(_dataRow[COLUMN_SMT_AUTOID], -1));
            }
            set
            {
                _dataRow[COLUMN_SMT_AUTOID] = GetSafeObjectValue(value, -1);
            }
        }
        public  Nullable<int> OBJ_AUTOID
        {
            get
            {
                return ConvertToInt32(GetSafeObjectValue(_dataRow[COLUMN_OBJ_AUTOID], -1));
            }
            set
            {
                _dataRow[COLUMN_OBJ_AUTOID] = GetSafeObjectValue(value, -1);
            }
        }
        public String DEC_INVOICENO
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DEC_INVOICENO], null));
            }
            set
            {
                _dataRow[COLUMN_DEC_INVOICENO] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public DateTime DEC_INVOICEDATE
        {
            get
            {
                return Convert.ToDateTime(GetSafeObjectValue(_dataRow[COLUMN_DEC_INVOICEDATE], DateTime.MinValue));
            }
            set
            {
                _dataRow[COLUMN_DEC_INVOICEDATE] = Convert.ToDateTime(GetSafeObjectValue(value, DateTime.MinValue));
            }
        }
        public Decimal DEC_AMOUNT
        {
            get
            {
                return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DEC_AMOUNT], -1));
            }
            set
            {
                _dataRow[COLUMN_DEC_AMOUNT] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
            }
        }
        public Decimal DEC_BASEAMOUNT
        {
            get
            {
                return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DEC_BASEAMOUNT], -1));
            }
            set
            {
                _dataRow[COLUMN_DEC_BASEAMOUNT] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
            }
        }
        public String DEC_REGISTEROFFICIAL
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DEC_REGISTEROFFICIAL], null));
            }
            set
            {
                _dataRow[COLUMN_DEC_REGISTEROFFICIAL] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public  Nullable<int> OBJ_HANDLE
        {
            get
            {
                return ConvertToInt32(GetSafeObjectValue(_dataRow[COLUMN_OBJ_HANDLE], -1));
            }
            set
            {
                _dataRow[COLUMN_OBJ_HANDLE] = GetSafeObjectValue(value, -1);
            }
        }
        public String DEC_IMPORTHARBOUR
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DEC_IMPORTHARBOUR], null));
            }
            set
            {
                _dataRow[COLUMN_DEC_IMPORTHARBOUR] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public String DEC_EXPORTHARBOUR
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DEC_EXPORTHARBOUR], null));
            }
            set
            {
                _dataRow[COLUMN_DEC_EXPORTHARBOUR] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public DateTime DEC_ARRIVALDATE
        {
            get
            {
                return Convert.ToDateTime(GetSafeObjectValue(_dataRow[COLUMN_DEC_ARRIVALDATE], DateTime.MinValue));
            }
            set
            {
                _dataRow[COLUMN_DEC_ARRIVALDATE] = Convert.ToDateTime(GetSafeObjectValue(value, DateTime.MinValue));
            }
        }
        public Decimal DEC_BALANCE
        {
            get
            {
                return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DEC_BALANCE], -1));
            }
            set
            {
                _dataRow[COLUMN_DEC_BALANCE] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
            }
        }
        public String DEC_BOARDCUSTOMS
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DEC_BOARDCUSTOMS], null));
            }
            set
            {
                _dataRow[COLUMN_DEC_BOARDCUSTOMS] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public String DEC_BRANCHOFFICE
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DEC_BRANCHOFFICE], null));
            }
            set
            {
                _dataRow[COLUMN_DEC_BRANCHOFFICE] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public String DEC_DELIVERYINVOICE
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DEC_DELIVERYINVOICE], null));
            }
            set
            {
                _dataRow[COLUMN_DEC_DELIVERYINVOICE] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public DateTime DEC_DELIVERYDATE
        {
            get
            {
                return Convert.ToDateTime(GetSafeObjectValue(_dataRow[COLUMN_DEC_DELIVERYDATE], DateTime.MinValue));
            }
            set
            {
                _dataRow[COLUMN_DEC_DELIVERYDATE] = Convert.ToDateTime(GetSafeObjectValue(value, DateTime.MinValue));
            }
        }
        public String DEC_COMMUNNO
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DEC_COMMUNNO], null));
            }
            set
            {
                _dataRow[COLUMN_DEC_COMMUNNO] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public DateTime DEC_COMMUDATE
        {
            get
            {
                return Convert.ToDateTime(GetSafeObjectValue(_dataRow[COLUMN_DEC_COMMUDATE], DateTime.MinValue));
            }
            set
            {
                _dataRow[COLUMN_DEC_COMMUDATE] = Convert.ToDateTime(GetSafeObjectValue(value, DateTime.MinValue));
            }
        }
        public String DEC_COMMUNCONTENT
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DEC_COMMUNCONTENT], null));
            }
            set
            {
                _dataRow[COLUMN_DEC_COMMUNCONTENT] = Convert.ToString(GetSafeObjectValue(value, null));
            }
        }
        public bool DEC_ISUSE
        {
            get
            {
                return Convert.ToBoolean(GetSafeObjectValue(_dataRow[COLUMN_DEC_ISUSE], false));
            }
            set
            {
                _dataRow[COLUMN_DEC_ISUSE] = GetSafeDBValue(value, null);
            }
        }
        public Nullable<Int16> PTE_AUTOID
        {
            get
            {
                return ConvertToInt16(GetSafeObjectValue(_dataRow[COLUMN_PTE_AUTOID], -1));
            }
            set
            {
                _dataRow[COLUMN_PTE_AUTOID] = GetSafeObjectValue(value, -1);
            }
        }
        public DateTime PTE_DUEDATE
        {
            get
            {
                return Convert.ToDateTime(GetSafeObjectValue(_dataRow[COLUMN_PTE_DUEDATE], DateTime.MinValue));
            }
            set
            {
                _dataRow[COLUMN_PTE_DUEDATE] = Convert.ToDateTime(GetSafeObjectValue(value, DateTime.MinValue));
            }
        }
        public Decimal DEC_CURRENCYRATE
        {
            get
            {
                return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DEC_CURRENCYRATE], -1));
            }
            set
            {
                _dataRow[COLUMN_DEC_CURRENCYRATE] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
            }
        }
        
        public DECLARATION(DataRow row) : base(row, TABLE_NAME) { }
        public DECLARATION(IDataReader RederObject) : base(RederObject, TABLE_NAME) { }
        public DECLARATION()
            : base(TABLE_NAME
            , COLUMN_DEC_DOCUMENTID
                    , COLUMN_DEC_ISUSE
                    , COLUMN_PTE_DUEDATE
                    , COLUMN_DEC_INVOICEDATE
                    , COLUMN_DEC_ARRIVALDATE
                    , COLUMN_DEC_COMMUDATE
                    , COLUMN_DEC_DELIVERYDATE
                    , COLUMN_DEC_BASEAMOUNT
                    , COLUMN_DEC_AMOUNT
                    , COLUMN_DEC_BALANCE
                    , COLUMN_OBJ_HANDLE
                    , COLUMN_CON_AUTOID
                    , COLUMN_OBJ_AUTOID
                    , COLUMN_DEC_COMMUNCONTENT
                    , COLUMN_DEC_IMPORTHARBOUR
                    , COLUMN_CUR_AUTOID
                    , COLUMN_FICI_AUTOID
                    , COLUMN_PTE_AUTOID
                    , COLUMN_PPT_AUTOID
                    , COLUMN_DOTY_AUTOID
                    , COLUMN_SMT_AUTOID
                    , COLUMN_DEC_INVOICENO
                    , COLUMN_DEC_BOARDCUSTOMS
                    , COLUMN_DEC_EXPORTHARBOUR
                    , COLUMN_DEC_REGISTEROFFICIAL
                    , COLUMN_DEC_COMMUNNO
                    , COLUMN_DEC_DELIVERYINVOICE
                    , COLUMN_DEC_BRANCHOFFICE
                    , COLUMN_DEC_CURRENCYRATE 
                        ) { }
    }
}