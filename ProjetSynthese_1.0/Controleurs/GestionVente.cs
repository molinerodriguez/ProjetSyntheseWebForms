using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetSynthese_1._0.Modeles;

namespace ProjetSynthese_1._0.Controleurs
{
    public class GestionVente
    {
        //Initialiser la vente
        public static void InitialiserVente(NouvelleVente frm)
        {
            
            Utilisateur user = frm.Session["utilisateur"] as Utilisateur;

            Vente vente = new Vente();
            vente.numFiliale = user.numFiliale;
            vente.nomUtilisateur = user.nomUtilisateur;

            frm.Session["vente"] = vente;
        }

        //Ajouter une ligne vente dans la vente encours
        public static void Ajouter(NouvelleVente frm)
        {
            int numArticle = int.Parse(frm.TxtNumArticle.Text);
            int quantite = int.Parse(frm.TxtQuantite.Text);
            float prixVente = float.Parse(frm.TxtPrixVente.Text);
            Utilisateur user = frm.Session["utilisateur"] as Utilisateur;
            Vente vente = frm.Session["vente"] as Vente;

            int qteStock = GetQuantiteEnStock(numArticle, user.numFiliale);
            if ( qteStock > 0 && qteStock >= quantite)
            {
                //Récuperer une ligne vente encours
                LigneVente ligne = RechercherLigneVente(numArticle, vente.LigneVentes);

                if (ligne == null)
                {
                    vente.LigneVentes.Add(
                        new LigneVente
                        {
                            numArticle = numArticle,
                            quantite = quantite,
                            prix = prixVente
                        }
                        );

                    vente.montant += prixVente * quantite;
                    frm.TxtMontant.Text = vente.montant.ToString();
                }
                else
                {
                    ligne.quantite += quantite;
                    vente.montant += prixVente * quantite;
                    frm.TxtMontant.Text = vente.montant.ToString();
                }

                frm.GridLigneVente.DataSource = vente.LigneVentes;
                frm.GridLigneVente.DataBind();
            }
            else
            {
                //Message : Qte en stock 
            }
            
        }

        //Rechercher une ligne de vente dans la vente encours
        private static LigneVente RechercherLigneVente(int numArt, ICollection<LigneVente> ligneVente)
        {
            LigneVente ligne = null;

            IEnumerable<LigneVente> result = from l in ligneVente
                                             where l.numArticle == numArt
                                             select l;
            if (result.Count()>0)
            {
                ligne = result.Single();
            }

            return ligne;
        }

        //Qte en stock d'un article dans une filiale
        private static int GetQuantiteEnStock(int numArt, int numFiliale)
        {
            int qte = -1;
            using (var sim = new SIM_Context())
            {
                var result = from s in sim.Stocks
                             where s.numFiliale == numFiliale && s.numArticle == numArt
                             select s;
                if (result.Count() > 0)
                {
                    qte = result.Single().qteEnStock;
                }
            }
            return qte;
        }

        //Valider une vente
        public static void ValiderVente(NouvelleVente frm)
        {
            try
            {
                Utilisateur user = frm.Session["utilisateur"] as Utilisateur;
                Vente vente = frm.Session["vente"] as Vente;
                string sms = "Commande en urgence pour les articles suivants : ";
                bool temoinMsg = false;

                using (var sim = new SIM_Context())
                {
                    foreach (LigneVente l in vente.LigneVentes)
                    {
                        //Mise à jour de la quantite en stock
                        //Stock stock = sim.Stocks.Find(new object[] { l.numArticle, user.numFiliale});//Douteux?
                        Stock stock = (from s in sim.Stocks
                                       where s.numArticle == l.numArticle &&
                                       s.numFiliale == user.numFiliale
                                       select s
                                       ).Single();
                        stock.qteEnStock -= l.quantite;
                        if (stock.qteEnStock == stock.qteMoyenneMin)
                        {
                            sms +="("+stock.numArticle+","+stock.Article.nom+") ";
                            temoinMsg = true;
                        }
                    }

                    vente.dateVente = DateTime.Now;
                    vente = sim.Ventes.Add(vente);
                    int ok = sim.SaveChanges();
                    frm.TxtNumVente.Text = vente.numVente.ToString();
                    frm.TxtDateVente.Text = vente.dateVente.ToShortDateString();
                    
                    //Notification
                    if (true)
                    {
                        Sms.SendSms("Test");
                    }
                    //Message: La vente a été éffectuée avec succès
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}