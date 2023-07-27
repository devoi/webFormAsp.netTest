<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication6.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-left: 40px">
    <form id="form1" runat="server">
        <div>
            <h3>&nbsp;</h3>
            <h3>Bind & search Records in Gridview</h3>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Search By:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>empno</asp:ListItem>
                    <asp:ListItem>ename</asp:ListItem>
                    <asp:ListItem>dept</asp:ListItem>
                    <asp:ListItem>mgr</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#009933" OnClick="Button1_Click" Text="Search" />
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
            </p>
        </div>
    </form>
</body>
</html>
