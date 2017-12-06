using System;

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

using vnyi.Utility;
using vnyi.Library.Meta.STATUS;
using vnyi.Library.PO;
using vnyi.Library.RQ;
namespace vnyi.Workflow.PO
{
    public sealed partial class POWorkFlow : SequentialWorkflowActivity
    {
        #region VARIABLE
        private Status _status;
        private string _ldocID;


        private DOCOFTYPE _docType;
        //public PUBDOCUMENT Doc;
        private eziposModule _module;
        private object _objDoc;
        private int _objID, _orgID;
        private short _curID;
        private string _des;
        private Dictionary<WorkflowPara, string> _paras;
        private List<PUBSTATUS> _pubStatus;

        public List<PUBSTATUS> pubStatus { get; set; }
        public Status ppStatus { get; set; }
        public Dictionary<WorkflowPara, string> Paras
        {
            get { return _paras; }
            set { _paras = value; }
        }
        public int OrgID
        {
            get { return _orgID; }
            set { _orgID = value; }
        }
        public string LdocID
        {
            get { return _ldocID; }
            set { _ldocID = value; }
        }
        public int ObjID
        {
            get { return _objID; }
            set { _objID = value; }
        }
        public short CurID
        {
            get { return _curID; }
            set { _curID = value; }
        }
        public string Des
        {
            get { return _des; }
            set { _des = value; }
        }
        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public DOCOFTYPE DocType
        {
            get { return _docType; }
            set { _docType = value; }
        }
        public eziposModule Module
        {
            get { return _module; }
            set { _module = value; }
        }
        public object ObjDoc
        {
            get { return _objDoc; }
            set { _objDoc = value; }
        }
        #endregion

        public POWorkFlow()
        {
            InitializeComponent();

        }

        #region CODITION
        //PR
        private void ConditionPRApprove(object sender, ConditionalEventArgs e)
        {
            e.Result = false;
            if (Module == eziposModule.PR)
            {
                if (Status == Status.Approved)
                    e.Result = true;

            }
        }
        private void ConditionPRMakePO(object sender, ConditionalEventArgs e)
        {
            e.Result = false;
            if (Module == eziposModule.PR)
            {
                if (Status == Status.Approved)
                    e.Result = true;

            }
        }
        //PO
        private void ConditionPOApprove(object sender, ConditionalEventArgs e)
        {
            e.Result = false;
            if (Module == eziposModule.PO)
            {
                if (Status == Status.Approved)
                    e.Result = true;

            }
        }
        private void ConditionPOMakeInvoice(object sender, ConditionalEventArgs e)
        {
            e.Result = false;
            if (Module == eziposModule.PO && Paras[WorkflowPara.MakeInvoce] == "1")
            {
                if (Status == Status.Approved)
                    e.Result = true;

            }
        }
        private void ConditionPOMakePROSEPAY(object sender, ConditionalEventArgs e)
        {
            e.Result = false;
            if (Module == eziposModule.PO && Paras[WorkflowPara.MakeProposePayment] == "1")
            {
                if (Status == Status.Approved)
                    e.Result = true;

            }
        }
        private void ConditionPOMakeContract(object sender, ConditionalEventArgs e)
        {
            e.Result = false;
            if (Module == eziposModule.PO && Paras[WorkflowPara.MakeContract] == "1")
            {
                if (Status == Status.Approved)
                    e.Result = true;

            }
        }
        //PaymentRequest
        private void ConditionPROSEPAYApprove(object sender, ConditionalEventArgs e)
        {
            e.Result = false;
            if (Module == eziposModule.PROSEPAY)
            {
                if (Status == Status.Approved)
                    e.Result = true;

            }
        }
        private void ConditionPROSEPAYMakeInvoice(object sender, ConditionalEventArgs e)
        {
            e.Result = false;
            if (Module == eziposModule.PROSEPAY && Paras[WorkflowPara.MakeInvoce] == "1")
            {
                if (Status == Status.Approved)
                    e.Result = true;

            }
        }



        #endregion

        #region EXUCUTECODE
        private void codeActivityPRMakePO_ExecuteCode(object sender, EventArgs e)
        {
            foreach (string str in _ldocID.Split(';'))
            {
                PURREQUESTDAO.MakePO(clsFormat.Int64ConvertNull(str), _objID, _curID, _orgID, _des);
            }
        }

        private void codeActivityPOMakeInvoice_ExecuteCode(object sender, EventArgs e)
        {
            PURORDERDAO.MakeInvoice(_ldocID, _objID, _curID, _orgID, _des);
        }

        private void codeActivityPOMakeContract_ExecuteCode(object sender, EventArgs e)
        {
            PURORDERDAO.MakeContract(_ldocID, _objID, _curID, _orgID, _des);
        }

        private void codeActivityPOMakePaymentReQuest_ExecuteCode(object sender, EventArgs e)
        {
            PURORDERDAO.MakePaymentRequest(_ldocID, _objID, _curID, _orgID, _des);
        }

        private void codeActivityPAYRMakeInvoice_ExecuteCode(object sender, EventArgs e)
        {
            PUBPROPOSEPAYDAO.MakeInvoice(_ldocID, _objID, _curID, _orgID, _des);
        }
        #endregion




    }

}
