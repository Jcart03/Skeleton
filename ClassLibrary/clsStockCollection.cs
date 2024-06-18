using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //create the items of test data
        clsStock mThisStock = new clsStock();

        //public property for the address list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //sgdhdfhdherherhdhdfdfhhh
            }
        }
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }
        //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            //populate the array list with the data table
            PopulateArray(DB);
            {
                //create a black stock
                clsStock AStock = new clsStock();
                //read in the fields for the current record
                AStock.ShoeAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["ShoeAvailability"]);
                AStock.ShoeId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AStock.ShoeSize = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoeSize"]);
                AStock.ShoePrice = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoePrice"]);
                AStock.ShoeBrand = Convert.ToString(DB.DataTable.Rows[Index]["ShoeBrand"]);
                AStock.ShoeColour = Convert.ToString(DB.DataTable.Rows[Index]["ShoeColour"]);
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }
        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@ShoeId", mThisStock.ShoeId);
            DB.AddParameter("@ShoeSize", mThisStock.ShoeSize);
            DB.AddParameter("@ShoeColour", mThisStock.ShoeColour);
            DB.AddParameter("@ShoePrice", mThisStock.ShoePrice);
            DB.AddParameter("@ShoeBrand", mThisStock.ShoeBrand);
            DB.AddParameter("@ShoeAvailability", mThisStock.ShoeAvailability);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ShoeId", mThisStock.ShoeId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByShoeColour(string ShoeColour)
        {
            //filters the records based on a full or partial shoe colour
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the database
            DB.AddParameter("@ShoeColour", ShoeColour);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByShoeColour");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address object
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.ShoeAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["ShoeAvailability"]);
                AStock.ShoeId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AStock.ShoeSize = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoeSize"]);
                AStock.ShoePrice = Convert.ToInt32(DB.DataTable.Rows[Index]["ShoePrice"]);
                AStock.ShoeBrand = Convert.ToString(DB.DataTable.Rows[Index]["ShoeBrand"]);
                AStock.ShoeColour = Convert.ToString(DB.DataTable.Rows[Index]["ShoeColour"]);
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }
    }
}
