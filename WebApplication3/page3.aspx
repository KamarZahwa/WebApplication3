<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="WebApplication3.page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Query string<br />
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <br />
        *********************<br />
        cookies - session - Application<br />
    
    </div>
        <div>
           
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
           
        </div>
        <div>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button3" runat="server" Text="set" OnClick="Button3_Click" /><asp:Button ID="Button4" runat="server" Text="restore" OnClick="Button4_Click" />
        </div>
    </form>
</body>
</html>
