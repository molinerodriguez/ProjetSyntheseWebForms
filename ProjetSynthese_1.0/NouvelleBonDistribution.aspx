﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NouvelleBonDistribution.aspx.cs" Inherits="ProjetSynthese_1._0.NouvelleBonDistribution" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="h3 text-primary">Nouveau bon de distribution</div>

    <table class="table">
        <tr>
            <td>
                <asp:Label ID="lblNum" runat="server" Text="Numéro Bon Distribution "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumBonDistribution" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblFiliale" runat="server" Text="Filiale "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cmbFiliale" runat="server"
                    OnSelectedIndexChanged="cmbFiliale_SelectedIndexChanged" AutoPostBack="true"
                    CssClass="form-control">
                </asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="txtInfoFiliale" runat="server" Height="100px" TextMode="MultiLine" Enabled="False" CssClass="form-control"></asp:TextBox><br />
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDateBonDistribution" runat="server" Text="Date Bon distribution "></asp:Label>
            </td>
            <td>
                <input id="Text1" type="text" value="<%= DateTime.Now.ToShortDateString() %>" class="form-control" readonly />
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblArticle" runat="server" Text="Article "></asp:Label>
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
                <asp:GridView ID="gridArticles" runat="server"
                    OnSelectedIndexChanged="gridArticles_SelectedIndexChanged"
                    AutoGenerateSelectButton="True" CssClass="table Grid">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblNumArticle" runat="server" Text="Numéro "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumArticle" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblNomArticle" runat="server" Text="Nom "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNom" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblQuantite" runat="server" Text="Quantité"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQuantite" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label ID="lblResultatTxtQuantite" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" OnClick="btnAjouter_Click" Enabled="false" CssClass="btn btn-primary btn-block" />
            </td>
            <td></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="gridViewDistribution" runat="server" AutoGenerateDeleteButton="True"
                    OnRowDeleting="gridViewDistribution_RowDeleting" CssClass="table Grid">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblResultatEnregistrer" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnEnregistrer" runat="server" Text="Enregistrer" Enabled="false"
                    OnClick="btnEnregistrer_Click" CssClass="btn btn-primary btn-block" />
            </td>
            <td></td>
        </tr>
    </table>

</asp:Content>
