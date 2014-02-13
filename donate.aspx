<%@ Page Language="C#" AutoEventWireup="true" CodeFile="donate.aspx.cs" Inherits="donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Donate</h1>
        
        <asp:TextBox ID="txtDonate" runat="server"></asp:TextBox>
        <asp:Label ID="lblDError" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="BtnDonate" runat="server" Text="Donate" OnClick="BtnDonate_Click" />
   
         </div>
    </form>
</body>
</html>
