<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplWebAula3_Intermediario_3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head nat="server">
        <title>Trabalhando com Calendar</title>
        <link href="App_Themes/CSS/cssEstilos.css" rel="stylesheet" />
        </head>
    <body>
        <form id="frmWebDefault" runat="server">
            <table width="800" cellpadding="0" cellspacing="0" border="0">
                <tr>
                    <td colspan="3" align="center" class="clsTexto24">
                        <h1>Trabalhando com Calendar</h1>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center" height="50px">
                        <asp:Label ID="lblMsgErro" runat="server" Text="" CssClass="clsMsgErro"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center" height="50px">
                        <asp:Calendar ID="calData" runat="server" Height="211px" Width="630px" OnSelectionChanged="calData_SelectionChanged"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center" height="10px">
                        
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18" height="50px">
                        Data:
                    </td>
                    <td width="250px" align="center" height="50px">
                        <asp:Label ID="lblData" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18" height="50px">
                        M&ecirc;s:
                    </td>
                    <td width="250px" align="center" height="50px">
                        <asp:Label ID="lblMes" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td width="200px" align="right" class="clsTexto18" height="50px">
                        M&ecirc;s:
                    </td>
                    <td width="250px" align="center" height="50px">
                        <asp:Label ID="lblMes2" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
            </table>
        </form>
    </body>
</html>
