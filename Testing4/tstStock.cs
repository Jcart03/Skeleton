using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
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
    }
}