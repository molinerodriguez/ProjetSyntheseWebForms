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
                //Charger foutnisseur
                this.cmbFournisseur.DataSource = GestionFournisseur.Rechercher();
                this.cmbFournisseur.DataTextField = "nom";
                this.cmbFournisseur.DataBind();
                //Fin
            }
            
        }

        protected void cmbFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Afficher info fournisseur
            this.txtInfoFpurnisseur.Text = this.cmbFournisseur.SelectedValue;
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
        public TextBox TxtQuantite { get { return this.txtQuantite; } }

        public GridView GridViewCommande { get { return this.gridViewCommande; } }
        #endregion
    }
}