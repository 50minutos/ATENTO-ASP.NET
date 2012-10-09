<%@ Control 
Language="C#" 
AutoEventWireup="true" 
CodeBehind="WebUserControl1.ascx.cs" 
Inherits="_003_Links.WebUserControl1" %>

<p style="text-align:center;background-color:#999;padding:10px;">
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/WebForm1.aspx" runat="server">Página 1</asp:HyperLink>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink2" NavigateUrl="~/WebForm2.aspx" runat="server">Página 2</asp:HyperLink>    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink3" NavigateUrl="~/WebForm3.aspx" runat="server">Página 3</asp:HyperLink>    
</p>
<hr />
    