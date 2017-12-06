using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace vnyi.Workflow
{
    partial class Purchase
    {
        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition4 = new System.Workflow.Activities.CodeCondition();
            this.codeNotMakeInvoice = new System.Workflow.Activities.CodeActivity();
            this.codeMakeInvoice = new System.Workflow.Activities.CodeActivity();
            this.NotMakeInvoice = new System.Workflow.Activities.IfElseBranchActivity();
            this.DoMakeInvoice = new System.Workflow.Activities.IfElseBranchActivity();
            this.MakeInvoice = new System.Workflow.Activities.IfElseActivity();
            this.codeMasePROPOSEPAYMENT = new System.Workflow.Activities.CodeActivity();
            this.PROPOSEPAYMENTNotAprove = new System.Workflow.Activities.IfElseBranchActivity();
            this.PROPOSEPAYMENTAprove = new System.Workflow.Activities.IfElseBranchActivity();
            this.NotMakePROPOSEPAYMENT = new System.Workflow.Activities.IfElseBranchActivity();
            this.DoMakePROPOSEPAYMENT = new System.Workflow.Activities.IfElseBranchActivity();
            this.PROPOSEPAYMENT = new System.Workflow.Activities.IfElseActivity();
            this.MakePROPOSEPAYMENT = new System.Workflow.Activities.IfElseActivity();
            this.PONotAprove = new System.Workflow.Activities.IfElseBranchActivity();
            this.POAprove = new System.Workflow.Activities.IfElseBranchActivity();
            this.PO = new System.Workflow.Activities.IfElseActivity();
            // 
            // codeNotMakeInvoice
            // 
            this.codeNotMakeInvoice.Name = "codeNotMakeInvoice";
            this.codeNotMakeInvoice.ExecuteCode += new System.EventHandler(this.codeNotMakeInvoice_ExecuteCode);
            // 
            // codeMakeInvoice
            // 
            this.codeMakeInvoice.Name = "codeMakeInvoice";
            this.codeMakeInvoice.ExecuteCode += new System.EventHandler(this.codeMakeInvoice_ExecuteCode);
            // 
            // NotMakeInvoice
            // 
            this.NotMakeInvoice.Activities.Add(this.codeNotMakeInvoice);
            this.NotMakeInvoice.Name = "NotMakeInvoice";
            // 
            // DoMakeInvoice
            // 
            this.DoMakeInvoice.Activities.Add(this.codeMakeInvoice);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionMakeInvoice);
            this.DoMakeInvoice.Condition = codecondition1;
            this.DoMakeInvoice.Name = "DoMakeInvoice";
            // 
            // MakeInvoice
            // 
            this.MakeInvoice.Activities.Add(this.DoMakeInvoice);
            this.MakeInvoice.Activities.Add(this.NotMakeInvoice);
            this.MakeInvoice.Name = "MakeInvoice";
            // 
            // codeMasePROPOSEPAYMENT
            // 
            this.codeMasePROPOSEPAYMENT.Name = "codeMasePROPOSEPAYMENT";
            this.codeMasePROPOSEPAYMENT.ExecuteCode += new System.EventHandler(this.codeMakePROPOSEPAYMENT_ExecuteCode);
            // 
            // PROPOSEPAYMENTNotAprove
            // 
            this.PROPOSEPAYMENTNotAprove.Name = "PROPOSEPAYMENTNotAprove";
            // 
            // PROPOSEPAYMENTAprove
            // 
            this.PROPOSEPAYMENTAprove.Activities.Add(this.MakeInvoice);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPROPOSEPAYMENTAprove);
            this.PROPOSEPAYMENTAprove.Condition = codecondition2;
            this.PROPOSEPAYMENTAprove.Name = "PROPOSEPAYMENTAprove";
            // 
            // NotMakePROPOSEPAYMENT
            // 
            this.NotMakePROPOSEPAYMENT.Name = "NotMakePROPOSEPAYMENT";
            // 
            // DoMakePROPOSEPAYMENT
            // 
            this.DoMakePROPOSEPAYMENT.Activities.Add(this.codeMasePROPOSEPAYMENT);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionMakePROPOSEPAYMENT);
            this.DoMakePROPOSEPAYMENT.Condition = codecondition3;
            this.DoMakePROPOSEPAYMENT.Name = "DoMakePROPOSEPAYMENT";
            // 
            // PROPOSEPAYMENT
            // 
            this.PROPOSEPAYMENT.Activities.Add(this.PROPOSEPAYMENTAprove);
            this.PROPOSEPAYMENT.Activities.Add(this.PROPOSEPAYMENTNotAprove);
            this.PROPOSEPAYMENT.Name = "PROPOSEPAYMENT";
            // 
            // MakePROPOSEPAYMENT
            // 
            this.MakePROPOSEPAYMENT.Activities.Add(this.DoMakePROPOSEPAYMENT);
            this.MakePROPOSEPAYMENT.Activities.Add(this.NotMakePROPOSEPAYMENT);
            this.MakePROPOSEPAYMENT.Name = "MakePROPOSEPAYMENT";
            // 
            // PONotAprove
            // 
            this.PONotAprove.Name = "PONotAprove";
            // 
            // POAprove
            // 
            this.POAprove.Activities.Add(this.MakePROPOSEPAYMENT);
            this.POAprove.Activities.Add(this.PROPOSEPAYMENT);
            codecondition4.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPOAprove);
            this.POAprove.Condition = codecondition4;
            this.POAprove.Name = "POAprove";
            // 
            // PO
            // 
            this.PO.Activities.Add(this.POAprove);
            this.PO.Activities.Add(this.PONotAprove);
            this.PO.Name = "PO";
            // 
            // Purchase
            // 
            this.Activities.Add(this.PO);
            this.Name = "Purchase";
            this.CanModifyActivities = false;

        }

        #endregion

        private IfElseBranchActivity PROPOSEPAYMENTNotAprove;
        private IfElseBranchActivity PROPOSEPAYMENTAprove;
        private IfElseActivity PROPOSEPAYMENT;
        private CodeActivity codeMasePROPOSEPAYMENT;
        private IfElseBranchActivity NotMakePROPOSEPAYMENT;
        private IfElseBranchActivity DoMakePROPOSEPAYMENT;
        private IfElseActivity MakePROPOSEPAYMENT;
        private IfElseBranchActivity PONotAprove;
        private IfElseBranchActivity POAprove;
        private IfElseBranchActivity NotMakeInvoice;
        private IfElseBranchActivity DoMakeInvoice;
        private IfElseActivity MakeInvoice;
        private CodeActivity codeMakeInvoice;
        private CodeActivity codeNotMakeInvoice;
        private IfElseActivity PO;

















































    }
}
