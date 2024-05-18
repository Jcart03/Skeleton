using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

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
        public clsOrder ThisOrder { get; set; }

        // class constructor
        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrders_SelectAll");
            RecordCount = DB.Count;
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
    }
}