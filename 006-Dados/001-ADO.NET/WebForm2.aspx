<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_001_ADO.NET.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem Value="X">(escolha uma opção)</asp:ListItem>
                <asp:ListItem Value="M">Masculino</asp:ListItem>
                <asp:ListItem Value="F">Feminino</asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC"
            BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="COD_PESSOA" 
            DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="COD_PESSOA" HeaderText="COD_PESSOA" 
                    InsertVisible="False" ReadOnly="True" SortExpression="COD_PESSOA" />
                <asp:BoundField DataField="NOME_PESSOA" HeaderText="NOME_PESSOA" 
                    SortExpression="NOME_PESSOA" />
                <asp:BoundField DataField="SEXO_PESSOA" HeaderText="SEXO_PESSOA" 
                    SortExpression="SEXO_PESSOA" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DbConnectionString1 %>" 
            SelectCommand="SELECT * FROM [PESSOA] WHERE ([SEXO_PESSOA] = @SEXO_PESSOA)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="SEXO_PESSOA" 
                    PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
