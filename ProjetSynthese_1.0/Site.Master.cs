using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {    
            if (!IsPostBack)
            {
                GestionUtilisateur.SetupEspaceTravail(this);
            }
        }

        protected void btnDeconnexion_Click(object sender, EventArgs e)
        {
            btnDeconnexion.Visible = false;
            btnUtilisateur.Text = "Se connecter";
            GestionUtilisateur.SeDeconnecter(this);
        }

        protected void btnUtilisateur_Click(object sender, EventArgs e)
        {
            if(btnUtilisateur.Text == "Se connecter")
            {
                Server.Transfer("Login.aspx");
            }
        }


    }
}