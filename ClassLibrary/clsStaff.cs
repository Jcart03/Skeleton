using System;
using System.Data;
using System.IO;

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

        public bool Find(int StaffId)
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

        public string Valid(string StaffName, string StaffAddress, string StaffEmail, string StartingDate, string StaffSalary)
        {

            string Error = "";
            DateTime DateTemp;

            // staffname validation
            if (StaffName.Length == 0)
            {
                Error = Error + "The staff name may not be blank : ";

            }

            if (StaffName.Length > 60)

            {
                Error = Error + "The staff name must be less than  60 characters : ";
            }


            //startingdate validation 

            DateTime DateComp = DateTime.Now.Date;

            try
            {
                DateTemp = Convert.ToDateTime(StartingDate);

                if (DateTemp < DateComp)
                {
                    Error = Error + "The Date cannot be in the past : ";
                }
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not valid date : ";
            }

            //staffaddress validation
            if (StaffAddress.Length == 0)

            {
                Error = Error + "The staff address may not be blank : ";
            }

            if (StaffAddress.Length > 100)

            {
                Error = Error + "The staff address must be less than 100 characters : ";

            }
            //staff email validation
            if (StaffEmail.Length == 0)

            {
                Error = Error + "The staff email may not be blank : ";
            }

            if (StaffEmail.Length > 50)

            {
                Error = Error + "The staff email must be less than 50 characters : ";

            }
            //staff salary validation
            if (StaffSalary.Length == 0)

            {
                Error = Error + "The staff salary may not be blank : ";
            }

            if (StaffSalary.Length > 18)

            {
                Error = Error + "The staff salary must be less than 18 characters : ";

            }
            return Error;
        }

        /****** Statistics Grouped by StaffAddress method ******/

        public DataTable StatisticsGroupedByStaffAddress()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaff_Count_GroupByStaffAddress");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedByStaffSalary()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaff_Count_GroupByStaffSalary");
            return DB.DataTable;
        }
    }
}


