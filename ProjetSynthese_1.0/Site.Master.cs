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
            //ici il faut detruire session utilisateur etc.
            Server.Transfer("~/Login.aspx");
        }
    }
}