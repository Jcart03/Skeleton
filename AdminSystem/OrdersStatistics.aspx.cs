using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrdersStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        
        DataTable dT = AnOrder.StatisticsGroupedByCustomerName();
        GridViewGroupByCustomerName.DataSource = dT;
        GridViewGroupByCustomerName.DataBind();
        GridViewGroupByCustomerName.HeaderRow.Cells[0].Text = " Total ";

        dT = AnOrder.StatisticsGroupedByOrderItem();
        GridViewGroupByOrderItem.DataSource = dT;
        GridViewGroupByOrderItem.DataBind();
        GridViewGroupByOrderItem.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void btnPreviousPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}