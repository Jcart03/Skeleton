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
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff(StaffId);
            }
        }
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
            AnStaff.StaffId = StaffId;
            AnStaff.StaffName = StaffName;
            AnStaff.StaffAddress = StaffAddress;
            AnStaff.StaffEmail = StaffEmail;
            AnStaff.StartingDate = Convert.ToDateTime(DateTime.Now);
            AnStaff.StaffSalary = Convert.ToDecimal(txtStaffSalary.Text);
            AnStaff.IsManager = chkIsManager.Checked;
            //create a new instance of the address collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffId = -1 then add the data
            if (StaffId == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AnStaff;
                //add the new record
                StaffList.Add();
            }
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the thisstaff property
                StaffList.ThisStaff = AnStaff;
                //update the record
                StaffList.Update();
            }

            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
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

            //display the values of the properties in the form
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
        Response.Redirect("StaffList.aspx");
    }

    void DisplayStaff(int StaffId)
    {
        //create an instance of the staff
        clsStaffCollection staff = new clsStaffCollection();
        //find the record to update
        bool found = staff.ThisStaff.Find(StaffId);
        if (found)
        {
            //display the data for the record
            txtStaffID.Text = staff.ThisStaff.StaffId.ToString();
            txtStaffName.Text = staff.ThisStaff.StaffName.ToString();
            txtStaffAddress.Text = staff.ThisStaff.StaffAddress.ToString();
            txtStaffEmail.Text = staff.ThisStaff.StaffEmail.ToString();
            txtStartingDate.Text = staff.ThisStaff.StartingDate.ToString();
            txtStaffSalary.Text = staff.ThisStaff.StaffSalary.ToString();
            chkIsManager.Checked = staff.ThisStaff.IsManager;
        }
        else
        {
            lblError.Text = "staff not found";
        }
    }


    protected void btnReturntomm_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
