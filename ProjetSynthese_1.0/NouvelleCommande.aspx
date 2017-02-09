<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NouvelleCommande.aspx.cs" Inherits="ProjetSynthese_1._0.NouvelleCommande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <asp:Label ID="lblNum" runat="server" Text="Numero Commande "></asp:Label>
    <asp:TextBox ID="txtNumCommande" runat="server" Enabled="false"></asp:TextBox><br/>

    <asp:Label ID="lblFournisseur" runat="server" Text="Fournisseur "></asp:Label>
    <asp:DropDownList ID="cmbFournisseur" runat="server" OnSelectedIndexChanged="cmbFournisseur_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><br/>
    
    <asp:TextBox ID="txtInfoFpurnisseur" runat="server" Height="41px" Width="247px"></asp:TextBox><br/>

    <asp:Label ID="lblMontant" runat="server" Text="Montant "></asp:Label>
    <asp:TextBox ID="txtMontant" runat="server"></asp:TextBox><br/>

    <asp:Label ID="lblDateCommande" runat="server" Text="Date commande "></asp:Label>
    <asp:Calendar ID="calDateCommande" runat="server" Height="16px" Width="127px"></asp:Calendar><br/>

    <hr/>
    <asp:Label ID="lblArticle" runat="server" Text="Article "></asp:Label>
    <asp:TextBox ID="txtArticle" runat="server"></asp:TextBox>
    <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click"/>
    <br/>

    <asp:GridView ID="gridArticles" runat="server" Height="50px" Width="125px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridArticles_SelectedIndexChanged">
    </asp:GridView><br/>

     <asp:Label ID="lblNumArticle" runat="server" Text="Numero "></asp:Label>
    <asp:TextBox ID="txtNum" runat="server" Enabled="false"></asp:TextBox><br/>

    <asp:Label ID="lblNomArticle" runat="server" Text="Nom "></asp:Label>
    <asp:TextBox ID="txtNom" runat="server" Enabled="false"></asp:TextBox><br/>

    <asp:Label ID="lblPrix" runat="server" Text="Prix "></asp:Label>
    <asp:TextBox ID="txtPrix" runat="server" Enabled="false"></asp:TextBox><br/>

    <asp:Label ID="lblQuantite" runat="server" Text="Quantite "></asp:Label>
    <asp:TextBox ID="txtQuantite" runat="server"></asp:TextBox><br/>

    <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" OnClick="btnAjouter_Click" />

    <hr/>

    <asp:GridView ID="gridViewCommande" runat="server" Height="50px" Width="125px">
    </asp:GridView><br/>

    <hr/>
    <asp:Button ID="btnEnregistrer" runat="server" Text="Enregistrer" />

</asp:Content>
