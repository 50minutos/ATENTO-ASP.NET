<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_004_Triangulos.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Triângulos</h1>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View runat="server">
                <p>Informe o lado a:<br />
                    <asp:TextBox ID="LadoA" runat="server"/></p>
                <p>Informe o lado b:<br />
                    <asp:TextBox ID="LadoB" runat="server"/></p>
                <p>Informe o lado c:<br />
                    <asp:TextBox ID="LadoC" runat="server"/></p>
                <p><asp:Button runat="server" OnClick="Calcular" Text="Calcular"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="LadoA" Display="None" ErrorMessage="Preencha o lado a" 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="LadoB" Display="None" ErrorMessage="Preencha o lado b" 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="LadoC" Display="None" ErrorMessage="Preencha o lado c" 
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="LadoA" Display="None" ErrorMessage="Digite um valor inteiro" 
                        Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToValidate="LadoB" Display="None" ErrorMessage="Digite um valor inteiro" 
                        Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
                </p>
                <p>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" 
                        ControlToValidate="LadoC" Display="None" ErrorMessage="Digite um valor inteiro" 
                        Operator="DataTypeCheck" SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
                </p>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </asp:View>
            <asp:View runat="server">
            <p style="text-align: center">
                <asp:Image ID="Imagem" runat="server" />
                </p>
            <p class="style1">
                <asp:Label ID="Mensagem" runat="server" />
                </p>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
