<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersStatistics.aspx.cs" Inherits="OrdersStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> <h1> Statistics Page </h1> </div>
        
        <div>
            <h3> Order List - Grouped By Customer Name </h3>
            <asp:GridView ID="GridViewGroupByCustomerName" runat="server"></asp:GridView>
        </div>

        <div>
            <h3> Order List - Grouped By Item Name </h3>
            <asp:GridView ID="GridViewGroupByOrderItem" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Button ID="btnPreviousPage" runat="server" style="margin-top: 50px" Text="Back to Previous Page" OnClick="btnPreviousPage_Click"/>
        </div>
    </form>
</body>
</html>
