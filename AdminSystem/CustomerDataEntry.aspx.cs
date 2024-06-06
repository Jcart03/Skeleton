using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 Customer_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Customer_Id = Convert.ToInt32(Session["Customer_Id"]);
        if (IsPostBack == false)
        {
            if (Customer_Id!= -1)
            {
                DisplayCustomer();
            }
        }

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
            ACustomer.Customer_Id = Customer_Id;
            ACustomer.Name = RAWName;
            ACustomer.Email = RAWEmail;
            ACustomer.Customer_Id = Convert.ToInt32(RAWCustomer_Id);
            ACustomer.Password = RAWPassword;
            ACustomer.Address = RAWAddress;
            ACustomer.Timestamp = Convert.ToDateTime(RAWTimestamp);
            ACustomer.Logged_In = RAWLogged_In;

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (Customer_Id == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            } else
            {
                CustomerList.ThisCustomer.Find(Customer_Id);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        

    }

    void DisplayCustomer()
    {
        clsCustomerCollection customerCollection = new clsCustomerCollection();
        customerCollection.ThisCustomer.Find(Customer_Id);

        txtCustomerId.Text = customerCollection.ThisCustomer.Customer_Id.ToString();
        txtCustomerName.Text = customerCollection.ThisCustomer.Name.ToString();
        txtEmail.Text = customerCollection.ThisCustomer.Email.ToString();
        txtPassword.Text = customerCollection.ThisCustomer.Password.ToString();
        txtTimestamp.Text = customerCollection.ThisCustomer.Timestamp.ToString();
        txtAddress.Text = customerCollection.ThisCustomer.Address.ToString();
        cbLoggedIn.Checked = customerCollection.ThisCustomer.Logged_In;
       

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 Customer_Id;
        Boolean Found = false;
        Customer_Id = Convert.ToInt32(txtCustomerId.Text);
        Found = ACustomer.Find(Customer_Id);
        if (Found  == true)
        {
            txtAddress.Text = ACustomer.Address;
            txtCustomerName.Text = ACustomer.Name;
            txtEmail.Text = ACustomer.Email;
            txtPassword.Text = ACustomer.Password;
            txtTimestamp.Text = ACustomer.Timestamp.ToString();
            cbLoggedIn.Checked = ACustomer.Logged_In;


        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}