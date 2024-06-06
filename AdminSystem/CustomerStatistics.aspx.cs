using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer clsCustomer = new clsCustomer();
        DataTable dT = clsCustomer.StatisticsGroupedByLoggedIn();
        gvLoggedIn.DataSource = dT;
        gvLoggedIn.DataBind();
        gvLoggedIn.HeaderRow.Cells[0].Text = " Total ";

        dT = clsCustomer.StatisticsGroupedByTimestamp();
        gvTimestamp.DataSource = dT;
        gvTimestamp.DataBind();
        gvTimestamp.HeaderRow.Cells[0].Text = " Total ";
            }
}