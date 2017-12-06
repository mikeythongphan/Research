using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Ext.Net;
namespace vnyi.Utility
{
    public partial class Finder
    {
        private List<DataItem> DataSource;
        public string StoreName
        {
            get;
            set;
        }
                                                                                           
        public int LabelWidth
        {
            get;
            set;
        }
        //public FinderType FinderType { get; set; }
        public ListControlFinder ListControl
        {
            get;
            set;
        }
        public GridFinder GridFinder
        {
            get;
            set;
        }
        /// <summary>
        /// Sự kiện tạo mới
        /// </summary>
        public string EventbtnNews
        {
            get;
            set;
        }
        /// <summary>
        /// có hiển thị Nút Tạo mới hay không
        /// </summary>
        public bool IsEventbtn
        {
            get;
            set;
        }        
        /// <summary>
        /// Khởi tạo fileder
        /// </summary>
        /// <param name="findertype">Loại</param>
        /// <param name="Culture">Ngôn ngữ</param>
        public Finder(string findertype, Int16? Culture)
        {
            if (Culture == null)
                Culture = 1;
            IsEventbtn = false;
            this.ListControl = new ListControlFinder();
            this.GridFinder = new GridFinder();
            this.DataSource = new List<DataItem>();
            initFinder(findertype, Culture);
        }      
    }


    public enum FinderType
    {
        none,
        customer,
        organization,
        invoice,
        declaration
    }
}
