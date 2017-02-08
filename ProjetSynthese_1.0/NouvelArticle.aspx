<%@ Page Title="Nouvel article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NouvelArticle.aspx.cs" Inherits="ProjetSynthese_1._0.NouvelArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <asp:Label ID="lblNumArticle" runat="server" Text="Numero "></asp:Label>
    <asp:TextBox ID="txtNum" runat="server"></asp:TextBox><br/>

    <asp:Label ID="lblNomArticle" runat="server" Text="Nom "></asp:Label>
    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox><br/>

    <asp:Label ID="lblDescription" runat="server" Text="Description "></asp:Label>
    <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox><br/>

    <asp:Label ID="lblCategorie" runat="server" Text="Categorie "></asp:Label>
    <asp:TextBox ID="txtCategorie" runat="server"></asp:TextBox><br/>

    <asp:Label ID="lblPxAchat" runat="server" Text="Prix d'achat "></asp:Label>
    <asp:TextBox ID="txtPxAchat" runat="server"></asp:TextBox><br/>

    <asp:Label ID="lblPxVente" runat="server" Text="Prix de vente "></asp:Label>
    <asp:TextBox ID="txtPxVente" runat="server"></asp:TextBox><br/>
    <asp:Button ID="btnEnregistrer" runat="server" Text="Button" OnClick="btnEnregistrer_Click"/>
</asp:Content>
