using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;

    void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderId);
        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtCustomerName.Text = OrderBook.ThisOrder.CustomerName.ToString();
        txtStaffName.Text = OrderBook.ThisOrder.StaffName.ToString();
        txtOrderNotes.Text = OrderBook.ThisOrder.OrderNotes.ToString();
        txtOrderItem.Text = OrderBook.ThisOrder.OrderItem.ToString();
        txtOrderQuantity.Text = OrderBook.ThisOrder.OrderQuantity.ToString();
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.Date.ToString();
        chkOrderShipped.Checked = OrderBook.ThisOrder.OrderShipped;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrder();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        
        // capture CustomerName
        string CustomerName = txtCustomerName.Text;
        // capture StaffName
        string StaffName = txtStaffName.Text;
        // capture OrderNotes
        string OrderNotes = txtOrderNotes.Text;
        // capture OrderDate
        string OrderDate = txtOrderDate.Text;
        // capture OrderItem
        string OrderItem = txtOrderItem.Text;
        // capture OrderQuantity
        string OrderQuantity = txtOrderQuantity.Text;

        // validate and catch any error message       
        string Error = AnOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
        if (Error == "")
        {
            // capture the OrderId
            AnOrder.OrderId = OrderId;
            // capture validated CustomerName
            AnOrder.CustomerName = CustomerName;
            // capture validated StaffName
            AnOrder.StaffName = StaffName;
            // capture validated OrderNotes
            AnOrder.OrderNotes = OrderNotes;
            // capture validated OrderDate
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            // capture validated OrderItem
            AnOrder.OrderItem = OrderItem;
            // capture validated OrderQuantity
            AnOrder.OrderQuantity = Convert.ToInt32(OrderQuantity);
            // capture OrderShipped
            AnOrder.OrderShipped = chkOrderShipped.Checked;

            // create new collection instance
            clsOrderCollection OrderList = new clsOrderCollection();

            // if this is a new record (OrderId = -1)
            if (OrderId == -1)
            {
                // add the new record
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            // otherwise update the record
            else
            {
                // find record, set record, and update
                OrderList.ThisOrder.Find(OrderId);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            // redirect back to list page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            // display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        try
        {
            OrderId = Convert.ToInt32(txtOrderId.Text);
            Found = AnOrder.Find(OrderId);
            if (Found)
            {
                txtCustomerName.Text = AnOrder.CustomerName;
                txtStaffName.Text = AnOrder.StaffName;
                txtOrderNotes.Text = AnOrder.OrderNotes;
                txtOrderItem.Text = AnOrder.OrderItem;
                txtOrderQuantity.Text = Convert.ToString(AnOrder.OrderQuantity);
                txtOrderDate.Text = AnOrder.OrderDate.Date.ToString();
                chkOrderShipped.Checked = AnOrder.OrderShipped;
            }
        }
        catch
        {
            lblError.Text = lblError.Text + "Order with that OrderId does not exist : ";
        }
    }
}