using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    int ShoeId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        ShoeId = Convert.ToInt32(Session["ShoeId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new insance of the address book collection class
        clsStockCollection StockList = new clsStockCollection();
        //find the record to delete
        StockList.ThisStock.Find("ShoeId");
        //delete the record
        StockList.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}