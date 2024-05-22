using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        string StaffName = txtStaffName.Text;
        string StaffAddress = txtStaffAddress.Text;
        string StaffEmail = txtStaffEmail.Text;
        string StartingDate = txtStartingDate.Text;
        string StaffSalary = txtStaffSalary.Text;
        string IsManager = chkIsManager.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
        if (Error =="")
        {
            AnStaff.StaffName = StaffName;
            AnStaff.StaffAddress = StaffAddress;
            AnStaff.StaffEmail = StaffEmail;
            AnStaff.StartingDate = Convert.ToDateTime(DateTime.Now);
            AnStaff.StaffSalary = Convert.ToDecimal(txtStaffSalary.Text);
            //store the staff inthe session object
            Session["AnStaff"] = AnStaff;
            //navigate to the view page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AnStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffID.Text);
        //Find the record
        Found = AnStaff.Find(StaffId);
        //if found
        if (Found == true)
        {

            //display the vakues of the properties in the form
            txtStaffName.Text = AnStaff.StaffName;
            txtStaffAddress.Text = AnStaff.StaffAddress;
            txtStaffEmail.Text = AnStaff.StaffEmail;
            txtStartingDate.Text = AnStaff.StartingDate.ToString("yyyy-MM-dd");
            txtStaffSalary.Text = AnStaff.StaffSalary.ToString("F2");
            chkIsManager.Checked = AnStaff.IsManager;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
