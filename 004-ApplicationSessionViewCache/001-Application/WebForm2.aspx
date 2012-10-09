<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_001_Application.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Alteração de Application</h1>
    <p>
        Nome da empresa: <br/>
        <asp:TextBox runat="server" ID="NomeEmpresa"></asp:TextBox>
    </p>
    <p>
        Desenvolvedor: <br/>
        <asp:TextBox runat="server" ID="Desenvolvedor"></asp:TextBox>
    </p>
    <p>
        E-mail: <br/>
        <asp:TextBox runat="server" ID="Email"></asp:TextBox>
    </p>
    <p>
        <asp:Button runat="server" Text="Gravar" OnClick="Gravar"/>
    </p>
    </div>
    </form>
</body>
</html>
