using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void LoggedInOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean TestData = true;

            ACustomer.Logged_In = TestData;
            Assert.AreEqual(ACustomer.Logged_In, TestData);
        }

        [TestMethod]
        public void TimestampOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Date TestData = DateTime.Now.Date;

            ACustomer.Timestamp = TestData;
            Assert.AreEqual(ACustomer.Timestamp, TestData);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            int TestData = "0";

            ACustomer.Customer_Id = TestData;
            Assert.AreEqual(ACustomer.Customer_Id, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            string TestData = "";

            ACustomer.Name = TestData;
            Assert.AreEqual(ACustomer.Name, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            string TestData = "";

            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void PwdOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            string TestData = "";

            ACustomer.Password = TestData;
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            string TestData = "";

            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);
        }
    }
}
