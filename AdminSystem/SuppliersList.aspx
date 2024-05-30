<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 356px">
            <asp:ListBox ID="lstSuppliersList" runat="server" Height="230px" Width="275px"></asp:ListBox>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="60px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit " Width="64px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnStatisticsPage" runat="server" OnClick="Button1_Click" Text="Statistics Page" />
            <asp:Button ID="btnreturntomm" runat="server" OnClick="btnreturntomm_Click" Text="Return to Main Menu" Width="155px" />
            <asp:Label ID="lblSupplierName" runat="server" Text="Enter Supplier Name "></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" OnTextChanged="txtFilter_TextChanged" Width="152px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
