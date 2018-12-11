<%@ Page Title="" Language="C#" MasterPageFile="~/frmWebPrincipal.Master" AutoEventWireup="true" CodeBehind="frmWebConsulta.aspx.cs" Inherits="AplWebMasterPage.frmWebConsulta" %>
<asp:Content ID="Content3" ContentPlaceHolderID="cphConteudo" runat="server">
    <%
        Response.Write("Nome = " + Request["txtNome"] + "<br>");
        Response.Write("E-Mail = " + Request["txtEmail"] + "<br>");
        Response.Write("Telefone = " + Request["txtTelefone"] + "<br>");
        Response.Write("Assunto = " + Request["ddlAssunto"] + "<br>");
        Response.Write("Mensagem = " + Request["txtMensagem"]);
    %>
</asp:Content>
