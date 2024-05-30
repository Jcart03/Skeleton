using System;
using System.Activities.Expressions;
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

    

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        clsSuppliers anSuppliers = new clsSuppliers();
        string SupplierIdText = txtSupplierID.Text;
        string Suppliername =txtSuppliersName.Text;
        string Address = txtAddress.Text;
        string PaymentTerms = txtPaymentTerms.Text;
        string ContractStart = txtContractStart.Text;
        string ContactNumber = txtContactNumber.Text;
        string IsActive = chkActive.Checked;
        string Error = "";

        Error = anSuppliers.Valid(Suppliername, Address, PaymentTerms, ContractStart, ContactNumber, IsActive);
        if (Error == "")
        {
            int SupplierID;
            if (int.TryParse(Error, out SupplierID))
            {
                anSuppliers.SupplierId = SupplierID;
                anSuppliers.Suppliername = SuppliersName;
                anSuppliers.Address = Address;
                anSuppliers.PaymentTerms = PaymentTerms;
                anSuppliers.ContractStart = ContractStart;
                anSuppliers.ContactNumber = ContactNumber;
                clsSuppliersCollection SuppliersList = new clsSuppliersCollection();

                if (SupplierID == -1)
                {
                    SuppliersList.Supplierid = SupplierID;
                    SuppliersList.Add();
                }
                else
                {
                    if (SuppliersList.ThisSuppliers.Find(SuppliersID))
                    {



                        SuppliersList.ThisSuppliers = anSuppliers;
                        SuppliersList.Update();
                    }
                    else
                    {
                        lblError.Text = "Supplier not found.";
                        return;
                    }
                }
                Response.Redirect("SuppliersList.aspx");
            }
            else
            {
                lblError.Text = "Invalid Supplier ID";
            }
        }
     else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSuppliers anSuppliers = new clsSuppliers();
        int SupplierID;
        bool Found = false;

        if(int.TryParse(txtSupplierID.Text, out SupplierID))
        {
            Found = anSuppliers.Find(SupplierID);
        }
        if( Found )
        {
            txtSuppliersName.Text = anSuppliers.SuppliersName;
            txtAddress.Text = anSuppliers.SuppliersAddress;
            txtPaymentTerms.Text = anSuppliers.PaymentTerms;
            txtContractStart.Text = anSuppliers.ContractStart.ToString("dd-mm-yyyy");
            chkActive.Checked = anSuppliers.IsActive;

        }
        else
        {
            lblError.Text = "Supplier not Found.";
        }
    }
}