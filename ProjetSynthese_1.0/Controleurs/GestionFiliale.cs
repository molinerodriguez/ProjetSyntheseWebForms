using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetSynthese_1._0.Modeles;

namespace ProjetSynthese_1._0.Controleurs
{
    public class GestionFiliale
    {
        //Charger les filiales dans le combobox
        public static void ChargerFiliale(NouvelleBonDistribution frm)
        {
            frm.CmbFiliale.DataSource = Rechercher();
            frm.CmbFiliale.DataTextField = "nom";
            frm.CmbFiliale.DataBind();
        }

        //Rechercher toutes les filiales
        public static List<Filiale> Rechercher()
        {
            List<Filiale> listeFiliale = null;
            using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
            {
                listeFiliale = (from f in sim.Filiales
                                    select f
                 ).ToList();
            }
            return listeFiliale;
        }

        //Rechercher une filiale  par nom
        public static Filiale Rechercher(string nom)
        {
            Filiale filiale = null;
            using (var sim = new SIM_Context() /*SIM_Context.getInstance()*/)
            {
                IEnumerable<Filiale> result = from f in sim.Filiales
                                                  where f.nom == nom
                                                  select f;

                if (result.Count() > 0)
                {
                    filiale = result.First();
                }
            }
            return filiale;
        }

        //Afficher une filiale selectionnée
        public static void AfficherFiliale(NouvelleBonDistribution frm)
        {
            Filiale f = Rechercher(frm.CmbFiliale.SelectedValue);
            frm.TxtInfoFiliale.Text = "Nom :" + f.nom + "\n" + "Adresse :" + f.adresse + "\n" + "Telephone :" + f.telephone;
        }
    }
}