<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SerieFibonacci.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" AssociatedControlID="txtNumero" Text="Ingrese el número del que desea saber la serie fibonacci: "></asp:Label>
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
        </div>
        <div>
            <br /><br /><br />
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" /><br /><br />
            <asp:Label ID="lbFibonacci" runat="server" Text="Serie Fibonacci"></asp:Label>
        </div>
    </form>
</body>
</html>
