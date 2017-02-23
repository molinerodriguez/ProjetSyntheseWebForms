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
                <%--<asp:TextBox ID="txtNumBondistribution" runat="server" CssClass="form-control"></asp:TextBox>--%>
                <asp:DropDownList ID="ddlNumBonDistribution" runat="server" CssClass="form-control"></asp:DropDownList>

                <asp:Label ID="lblResultatNumeroBonDistribution" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" OnClick="btnRechercher_Click" CssClass="btn btn-primary btn-block" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblNomFiliale" runat="server" Text="Filiale"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNomFiliale" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
            </td>
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
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gridBonDistribution" runat="server" CssClass="table Grid"></asp:GridView>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblResultatRecevoirBonDistribution" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
            <td>
                    <asp:Button ID="btnRecevoir" runat="server" Text="Recevoir" OnClick="btnRecevoir_Click" CssClass="btn btn-primary btn-block" Enabled="false" />
                    <asp:Button ID="btnImprimer" runat="server" Text="Imprimer" OnClick="btnImprimer_Click" CssClass="btn btn-primary btn-block" Enabled="false"/>
            </td>
        </tr>
    </table>
</asp:Content>
