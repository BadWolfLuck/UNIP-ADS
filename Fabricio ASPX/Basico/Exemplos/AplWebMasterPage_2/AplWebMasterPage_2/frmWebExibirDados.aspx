<%@ Page Title="" Language="C#" MasterPageFile="~/frmWebPrincipal.Master" AutoEventWireup="true" CodeBehind="frmWebExibirDados.aspx.cs" Inherits="AplWebMasterPage_2.frmWebExibirDados" %>
<asp:Content ID="Content3" ContentPlaceHolderID="cphCorpoPrincipal" runat="server">
    <%
        Response.Write("Nome: " + Request["txtNome"].ToString() + "<br>");
        Response.Write("E-Mail: " + Request["txtEMail"].ToString() + "<br>");
        Response.Write("Telefone: " + Request["txtTelefone"].ToString() + "<br>");
        Response.Write("Assunto: " + Request["cboAssunto"].ToString() + "<br>");
    %>
</asp:Content>
