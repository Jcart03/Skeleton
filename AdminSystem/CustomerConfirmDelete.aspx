﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

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
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="127px" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" Width="125px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
