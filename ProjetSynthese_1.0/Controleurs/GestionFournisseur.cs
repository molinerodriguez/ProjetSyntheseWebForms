using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetSynthese_1._0.Modeles;

namespace ProjetSynthese_1._0.Controleurs
{
    public class GestionFournisseur
    {
        //Enregistrer un fournisseur
        public static void Enregistrer(NouveauFournisseur frm)
        {
            if (Rechercher(telephone: frm.TxtTelephone.Text, nom: frm.TxtNom.Text) == null)
            {
                using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
                {
                    Fournisseur fournisseur = sim.Fournisseurs.Add(
                            new Fournisseur
                            {
                                nom = frm.TxtNom.Text,
                                adresse = frm.TxtAdresse.Text,
                                telephone = frm.TxtTelephone.Text
                            }
                        );
                    int n = sim.SaveChanges();//Procedure stockee à intégrer ...
                    frm.TxtNum.Text = fournisseur.numFournisseur.ToString();
                    //Message de confirmation!
                }
            }
            else
            {
                //Message d'erreur! 
            }
        }

        //Rechercher un fournisseur par nom et par telephone
        private static Fournisseur Rechercher(string nom, string telephone)
        {
            Fournisseur fournisseur = null;
            using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
            {
                IEnumerable<Fournisseur> result = from f in sim.Fournisseurs
                                              where f.nom == nom && f.telephone == telephone
                                              select f;

                if (result.Count() > 0)
                {
                   fournisseur = result.First();
                }
            }
            return fournisseur;
        }

        //Rechercher tous les fournisseurs
        private static List<Fournisseur> Rechercher()
        {
            List<Fournisseur> listeFournisseur = null;
            using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
            {
                listeFournisseur=(from f in sim.Fournisseurs
                 select f
                 ).ToList();
            }
            return listeFournisseur;
        }
    }
}