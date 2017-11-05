using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using SimpayServiceLibrary;

namespace WcfHosts
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svcFundManagementHost = null;
            ServiceHost svcSMSHost = null;
            try
            {
                svcFundManagementHost = new ServiceHost(typeof(FundManagement));
                svcFundManagementHost.Open(); Console.WriteLine("\n\nFundManagement Service is Running  at following address");
                Console.WriteLine("\n" + svcFundManagementHost.BaseAddresses);
            }
            catch (Exception eX)
            {
                svcFundManagementHost = null;
                Console.WriteLine("FundManagement Service can not be started \n\nError Message [" + eX.Message + "]");
            } if (svcFundManagementHost != null)
            {
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
                svcFundManagementHost.Close();
                svcFundManagementHost = null;
            }

            try
            {
                svcSMSHost = new ServiceHost(typeof(SimpayServiceLibrary.SMS));
                svcSMSHost.Open();
                Console.WriteLine("\n\nSMS Service is Running  at following address");
                Console.WriteLine("\n" + svcSMSHost.BaseAddresses);
            }
            catch (Exception eX)
            {
                svcSMSHost = null;
                Console.WriteLine("SMS Service can not be started \n\nError Message [" + eX.Message + "]");
            } if (svcSMSHost != null)
            {
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
                svcSMSHost.Close();
                svcSMSHost = null;
            }       
        }
    }
}
