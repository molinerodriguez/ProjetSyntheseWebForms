<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NouvelleVente.aspx.cs" Inherits="ProjetSynthese_1._0.NouvelleVente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <br />
    <div class="h3 text-primary">Nouvel vente</div>

    <table class="table">

        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Numéro vente"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumVente" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Date vente"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateVente" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Article"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtArticle" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click" CssClass="btn btn-primary btn-block" />
            </td>
            <td></td>
        </tr>
        <tr>
            <td colspan="4">
                <div class="h3 text-primary">Lignes article</div>

                <asp:GridView ID="gridArticle" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridArticle_SelectedIndexChanged" CssClass="table Grid"></asp:GridView>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Numero article"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumArticle" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Nom article"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNomArticle" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Prix de vente"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPrixVente" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Quantité"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQuantite" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" Enabled="false" OnClick="btnAjouter_Click" CssClass="btn btn-primary btn-block" />
            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td colspan="4">
                <div class="h3 text-primary">Lignes vente</div>
                <asp:GridView ID="gridLigneVente" runat="server" CssClass="table Grid"></asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Montant"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMontant" runat="server" Enabled="false" CssClass="form-control"> </asp:TextBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnValider" runat="server" Text="Valider" Enabled="false" OnClick="btnValider_Click" CssClass="btn btn-primary btn-block" />
            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </table>

</asp:Content>
