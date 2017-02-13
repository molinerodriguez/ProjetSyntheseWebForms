using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Modeles;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class StockBureaucentral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            using (var sim = new SIM_Context())
            {
                var result = from s in sim.StockCentrals
                                 /*where s.Article.nom == "" || s.Article.categorie == ""*/
                             select new
                             {
                                 Numero = s.Article.numArticle,
                                 Nom = s.Article.nom,
                                 Catetorie = s.Article.categorie,
                                 QteEnStock = s.Article.StockCentral.qte
                             };

                this.GridEtatStock.DataSource = result.ToList();
                this.GridEtatStock.DataBind();
            }
        }
    }
}