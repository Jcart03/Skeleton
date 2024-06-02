using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


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
            TestItem.SupplierId = 6;
            TestItem.SupplierName = "David"; //
            TestItem.Address = "Upper Down St"; //
            TestItem.PaymentTerms = "Debit";//
            TestItem.ContractStart = Convert.ToDateTime("01-04-2024");//
            TestItem.IsActive = true;
            TestItem.ContactNumber = 001450;//
            TestList.Add(TestItem);
            allSuppliers.SuppliersList = TestList;
            Assert.AreEqual(allSuppliers.SuppliersList, TestList);
        }
        [TestMethod]
        public void ThisSuppliersPropertyOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            clsSuppliers TestSuppliers = new clsSuppliers();
            TestSuppliers.SupplierId = 1;
            TestSuppliers.SupplierName = ""; //
            TestSuppliers.Address = ""; //
            TestSuppliers.PaymentTerms = "";//
            TestSuppliers.ContractStart = DateTime.Now;//
            TestSuppliers.IsActive = true;
            TestSuppliers.ContactNumber = 00;//
            allSuppliers.ThisSuppliers = TestSuppliers;
            Assert.AreEqual(allSuppliers.ThisSuppliers, TestSuppliers);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            List<clsSuppliers> TestList = new List<clsSuppliers>();
            clsSuppliers TestItem = new clsSuppliers();
            TestItem.SupplierId = 1;
            TestItem.SupplierName = ""; //
            TestItem.Address = ""; //
            TestItem.PaymentTerms = "";//
            TestItem.ContractStart = DateTime.Now;//
            TestItem.IsActive = true;
            TestItem.ContactNumber = 00;//
            TestList.Add(TestItem);
            allSuppliers.SuppliersList = TestList;
            Assert.AreEqual(allSuppliers.SuppliersList.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            clsSuppliers TestItem = new clsSuppliers();
            int PrimaryKey = 6; 
            TestItem.SupplierId = 6;
            TestItem.SupplierName = "Jake"; //
            TestItem.Address = "12 Down St"; //
            TestItem.PaymentTerms = "Debit";//
            TestItem.ContractStart = Convert.ToDateTime("01-05-2024");//
            TestItem.IsActive = true;
            TestItem.ContactNumber = 074574852;//
            allSuppliers.ThisSuppliers = TestItem;
            PrimaryKey = allSuppliers.Add();
            allSuppliers.ThisSuppliers.Find(PrimaryKey);
            Assert.AreEqual(allSuppliers.ThisSuppliers, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSuppliersCollection allSuppliers = new clsSuppliersCollection();
            clsSuppliers TestItem = new clsSuppliers();
            int PrimaryKey = 0;
            TestItem.SupplierId = 6;
            TestItem.SupplierName = "Jake"; //
            TestItem.Address = "12 Down St"; //
            TestItem.PaymentTerms = "Debit";//
            TestItem.ContractStart = Convert.ToDateTime("01-05-2024");//
            TestItem.IsActive = true;
            TestItem.ContactNumber = 074574852;//
            allSuppliers.ThisSuppliers = TestItem;
            PrimaryKey = allSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            TestItem.Address = "14 Main St"; //
            TestItem.ContactNumber = 074574752; //
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
            TestItem.SupplierId = 6;
            TestItem.SupplierName = "Jake"; //
            TestItem.Address = "12 Down St"; //
            TestItem.PaymentTerms = "Credit";//
            TestItem.ContractStart = Convert.ToDateTime("01-05-2024");//
            TestItem.IsActive = true;
            TestItem.ContactNumber = 00;//
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
            FilteredSuppliers.ReportBySupplierName("");
            Assert.AreEqual(allSuppliers.Count, FilteredSuppliers.Count);
        }
        [TestMethod]
        public void ReportBySuppliersnameNoneFound()
        {
            clsSuppliersCollection FilteredSuppliers = new clsSuppliersCollection();
            FilteredSuppliers.ReportBySupplierName("xxx");
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }
        [TestMethod]
        public void ReportBySuppliersnameTestDataFound()
        {
            clsSuppliersCollection FilteredSuppliers = new clsSuppliersCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportBySupplierName("Luke");
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