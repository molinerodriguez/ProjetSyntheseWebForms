using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Modeles;
using System.Web.UI.HtmlControls;

namespace ProjetSynthese_1._0.Controleurs
{
    public class GestionUtilisateur
    {
        //Authentifier un utilisateur
        public static void SeConnecter(Login log)
        {
            TextBox txtUser = log.FindControl("txtUser") as TextBox;
            TextBox txtPass = log.FindControl("txtPass") as TextBox;

            try
            {
                Utilisateur utilisateur = Rechercher(txtUser.Text, txtPass.Text);

                if (utilisateur != null)
                {
                    log.Session["utilisateur"] = utilisateur;
                    log.Server.Transfer("Accueil.aspx");
                }
                else
                {
                    (log.FindControl("lblResultatLogin") as Label).Text = "Authentification invalide";

                }
            }
            catch (Exception ex)
            {
                (log.FindControl("lblResultatLogin") as Label).Text = "Erreure: <br>" + ex;

            }

        }

        public static void SeDeconnecter(SiteMaster master)
        {
            master.Session.Remove("utilisateur");
            master.Server.Transfer("~/Accueil.aspx");
        }




        //Rechercher un utilisateur
        private static Utilisateur Rechercher(string user, string pass)//Exception à propager ici
        {
            Utilisateur utilisateur = null;
            using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
            {
                var result = from u in sim.Utilisateurs
                             where u.nomUtilisateur == user && u.motDePasse == pass
                             select u;

                if (result.Count() > 0)
                {
                    utilisateur = result.Single();
                }
            }

            return utilisateur;
        }

        //Definir le menu approprié aux utilisateurs
        public static void SetupEspaceTravail(SiteMaster master)
        {
            Utilisateur user = master.Session["utilisateur"] as Utilisateur;
            if (user != null)
            {
                (master.FindControl("btnUtilisateur") as Button).Text = "Utilisateur: " + user.nomUtilisateur;
                (master.FindControl("btnDeconnexion") as Button).Text = "Deconnexion!";
                (master.FindControl("btnDeconnexion") as Button).Visible = true;



                if (user.type == "admin")//Gestionnaire ou directeur
                {
                    //https://www.youtube.com/watch?v=xvrr-gZ2UJQ
                    //Menus
                    Menu menu = master.FindControl("menuPrincipale") as Menu;


                    menu.Items.Add(new MenuItem("Article"));
                    menu.Items.Add(new MenuItem("Fournisseur"));
                    menu.Items.Add(new MenuItem("Commande"));
                    menu.Items.Add(new MenuItem("Distribution"));
                    menu.Items.Add(new MenuItem("Rapports"));
                    //Sous menus
                    #region article
                    menu.Items[0].ChildItems.Add(new MenuItem("Nouvel article"));
                    menu.Items[0].ChildItems[0].NavigateUrl = "~/NouvelArticle.aspx";

                    menu.Items[0].ChildItems.Add(new MenuItem("Rechercher article"));
                    menu.Items[0].ChildItems[1].NavigateUrl = "~/RechercherArticle.aspx";

                    menu.Items[0].ChildItems.Add(new MenuItem("Fixer qte critique"));
                    menu.Items[0].ChildItems[2].NavigateUrl = "#";
                    #endregion



                    #region fournisseur
                    menu.Items[1].ChildItems.Add(new MenuItem("Nouveau fournisseur"));
                    menu.Items[1].ChildItems[0].NavigateUrl = "~/NouveauFournisseur.aspx";

                    menu.Items[1].ChildItems.Add(new MenuItem("Rechercher fournisseur"));
                    menu.Items[1].ChildItems[1].NavigateUrl = "#";
                    //menu.Items[1].ChildItems[1].NavigateUrl = "~/RechercherFournisseur.aspx";

                    #endregion

                    #region commande
                    menu.Items[2].ChildItems.Add(new MenuItem("Placer commande"));
                    menu.Items[2].ChildItems[0].NavigateUrl = "~/NouvelleCommande.aspx";

                    menu.Items[2].ChildItems.Add(new MenuItem("Recevoir commande"));
                    menu.Items[2].ChildItems[1].NavigateUrl = "~/RecevoirCommande.aspx";

                    menu.Items[2].ChildItems.Add(new MenuItem("Modifier commande"));
                    menu.Items[2].ChildItems[2].NavigateUrl = "#";
                    #endregion

                    #region Bon de distribution
                    menu.Items[3].ChildItems.Add(new MenuItem("Nouveau bon de distribution"));
                    menu.Items[3].ChildItems[0].NavigateUrl = "~/NouvelleBonDistribution.aspx";

                    menu.Items[3].ChildItems.Add(new MenuItem("Modifier bon de distribution"));
                    menu.Items[3].ChildItems[1].NavigateUrl = "#";
                    #endregion
                }
                if (user.type == "caissier")
                {
                    //Menus
                    Menu menu = master.FindControl("menuPrincipale") as Menu;
                    menu.Items.Add(new MenuItem("Article"));
                    menu.Items.Add(new MenuItem("Vente"));
                    menu.Items.Add(new MenuItem("Distribution"));
                    menu.Items.Add(new MenuItem("Rapports"));
                    //Sous menus
                }
            }
        }
    }
}