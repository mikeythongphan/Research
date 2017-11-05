using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Librarys.CRM;
using Helpers;
using Utilities;
using System.Data;
using System.Collections;
using SMSLibrary;
using SimpayServiceLibrary.Models;
using System.Configuration;

namespace SimpayServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SMS" in both code and config file together.
    public class SMS : ISMS
    {
        /// <summary>
        /// InsertSms
        /// </summary>
        public bool InsertSms(SMSModel obj)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            SMSLibrary.SMSLibrary objSMS = new SMSLibrary.SMSLibrary();
            if (objSMS.InsertSms(obj.MappingToSMS()))
                return true;
            else return false;
        }
        /// <summary>
        /// ListSms
        /// </summary>
        public List<SMSModel> ListSms()
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.AppSettings["sConnectionString_Crm"];
            SMSLibrary.SMSLibrary objSMS = new SMSLibrary.SMSLibrary();
            var result = new List<SMSModel>();
            objSMS.ListSms().ForEach(x=>{ result.Add(new SMSModel(x)); });
            return result;
        }
        /// <summary>
        /// SearchSms
        /// </summary>
        public DataSet SearchSms(DateTime FromDate, DateTime ToDate)
        {
            Helpers.Connection.sConnectionStringDatabase = ConfigurationManager.ConnectionStrings["sConnectionString_Crm"].ConnectionString;
            SMSLibrary.SMSLibrary objSMS = new SMSLibrary.SMSLibrary();
            DataSet dtOut = objSMS.SearchSms(FromDate, ToDate);
            return dtOut;
        }
    }
}
