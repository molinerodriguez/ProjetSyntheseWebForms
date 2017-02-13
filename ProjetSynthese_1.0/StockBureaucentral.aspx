<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockBureaucentral.aspx.cs" Inherits="ProjetSynthese_1._0.StockBureaucentral" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="h3 text-primary">Stock bureau central</div>


    <table class="table">
        <tr>
            <td>
                <asp:Label ID="lblNom" runat="server" Text="Nom Article"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNom" runat="server" CssClass="form-control"></asp:TextBox>
            </td> 
            <td>
                <asp:Button ID="btnRechercher" runat="server" Text="Générer l'etat de stock" OnClick="btnRechercher_Click" CssClass="btn btn-primary btn-block"/>
            </td>
            <td></td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="gridEtatStock" runat="server" CssClass="table Grid"></asp:GridView>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnImprimer" runat="server" Text="Imprimer" CssClass="btn btn-primary btn-block"/>
            </td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </table>


</asp:Content>
