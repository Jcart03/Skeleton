using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock clsStock = new clsStock();

        //retrieve data from the database
        DataTable dT = clsStock.StatisticsGroupedByShoeColour();

        //upload dT into GridView
        GridViewStGroupByShoeColour.DataSource = dT;
        GridViewStGroupByShoeColour.DataBind();

        //change the header of the first column
        GridViewStGroupByShoeColour.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        dT = clsStock.StatisticsGroupedByShoePrice();

        //upload dT into GridView
        GridViewStGroupByShoePrice.DataSource = dT;
        GridViewStGroupByShoePrice.DataBind();

        //change the header of the first column
        GridViewStGroupByShoePrice.HeaderRow.Cells[0].Text = " Total ";

    }
}