<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 360px">
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 10px; top: 50px; position: absolute" Text="OrderId"></asp:Label>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 100px; position: absolute" Text="CustomerName"></asp:Label>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute" Text="StaffName"></asp:Label>
        <asp:Label ID="lblOrderNotes" runat="server" style="z-index: 1; left: 10px; top: 200px; position: absolute" Text="OrderNotes"></asp:Label>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 10px; top: 250px; position: absolute" Text="OrderDate"></asp:Label>
        <asp:Label ID="lblOrderItem" runat="server" style="z-index: 1; left: 10px; top: 300px; position: absolute" Text="OrderItem"></asp:Label>
        <asp:Label ID="lblOrderQuantity" runat="server" style="z-index: 1; left: 10px; top: 350px; position: absolute" Text="OrderQuantity"></asp:Label>
        <asp:Label ID="lblOrderShipped" runat="server" style="z-index: 1; left: 10px; top: 400px; position: absolute" Text="OrderShipped"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 450px; position: absolute" Text=""></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 150px; top: 50px; position: absolute; width: 200px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 150px; top: 100px; position: absolute; width: 200px;"></asp:TextBox>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 150px; top: 150px; position: absolute; width: 200px;"></asp:TextBox>
        <asp:TextBox ID="txtOrderNotes" runat="server" style="z-index: 1; left: 150px; top: 200px; position: absolute; width: 200px;"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 150px; top: 250px; position: absolute; width: 200px;"></asp:TextBox>
        <asp:TextBox ID="txtOrderItem" runat="server" style="z-index: 1; left: 150px; top: 300px; position: absolute; width: 200px;"></asp:TextBox>
        <asp:TextBox ID="txtOrderQuantity" runat="server" style="z-index: 1; left: 150px; top: 350px; position: absolute; width: 200px;"></asp:TextBox>
        <asp:CheckBox ID="chkOrderShipped" runat="server" style="z-index: 1; left: 150px; top: 400px; position: absolute" Text="Shipped" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 400px; top: 50px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 15px; top: 500px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 75px; top: 500px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 185px; top: 500px; position: absolute" Text="Return to Main Menu" OnClick="btnMainMenu_Click" />
    </form>
</body>
</html>
