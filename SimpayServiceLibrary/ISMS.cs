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
using SimpayServiceLibrary.Models;

namespace SimpayServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISMS" in both code and config file together.
    [ServiceContract]
    public interface ISMS
    {
        [OperationContract]
        bool InsertSms(SMSModel obj);

        [OperationContract]
        List<SMSModel> ListSms();

        [OperationContract]
        DataSet SearchSms(DateTime FromDate, DateTime ToDate);
    }
}
