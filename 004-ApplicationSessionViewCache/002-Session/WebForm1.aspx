<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_002_Session.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>
        URL: <asp:Label runat="server" ID="URL"/>
    </p>
    <p>
        Session ID: <asp:Label runat="server" ID="ID"/>
    </p>
    <p>
        Nome:<br />
        <asp:TextBox runat="server" ID="Nome"></asp:TextBox>
    </p>
    <p>
        <asp:Button runat="server" Text="Enviar" OnClick="Enviar"/>
    </p>
    </div>
    </form>
</body>
</html>
