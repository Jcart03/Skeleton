﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write(ACustomer.Customer_Id);
        Response.Write(ACustomer.Name);
        Response.Write(ACustomer.Email);
        Response.Write(ACustomer.Address);
        Response.Write(ACustomer.Password);
        Response.Write(ACustomer.Timestamp);
        Response.Write(ACustomer.Logged_In);

    }
}