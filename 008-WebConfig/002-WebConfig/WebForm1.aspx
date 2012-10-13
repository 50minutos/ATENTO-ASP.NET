<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_002_WebConfig.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            
        <p>
            String de conexão armazenada no web.config:
            <br />
            <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
        </p>
        <p>
            E-mail armazenado no web.config:<br />
            <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
        </p>
        <p>
            Banco que está em uso:<br />
            <asp:Label ID="Label3" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
        </p>
            
    </div>
    </form>
</body>
</html>
