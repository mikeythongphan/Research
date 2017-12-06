using System;
using System.Collections.Generic;

using System.Data;

namespace vnyi.Library.COMON.IV
{
    public class PUBENTRYTYPE : vnyi.DLL.DataObject
    {

        public static string COLUMN_PETT_AUTOID = "PETT_AUTOID";
        public static string COLUMN_PETT_NAME = "PETT_NAME";
        public static string COLUMN_PETT_ISACTIVE = "PETT_ISACTIVE";

        public static string TABLE_NAME = "PUBENTRYTYPE";

        public Nullable<Int16> PETT_AUTOID
        {
            get
            {
                return ConvertToInt16(_dataRow[COLUMN_PETT_AUTOID]);
            }
            set
            {
                _dataRow[COLUMN_PETT_AUTOID] = value;
            }
        }
        public String PETT_NAME
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_PETT_NAME], null));
            }
            set
            {
                _dataRow[COLUMN_PETT_NAME] = value;
            }
        }
        public bool PETT_ISACTIVE
        {
            get
            {
                return ConvertToBoolean(_dataRow[COLUMN_PETT_ISACTIVE]);
            }
            set
            {
                _dataRow[COLUMN_PETT_ISACTIVE] = value;
            }
        }
        public PUBENTRYTYPE(IDataReader RederObject) : base(RederObject, TABLE_NAME) { }
        public PUBENTRYTYPE(DataRow row) : base(row, TABLE_NAME) { }
        public PUBENTRYTYPE()
            : base(TABLE_NAME, COLUMN_PETT_AUTOID,
            COLUMN_PETT_NAME,
            COLUMN_PETT_ISACTIVE
            ) { }
    }
}

