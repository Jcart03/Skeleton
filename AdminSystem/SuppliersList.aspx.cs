using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    int SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
        if (IsPostBack == false)
        {
            
                DisplaySuppliers();
        }
    }
    void DisplaySuppliers()
    {
        clsSuppliersCollection Suppliers = new clsSuppliersCollection();
        lstSuppliersList.DataSource = Suppliers.SuppliersList;
        lstSuppliersList.DataValueField = "SupplierId";
        lstSuppliersList.DataTextField = "Suppliername";
        lstSuppliersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;
        Response.Redirect("SuppliersDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int SupplierId;
        if (lstSuppliersList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(lstSuppliersList.SelectedValue);
            Session["SupplierId"] =SupplierId;
            Response.Redirect("SuppliersDataEntry.apsx");

        }
        else
        {
            lblError.Text = "Select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int SupplierId;
        if (lstSuppliersList.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(lstSuppliersList.SelectedValue);
            Session["SupplierId"] = SupplierId;
            Response.Redirect("SuppliersConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "Select a record from the list to delete";
        }
    }

    

    protected void btnreturntomm_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierStatistics.aspx");
    }

    protected void txtFilter_TextChanged(object sender, EventArgs e)
    {

    }
}