<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspBoots.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Tailwind Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="imgCover" runat="server" />
            <asp:HyperLink ID="HyperLink1" runat="server"
                NavigateUrl="~/Home.aspx">Go Home</asp:HyperLink>

            <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
            <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click"
                />
            <asp:Label ID="lblmessage" runat="server" Text="Message"></asp:Label>
        </div>

    </form>
</body>
</html>
