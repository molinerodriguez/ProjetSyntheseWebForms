﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModifierArticle.aspx.cs" Inherits="ProjetSynthese_1._0.ModifierArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="h3 text-primary">Modifier article</div>
    <table class="table table-hover">
        <tr>
            <td>
                <asp:Label ID="lblNumArticle" runat="server" Text="Numero" CssClass="control-label"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtNum" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtNum" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblNomArticle" runat="server" Text="Nom "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtNom" runat="server" CssClass="form-control"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtNom" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" Text="Description "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtDescription" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCategorie" runat="server" Text="Categorie "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtCategorie" runat="server" CssClass="form-control"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtCategorie" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPxAchat" runat="server" Text="Prix d'achat "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPxAchat" runat="server" CssClass="form-control" Text="0"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtPxAchat" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Nombre positiv seulement (ex:2.0)"
                    ControlToValidate="txtPxAchat" Enabled="false"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPxVente" runat="server" Text="Prix de vente "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPxVente" runat="server" CssClass="form-control" Text="0"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtPxVente" ForeColor="Red"></asp:RequiredFieldValidator>
            
            </td>
            <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Nombre positiv seulement (ex:2.0)"
                ControlToValidate="txtPxVente"  Enabled="false"></asp:RangeValidator>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnModifier" runat="server" Text="Modifier" OnClick="btnModifier_Click"
                    CssClass="btn btn-primary btn-block" /></td>
            <td>
                <asp:Label ID="lblResultatModificationArticle" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>


</asp:Content>
