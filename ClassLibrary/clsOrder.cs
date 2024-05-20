using System;
using System.Globalization;

namespace ClassLibrary
{
    public class clsOrder
    {
        // property definitions
        private Int32 mOrderId;
        public Int32 OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }        
        }
        private string mCustomerName;
        public string CustomerName 
        { 
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }
        public string mStaffName;
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }
        public string mOrderNotes;
        public string OrderNotes
        {
            get
            {
                return mOrderNotes;
            }
            set
            {
                mOrderNotes = value;
            }
        }
        public DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        public string mOrderItem;
        public string OrderItem
        {
            get
            {
                return mOrderItem;
            }
            set
            {
                mOrderItem = value;
            }
        }
        public Int32 mOrderQuantity;
        public Int32 OrderQuantity
        {
            get
            {
                return mOrderQuantity;
            }
            set
            {
                mOrderQuantity = value;
            }
        }
        public bool mOrderShipped;
        public bool OrderShipped
        {
            get
            {
                return mOrderShipped;
            }
            set
            {
                mOrderShipped = value;
            }
        }

        public bool Find(Int32 OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("dbo.sproc_tblOrder_FilterByOrderId");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mOrderNotes = Convert.ToString(DB.DataTable.Rows[0]["OrderNotes"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderItem = Convert.ToString(DB.DataTable.Rows[0]["OrderItem"]);
                mOrderQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["OrderQuantity"]);
                mOrderShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderShipped"]);
                return true;
            }
            else
            {
                return false;
            } 
        }

        public string Valid(string customerName, string staffName, string orderNotes, string orderDate, string orderItem, string orderQuantity)
        {
            String Error = "";
            DateTime DateTemp;
            DateTime DateComp = DateTime.Now.Date;
            Int32 QuantityTemp;

            // CustomerName validation
            if (customerName.Length == 0)
            {
                Error = Error + "The customer name may not be blank : ";
            }
            if (customerName.Length > 50)
            {
                Error = Error + "The customer name cannot be longer than 50 characters : ";
            }

            // StaffName validation
            if (staffName.Length == 0)
            {
                Error = Error + "The staff name may not be blank : ";
            }
            if (staffName.Length > 50)
            {
                Error = Error + "The staff name cannot be longer than 50 characters : ";
            }

            // OrderNotes validation
            if (orderNotes.Length > 100)
            {
                Error = Error + "The order notes cannot be longer than 100 characters : ";
            }

            // OrderDate validation
            try
            {
                DateTemp = Convert.ToDateTime(orderDate);
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

            // OrderItem validation
            if (orderItem.Length == 0)
            {
                Error = Error + "The order item may not be blank : ";
            }
            if (orderItem.Length > 50)
            {
                Error = Error + "The order item cannot be longer than 50 characters : ";
            }

            //OrderQuantity validation
            try
            {
                QuantityTemp = Convert.ToInt32(orderQuantity);
                if (QuantityTemp < 1)
                {
                    Error = Error + "The minimum order quanity is 1 : ";
                }
                if (QuantityTemp > 99)
                {
                    Error = Error + "The maximum order quanity is 99 : ";
                }
            }
            catch
            {
                Error = Error + "The order quantity was not a valid integer : ";
            }

            return Error;
        }
    }


}