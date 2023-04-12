<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proj1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Numero"></asp:Label>
            <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Fatorial"></asp:Label>
        <asp:TextBox ID="txtRes" runat="server"></asp:TextBox>
        <asp:Button ID="btCalcular" runat="server" OnClick="btCalcular_Click" Text="Calcular" />
        <p>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
