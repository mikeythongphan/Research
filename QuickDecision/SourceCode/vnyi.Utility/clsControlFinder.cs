using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
//using System.Web.UI;

namespace vnyi.Utility
{
    public class ControlFinder
    {

        public string QueryString
        {
            get;
            set;
        }
        public string FieldLabel
        {
            get;
            set;
        }
        public bool IsRequest
        {
            get;
            set;
        }
        public string DefaultValue
        {
            get;
            set;
        }
        public Nullable<DataType> DataType
        {
            get;
            set;
        }
        public Nullable<ControlType> ControlType
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public bool IsControlGetValue
        {
            get;
            set;
        }
        public List<DataItem> DataSource
        {
            get;
            set;
        }
        public string DataTextField
        {
            get;
            set;
        }
        public string DataValueField
        {
            get;
            set;
        }
        public bool IsFocus
        {
            get;
            set;
        }
        /// <summary>
        /// Sự kiện chạy javascript khi Render Control nay
        /// </summary>
        public string OnRender
        {
            get;
            set;
        }
        public ControlFinder()
        {
        }

        public ControlFinder(string fieldlabel, ControlType controltype, DataType datatype, string id)
        {
            this.FieldLabel = fieldlabel;
            this.DataType = datatype;
            this.ControlType = controltype;
            this.ID = id;
        }

        public ControlFinder(string fieldlabel, ControlType controltype, DataType datatype, string id, bool iscontrolgetvalue)
        {
            this.FieldLabel = fieldlabel;
            this.DataType = datatype;
            this.ControlType = controltype;
            this.ID = id;
            this.IsControlGetValue = iscontrolgetvalue;
        }
        public ControlFinder(string fieldlabel, ControlType controltype, DataType datatype, string id, bool iscontrolgetvalue, List<DataItem> dt)
        {
            this.FieldLabel = fieldlabel;
            this.DataType = datatype;
            this.ControlType = controltype;
            this.ID = id;
            this.IsControlGetValue = iscontrolgetvalue;
            this.DataSource = dt;
        }
        public ControlFinder(string fieldlabel, ControlType controltype, DataType datatype, string id, bool iscontrolgetvalue, bool isrequest)
        {
            this.FieldLabel = fieldlabel;
            this.DataType = datatype;
            this.ControlType = controltype;
            this.ID = id;
            this.IsControlGetValue = iscontrolgetvalue;
            this.IsRequest = isrequest;
        }
        public ControlFinder(string fieldlabel, ControlType controltype, DataType datatype, string id, string defaultvalue)
        {
            this.FieldLabel = fieldlabel;
            this.DataType = datatype;
            this.ControlType = controltype;
            this.ID = id;
            this.DefaultValue = defaultvalue;
        }
        public ControlFinder(string fieldlabel, ControlType controltype, DataType datatype, string id, string defaultvalue, bool isrequest)
        {
            this.FieldLabel = fieldlabel;
            this.DataType = datatype;
            this.ControlType = controltype;
            this.ID = id;
            this.DefaultValue = defaultvalue;
            this.IsRequest = isrequest;
        }

    }

    public class ListControlFinder
    {
        private List<ControlFinder> _lst;
        public List<ControlFinder> List
        {
            get { return this._lst; }
            set { this._lst = value; }
        }
        public ListControlFinder()
        {
            this._lst = new List<ControlFinder>();
        }

        public void Add(ControlFinder ctrl)
        {
            this._lst.Add(ctrl);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldlabel"></param>
        /// <param name="controltype"></param>
        /// <param name="datatype"></param>
        /// <param name="id"></param>
        public void Add(string fieldlabel, ControlType controltype, DataType datatype, string id)
        {
            ControlFinder ctrl = new ControlFinder(fieldlabel, controltype, datatype, id);
            this._lst.Add(ctrl);
        }
        public void Add(string fieldlabel, ControlType controltype, DataType datatype, string id, bool iscontrolgetvalue)
        {
            ControlFinder ctrl = new ControlFinder(fieldlabel, controltype, datatype, id, iscontrolgetvalue);
            this._lst.Add(ctrl);
        }
        public void Add(string fieldlabel, ControlType controltype, DataType datatype, string id, bool iscontrolgetvalue, List<DataItem> datasource)
        {
            ControlFinder ctrl = new ControlFinder(fieldlabel, controltype, datatype, id, iscontrolgetvalue, datasource);
            this._lst.Add(ctrl);
        }
    }
    public class DataItem
    {
        private object _datatextfield;
        private object _datavaluefield;
        public object DataTextField
        {
            get { return this._datatextfield; }
            set { this._datatextfield = value; }
        }

        public object DataValueField
        {
            get { return this._datavaluefield; }
            set { this._datavaluefield = value; }
        }
        public DataItem() { }
        public DataItem(object datatextfield, object datavaluefield)
        {
            this._datatextfield = datatextfield;
            this._datavaluefield = datavaluefield;
        }
    }

    public enum ControlType
    {
        NumberField,
        TextField,
        Combobox,
        CheckBoxField,
        DateField,
        DateFieldFromTo,
        HiddenField,
        LabelField


    }
}
