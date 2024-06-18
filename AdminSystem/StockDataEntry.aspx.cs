using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    int ShoeId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        ShoeId = Convert.ToInt32(Session["ShoeId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (ShoeId != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();

       
        //capture the shoe size
        string ShoeSize = txtShoeSize.Text;
        //capture the shoe colour
        string ShoeColour = txtShoeColour.Text;
        //capture the shoe price
        string ShoePrice = txtShoePrice.Text;
        //capture the shoe brand
        string ShoeBrand = txtShoeBrand.Text;
        //capture the shoe availability
        string ShoeAvailability = chkAvailable.Text;
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        // validate the data       
        Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
        if (Error == "")
        {
            //capture the stock id
            AStock.ShoeId = ShoeId;
            //capture the shoe size
            AStock.ShoeSize = Convert.ToInt32(txtShoeSize.Text);
            //capture the shoe colour
            AStock.ShoeColour = txtShoeColour.Text;
            //capture shoe price
            AStock.ShoePrice = Convert.ToInt32(txtShoePrice.Text);
            //capture shoe brand
            AStock.ShoeBrand = txtShoeBrand.Text;
            //capture shoe availabilty
            AStock.ShoeAvailability = chkAvailable.Checked;
            //capture the date added
            AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. shoeId = -1 then add the data
            if (ShoeId == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            else
            {
                //find the record to update
                StockList.ThisStock.Find(ShoeId);
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }

            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AStock = new clsStock();
        //create a variable to store the primary key
        Int32 ShoeId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ShoeId = Convert.ToInt32(txtShoeId.Text);
        //Find the record
        Found = AStock.Find(ShoeId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtShoeId.Text = AStock.ShoeId.ToString();
            txtShoeSize.Text = AStock.ShoeSize.ToString();
            txtShoeColour.Text = AStock.ShoeColour;
            txtShoePrice.Text = AStock.ShoePrice.ToString();
            txtShoeBrand.Text = AStock.ShoeBrand;
            txtDateAdded.Text = AStock.DateAdded.ToString("A1");
            chkAvailable.Checked = AStock.ShoeAvailability;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    void DisplayStock()
    {
        //create an instance of the staff
        clsStockCollection Stock = new clsStockCollection();
        //find the record to update
        bool found = Stock.ThisStock.Find(ShoeId);
        if (found)
        {
            //display the data for the record
            txtShoeId.Text = Stock.ThisStock.ShoeId.ToString();
            txtShoeSize.Text = Stock.ThisStock.ShoeSize.ToString();
            txtShoeColour.Text = Stock.ThisStock.ShoeColour.ToString();
            txtShoePrice.Text = Stock.ThisStock.ShoePrice.ToString();
            txtShoeBrand.Text = Stock.ThisStock.ShoeBrand.ToString();
            txtDateAdded.Text = Stock.ThisStock.DateAdded.ToString().ToString();
            chkAvailable.Checked = Stock.ThisStock.ShoeAvailability;
        }
        else
        {
            lblError.Text = "staff not found";
        }
    }
}

