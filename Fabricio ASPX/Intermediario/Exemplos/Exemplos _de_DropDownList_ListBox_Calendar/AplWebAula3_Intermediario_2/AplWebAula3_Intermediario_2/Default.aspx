<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplWebAula3_Intermediario_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head nat="server">
        <title>Trabalhando com ListBox</title>
        <link href="App_Themes/CSS/cssEstilos.css" rel="stylesheet" />
        </head>
    <body>
        <form id="frmWebDefault" runat="server">
            <table width="800" cellpadding="0" cellspacing="0" border="0">
                <tr>
                    <td colspan="3" align="center" class="clsTexto24">
                        <h1>Trabalhando com ListBox</h1>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center" height="50px">
                        <asp:Label ID="lblMsgErro" runat="server" Text="" CssClass="clsMsgErro"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18" height="50px">
                        Digite um Texto: &nbsp;
                    </td>
                    <td colspan="2" width="250px" height="50px">
                        <asp:TextBox ID="txtTexto" runat="server" Width="580px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18" height="50px">
                        Lista de Nomes: &nbsp;
                    </td>
                    <td colspan="2" width="250px" height="50px">
                        <asp:ListBox ID="lstNomes" runat="server" AutoPostBack="True" Height="112px" OnSelectedIndexChanged="lstNomes_SelectedIndexChanged" Width="338px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18" height="50px">
                        Posição na lista:
                    </td>
                    <td width="250px" align="center" height="50px">
                        <asp:Label ID="lblPosicaoLista" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                    <td rowspan="3" width="350px" align="center" height="50px">
                        <asp:Button ID="btnAdicionar" runat="server" Text="Adicionar" OnClick="btnAdicionar_Click" />
                        <br />
                        <br />
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                        <br />
                        <br />
                        <asp:Button ID="btnLimparTodaLista" runat="server" Text="Limpar toda a lista" OnClick="btnLimparTodaLista_Click" />
                        <br />
                        <br />
                        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18" height="50px">
                        Texto selecionado:
                    </td>
                    <td width="250px" align="center" height="50px">
                        <asp:Label ID="lblTextoSelecionado" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18" height="50px">
                        Total de Itens:
                    </td>
                    <td width="250px" align="center" height="50px">
                        <asp:Label ID="lblTotalItens" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
            </table>
        </form>
    </body>
</html>
