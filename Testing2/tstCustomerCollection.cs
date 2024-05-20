using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Logged_In = true;
            TestItem.Customer_Id = 1;
            TestItem.Timestamp = DateTime.Now;
            TestItem.Email = "John@email.com";
            TestItem.Name = "John";
            TestItem.Password = "password";
            TestItem.Address = "Le21hg";

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }


        [TestMethod]
        public void ThisCustomerPropertyOK() 
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Logged_In = true;
            TestCustomer.Customer_Id = 1;
            TestCustomer.Timestamp = DateTime.Now;
            TestCustomer.Email = "Fred12@email.com";
            TestCustomer.Name = "Fred12";
            TestCustomer.Password = "Pwd";
            TestCustomer.Address = "Le12gh";

            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();

            TestItem.Logged_In = false;
            TestItem.Customer_Id = 2;
            TestItem.Timestamp = DateTime.Now;
            TestItem.Email = "Jenny86@gmail.co.uk";
            TestItem.Name = "Jenny";
            TestItem.Password = "hhhhhhhhhhhh";
            TestItem.Address = "Cv18gh";

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
      
    }
}
