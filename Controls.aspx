<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Controls.aspx.cs" Inherits="AspBoots.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbltest" AssociatedControlID="txtone" runat="server" ToolTip="First Label"></asp:Label>
                <asp:TextBox ID="txtone" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="brand" DataValueField="brand">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:inventorydbConnectionString %>" ProviderName="<%$ ConnectionStrings:inventorydbConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT [brand] FROM [tblBrand]"></asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Morning</asp:ListItem>
                <asp:ListItem>Afternoon</asp:ListItem>
                <asp:ListItem>Evening</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:GridView ID="GridView1" runat="server" OnRowEditing="GridView1_RowEditing"></asp:GridView>
        </div>
    </form>
</body>
</html>
