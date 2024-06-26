﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "CustomerName";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection FilteredOrders = new clsOrderCollection();
        FilteredOrders.ReportByCustomerName(txtCustomerNameFilter.Text);
        lstOrderList.DataSource = FilteredOrders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "CustomerName";
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        AllOrders.ReportByCustomerName("");
        txtCustomerNameFilter.Text = "";
        lstOrderList.DataSource = AllOrders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "CustomerName";
        lstOrderList.DataBind();
    }

    protected void btnStatisticsPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersStatistics.aspx");
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
