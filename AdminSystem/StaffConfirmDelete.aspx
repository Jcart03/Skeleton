<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
    <style>
        body {
            background-image: url('../Image/bg1.png'); 
            background-size: cover;
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            display: flex; 
            justify-content: center;
            align-items: center;
            height: 100vh; 
        }
        #form1 {
            width: 400px;
            background-color: rgba(255, 255, 255, 0.8); 
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.3); 
            text-align: center; 
        }
        .button-group {
            margin-top: 20px; 
        }
        .button-group button {
            margin: 0 10px;
            padding: 8px 20px;
            border: none;
            background-color: #4CAF50; 
            color: white;
            cursor: pointer;
            border-radius: 5px;
        }
        .button-group button:hover {
            background-color: #e99259; 
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="LblConfirmDelete" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <div class="button-group">
            <asp:Button ID="btnYes" runat="server" Text="Yes" Width="105px" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="No" Width="105px" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>