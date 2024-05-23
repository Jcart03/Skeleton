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

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Logged_In = true;
            TestItem.Customer_Id = 3;
            TestItem.Timestamp = DateTime.Now;
            TestItem.Email = "Bella@gmail.com";
            TestItem.Name = "Bella";
            TestItem.Password = "swagmaster420";
            TestItem.Address = "Cv82hj";

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.Customer_Id = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod] 
        public void DeleteMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;
            TestItem.Logged_In = true;
            TestItem.Customer_Id = 25;
            TestItem.Timestamp = DateTime.Now;
            TestItem.Email = "Bella@gmail.com";
            TestItem.Name = "Bella";
            TestItem.Password = "swagmaster420";
            TestItem.Address = "Cv82hj";

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.Customer_Id = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);



        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;
            TestItem.Logged_In = true;
            TestItem.Customer_Id = 3;
            TestItem.Timestamp = DateTime.Now;
            TestItem.Email = "Bella@gmail.com";
            TestItem.Name = "Bella";
            TestItem.Password = "swagmaster420";
            TestItem.Address = "Cv82hj";

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();

            TestItem.Customer_Id = PrimaryKey;
            TestItem.Logged_In = false;
            TestItem.Customer_Id = 1;
            TestItem.Timestamp = DateTime.Now;
            TestItem.Email = "Bella2@gmail.com";
            TestItem.Name = "Bella2";
            TestItem.Password = "swagmaster4202";
            TestItem.Address = "Cv82hd";

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);



        }

        [TestMethod]
        public void ReportByAddressMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
  
            clsCustomerCollection filter = new clsCustomerCollection();
            filter.ReportByAddress("");
            Assert.AreEqual(AllCustomers.Count, filter.Count);



        }
        [TestMethod]
        public void ReportByAddressNoneFound()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomerCollection filter = new clsCustomerCollection();
            filter.ReportByAddress("xxxxxxxxx");
            Assert.AreEqual(0, filter.Count);



        }
        [TestMethod]
        public void ReportByAddressTestDataFound()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Boolean OK = true;
            clsCustomerCollection filter = new clsCustomerCollection();
            filter.ReportByAddress("xxxxxx");


            if (filter.Count == 2)
            {
                if (filter.CustomerList[0].Customer_Id != 19)
                {
                    OK = false;
                }
                if (filter.CustomerList[1].Customer_Id != 26)
                {
                    OK = false;
                }
            } else
            {
                OK = false;
            }
            Assert.IsTrue(OK);



        }



    }
}
