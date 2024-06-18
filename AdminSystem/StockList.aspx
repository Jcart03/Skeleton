<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="472px" Width="473px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblStock" runat="server" Text="Enter Shoe Size"></asp:Label>
            <asp:TextBox ID="txtStock" runat="server" Height="16px" style="margin-left: 33px; margin-top: 1px"></asp:TextBox>

        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Style="margin-left: 128px" Text="Apply Filter" Width="87px" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Style="margin-left: 32px" Text="Clear Filter" Width="95px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

