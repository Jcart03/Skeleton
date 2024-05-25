<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ListBox ID="lstStaffList" runat="server" Height="360px" Width="786px"></asp:ListBox>

        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="69px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="69px" />
            
        </p>

        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>

    </form>
</body>
</html>
