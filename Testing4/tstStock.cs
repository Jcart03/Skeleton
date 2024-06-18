using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.IO;
using System.Net;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass the method
        string ShoeId = "5";
        string ShoeSize = "7";
        string ShoeColour = "Orange";
        string ShoePrice = "50";
        string ShoeBrand = "Converse";
        string DateAdded = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            ///create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Active, TestData);
        }
        [TestMethod]
        public void ShoeIdPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStock stock = new clsStock();

            // Create some test data to assign to the property
            int testData = 1;

            // Assign the data to the property
            stock.ShoeId = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(stock.ShoeId, testData);
        }

        [TestMethod]
        public void ShoeSizePropertyOK()
        {
            // Create an instance of the class we want to test
            clsStock stock = new clsStock();

            // Create some test data to assign to the property
            int testData = 42;

            // Assign the data to the property
            stock.ShoeSize = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(stock.ShoeSize, testData);
        }

        [TestMethod]
        public void ShoeColourPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStock stock = new clsStock();

            // Create some test data to assign to the property
            string testData = "Blue";

            // Assign the data to the property
            stock.ShoeColour = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(stock.ShoeColour, testData);
        }

        [TestMethod]
        public void ShoePricePropertyOK()
        {
            // Create an instance of the class we want to test
            clsStock stock = new clsStock();

            // Create some test data to assign to the property
            int testData = 50;

            // Assign the data to the property
            stock.ShoePrice = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(stock.ShoePrice, testData);
        }

        [TestMethod]
        public void ShoeBrandPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStock stock = new clsStock();

            // Create some test data to assign to the property
            string testData = "Nike";

            // Assign the data to the property
            stock.ShoeBrand = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(stock.ShoeBrand, testData);
        }

        [TestMethod]
        public void ShoeAvailabilityPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStock stock = new clsStock();

            // Create some test data to assign to the property
            bool testData = true;

            // Assign the data to the property
            stock.ShoeAvailability = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(stock.ShoeAvailability, testData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            // Create an instance of the class we want to test
            clsStock stock = new clsStock();

            // Create some test data to assign to the property
            DateTime testData = DateTime.Now.Date;

            // Assign the data to the property
            stock.DateAdded = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(stock.DateAdded, testData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ShoeId = 5;
            //invoke the method
            Found = AStock.Find(ShoeId);
            //test to see id the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestShoeIdFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeId = 5;
            //Invoke the method
            Found = AStock.Find(ShoeId);
            //check the stock id
            if (AStock.ShoeId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeSizeFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeId = 5;
            //Invoke the method
            Found = AStock.Find(ShoeId);
            //check the shoe size
            if (AStock.ShoeSize != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeColourFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeId = 5;
            //Invoke the method
            Found = AStock.Find(ShoeId);
            //check the shoe colour
            if (AStock.ShoeColour != "Orange")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoePriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 10;
            //Invoke the method
            Found = AStock.Find(StockId);
            //check the shoe price
            if (AStock.ShoePrice != 70)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeBrandFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeId = 5;
            //Invoke the method
            Found = AStock.Find(ShoeId);
            //check the shoe brand
            if (AStock.ShoeBrand != "Converse")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeId = 5;
            //Invoke the method
            Found = AStock.Find(ShoeId);
            //check the shoe availability
            if (AStock.ShoeAvailability != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ShoeId = 5;
            //Invoke the method
            Found = AStock.Find(ShoeId);
            //check the shoe price
            if (AStock.DateAdded != Convert.ToDateTime("17/01/2024"))
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
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        ///////////////////////////////////////////////ShoeSize
        [TestMethod]
        public void ShoeSizeNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            String Error = "";
            //create some test data to pass to the method
            string ShoeSize = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeNoMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShoeSize = "a";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeSize = "aa";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some text data to pass to the method
            string ShoeSize = "aaaaa";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShoeSizeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ShoeSize = "aaaaaa";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see  that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ShoeSize = "aaa";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ShoeSize = "aaaaaaa";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        ///////////////////////////////////////////////DateAdded
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date varable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            //convert the date varable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date varable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            //convert the date varable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            //convert the date varable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            String DateAdded = "This is not a date";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        ///////////////////////////////////////////////ShoePrice
        [TestMethod]
        public void ShoePriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ShoePriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoePriceMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoePriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoePriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoePriceMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoePriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoePriceMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoePriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoePriceInvalidDataType()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoePrice = "";
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        ///////////////////////////////////////////////ShoeColour
        [TestMethod]
        public void ShoeColourExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = ""; // Extreme Min (No Characters)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = "a"; // Min - 1 (1 Character)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = "aa"; // Min (Boundary) (2 Characters)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = "aaa"; // Min + 1 (3 Characters)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = new string('a', 49); // Max - 1 (49 Characters)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = new string('a', 50); // Max (Boundary) (50 Characters)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = new string('a', 51); // Max + 1 (51 Characters)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = new string('a', 25); // Mid (25 Characters)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = new string('a', 100); // Extreme Max (100 Characters)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeColourInvalidDataType()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            string Error = "";
            //create some test data to pass to the method
            string ShoeColour = "123456"; // Invalid data type (Numbers)
            //invoke the method
            Error = AStock.Valid(ShoeSize, ShoeColour, ShoePrice, ShoeBrand, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

       

        [TestMethod]
        public void StatStatisticsGroupedByShoePrice()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //invoke the method
            DataTable dT = AStock.StatisticsGroupedByShoePrice();
            //According to the last executed stored procedure, there should be three rows of data.
            int noOfRecord = 2;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }

        [TestMethod]
        public void StatStatStatisticsGroupedByShoeColour()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //invoke the method
            DataTable dT = AStock.StatisticsGroupedByShoeColour();
            //According to the last executed stored procedure, there should be three rows of data.
            int noOfRecord = 10;

            //test to see that the result is correct
            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}


