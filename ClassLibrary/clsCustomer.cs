using System;

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
            mCustomerId = 1;
            mTimestamp = Convert.ToDateTime("23/12/2022");
            mLogged_In = false;
            mName = "John";
            mEmail = "John@email.com";
            mPassword = "pass";
            mAddress = "Addr";
            return true;
        }

        public string Valid(string address, string email, string timestamp, string name)
        {
            DateTime DateTemp;
            String Error = "";
           
            if (address.Length == 0)
            {
                Error = Error + "The address may not be blank : ";
            }
            if(address.Length > 20)
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
    }
   
}