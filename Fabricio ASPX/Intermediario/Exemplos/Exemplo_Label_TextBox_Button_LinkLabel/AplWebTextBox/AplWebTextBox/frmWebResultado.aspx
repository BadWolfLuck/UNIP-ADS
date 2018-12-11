<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmWebResultado.aspx.cs" Inherits="AplWebTextBox.frmWebResultado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resultado</title>
</head>
<body>
    <form id="frmWebResultado" runat="server">
        <table width="800" cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td align="center" class="clsTexto24">
                    <h1>Resultado</h1>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center" class="clsTexto18">
                    <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Button ID="btnVltar" runat="server" Text="Voltar" OnClick="btnVltar_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
