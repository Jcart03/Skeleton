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
            DateTime TestData = Convert.ToDateTime("04/04/2024");
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
            Int32 TestData = 6;
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
            string TestData = "KalonVelez";
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
            String TestData = "12FrisbyRoad";
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
            string TestData = "Kvelez@gmail.com";
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
            DateTime TestData = Convert.ToDateTime("06/04/2024");
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
            decimal TestData = 37.532m;
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the results of the validations
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see of the tresult is true
            Assert.IsTrue(!Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the address id
            if (AnStaff.StaffId != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(!OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff name property
            if (AnStaff.StaffName != "KalonVelez")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(!OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff name property
            if (AnStaff.StaffAddress != "12FrisbyRoad")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(!OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff name property
            if (AnStaff.StaffEmail != "Kvelez@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(!OK);
        }


        [TestMethod]
        public void TestStartingDateFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff name property
            if (AnStaff.StartingDate != Convert.ToDateTime("06/04/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(!OK);
        }


        [TestMethod]
        public void TestStaffSalaryFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff name property
            if (AnStaff.StaffSalary != 37.532m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(!OK);
        }

        [TestMethod]
        public void TestIsManagerFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff name property
            if (AnStaff.IsManager != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}



