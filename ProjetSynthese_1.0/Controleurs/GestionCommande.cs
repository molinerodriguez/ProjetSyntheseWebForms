﻿using System;
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
            int numArticle = int.Parse(frm.TxtNum.Text);
            double prix= double.Parse(frm.TxtPrix.Text);
            int quantite = int.Parse(frm.TxtQuantite.Text);
            Commande cmd = frm.Session["commande"] as Commande;

            LigneCommande ligne = RechercherLigneCommande(numArticle, cmd.LigneCommandes);
            if (ligne==null)
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

        }

        //Rechercher une ligne de commande dans la commande en cours
        private static LigneCommande RechercherLigneCommande(int numArticle, ICollection<LigneCommande> ligneCommande)
        {
            LigneCommande ligne = null;
            IEnumerable<LigneCommande> result = from l in ligneCommande
                                                where l.numArticle == numArticle
                                                select l;
            if (result.Count()>0)
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
                //Erreur systeme grave!!!!!!
            }
        }

        //Enregistrer une commande
        public static void EnregisterCommande(NouvelleCommande frm)
        {
            //L'utilisateur en cours
            Utilisateur utilisateur= frm.Session["utilisateur"] as Utilisateur;

            //Mon fammeux objet commande
            Commande cmd = frm.Session["commande"] as Commande;

            //Recuperer le fournisseur
            Fournisseur fournisseur = GestionFournisseur.Rechercher(frm.CmbFournisseur.SelectedValue);
            
            //Completion de l'objet commande
            cmd.numFournisseur = fournisseur.numFournisseur;
            cmd.dateCommande = frm.CalDateCommande.SelectedDate;
            cmd.nomUtilisateur = utilisateur.nomUtilisateur;
            //cmd.Fournisseur = fournisseur;

            using (var sim = new SIM_Context())
            {
                //Sauvegarde de la commande
                cmd =sim.Commandes.Add(cmd);
                int result = sim.SaveChanges();

                //Affichage numero commande
                frm.TxtNumCommande.Text = cmd.numCommande.ToString();

                //Mise à jour du grid
                frm.GridViewCommande.DataSource = cmd.LigneCommandes;
                frm.GridViewCommande.DataBind();

                frm.BtnEnregistrer.Enabled = false;
                frm.Session["commande"] = null;
                //Message de confirmation : La commande a été sauvegardée avec succes
            }

        }
    }
}