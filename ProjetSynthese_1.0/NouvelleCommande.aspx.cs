using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class NouvelleCommande : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GestionFournisseur.ChargerFourniseur(this);
                GestionCommande.InitialiserCommande(this);
            }
            
        }

        protected void cmbFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Afficher info fournisseur
            GestionFournisseur.AfficherInfosFournisseur(this);
        }

        //protected void txtArticle_TextChanged(object sender, EventArgs e)
        //{
        //    //Lister des articles
        //    GestionArticle.ListerArticles(this);
        //}

        protected void gridArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Afficher un article
            GestionArticle.Afficher(this);
        }

        #region proprietes
        public TextBox TxtNumCommande { get { return this.txtNumCommande; } }
        public DropDownList CmbFournisseur { get { return this.cmbFournisseur; } }
        public TextBox TxtInfoFournisseur { get { return this.txtInfoFpurnisseur; } }
        public TextBox TxtMontant { get { return this.txtMontant; } }
        public Calendar CalDateCommande { get { return this.calDateCommande; } }

        public TextBox TxtArticle { get { return this.txtArticle; } }
        public GridView GridArticles { get { return this.gridArticles; } }
        public TextBox TxtNum { get { return this.txtNum; } }
        public TextBox TxtNom { get { return this.txtNom; } }
        public TextBox TxtPrix { get { return this.txtPrix; } }
        public TextBox TxtQuantite { get { return this.txtQuantite; } }
        public GridView GridViewCommande { get { return this.gridViewCommande; } }
        public Button BtnRechercher { get { return this.btnRechercher; } }
        public Button BtnEnregistrer { get { return this.btnEnregistrer; } }
        public Button BtnAjouter { get { return this.btnAjouter; } }
        #endregion

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            GestionCommande.Ajouter(this);
        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            //Lister des articles
            GestionArticle.ListerArticles(this);
        }

        protected void gridViewCommande_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Selection de la ligne à supprimer
            GridViewRow myRow = ((GridView)sender).Rows[e.RowIndex];
            int numArticle = int.Parse(myRow.Cells[2].Text);
            GestionCommande.supprimmerLigne(this,numArticle);
        }

        protected void btnEnregistrer_Click(object sender, EventArgs e)
        {
            GestionCommande.EnregisterCommande(this);
        }
    }
}