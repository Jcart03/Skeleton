using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the Stock brand
        AStock.ShoeBrand = txtShoeBrand.Text;
        //capture the Shoe Size
        AStock.ShoeSize = Convert.ToInt32(txtShoeSize.Text);
        //capture the Shoe Colour
        AStock.ShoeColour = txtShoeColour.Text;
        //capture the Shoe Price
        AStock.ShoePrice = Convert.ToInt32(txtShoePrice.Text);
        //capture the Shoe Price
        AStock.ShoeAvailability = chkAvailable.Checked;
        //capture the Shoe Availability
        AStock.DateAdded = Convert.ToDateTime(DateTime.Now);
        //store the Stock in the session object
        Session["AStock"] = AStock;
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }
    public class clsStock
    {
        public string ShoeBrand { get; set; }
        public int ShoeSize { get; set; }
        public string ShoeColour { get; set; }
        public int ShoePrice { get; set; }
        public bool ShoeAvailability { get; set; }
        public DateTime DateAdded { get; set; }
    }

}