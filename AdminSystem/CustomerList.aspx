<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="472px" Width="473px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" Width="54px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Enter an Address (Postcode)"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" Height="16px" OnTextChanged="txtAddress_TextChanged" style="margin-left: 33px; margin-top: 1px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="margin-left: 128px" Text="Apply Filter" Width="87px" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="margin-left: 32px" Text="Clear Filter" Width="95px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
