using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnStaffManagementSystem_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    protected void btnOrderManagementSystem_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnCustomerManagementSystem_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnSupplierManagementSystem_Click(object sender, EventArgs e)
    {
        Response.Redirect("SuppliersList.aspx");
    }

    protected void btnStockManagementSystem_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}