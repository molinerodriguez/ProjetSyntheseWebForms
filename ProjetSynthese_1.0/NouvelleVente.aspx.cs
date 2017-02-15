using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class NouvelleVente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GestionVente.InitialiserVente(this);
            }
        }

        #region Proprietes
        public TextBox TxtNumVente { get { return this.txtNumVente; } }
        public TextBox TxtDateVente { get { return this.txtDateVente; } }
        public TextBox TxtArticle { get { return this.txtArticle; } }
        public Button BtnRechercher { get { return this.btnRechercher; } }
        public GridView GridArticle { get { return this.gridArticle; } }
        public TextBox TxtNumArticle { get { return this.txtNumArticle; } }
        public TextBox TxtNomArticle { get { return this.txtNomArticle; } }
        public TextBox TxtPrixVente { get { return this.txtPrixVente; } }
        public TextBox TxtQuantite { get { return this.txtQuantite; } }
        public Button BtnAjouter { get { return this.btnAjouter; } }
        public GridView GridLigneVente { get { return this.gridLigneVente; } }
        public TextBox TxtMontant { get { return this.txtMontant; } }
        public Button BtnValider { get { return this.btnValider; } }
        #endregion

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            GestionArticle.ListerArticles(this);
        }

        protected void gridArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow myRow = this.GridArticle.SelectedRow;
            this.TxtNumArticle.Text = myRow.Cells[1].Text;
            this.TxtNomArticle.Text = myRow.Cells[2].Text;
            this.TxtPrixVente.Text = myRow.Cells[4].Text;
            this.btnAjouter.Enabled = true;
        }

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            GestionVente.Ajouter(this);
            this.BtnAjouter.Enabled = false;
            this.BtnValider.Enabled = true;
        }

        protected void btnValider_Click(object sender, EventArgs e)
        {
            GestionVente.ValiderVente(this);
        }
    }
}