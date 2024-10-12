

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="GridView1"></asp:GridView>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>      
            <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>
            <asp:TextBox runat="server" ID="TextBox3"></asp:TextBox>
            <asp:TextBox runat="server" ID="TextBox4"></asp:TextBox>  
            <asp:Button ID="Button1" runat="server" Text="save" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="update" OnClick="Button3_Click" />
            

        </div>
    </form>
</body>
</html>
