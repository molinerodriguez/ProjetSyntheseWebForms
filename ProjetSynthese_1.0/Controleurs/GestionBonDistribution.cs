using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetSynthese_1._0.Modeles;

namespace ProjetSynthese_1._0.Controleurs
{
    public class GestionBonDistribution
    {
        //Initilatisation du bon de distribution
        public static void InitialiserBon(NouvelleBonDistribution frm)
        {
            BonDistribution bonDistribution = new BonDistribution();
            frm.Session["bonDistribution"] = bonDistribution;
        }

        //Ajout d'une ligne de bon de distribution
        public static void Ajouter(NouvelleBonDistribution frm)
        {
            int numArticle = int.Parse(frm.TxtNumArticle.Text);
            int quantite = int.Parse(frm.TxtQuantite.Text);
            //Avant d'aller plus loin, verifier si l'article est en stock ou possede la qte demandée
            Article article = GestionArticle.Rechercher(numArticle);
            if (article != null)
            {
                StockCentral stockCentral = article.StockCentral;
                if (stockCentral != null)
                {
                    if (stockCentral.qte >= quantite)
                    {
                        BonDistribution bonDistribution = frm.Session["bonDistribution"] as BonDistribution;
                        LigneBonDistribution ligne = RechercherLigneBonDistribution(numArticle, bonDistribution.LigneBonDistributions);
                        if (ligne == null)
                        {
                            ligne = new LigneBonDistribution
                            {
                                numArticle = numArticle,
                                quantite = quantite,
                                //Article=article
                            };
                            bonDistribution.LigneBonDistributions.Add(ligne);
                        }
                        else
                        {
                            ligne.quantite += quantite;
                        }

                        frm.GridViewDistribution.DataSource = bonDistribution.LigneBonDistributions;
                        frm.GridViewDistribution.DataBind();

                        frm.TxtNumArticle.Text = "";
                        frm.TxtNom.Text = "";
                        frm.TxtQuantite.Text = "";
                    }
                    else
                    {
                        //Message: Quantite insufisante, la quantite en etock est : stockCentral.qte
                    }
                }
                else
                {
                    //Message: Cet article n'est pas en stock, Veuillez commander SVP!
                }
            }

        }

        //Rechercher une ligne de Bon de Distribution dans le Bon de Distribution en cours
        private static LigneBonDistribution RechercherLigneBonDistribution(int numArticle, ICollection<LigneBonDistribution> ligneBonDistribution)
        {
            LigneBonDistribution ligne = null;
            IEnumerable<LigneBonDistribution> result = from l in ligneBonDistribution
                                                       where l.numArticle == numArticle
                                                       select l;
            if (result.Count() > 0)
            {
                ligne = result.Single();
            }
            return ligne;
        }

        //Supprimer une ligne du bon de distribution
        public static void supprimmerLigne(NouvelleBonDistribution frm, int numArticle)
        {
           BonDistribution bonDistribution = frm.Session["bonDistribution"] as BonDistribution;

            LigneBonDistribution ligne = RechercherLigneBonDistribution(numArticle, bonDistribution.LigneBonDistributions);
            if (ligne != null)
            {

                //Suppression de la ligne
                bonDistribution.LigneBonDistributions.Remove(ligne);

                //Mise à jour du grid
                frm.GridViewDistribution.DataSource = bonDistribution.LigneBonDistributions;
                frm.GridViewDistribution.DataBind();

            }
            else
            {
                //Erreur systeme grave!!!!!!  à ne pas traiter dans la page
            }
        }
    }
}