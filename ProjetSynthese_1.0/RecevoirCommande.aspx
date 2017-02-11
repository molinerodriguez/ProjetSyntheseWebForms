<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecevoirCommande.aspx.cs" Inherits="ProjetSynthese_1._0.RecevoirCommande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="lblNumeroCommande" runat="server" Text="Numéro commande :"></asp:Label>
    <asp:TextBox ID="txtNumeroCommande" runat="server"></asp:TextBox>
    <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click"/>
    <br/>
    
    <hr>

    <asp:Label ID="lblFournisseur" runat="server" Text="Fournisseur "></asp:Label><br/>
    <asp:TextBox ID="txtFournisseur" runat="server" Enabled="false" Height="83px" TextMode="MultiLine" Width="693px"></asp:TextBox>
    <br/>
    
    <asp:Label ID="lblMontant" runat="server" Text="Montant  "></asp:Label>
    <asp:TextBox ID="txtMontant" runat="server" Enabled="false"></asp:TextBox>
    <asp:Label ID="lblDate" runat="server" Text="Date commande  "></asp:Label>
    <asp:TextBox ID="txtDate" runat="server" Enabled="false"></asp:TextBox>
    <br/>

    <asp:Label ID="lblLignesCommande" runat="server" Text="Ligne de la commande"></asp:Label><br/>
    <hr>
    <asp:GridView ID="gridLignesCommande" runat="server" AutoGenerateSelectButton="True"></asp:GridView>
    <br/>

    <%--<asp:Label ID="lblArticles" runat="server" Text="Articles commandés"></asp:Label><br/>
    <hr>
    <asp:GridView ID="gridArticlesCommande" runat="server"></asp:GridView>
    <br/>--%>

    <hr>
    
    <asp:Button ID="btnRecevoir" runat="server" Text="Recevoir" Enabled="false" OnClick="btnRecevoir_Click"/>
    <asp:Button ID="btnImprimer" runat="server" Text="Imprimer" Enabled="false"/>

</asp:Content>
