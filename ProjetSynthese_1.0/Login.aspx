<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjetSynthese_1._0.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title>Authentification</title>
</head>
<body>
    <div class="container" style="margin-top: 5%;">
        <div class="col-md-4 col-md-offset-4">
            <div class="panel panel-primary">
                <div class="panel-heading h3 text-center">Authentification</div>
                <div class="panel-body">

                    <!-- Login Form -->
                    <form role="form" runat="server">

                        <!-- Champ Utililsateur -->
                        <div class="row">
                            <div class="form-group col-xs-12">
                                <label><span class="text-danger" style="margin-right: 5px;">*</span>Nom utilisateur:</label>
                                <div class="input-group">
                                    <asp:TextBox ID="txtUser" runat="server" type="text" Text="Dan" class="form-control" placeholder="obligatoire" />
                                    <span class="input-group-btn">
                                        <label class="btn btn-primary"><span class="glyphicon glyphicon-user" aria-hidden="true"></span></label>
                                    </span>
                                </div>
                            </div>
                        </div>

                        <!-- Champ contenue -->
                        <div class="row">
                            <div class="form-group col-xs-12">
                                <label><span class="text-danger" style="margin-right: 5px;">*</span>Mot de passe:</label>
                                <div class="input-group">
                                    <asp:TextBox ID="txtPass" runat="server" type="password" Text="Roman" class="form-control" placeholder="obligatoire" />
                                    <span class="input-group-btn">
                                        <label class="btn btn-primary"><span class="glyphicon glyphicon-lock" aria-hidden="true"></span></label>
                                    </span>
                                </div>
                            </div>
                        </div>

                        <!-- Boutton Login -->
                        <div class="row">
                            <div class="form-group col-xs-12">
                                <%--<button class="btn btn-primary" type="submit">Submit</button>--%>
                                <asp:Button ID="btnSeconnecter" runat="server" Text="Connexion" OnClick="btnSeconnecter_Click" class="btn btn-primary btn-block" />
                            </div>
                        </div>

                        <!-- Controlleurs Form-->
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nom d'utilisateur obligatoire"
                            ControlToValidate="txtUser" ForeColor="Red"></asp:RequiredFieldValidator><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Mot de passe obligatoire"
                            ControlToValidate="txtPass" ForeColor="Red"></asp:RequiredFieldValidator><br />
                        <asp:Label ID="lblResultatLogin" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </form>
                    <!-- Fin Form -->
                </div>
            </div>
        </div>
    </div>


</body>
</html>
