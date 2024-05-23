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
        string RAWName = txtCustomerName.Text;
        string RAWEmail = txtEmail.Text;
        string RAWCustomer_Id = txtCustomerId.Text;
        string RAWPassword = txtPassword.Text;
        string RAWAddress = txtAddress.Text;
        string RAWTimestamp = txtTimestamp.Text;
        bool RAWLogged_In = cbLoggedIn.Checked;
        string Error = "";
        Error = ACustomer.Valid(RAWAddress, RAWEmail, RAWTimestamp, RAWName);
        if (Error == "")
        {
            ACustomer.Name = RAWName;
            ACustomer.Email = RAWEmail;
            ACustomer.Customer_Id = Convert.ToInt32(RAWCustomer_Id);
            ACustomer.Password = RAWPassword;
            ACustomer.Address = RAWAddress;
            ACustomer.Timestamp = Convert.ToDateTime(RAWTimestamp);
            ACustomer.Logged_In = RAWLogged_In;

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = ACustomer;
            CustomerList.Add();
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        

    }
}