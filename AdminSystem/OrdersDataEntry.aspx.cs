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
        //capture OrderId
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        //capture CustomerName
        AnOrder.CustomerName = txtCustomerName.Text;
        //capture StaffName
        AnOrder.StaffName = txtStaffName.Text;
        //capture OrderNotes
        AnOrder.OrderNotes = txtOrderNotes.Text;
        //capture OrderDate
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        //capture OrderItem
        AnOrder.OrderItem = txtOrderItem.Text;
        //capture OrderQuantity
        AnOrder.OrderQuantity = Convert.ToInt32(txtOrderQuantity.Text);
        //capture OrderShipped
        AnOrder.OrderShipped = chkOrderShipped.Checked;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrdersViewer.aspx");
    }
}