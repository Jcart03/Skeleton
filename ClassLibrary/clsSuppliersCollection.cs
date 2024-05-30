using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsSuppliersCollection
    {
        public clsSuppliersCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblsuppliers_SelectAll");
            PopulateArray(DB);
        }
        List<clsSuppliers> mSuppliersList = new List<clsSuppliers>();
        clsSuppliers mThisSuppliers = new clsSuppliers();

        public List<clsSuppliers> SuppliersList
        {
            get
            {
                return mSuppliersList;
            }
            set
            {
                mSuppliersList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSuppliersList.Count;

            }
            set
            {
                mSuppliersList.Clear();
            }
        }
        public clsSuppliers ThisSuppliers
        {
            get
            {
                return mThisSuppliers;

            }
            set
            {
                mThisSuppliers = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Suppliername", mThisSuppliers.Suppliersname);
            DB.AddParameter("@Address", mThisSuppliers.Address);
            DB.AddParameter("@PaymentTerms", mThisSuppliers.PaymentTerms);
            DB.AddParameter("@ContractStart", mThisSuppliers.ContractStart);
            DB.AddParameter("@IsActive", mThisSuppliers.IsActive);
            DB.AddParameter("@ContactNumber", mThisSuppliers.ContactNumber);

            return DB.Execute("sproc_tblsuppliers_Insert");
            
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierId", mThisSuppliers.SupplierId);
            DB.AddParameter("@Suppliername", mThisSuppliers.Suppliersname);
            DB.AddParameter("@Address", mThisSuppliers.Address);
            DB.AddParameter("@PaymentTerms", mThisSuppliers.PaymentTerms);
            DB.AddParameter("@ContractStart", mThisSuppliers.ContractStart);
            DB.AddParameter("@IsActive", mThisSuppliers.IsActive);
            DB.AddParameter("@ContactNumber", mThisSuppliers.ContactNumber);

            DB.Execute("sproc_tblsuppliers_Update");

        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@SupplierId", mThisSuppliers.SupplierId);
            DB.Execute("sproc_tblsuppliers_Delete");

        }
        public void ReportBySupplierName(string Suppliername)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Suppliername", Suppliername);
            DB.Execute("sproc_tblsuppliers_FilterBySuppliername");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mSuppliersList = new List<clsSuppliers>();
            while(Index < RecordCount)
            {
                clsSuppliers anSuppliers = new clsSuppliers();
                anSuppliers.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SuppliersId"]);
                anSuppliers.Suppliersname = Convert.ToString(DB.DataTable.Rows[Index]["Suppliername"]);
                anSuppliers.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                anSuppliers.PaymentTerms = Convert.ToString(DB.DataTable.Rows[Index]["PaymentTerms"]);
                anSuppliers.ContractStart = Convert.ToDateTime(DB.DataTable.Rows[Index]["ContractStart"]);
                anSuppliers.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                anSuppliers.ContactNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["ContactNumber"]);
                mSuppliersList.Add(anSuppliers);
                Index++;
            }
            }
        }



    }
 

