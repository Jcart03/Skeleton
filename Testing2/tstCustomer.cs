using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        string name = "john";
        string address = "Leicester";
        string email = "John@email.com";
        string timestamp = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOKc() { clsCustomer ACustomer = new clsCustomer(); }
        [TestMethod]
        public void Logged_In() { clsCustomer ACustomer = new clsCustomer(); Boolean TestData = true; ACustomer.Logged_In = TestData; Assert.AreEqual(ACustomer.Logged_In, TestData); }
        [TestMethod]
        public void CustomerId() { clsCustomer ACustomer = new clsCustomer(); int TestData = 0; ACustomer.Customer_Id = TestData; Assert.AreEqual(ACustomer.Customer_Id, TestData); }
        [TestMethod]
        public void Name() { clsCustomer ACustomer = new clsCustomer(); string TestData = ""; ACustomer.Name = TestData; Assert.AreEqual(ACustomer.Name, TestData); }
        [TestMethod]
        public void Email() { clsCustomer ACustomer = new clsCustomer(); string TestData = ""; ACustomer.Email = TestData; Assert.AreEqual(ACustomer.Email, TestData); }
        [TestMethod]
        public void Pwd() { clsCustomer ACustomer = new clsCustomer(); string TestData = ""; ACustomer.Password = TestData; Assert.AreEqual(ACustomer.Password, TestData); }
        [TestMethod]
        public void Address() { clsCustomer ACustomer = new clsCustomer(); string TestData = ""; ACustomer.Address = TestData; Assert.AreEqual(ACustomer.Address, TestData); }
        [TestMethod]
        public void Timestamp() { clsCustomer ACustomer = new clsCustomer(); DateTime TestData = DateTime.Now.Date; ACustomer.Timestamp = TestData; Assert.AreEqual(ACustomer.Timestamp, TestData); }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerID = 21;
            Found = ACustomer.Find(CustomerID);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 19;
            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Customer_Id != 19)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCustomerTimestampFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 19;
            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Timestamp != Convert.ToDateTime("01/01/1754"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCustomerLoggedInFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 19;
            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Logged_In != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 19;
            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Name != "Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 19;
            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Email != "Email")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 19;
            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Password != "Pass")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 19;
            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Address != "xxxxxx")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            Error = ACustomer.Valid(address, email, timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = new string('a', 0);
            Error = ACustomer.Valid(Address, email, timestamp, name);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = new string('a', 1);
            Error = ACustomer.Valid(Address, email, timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = new string('a', 2);
            Error = ACustomer.Valid(Address, email, timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = new string('a', 8);
            Error = ACustomer.Valid(Address, email, timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = new string('a', 10);
            Error = ACustomer.Valid(Address, email, timestamp, name);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = new string('a', 9);
            Error = ACustomer.Valid(Address, email, timestamp, name);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = new string('a', 5);
            Error = ACustomer.Valid(Address, email, timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax() 
        { 
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = new string('a', 500);
            Error = ACustomer.Valid(Address, email, timestamp, name);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = new string('a', 0);
            Error = ACustomer.Valid(address, Email, timestamp, name);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = new string('a', 1);
            Error = ACustomer.Valid(address, Email, timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = new string('a', 2);
            Error = ACustomer.Valid(address, Email, timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = new string('a', 254);
            Error = ACustomer.Valid(address, Email, timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = new string('a', 256);
            Error = ACustomer.Valid(address, Email, timestamp, name);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = new string('a', 255);
            Error = ACustomer.Valid(address, Email, timestamp, name);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = new string('a', 127);
            Error = ACustomer.Valid(address, Email, timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = new string('a', 500);
            Error = ACustomer.Valid(address, Email, timestamp, name);
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Name = new string('a', 0);
            Error = ACustomer.Valid(address, email, timestamp, Name);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Name = new string('a', 1);
            Error = ACustomer.Valid(address, email, timestamp, Name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Name = new string('a', 2);
            Error = ACustomer.Valid(address, email, timestamp, Name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Name = new string('a', 39);
            Error = ACustomer.Valid(address, email, timestamp, Name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Name = new string('a', 41);
            Error = ACustomer.Valid(address, email, timestamp, Name);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Name = new string('a', 40);
            Error = ACustomer.Valid(address, email, timestamp, Name);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Name = new string('a', 20);
            Error = ACustomer.Valid(address, email, timestamp, Name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Name = new string('a', 500);
            Error = ACustomer.Valid(address, email, timestamp, Name);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void DateMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string Timestamp = TestDate.ToString();
            Error = ACustomer.Valid(address, email, Timestamp, name);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Timestamp = TestDate.ToString();
            Error = ACustomer.Valid(address, email, Timestamp, name);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string Timestamp = TestDate.ToString();
            Error = ACustomer.Valid(address, email, Timestamp, name);
            Assert.AreNotEqual(Error, "");
        }
       
        [TestMethod]
        public void DateExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string Timestamp = TestDate.ToString();
            Error = ACustomer.Valid(address, email, Timestamp, name);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string Timestamp = TestDate.ToString();
            Error = ACustomer.Valid(address, email, Timestamp, name);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateInvalid() 
        {  
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Timestamp = "notdate";
            Error = ACustomer.Valid(address, email, Timestamp, name);
            Assert.AreNotEqual(Error, "");
        }








    }
}
