<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnterPasswordPage.aspx.cs" Inherits="PracticalTest.EnterPasswordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <fieldset style ="width:200px;">
    <legend>Set-Up Password </legend>
        <asp:TextBox ID="txtpassword" placeholder="Password" runat="server"
            Width="180px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtcofirmPassword" placeholder="Confirm password" runat="server"
            Width="180px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnsave" runat="server" Text="Save"
           Width="81px" OnClick="btnsave_Click" />
        <asp:Button ID="btncancel" runat="server" Text="btncancel"
           Width="81px" />
            
           
    </fieldset>
    </div>
    </form>
</body>
</html>
