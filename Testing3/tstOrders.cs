using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Globalization;

namespace Testing3
{
    [TestClass]
    public class tstOrders
    {
        // clean data for tests
        string CustomerName = "John";
        string StaffName = "Ben";
        string OrderNotes = "Doorbell is broken, please knock.";
        string OrderDate = DateTime.Now.Date.ToString();
        string OrderItem = "Air Jordans";
        string OrderQuantity = "1";

        // - INSTANCE AND PROPERTY TESTS

        // clsOrder instance test

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        // clsOrder property tests

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "James";
            AnOrder.CustomerName = TestData;
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "John";
            AnOrder.StaffName = TestData;
            Assert.AreEqual(AnOrder.StaffName, TestData);
        }

        [TestMethod]
        public void OrderNotesPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "Leave behind green bin";
            AnOrder.OrderNotes = TestData;
            Assert.AreEqual(AnOrder.OrderNotes, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderItemPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Air Jordans";
            AnOrder.OrderItem = TestData;
            Assert.AreEqual(AnOrder.OrderItem, TestData);
        }

        [TestMethod]
        public void OrderQuantityPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 2;
            AnOrder.OrderQuantity = TestData;
            Assert.AreEqual(AnOrder.OrderQuantity, TestData);
        }

        [TestMethod]
        public void OrderShippedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.OrderShipped = TestData;
            Assert.AreEqual(AnOrder.OrderShipped, TestData);
        }

        // - FIND METHOD TESTS

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsOrder AnOrder = new clsOrder(); 
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerName != "John Baker")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.StaffName != "Alexa Mill")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderNotesFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderNotes != "Please ship in one package")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate != Convert.ToDateTime("20/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderItemFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderItem != "Air Jordans [9]")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderQuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderQuantity != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderShippedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderShipped != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        // - VALIDATION METHOD TESTS

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            Error = AnOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, "");
        }

        // -- PARAMETER VALIDATION TESTS

        // CustomerName parameter validation test

        [TestMethod]
        public void CustomerNameMinMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 0 characters
            string CustomerName = "";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 1 characters
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(1, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 2 characters
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(2, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void CustomerNameMaxMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 49 characters
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 50 characters
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 51 characters
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 25 characters
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 500 characters
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        // StaffName parameter validation test

        [TestMethod]
        public void StaffNameMinMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 0 characters
            string StaffName = "";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void StaffNameMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 1 characters
            string StaffName = "";
            StaffName = StaffName.PadRight(1, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 2 characters
            string StaffName = "";
            StaffName = StaffName.PadRight(2, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void StaffNameMaxMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 49 characters
            string StaffName = "";
            StaffName = StaffName.PadRight(49, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void StaffNameMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 50 characters
            string StaffName = "";
            StaffName = StaffName.PadRight(50, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 51 characters
            string StaffName = "";
            StaffName = StaffName.PadRight(51, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void StaffNameMid()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 25 characters
            string StaffName = "";
            StaffName = StaffName.PadRight(25, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 500 characters
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        // OrderNotes parameter validation test

        [TestMethod]
        public void OrderNotesMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 0 characters
            string OrderNotes = "";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderNotesMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 1 characters
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(1, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderNotesMaxMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 99 characters
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(99, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderNotesMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 100 characters
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(100, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderNotesMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 101 characters
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(101, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderNotesMid()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 50 characters
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(50, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderNotesExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 500 characters
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(500, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        // OrderDate parameter validation test

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ today's date minus 100 years
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderDateMinMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ today's date minus 1 day
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ today's date
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ today's date plus 1 day
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ today's date plus 100 years
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ string containing sentence instead of date
            string OrderDate = "this is not a date!";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        // OrderItem parameter validation test

        [TestMethod]
        public void OrderItemMinMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 0 characters
            string OrderItem = "";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderItemMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 1 characters
            string OrderItem = "";
            OrderItem = OrderItem.PadRight(1, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderItemMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 2 characters
            string OrderItem = "";
            OrderItem = OrderItem.PadRight(2, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderItemMaxMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 49 characters
            string OrderItem = "";
            OrderItem = OrderItem.PadRight(49, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderItemMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 50 characters
            string OrderItem = "";
            OrderItem = OrderItem.PadRight(50, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderItemMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 51 characters
            string OrderItem = "";
            OrderItem = OrderItem.PadRight(51, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderItemMid()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 25 characters
            string OrderItem = "";
            OrderItem = OrderItem.PadRight(25, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderItemExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ 500 characters
            string OrderItem = "";
            OrderItem = OrderItem.PadRight(500, 'a');
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        // OrderQuantity parameter validation test

        [TestMethod]
        public void OrderQuantityExtremeMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data of -10
            string OrderQuantity = "-10";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderQuantityMinMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data of 0
            string OrderQuantity = "0";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderQuantityMin()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data of 1
            string OrderQuantity = "1";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderQuantityMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data of 2
            string OrderQuantity = "2";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderQuantityMaxMinusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data of 98
            string OrderQuantity = "98";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderQuantityMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data of 99
            string OrderQuantity = "99";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderQuantityMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data of 100
            string OrderQuantity = "100";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderQuantityMid()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data of 50
            string OrderQuantity = "50";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreEqual(Error, ""); // should be valid
        }

        [TestMethod]
        public void OrderQuantityExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data of 9999
            string OrderQuantity = "9999";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        [TestMethod]
        public void OrderQuantityInvalidData()
        {
            clsOrder anOrder = new clsOrder();
            string Error = "";
            // test data w/ string containing sentence instead of numbers
            string OrderQuantity = "this is not a number!";
            Error = anOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
            Assert.AreNotEqual(Error, ""); // should be invalid
        }

        // Statistics method tests

        [TestMethod]
        public void StatStatisticsGroupedByCustomerName()
        {
            clsOrder AnOrder = new clsOrder();
            DataTable dT = AnOrder.StatisticsGroupedByCustomerName();
            int noOfRecord = 3; // ADD CORRECT NUMBER OF RECCORDS HERE

            Assert.AreEqual(noOfRecord, dT.Rows.Count);

        }

        [TestMethod]
        public void StatStatisticsGroupedByItemName()
        {
            clsOrder AnOrder = new clsOrder();
            DataTable dT = AnOrder.StatisticsGroupedByItemName();
            int noOfRecord = 3; // ADD CORRECT NUMBER OF RECCORDS HERE

            Assert.AreEqual(noOfRecord, dT.Rows.Count);
        }
    }
}
