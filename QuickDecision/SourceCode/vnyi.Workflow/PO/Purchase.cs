using System;
using System.Data;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
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
using vnyi.Library.PO;
using vnyi.Library.SO;
using vnyi.Library.RQ;
using vnyi.Library.DOC;
using vnyi.Library.COMON.IV;

namespace vnyi.Workflow
{
    public sealed partial class Purchase : SequentialWorkflowActivity
    {
        private int _ObjID;

        private long _IDResult = -1;
        private string _Description = "";

        private object _ObjParent = null;

        public List<PURORDERDETAIL> lPURORDERDETAIL = null;
        private short _CurID = -1;
        private Status _Status;

        public eziposModule Module { get; set; }
        public string ListIDDetail { get; set; }
        public DOCOFTYPE DocType { get; set; }
        public int ObjID
        {
            get { return _ObjID; }
            set { _ObjID = value; }
        }

        public string Des
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public object ObjParent
        {
            get { return _ObjParent; }
            set { _ObjParent = value; }
        }

        public short CurID
        {
            get { return _CurID; }
            set { _CurID = value; }
        }

        public Status Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public long IDResult
        {
            get { return _IDResult; }
        }
        public Purchase()
        {
            InitializeComponent();
        }
        public Purchase(object obj, Status sta, short cur, eziposModule mod, string listID, DOCOFTYPE doctype, string des)
        {
            InitializeComponent();
            _ObjParent = obj;
            Module = mod;
            _Status = sta;
            _CurID = cur;
            ListIDDetail = listID;
            DocType = doctype;
            _Description = des;

        }
        #region Condition

        private void ConditionPOAprove(object sender, ConditionalEventArgs e)
        {
            if (Module == eziposModule.PO)
            {
                switch (Status)
                {
                    case Status.Approved:
                        e.Result = true;
                        break;
                    case Status.CreateInvoice:
                        e.Result = true;
                        break;

                    default:
                        e.Result = false;
                        break;

                }
            }
            else if (Module == eziposModule.PROSEPAY || Module == eziposModule.IV)
            {
                e.Result = true;
            }
            else
                e.Result = false;
        }
        private void ConditionMakeInvoice(object sender, ConditionalEventArgs e)
        {
            if (Module == eziposModule.PROSEPAY)
            {
                switch (Status)
                {
                    case Status.CreateInvoice:
                        e.Result = true;
                        break;
                    default:
                        e.Result = false;
                        break;

                }
            }
        }

        private void ConditionPROPOSEPAYMENTAprove(object sender, ConditionalEventArgs e)
        {
            if (Module == eziposModule.PROSEPAY)
            {
                switch (Status)
                {
                    case Status.CreateInvoice:
                        e.Result = true;
                        break;
                    case Status.Approved:
                        e.Result = true;
                        break;
                    case Status.CreateProposepayment:
                        e.Result = true;
                        break;

                    default:
                        e.Result = false;
                        break;

                }
            }
        }
        private void ConditionMakePROPOSEPAYMENT(object sender, ConditionalEventArgs e)
        {
            if (Module == eziposModule.PROSEPAY)
            {
                switch (Status)
                {
                    case Status.CreateProposepayment:
                        e.Result = true;
                        break;

                    default:
                        e.Result = false;
                        break;

                }
            }
        }
        #endregion Condition

        #region ExecuteCode

        private void codeMakePROPOSEPAYMENT_ExecuteCode(object sender, EventArgs e)
        {
              

        }
        private void codeMakeInvoice_ExecuteCode(object sender, EventArgs e)
        {
            PUBDOCUMENT PUBDOCUMENT = (PUBDOCUMENT)ObjParent;
            if (PUBDOCUMENT != null && PUBDOCUMENT.DOC_DOCUMENTID > 0)
            {
                PUBDOCUMENT.DOC_ISACTIVE = true;
                PUBDOCUMENT.DOC_DOCUMENTDATE = DateTime.Now;
                PUBDOCUMENT.DOC_LASTUPDATE = DateTime.Now;
                PUBDOCUMENT.DOC_DOCUMENTNO = DOCUMENTCONFIGIDDAO.getVoucher((short)eziposModule.IV);

                long DOCID = PUBDOCUMENTDAO.Insert(PUBDOCUMENT, true);
                if (DOCID > 0)
                {
                    INVOICE newInvoice = new INVOICE();
                    newInvoice.OBJ_AUTOID = PUBDOCUMENT.DOC_CREATEBY;
                    newInvoice.CUR_AUTOID = CurID;
                    newInvoice.IV_DOCUMENTNUM = PUBDOCUMENT.DOC_DOCUMENTNO;
                    newInvoice.IV_DOCUMENTID = DOCID;
                    newInvoice.ST_AUTOID = (short)Status.Draft;
                    if (DocType == DOCOFTYPE.AP || DocType == DOCOFTYPE.Payment)
                        newInvoice.DOTY_AUTOID = (short)DOCOFTYPE.Buy;
                    else if (DocType == DOCOFTYPE.AR || DocType == DOCOFTYPE.Receive)
                        newInvoice.DOTY_AUTOID = (short)DOCOFTYPE.Sale;
                    // newInvoice.DOTY_AUTOID =

                    if (INVOICEDAO.InserttoTemp(newInvoice))
                    {
                        DOCUMENTRELATION rltdoc = new DOCUMENTRELATION();
                        rltdoc.DJ_DOPARENTID = PUBDOCUMENT.DOC_DOCUMENTID;
                        rltdoc.DJ_DOCUMENTID = DOCID;
                        if (DOCUMENTRELATIONDAO.Insert(rltdoc, true))
                        {
                            if (ListIDDetail.TrimEnd(';').Length > 0)
                            {
                                DataSet ds = null;
                                if (DocType == DOCOFTYPE.AP || DocType == DOCOFTYPE.Payment)
                                //if (rdoPayment.Checked | rdoAP.Checked)
                                {
                                    ds = PUBPROPOSEPAYDAO.GetDetailPOSO(ListIDDetail.TrimEnd(';'), true);
                                    if (ds != null && ds.Tables.Count > 0)
                                    {
                                        foreach (DataRow dr in ds.Tables[0].Rows)
                                        {
                                            try
                                            {
                                                INVOICEDETAIL ivd = new INVOICEDETAIL();
                                                ivd.IV_DOCUMENTID = DOCID;
                                                ivd.ITT_AUTOID = clsFormat.Int16Convert(dr[SALDETAIL.COLUMN_ITT_AUTOID]);
                                                ivd.PIT_AUTOID = clsFormat.IntConvert(dr[SALDETAIL.COLUMN_PIT_AUTOID]);
                                                //ivd.PIT_ITEMNO = clsFormat.StringConvert(dr[SALDETAIL.COLUMN_SALD_ITEMNO]);
                                                //ivd.PIT_ITEMNAME = clsFormat.StringConvert(dr[SALDETAIL.COLUMN_SALD_ITEMNAME]);
                                                ivd.IVD_QUANTITYREAL = clsFormat.DecimalConvert(dr[SALDETAIL.COLUMN_SALD_QUANTITY]);
                                                //ivd.IVD_UOM = clsFormat.Int16Convert(dr[SALDETAIL.COLUMN_SALD_UOM]);
                                                ivd.IVD_UNITPRICE = clsFormat.DecimalConvert(dr[SALDETAIL.COLUMN_SALD_UNITPRICE]);
                                                ivd.IVD_TOTALAMOUNT = clsFormat.DecimalConvert(dr[SALDETAIL.COLUMN_SALD_TOTALAMOUNT]);
                                                //ivd.IVD_PERCENTTAX = clsFormat.DecimalConvert(dr[SALDETAIL.COLUMN_SALD_TAXPERCENT]);
                                                ivd.IVD_REDUCEPER = clsFormat.DecimalConvert(dr[SALDETAIL.COLUMN_SALD_PERREDUCE]);
                                                //ivd.IVD_REDUCEMONEY = clsFormat.DecimalConvert(dr[SALDETAIL.]);
                                                ivd.COT_AUTOID = clsFormat.IntConvert(dr[SALDETAIL.COLUMN_COT_AUTOID]);
                                                //ivd.IVD_SOPO = clsFormat.Int64Convert(dr[SALDETAIL.COLUMN_SO_DOCUMENTID]);
                                                // ivd.ITET_AUTOID = clsFormat.Int16Convert(getValueNodeAt(xml, INVOICEDETAIL.COLUMN_ITET_AUTOID));
                                                //ivd.IVD_ISACTIVE = true;
                                                INVOICEDETAILDAO.InserttoTemp(ivd);


                                            }
                                            catch (Exception ex)
                                            {
                                                continue;
                                            }
                                        }
                                    }
                                }
                                else if (DocType == DOCOFTYPE.AR || DocType == DOCOFTYPE.Receive)
                                //else if (rdoAR.Checked | rdoReceive.Checked)
                                {
                                    ds = PUBPROPOSEPAYDAO.GetDetailPOSO(ListIDDetail.TrimEnd(';'), false);
                                    if (ds != null && ds.Tables.Count > 0)
                                    {
                                        foreach (DataRow dr in ds.Tables[0].Rows)
                                        {
                                            try
                                            {
                                                INVOICEDETAIL ivd = new INVOICEDETAIL();
                                                ivd.IV_DOCUMENTID = DOCID;
                                                ivd.PIT_AUTOID = clsFormat.IntConvert(dr[PURORDERDETAIL.COLUMN_PIT_AUTOID]);
                                                ivd.PIT_ITEMNO = clsFormat.StringConvert(dr[PURORDERDETAIL.COLUMN_PIT_ITEMNO]);
                                                ivd.PIT_ITEMNAME = clsFormat.StringConvert(dr[PURORDERDETAIL.COLUMN_PIT_ITEMNAME]);
                                                //ivd.IVD_UOM = clsFormat.Int16Convert(dr[PURORDERDETAIL.COLUMN_POD_IVUOM]);
                                                ivd.IVD_UNITPRICE = clsFormat.DecimalConvert(dr[PURORDERDETAIL.COLUMN_POD_UNITPRICE]);
                                                ivd.IVD_TOTALAMOUNT = clsFormat.DecimalConvert(dr[PURORDERDETAIL.COLUMN_POD_TOTALAMOUNT]);
                                                //ivd.IVD_PERCENTTAX = clsFormat.DecimalConvert(dr[PURORDERDETAIL.COLUMN_POD_TAXPERCENT]);
                                                ivd.IVD_REDUCEPER = clsFormat.DecimalConvert(dr[PURORDERDETAIL.COLUMN_POD_PERREDUCE]);
                                                //ivd.IVD_REDUCEMONEY = clsFormat.DecimalConvert(dr[PURORDERDETAIL.COLUMN_POD_REDUCEAMOUNT]);
                                                ivd.COT_AUTOID = clsFormat.IntConvert(dr[PURORDERDETAIL.COLUMN_COT_AUTOID]);
                                                //ivd.IVD_SOPO = clsFormat.Int64Convert(dr[PURORDERDETAIL.COLUMN_PURO_DOCUMENTID]);
                                                // ivd.ITET_AUTOID = clsFormat.Int16Convert(getValueNodeAt(xml, INVOICEDETAIL.COLUMN_ITET_AUTOID));
                                                //ivd.IVD_ISACTIVE = true;
                                                INVOICEDETAILDAO.InserttoTemp(ivd);
                                            }
                                            catch (Exception ex)
                                            {
                                                continue;
                                            }
                                        }
                                    }
                                }


                            }
                            if (INVOICEDAO.insertIVtoReal(newInvoice.IV_DOCUMENTID))
                            {
                                _IDResult = DOCID;
                            }
                        }
                    }
                }
            }
        }

        private void codeNotMakeInvoice_ExecuteCode(object sender, EventArgs e)
        {

        }


        #endregion ExecuteCode
    }

}
