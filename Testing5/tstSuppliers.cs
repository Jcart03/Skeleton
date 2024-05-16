using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSuppliers
    {
        [TestMethod]
        public void TestMethodOK()
        {
            //create an instance of thee class we want to create
            clsSuppliers AnSuppliers = new clsSuppliers();
            //Test to see that it exists
            Assert.IsNotNull(AnSuppliers);
        }
    }
}
