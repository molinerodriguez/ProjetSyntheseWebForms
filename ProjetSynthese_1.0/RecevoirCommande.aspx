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
            </td>
            <td>
                <asp:Button CssClass="btn btn-primary btn-block" ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click" />
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblFournisseur" runat="server" Text="Fournisseur "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFournisseur" runat="server" Enabled="false"
                    Height="83px" TextMode="MultiLine" Width="693px" CssClass="form-control"></asp:TextBox>
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
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </table>
    <hr />

    <asp:Label ID="lblLignesCommande" runat="server" Text="Ligne de la commande"></asp:Label>
    <hr>
    <asp:GridView CssClass="table table-responsive Grid" ID="gridLignesCommande" runat="server" AutoGenerateSelectButton="True"></asp:GridView>
    <%--<asp:Label ID="lblArticles" runat="server" Text="Articles commandés"></asp:Label><br/>
    <hr>
    <asp:GridView ID="gridArticlesCommande" runat="server"></asp:GridView>
    <br/>--%>
    <hr>
    <table class="table table-responsive ">
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <div class="btn-group pull-right">
                    <asp:Button CssClass="btn btn-primary " ID="btnRecevoir" runat="server" Text="Recevoir" Enabled="false" OnClick="btnRecevoir_Click" />
                    <asp:Button CssClass="btn btn-primary " ID="btnImprimer" runat="server" Text="Imprimer" Enabled="false" />
                </div>
            </td>
        </tr>
    </table>

</asp:Content>
