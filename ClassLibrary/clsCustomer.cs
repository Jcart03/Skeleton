using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Logged_In { get; set; }

        public int Customer_Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public DateTime Timestamp { get; set; }
    }
}