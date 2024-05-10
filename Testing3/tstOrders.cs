﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace Testing3
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

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
        public void OrderTimePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            TimeSpan TestData = DateTime.Now.TimeOfDay;
            AnOrder.OrderTime = TestData;
            Assert.AreEqual(AnOrder.OrderTime, TestData);
        }

        [TestMethod]
        public void OrderShippedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.OrderShipped = TestData;
            Assert.AreEqual(AnOrder.OrderShipped, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //OrderShipped
        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsOrder AnOrder = new clsOrder(); 
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerName != "Test Customer")
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
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.StaffName != "Test Staff")
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
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderNotes != "Test Notes")
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
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate != Convert.ToDateTime("01/01/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTimeFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 21;
            DateTime OrderTime = new DateTime();
            CultureInfo provider = CultureInfo.InvariantCulture;
            OrderTime = DateTime.ParseExact("12:00", "HH:mm", provider);
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderTime != OrderTime.TimeOfDay)
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
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderShipped != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
