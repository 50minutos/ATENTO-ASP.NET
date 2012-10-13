<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_001_ADO.NET.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
            DataKeyNames="COD_PESSOA" DataSourceID="SqlDataSource1" 
            EmptyDataText="There are no data records to display." ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="COD_PESSOA" HeaderText="CÓD" ReadOnly="True" 
                    SortExpression="COD_PESSOA" />
                <asp:BoundField DataField="NOME_PESSOA" HeaderText="NOME" 
                    SortExpression="NOME_PESSOA" />
                <asp:BoundField DataField="SEXO_PESSOA" HeaderText="SEXO" 
                    SortExpression="SEXO_PESSOA" />
                <asp:CommandField CancelText="Cancelar" DeleteText="Excluir" EditText="Alterar" 
                    ShowDeleteButton="True" ShowEditButton="True" UpdateText="Gravar" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:DbConnectionString1 %>" 
            DeleteCommand="DELETE FROM [PESSOA] WHERE [COD_PESSOA] = @COD_PESSOA" 
            InsertCommand="INSERT INTO [PESSOA] ([NOME_PESSOA], [SEXO_PESSOA]) VALUES (@NOME_PESSOA, @SEXO_PESSOA)" 
            ProviderName="<%$ ConnectionStrings:DbConnectionString1.ProviderName %>" 
            SelectCommand="SELECT [COD_PESSOA], [NOME_PESSOA], [SEXO_PESSOA] FROM [PESSOA]" 
            UpdateCommand="UPDATE [PESSOA] SET [NOME_PESSOA] = @NOME_PESSOA, [SEXO_PESSOA] = @SEXO_PESSOA WHERE [COD_PESSOA] = @COD_PESSOA">
            <DeleteParameters>
                <asp:Parameter Name="COD_PESSOA" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="NOME_PESSOA" Type="String" />
                <asp:Parameter Name="SEXO_PESSOA" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="NOME_PESSOA" Type="String" />
                <asp:Parameter Name="SEXO_PESSOA" Type="String" />
                <asp:Parameter Name="COD_PESSOA" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            CellPadding="4" DataKeyNames="COD_PESSOA" DataSourceID="SqlDataSource1" 
            DefaultMode="Insert" ForeColor="#333333" GridLines="None" Height="50px" 
            Width="125px">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="COD_PESSOA" HeaderText="Código:" 
                    InsertVisible="False" ReadOnly="True" SortExpression="COD_PESSOA" />
                <asp:BoundField DataField="NOME_PESSOA" HeaderText="Nome:" 
                    SortExpression="NOME_PESSOA" />
                <asp:BoundField DataField="SEXO_PESSOA" HeaderText="Sexo:" 
                    SortExpression="SEXO_PESSOA" />
                <asp:CommandField CancelText="Cancelar" InsertText="Gravar" 
                    ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
    
    </div>
    </form>
</body>
</html>
