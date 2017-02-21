using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class NouvelleBonDistribution : System.Web.UI.Page
    {
        #region Proprietes
        public TextBox TxtNumBonDistribution { get { return this.txtNumBonDistribution; } }
        public TextBox TxtInfoFiliale { get { return this.txtInfoFiliale; } }
        public DropDownList CmbFiliale { get { return this.cmbFiliale; } }
        public TextBox TxtArticle { get { return this.txtArticle; } }
        public Button BtnRechercher { get { return this.btnRechercher; } }
        public GridView GridArticles { get { return this.gridArticles; } }
        public TextBox TxtNumArticle { get { return this.txtNumArticle; } }
        public TextBox TxtNom { get { return this.txtNom; } }
        public TextBox TxtQuantite { get { return this.txtQuantite; } }
        public Button BtnAjouter { get { return this.btnAjouter; } }
        public GridView GridViewDistribution { get { return this.gridViewDistribution; } }
        public Button BtnEnregistrer { get { return this.btnEnregistrer; } }

        public Label LblResultatTxtQuantite { get { return this.lblResultatTxtQuantite; } }
        public Label LblResultatEnregistrer { get { return this.lblResultatEnregistrer; } }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GestionFiliale.ChargerFiliale(this);
                GestionBonDistribution.InitialiserBon(this);
            }
        }

        protected void cmbFiliale_SelectedIndexChanged(object sender, EventArgs e)
        {
            GestionFiliale.AfficherFiliale(this);
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            //Lister des articles
            GestionArticle.ListerArticles(this);
        }

        protected void gridArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Afficher un article
            GestionArticle.Afficher(this);
            BtnAjouter.Enabled = true;

        }

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            //Ajouter une ligne de distribution
            GestionBonDistribution.Ajouter(this);
            BtnAjouter.Enabled = false;
            BtnEnregistrer.Enabled = true;
        }

        protected void gridViewDistribution_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Selection de la ligne à supprimer
            GridViewRow myRow = ((GridView)sender).Rows[e.RowIndex];
            int numArticle = int.Parse(myRow.Cells[2].Text);
            GestionBonDistribution.supprimmerLigne(this,numArticle);
            
        }

        protected void btnEnregistrer_Click(object sender, EventArgs e)
        {
            GestionBonDistribution.Enregistrer(this);
        }
        
    }
}