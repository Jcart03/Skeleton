using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //get the data from the session onject
        AStock = (clsStock)Session["AStock"];
        Response.Write(AStock.ShoeBrand);
        Response.Write(AStock.ShoeSize);
        Response.Write(AStock.ShoeColour);
        Response.Write(AStock.ShoePrice);
        Response.Write(AStock.ShoeAvailability);
        Response.Write(AStock.DateAdded);
    }
}