<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NouveauFournisseur.aspx.cs" Inherits="ProjetSynthese_1._0.NouveauFournisseur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <asp:Label ID="lblNumFournisseur" runat="server" Text="Numero " Enabled="false"></asp:Label>
    <asp:TextBox ID="txtNum" runat="server"></asp:TextBox><br/>

    <asp:Label ID="lblNomFournisseur" runat="server" Text="Nom "></asp:Label>
    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox><br/>

    <asp:Label ID="lblAdresse" runat="server" Text="Adresse "></asp:Label>
    <asp:TextBox ID="txtAdresse" runat="server"></asp:TextBox><br/>

    <asp:Label ID="lblTelephone" runat="server" Text="Téléphone "></asp:Label>
    <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox><br/>

    <asp:Button ID="btnEnregistrer" runat="server" Text="Enregistrer" OnClick="btnEnregistrer_Click"/>
</asp:Content>
