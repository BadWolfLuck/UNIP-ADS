<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplWebTextBox.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Trabalhando com Label, TextBox, Button e LinkLabel</title>
        <link href="App_Themes/CSS/cssEstilos.css" rel="stylesheet" />
        <script language="javascript" type="text/javascript">
            function fnValidarDados() {
                if (document.getElementById('txtNome').value == "") {
                    alert('Campo Nome esta vazio...');
                }
                else {
                    document.getElementById('frmWebDefault').action = 'frmWebResultado.aspx';
                    document.getElementById('frmWebDefault').submit();
                }
                return false;
            }
            </script>
        <style type="text/css">
            .auto-style1 {
                font-size: 18px;
                height: 22px;
            }
        </style>
    </head>
    <body>
        <form id="frmWebDefault" runat="server">
            <table width="800" cellpadding="0" cellspacing="0" border="0">
                <tr>
                    <td colspan="2" align="center" class="clsTexto24">
                        <h1>Trabalhando com Label, TextBox, Button e LinkLabel</h1>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center" height="50px">
                        <asp:Label ID="lblMsgErro" runat="server" Text="" CssClass="clsMsgErro"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18">
                        <asp:Label ID="Label1" runat="server" Text="Digite seu nome:"></asp:Label>
                    </td>
                    <td width="600px">
                        <asp:TextBox ID="txtNome" runat="server" Width="550px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style1">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" class="clsTexto18">
                        <asp:LinkButton ID="lnkWeb" runat="server" OnClientClick="fnValidarDados()">Enviar dados</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnEnviar" runat="server" Text="Enviar Dados" OnClick="btnEnviar_Click" />
                        &nbsp;
                        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" />
                    </td>
                </tr>
            </table>
        </form>
    </body>
</html>
