using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using 

namespace WcfWindowsService
{
    public partial class WcfService : ServiceBase
    {
        public WcfService()
        {
            InitializeComponent();
        }

        internal static ServiceHost wcfServiceHost = null; 

        protected override void OnStart(string[] args)
        {
            if (wcfServiceHost != null)
            {
                wcfServiceHost.Close();
            }
            wcfServiceHost = new ServiceHost(typeof(WcfService));
            wcfServiceHost.Open();
        }

        protected override void OnStop()
        {
            if (wcfServiceHost != null)
            {
                wcfServiceHost.Close();
                wcfServiceHost = null;
            }
        }
    }
}
