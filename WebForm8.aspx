<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication6.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>ListView</h3>
            <asp:ListView ID="ListView1" runat="server">
            </asp:ListView>
            <br />
            <h3>FormView</h3>
            <asp:FormView ID="FormView1" runat="server">
            </asp:FormView>
            <br />
            <h3>DetailsView</h3>
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
            </asp:DetailsView>
            <br />
            <h3>GridView</h3>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
