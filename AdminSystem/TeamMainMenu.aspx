<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
    <style>
     body {
            background-image: url('../Image/bg1.png'); 
            background-size: cover;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            margin: 0;
            padding: 0;
            color: #333;
        }
        .title-container {
            display: flex;
            align-items: center;
            justify-content: center;
            padding: 20px;
            background-color: rgba(255, 255, 255, 0.9); 
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.2); 
        }
        .title {
            font-size: 48px; 
            margin: 0; 
            color: #FF8C00; 
            text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.2); 
        }
        .logo {
            height: 100px; 
            margin-right: 20px; 
        }
           .container {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center; 
            height: 100vh; 
        }
        .button-container {
            display: flex;
            justify-content: center;
            margin-bottom: 20px;
            width: 100%;
            text-align: center;
        }
        .button {
            padding: 12px 25px;
            border: 2px solid transparent;
            background-color: #4CAF50;
            color: white;
            cursor: pointer;
            border-radius: 5px;
            font-size: 16px;
            transition: background-color 0.3s, transform 0.3s, border-color 0.3s;
            margin: 0 10px; 
        }
        .button:hover {
            background-color: #e99259;
            transform: scale(1.05);
        }
        .button:hover,
        .button:focus {
            border-color: #333;
        }
        .btn-staff {
            background-color: #333;
        }
        .btn-order {
            background-color: #333;
        }
        .btn-customer {
            background-color: #333;
        }
        .btn-supplier {
            background-color: #333;
        }
        .btn-stock {
            background-color: #333;
        }
    </style>
</head>
<body>
    <div class="title-container">
        <img src="../Image/Logo.png" alt="Logo" class="logo" /> 
        <h1 class="title">Orange Shoe</h1>
    </div>
    <div class="container">
        <form id="form1" runat="server">
            <div class="button-container">
                <asp:Button ID="btnStaffManagementSystem" runat="server" Text="Staff Management System" OnClick="btnStaffManagementSystem_Click" CssClass="button btn-staff" />
                <asp:Button ID="btnOrderManagementSystem" runat="server" Text="Order Management System" OnClick="btnOrderManagementSystem_Click" CssClass="button btn-order" />
            </div>
            <div class="button-container">
                <asp:Button ID="btnCustomerManagementSystem" runat="server" Text="Customer Management System" OnClick="btnCustomerManagementSystem_Click" CssClass="button btn-customer" />
                <asp:Button ID="btnSupplierManagementSystem" runat="server" Text="Supplier Management System" OnClick="btnSupplierManagementSystem_Click" CssClass="button btn-supplier" />
            </div>
            <div class="button-container">
                <asp:Button ID="btnStockManagementSystem" runat="server" Text="Stock Management System" OnClick="btnStockManagementSystem_Click" CssClass="button btn-stock" />
            </div>
        </form>
    </div>
</body>
 </html>
