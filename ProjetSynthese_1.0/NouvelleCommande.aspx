﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NouvelleCommande.aspx.cs" Inherits="ProjetSynthese_1._0.NouvelleCommande" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Grid.css" rel="stylesheet" />

    <br />
    <div class="h2 text-primary">Placer commande</div>

    <table class="table table-responsive">
        <tr>
            <td>
                <asp:Label ID="lblNum" runat="server" Text="Numero Commande "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumCommande" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblFournisseur" runat="server" Text="Fournisseur "></asp:Label>
            </td>
            <td>
                <div class="form-group">
                    <asp:DropDownList ID="cmbFournisseur" runat="server" OnSelectedIndexChanged="cmbFournisseur_SelectedIndexChanged"
                        AutoPostBack="true" CssClass="form-control">
                    </asp:DropDownList>
                </div>
            </td>
            <td>
                <asp:TextBox ID="txtInfoFpurnisseur" runat="server" Height="60px" Enabled="False" CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDateCommande" runat="server" Text="Date commande "></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="calDateCommande" runat="server" BackColor="White" BorderColor="White" 
                    BorderStyle="None" Font-Names="Verdana" 
                    Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" 
                    Width="350px"
                    SelectedDate="<%# DateTime.Today %>">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
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
                <asp:Button ID="btnRechercher" runat="server" Text="Rechercher"
                    OnClick="btnRechercher_Click" CssClass="btn btn-primary btn-block pull-left" />
            </td>
            <td></td>
        </tr>
    </table>

    <hr />
    <%--GRID--%>
    <asp:GridView ID="gridArticles" runat="server" OnSelectedIndexChanged="gridArticles_SelectedIndexChanged"
        AutoGenerateDeleteButton="False" AutoGenerateSelectButton="True" CssClass="table Grid">
    </asp:GridView>

    <br />
    <div class="h4 text-primary">Article séléctioné</div>
    <table class="table">
        <tr>
            <td>
                <asp:Label ID="lblNumArticle" runat="server" Text="Numero "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNum" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
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
                <asp:Label ID="lblPrix" runat="server" Text="Prix "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPrix" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblQuantite" runat="server" Text="Quantite"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQuantite" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" OnClick="btnAjouter_Click"
                    Enabled="false" CssClass="btn btn-primary btn-block pull-left" />
            </td>
            <td></td>
        </tr>
    </table>
    <hr />
    <%--GRID--%>
    <asp:GridView ID="gridViewCommande" runat="server" AutoGenerateDeleteButton="True" OnRowDeleting="gridViewCommande_RowDeleting" CssClass="table table-responsive Grid">
    </asp:GridView>

    <br />
    <div class="h4 text-primary">Montant total</div>
    <table class="table">
        <tr>
            <td>
                <asp:Label ID="lblMontant" runat="server" Text=""></asp:Label>
                <asp:TextBox ID="txtMontant" runat="server" Enabled="False"
                    CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnEnregistrer" runat="server" Text="Enregistrer" Enabled="false" OnClick="btnEnregistrer_Click" CssClass="btn btn-primary btn-block" />
            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </table>

</asp:Content>
