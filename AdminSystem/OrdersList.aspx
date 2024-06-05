<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:ListBox ID="lstOrderList" runat="server" Height="500px" Width="500px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 525px; position: absolute;" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 60px; top: 525px; position: absolute;" Text="Edit" OnClick="btnEdit_Click"/>
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 110px; top: 525px; position: absolute;" Text="Delete" OnClick="btnDelete_Click"/>
            <asp:Label ID="lblTextBox" runat="server" style="z-index: 1; left: 10px; top: 575px; position: absolute;" Text="Enter a Customer Name: "></asp:Label>      
            <asp:TextBox ID="txtCustomerNameFilter" runat="server" style="z-index: 1; left: 200px; top: 575px; position: absolute;"></asp:TextBox>  
            <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 10px; top: 625px; position: absolute;" Text="Apply Filter" OnClick="btnApplyFilter_Click"/>
            <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 160px; top: 625px; position: absolute;" Text="Clear Filter" OnClick="btnClearFilter_Click"/>
            <asp:Button ID="btnStatisticsPage" runat="server" style="z-index: 1; left: 310px; top: 625px; position: absolute;" Text="Statistics Page" OnClick="btnStatisticsPage_Click"/>
            <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 510px; top: 625px; position: absolute;" Text="Return to Main Menu" OnClick="btnMainMenu_Click"/>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 675px; position: absolute;" Text=""></asp:Label>
            
    </form>
</body>
</html>
