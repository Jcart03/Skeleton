using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing1
{
    [TestClass]
    public class TstStaffCollection
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
        public void DeleteMethodOK()
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
            //set thisstaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaffs.Delete();
            //now find the record
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByStaffNameMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            FilteredStaffs.ReportByStaffName("");
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByStaffNameNoneFound() 
        {
            // create an instance of the class we want to create
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a staff name that doesnt exist
            FilteredStaffs.ReportByStaffName("");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs);
        }
        [TestMethod]
        public void ReportByStaffNameTestDataFound()
        {
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a post code that doesnt exist
            FilteredStaffs.ReportByStaffName("");
            //check that the correct number of records are found
            if (FilteredStaffs.Count == 2)
            {
                //check to see that the first record is 25
                if (FilteredStaffs.StaffList[0].StaffId != 25)
                {
                    OK = false;

                }
                //check to see that the first record is 26
                if (FilteredStaffs.StaffList[0].StaffId != 26)
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
