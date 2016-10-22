<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    My Value&nbsp;
    <asp:TextBox ID="tbMyValue" runat="server"></asp:TextBox>
    <br />
    My Total&nbsp;&nbsp;
    <asp:TextBox ID="tbMyTotal" runat="server"></asp:TextBox>
    <br />
<br />
<br />
<asp:Button ID="bttnCalculate" runat="server" Text="Calculate" />
<br />
<br />
<asp:Label ID="lblPercentage" runat="server" Text="=Calculated Percentage"></asp:Label>
<br />
<br />
<br />
<asp:Label ID="lblServerTime" runat="server"></asp:Label>
<br />
    <br />
    
</asp:Content>
