<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Registration</h1>
        
        
        <table>
           <tr>
               <td>Enter First Name</td>
               <td>
                   <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox></td>
           <td>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field Required" ControlToValidate="txtFirst"></asp:RequiredFieldValidator></td>
           </tr>
           <tr>
               <td>Enter Last Name</td>
               <td>
                   <asp:TextBox ID="txtLast" runat="server"></asp:TextBox></td>
                 <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Field Required" ControlToValidate="txtLast"></asp:RequiredFieldValidator></td>
           </tr>
           <tr>
               <td>Enter Email</td>
               <td>
                   <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                 <td>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"  ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator></td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Field Required" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
           </tr>
          
               
           </table>
            <h2> Enter your password</h2>
            <table>
            <tr>
               <td>Enter Password</td>
               <td>
                   <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox></td>
               <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Field Required" ControlToValidate="txtPass"></asp:RequiredFieldValidator></td>
           </tr>
           <tr>
               <td>Comfirm Password</td>
               <td>
                   <asp:TextBox ID="txtComfirm" runat="server" TextMode="Password"></asp:TextBox></td>
               <td>    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Doesn't Match" ControlToValidate="txtComfirm" ControlToCompare="txtPass"></asp:CompareValidator></td>
               <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Must Confirm Password" ControlToValidate="txtComfirm"></asp:RequiredFieldValidator></td>
           </tr>
            <tr>
               <td>
                   <asp:Button ID="btnSubmit" runat="server" Text="Submit" style="margin-bottom: 1px" OnClick="btnSubmit_Click1" /></td>
               <td>
                   <asp:Label ID="lblError" runat="server" Text=""></asp:Label></td>
                   <td></td>
                   
           </tr>             
        </table>
    </div>
    </form>
</body>
</html>
-