<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Quantity.aspx.vb" Inherits="OnlineOrdering.Quantity" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" 
            Text="Select Quantity"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Product: "></asp:Label>
&nbsp;<asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
        
        <br />
        Quantity:         <asp:TextBox ID="txtQuantity" runat="server">1</asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="txtQuantity" 
            ErrorMessage="&quot;Enter value between 0 and 10 000&quot;" 
            MaximumValue="10000" MinimumValue="0" Type="Integer"></asp:RangeValidator>
        <br />
        <br />
        <asp:Button ID="bttnAdd" runat="server" Text="Add" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bttnCancel" runat="server" Text="Cancel" />
    
    </div>
    <asp:ObjectDataSource ID="odsProductByProductId" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByProductId" 
        TypeName="OnlineOrdering.NorthwindTableAdapters.ProductsTableAdapter">
        <SelectParameters>
            <asp:QueryStringParameter Name="ProductId" QueryStringField="productId" 
                Type="Int32" DefaultValue="" />
        </SelectParameters>
    </asp:ObjectDataSource>
    </form>
</body>
</html>
