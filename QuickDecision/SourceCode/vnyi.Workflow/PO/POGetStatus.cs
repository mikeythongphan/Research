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

namespace vnyi.Workflow.PO
{
    public sealed partial class POGetStatus : SequentialWorkflowActivity
    {
        public List<PUBSTATUS> pubStatus { get; set; }
        private List<PUBSTATUS> _pubStatus;
        public Status ppStatus { get; set; }
        public POGetStatus()
        {
            InitializeComponent();

        }
        private void Init(object sender, EventArgs e)
        {
            _pubStatus = PUBSTATUSDAO.SelectByCondition(" ST_ISPO  = 1 ");
        }
        private void codeNextStatusN_ExecuteCode(object sender, EventArgs e)
        {
            //new
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == (short)Status.New
                                                    || st.ST_AUTOID == (short)Status.Approved
                                                    || st.ST_AUTOID == (short)Status.RequestEdit).ToList<PUBSTATUS>();
        }

        private void codeNextStatusA_ExecuteCode(object sender, EventArgs e)
        {
            //approve
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == (short)Status.Closed
                                                    || st.ST_AUTOID == (short)Status.Approved).ToList<PUBSTATUS>();
        }

        private void codeNextStatusnot_ExecuteCode(object sender, EventArgs e)
        {
            //not approve
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == (short)Status.Closed
                                                    || st.ST_AUTOID == (short)Status.Approved
                                                    || st.ST_AUTOID == (short)Status.RequestEdit
                                                    || st.ST_AUTOID == (short)Status.NotApproved).ToList<PUBSTATUS>();
        }

        private void codeNextStatusR_ExecuteCode(object sender, EventArgs e)
        {
            //request edit
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == (short)Status.Approved
                                                    || st.ST_AUTOID == (short)Status.Edited
                                                    || st.ST_AUTOID == (short)Status.RequestEdit).ToList<PUBSTATUS>();
        }

        private void codeNextStatusC_ExecuteCode(object sender, EventArgs e)
        {
            //close
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == (short)Status.Closed).ToList<PUBSTATUS>();
        }

        private void codeNextStatusE_ExecuteCode(object sender, EventArgs e)
        {
            //edit
            pubStatus = _pubStatus.Where<PUBSTATUS>(st => st.ST_AUTOID == (short)Status.RequestEdit
                                                    || st.ST_AUTOID == (short)Status.Approved
                                                    || st.ST_AUTOID == (short)Status.RequestEdit
                                                    || st.ST_AUTOID == (short)Status.NotApproved).ToList<PUBSTATUS>();
        }
    }

}
