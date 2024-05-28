<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <p>
            <asp:Label ID="LblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" Text="Yes" Width="105px" OnClick="btnYes_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNo" runat="server" Text="No" Width="105px" OnClick="btnNo_Click" />
        
    </form>
</body>
</html>
