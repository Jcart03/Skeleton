<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Management</title>
    <style type="text/css">
body {
    background-image: url('../Image/bg1.png');
    background-size: cover;
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    display: flex; 
    justify-content: center; 
}

#form1 {
    width: 800px;
    margin-top: 50px; 
    padding: 20px;
    background-color: rgba(255, 255, 255, 0.8); 
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.3); 
}

.button-group, .filter-group {
    text-align: center;
    margin-bottom: 10px;
}

.button-group button, .filter-group button {
    margin: 0 5px;
    padding: 8px 20px;
    border: none;
    background-color: #4CAF50; 
    color: white;
    cursor: pointer;
    border-radius: 5px;
}

.button-group button:hover, .filter-group button:hover {
    background-color: #e99259; 
}

.label-text {
    margin-right: 10px;
}

.filter-group input[type="text"] {
    padding: 5px;
    border-radius: 5px;
    border: 1px solid #ccc;
}

.bottom-buttons {
    text-align: center;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaffList" runat="server" Height="300px" Width="100%" CssClass="list-box"></asp:ListBox>

        <div class="button-group">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </div>

        <div class="filter-group">
            <asp:Label ID="lblError" runat="server" Text="lblError" CssClass="label-text"></asp:Label>
            Enter a Staff Name
            <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" />
        </div>

        <div class="bottom-buttons">
            <asp:Button ID="btnStatisticsPage" runat="server" Text="Statistics Page" OnClick="btnStatisticsPage_Click" />
            <asp:Button ID="btnReturntomm" runat="server" Text="Return to Main Menu" OnClick="btnReturntomm_Click" />
        </div>
    </form>
</body>
</html>