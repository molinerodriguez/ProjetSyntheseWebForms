using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class ModifierArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //this.RangeValidator1.Enabled = false;
                //this.RangeValidator2.Enabled = false;

                GridViewRow myRow = Session["myRow"] as GridViewRow;
                //myGrid = Session["maSource"] as Object;
                this.txtNum.Text = myRow.Cells[1].Text;
                this.txtNom.Text = myRow.Cells[2].Text;
                this.txtDescription.Text = myRow.Cells[3].Text;
                this.txtCategorie.Text = myRow.Cells[4].Text;
                this.txtPxAchat.Text = myRow.Cells[5].Text;
                this.txtPxVente.Text = myRow.Cells[6].Text;
                //this.RangeValidator1.Enabled = true;
                //this.RangeValidator2.Enabled = true;
            }
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            GestionArticle.Modifier(this);
        }

        #region proprietes
        public TextBox TxtNum
        {
            get { return this.txtNum; }
        }

        public TextBox TxtNom
        {
            get { return this.txtNom; }
        }

        public TextBox TxtDescription
        {
            get { return this.txtDescription; }
        }

        public TextBox TxtCategorie
        {
            get { return this.txtCategorie; }
        }

        public TextBox TxtPxAchat
        {
            get { return this.txtPxAchat; }
        }

        public TextBox TxtPxVente
        {
            get { return this.txtPxVente; }
        }

        public Label LblResultatModificationArticle
        {
            get
            {
                return lblResultatModificationArticle;
            }
        }
        #endregion
    }
}