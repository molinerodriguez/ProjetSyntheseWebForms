<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjetSynthese_1._0.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>


    <div class="container">
        <div class="row">
            <div class="col-md-offset-4 col-md-4 col-sm-offset-3 col-sm-6 well">
                <div class="h4 text-center">Bienvenue</div>
                <hr />
                <form class="form-horizontal" id="form1" runat="server">
                    <div class="form-group">
                        <div class="col-sm-12">
                            <%--<input type="email" class="form-control" id="email" placeholder="nom utilisateur">--%>
                            <asp:TextBox ID="txtUser" runat="server" type="text" class="form-control" placeholder="nom utilisateur" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <asp:TextBox ID="txtPass" runat="server" type="password" class="form-control" placeholder="mot de passe"/>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <asp:Button ID="btnSeconnecter" runat="server" Text="Se connecter" OnClick="btnSeconnecter_Click" class="btn btn-default btn-block" />
                        </div>
                    </div>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=">> nom d'utilisateur obligatoire" 
                        ControlToValidate="txtUser" ForeColor="Red"></asp:RequiredFieldValidator><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=">> mot de passe obligatoire"
                        ControlToValidate="txtPass" ForeColor="Red"></asp:RequiredFieldValidator><br />
                    <asp:Label ID="lblResultatLogin" runat="server" Text="" ForeColor="Red"></asp:Label>
                </form>

            </div>
        </div>
    </div>

    <%--    
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserName" runat="server" Text="Nom d'utilisateur " /><asp:TextBox ID="txtUser" runat="server" /><br />
            <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe " /><asp:TextBox ID="txtPass" runat="server" /><br />
            <asp:Button ID="btnSeconnecter" runat="server" Text="Se connecter" OnClick="btnSeconnecter_Click" />


        </div>
    </form>
    --%>
</body>
</html>
