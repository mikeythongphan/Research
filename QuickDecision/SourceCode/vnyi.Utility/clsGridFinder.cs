using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
//using System.Web.UI;
using Ext.Net;

namespace vnyi.Utility
{
    public class ColumnGridFinder
    {
        public string ColumnId { get; set; }
        public string Header { get; set; }
        public int Width { get; set; }
        public bool Sortable { get; set; }
        public string DataIndex { get; set; }
        /// <summary>
        /// Script Render
        /// </summary>
        public string Renderer { get; set; }
        public string RecordField { get; set; }
        public RecordFieldType datatype { get; set; }
        public bool IsReturnValue { get; set; }
        public bool IsHidden { get; set; }
        public bool AutoExpandColumn { get; set; }


        public ColumnGridFinder()
        {

        }
        public ColumnGridFinder(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield)
        {
            this.ColumnId = columnid;
            this.Header = header;
            this.Width = width;
            this.Sortable = sortable;
            this.DataIndex = dataindex;
            this.Renderer = ScriptRenderer;
            this.RecordField = recordfield;
        }
        public ColumnGridFinder(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, RecordFieldType Datatype)
        {
            this.ColumnId = columnid;
            this.Header = header;
            this.Width = width;
            this.Sortable = sortable;
            this.DataIndex = dataindex;
            this.Renderer = ScriptRenderer;
            this.RecordField = recordfield;
          this.datatype=Datatype;
        }
        public ColumnGridFinder(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, bool isreturnvalue)
        {
            this.ColumnId = columnid;
            this.Header = header;
            this.Width = width;
            this.Sortable = sortable;
            this.DataIndex = dataindex;
            this.Renderer = ScriptRenderer;
            this.RecordField = recordfield;
            this.IsReturnValue = isreturnvalue;
        }
        public ColumnGridFinder(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, RecordFieldType Datatype, bool isreturnvalue)
        {
            this.ColumnId = columnid;
            this.Header = header;
            this.Width = width;
            this.Sortable = sortable;
            this.DataIndex = dataindex;
            this.Renderer = ScriptRenderer;
            this.RecordField = recordfield;
            this.IsReturnValue = isreturnvalue;
            this.datatype=Datatype;
        }
        public ColumnGridFinder(string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield)
        {
            this.Header = header;
            this.Width = width;
            this.Sortable = sortable;
            this.DataIndex = dataindex;
            this.Renderer = ScriptRenderer;
            this.RecordField = recordfield;
        }
        public ColumnGridFinder(string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, RecordFieldType Datatype)
        {
            this.Header = header;
            this.Width = width;
            this.Sortable = sortable;
            this.DataIndex = dataindex;
            this.Renderer = ScriptRenderer;
            this.RecordField = recordfield;
            this.datatype=Datatype;
        }
        public ColumnGridFinder(string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, bool isreturnvalue)
        {
            this.Header = header;
            this.Width = width;
            this.Sortable = sortable;
            this.DataIndex = dataindex;
            this.Renderer = ScriptRenderer;
            this.RecordField = recordfield;
            this.IsReturnValue = isreturnvalue;
        }
        public ColumnGridFinder(string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, RecordFieldType Datatype, bool isreturnvalue)
        {
            this.Header = header;
            this.Width = width;
            this.Sortable = sortable;
            this.DataIndex = dataindex;
            this.Renderer = ScriptRenderer;
            this.RecordField = recordfield;
            this.IsReturnValue = isreturnvalue;
            this.datatype=Datatype;
        }
    }

    public class GridFinder
    {
        public string ID { get; set; }
        public string Title { get; set; }        
        public bool Mutiple { get; set; }
      

        public List<ColumnGridFinder> ListColumn { get; set; }

        public GridFinder()
        {
            this.ListColumn = new List<ColumnGridFinder>();
        }
        /// <summary>
        /// Danh sách Object theo tiêu chí Finder tím được
        /// </summary>
        /// <param name="title">Tiêu Đề của Lưới</param>
        /// <param name="mutiple">Lưới có Được chọn nhiều hay khong</param>
        public GridFinder(string title, bool mutiple)
        {
            this.Title = title;
            this.Mutiple = mutiple;
            this.ListColumn = new List<ColumnGridFinder>();
        }
        /// <summary>
        /// Thêm control vào ô nhập finder
        /// </summary>
        /// <param name="col">Đối tượng control cần thêm</param>
        public void Add(ColumnGridFinder col)
        {
            ListColumn.Add(col);
        }
        /// <summary>
        /// Thêm cột vào trong lưới 
        /// </summary>
        /// <param name="columnid">Mã của collun</param>
        /// <param name="header">Tiêu đề cột</param>
        /// <param name="width">Độ rộng của cột</param>
        /// <param name="sortable">Có Được Phép sắp xếp hay khong</param>
        /// <param name="dataindex"></param>
        /// <param name="ScriptRenderer"></param>
        /// <param name="recordfield"></param>
        public void Add(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield)
        {
            ColumnGridFinder col = new ColumnGridFinder(columnid, header, width, sortable, dataindex, ScriptRenderer, recordfield);
            ListColumn.Add(col);

        }
        public void Add(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, RecordFieldType Datatype)
        {
            ColumnGridFinder col = new ColumnGridFinder(columnid, header, width, sortable, dataindex, ScriptRenderer, recordfield, Datatype);
            ListColumn.Add(col);

        }
        public void Add(string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield)
        {
            ColumnGridFinder col = new ColumnGridFinder(header, width, sortable, dataindex, ScriptRenderer, recordfield);
            ListColumn.Add(col);
        }
        public void Add(string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, RecordFieldType Datatype)
        {
            ColumnGridFinder col = new ColumnGridFinder(header, width, sortable, dataindex, ScriptRenderer, recordfield, Datatype);
            ListColumn.Add(col);
        }
        //co an cot
        public void Add(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, bool isreturnvalue, bool ishidden)
        {
            ColumnGridFinder col = new ColumnGridFinder();
            col.ColumnId = columnid;
            col.Header = header;
            col.Width = width;
            col.Sortable = sortable;
            col.DataIndex = dataindex;
            col.Renderer = ScriptRenderer;
            col.RecordField = recordfield;
            col.IsReturnValue = isreturnvalue;
            col.IsHidden = ishidden;
            ListColumn.Add(col);
        }
        public void Add(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, bool isreturnvalue, bool ishidden, RecordFieldType Datatype)
        {
            ColumnGridFinder col = new ColumnGridFinder();
            col.ColumnId = columnid;
            col.Header = header;
            col.Width = width;
            col.Sortable = sortable;
            col.DataIndex = dataindex;
            col.Renderer = ScriptRenderer;
            col.RecordField = recordfield;
            col.IsReturnValue = isreturnvalue;
            col.IsHidden = ishidden;
            col.datatype = Datatype;
            ListColumn.Add(col);
        }
        public void Add(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, bool isreturnvalue)
        {
            ColumnGridFinder col = new ColumnGridFinder(columnid, header, width, sortable, dataindex, ScriptRenderer, recordfield, isreturnvalue);
            ListColumn.Add(col);
        }
        public void Add(string columnid, string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, bool isreturnvalue, RecordFieldType Datatype)
        {
            ColumnGridFinder col = new ColumnGridFinder(columnid, header, width, sortable, dataindex, ScriptRenderer, recordfield,Datatype, isreturnvalue);
            ListColumn.Add(col);
        }
        public void Add(string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, bool isreturnvalue)
        {
            ColumnGridFinder col = new ColumnGridFinder(header, width, sortable, dataindex, ScriptRenderer, recordfield, isreturnvalue);
            ListColumn.Add(col);
        }
        public void Add(string header, int width, bool sortable, string dataindex, string ScriptRenderer, string recordfield, bool isreturnvalue, RecordFieldType Datatype)
        {
            ColumnGridFinder col = new ColumnGridFinder(header, width, sortable, dataindex, ScriptRenderer, recordfield, Datatype, isreturnvalue);
            ListColumn.Add(col);
        }

        internal void Add(string p, int p_2, bool p_3, string p_4, string p_5, string p_6, bool p_7, bool p_8)
        {
            throw new NotImplementedException();
        }
    }

    public enum DataType
    {
        String,
        Int,
        Float,
        Date
    }

}
