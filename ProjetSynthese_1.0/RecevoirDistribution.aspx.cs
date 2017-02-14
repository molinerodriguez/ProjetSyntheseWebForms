using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetSynthese_1._0.Modeles;
using ProjetSynthese_1._0.Controleurs;

namespace ProjetSynthese_1._0
{
    public partial class RecevoirDistribution : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Proprietes
        public TextBox TxtNumBondistribution { get { return this.txtNumBondistribution; } }
        public TextBox TxtNomFiliale { get { return this.txtNomFiliale; } }
        public Button BtnRechercher { get { return this.btnRechercher; } }
        public TextBox TxtDateBonDistribution { get { return this.txtDateBonDistribution; } }
        public GridView GridBonDistribution { get { return this.gridBonDistribution; } }
        public Button BtnRecevoir { get { return this.btnRecevoir; } }
        public Button BtnImprimer { get { return this.btnImprimer; } }
        #endregion

        protected void btnRecevoir_Click(object sender, EventArgs e)
        {

        }

        protected void btnImprimer_Click(object sender, EventArgs e)
        {

        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            BonDistribution bnd = null;
            using (var sim = new SIM_Context())
            {
                bnd = sim.BonDistributions.Find(this.TxtNumBondistribution.Text);
                if (bnd!=null)
                {
                    this.TxtNumBondistribution.Text = bnd.numBonDistribution.ToString();
                    this.TxtNomFiliale.Text = bnd.Filiale.nom;
                }
            }
        }
    }
}