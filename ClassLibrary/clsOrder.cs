using System;
using System.Globalization;

namespace ClassLibrary
{
    public class clsOrder
    {
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
            mOrderId = 21;
            mCustomerName = "Test Customer";
            mStaffName = "Test Staff";
            mOrderNotes = "Test Notes";
            mOrderDate = Convert.ToDateTime("01/01/2001");
            mOrderItem = "Test Item";
            mOrderQuantity = 5;
            mOrderShipped = true;
            return true;
        }

        public string Valid(string customerName, string staffName, string orderNotes, string orderDate, string orderItem, string orderQuantity)
        {
            return "";
        }
    }


}