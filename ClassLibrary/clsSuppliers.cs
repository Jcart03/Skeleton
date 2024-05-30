using System;

namespace ClassLibrary
{
    public class clsSuppliers
    {
        private int mSupplierId;
        

        public int SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }

        private string mSuppliername;
        public string Suppliersname
        {
            get
            {
                return mSuppliername;
            }
            set
            {
                mSuppliername = value;
            }
        }
        private string mAddress;

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        private string mPaymentTerms;

        public string PaymentTerms
        {
            get
            {
                return mPaymentTerms;
            }
            set
            {
                mPaymentTerms = value;
            }
        }

        private DateTime mContractStart;

        public DateTime ContractStart
        {
            get
            {
                return mContractStart;
            }
            set
            {
                mContractStart = value;
            }
        }
        private bool mIsActive;
        public bool IsActive
        {
            get
            {
                return mIsActive;
            }
            set
            {
                mIsActive = value;
            }
        }
        private int mContactNumber;
        public int ContactNumber
        {
            get
            {
                return mContactNumber;
            }
            set
            {
                mContactNumber = value;
            }
        }



        public bool Find(int supplierId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("SupplierId" , SupplierId);
            DB.Execute("sproc_tblsuppliers_FilterBySupplierId");

            if (DB.Count == 1)
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSuppliername = Convert.ToString(DB.DataTable.Rows[0]["Suppliername"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPaymentTerms = Convert.ToString(DB.DataTable.Rows[0]["PaymentTerms"]);
                mContractStart = Convert.ToDateTime(DB.DataTable.Rows[0]["ContractStart"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mContactNumber = Convert.ToInt32(DB.DataTable.Rows[0]["ContactNumber"]);

                return true;
            }
            else
            {
                return false;
            }


        }
        
        
       
       
        
    }
}