using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;
using System.Net.Mail;

namespace Testing5
{
    [TestClass]
    public class tstSuppliers
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of thee class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //Test to see that it exists
            Assert.IsNotNull(AnSuppliers);

        }

        public void ActivePropertyOK()
        {
            //create an instnace of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnSuppliers.Active = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnSuppliers.Active, TestData);
        }
        public void SuppiersIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnSuppliers.SuppliersId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.SuppliersId, TestData);
        }
        public void SupplierNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            // Create some test data to assign to the property
            string TestData = "Name name";
            // Assign the data to the property
            AnSuppliers.SuppliersName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnSuppliers.SuppliersName, TestData);
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
            AnSuppliers.Active = TestData;
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
            boolean Found = false;
            Int32 SupplierId = 21;
            Found = anSuppliers.Find(SupplierId);
        }
        [TestMethod]
        public void TestSuppliersIdFound()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;
 
            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.SupplierId != 1) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSuppliersnameFound()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierId = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.Suppliername != "") //
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
            Int32 SupplierId = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.Suppliername != "") //
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
            Int32 Suppliernsme = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.PaymentTerms != "") //
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
            Int32 Suppliernsme = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.ContractStart != Convert.ToDateTime(""))  //
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
            Int32 Suppliernsme = 1;

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
            Int32 Suppliernsme = 1;

            Found = anSuppliers.Find(SupplierId);
            if (anSuppliers.ContactNumber != "")  //  
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
            Error = anSuppliers.Valid(SupplierName, Address, PaymentTerms, ContractStart, IsActive, ContactNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StatStatisticsGroupedBySupplierName()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            DataTable dT = anSuppliers.StatistisGroupedByAddress();
            int noOfRecord = 1;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
        [TestMethod]
        public void StatStatisticsGroupedByAddress()
        {
            clsSuppliers anSuppliers = new clsSuppliers();
            DataTable dT = anSuppliers.StatistisGroupedByAddress();
            int noOfRecord = 1;
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}
