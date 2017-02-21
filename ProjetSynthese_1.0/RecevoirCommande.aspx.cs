using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class RecevoirCommande : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region proprietes
        public TextBox TxtNumeroCommande { get { return this.txtNumeroCommande; } }
        public TextBox TxtFournisseur { get { return this.txtFournisseur; } }
        public TextBox TxtMontant { get { return this.txtMontant; } }
        public TextBox TxtDate { get { return this.txtDate; } }
        public GridView GridLignesCommande { get { return this.gridLignesCommande; } }
        //public GridView GridArticlesCommande { get { return this.gridArticlesCommande; } }
        public Button BtnRecevoir { get { return this.btnRecevoir; } }
        public Button BtnImprimer { get { return this.btnImprimer; } }
        public Label LblResultatRecevoir { get { return this.lblResultatRecevoir; } }


        
        #endregion

        protected void btnRecevoir_Click(object sender, EventArgs e)
        {
            GestionCommande.RecevoirCommande(this);
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            GestionCommande.RechercherCommande(this);
        }
    }
}