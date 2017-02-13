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
            if (!IsPostBack)
            {
                GestionnaireStock.AfficherEtatStockCentral(this,false);
            }
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            GestionnaireStock.AfficherEtatStockCentral(this,true);
        }

        #region Proprietes
        public TextBox TxtNom { get { return this.txtNom; } }
        public Button BtnRechercher { get { return this.btnRechercher; } }
        public Button BtnImprimer { get { return this.btnImprimer; } }
        public GridView GridEtatStock { get { return this.gridEtatStock; } }
        #endregion
    }
}