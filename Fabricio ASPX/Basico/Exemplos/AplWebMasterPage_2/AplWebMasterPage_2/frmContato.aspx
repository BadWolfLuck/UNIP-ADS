<%@ Page Title="" Language="C#" MasterPageFile="~/frmWebPrincipal.Master" AutoEventWireup="true" CodeBehind="frmContato.aspx.cs" Inherits="AplWebMasterPage_2.frmContato" %>
<asp:Content ID="Content3" ContentPlaceHolderID="cphCorpoPrincipal" runat="server">
        <table width="1200" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="2" height="100" class="clsTexto25VM" align="center" valign="middle">
                    Contato
                </td>
            </tr>
            <tr>
                <td width="100" height="50" class="clsTexto14VM" align="right" valign="middle">
                    Nome:
                </td>
                <td width="1100" height="50" class="clsTexto14VM" align="left" valign="middle">
                    <input type="text" name="txtNome" value="" size="130" />
                </td>
            </tr>
            <tr>
                <td width="100" height="50" class="clsTexto14VM" align="right" valign="middle">
                    E-Mail:
                </td>
                <td width="1100" height="50" class="clsTexto14VM" align="left" valign="middle">
                    <input type="text" name="txtEMail" value="" size="130" />
                </td>
            </tr>
            <tr>
                <td width="100" height="50" class="clsTexto14VM" align="right" valign="middle">
                    Telefone:
                </td>
                <td width="1100" height="50" class="clsTexto14VM" align="left" valign="middle">
                    <input type="text" name="txtTelefone" value="" size="20" />
                </td>
            </tr>
            <tr>
                <td width="100" height="50" class="clsTexto14VM" align="right" valign="middle">
                    Assunto:
                </td>
                <td width="1100" height="50" class="clsTexto14VM" align="left" valign="middle">
                    <select name="cboAssunto">
                        <option value="" selected>Escolha um Assunto</option>
                        <option value="Criticas">Cr&iacute;ticas</option>
                        <option value="Duvidas">D&uacute;vidas</option>
                        <option value="Elogios">Elogios</option>
                        <option value="Reclamacoes">Reclama&ccedil;&otilde;es</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2" height="50" class="clsTexto14VM" align="center" valign="middle">
                    <input type="button" name="btnEnviar" value="Enviar" onclick="fnValidarDados();" />
                    &nbsp;
                    <input type="reset" name="btnlimpar" value="Limpar" />
                </td>
            </tr>
        </table>
</asp:Content>
