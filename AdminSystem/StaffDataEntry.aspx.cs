using System;
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
        //the id 
        AnStaff.StaffId = int.Parse(txtStaffID.Text);
        AnStaff.StaffName = txtStaffName.Text;
        AnStaff.StaffAddress = txtStaffAddress.Text;
        AnStaff.StaffEmail = txtStaffEmail.Text;
        AnStaff.StartingDate = Convert.ToDateTime(DateTime.Now);
        AnStaff.StaffSalary = Convert.ToDecimal(txtStaffSalary.Text);
        AnStaff.IsManager = chkIsManager.Checked;
        //store the staff name
        Session["AnStaff"] = AnStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");

    }

}