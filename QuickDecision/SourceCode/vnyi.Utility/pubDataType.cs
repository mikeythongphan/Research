using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace vnyi.Utility
{
    
    public enum enmGridViewType
    {
        TextBox = 2,
        DropDownList = 3,
        RadDatePicker = 4,
        RadDateTimePicker = 5,
        CheckBox = 6,
        ASPxButtonEdit=7
    }
    /// <summary>
    /// enum lay OBJT_AUTOID tu database
    /// </summary>
    public enum objectType
    {
        [StringValue("Nhân viên")]
        Employee = 1, //Nhan vien
        [StringValue("Khách hàng")]
        Customer = 2, //Khach hang
        [StringValue("Nhà cung cấp")]
        Supplier = 3, //Nha cung cap
        [StringValue("Nhà phân phối")]
        Distributor = 4, //Nha phan phoi
        [StringValue("Đối tác")]
        Partner = 5, //Doi tac
        [StringValue("Đối tượng khác")]
        Other = 6 //Doi tuong khac
    }
    public class GridViewTemplate : ITemplate
    {
        private enmGridViewType templateType;
        private string[] strId;

        public GridViewTemplate(enmGridViewType type,params string[] id )
        {
            templateType = type;
            strId = id;
        }

        public void InstantiateIn(System.Web.UI.Control container)
        {
            // Create the content for the different row types.
            Label lbl = new Label();
            lbl.ID=strId[0];
            container.Controls.Add(lbl);
            switch (templateType)
            {
                case enmGridViewType.TextBox:
                    TextBox txt = new TextBox();
                    txt.ID = strId[1];
                    txt.Text = "";
                    txt.Visible = false;
                    container.Controls.Add(txt);
                    break;
                case enmGridViewType.DropDownList:
                    // Create the controls to put in a data row
                    // section and set their properties.
                    Label firstName = new Label();
                    Label lastName = new Label();

                    Literal spacer = new Literal();
                    spacer.Text = " ";

                    // To support data binding, register the event-handling methods
                    // to perform the data binding. Each control needs its own event
                    // handler.
                    firstName.DataBinding += new EventHandler(this.FirstName_DataBinding);
                    lastName.DataBinding += new EventHandler(this.LastName_DataBinding);

                    // Add the controls to the Controls collection
                    // of the container.
                    container.Controls.Add(firstName);
                    container.Controls.Add(spacer);
                    container.Controls.Add(lastName);
                    break;

                // Insert cases to create the content for the other 
                // row types, if desired.

                default:
                    // Insert code to handle unexpected values.
                    break;
            }
        }

        private void FirstName_DataBinding(Object sender, EventArgs e)
        {
            // Get the Label control to bind the value. The Label control
            // is contained in the object that raised the DataBinding 
            // event (the sender parameter).
            Label l = (Label)sender;

            // Get the GridViewRow object that contains the Label control. 
            GridViewRow row = (GridViewRow)l.NamingContainer;

            // Get the field value from the GridViewRow object and 
            // assign it to the Text property of the Label control.
            l.Text = DataBinder.Eval(row.DataItem, "au_fname").ToString();
        }

        private void LastName_DataBinding(Object sender, EventArgs e)
        {
            // Get the Label control to bind the value. The Label control
            // is contained in the object that raised the DataBinding 
            // event (the sender parameter).
            Label l = (Label)sender;

            // Get the GridViewRow object that contains the Label control.
            GridViewRow row = (GridViewRow)l.NamingContainer;

            // Get the field value from the GridViewRow object and 
            // assign it to the Text property of the Label control.
            l.Text = DataBinder.Eval(row.DataItem, "au_lname").ToString();
        }
    }

}
