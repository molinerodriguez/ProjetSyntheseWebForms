<%@ Page Title="Rechercher article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RechercherArticle.aspx.cs" Inherits="ProjetSynthese_1._0.RechercherArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br/> <br/>
    <asp:Label ID="lblNomArticle" runat="server" Text="Nom article"></asp:Label>
    <asp:TextBox ID="txtNomArticle" runat="server" OnTextChanged="txtNomArticle_TextChanged"></asp:TextBox>
    <br/>
    <asp:GridView ID="gridArticles" runat="server" AutoGenerateEditButton="True" OnRowEditing="gridArticles_RowEditing"></asp:GridView>
</asp:Content>
