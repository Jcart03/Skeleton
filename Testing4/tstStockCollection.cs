using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance od the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to thhproperty
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ShoeId = 5;
            TestItem.ShoeSize = 7;
            TestItem.ShoeColour = "Orange";
            TestItem.ShoePrice = 50;
            TestItem.ShoeBrand = "Converse";
            TestItem.ShoeAvailability = true;
            TestItem.DateAdded = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set its properties
            TestStock.ShoeId = 5;
            TestStock.ShoeSize = 5;
            TestStock.ShoeColour = "Orange";
            TestStock.ShoePrice = 50;
            TestStock.ShoeBrand = "Converse";
            TestStock.ShoeAvailability = true;
            TestStock.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ShoeId = 5;
            TestItem.ShoeSize = 7;
            TestItem.ShoeColour = "Orange";
            TestItem.ShoePrice = 50;
            TestItem.ShoeBrand = "Converse";
            TestItem.ShoeAvailability = true;
            TestItem.DateAdded = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            //initialize the primary key variable
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ShoeId = 5;
            TestItem.ShoeSize = 7;
            TestItem.ShoeColour = "Orange";
            TestItem.ShoePrice = 50;
            TestItem.ShoeBrand = "Converse";
            TestItem.ShoeAvailability = true;
            TestItem.DateAdded = DateTime.Now;
            //assign the data to the property
            AllStock.ThisStock = TestItem;
            //call the add method to add the test item to the stock collection
            PrimaryKey = AllStock.Add();
            //set the shoeid of the test item to the returned primary key
            TestItem.ShoeId = PrimaryKey;
            //find the stock item in the collection using the primary key
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            //initialize the primary key variable
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ShoeId = 5;
            TestItem.ShoeSize = 7;
            TestItem.ShoeColour = "Orange";
            TestItem.ShoePrice = 50;
            TestItem.ShoeBrand = "Converse";
            TestItem.ShoeAvailability = true;
            TestItem.DateAdded = DateTime.Now;
            //assign the data to the property
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            //set its properties
            TestItem.ShoeId = 10;
            TestItem.ShoeSize = 11;
            TestItem.ShoeColour = "Red";
            TestItem.ShoePrice = 90;
            TestItem.ShoeBrand = "Adidas";
            TestItem.ShoeAvailability = true;
            TestItem.DateAdded = DateTime.Now;
            //assign the data to the property
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if this stock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestItem = new clsStock();
            //initialize the primary key variable
            int PrimaryKey = 0;
            //set its properties
            TestItem.ShoeId = 5;
            TestItem.ShoeSize = 7;
            TestItem.ShoeColour = "Orange";
            TestItem.ShoePrice = 50;
            TestItem.ShoeBrand = "Converse";
            TestItem.ShoeAvailability = true;
            TestItem.DateAdded = DateTime.Now.Date;
            //set thisstock to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestItem.ShoeId = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the item
            AllStocks.Delete();
            //now find the record
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByShoeColourMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStocks.ReportByShoeColour("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }
        [TestMethod]
        public void ReportByShoeColourNoneFound()
        {
            //create an instance of the class we want to create
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a post code that doesnt exist
            FilteredStocks.ReportByShoeColour("");
            Assert.AreEqual(0, FilteredStocks.Count);
        }
        [TestMethod]
        public void ReportByShoeColourTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a post code that doesnt exist
            FilteredStocks.ReportByShoeColour("");
            //check that the correct number of records are found
            if (FilteredStocks.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredStocks.StockList[0].ShoeId != 25)
                {
                    OK = false;

                }
                //check to see that the first record is 26
                if (FilteredStocks.StockList[0].ShoeId != 26)
                {
                    OK = false;

                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}