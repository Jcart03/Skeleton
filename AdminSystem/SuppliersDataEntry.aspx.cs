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
        //create a new instnace of clsSuppliers
        clsSuppliers AnSuppliers = new clsSuppliers();
        //SuppliersID
        AnSuppliers.SuppliersId = Convert.ToInt32(txtSupplierID.Text);  
        //Capture the Suppliers Name
        AnSuppliers.SuppliersName = txtSuppliersName.Text;
        //Address
        AnSuppliers.SuppliersAddress = txtAddress.Text; 
        //PaymentTerms
        AnSuppliers.PaymentTerms = txtPaymentTerms.Text;
        //Contactstartdate
        AnSuppliers.ContractStart = Convert.ToDateTime(DateTime.Now);
        //ISActive
        AnSuppliers.IsActive = chkActive.Checked;  
        //ContactNumber
        AnSuppliers.ContactNumber = Convert.ToInt32(txtContactNumber.Text);



        //store the Suppliers name in the session object
        Session["AnSuppliers"] = AnSuppliers;
        //navigate to the view page
        Response.Redirect("SuppliersViewer.aspx");
    }



    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}