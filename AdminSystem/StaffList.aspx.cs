using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box 
            DisplayStaffs();
        }
    }

    void DisplayStaffs()
    {
        //create an instance of the staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        lstStaffList.DataSource = Staffs.StaffList;
        //set the data source to list of staffs in the collection
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}