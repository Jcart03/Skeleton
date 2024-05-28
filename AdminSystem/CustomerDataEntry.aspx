<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 213px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCustomerId" runat="server" height="22px" style="z-index: 1; left: 125px; top: 22px; position: absolute; width: 113px"></asp:TextBox>
            <asp:Label ID="lblCustomerAddress" runat="server" height="19px" style="z-index: 1; left: 10px; top: 117px; position: absolute; width: 79px" Text="Address"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblCustomerName" runat="server" height="19px" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Name" width="79px"></asp:Label>
            <asp:Label ID="lblCustomerEmail" runat="server" height="19px" style="z-index: 1; left: 10px; top: 82px; position: absolute" Text="Email" width="79px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" height="22px" style="z-index: 1; left: 125px; top: 54px; position: absolute; width: 113px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 253px; margin-bottom: 0px" Text="Find" Width="85px" />
        </p>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 24px; position: absolute; width: 79px; right: 1421px" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" height="22px" style="z-index: 1; left: 125px; top: 82px; position: absolute; width: 113px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtAddress" runat="server" height="22px" style="z-index: 1; left: 125px; top: 114px; position: absolute; width: 113px"></asp:TextBox>
            <asp:Label ID="lblTimestamp" runat="server" height="19px" style="z-index: 1; left: 10px; top: 139px; position: absolute; width: 79px" Text="Timestamp"></asp:Label>
            <asp:TextBox ID="txtTimestamp" runat="server" height="22px" style="z-index: 1; left: 125px; top: 141px; position: absolute; width: 113px"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" height="22px" style="z-index: 1; left: 125px; top: 166px; position: absolute; width: 113px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" height="19px" style="z-index: 1; left: 10px; top: 167px; position: absolute" Text="Password" width="79px"></asp:Label>
        </p>
        <p>
            <asp:CheckBox ID="cbLoggedIn" runat="server" style="z-index: 1; left: 127px; top: 199px; position: absolute" Text="Logged_In" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 224px; position: absolute; height: 19px"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 36px; top: 255px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 83px; top: 255px; position: absolute" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
