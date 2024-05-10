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
        public TimeSpan mOrderTime;
        public TimeSpan OrderTime
        {
            get
            {
                return mOrderTime;
            }
            set
            {
                mOrderTime = value;
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

        public bool Find(int orderId)
        {
            mOrderId = 21;
            mCustomerName = "Test Customer";
            mStaffName = "Test Staff";
            mOrderNotes = "Test Notes";
            mOrderDate = Convert.ToDateTime("01/01/2001");
            DateTime OrderTime = new DateTime();
            CultureInfo provider = CultureInfo.InvariantCulture;
            OrderTime = DateTime.ParseExact("12:00", "HH:mm", provider);
            mOrderTime = OrderTime.TimeOfDay;
            mOrderShipped = true;
            return true;
        }
    }


}