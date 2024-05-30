using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSuppliers anSuppliers = new clsSuppliers();
        anSuppliers = (clsSuppliers)Session["anSuppliers"];
        Response.Write(anSuppliers.SuppliersId);
        Response.Write(anSuppliers.Suppliername);
        Response.Write(anSuppliers.Address);
        Response.Write(anSuppliers.PaymentTerms);
        Response.Write(anSuppliers.ContractStart);
        Response.Write(anSuppliers.ContactNumber);
        Response.Write(anSuppliers.IsActive);
    }
}