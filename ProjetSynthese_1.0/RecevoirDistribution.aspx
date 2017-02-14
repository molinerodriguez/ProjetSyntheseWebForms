<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecevoirDistribution.aspx.cs" Inherits="ProjetSynthese_1._0.RecevoirDistribution" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <br />
    <div class="h2 text-primary">Recevoir bon distribution</div>

    <table class="table">
        <tr>
            <td>
                <asp:Label ID="lblNumeroBonDitribution" runat="server" Text="Numéro bon distribution"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumBondistribution" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click" CssClass="btn btn-primary btn-block"/>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblNomFiliale" runat="server" Text="Filiale"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNomFiliale" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDateBonDistribution" runat="server" Text="Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDateBonDistribution" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="gridBonDistribution" runat="server"></asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnRecevoir" runat="server" Text="Recevoir" OnClick="btnRecevoir_Click" CssClass="btn btn-primary btn-block"/>
            </td>
            <td>
                <asp:Button ID="btnImprimer" runat="server" Text="Imprimer" OnClick="btnImprimer_Click" CssClass="btn btn-primary btn-block"/>
            </td>
            <td></td>
            <td></td>
        </tr>
    </table>
</asp:Content>
