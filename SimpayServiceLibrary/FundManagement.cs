using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FundManagementLib;
using SimpayServiceLibrary.Models;

namespace SimpayServiceLibrary
{
    public class FundManagement:IFundManagement
    {
        public bool ProcessingDistributeSMS(SMSModel sms)
        {
            return true;
        }
    }
}
