<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 353px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblShoeId" runat="server" style="z-index: 1; left: 21px; top: 45px; position: absolute; height: 22px; width: 120px" Text="Shoe Id"></asp:Label>
        <asp:TextBox ID="txtShoeId" runat="server" style="z-index: 1; left: 170px; top: 41px; position: absolute; height: 20px; width: 145px"></asp:TextBox>
        <asp:Button runat="server" Style="z-index: 1; left: 335px; top: 41px; position: absolute; height: 26px; width: 58px" Text="Find" ID="btnFind" OnClick="btnFind_Click"></asp:Button>
        <asp:Label ID="lblShoeBrand" runat="server" style="z-index: 1; left: 21px; top: 87px; position: absolute; height: 22px; width: 120px" Text="Shoe Brand"></asp:Label>
        <asp:TextBox ID="txtShoeBrand" runat="server" style="z-index: 1; left: 170px; top: 83px; position: absolute; height: 20px; width: 145px"></asp:TextBox>
        <asp:Label ID="lblShoeSize" runat="server" style="z-index: 1; left: 21px; top: 129px; position: absolute; height: 22px; width: 120px" Text="Shoe Size"></asp:Label>
        <asp:TextBox ID="txtShoeSize" runat="server" style="z-index: 1; left: 170px; top: 125px; position: absolute; height: 20px; width: 145px"></asp:TextBox>
        <asp:Label ID="lblShoeColour" runat="server" style="z-index: 1; left: 21px; top: 172px; position: absolute; height: 22px; width: 120px" Text="Shoe Colour"></asp:Label>
        <asp:TextBox ID="txtShoeColour" runat="server" style="z-index: 1; left: 170px; top: 168px; position: absolute; height: 20px; width: 145px"></asp:TextBox>
        <asp:Label ID="lblShoePrice" runat="server" style="z-index: 1; left: 21px; top: 214px; position: absolute; height: 22px; width: 120px" Text="Shoe Price"></asp:Label>
        <asp:TextBox ID="txtShoePrice" runat="server" style="z-index: 1; left: 170px; top: 210px; position: absolute; height: 20px; width: 145px"></asp:TextBox>
        <asp:Label ID="lblShoeAvailability" runat="server" style="z-index: 1; left: 21px; top: 257px; position: absolute; height: 22px; width: 120px" Text="Shoe Availability"></asp:Label>
        <asp:TextBox ID="txtShoeAvailability" runat="server" style="z-index: 1; left: 170px; top: 253px; position: absolute; height: 20px; width: 145px"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 21px; top: 300px; position: absolute; height: 22px; width: 120px" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 170px; top: 296px; position: absolute; height: 20px; width: 145px"></asp:TextBox>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 140px; top: 344px; position: absolute; height: 20px; width: 137px" Text="Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 380px; position: absolute; height: 20px; width: 91px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; left: 98px; top: 415px; position: absolute; height: 26px; width: 58px" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 21px; top: 415px; position: absolute; height: 26px; width: 58px" Text="OK" />
        </p>
    </form>
</body>
</html>
