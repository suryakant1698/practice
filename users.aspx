<%@ Page Language="C#" AutoEventWireup="true" CodeFile="users.aspx.cs" Inherits="users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label runat="server" ID="Label1" Text="welcome">
    </asp:Label><br />
        <asp:Button runat="server" ID="logoutButton" Text="Logout" OnClick="logoutButton_Click" />

    </div>
    </form>
</body>
</html>
