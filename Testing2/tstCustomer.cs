using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOKc(){clsCustomer ACustomer = new clsCustomer();}
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
    }
}
