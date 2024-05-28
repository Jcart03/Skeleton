using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 Customer_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Customer_Id = Convert.ToInt32(Session["Customer_Id"]);
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection clsCustomerCollection = new clsCustomerCollection();
        clsCustomerCollection.ThisCustomer.Find(Customer_Id);
        clsCustomerCollection.Delete();
        Response.Redirect("CustomerList.aspx");
    }
}