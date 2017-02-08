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

            if (Rechercher(description: description.Text, nom: nom.Text)==null)
            {
                //TextBox categorie = frmArticle.FindControl("txtCategorie") as TextBox;
                TextBox categorie = frmArticle.TxtCategorie;
                //TextBox pxAchat = frmArticle.FindControl("txtPxAchat") as TextBox;
                TextBox pxAchat = frmArticle.TxtPxAchat;
                //TextBox pxVente = frmArticle.FindControl("txtPxVente") as TextBox;
                TextBox pxVente = frmArticle.TxtPxVente;

                using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
                {
                    Article article=sim.Articles.Add(new Article
                    {
                        nom = nom.Text,
                        description = description.Text,
                        categorie = categorie.Text,
                        prixAchat = double.Parse(pxAchat.Text),
                        prixVente = double.Parse(pxVente.Text)
                    });
                    int n = sim.SaveChanges();//Procedure stockee à intégrer ...
                    frmArticle.TxtNum.Text = article.numArticle.ToString();
                    int b = 1;
                    //Ajouter aussi un message de confirmation
                }
            }
            else
            {
                //Afficher Article existe déjà
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

        //Rechercher un article par numéro
        //private static Article Rechercher(int num)
        //{
        //    Article article = null;
        //    var sim = SIM_Context.getInstance();
        //    IEnumerable<Article> result = from a in sim.Articles
        //                                  where a.numArticle==num
        //                                  select a;
        //    if (result.Count() > 0)
        //    {
        //        article = result.First();
        //    }
        //    return article;
        //}
        private void Test() { }

        public static void ListerArticles(RechercherArticle frmArticle)
        {
            if (!frmArticle.TxtNom.Text.Equals(""))
            {
                using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
                {
                    IEnumerable<Article> articles = from a in sim.Articles
                                                    where a.nom==frmArticle.TxtNom.Text
                                                    select a;

                    frmArticle.GridArticles.DataSource = articles.ToList();
                    frmArticle.GridArticles.DataBind();
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
                    //frmArticle.Server.Transfer("RechercherArticle.aspx");
                }
            }
            
        }
    }
}