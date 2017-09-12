<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

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
            <td><asp:Label runat="server" Text="Username" ></asp:Label></td>
            <td><asp:TextBox Id="usernameId" runat="server" AutoPostBack="True" OnTextChanged="usernameId_TextChanged" ></asp:TextBox>       
           
             </td>   
           
        </tr>
        <tr>
               <td><asp:Label runat="server" Text="Email" ></asp:Label></td>
            <td>
                <asp:TextBox ID="Email" runat="server" AutoPostBack="True" OnTextChanged="Email_TextChanged"  ></asp:TextBox>
            </td>
           </tr>
        <tr>
            <td><asp:Label runat="server" Text="Full Name" ></asp:Label></td>
            <td>
                <asp:TextBox ID="fullName" runat="server" ></asp:TextBox>

            </td>
        </tr>
           
        <tr>
            <td><asp:Label runat="server" Text="Password" ></asp:Label></td>
            <td>
                <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td><asp:Label runat="server" Text="Confirm Password" ></asp:Label></td>
            <td>
                <asp:TextBox id="passwordCheck" runat="server" AutoPostBack="True" TextMode="Password"></asp:TextBox>

            </td>
            <td><asp:Label ID="Label2" runat="server"></asp:Label></td>
        </tr>
        <tr><td><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /></td></tr>

    </table>
    </div>
    </form>
</body>
</html>
