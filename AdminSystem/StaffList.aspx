<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 639px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ListBox ID="lstStaffList" runat="server" Height="360px" Width="786px"></asp:ListBox>

        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="105px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="105px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Width="105px"/>
            
        </p>


        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="Button1_Click" Text="Apply Filter" />
         &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" />

        Enter a Staff Name<asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>

        <asp:Button ID="btnStatisticsPage" runat="server" Text="Statistics Page" />

    </form>
</body>
</html>
