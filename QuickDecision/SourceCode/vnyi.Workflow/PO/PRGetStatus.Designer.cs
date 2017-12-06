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
    partial class PRGetStatus
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
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference2 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference3 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference4 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference5 = new System.Workflow.Activities.Rules.RuleConditionReference();
            this.codeNextStatusE = new System.Workflow.Activities.CodeActivity();
            this.codeNextStatusR = new System.Workflow.Activities.CodeActivity();
            this.codeNextStatusnot = new System.Workflow.Activities.CodeActivity();
            this.codeNextStatusA = new System.Workflow.Activities.CodeActivity();
            this.codeNextStatusN = new System.Workflow.Activities.CodeActivity();
            this.Edit = new System.Workflow.Activities.IfElseBranchActivity();
            this.RequestEdit = new System.Workflow.Activities.IfElseBranchActivity();
            this.NotApprove = new System.Workflow.Activities.IfElseBranchActivity();
            this.Approve = new System.Workflow.Activities.IfElseBranchActivity();
            this.New = new System.Workflow.Activities.IfElseBranchActivity();
            this.PR = new System.Workflow.Activities.IfElseActivity();
            // 
            // codeNextStatusE
            // 
            this.codeNextStatusE.Name = "codeNextStatusE";
            this.codeNextStatusE.ExecuteCode += new System.EventHandler(this.codeNextStatusE_ExecuteCode);
            // 
            // codeNextStatusR
            // 
            this.codeNextStatusR.Name = "codeNextStatusR";
            this.codeNextStatusR.ExecuteCode += new System.EventHandler(this.codeNextStatusR_ExecuteCode);
            // 
            // codeNextStatusnot
            // 
            this.codeNextStatusnot.Name = "codeNextStatusnot";
            this.codeNextStatusnot.ExecuteCode += new System.EventHandler(this.codeNextStatusnot_ExecuteCode);
            // 
            // codeNextStatusA
            // 
            this.codeNextStatusA.Name = "codeNextStatusA";
            this.codeNextStatusA.ExecuteCode += new System.EventHandler(this.codeNextStatusA_ExecuteCode);
            // 
            // codeNextStatusN
            // 
            this.codeNextStatusN.Name = "codeNextStatusN";
            this.codeNextStatusN.ExecuteCode += new System.EventHandler(this.codeNextStatusN_ExecuteCode);
            // 
            // Edit
            // 
            this.Edit.Activities.Add(this.codeNextStatusE);
            ruleconditionreference1.ConditionName = "Edited";
            this.Edit.Condition = ruleconditionreference1;
            this.Edit.Name = "Edit";
            // 
            // RequestEdit
            // 
            this.RequestEdit.Activities.Add(this.codeNextStatusR);
            ruleconditionreference2.ConditionName = "RequestEdit";
            this.RequestEdit.Condition = ruleconditionreference2;
            this.RequestEdit.Name = "RequestEdit";
            // 
            // NotApprove
            // 
            this.NotApprove.Activities.Add(this.codeNextStatusnot);
            ruleconditionreference3.ConditionName = "NotApproved";
            this.NotApprove.Condition = ruleconditionreference3;
            this.NotApprove.Name = "NotApprove";
            // 
            // Approve
            // 
            this.Approve.Activities.Add(this.codeNextStatusA);
            ruleconditionreference4.ConditionName = "Approved";
            this.Approve.Condition = ruleconditionreference4;
            this.Approve.Name = "Approve";
            // 
            // New
            // 
            this.New.Activities.Add(this.codeNextStatusN);
            ruleconditionreference5.ConditionName = "New";
            this.New.Condition = ruleconditionreference5;
            this.New.Name = "New";
            // 
            // PR
            // 
            this.PR.Activities.Add(this.New);
            this.PR.Activities.Add(this.Approve);
            this.PR.Activities.Add(this.NotApprove);
            this.PR.Activities.Add(this.RequestEdit);
            this.PR.Activities.Add(this.Edit);
            this.PR.Name = "PR";
            // 
            // PRGetStatus
            // 
            this.Activities.Add(this.PR);
            this.Name = "PRGetStatus";
            this.Initialized += new System.EventHandler(this.Init);
            this.CanModifyActivities = false;

        }

        #endregion

        private CodeActivity codeNextStatusA;
        private IfElseBranchActivity Edit;
        private IfElseBranchActivity RequestEdit;
        private IfElseBranchActivity NotApprove;
        private IfElseBranchActivity Approve;
        private IfElseBranchActivity New;
        private CodeActivity codeNextStatusE;
        private CodeActivity codeNextStatusR;
        private CodeActivity codeNextStatusnot;
        private CodeActivity codeNextStatusN;
        private IfElseActivity PR;
























































    }
}
