<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Products.aspx.vb" Inherits="OnlineOrdering.Products" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" 
            Text="Add Product to a Cart"></asp:Label>
        <br />
        <br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Categories:  "></asp:Label>
        <asp:DropDownList ID="ddlCategories" runat="server" 
            DataSourceID="odsCategories" DataTextField="CategoryName" 
            DataValueField="CategoryID">
        </asp:DropDownList>
    
    &nbsp;
        <asp:Button ID="Button1" runat="server" Text="Search" />
        <br />
    
    </div>
    <asp:ObjectDataSource ID="odsCategories" runat="server" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetData" 
        TypeName="OnlineOrdering.NorthwindTableAdapters.CategoriesTableAdapter">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsProducts" runat="server" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByCategoryId" 
        TypeName="OnlineOrdering.NorthwindTableAdapters.ProductsTableAdapter">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlCategories" DefaultValue="1" 
                Name="CategoryID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:GridView ID="gwProducts" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ProductID,ProductName" 
        DataSourceID="odsProducts">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" 
                InsertVisible="False" ReadOnly="True" SortExpression="ProductID" 
                Visible="False" />
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" 
                SortExpression="ProductName" />
            <asp:BoundField DataField="QuantityPerUnit" HeaderText="Quantity Per Unit" 
                SortExpression="QuantityPerUnit" />
            <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" 
                SortExpression="UnitPrice" />
            <asp:BoundField DataField="UnitsInStock" HeaderText="Units In Stock" 
                SortExpression="UnitsInStock" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
