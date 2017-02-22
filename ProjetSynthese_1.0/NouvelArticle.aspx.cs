using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class NouvelArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            genererDropDownListCategorie();

        }

        private void genererDropDownListCategorie()
        {
            ddlCategorieNouvelArticle.Items.Add("Fruits");
            ddlCategorieNouvelArticle.Items.Add("Legumes");
        }

        protected void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                GestionArticle.Enregister(this);
            }
        }

        #region proprietes
        public TextBox TxtNum { get { return this.txtNum; } }
        public TextBox TxtNom { get { return this.txtNom; } }
        public TextBox TxtDescription { get { return this.txtDescription; } }
        public DropDownList DDLCategorieNouvelArticle { get { return this.ddlCategorieNouvelArticle; } }
        public TextBox TxtPxAchat { get { return this.txtPxAchat; } }
        public TextBox TxtPxVente { get { return this.txtPxVente; } }
        public Label LblResultatNouvelArticle { get { return this.lblResultatNouvelArticle; } }
        #endregion
    }
}