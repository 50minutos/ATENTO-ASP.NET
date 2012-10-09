<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_001_MultiView.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Cadastro de clientes</h1>
        <asp:MultiView runat="server" ID="MV" ActiveViewIndex="0">
            <asp:View runat="server">
                <p>
                    Nome:<br />
                    <asp:TextBox runat="server" ID="Nome" Width="300"></asp:TextBox>
                </p>
                <p>
                    E-mail:<br />
                    <asp:TextBox runat="server" ID="Email" Width="600"></asp:TextBox>
                </p>
                <p>
                    Confirme o e-mail:<br />
                    <asp:TextBox runat="server" ID="EmailConfirmacao" Width="600"></asp:TextBox>
                </p>
                <p><asp:Button runat="server" Text="Enviar" onclick="Unnamed2_Click" /></p>
            </asp:View>
            <asp:View runat="server">
                <h2>Você digitou:</h2>
                <p>Nome: <asp:Label runat="server" ID="LblNome"></asp:Label></p>
                <p>E-mail: <asp:Label runat="server" ID="LblEmail"></asp:Label></p>
                <p>Confirmação do e-mail: <asp:Label runat="server" ID="LblEmailConfirmacao"></asp:Label></p>
                <p><asp:Button runat="server" Text="Voltar" onclick="Unnamed4_Click" /></p>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
