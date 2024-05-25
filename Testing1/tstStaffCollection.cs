using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that is exists
            Assert.IsNotNull(AllStaffs);
        }
        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffId = 1;
            TestItem.StaffName = "somename";
            TestItem.StaffAddress = "somestreet";
            TestItem.StaffEmail = "some@email.com";
            TestItem.StartingDate = DateTime.Now;
            TestItem.StaffSalary = 37000;
            TestItem.IsManager = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffId = 1;
            TestStaff.StaffName = "somename";
            TestStaff.StaffAddress = "somestreet";
            TestStaff.StaffEmail = "some@email.com";
            TestStaff.StartingDate = DateTime.Now;
            TestStaff.StaffSalary = 37000;
            TestStaff.IsManager = true;
            AllStaffs.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            TestItem.StaffId = 1;
            TestItem.StaffName = "somename";
            TestItem.StaffAddress = "somestreet";
            TestItem.StaffEmail = "some@email.com";
            TestItem.StartingDate = DateTime.Now;
            TestItem.StaffSalary = 37000;
            TestItem.IsManager = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, TestList.Count);

        }

        // Add method test

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffId = 1;
            TestItem.StaffName = "somename";
            TestItem.StaffAddress = "somestreet";
            TestItem.StaffEmail = "some@email.com";
            TestItem.StartingDate = DateTime.Now.Date;
            TestItem.StaffSalary = 37000;
            TestItem.IsManager = true;
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffId = 1;
            TestItem.StaffName = "somename";
            TestItem.StaffAddress = "somestreet";
            TestItem.StaffEmail = "some@email.com";
            TestItem.StartingDate = DateTime.Now.Date;
            TestItem.StaffSalary = 37000;
            TestItem.IsManager = true;
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffId = PrimaryKey;
            TestItem.StaffName = "Randomname";
            TestItem.StaffAddress = "Randomstreet";
            TestItem.StaffEmail = "Random@email.com";
            TestItem.StartingDate = DateTime.Now.Date;
            TestItem.StaffSalary = 30000;
            TestItem.IsManager = false;
            AllStaffs.ThisStaff = TestItem;
            //update the record
            AllStaffs.Update();
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see if thisstaff matches the test data
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }
    }
}
