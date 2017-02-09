<%@ Page Title="Nouvel article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NouvelArticle.aspx.cs" Inherits="ProjetSynthese_1._0.NouvelArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="h3 text-primary">Nouvel article</div>
    <table class="table table-hover">
        <tr>
            <td>
                <asp:Label ID="lblNumArticle" runat="server" Text="Numero "></asp:Label></td>
            <td>
                <asp:TextBox ID="txtNum" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox></td>
            <td></td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lblNomArticle" runat="server" Text="Nom " CssClass="control-label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNom" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtNom" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" Text="Description "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtDescription" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCategorie" runat="server" Text="Categorie "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCategorie" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtCategorie" ForeColor="Red">
                </asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPxAchat" runat="server" Text="Prix d'achat "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPxAchat" runat="server" CssClass="form-control" ForeColor="Red"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtPxAchat" ForeColor="Red">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Nombre réel seulement (ex: 0.5)"
                    ControlToValidate="txtPxAchat" Type="Double" ForeColor="Red">
                </asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPxVente" runat="server" Text="Prix de vente "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPxVente" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                    ErrorMessage="Champ obligatoire" ControlToValidate="txtPxVente" ForeColor="Red">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Nombre réel seulement (ex: 10.5)"
                    ControlToValidate="txtPxVente" Type="Double" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnEnregistrer" runat="server" Text="Sauvegarder" OnClick="btnEnregistrer_Click"
                    CssClass="btn btn-primary" />
            </td>
            <td>
                <asp:Label ID="lblResultatSauvegarde" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
            <td></td>
        </tr>
    </table>
</asp:Content>
