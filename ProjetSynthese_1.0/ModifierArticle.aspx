<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModifierArticle.aspx.cs" Inherits="ProjetSynthese_1._0.ModifierArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="h3 text-primary">Modifier article</div>
    <table class="table table-hover">
        <tr>
            <td>
                <asp:Label ID="lblNumArticle" runat="server" Text="Numero" CssClass="control-label"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtNum" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblNomArticle" runat="server" Text="Nom "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtNom" runat="server" CssClass="form-control"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" Text="Description "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCategorie" runat="server" Text="Categorie "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtCategorie" runat="server" CssClass="form-control"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPxAchat" runat="server" Text="Prix d'achat "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPxAchat" runat="server" CssClass="form-control" ></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPxVente" runat="server" Text="Prix de vente "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPxVente" runat="server" CssClass="form-control" ></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnModifier" runat="server" Text="Modifier" OnClick="btnModifier_Click"
                    CssClass="btn btn-primary btn-block" /></td>
            <td>
                <asp:Label ID="lblResultatModificationArticle" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>


</asp:Content>
