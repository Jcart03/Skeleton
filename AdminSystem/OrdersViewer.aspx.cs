using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderId);
        Response.Write(AnOrder.StaffName);
        Response.Write(AnOrder.CustomerName);
        Response.Write(AnOrder.OrderNotes);
        Response.Write(AnOrder.OrderDate);
        Response.Write(AnOrder.OrderItem);
        Response.Write(AnOrder.OrderQuantity);
        Response.Write(AnOrder.OrderShipped);
    }
}