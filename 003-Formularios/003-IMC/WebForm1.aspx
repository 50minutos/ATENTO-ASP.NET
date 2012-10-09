<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_003_IMC.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            IMC</h1>
        <h2>
            imc = massa / altura²</h2>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <p>
                    Qual é o seu peso?<br />
                    <asp:TextBox runat="server" ID="Massa"></asp:TextBox>
                <p>
                    Qual é a sua altura?<br />
                    <asp:TextBox runat="server" ID="Altura"></asp:TextBox>
                </p>
                <p>
                    <asp:Button runat="server" OnClick="Calcular" Text="Calcular" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <p>
                    Seu imc é
                    <asp:Label runat="server" ID="IMC" Font-Bold="true"></asp:Label></p>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
