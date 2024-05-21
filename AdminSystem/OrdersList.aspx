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
    </form>
</body>
</html>
