<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjetSynthese_1._0.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
   
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUserName" runat="server" Text="Nom d'utilisateur "/><asp:TextBox ID="txtUser" runat="server"/><br/>
        <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe "/><asp:TextBox ID="txtPass" runat="server"/><br/> 
        <asp:Button ID="btnSeconnecter" runat="server" Text="Se connecter" OnClick="btnSeconnecter_Click"/>


    </div>
    </form>
</body>
</html>
