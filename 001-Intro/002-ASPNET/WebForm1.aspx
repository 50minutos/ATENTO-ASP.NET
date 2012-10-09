<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_002_ASPNET.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Exemplo de controles ASP.NET</h1>
        <p>
            <asp:Label runat="server">exemplo de label</asp:Label>
        </p>
        <p>
            <asp:Button runat="server" Text="Clique aqui" OnClick="Unnamed2_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
