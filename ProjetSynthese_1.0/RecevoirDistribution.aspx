<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecevoirDistribution.aspx.cs" Inherits="ProjetSynthese_1._0.RecevoirDistribution" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblNumeroBonDitribution" runat="server" Text="Numéro bon distribution"></asp:Label>
    <asp:TextBox ID="txtNumBondistribution" runat="server"></asp:TextBox>
    <br/>

    <hr>

    <asp:Label ID="lblNomFiliale" runat="server" Text="Filiale"></asp:Label>
    <asp:TextBox ID="txtNomFiliale" runat="server" Enabled="false"></asp:TextBox>
    <br/>

    <asp:Label ID="lblDateBonDistribution" runat="server" Text="Date"></asp:Label>
    <asp:TextBox ID="txtDateBonDistribution" runat="server" Enabled="false"></asp:TextBox>
    <br/>

    <hr>

    <asp:GridView ID="gridBonDistribution" runat="server"></asp:GridView>
    <br/>

    <hr>

    <asp:Button ID="btnRecevoir" runat="server" Text="Recevoir" />
    <asp:Button ID="btnImprimer" runat="server" Text="Imprimer" />

</asp:Content>
