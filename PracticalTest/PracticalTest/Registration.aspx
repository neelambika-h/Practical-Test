<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="PracticalTest.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" align="center">
    <div>
        <h1>Registration Details</h1>
        <div>
            <asp:Label ID="lblProfilePic" runat="server" Text="Profile Picture"></asp:Label><br />
        
        <asp:Image ID="Image1" runat="server" Height = "100" Width = "100" />
        <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
        <asp:Button ID="btnUpload" Text="Upload" runat="server" OnClick="UploadFile" />
        </div>
    
    </div>

        <table align="center">
            <tr>
                <td><asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label></td>
                <td><asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lbllastname" runat="server" Text="Last Name"></asp:Label></td>
                <td><asp:TextBox ID="txtlastname" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td><asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label></td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblmobileno" runat="server" Text="Mobile NO"></asp:Label></td>
                <td> <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <h4>Address</h4>
        <table align="center">
            <tr>
                <td><asp:Label ID="lblcity" runat="server" Text="City"></asp:Label></td>
                <td><asp:TextBox ID="txtcity" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblstate" runat="server" Text="State"></asp:Label></td>
                <td><asp:TextBox ID="txtstate" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblcountry" runat="server" Text="Country"></asp:Label></td>
                <td><asp:TextBox ID="txtcountry" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="lblPincode" runat="server" Text="Pincode"></asp:Label></td>
                <td><asp:TextBox ID="txtpincode" runat="server"></asp:TextBox></td>
            </tr>
        </table>
         
        
        <div>
            <asp:Button ID="btnsave" runat="server" Text="save" OnClick="btnsave_Click" />
            <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" /><br />

           

        </div>
    </form>
</body>
</html>
