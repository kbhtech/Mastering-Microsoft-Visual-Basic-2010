<%@ Page Language="VB" AutoEventWireup="false" CodeFile="MyAjax.aspx.vb" Inherits="MyAjax" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Interval="1000">
            </asp:Timer>
            <asp:Label ID="lblServerTime" runat="server"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
