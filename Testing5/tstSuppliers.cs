using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

    }
}
