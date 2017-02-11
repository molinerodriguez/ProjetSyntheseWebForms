<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NouveauFournisseur.aspx.cs" Inherits="ProjetSynthese_1._0.NouveauFournisseur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="h3 text-primary">Nouveau fournisseur</div>

    <table class="table table-hover">
        <tr>
            <td>
                <asp:Label ID="lblNumFournisseur" runat="server" Text="Numero"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNum" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
            </td>
            <td>
<%--                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Champ obligatoire"
                    ControlToValidate="txtNum" ForeColor="Red" ></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblNomFournisseur" runat="server" Text="Nom "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNom" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Champ obligatoire"
                    ControlToValidate="txtNom" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAdresse" runat="server" Text="Adresse "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAdresse" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Champ obligatoire"
                    ControlToValidate="txtAdresse" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTelephone" runat="server" Text="Téléphone "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTelephone" runat="server" CssClass="form-control"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Champ obligatoire"
                    ControlToValidate="txtTelephone" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEnregistrer" runat="server" Text="Enregistrer" OnClick="btnEnregistrer_Click" CssClass="btn btn-primary btn-block"/>
            </td>
            <td>
                <asp:Label ID="lblResultatNouveauFournisseur" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
