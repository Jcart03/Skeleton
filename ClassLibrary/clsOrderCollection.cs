using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        // private data member for ThisOrder
        clsOrder mThisOrder = new clsOrder();

        // property definitions
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public Int32 Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                // to be completed
            }
        } 
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        // class constructor
        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("dbo.sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrder.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AnOrder.OrderNotes = Convert.ToString(DB.DataTable.Rows[Index]["OrderNotes"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.OrderItem = Convert.ToString(DB.DataTable.Rows[Index]["OrderItem"]);
                AnOrder.OrderQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderQuantity"]);
                AnOrder.OrderShipped = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderShipped"]);

                mOrderList.Add(AnOrder);
                Index++;
            }
        }

        public Int32 Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@StaffName", mThisOrder.StaffName);
            DB.AddParameter("@OrderNotes", mThisOrder.OrderNotes);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderItem", mThisOrder.OrderItem);
            DB.AddParameter("@OrderQuantity", mThisOrder.OrderQuantity);
            DB.AddParameter("@OrderShipped", mThisOrder.OrderShipped);

            return DB.Execute("dbo.sproc_tblOrder_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@StaffName", mThisOrder.StaffName);
            DB.AddParameter("@OrderNotes", mThisOrder.OrderNotes);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@OrderItem", mThisOrder.OrderItem);
            DB.AddParameter("@OrderQuantity", mThisOrder.OrderQuantity);
            DB.AddParameter("@OrderShipped", mThisOrder.OrderShipped);

            DB.Execute("dbo.sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);

            DB.Execute("dbo.sproc_tblOrder_Delete");

        }

        public void ReportByCustomerName(string CustomerName)
        {
            // Filters the records based on a full or partial customer name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", CustomerName);
            DB.Execute("dbo.sproc_tblOrder_FilterByCustomerName");
            PopulateArray(DB);
        }
    }
}