using System;
using System.Data;
using System.Reflection;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerId;
        private bool mLogged_In;
        private string mName;
        private string mEmail;
        private string mPassword;
        private string mAddress;
        private DateTime mTimestamp;

        public bool Logged_In {get{return mLogged_In;}set{mLogged_In = value;}}

        public int Customer_Id {get{return mCustomerId;}set{mCustomerId = value;}}

        public string Name {get{return mName;}set{mName = value;}}

        public string Email { get { return mEmail; } set { mEmail = value; } }

        public string Password { get { return mPassword; } set { mPassword = value; } }

        public string Address { get { return mAddress; } set { mAddress = value; } }

        public DateTime Timestamp { get { return mTimestamp; } set { mTimestamp = value; } }

        public bool Find(int customerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customer_Id", customerID);
            DB.Execute("sproc_tblCustomers_FilterByCustomerId");

            if (DB.Count == 1)
            {
                mLogged_In = Convert.ToBoolean(DB.DataTable.Rows[0]["Logged_In"]);
                mCustomerId= Convert.ToInt32(DB.DataTable.Rows[0]["Customer_Id"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Customer_Email"]);
                mTimestamp = Convert.ToDateTime(DB.DataTable.Rows[0]["Timestamp"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Customer_name"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Customer_Hashed_Password"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string address, string email, string timestamp, string name)
        {
            DateTime DateTemp;
            String Error = "";
           
            if (address.Length == 0)
            {
                Error = Error + "The address may not be blank : ";
            }
            if(address.Length > 9)
            {
                Error = Error + "The address must be no greater than 20 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(timestamp);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The timestamp cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The timestamp cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            if(email.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }
            if (email.Length > 255)
            {
                Error = Error + "The email must be no greater than 255 characters : ";
            }

            if (name.Length == 0)
            {
                Error = Error + "The name may not be blank : ";
            }
            if (name.Length > 40)
            {
                Error = Error + "The name must be no greater than 40 characters : ";
            }

            return Error;
        }

        public DataTable StatisticsGroupedByAddress()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomers_Count_GroupByAddress");
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedByTimestamp()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomers_Count_GroupByTimestamp");
            return DB.DataTable;
        }
    }
   
}