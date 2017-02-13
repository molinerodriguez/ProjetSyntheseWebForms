using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetSynthese_1._0.Modeles;

namespace ProjetSynthese_1._0.Controleurs
{
    public class GestionnaireStock
    {
        //Methode affichant l'etat central par nom d'articles
        public static void AfficherEtatStockCentral(StockBureaucentral frm, bool filtre)
        {
            using (var sim = new SIM_Context())
            {
                IEnumerable<Object> result = null;
                if (filtre)
                {
                        result = from s in sim.StockCentrals
                                 where s.Article.nom.ToUpper().StartsWith(frm.TxtNom.Text.ToUpper())
                                 select new
                                 {
                                     Numero = s.Article.numArticle,
                                     Nom = s.Article.nom,
                                     Catetorie = s.Article.categorie,
                                     QteEnStock = s.Article.StockCentral.qte,
                                     QteCritique = s.qteCritique
                                 };
                }
                else
                {
                        result = from s in sim.StockCentrals
                                 select new
                                 {
                                     Numero = s.Article.numArticle,
                                     Nom = s.Article.nom,
                                     Catetorie = s.Article.categorie,
                                     QteEnStock = s.Article.StockCentral.qte,
                                     QteCritique = s.qteCritique
                                 };
                }

                frm.GridEtatStock.DataSource = result.ToList();
                frm.GridEtatStock.DataBind();
            }
        }
    }
}