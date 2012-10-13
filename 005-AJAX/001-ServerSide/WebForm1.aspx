<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_001_ServerSide.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div>
            <h1>
                Exemplo de AJAX - Asynchronous Javascript And XML
            </h1>
        </div>
<%--        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1Tick" Enabled="True">
                </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
--%>        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel2">
            <ProgressTemplate>
                carregando os dados...</ProgressTemplate>
        </asp:UpdateProgress>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:DropDownList ID="DropDownList1" runat="server" Visible="false">
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="Carregar estado civil" OnClick="ButtonClick" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
