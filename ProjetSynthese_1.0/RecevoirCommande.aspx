<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecevoirCommande.aspx.cs" Inherits="ProjetSynthese_1._0.RecevoirCommande" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="h3 text-primary">Recevoir commande</div>
    <table class="table table-responsive">
        <tr>
            <td>
                <asp:Label ID="lblNumeroCommande" runat="server" Text="Numéro commande :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumeroCommande" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label ID="lblResultatNumeroCommande" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
            <td></td>
            <td>
                <asp:Button CssClass="btn btn-primary btn-block" ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblFournisseur" runat="server" Text="Fournisseur "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFournisseur" runat="server" Enabled="false"
                    Height="100px" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMontant" runat="server" Text="Montant  "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMontant" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblDate" runat="server" Text="Date commande  "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDate" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td colspan="4">
                <div class="h3 text-primary">Les lignes de la commande</div>
                <asp:GridView CssClass="table table-responsive Grid" ID="gridLignesCommande" runat="server" AutoGenerateSelectButton="True"></asp:GridView>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblResultatRecevoir" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
            <td></td>
            <td>
                <asp:Button CssClass="btn btn-primary btn-block" ID="btnRecevoir" runat="server" Text="Recevoir" Enabled="false" OnClick="btnRecevoir_Click" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Button CssClass="btn btn-primary btn-block" ID="btnImprimer" runat="server" Text="Imprimer" Enabled="false" />

            </td>
        </tr>
    </table>

</asp:Content>
