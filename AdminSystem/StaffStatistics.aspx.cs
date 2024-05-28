using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class StaffStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff clsStaff = new clsStaff();

        //retrieve data from the datbase 
        DataTable dT = clsStaff.StatisticsGroupedByStaffAddress();

        //upload dT into gridview
        GridViewStGroupByStaffAddress.DataSource = dT;
        GridViewStGroupByStaffAddress.DataBind();

        GridViewStGroupByStaffAddress.HeaderRow.Cells[0].Text = " Total ";

        dT = clsStaff.StatisticsGroupedByStaffAddress();

        //upload
        GridViewStGroupByStaffSalary.DataSource = dT;
        GridViewStGroupByStaffSalary.DataBind();

        //change the header 
        GridViewStGroupByStaffSalary.HeaderRow.Cells[0].Text = " Total ";

    }
}