using System;
using System.Data;
using ClassLibrary;

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
        public string SupplierName
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



        public bool Find(int SupplierId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", SupplierId);
            DB.Execute("sproc_tblsuppliers_FilterBySupplierId");

            if (DB.Count == 1)
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSuppliername = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
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


        public DataTable StatisticsGroupedByAddress()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblsuppliers_Count_GroupByAddress");
            return DB.DataTable;
        }
        public DataTable StatisticsGroupBySupplierName()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblsuppliers_Count_GroupBySupplierName");
            return DB.DataTable;
        }



        public string Valid(string supplierName, string address, string paymentTerms, string contractStart, string contactNumber)
        {
            // Create a string variable to store the error
            string Error = "";
            // Create a temporary variable to store date values
            DateTime DateTemp;
            int ContactNumTemp;

            // Validate SupplierName
            if (supplierName.Length == 0)
            {
                // Record the error
                Error += "The supplier name may not be blank : ";
            }
            if (supplierName.Length > 50)
            {
                // Record the error
                Error += "The supplier name must be less than 50 characters : ";
            }

            // Validate Address
            if (address.Length == 0)
            {
                // Record the error
                Error += "The address may not be blank : ";
            }

            // Validate PaymentTerms
            if (paymentTerms.Length == 0)
            {
                // Record the error
                Error += "The payment terms may not be blank : ";
            }
            if (paymentTerms.Length > 50)
            {
                // Record the error
                Error += "The payment terms must be less than 50 characters : ";
            }

            // Validate ContractStart
            try
            {
                // Copy the contractStart value to the DateTemp variable
                DateTemp = Convert.ToDateTime(contractStart);

                // Compare contractStart with the current date
                DateTime DateComp = DateTime.Now.Date;

                if (DateTemp < DateComp)
                {
                    // Record the error
                    Error += "The contract start date cannot be in the past : ";
                }
                if (DateTemp > DateComp.AddYears(5))
                {
                    // Record the error
                    Error += "The contract start date cannot be more than 5 years in the future : ";
                }
            }
            catch
            {
                // Record the error
                Error += "The contract start date was not a valid date : ";
            }

            // Validate ContactNumber
            if (contactNumber.Length == 0)
            {
                // Record the error
                Error += "The contact number may not be blank : ";
            }
            if (contactNumber.Length != 10) // Assuming the contact number should be exactly 10 digits
            {
                // Record the error
                Error += "The contact number must be exactly 10 digits : ";
            }
            if (!int.TryParse(contactNumber, out ContactNumTemp)) // Check if the contact number is a valid integer
            {
                // Record the error
                Error += "The contact number must be a valid integer : ";
            }

            // Return any error messages
            return Error;
        }


    }
}