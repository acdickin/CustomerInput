<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Login</h1>
       
        <table>
            <tr>
                <td>User Name</td>
                <td> <asp:TextBox ID="txtuser" runat="server"></asp:TextBox></td>
                <td></td>
                <td>Password</td>
                <td> <asp:TextBox ID="txtpass" TextMode="Password" runat="server"></asp:TextBox></td>
                <td>  <asp:Button ID="btnLogin" runat="server" Text="LOGIN" OnClick="btnLogin_Click" /></td>
                <td>  <asp:Label ID="Label1" runat="server"></asp:Label>      
                  
                </td>
            </tr>
        </table>
        
      <asp:LinkButton ID="lb1" runat="server" OnClick="lb1_Click">Register</asp:LinkButton>
    </div>
    </form>
</body>
</html>
