<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblConfirm" runat="server" style="z-index: 1; left: 10px; top: 10px; position: absolute;" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 50px; top: 50px; position: absolute;" Text="Yes" Width="50px" OnClick="btnYes_Click"/>
        <asp:Button ID="BtnNo" runat="server" style="z-index: 1; left: 150px; top: 50px; position: absolute;" Text="No" Width="50px" OnClick="BtnNo_Click"/>
    </form>
</body>
</html>
