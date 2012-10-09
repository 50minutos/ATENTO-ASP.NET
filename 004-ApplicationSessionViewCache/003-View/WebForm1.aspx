<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_003_View.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>View State - WebForm1</h1>
    
    <p>
        Digite o seu nome:<br/>
        <asp:TextBox runat="server" ID="Nome"></asp:TextBox>
    </p>
    
    <p>
        <asp:Label runat="server" ID="LblNome"></asp:Label>
    </p>
    
    <p>
        <asp:Button ID="Button1" runat="server" Text="Gravar no view state" OnClick="Gravar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Ler do view state" OnClick="Ler_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Context" OnClick="Context_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Session" OnClick="Session_Click" />
    </p>
    </div>
    </form>
</body>
</html>
