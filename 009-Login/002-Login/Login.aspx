<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_002_Login.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:10px auto;padding:10px;background-color:#ccc;">
        <h1>
            Login</h1>
        <p>
            Usuário:
            <br />
            <asp:TextBox ID="Usuario" runat="server"></asp:TextBox>
        </p>
        <p>
            Senha:
            <br />
            <asp:TextBox ID="Senha" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button runat="server" Text="Login" OnClick="Logar"/>
        </p>
    </div>
    </form>
</body>
</html>
