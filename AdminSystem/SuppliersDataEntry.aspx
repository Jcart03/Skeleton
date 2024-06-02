<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="SuppliersID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="SuppliersID" width="119px"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 158px; top: 20px; position: absolute; width: 102px; height: 11px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="SuppliersName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Suppliers Name" width="119px"></asp:Label>
            <asp:TextBox ID="txtSuppliersName" runat="server" height="11px" style="z-index: 1; left: 157px; top: 51px; position: absolute; width: 102px; bottom: 475px"></asp:TextBox>
        </p>
        <asp:Label ID="SuppliersAddress" runat="server" style="z-index: 1; top: 92px; position: absolute; left: 10px" Text="Address" width="119px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" height="11px" style="z-index: 1; left: 157px; top: 85px; position: absolute; width: 102px"></asp:TextBox>
        <asp:Label ID="PaymentTerms" runat="server" style="z-index: 1; left: 11px; top: 127px; position: absolute" Text="Payment Terms" width="119px"></asp:Label>
        <p style="height: 53px">
            <asp:TextBox ID="txtPaymentTerms" runat="server" style="z-index: 1; left: 157px; top: 127px; position: absolute; width: 102px; height: 11px"></asp:TextBox>
            <asp:Label ID="ContractStart" runat="server" style="z-index: 1; left: 10px; top: 168px; position: absolute" Text="Contract Start Date"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtContractStart" runat="server" style="z-index: 1; left: 157px; top: 170px; position: absolute; width: 102px; height: 11px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="IsActive" runat="server" style="z-index: 1; left: 10px; top: 210px; position: absolute; height: 14px" Text="Supplier Active" width="119px"></asp:Label>
            <asp:Label ID="ContactNumber" runat="server" style="z-index: 1; left: 9px; top: 256px; position: absolute; height: 15px; width: 119px; right: 1028px" Text="Contact Number"></asp:Label>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 120px; top: 213px; position: absolute; bottom: 513px; width: 113px" Text="Active" />
        </p>
        <asp:TextBox ID="txtContactNumber" runat="server" height="11px" style="z-index: 1; left: 157px; top: 258px; position: absolute; width: 102px"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 309px; position: absolute; height: 22px"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; top: 340px; position: absolute; right: 1058px; width: 28px; bottom: 182px" Text="OK" />
        </p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 353px; position: absolute; width: 77px; height: 26px; left: 148px" Text="Cancel" />
            <asp:Button ID="Button1" runat="server" OnClick="btnOK_Click" Text="OK" Width="86px" />
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" Height="32px" OnClick="btnFind_Click" Text="Find" Width="86px" />
        </p>
    </form>
</body>
</html>
