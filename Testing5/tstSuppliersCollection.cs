using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing5
{
    [TestClass]
    public class tstSuppliersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            Assert.IsNotNull(allSuppliers);
        }
        [TestMethod]
        public void SuppliersListOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            List<clsSuppliers> TestList = new List<clsSuppliers>();
            clsSuppliers TestItem = new clsSuppliers();
            TestItem.SupplierId = 1;
            TestItem.Suppliersname = ""; //
            TestItem.Address = ""; //
            TestItem.PaymentTerms = "";//
            TestItem.ContractStart = DateTime.Now;//
            TestItem.IsActive = true;
            TestItem.ContactNumber = "";//
            TestList.Add(TestItem);
            allSuppliers.SuppliersList = TestList;
            Assert.AreEqual(allSuppliers.SuppliersList, TestList);
        }
        [TestMethod]
        public void ThisSuppliersPropertyOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            clsSuppliers TestSuppliers = new clsSuppliers();
            TestSuppliers.TestItem.SupplierId = 1;
            TestSuppliers.Suppliersname = ""; //
            TestSuppliers.Address = ""; //
            TestSuppliers.PaymentTerms = "";//
            TestSuppliers.ContractStart = DateTime.Now;//
            TestSuppliers.IsActive = true;
            TestSuppliers.ContactNumber = "";//
            TestSuppliers.Add(TestItem);
            allSuppliers.SuppliersList = TestList;
            Assert.AreEqual(allSuppliers.SuppliersList, TestList);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            List<clsSuppliers> TestList = new List<clsSuppliers>();
            clsSuppliers TestItem = new clsSuppliers();
            TestItem.SupplierId = 1;
            TestItem.Suppliersname = ""; //
            TestItem.Address = ""; //
            TestItem.PaymentTerms = "";//
            TestItem.ContractStart = DateTime.Now;//
            TestItem.IsActive = true;
            TestItem.ContactNumber = "";//
            TestList.Add(TestItem);
            allSuppliers.SuppliersList = TestList;
            Assert.AreEqual(allSuppliers.SuppliersList.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            clsSuppliers TestItem = new clsSuppliers();
            int PrimaryKey = 0;
            TestItem.SupplierId = 1;
            TestItem.Suppliersname = ""; //
            TestItem.Address = ""; //
            TestItem.PaymentTerms = "";//
            TestItem.ContractStart = Convert.ToDateTime("");//
            TestItem.IsActive = true;
            TestItem.ContactNumber = "";//
            allSuppliers.ThisSuppliers = TestItem;
            PrimaryKey = allSuppliers.Add();
            allSuppliers.ThisSuppliers.Find(PrimaryKey);
            Assert.AreEqual(allSuppliers.ThisSuppliers,TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            clsSuppliers TestItem = new clsSuppliers();
            int PrimaryKey = 0;
            TestItem.SupplierId = 1;
            TestItem.Suppliersname = ""; //
            TestItem.Address = ""; //
            TestItem.PaymentTerms = "";//
            TestItem.ContractStart = Convert.ToDateTime("");//
            TestItem.IsActive = true;
            TestItem.ContactNumber = "";//
            allSuppliers.ThisSuppliers = TestItem;
            PrimaryKey = allSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            TestItem.Address = ""; //
            TestItem.ContractNumber = ""; //
            allSuppliers.ThisSuppliers = TestItem;
            allSuppliers.Update();
            allSuppliers.ThisSuppliers.Find(PrimaryKey);
            Assert.AreEqual(allSuppliers.ThisSuppliers, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            clsSuppliers TestItem = new clsSuppliers();
            int PrimaryKey = 0;
            TestItem.SupplierId = 1;
            TestItem.Suppliersname = ""; //
            TestItem.Address = ""; //
            TestItem.PaymentTerms = "";//
            TestItem.ContractStart = Convert.ToDateTime("");//
            TestItem.IsActive = true;
            TestItem.ContactNumber = "";//
            allSuppliers.ThisSuppliers = TestItem;
            PrimaryKey = allSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            allSuppliers.Delete();
            Boolean Found = allSuppliers.ThisSuppliers.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportBySuppliersnameMethodOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            clsSuppliersCollection FilteredSuppliers = new clsSuppliersCollection();
            FilteredSuppliers.ReportBySuppliersname("");
            Assert.AreEqual(allSuppliers.Count, FilteredSuppliers.Count);
        }
        [TestMethod]
        public void ReportBySuppliersnameNoneFound()
        {
            clsSuppliersCollection FilteredSuppliers = new clsSuppliersCollection();
            FilteredSuppliers.ReportBySuppliersname("");
            Assert.AreEqual(0, FilteredSuppliers);
        }
        [TestMethod]
        public void ReportBySuppliersnameTestDataFound()
        {
            clsSuppliersCollection FilteredSuppliers = new clsSuppliersCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportBySuppliersname("");
            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.SuppliersList[0].SupplierId != 25)
                {
                    OK = false;

                }

                if (FilteredSuppliers.SuppliersList[0].SupplierId != 26)
                {
                    OK = false;

                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
