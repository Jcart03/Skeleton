
using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    //contructor for the class
    public class clsStaffCollection
    {
        //create the items of test data
        clsStaff TestItem = new clsStaff();
        //set its properties 


        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff ThisStaff { get; set; }
    }
}