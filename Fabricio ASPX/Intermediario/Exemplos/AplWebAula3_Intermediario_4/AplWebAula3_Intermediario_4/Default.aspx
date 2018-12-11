<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplWebAula3_Intermediario_4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head nat="server">
        <title>Trabalhando com AdRotator</title>
        <link href="App_Themes/CSS/cssEstilos.css" rel="stylesheet" />
        </head>
    <body>
        <form id="frmWebDefault" runat="server">
            <table width="800" cellpadding="0" cellspacing="0" border="0">
                <tr>
                    <td colspan="3" align="center" class="clsTexto24">
                        <h1>Trabalhando com AdRotator</h1>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center" height="50px">
                        <asp:Label ID="lblMsgErro" runat="server" Text="" CssClass="clsMsgErro"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center" height="50px">
                        <asp:AdRotator ID="arBanners" runat="server" AdvertisementFile="~/App_Code/arBanners.xml" Height="350px" Width="700px" />
                    </td>
                </tr>
            </table>
        </form>
    </body>
</html>
