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

namespace vnyi.Workflow.PO
{
    partial class POWorkFlow
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
            System.Workflow.Activities.CodeCondition codecondition5 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition6 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.CodeCondition codecondition7 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference2 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.CodeCondition codecondition8 = new System.Workflow.Activities.CodeCondition();
            this.codeActivityPROSEPAYMakeInvoice = new System.Workflow.Activities.CodeActivity();
            this.PROSEPAYApproveDoNothing = new System.Workflow.Activities.IfElseBranchActivity();
            this.PROSEPAYMakeInvoice = new System.Workflow.Activities.IfElseBranchActivity();
            this.PAYRApproveActivity = new System.Workflow.Activities.IfElseActivity();
            this.NotPROSEPAY = new System.Workflow.Activities.IfElseBranchActivity();
            this.PROSEPAYApprove = new System.Workflow.Activities.IfElseBranchActivity();
            this.ProposePayment = new System.Workflow.Activities.IfElseActivity();
            this.codeActivityPOMakeProposePayment = new System.Workflow.Activities.CodeActivity();
            this.codeActivityPOMakeContract = new System.Workflow.Activities.CodeActivity();
            this.codeActivityPOMakeInvoice = new System.Workflow.Activities.CodeActivity();
            this.POMakeProposePayment = new System.Workflow.Activities.IfElseBranchActivity();
            this.POMakeContract = new System.Workflow.Activities.IfElseBranchActivity();
            this.POMakeInvoice = new System.Workflow.Activities.IfElseBranchActivity();
            this.ifMakePP = new System.Workflow.Activities.IfElseActivity();
            this.ifElseActivity2 = new System.Workflow.Activities.IfElseActivity();
            this.ifElseActivity1 = new System.Workflow.Activities.IfElseActivity();
            this.codeActivityPRMakePO = new System.Workflow.Activities.CodeActivity();
            this.sequenceActivity3 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity2 = new System.Workflow.Activities.SequenceActivity();
            this.sequenceActivity1 = new System.Workflow.Activities.SequenceActivity();
            this.PRApproveDoNothing = new System.Workflow.Activities.IfElseBranchActivity();
            this.PRMakePO = new System.Workflow.Activities.IfElseBranchActivity();
            this.POApproveActivity = new System.Workflow.Activities.ParallelActivity();
            this.faultHandlersActivity1 = new System.Workflow.ComponentModel.FaultHandlersActivity();
            this.PRApproveActivity = new System.Workflow.Activities.IfElseActivity();
            this.NotPO = new System.Workflow.Activities.IfElseBranchActivity();
            this.POAppove = new System.Workflow.Activities.IfElseBranchActivity();
            this.NotPR = new System.Workflow.Activities.IfElseBranchActivity();
            this.PRApprove = new System.Workflow.Activities.IfElseBranchActivity();
            this.PO = new System.Workflow.Activities.IfElseActivity();
            this.PR = new System.Workflow.Activities.IfElseActivity();
            // 
            // codeActivityPROSEPAYMakeInvoice
            // 
            this.codeActivityPROSEPAYMakeInvoice.Name = "codeActivityPROSEPAYMakeInvoice";
            this.codeActivityPROSEPAYMakeInvoice.ExecuteCode += new System.EventHandler(this.codeActivityPAYRMakeInvoice_ExecuteCode);
            // 
            // PROSEPAYApproveDoNothing
            // 
            this.PROSEPAYApproveDoNothing.Name = "PROSEPAYApproveDoNothing";
            // 
            // PROSEPAYMakeInvoice
            // 
            this.PROSEPAYMakeInvoice.Activities.Add(this.codeActivityPROSEPAYMakeInvoice);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPROSEPAYMakeInvoice);
            this.PROSEPAYMakeInvoice.Condition = codecondition1;
            this.PROSEPAYMakeInvoice.Name = "PROSEPAYMakeInvoice";
            // 
            // PAYRApproveActivity
            // 
            this.PAYRApproveActivity.Activities.Add(this.PROSEPAYMakeInvoice);
            this.PAYRApproveActivity.Activities.Add(this.PROSEPAYApproveDoNothing);
            this.PAYRApproveActivity.Name = "PAYRApproveActivity";
            // 
            // NotPROSEPAY
            // 
            this.NotPROSEPAY.Name = "NotPROSEPAY";
            // 
            // PROSEPAYApprove
            // 
            this.PROSEPAYApprove.Activities.Add(this.PAYRApproveActivity);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPROSEPAYApprove);
            this.PROSEPAYApprove.Condition = codecondition2;
            this.PROSEPAYApprove.Name = "PROSEPAYApprove";
            // 
            // ProposePayment
            // 
            this.ProposePayment.Activities.Add(this.PROSEPAYApprove);
            this.ProposePayment.Activities.Add(this.NotPROSEPAY);
            this.ProposePayment.Name = "ProposePayment";
            // 
            // codeActivityPOMakeProposePayment
            // 
            this.codeActivityPOMakeProposePayment.Name = "codeActivityPOMakeProposePayment";
            this.codeActivityPOMakeProposePayment.ExecuteCode += new System.EventHandler(this.codeActivityPOMakePaymentReQuest_ExecuteCode);
            // 
            // codeActivityPOMakeContract
            // 
            this.codeActivityPOMakeContract.Name = "codeActivityPOMakeContract";
            this.codeActivityPOMakeContract.ExecuteCode += new System.EventHandler(this.codeActivityPOMakeContract_ExecuteCode);
            // 
            // codeActivityPOMakeInvoice
            // 
            this.codeActivityPOMakeInvoice.Name = "codeActivityPOMakeInvoice";
            this.codeActivityPOMakeInvoice.ExecuteCode += new System.EventHandler(this.codeActivityPOMakeInvoice_ExecuteCode);
            // 
            // POMakeProposePayment
            // 
            this.POMakeProposePayment.Activities.Add(this.codeActivityPOMakeProposePayment);
            this.POMakeProposePayment.Activities.Add(this.ProposePayment);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPOMakePROSEPAY);
            this.POMakeProposePayment.Condition = codecondition3;
            this.POMakeProposePayment.Name = "POMakeProposePayment";
            // 
            // POMakeContract
            // 
            this.POMakeContract.Activities.Add(this.codeActivityPOMakeContract);
            codecondition4.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPOMakeContract);
            this.POMakeContract.Condition = codecondition4;
            this.POMakeContract.Name = "POMakeContract";
            // 
            // POMakeInvoice
            // 
            this.POMakeInvoice.Activities.Add(this.codeActivityPOMakeInvoice);
            codecondition5.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPOMakeInvoice);
            this.POMakeInvoice.Condition = codecondition5;
            this.POMakeInvoice.Name = "POMakeInvoice";
            // 
            // ifMakePP
            // 
            this.ifMakePP.Activities.Add(this.POMakeProposePayment);
            this.ifMakePP.Name = "ifMakePP";
            // 
            // ifElseActivity2
            // 
            this.ifElseActivity2.Activities.Add(this.POMakeContract);
            this.ifElseActivity2.Name = "ifElseActivity2";
            // 
            // ifElseActivity1
            // 
            this.ifElseActivity1.Activities.Add(this.POMakeInvoice);
            this.ifElseActivity1.Name = "ifElseActivity1";
            // 
            // codeActivityPRMakePO
            // 
            this.codeActivityPRMakePO.Name = "codeActivityPRMakePO";
            this.codeActivityPRMakePO.ExecuteCode += new System.EventHandler(this.codeActivityPRMakePO_ExecuteCode);
            // 
            // sequenceActivity3
            // 
            this.sequenceActivity3.Activities.Add(this.ifMakePP);
            this.sequenceActivity3.Name = "sequenceActivity3";
            // 
            // sequenceActivity2
            // 
            this.sequenceActivity2.Activities.Add(this.ifElseActivity2);
            this.sequenceActivity2.Name = "sequenceActivity2";
            // 
            // sequenceActivity1
            // 
            this.sequenceActivity1.Activities.Add(this.ifElseActivity1);
            this.sequenceActivity1.Name = "sequenceActivity1";
            // 
            // PRApproveDoNothing
            // 
            this.PRApproveDoNothing.Name = "PRApproveDoNothing";
            // 
            // PRMakePO
            // 
            this.PRMakePO.Activities.Add(this.codeActivityPRMakePO);
            codecondition6.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPRMakePO);
            this.PRMakePO.Condition = codecondition6;
            this.PRMakePO.Name = "PRMakePO";
            // 
            // POApproveActivity
            // 
            this.POApproveActivity.Activities.Add(this.sequenceActivity1);
            this.POApproveActivity.Activities.Add(this.sequenceActivity2);
            this.POApproveActivity.Activities.Add(this.sequenceActivity3);
            this.POApproveActivity.Name = "POApproveActivity";
            // 
            // faultHandlersActivity1
            // 
            this.faultHandlersActivity1.Name = "faultHandlersActivity1";
            // 
            // PRApproveActivity
            // 
            this.PRApproveActivity.Activities.Add(this.PRMakePO);
            this.PRApproveActivity.Activities.Add(this.PRApproveDoNothing);
            this.PRApproveActivity.Name = "PRApproveActivity";
            // 
            // NotPO
            // 
            ruleconditionreference1.ConditionName = "POEdited";
            this.NotPO.Condition = ruleconditionreference1;
            this.NotPO.Name = "NotPO";
            // 
            // POAppove
            // 
            this.POAppove.Activities.Add(this.POApproveActivity);
            codecondition7.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPOApprove);
            this.POAppove.Condition = codecondition7;
            this.POAppove.Name = "POAppove";
            // 
            // NotPR
            // 
            ruleconditionreference2.ConditionName = "PRClose";
            this.NotPR.Condition = ruleconditionreference2;
            this.NotPR.Name = "NotPR";
            // 
            // PRApprove
            // 
            this.PRApprove.Activities.Add(this.PRApproveActivity);
            this.PRApprove.Activities.Add(this.faultHandlersActivity1);
            codecondition8.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.ConditionPRApprove);
            this.PRApprove.Condition = codecondition8;
            this.PRApprove.Name = "PRApprove";
            // 
            // PO
            // 
            this.PO.Activities.Add(this.POAppove);
            this.PO.Activities.Add(this.NotPO);
            this.PO.Name = "PO";
            // 
            // PR
            // 
            this.PR.Activities.Add(this.PRApprove);
            this.PR.Activities.Add(this.NotPR);
            this.PR.Name = "PR";
            // 
            // POWorkFlow
            // 
            this.Activities.Add(this.PR);
            this.Activities.Add(this.PO);
            this.Name = "POWorkFlow";
            this.CanModifyActivities = false;

        }

        #endregion

        private IfElseBranchActivity NotPR;
        private IfElseBranchActivity NotPO;
        private FaultHandlersActivity faultHandlersActivity1;
        private SequenceActivity sequenceActivity2;
        private SequenceActivity sequenceActivity1;
        private ParallelActivity POApproveActivity;
        private CodeActivity codeActivityPOMakeContract;
        private CodeActivity codeActivityPOMakeInvoice;
        private IfElseBranchActivity POMakeContract;
        private IfElseBranchActivity POMakeInvoice;
        private IfElseActivity ifElseActivity2;
        private IfElseActivity ifElseActivity1;
        private SequenceActivity sequenceActivity3;
        private IfElseBranchActivity PRApproveDoNothing;
        private IfElseBranchActivity PRMakePO;
        private IfElseActivity PRApproveActivity;
        private IfElseBranchActivity PRApprove;
        private CodeActivity codeActivityPRMakePO;
        private IfElseBranchActivity POAppove;
        private IfElseActivity PO;
        private IfElseActivity ifMakePP;
        private IfElseBranchActivity POMakeProposePayment;
        private CodeActivity codeActivityPOMakeProposePayment;
        private IfElseBranchActivity NotPROSEPAY;
        private IfElseBranchActivity PROSEPAYApprove;
        private IfElseActivity ProposePayment;
        private IfElseBranchActivity PROSEPAYApproveDoNothing;
        private IfElseBranchActivity PROSEPAYMakeInvoice;
        private IfElseActivity PAYRApproveActivity;
        private CodeActivity codeActivityPROSEPAYMakeInvoice;
        private IfElseActivity PR;



















































































































































    }
}
