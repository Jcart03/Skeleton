using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Net.Mail;

using System.Security.Cryptography;

using System.Security;


namespace ClassLibrary
{

    //contructor for the class
    public class clsStaffCollection
    {


        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //create the items of test data
        clsStaff mThisStaff = new clsStaff();
        //set its properties 

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }

        }

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StartingDate", mThisStaff.StartingDate);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@IsManager", mThisStaff.IsManager);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StartingDate", mThisStaff.StartingDate);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@IsManager", mThisStaff.IsManager);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }
        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByStaffName(string StaffName)
        {
            //filters the records based on a full or partial staff name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the staffname parameter to the database
            DB.AddParameter("@StaffName", StaffName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffName");
            //populate the array list with the data atble
            PopulateArray(DB);
        }

       void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AnStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AnStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AnStaff.StartingDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartingDate"]);
                AnStaff.StaffSalary = Convert.ToDecimal(DB.DataTable.Rows[Index]["StaffSalary"]);
                AnStaff.IsManager = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsManager"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }
        }
    }
}