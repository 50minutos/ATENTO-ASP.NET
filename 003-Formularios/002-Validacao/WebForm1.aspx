<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_002_Validacao.WebForm1" %>

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
            <asp:View ID="View1" runat="server">
                <p>
                    Nome:<br />
                    <asp:TextBox runat="server" ID="Nome" Width="300"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="Nome" Display="None" ErrorMessage="Preencha o campo nome!!!" 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                </p>
                <p>
                    E-mail:<br />
                    <asp:TextBox runat="server" ID="Email" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="Email" Display="None" 
                        ErrorMessage="Preencha o campo e-mail!!!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="Email" Display="None" 
                        ErrorMessage="Digite um e-mail válido!!!" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </p>
                <p>
                    Senha:<br />
                    <asp:TextBox runat="server" ID="Senha" Width="100" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="Senha" Display="None" 
                        ErrorMessage="Preencha o campo senha!!!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </p>
                <p>
                    Confirme a senha:<br />
                    <asp:TextBox runat="server" ID="SenhaConfirmacao" Width="100" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="Senha" ControlToValidate="SenhaConfirmacao" Display="None" 
                        ErrorMessage="Digite senhas iguais!!!" SetFocusOnError="True"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="SenhaConfirmacao" Display="None" 
                        ErrorMessage="Preencha o campo confirme a senha!!!" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </p>
                <p>
                    Idade:<br />
                    <asp:TextBox runat="server" ID="Idade" Width="50"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="Idade" Display="None" 
                        ErrorMessage="Digite um valor numérico inteiro!!!" Operator="DataTypeCheck" 
                        SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
                </p>
                <p>
                    <asp:Button runat="server" Text="Enviar" OnClick="Unnamed2_Click" /></p>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ShowMessageBox="True" ShowSummary="False" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <h2>
                    Você digitou:</h2>
                <p>
                    Nome:
                    <asp:Label runat="server" ID="LblNome" Font-Bold="true"></asp:Label></p>
                <p>
                    E-mail:
                    <asp:Label runat="server" ID="LblEmail" Font-Bold="true"></asp:Label></p>
                <p>
                    Senha:
                    <asp:Label runat="server" ID="LblSenha" Font-Bold="true"></asp:Label></p>
                <p>
                    Idade:
                    <asp:Label runat="server" ID="LblIdade" Font-Bold="true"></asp:Label></p>
                <p>
                    <asp:Button runat="server" Text="Voltar" OnClick="Unnamed4_Click" /></p>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
