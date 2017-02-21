using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetSynthese_1._0.Modeles;

namespace ProjetSynthese_1._0.Controleurs
{
    public class GestionCommande
    {
        //Initialiser la commande
        public static void InitialiserCommande(NouvelleCommande frm)
        {
            Commande commande = new Commande();
            //commande.LigneCommandes = new List<LigneCommande>();
            frm.Session["commande"] = commande;
            //frm.GridViewCommande.DataSource = commande.LigneCommandes;
            //frm.GridViewCommande.DataBind();
        }

        //Ajouter un article à la commande
        public static void Ajouter(NouvelleCommande frm)
        {
            try
            {
                int numArticle = int.Parse(frm.TxtNum.Text);
                double prix = double.Parse(frm.TxtPrix.Text);
                int quantite = int.Parse(frm.TxtQuantite.Text);
                Commande cmd = frm.Session["commande"] as Commande;

                LigneCommande ligne = RechercherLigneCommande(numArticle, cmd.LigneCommandes);
                if (ligne == null)
                {
                    ligne = new LigneCommande
                    {
                        numArticle = numArticle,
                        quantite = quantite,
                        prix = prix
                    };
                    cmd.LigneCommandes.Add(ligne);
                    cmd.montant += prix * quantite;
                    frm.TxtMontant.Text = cmd.montant.ToString();
                }
                else
                {
                    ligne.quantite += quantite;
                    cmd.montant += prix * quantite;
                    frm.TxtMontant.Text = cmd.montant.ToString();
                }
                frm.GridViewCommande.DataSource = cmd.LigneCommandes;
                frm.GridViewCommande.DataBind();

                frm.TxtNum.Text = "";
                frm.TxtNom.Text = "";
                frm.TxtPrix.Text = "";
                frm.TxtQuantite.Text = "";
                frm.BtnAjouter.Enabled = false;
                frm.BtnEnregistrer.Enabled = true;
                frm.LblResultatTxtQuantite.Text = "";
            }
            catch (Exception e)
            {
                frm.LblResultatTxtQuantite.Text = "En nombre seulement";
            }

        }


        //Rechercher une ligne de commande dans la commande en cours
        private static LigneCommande RechercherLigneCommande(int numArticle, ICollection<LigneCommande> ligneCommande)
        {
            LigneCommande ligne = null;
            IEnumerable<LigneCommande> result = from l in ligneCommande
                                                where l.numArticle == numArticle
                                                select l;
            if (result.Count() > 0)
            {
                ligne = result.Single();
            }
            return ligne;
        }

        //Supprimer une ligne de commande
        public static void supprimmerLigne(NouvelleCommande frm, int numArticle)
        {
            Commande cmd = frm.Session["commande"] as Commande;

            LigneCommande ligne = RechercherLigneCommande(numArticle, cmd.LigneCommandes);
            if (ligne != null)
            {
                //Mise à jour du montant dans la fenetre
                cmd.montant -= ligne.prix * ligne.quantite;
                frm.TxtMontant.Text = cmd.montant.ToString();

                //Suppression de la ligne
                cmd.LigneCommandes.Remove(ligne);

                //Mise à jour du grid
                frm.GridViewCommande.DataSource = cmd.LigneCommandes;
                frm.GridViewCommande.DataBind();

            }
            else
            {
                //Erreur systeme grave!!!!!!  à ne pas traiter dans la page
            }
        }

        //Enregistrer une commande
        public static void EnregisterCommande(NouvelleCommande frm)
        {
            //L'utilisateur en cours
            Utilisateur utilisateur = frm.Session["utilisateur"] as Utilisateur;

            //Mon fammeux objet commande
            Commande cmd = frm.Session["commande"] as Commande;

            //Recuperer le fournisseur
            Fournisseur fournisseur = GestionFournisseur.Rechercher(frm.CmbFournisseur.SelectedValue);

            //Completion de l'objet commande
            cmd.numFournisseur = fournisseur.numFournisseur;
            cmd.dateCommande = DateTime.Now;
            cmd.nomUtilisateur = utilisateur.nomUtilisateur;
            //cmd.Fournisseur = fournisseur;

            using (var sim = new SIM_Context())
            {
                //Sauvegarde de la commande
                cmd = sim.Commandes.Add(cmd);
                int result = sim.SaveChanges();

                //Affichage numero commande
                frm.TxtNumCommande.Text = cmd.numCommande.ToString();

                //Mise à jour du grid
                frm.GridViewCommande.DataSource = cmd.LigneCommandes;
                frm.GridViewCommande.DataBind();

                frm.BtnEnregistrer.Enabled = false;
                frm.Session.Remove("commande");
                frm.LblResultatEnregistrer.Text = "Nouvelle commande enregistré avec succes!";
                //Message de confirmation : La commande a été sauvegardée avec succes
            }

        }

        //Rechercher une commande
        public static Commande RechercherCommande(int numCommande)
        {
            Commande commande = null;

            var sim = new SIM_Context();//Il faut absolument implementer L'interface IClonable pour toutes les entites

            IEnumerable<Commande> result = from c in sim.Commandes
                                           where c.numCommande == numCommande
                                           select c;
            if (result.Count() > 0)
            {
                commande = result.Single();
            }

            return commande;
        }

        //Rechercher et afficher une commande
        public static void RechercherCommande(RecevoirCommande frm)
        {
            //Numero de la commande à rechercher
            int numCommande = int.Parse(frm.TxtNumeroCommande.Text);

            Commande commande = RechercherCommande(numCommande);

            if (commande != null)
            {
                //Sauvegarde temporaire du num de la commande
                frm.Session["numCommande"] = commande.numCommande;

                //Affichage du fournisseur
                frm.TxtFournisseur.Text = "Nom :" + commande.Fournisseur.nom +
                                          " Adresse :" + commande.Fournisseur.adresse +
                                          " Telephone :" + commande.Fournisseur.telephone;

                //Affichage du montant et de la date
                frm.TxtMontant.Text = commande.montant.ToString();
                frm.TxtDate.Text = commande.dateCommande.ToShortDateString();

                //Affichage des lignes de commande
                frm.GridLignesCommande.DataSource = commande.LigneCommandes;
                frm.GridLignesCommande.DataBind();

                //Activation des boutons
                frm.BtnRecevoir.Enabled = true;
                frm.BtnImprimer.Enabled = true;
            }
            else
            {
                //Message : Cette commande n'existe pas!
            }
        }

        //Recevoir une commande
        public static void RecevoirCommande(RecevoirCommande frm)
        {
            //Recuperation du numero de commande
            int numCommande = int.Parse(frm.Session["numCommande"].ToString());

            using (var sim = new SIM_Context())
            {
                //Recuperation de l'objet commande
                Commande commande = sim.Commandes.Find(numCommande);

                if (commande != null)
                {
                    foreach (LigneCommande l in commande.LigneCommandes)
                    {
                        //Selectionner l'article
                        Article article = l.Article;

                        //Selectionner le StockCentral lié à l'article
                        StockCentral stockCentral = sim.StockCentrals.Find(article.numArticle);

                        if (stockCentral != null)//L'article est deja en stock
                        {
                            //Mise à jour de la quantite en stock
                            stockCentral.qte += l.quantite;
                        }
                        else
                        {
                            //Premiere commande pour cet article
                            sim.StockCentrals.Add(
                                new StockCentral
                                {
                                    numArticle = article.numArticle,
                                    qte = l.quantite,
                                    qteCritique = 0
                                }
                                );
                        }
                    }

                    int result = sim.SaveChanges();
                    frm.Session.Remove("numCommande");
                    frm.LblResultatRecevoir.Text = "La commande a été reçu avec succes!";
                    frm.BtnRecevoir.Enabled = false;
                    frm.BtnImprimer.Enabled = false;

                    //Message de confirmation: La réception de la commande a été faite avec succes et les stocks ont été mis à jour!. 
                }

            }
        }
    }
}