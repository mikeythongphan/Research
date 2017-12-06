using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using vnyi.Library.Meta.STATUS;
using vnyi.Utility;

namespace vnyi.Workflow
{
    public sealed partial class ContractGetStatus : SequentialWorkflowActivity
    {
        public List<PUBSTATUS> pubStatus { get; set; }
        private List<PUBSTATUS> _pubStatus;
        public Status ppStatus { get; set; }
        public ContractGetStatus()
        {
            InitializeComponent();

        }
        private void Init(object sender, EventArgs e)
        {
            _pubStatus = PUBSTATUSDAO.SelectByCondition(" ST_ISCONTRACT  = 1 ");
        }
        private void codeNextStatusN_ExecuteCode(object sender, EventArgs e)
        {
            //new
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == (short)Status.Executing).ToList<PUBSTATUS>();
        }

        private void codeNextStatusL_ExecuteCode(object sender, EventArgs e)
        {
            //Liquidated
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == -1).ToList<PUBSTATUS>();
        }

        private void codeNextStatusW_ExecuteCode(object sender, EventArgs e)
        {
            //Wait for Liquidated
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == (short)Status.Liquidated).ToList<PUBSTATUS>();
        }

        private void codeNextStatusE_ExecuteCode(object sender, EventArgs e)
        {
            //Executing
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == (short)Status.WaitForLiquidate
                                                    || st.ST_AUTOID == (short)Status.Dissolve).ToList<PUBSTATUS>();
        }

        private void codeNextStatusC_ExecuteCode(object sender, EventArgs e)
        {
            //Dissolve
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == -1).ToList<PUBSTATUS>();
        }

    
    }

}
