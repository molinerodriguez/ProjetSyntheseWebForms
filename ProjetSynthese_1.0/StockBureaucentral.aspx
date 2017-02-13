<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockBureaucentral.aspx.cs" Inherits="ProjetSynthese_1._0.StockBureaucentral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblNom" runat="server" Text="Nom Article"></asp:Label>
    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
    <asp:Button ID="btnRechercher" runat="server" Text="Générer etat de stock" OnClick="btnRechercher_Click"/>
    <br/>

    <hr>

    <asp:GridView ID="gridEtatStock" runat="server"></asp:GridView>
    <br/>

    <hr>
    <asp:Button ID="btnImprimer" runat="server" Text="Imprimer"/>
</asp:Content>
