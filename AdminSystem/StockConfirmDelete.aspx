<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" Style="z-index: 1; height: 25px; width: 60px" Text="Yes" OnClick="btnYes_Click" Width="140px" />
            <asp:Button ID="btnNo" runat="server" Style="z-index: 1; height: 25px; width: 60px" Text="No" OnClick="btnNo_Click" Width="145px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
        