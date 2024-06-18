using System;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the stock id property
        private Int32 mShoeId;
        //shoe id public property
        public int ShoeId
        {
            get
            {
                //this line of code send data out of the property
                return mShoeId;
            }
            set
            {
                //this line of code allows data into the property
                mShoeId = value;
            }
        }
        //private data member for the stock colour property
        private string mStockColour;
        //stock colour public property
        public string StockColour
        {
            get
            {
                //this line of cod sends data out of the property
                return mStockColour;
            }
            set
            {
                //this line of code allows data into the property
                mStockColour = value;
            }
        }
        //private data member for the stock price property
        private Int32 mStockPrice;
        //stock price property
        public Int32 StockPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mStockPrice;
            }
            set
            {
                //this line of code allows data into the property
                mStockPrice = value;
            }
        }
        //private data member for the town property
        private string mStockBrand;
        //stock brand property
        public string StockBrand
        {
            get
            {
                //this line of code sends data into the property
                return mStockBrand;
            }
            set
            {
                //this line of code allows data into the property
                mStockBrand = value;
            }
        }
        //private data member for the stock availability property
        private bool mStockAvailability;
        //stock availability public property
        public bool StockAvailability
        {
            get
            {
                //this line of code allows data out the property
                return mStockAvailability;
            }
            set
            {
                //this line of code allows data into the property
                mStockAvailability = value;
            }
        }
        //private data member for the date added property
        private DateTime mDateAdded;
        //date added public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        //find method
        public bool Find(int ShoeId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@ShoeId", ShoeId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByShoeId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from database to the private data members
                mShoeId = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeId"]); int
                mStockSize = Convert.ToInt32(DB.DataTable.Rows[0]["StockSize"]); //int
                mStockColour = Convert.ToString(DB.DataTable.Rows[0]["StockColour"]);//varhcar 50
                mStockPrice = Convert.ToInt32(DB.DataTable.Rows[0]["StockPrice"]);//int
                mStockBrand = Convert.ToString(DB.DataTable.Rows[0]["StockBrand"]);//varchar 50
                mStockAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["StockAvailability"]);//bit
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everything worked OK
                return true;
            }
            //is no record was found
            else
            {

                //return false indicating there is a problem
                return false;
            }
        }
        public bool Active { get; set; }
        public int shoeId { get; set; }
        public int ShoeSize { get; set; }
        public string ShoeColour { get; set; }
        public int ShoePrice { get; set; }
        public string ShoeBrand { get; set; }
        public bool ShoeAvailability { get; set; }

        

        //Statistics Grouped by ShoePrice METHOD

        public DataTable StatisticsGroupedByShoePrice()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Count_GroupShoePrice");
            //There should be either zero, one or more records
            return DB.DataTable;
        }

        //Statistics Grouped by ShoeColour METHOD
        public DataTable StatisticsGroupedByShoeColour()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Count_GroupShoeColour");
            //There should be either zero, one, or more records
            return DB.DataTable;
        }

        
   

        public string Valid(string shoeSize, string shoeColour, string shoePrice, string shoeBrand,string DateAdded)
        {
                //shoe id validation
                //create a string variable to store the error
                String Error = "";
                DateTime DateTemp;
                DateTime DateComp = DateTime.Now.Date;

                try
                {
                    //date added validation
                    //copy the date added value to the DateTemp variable
                    DateTemp = Convert.ToDateTime(DateAdded);
                    //check to see if the data is less than today's date
                    if (DateTemp < DateComp)
                    {
                        Error = Error + "The date cannot be in the past : ";
                    }
                    if (DateTemp > DateComp)
                    {
                        Error = Error + "The date cannot be in the future : ";
                    }
                }
                catch
                {
                    Error = Error + "The date was not a valid date : ";
                }

                //shoe size validation
                if (shoeSize.Length == 0)

                {
                    Error = Error + "The shoe size may not be blank: ";
                }

                if (shoeSize.Length > 40)

                {
                    Error = Error + "The shoe size must be less than 40 characters";
                }
                //shoe colour validation
                if (shoeColour.Length == 0)

                {
                    Error = Error + "The shoe colour may not be blank : ";
                }

                if (shoeColour.Length > 20)

                {
                    Error = Error + "The shoe colour must be less than 20 characters : ";

                }
                //shoe brand validation
                if (shoeBrand.Length == 0)

                {
                    Error = Error + "The shoe brand may not be blank : ";
                }

                if (shoeBrand.Length > 15)

                {
                    Error = Error + "The shoe brand must be less than 15 characters : ";

                }
                //shoe price validation
                if (shoePrice.Length == 0)

                {
                    Error = Error + "The shoe price may not be blank : ";
                }

                if (shoePrice.Length > 10)

                {
                    Error = Error + "The shoe brand must be less than 10 characters : ";

                }
                //return any error messages
                return Error;
            }

        public void Find(string v)
        {
            throw new NotImplementedException();
        }
    }
    }
 
