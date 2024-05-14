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
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.Name = txtCustomerName.Text;
        ACustomer.Email = txtEmail.Text;
        ACustomer.Customer_Id = Convert.ToInt32(txtCustomerId.Text);
        ACustomer.Password = txtPassword.Text;
        ACustomer.Address = txtAddress.Text;
        ACustomer.Timestamp = Convert.ToDateTime(txtTimestamp.Text);
        ACustomer.Logged_In = cbLoggedIn.Checked;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }
}