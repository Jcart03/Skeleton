<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 688px">
            <div style="position: relative;">
                <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 63px; top: 91px; position: absolute; width: 142px; height: 20px" Text="Staff ID"></asp:Label>
                <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 215px; top: 91px; position: absolute; width: 142px; height: 20px"></asp:TextBox>
                <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 62px; top: 139px; position: absolute; width: 142px; height: 20px; margin-top: 0px;" Text="Staff Name"></asp:Label>
                <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 215px; top: 139px; position: absolute; width: 142px; height: 20px"></asp:TextBox>
                <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 60px; top: 237px; position: absolute; width: 142px; height: 20px; margin-top: 0px;" Text="Staff Email"></asp:Label>
                <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 215px; top: 237px; position: absolute; width: 142px; height: 20px"></asp:TextBox>
                <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 59px; top: 188px; position: absolute; width: 142px; height: 20px; bottom: 666px" Text="Staff Address"></asp:Label>
                <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 215px; top: 188px; position: absolute; width: 142px; height: 20px"></asp:TextBox>
                <asp:Label ID="lblStartingDate" runat="server" style="z-index: 1; left: 59px; top: 292px; position: absolute; width: 140px; height: 20px" Text="Starting Date"></asp:Label>
                <asp:TextBox ID="txtStartingDate" runat="server" style="z-index: 1; left: 215px; top: 292px; position: absolute; width: 142px; height: 20px"></asp:TextBox>
                <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 58px; top: 343px; position: absolute; width: 142px; height: 20px" Text="Staff Salary"></asp:Label>
                <asp:TextBox ID="txtStaffSalary" runat="server" style="z-index: 1; left: 215px; top: 343px; position: absolute; width: 142px; height: 20px"></asp:TextBox>
                <asp:CheckBox ID="chkIsManager" runat="server" style="z-index: 1; left: 215px; top: 393px; position: absolute; width: 142px; height: 20px;" Text="IsManager" />
                <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 59px; top: 440px; position: absolute; height: 20px; width: 400px;" Text=""></asp:Label>
                <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 215px; top: 470px; position: absolute;" Text="OK" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 315px; top: 470px; position: absolute;" Text="Cancel" />
            </div>
            </div>
    </form>
</body>
</html>

