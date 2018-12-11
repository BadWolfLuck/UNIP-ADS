<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplWebAula2_Intermediario.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head nat="server">
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
        </head>
    <body>
        <form id="frmWebDefault" runat="server">
            <table width="800" cellpadding="0" cellspacing="0" border="0">
                <tr>
                    <td colspan="3" align="center" class="clsTexto24">
                        <h1>Trabalhando com LinkButton, CheckBox, RadioButton, Image e ImageButton</h1>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center" height="50px">
                        <asp:Label ID="lblMsgErro" runat="server" Text="" CssClass="clsMsgErro"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18">
                        Imagem seelcionada
                    </td>
                    <td width="250px">
                        <asp:Image ID="imgFoto" runat="server" Height="149px" Width="236px" />
                    </td>
                    <td width="350px" align="center">
                        <asp:ImageButton ID="btnSelecionarImagem" runat="server" Height="50px" ImageUrl="~/Imagens/imgbtnselecionar.png" Width="100px" OnClick="btnSelecionarImagem_Click" />
                        <br />
                        <br />
                        <asp:ImageButton ID="btnLimparImagem" runat="server" Height="50px" ImageUrl="~/Imagens/imgbtnlimpar.png" Width="100px" OnClick="btnLimparImagem_Click" />
                    </td>
                </tr>
                <tr>
                    <td rowspan="2" width="200px" align="right" class="clsTexto18" height="50px">
                        Tamanho da Imagem:
                    </td>
                    <td width="250px" height="50px">
                        <asp:RadioButton ID="rdoTamnahoPequeno" GroupName="grpTamanho" runat="server" Text="Pequena" AutoPostBack="True" OnCheckedChanged="rdoTamnahoPequeno_CheckedChanged" />
                    </td>
                    <td width="350px" align="left" height="50px">
                        <asp:RadioButton ID="rdoTamanhoMedio" GroupName="grpTamanho" runat="server" Text="Mèdia" AutoPostBack="True" OnCheckedChanged="rdoTamanhoMedio_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td width="250px" height="50px">
                        <asp:RadioButton ID="rdoTamanhoGrande" GroupName="grpTamanho" runat="server" Text="Grande" AutoPostBack="True" OnCheckedChanged="rdoTamanhoGrande_CheckedChanged" />
                    </td>
                    <td width="350px" align="left" height="50px">
                        <asp:RadioButton ID="rdoTamanhoExtraLargo" GroupName="grpTamanho" runat="server" Text="Extra Grande" AutoPostBack="True" OnCheckedChanged="rdoTamanhoExtraLargo_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center" valign="middle">
                        &nbsp;
                        <asp:Image ID="imgAmpliada" runat="server" Height="61px" Width="96px" Visible="False" />
                    </td>
                </tr>
            </table>
        </form>
    </body>
</html>
