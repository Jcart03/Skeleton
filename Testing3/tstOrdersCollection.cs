﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    [TestClass]
    public class tstOrdersCollection
    {
        // - INSTANCE AND PROPERTY TESTS

        // clsOrderCollection instance test

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        // clsOrderCollection property tests

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderId = 1;
            TestOrder.CustomerName = "John";
            TestOrder.StaffName = "Ben";
            TestOrder.OrderNotes = "Doorbell is broken, please knock.";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderItem = "Air Jordans";
            TestOrder.OrderQuantity = 1;
            TestOrder.OrderShipped = true;
            TestList.Add(TestOrder);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderId = 1;
            TestOrder.CustomerName = "John";
            TestOrder.StaffName = "Ben";
            TestOrder.OrderNotes = "Doorbell is broken, please knock.";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderItem = "Air Jordans";
            TestOrder.OrderQuantity = 1;
            TestOrder.OrderShipped = true;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        // test that Count corresponds to OrderList size

        [TestMethod] 
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderId = 1;
            TestOrder.CustomerName = "John";
            TestOrder.StaffName = "Ben";
            TestOrder.OrderNotes = "Doorbell is broken, please knock.";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderItem = "Air Jordans";
            TestOrder.OrderQuantity = 1;
            TestOrder.OrderShipped = true;
            TestList.Add(TestOrder);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}