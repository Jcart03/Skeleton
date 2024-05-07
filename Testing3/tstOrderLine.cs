using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderId = TestData;
            Assert.AreEqual(AnOrderLine.OrderId, TestData);
        }

        [TestMethod]
        public void ShoeNamePropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String TestData = "Air Jordan [11]";
            AnOrderLine.ShoeName = TestData;
            Assert.AreEqual(AnOrderLine.ShoeName, TestData);
        }

        [TestMethod]
        public void OrderQuantityPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderQuantity = TestData;
            Assert.AreEqual(AnOrderLine.OrderQuantity, TestData);
        }
    }
}
