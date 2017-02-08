using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class NouveauFournisseur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnregistrer_Click(object sender, EventArgs e)
        {
            GestionFournisseur.Enregistrer(this);
        }

        #region
        public TextBox TxtNum { get { return this.txtNum; } }
        public TextBox TxtNom { get { return this.txtNom; } }
        public TextBox TxtAdresse { get { return this.txtAdresse; } }
        public TextBox TxtTelephone { get { return this.txtTelephone; } }
        #endregion
    }
}