<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_002_ClientSide.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .cinza
        {
            color: #ccc;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
        <h1>
            Cadastro</h1>
        <p>
            Nome:<br />
            <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
            <asp:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" runat="server"
                Enabled="True" TargetControlID="TextBox1" WatermarkText="digite o seu nome" WatermarkCssClass="cinza">
            </asp:TextBoxWatermarkExtender>
        </p>
        <p>
            Data de nascimento:<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" Enabled="True"
                TargetControlID="TextBox2">
            </asp:CalendarExtender>
        </p>
        <p>
            Peso:<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:NumericUpDownExtender ID="TextBox3_NumericUpDownExtender" runat="server" Enabled="True"
                Maximum="200" Minimum="0" RefValues="" ServiceDownMethod="" ServiceDownPath="" ServiceUpMethod="" Tag="" TargetButtonDownID="" TargetButtonUpID="" TargetControlID="TextBox3" Width="100">
            </asp:NumericUpDownExtender>
        </p>
        <cc1:Editor ID="Editor1" runat="server" />
    </div>
    </form>
</body>
</html>
