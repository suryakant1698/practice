<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="text-align:right">
        <tr>
            <td style="float: right"><asp:Label ID="usernameLabel" runat="server" Text="username" ></asp:Label></td>
            <td><asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label></td>
            <td><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button Text="Log In" runat="server" ID="LoginButton" OnClick="LoginButton_Click" /></td>
        </tr>
        <tr>
            <td><h1>if not already registered</h1></td>
            <td><asp:Button runat="server" Text="Register" OnClick="Unnamed1_Click" /></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
