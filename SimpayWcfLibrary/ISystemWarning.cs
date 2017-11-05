﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpayWcfLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISystemWarning" in both code and config file together.
    [ServiceContract]
    public interface ISystemWarning
    {
        [OperationContract]
        void Balance_Simpay(Int64 providerID, decimal balance);
    }
}