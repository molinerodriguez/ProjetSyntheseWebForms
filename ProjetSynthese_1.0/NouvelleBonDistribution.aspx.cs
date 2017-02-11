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
        public Calendar CalDateBonDistribution { get { return this.calDateBonDistribution; } }
        public TextBox TxtArticle { get { return this.txtArticle; } }
        public Button BtnRechercher { get { return this.btnRechercher; } }
        public GridView GridArticles { get { return this.gridArticles; } }
        public TextBox TxtNumArticle { get { return this.txtNumArticle; } }
        public TextBox TxtNom { get { return this.txtNom; } }
        public TextBox TxtQuantite { get { return this.txtQuantite; } }
        public Button BtnAjouter { get { return this.btnAjouter; } }
        public GridView GridViewDistribution { get { return this.gridViewDistribution; } }
        public Button BtnEnregistrer { get { return this.btnEnregistrer; } }
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

        }

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            //Ajouter une ligne de distribution
            GestionBonDistribution.Ajouter(this);
        }

        protected void gridViewDistribution_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }
        
    }
}