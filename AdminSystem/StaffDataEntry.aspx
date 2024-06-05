<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>staff data entry</title>
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
        }
        .form-group {
            margin-bottom: 20px;
        }
        .button-group {
            text-align: center;
        }
         .button-group button {
             margin-right: 10px;
        }
        .button:hover {
            background-color: #e99259;

        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblStaffName" runat="server" Text="Staff Name"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblStaffEmail" runat="server" Text="Staff Email"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblStaffAddress" runat="server" Text="Staff Address"></asp:Label>
            <asp:TextBox ID="txtStaffAddress" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblStartingDate" runat="server" Text="Starting Date"></asp:Label>
            <asp:TextBox ID="txtStartingDate" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblStaffSalary" runat="server" Text="Staff Salary"></asp:Label>
            <asp:TextBox ID="txtStaffSalary" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:CheckBox ID="chkIsManager" runat="server" Text="Is Manager" />
        </div>
         <asp:Label ID="lblError" runat="server" Text=""></asp:Label> 
        <div class="button-group">
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
        <asp:Button ID="btnReturntomm" runat="server" Text="Return to Main Menu" OnClick="btnReturntomm_Click" />
    </form>
</body>
</html>

