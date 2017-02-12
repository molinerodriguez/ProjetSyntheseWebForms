using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetSynthese_1._0.Modeles;
using ProjetSynthese_1._0.Controleurs;
using System.Web.UI.WebControls;

namespace ProjetSynthese_1._0.Controleurs
{
    public class GestionArticle
    {
        //Enregistrer un nouvel article
        public static void Enregister(NouvelArticle frmArticle)
        {
            //TextBox nom = frmArticle.FindControl("txtNom") as TextBox;
            TextBox nom = frmArticle.TxtNom;
            //TextBox description = frmArticle.FindControl("txtDescription") as TextBox;
            TextBox description = frmArticle.TxtDescription;

            if (Rechercher(description: description.Text, nom: nom.Text) == null)
            {
                //TextBox categorie = frmArticle.FindControl("txtCategorie") as TextBox;
                TextBox categorie = frmArticle.TxtCategorie;
                //TextBox pxAchat = frmArticle.FindControl("txtPxAchat") as TextBox;
                TextBox pxAchat = frmArticle.TxtPxAchat;
                //TextBox pxVente = frmArticle.FindControl("txtPxVente") as TextBox;
                TextBox pxVente = frmArticle.TxtPxVente;

                using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
                {
                    try
                    {
                        Article article = sim.Articles.Add(new Article
                        {
                            nom = nom.Text,
                            description = description.Text,
                            categorie = categorie.Text,
                            prixAchat = double.Parse(pxAchat.Text),
                            prixVente = double.Parse(pxVente.Text)
                        });
                        int n = sim.SaveChanges();//Procedure stockee à intégrer ...
                        frmArticle.TxtNum.Text = article.numArticle.ToString();

                        //Ajouter aussi un message de confirmation
                        frmArticle.LblResultatNouvelArticle.Text = "L'article a été enregistrer avec succes!";

                    }
                    catch (Exception)
                    {
                        //Affiche message si prix n'Est pas un nombre
                        frmArticle.LblResultatNouvelArticle.Text = "Prix d'achat et de vente en nombre seulement";
                    }
                }
            }
            else
            {
                frmArticle.LblResultatNouvelArticle.Text = "Attention! L'article existe déjà!";
            }
        }

        //Rechercher un article par nom et par description
        private static Article Rechercher(string nom, string description)
        {
            Article article = null;
            using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
            {
                IEnumerable<Article> result = from a in sim.Articles
                                              where a.nom == nom && a.description == description
                                              select a;

                if (result.Count() > 0)
                {
                    article = result.First();
                }
            }
            return article;
        }

        //Rechercher un article par numero article
        public static Article Rechercher(int numArticle)
        {
            Article article = null;
            var sim = new SIM_Context();
            IEnumerable<Article> result = from a in sim.Articles
                                          where a.numArticle == numArticle
                                          select a;

            if (result.Count() > 0)
            {
                article = result.First();
            }
            return article;
        }

        //Rechercher un article par nom
        private static List<Article> Rechercher(string nom)
        {
            List<Article> listArticle = null;
            using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
            {
                IEnumerable<Article> result = from a in sim.Articles
                                              where a.nom == nom
                                              select a;
                if (result.Count() > 0)
                {
                    listArticle = result.ToList();
                }
            }

            return listArticle;
        }


        //Lister articles dans le fenetre d'article
        public static void ListerArticles(RechercherArticle frmArticle)
        {
            if (!frmArticle.TxtNom.Text.Equals(""))
            {
                frmArticle.GridArticles.DataSource = Rechercher(frmArticle.TxtNom.Text);
                frmArticle.GridArticles.DataBind();
            }
        }

        //Lister articles dans le fenetre de commande
        public static void ListerArticles(NouvelleCommande frm)
        {
            if (!frm.TxtArticle.Text.Equals(""))
            {
                if ((frm.GridArticles.DataSource = Rechercher(frm.TxtArticle.Text)) != null)
                {
                    frm.GridArticles.DataBind();
                    frm.BtnAjouter.Enabled = true;
                }
            }
        }

        //Lister articles dans le fenetre de bon de distribution
        public static void ListerArticles(NouvelleBonDistribution frm)
        {
            if (!frm.TxtArticle.Text.Equals(""))
            {
                if ((frm.GridArticles.DataSource = Rechercher(frm.TxtArticle.Text)) != null)
                {
                    frm.GridArticles.DataBind();
                }
            }
        }

        public static void Modifier(ModifierArticle frmArticle)
        {
            TextBox nom = frmArticle.TxtNom;
            TextBox description = frmArticle.TxtDescription;
            int num = int.Parse(frmArticle.TxtNum.Text);
            using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
            {
                try
                {
                    Article article;
                    //Verifier l'existence de l'article
                    if ((article = sim.Articles.Find(num)) != null)
                    {
                        //Modification de l'article
                        article.nom = frmArticle.TxtNom.Text;
                        article.description = frmArticle.TxtDescription.Text;
                        article.categorie = frmArticle.TxtCategorie.Text;
                        article.prixAchat = double.Parse(frmArticle.TxtPxAchat.Text);
                        article.prixVente = double.Parse(frmArticle.TxtPxVente.Text);

                        //Sauvegarde de l'article
                        sim.SaveChanges();

                        //Affichage de la mise à jour de la liste.
                        frmArticle.LblResultatModificationArticle.Text = "Article modifié avec succes!";
                        //frmArticle.Server.Transfer("RechercherArticle.aspx");
                    }
                }
                catch (Exception)
                {

                    frmArticle.LblResultatModificationArticle.Text = "Les prix d'achat et de ventes nombre seulement!";

                }
            }

        }

        //Afficher un article dans le fourmulaire nouvelle commande
        public static void Afficher(NouvelleCommande frm)
        {
            GridViewRow myRow = frm.GridArticles.SelectedRow;
            frm.TxtNum.Text = myRow.Cells[1].Text;
            frm.TxtNom.Text = myRow.Cells[2].Text;
            frm.TxtPrix.Text = myRow.Cells[5].Text;
        }

        //Afficher un article dans le fourmulaire nouvelle commande
        public static void Afficher(NouvelleBonDistribution frm)
        {
            GridViewRow myRow = frm.GridArticles.SelectedRow;
            frm.TxtNumArticle.Text = myRow.Cells[1].Text;
            frm.TxtNom.Text = myRow.Cells[2].Text;
        }
    }
}