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
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    private void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "Email";
        lstCustomerList.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Customer_Id"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 Customer_Id;

        if(lstCustomerList.SelectedIndex != -1)
        {
            Customer_Id = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["Customer_Id"] = Customer_Id;
            Response.Redirect("CustomerDataEntry.aspx");
           
        } else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)

    {
        Int32 Customer_Id;
        if (lstCustomerList.SelectedIndex != -1)
        {
            Customer_Id = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["Customer_Id"] = Customer_Id;
            Response.Redirect("CustomerConfirmDelete.aspx");
        } else
        {
            lblError.Text = "PLease select a record from the list to delete";
        }
    }



    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ReportByAddress(txtAddress.Text);
        lstCustomerList.DataSource = ACustomer.CustomerList;
        lstCustomerList.DataValueField = "Customer_Id";
        lstCustomerList.DataTextField = "Address";
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ReportByAddress("");
        txtAddress.Text = "";
        lstCustomerList.DataSource = ACustomer.CustomerList;
        lstCustomerList.DataValueField = "Customer_Id";
        lstCustomerList.DataTextField = "Address";
        lstCustomerList.DataBind();
    }

    protected void txtAddress_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnStatistics_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerStatistics.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}