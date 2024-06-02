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
        if (!IsPostBack)
        {
            if (Session["SupplierId"] != null)
            {
                int SupplierId = Convert.ToInt32(Session["SupplierId"]);
                if (SupplierId != -1)
                {
                    DisplaySuppliers(SupplierId);
                }
            }    
        }
    }

    void DisplaySuppliers(int SupplierId)
    {
        clsSuppliersCollection Suppliers = new clsSuppliersCollection();
        bool found = Suppliers.ThisSuppliers.Find(SupplierId);
        if (found)
        {
            txtSupplierID.Text = Suppliers.ThisSuppliers.SupplierId.ToString();
            txtSuppliersName.Text = Suppliers.ThisSuppliers.SupplierName.ToString();
            txtAddress.Text = Suppliers.ThisSuppliers.Address.ToString();
            txtPaymentTerms.Text = Suppliers.ThisSuppliers.PaymentTerms.ToString();
            txtContractStart.Text = Suppliers.ThisSuppliers.ContractStart.ToString();
            chkActive.Text = Suppliers.ThisSuppliers.IsActive.ToString();
            txtContactNumber.Text = Suppliers.ThisSuppliers.ContactNumber.ToString();
        }
        else { lblError.Text = "Suppliers Not Found "; }


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSuppliers anSuppliers = new clsSuppliers();
        string SupplierIdT = txtSupplierID.Text;
        string SupplierName = txtSuppliersName.Text;
        string Address = txtAddress.Text;
        string PaymentTerms = txtPaymentTerms.Text;
        string ContractStart = txtContractStart.Text;
        string ContactNumber = txtContactNumber.Text; // Keep as string for validation
        bool IsActive = chkActive.Checked;
        string Error = "";

        // Validate inputs
        Error = anSuppliers.Valid(SupplierName, Address, PaymentTerms, ContractStart, ContactNumber);
        if (Error == "")
        {
            int SupplierId;
            if (int.TryParse(SupplierIdT, out SupplierId))
            {
                anSuppliers.SupplierId = SupplierId;
                anSuppliers.SupplierName = SupplierName;
                anSuppliers.Address = Address;
                anSuppliers.PaymentTerms = PaymentTerms;
                anSuppliers.ContractStart = DateTime.Parse(ContractStart); // Convert to DateTime
                anSuppliers.ContactNumber = int.Parse(ContactNumber); // Convert to int
                anSuppliers.IsActive = IsActive;
                clsSuppliersCollection SuppliersList = new clsSuppliersCollection();

                if (SupplierId == -1)
                {
                    SuppliersList.ThisSuppliers = anSuppliers;
                    SuppliersList.Add();
                }
                else
                {
                    SuppliersList.ThisSuppliers.Find(SupplierId); // Assuming Find method returns a supplier object
                    SuppliersList.ThisSuppliers = anSuppliers;
                    SuppliersList.Update();
                }

                Response.Redirect("SuppliersList.aspx");
            }
            else
            {
                lblError.Text = "Invalid Supplier ID.";
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
        int SupplierId;
        bool Found = false;

        if (int.TryParse(txtSupplierID.Text, out SupplierId))
        {
            Found = anSuppliers.Find(SupplierId);
        }
        if (Found)
        {
            txtSuppliersName.Text = anSuppliers.SupplierName;
            txtAddress.Text = anSuppliers.Address;
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