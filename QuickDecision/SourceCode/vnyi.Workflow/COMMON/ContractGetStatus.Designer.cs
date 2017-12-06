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
    partial class ContractGetStatus
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
            this.codeNextStatusD = new System.Workflow.Activities.CodeActivity();
            this.codeNextStatusP = new System.Workflow.Activities.CodeActivity();
            this.codeNextStatusW = new System.Workflow.Activities.CodeActivity();
            this.codeNextStatusL = new System.Workflow.Activities.CodeActivity();
            this.codeNextStatusN = new System.Workflow.Activities.CodeActivity();
            this.Dissolve = new System.Workflow.Activities.IfElseBranchActivity();
            this.sExecuting = new System.Workflow.Activities.IfElseBranchActivity();
            this.WaitForLiquidate = new System.Workflow.Activities.IfElseBranchActivity();
            this.Liquidated = new System.Workflow.Activities.IfElseBranchActivity();
            this.New = new System.Workflow.Activities.IfElseBranchActivity();
            this.Contract = new System.Workflow.Activities.IfElseActivity();
            // 
            // codeNextStatusD
            // 
            this.codeNextStatusD.Name = "codeNextStatusD";
            this.codeNextStatusD.ExecuteCode += new System.EventHandler(this.codeNextStatusC_ExecuteCode);
            // 
            // codeNextStatusP
            // 
            this.codeNextStatusP.Name = "codeNextStatusP";
            this.codeNextStatusP.ExecuteCode += new System.EventHandler(this.codeNextStatusE_ExecuteCode);
            // 
            // codeNextStatusW
            // 
            this.codeNextStatusW.Name = "codeNextStatusW";
            this.codeNextStatusW.ExecuteCode += new System.EventHandler(this.codeNextStatusW_ExecuteCode);
            // 
            // codeNextStatusL
            // 
            this.codeNextStatusL.Name = "codeNextStatusL";
            this.codeNextStatusL.ExecuteCode += new System.EventHandler(this.codeNextStatusL_ExecuteCode);
            // 
            // codeNextStatusN
            // 
            this.codeNextStatusN.Name = "codeNextStatusN";
            this.codeNextStatusN.ExecuteCode += new System.EventHandler(this.codeNextStatusN_ExecuteCode);
            // 
            // Dissolve
            // 
            this.Dissolve.Activities.Add(this.codeNextStatusD);
            ruleconditionreference1.ConditionName = "Dissolve";
            this.Dissolve.Condition = ruleconditionreference1;
            this.Dissolve.Name = "Dissolve";
            // 
            // sExecuting
            // 
            this.sExecuting.Activities.Add(this.codeNextStatusP);
            ruleconditionreference2.ConditionName = "Executing";
            this.sExecuting.Condition = ruleconditionreference2;
            this.sExecuting.Name = "sExecuting";
            // 
            // WaitForLiquidate
            // 
            this.WaitForLiquidate.Activities.Add(this.codeNextStatusW);
            ruleconditionreference3.ConditionName = "WaitForLiquidate";
            this.WaitForLiquidate.Condition = ruleconditionreference3;
            this.WaitForLiquidate.Name = "WaitForLiquidate";
            // 
            // Liquidated
            // 
            this.Liquidated.Activities.Add(this.codeNextStatusL);
            ruleconditionreference4.ConditionName = "Liquidated";
            this.Liquidated.Condition = ruleconditionreference4;
            this.Liquidated.Name = "Liquidated";
            // 
            // New
            // 
            this.New.Activities.Add(this.codeNextStatusN);
            ruleconditionreference5.ConditionName = "New";
            this.New.Condition = ruleconditionreference5;
            this.New.Name = "New";
            // 
            // Contract
            // 
            this.Contract.Activities.Add(this.New);
            this.Contract.Activities.Add(this.Liquidated);
            this.Contract.Activities.Add(this.WaitForLiquidate);
            this.Contract.Activities.Add(this.sExecuting);
            this.Contract.Activities.Add(this.Dissolve);
            this.Contract.Name = "Contract";
            // 
            // ContractGetStatus
            // 
            this.Activities.Add(this.Contract);
            this.Name = "ContractGetStatus";
            this.Initialized += new System.EventHandler(this.Init);
            this.CanModifyActivities = false;

        }

        #endregion

        private CodeActivity codeNextStatusL;
        private IfElseBranchActivity Dissolve;
        private IfElseBranchActivity sExecuting;
        private IfElseBranchActivity WaitForLiquidate;
        private IfElseBranchActivity Liquidated;
        private IfElseBranchActivity New;
        private CodeActivity codeNextStatusD;
        private CodeActivity codeNextStatusP;
        private CodeActivity codeNextStatusW;
        private CodeActivity codeNextStatusN;
        private IfElseActivity Contract;












































































    }
}
