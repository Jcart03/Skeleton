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
    }
}