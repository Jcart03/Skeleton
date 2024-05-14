using System;
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
        if (Session["AnStaff"] != null && Session["AnStaff"] is clsStaff)
        {
            //create a new instance of clsStaff
            clsStaff AnStaff = new clsStaff();
            //get the data from the session object
            AnStaff = (clsStaff)Session["AnStaff"];

            //display the staff data for all these entry
            Response.Write("Staff ID: " + AnStaff.StaffId + "<br/>");
            Response.Write("Staff Name: " + AnStaff.StaffName + "<br/>");
            Response.Write("Staff Address: " + AnStaff.StaffAddress + "<br/>");
            Response.Write("Staff Email: " + AnStaff.StaffEmail + "<br/>");
            Response.Write("Starting Date: " + AnStaff.StartingDate.ToString("yyyy-MM-dd") + "<br/>");
            Response.Write("Staff Salary: " + AnStaff.StaffSalary.ToString("C") + "<br/>");
            Response.Write("Is Manager: " + (AnStaff.IsManager ? "Yes" : "No") + "<br/>");
        }
        else
        {
            // Handle the case where the session object doesn't exist or is of incorrect type
            Response.Write("Session data not found or is invalid.");
        }
        }

    }
