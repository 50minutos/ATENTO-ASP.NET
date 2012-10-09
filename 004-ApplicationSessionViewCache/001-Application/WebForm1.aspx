<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_001_Application.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p>
            Empresa:
            <asp:Label ID="Label1" runat="server" style="font-weight: 700"></asp:Label>
        </p>
        <p>
            Desenvolvedor:
            <asp:Label ID="Label2" runat="server" style="font-weight: 700"></asp:Label>
        </p>
        <p>
            E-mail:
            <asp:Label ID="Label3" runat="server" style="font-weight: 700"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/WebForm2.aspx" 
                Text="Clique aqui para alterar os dados de Application" />
        </p>
    </div>
    </form>
</body>
</html>
