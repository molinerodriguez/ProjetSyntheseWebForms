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
    }
}