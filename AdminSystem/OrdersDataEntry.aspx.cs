using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        // capture OrderId
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
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
        // capture OrderShipped
        AnOrder.OrderShipped = chkOrderShipped.Checked;

        // validate and catch any error message       
        string Error = AnOrder.Valid(CustomerName, StaffName, OrderNotes, OrderDate, OrderItem, OrderQuantity);
        if (Error == "")
        {
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

            // navigate to view page
            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrdersViewer.aspx");
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