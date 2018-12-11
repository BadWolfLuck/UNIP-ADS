<%@ Page Title="" Language="C#" MasterPageFile="~/frmWebPrincipal.Master" AutoEventWireup="true" CodeBehind="frmWebContato.aspx.cs" Inherits="AplWebMasterPage.frmWebContato" %>
<asp:Content ID="Content3" ContentPlaceHolderID="cphConteudo" runat="server">
    <table width="1024px" cellpadding="0px" cellspacing="0px" border="0">
        <tr>
            <td colspan="2" height="20px">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td width="224px" height="30px" align="right">
                Nome:&nbsp;
            </td>
            <td width="800px" height="30px">
                <input type="text" name="txtNome" size="51" maxlength="50" value="" />
            </td>
        </tr>
        <tr>
            <td width="224px" height="30px" align="right">
                E-Mail:&nbsp;
            </td>
            <td width="800px" height="30px">
                <input type="text" name="txtEmail" size="130" maxlength="300" value="" />
            </td>
        </tr>
        <tr>
            <td width="224px" height="30px" align="right">
                Telefone:&nbsp;
            </td>
            <td width="800px" height="30px">
                <input type="text" name="txtTelefone" size="15" maxlength="15" value="" />
            </td>
        </tr>
        <tr>
            <td width="224px" height="30px" align="right">
                Assunto:&nbsp;
            </td>
            <td width="800px" height="30px">
                <select name="ddlAssunto" style="width: 130px">
                    <option value="Duvidas">D&uacute;vidas</option>
                    <option value="Sugestoes">Sugest&otilde;es</option>
                    <option value="Criticas">Cr&iacute;ticas</option>
                    <option value="Elogios">Elogios</option>
                </select>
            </td>
        </tr>
        <tr>
            <td width="224px" height="30px" align="right">
                Mensagem:&nbsp;
            </td>
            <td width="800px" height="30px">
                <textarea name="txtMensagem" cols="50" rows="10" maxlength="500"></textarea>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="10px">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="2" height="30px" align="center" valign="middle">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                &nbsp;
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar" />
            </td>
        </tr>
        <tr>
            <td colspan="2" height="20px">
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
