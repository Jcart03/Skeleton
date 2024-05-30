<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersStatisticsPage.aspx.cs" Inherits="SuppliersStatisticsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridViewStatiaticsGroupedBySupplierName" runat="server" Height="191px" Width="517px">
        </asp:GridView>
        <asp:GridView ID="GridViewStatisticsGroupedByAddress" runat="server" Height="187px" Width="516px">
        </asp:GridView>
    </form>
</body>
</html>
