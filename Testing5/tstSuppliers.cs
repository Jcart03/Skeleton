using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Net;

namespace Testing5
{
    [TestClass]
    public class tstSuppliers
    {
        
        
        string SupplierName = "name";
        string Address = "Address";
        string PaymentTerms = "Debit";
        string ContractStart = ("01-05-2024"); 
        string ContactNumber = "1234567890";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of thee class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //Test to see that it exists
            Assert.IsNotNull(AnSuppliers);

        }

        public void SuppiersIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers anSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            anSuppliers.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anSuppliers.SupplierId, TestData);
        }
        public void SupplierNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsSuppliers anSuppliers = new clsSuppliers();
            // Create some test data to assign to the property
            string TestData = "Name";
            // Assign the data to the property
            anSuppliers.SupplierName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(anSuppliers.SupplierName, TestData);
        }
        public void PaymentTermsPropertyOK()
        {
            // Create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            // Create some test data to assign to the property
            string TestData = "Debit";
            // Assign the data to the property
            AnSuppliers.PaymentTerms = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.PaymentTerms, TestData);
        }
        public void ContractStartPropertyOK()
        {
            // Create an instance of the class we want to test
            clsSuppliers AnSuppliers = new clsSuppliers();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AnSuppliers.ContractStart = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.ContractStart, TestData);
        }
        public void IsActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnSuppliers.IsActive = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.IsActive, TestData);
        }
        public void ContactNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSuppliers.ContactNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.ContactNumber, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Int32 SupplierId = 21;
            Found = anSuppliers.Find(SupplierId);
        }
        [TestMethod]
        public void TestSupplierIdFound()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 2;
            Found = anSuppliers.Find(SupplierId);

            if (anSuppliers.SupplierId != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSuppliernameFound()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierId = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.SupplierName != "John")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressFound()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierId = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.Address != "17 Walnut ST")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPaymentTermsFound()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierId = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.PaymentTerms != "Debit") //
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContractStartFound()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierId = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.ContractStart != Convert.ToDateTime("24/11/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsActiveFound()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierId = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.IsActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactNumberFound()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierId = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.ContactNumber != 79827657)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            string Error = "";
            Error = anSuppliers.Valid(SupplierName, Address, PaymentTerms, ContractStart, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StatStatisticsGroupedBySupplierName()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            DataTable dT = anSuppliers.StatisticsGroupedByAddress();
            int noOfRecord = 1;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupedByAddress()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            DataTable dT = anSuppliers.StatisticsGroupedByAddress();
            int noOfRecord = 1;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }



    }

     
}
