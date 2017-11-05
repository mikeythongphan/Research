using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using SimpayServiceLibrary.Models;

namespace SimpayServiceLibrary
{
    [ServiceContract]
    public interface IFundManagement
    {
        [OperationContract]
        bool ProcessingDistributeSMS(SMSModel sms);
    }
}
