using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        //create an instance of the stock collection
        clsStockCollection AStock = new clsStockCollection();
        //set the data source to list of stock in the collection
        lstStockList.DataSource = AStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ShoeId";
        //set the data field to display
        lstStockList.DataTextField = "ShoeSize";
        //bind the data to the list
        lstStockList.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ShoeId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 ShoeId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record edit
            ShoeId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ShoeId"] = ShoeId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else    //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 ShoeId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            ShoeId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["ShoeId"] = ShoeId;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else   //if no record has been selected
        {
                //display an error message
                lblError.Text = "Please select a record from the list to delete";
            }

        }
    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsStockCollection AStock = new clsStockCollection();
        //retrieve the value of shoe colour from the presentation layer
        AStock.ReportByShoeColour(txtStock.Text);
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource = AStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ShoeId";
        //set the name of the field to display
        lstStockList.DataTextField = "ShoeColour";
        //bind the data to the list
        lstStockList.DataBind();
    }
    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection AStock = new clsStockCollection();
        //set an empty string
        AStock.ReportByShoeColour("");
        //clear any existing filter to tidy up the interface
        txtStock.Text = "";
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource = AStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "ShoeId";
        //set the name of the field to display
        lstStockList.DataTextField = "ShoeColour";
        //bind the data to the list
        lstStockList.DataBind();
    }
}
