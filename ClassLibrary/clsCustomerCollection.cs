using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.Logged_In = Convert.ToBoolean(DB.DataTable.Rows[Index]["Logged_In"]);
                ACustomer.Customer_Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Customer_Id"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Email"]);
                ACustomer.Timestamp = Convert.ToDateTime(DB.DataTable.Rows[Index]["Timestamp"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Name"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Address"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Password"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }
        public List<clsCustomer> CustomerList 
        { 
            get
            {
                return mCustomerList;
            } 
            set
            {
                mCustomerList = value;
            }
        }
        public int Count 
        { 
            get
            {
                return mCustomerList.Count;
            } 
            set
            {

            }
        }
        public clsCustomer ThisCustomer { get; set; }
    }
}