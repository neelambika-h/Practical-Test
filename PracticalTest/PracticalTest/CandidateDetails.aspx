<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CandidateDetails.aspx.cs" Inherits="PracticalTest.CandidateDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <table>
                <tr>
                    <td><asp:Button ID="btnadd" runat="server" Text="AddEmployee" OnClick="btnadd_Click"/></td>
                    <td></td>
                    <td>FilterBy</td>
                    <td><asp:DropDownList ID="drpexperience" runat="server">
 

                    <asp:ListItem>--select--</asp:ListItem>
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
 

                         </asp:DropDownList></td>
                    <td></td>
                    <td><asp:TextBox ID="txtsearch" placeholder="Search Employee" runat="server"
            Width="180px"></asp:TextBox></td>
                </tr>
            </table>
           
        </div>
    <asp:GridView ID="gvImages" runat="server" AutoGenerateColumns="false" Height="10px" Width="10px">
    <Columns>
         <asp:ImageField ControlStyle-Height="50px" ControlStyle-Width="50px" DataImageUrlField="Profile_Photo" HeaderText="Profile Picture">
             
         </asp:ImageField>
          <asp:TemplateField HeaderText="First Name" >
                <ItemTemplate>
                            <asp:Label ID="lblfname" runat="server" Text='<%#Eval("FirstName") %>' ></asp:Label>
                            </ItemTemplate>
          </asp:TemplateField>
        <asp:TemplateField HeaderText="Last Name" >
                <ItemTemplate>
                            <asp:Label ID="lbllastname" runat="server" Text='<%#Eval("LastName") %>' ></asp:Label>
                            </ItemTemplate>
          </asp:TemplateField>
        <asp:TemplateField HeaderText="Email" >
                <ItemTemplate>
                            <asp:Label ID="lblemail" runat="server" Text='<%#Eval("Email") %>' ></asp:Label>
                            </ItemTemplate>
          </asp:TemplateField>
        <asp:TemplateField HeaderText="Mobile Number" >
                <ItemTemplate>
                            <asp:Label ID="lblmno" runat="server" Text='<%#Eval("MobileNo") %>' ></asp:Label>
                            </ItemTemplate>
          </asp:TemplateField>
        <asp:TemplateField HeaderText="City" >
                <ItemTemplate>
                            <asp:Label ID="lblcity" runat="server" Text='<%#Eval("City") %>' ></asp:Label>
                            </ItemTemplate>
          </asp:TemplateField>

        <asp:TemplateField HeaderText="State" >
                <ItemTemplate>
                            <asp:Label ID="lblstate" runat="server" Text='<%#Eval("State") %>' ></asp:Label>
                            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Country" >
                <ItemTemplate>
                            <asp:Label ID="lblcountry" runat="server" Text='<%#Eval("Country") %>' ></asp:Label>
                            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Pincode" >
                <ItemTemplate>
                            <asp:Label ID="lblpincode" runat="server" Text='<%#Eval("pincode") %>' ></asp:Label>
                            </ItemTemplate>
        </asp:TemplateField>
           
        

    </Columns>
</asp:GridView>
    </div>
    </form>
</body>
</html>
