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
            try
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
                            frm.LblResultatEnregistrer.Text = "";
                            frm.LblResultatTxtQuantite.Text = "Article a été ajouté dans la liste bon distribution";
                        }
                        else
                        {
                            //Message: Quantite insufisante, la quantite en etock est : stockCentral.qte
                            frm.LblResultatTxtQuantite.Text = "Quantite insufisante! La quantite en etock est : " + stockCentral.qte;
                        }
                    }
                    else
                    {
                        //Message: Cet article n'est pas en stock, Veuillez commander SVP!
                        frm.LblResultatTxtQuantite.Text = "Cet article n'est pas en stock, Veuillez commander SVP!";
                    }
                }


            }
            catch (Exception e)
            {
                frm.LblResultatTxtQuantite.Text = "Champ oblitatoire et en numérique!";
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

        public static void Enregistrer(NouvelleBonDistribution frm)
        {
            //L'utilisateur en cours
            Utilisateur utilisateur = frm.Session["utilisateur"] as Utilisateur;

            //Mon fammeux objet bon distribution
            BonDistribution  bnd = frm.Session["bonDistribution"] as BonDistribution;

            //Recuperer la filiale
            Filiale filiale = GestionFiliale.Rechercher(frm.CmbFiliale.SelectedValue);

            //Completion de l'objet bondistribution
            bnd.numFiliale = filiale.numFiliale;
            bnd.dateBonDistribution = DateTime.Now;
            bnd.nomUtilisateur = utilisateur.nomUtilisateur;
            //bnd.Filiale = filiale;
            bnd.NotificationBonDistributions.Add(
                new NotificationBonDistribution
                {
                    message = "Un bon de distribution vous a été envoyé",
                    dateNotification = DateTime.Now,
                    etat = "0"//0: Nom, lu  1: Lu
                }
                );

            using (var sim = new SIM_Context())
            {
                //Mise à jour de la quantite du stock centrale pour chaque article distribué
                foreach (LigneBonDistribution l in bnd.LigneBonDistributions)
                {
                    sim.Articles.Find(l.numArticle).StockCentral.qte -= l.quantite;
                }

                //Sauvegarde du bon de distribution
                bnd = sim.BonDistributions.Add(bnd);
                int result = sim.SaveChanges();

                //Affichage numero bon de distribution
                frm.TxtNumBonDistribution.Text = bnd.numBonDistribution.ToString();

                //Mise à jour du grid
                frm.GridViewDistribution.DataSource = bnd.LigneBonDistributions;
                frm.GridViewDistribution.DataBind();

                frm.BtnEnregistrer.Enabled = false;
                frm.Session.Remove("bonDistribution");
                frm.LblResultatEnregistrer.Text = "Bon de distribution enregistré avec succes!";
                frm.LblResultatTxtQuantite.Text = "";
                //Message de confirmation : Le bon de distribution a été sauvegardé avec succès!
            }
        }
    }
}