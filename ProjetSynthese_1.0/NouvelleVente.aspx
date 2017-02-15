<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NouvelleVente.aspx.cs" Inherits="ProjetSynthese_1._0.NouvelleVente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Numéro vente"></asp:Label>
    <asp:TextBox ID="txtNumVente" runat="server" Enabled="false"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Date vente"></asp:Label>
    <asp:TextBox ID="txtDateVente" runat="server" Enabled="false"></asp:TextBox>
    <br/>

    <hr>

    <asp:Label ID="Label3" runat="server" Text="Article"></asp:Label>
    <asp:TextBox ID="txtArticle" runat="server"></asp:TextBox>
    <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click"/>
    <br/>

    <asp:GridView ID="gridArticle" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridArticle_SelectedIndexChanged"></asp:GridView>

    <hr>

    <asp:Label ID="Label8" runat="server" Text="Numero article"></asp:Label>
    <asp:TextBox ID="txtNumArticle" runat="server" Enabled="false"></asp:TextBox>
    <asp:Label ID="Label5" runat="server" Text="Nom article"></asp:Label>
    <asp:TextBox ID="txtNomArticle" runat="server" Enabled="false"></asp:TextBox>
    <br/>
    
    <asp:Label ID="Label6" runat="server" Text="Prix de vente"></asp:Label>
    <asp:TextBox ID="txtPrixVente" runat="server" Enabled="false"></asp:TextBox>
    <asp:Label ID="Label9" runat="server" Text="Quantité"></asp:Label>
    <asp:TextBox ID="txtQuantite" runat="server"></asp:TextBox>
    <br/>
    <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" Enabled="false" OnClick="btnAjouter_Click"/>
    <br/>

    <asp:Label ID="Label7" runat="server" Text="Lignes vente"></asp:Label>
    <asp:GridView ID="gridLigneVente" runat="server"></asp:GridView>
    <br/>

    <hr>

    <asp:Label ID="Label4" runat="server" Text="Montant"></asp:Label>
    <asp:TextBox ID="txtMontant" runat="server" Enabled="false"></asp:TextBox>
    <br/>

    <hr>
    <asp:Button ID="btnValider" runat="server" Text="Valider" Enabled="false" OnClick="btnValider_Click"/>
</asp:Content>
