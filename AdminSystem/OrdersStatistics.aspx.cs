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

        dT = AnOrder.StatisticsGroupedByItemName();
        GridViewGroupByItemName.DataSource = dT;
        GridViewGroupByItemName.DataBind();
        GridViewGroupByItemName.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}