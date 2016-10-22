<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Cart.aspx.vb" Inherits="OnlineOrdering.Cart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
    
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" 
            Text="Selected Products"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <asp:GridView ID="gwCart" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ProductName" HeaderText="Product Name">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="DiscountedUnitPrice" 
                HeaderText="Online Discount Price">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="ProductTotal" HeaderText="Product Total">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" Visible="False">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="ProductID, ProductName" 
                DataNavigateUrlFormatString="Quantity.aspx?productId={0}&amp;productName={1}" 
                HeaderText="Change" NavigateUrl="Quantity.aspx" Text="Change" />
        </Columns>
        <EmptyDataTemplate>
            Product Name
        </EmptyDataTemplate>
    </asp:GridView>
    <div>
    
        <br />
        <asp:Label ID="Label3" runat="server" Text="Total: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblTotal" runat="server" Font-Bold="True"></asp:Label>
        <br />
        <br />
        <asp:Button ID="bttnCheckOut" runat="server" Text="Check Out" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bttnAddMore" runat="server" Text="Add More Products" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bttnEmpty" runat="server" Text="Empty" />
    
    </div>
    </form>
</body>
</html>
