<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="PracticalTest.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Customer Details
        </h1>
        <table>
            <tr>
                <td>InvoiceNo</td>
                <td>
                    <asp:TextBox ID="txtInvoiceNo" runat="server"></asp:TextBox>

                </td>
                <td>Invoice Date</td>
                 <td>
                    <asp:TextBox ID="txtInvoiceDate" runat="server" TextMode="Date"></asp:TextBox>

                </td>
                </tr>
            <tr>
                <td><asp:Label ID="lblcustomername" runat="server" Text="Customer Name *">

                    </asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
                   
                    

                </td>
                <td>GST No</td>
                <td>
                    <asp:TextBox ID="txtGSTNO" runat="server"></asp:TextBox>

                </td>
                </tr>
            <tr>
                <td>State</td>
                <td>
                    <asp:TextBox ID="txtState" runat="server"></asp:TextBox>

                </td>
            </tr>
        </table>
        <div>
            <table>
                <h1>Items Entry Details</h1>
                <tr>
                    <td>Product Name</td>
                    <td>Qty</td>
                    <td>Rate</td>
                    <td>Total Value</td>
                    <td>CGST</td>
                    <td>SGST</td>
                    <td>IGST</td>
                </tr>
                <tr>
                    <td> <asp:DropDownList ID="drpproductname" runat="server" CssClass="form-control" Width="300px">
                                               </asp:DropDownList></td>
                    <td><asp:TextBox ID="txtqty" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="txtrate" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="txttotal" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="txtcgst" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="txtsgst" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="txtigst" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <div id="taxdetails">
            <table>
                <tr>
                    <td>Total Amount:</td>
                    <td><asp:Label ID="lbltAmount" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>Total Tax(CGST):</td>
                    <td><asp:Label ID="lblCGST" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>Total Amount(SGST):</td>
                    <td><asp:Label ID="lblSGDT" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>Total Amount(IGST):</td>
                    <td><asp:Label ID="lblIGST" runat="server" Text=""></asp:Label></td>
                </tr>
                 <tr>
                    <td>Grand Total:</td>
                    <td><asp:Label ID="lblgtotal" runat="server" Text=""></asp:Label></td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Button ID="btnsave" runat="server" CssClass="btn btn-dark " Height="30px"
                                            Width="100px" Text="Save" OnClick="btnsave_Click"/>
        </div>
    
    </div>
    </form>
</body>
</html>
