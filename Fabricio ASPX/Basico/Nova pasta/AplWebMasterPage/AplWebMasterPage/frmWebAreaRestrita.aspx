<%@ Page Title="" Language="C#" MasterPageFile="~/frmWebPrincipal.Master" AutoEventWireup="true" CodeBehind="frmWebAreaRestrita.aspx.cs" Inherits="AplWebMasterPage.frmWebAreaRestrita" %>
<asp:Content ID="Content3" ContentPlaceHolderID="cphConteudo" runat="server">
    <table width="1024px" cellspacing="0px" cellpadding="0px" border="0">
        <tr>
            <td colspan="2" height="30px">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td width="512px" height="50px" class="clsEtiqueta">
                Usu&aacute;rio:&nbsp;
            </td>
            <td width="512px" height="50px">
                <asp:TextBox ID="txtUsuario" runat="server" MaxLength="20" Width="141px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="512px" height="50px" class="clsEtiqueta">
                Senha:&nbsp;
            </td>
            <td width="512px" height="50px">
                <asp:TextBox ID="txtSenha" runat="server" MaxLength="50" Width="189px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" height="50px" align="center" valign="middle">
                <asp:Button ID="btnLogar" runat="server" Text="Logar" />
                &nbsp;
                <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2" height="30px">
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
