using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.IO;
using System.Net;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        string StaffName = "somename";
        string StaffAddress = "somestreet";
        string StaffEmail = "some@email.com";
        string StartingDate = DateTime.Now.ToShortDateString();
        string StaffSalary = "37000";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
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
            DateTime TestData = DateTime.Now;
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
            Assert.IsTrue(Found);
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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
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
            if (AnStaff.StaffSalary != 37532)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //create some test sata to pass to the method
            string StaffName = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "a"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            string error = "";
            //create some test data to pass to the method
            string StaffName = "aa"; //this should be ok
                                     //invoke the method
            error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            string error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(59, 'a'); //this should be ok
                                                     //invoke the method
            error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            string error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(60, 'a'); //this should be ok
                                                     //invoke the method
            error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            string error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(30, 'a');//this should be ok
                                                    //invoke the method
            error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            // test data w/ 101 characters
            string StaffName = "";
            StaffName = StaffName.PadRight(61, 'a');
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void StaffAddressMinLessOne()
        {

            clsStaff AnStaff = new clsStaff();
            String error = "";
            //create some test sata to pass to the method
            string StaffAddress = ""; //this should trigger an error
            //invoke the method
            error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "a"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "aa"; //this should be ok
                                     //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(99, 'a'); //this should be ok
                                                     //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(100, 'a'); //this should be ok
                                                     //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(50, 'a');//this should be ok
                                                    //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            // test data w/ 101 characters
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(101, 'a');
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //create some test sata to pass to the method
            string StaffEmail = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "a"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "aa"; //this should be ok
                                     //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(49, 'a'); //this should be ok
                                                     //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(50, 'a'); //this should be ok
                                                     //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(25, 'a');//this should be ok
                                                    //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            // test data w/ 51 characters
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(51, 'a');
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }


        [TestMethod]
        public void StartingDateExtremeMin()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //create some test sata to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String StartingDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartingDateMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //create some test sata to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            String StartingDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartingDateMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            // test data w/ today's date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StartingDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void StartingDateMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //create some test sata to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            String StartingDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartingDateExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //create some test sata to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String StartingDate = TestDate.ToString();
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartingDateInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //create some test sata to pass to the method
            String StartingDate = "this is not a date!";
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffSalaryMinLessOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //create some test sata to pass to the method
            string StaffSalary = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "a"; //this should be ok
                                    //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "aa"; //this should be ok
                                     //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "";
            StaffSalary = StaffSalary.PadRight(17, 'a'); //this should be ok
                                                     //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffSalary = "";
            StaffSalary = StaffSalary.PadRight(18, 'a'); //this should be ok
                                                     //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffSalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string StaffSalary = "";
            StaffSalary = StaffSalary.PadRight(9, 'a');//this should be ok
                                                    //invoke the method
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            // test data w/ 101 characters
            string StaffSalary = "";
            StaffSalary = StaffSalary.PadRight(19, 'a');
            Error = AnStaff.Valid(StaffName, StaffAddress, StaffEmail, StartingDate, StaffSalary);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void StatStatisticsGroupedByStaffAddress()

        { 
            clsStaff AnStaff = new clsStaff();
            DataTable dT = AnStaff.StatisticsGroupedByStaffAddress();
            int noOfRecord = 9;
            //test
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        

        }

        [TestMethod]
        public void StatStatisticsGroupedByStaffSalary()
        {
            clsStaff AnStaff = new clsStaff();
            DataTable dT = AnStaff.StatisticsGroupedByStaffSalary();
            int noOfRecord = 4;
            //test
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}



