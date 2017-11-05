using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WarningLibrary;

namespace SimpayServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SystemWarning" in both code and config file together.
    public class SystemWarning : ISystemWarning
    {
        public void Balance_Simpay(long providerID, decimal balance)
        {
            Helpers.Connection.sConnectionStringDatabase = "Data Source=192.168.1.11,1433;Initial Catalog=SYSTEMWARNING;Connect Timeout=200;User id=sa;Password=@sp123456";
            WarningLibrary.SystemWarning sw = new WarningLibrary.SystemWarning();
            //sw.Balance_Simpay(providerID, balance);
        }
    }
}
