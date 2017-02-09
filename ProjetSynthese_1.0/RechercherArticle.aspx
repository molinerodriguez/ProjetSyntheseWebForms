<%@ Page Title="Rechercher article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RechercherArticle.aspx.cs" Inherits="ProjetSynthese_1._0.RechercherArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Grid.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
     <br/>
    <table class="table" >
        <tr>
            <td>
                <asp:Label ID="lblNomArticle" runat="server" Text="Nom article" CssClass="control-label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNomArticle" runat="server" OnTextChanged="txtNomArticle_TextChanged"
                    CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" 
                    OnClick="btnRechercher_Click" CssClass="btn btn-primary btn-block" />
            </td>
        </tr>
        </table>

    <asp:GridView ID="gridArticles" runat="server" AutoGenerateEditButton="True" OnRowEditing="gridArticles_RowEditing" 
        CssClass="table table-hover Grid" BorderStyle="None" >
    </asp:GridView>
</asp:Content>
