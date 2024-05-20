using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the staff id property
        private Int32 mStaffId;
        //staffid public property
        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        //private data member for the staff name property
        private string mStaffName;
        //staff name public property
        public String StaffName
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }

        //private data member for the staff name property
        private string mStaffAddress;
        //staff name public property
        public string StaffAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffAddress;
            }
            set
            {
                mStaffAddress = value;
            }
        }


        //private data member for the staff name property
        private string mStaffEmail;
        //staff name public property
        public String StaffEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffEmail;
            }
            set
            {
                mStaffEmail = value;
            }
        }


        //private data member for the staff name property
        private DateTime mStartingDate;
        //staff name public property
        public DateTime StartingDate
        {
            get
            {
                //this line of code sends data out of the property
                return mStartingDate;
            }
            set
            {
                mStartingDate = value;
            }
        }

        //private data member for the staff name property
        private Decimal mStaffSalary;
        //staff name public property
        public Decimal StaffSalary
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }
        }

        //private data member for the staff name property
        private Boolean mIsManager;
        //staff name public property
        public bool IsManager
        {
            get
            {
                //this line of code sends data out of the property
                return mIsManager;
            }
            set
            {
                mIsManager = value;
            }
        }

        public bool Find(int staffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStartingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartingDate"]);
                mStaffSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["StaffSalary"]);
                mIsManager = Convert.ToBoolean(DB.DataTable.Rows[0]["IsManager"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }
    }
}