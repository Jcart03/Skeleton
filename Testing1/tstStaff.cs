using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            // Create some test data to assign to the property
            string TestData = "Mishrta Nanji";
            // Assign the data to the property
            AnStaff.StaffName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffName, TestData);
        }


        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Some Street";
            //assign the data to the property
            AnStaff.StaffAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffAddress, TestData);

        }
        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStaff staff = new clsStaff();
            // Create some test data to assign to the property
            string TestData = "mishrta.nanji@example.com";
            // Assign the data to the property
            staff.StaffEmail = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(staff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StartingDatePropertyOK()
        {
            // Create an instance of the class we want to test
            clsStaff staff = new clsStaff();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            staff.StartingDate = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(staff.StartingDate, TestData);
        }

        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStaff staff = new clsStaff();
            // Create some test data to assign to the property
            decimal TestData = 50000.00m;
            // Assign the data to the property
            staff.StaffSalary = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(staff.StaffSalary, TestData);
        }

        [TestMethod]
        public void IsManagerPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStaff staff = new clsStaff();
            // Create some test data to assign to the property
            bool TestData = true;
            // Assign the data to the property
            staff.IsManager = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(staff.IsManager, TestData);
        }
    }
}

        
