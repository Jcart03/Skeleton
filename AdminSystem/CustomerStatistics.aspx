<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerStatistics.aspx.cs" Inherits="CustomerStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 471px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-multiline="True" draggable="false" style="height: 50px">
            <asp:Label ID="lblStatistics" runat="server" Font-Bold="True" Font-Size="X-Large" Height="30px" Text="Statistics Page"></asp:Label>
        </div>
        <div style="height: 31px">
            <asp:Label ID="lblLoggedIn" runat="server" Font-Bold="True" Height="25px" style="margin-left: 2px; margin-right: 3px; margin-bottom: 4px" Text="Customer List - Grouped by LoggedIn status" Width="300px"></asp:Label>
        </div>
        <div aria-atomic="False" style="height: 156px">
            <asp:GridView ID="gvLoggedIn" runat="server" Height="80px" style="margin-bottom: 19px" Width="136px">
            </asp:GridView>
            <div style="height: 24px; width: 1487px; margin-top: 32px">
                <asp:Label ID="lblTimestamp" runat="server" Font-Bold="True" Text="Customer List - Grouped By Timestamp"></asp:Label>
                <div style="height: 134px; width: 1486px; margin-top: 12px">
                    <asp:GridView ID="gvTimestamp" runat="server">
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
