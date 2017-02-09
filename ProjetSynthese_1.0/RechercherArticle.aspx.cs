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
    public partial class RechercherArticle : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    GridView myGrid;
            //    if ((myGrid = Session["maSource"] as GridView) != null)
            //    {
            //        this.gridArticles.DataSource = myGrid.DataSource;
            //    }
            //}
        }

        protected void gridArticles_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Demande de modification d'un article
            GridViewRow myRow=((GridView)sender).Rows[e.NewEditIndex];
            //string num = myRow.Cells[1].Text;
            //string nom = myRow.Cells[2].Text;
            //string description = myRow.Cells[3].Text;
            //string categorie = myRow.Cells[4].Text;
            //double pxAchat = double.Parse(myRow.Cells[5].Text);
            //double pxVente = double.Parse(myRow.Cells[6].Text);
            //************Test
            Session.Add("myRow", myRow);
            Session.Add("maSource",(GridView)sender);
            Server.Transfer("ModifierArticle.aspx");
            //************

        }

        protected void txtNomArticle_TextChanged(object sender, EventArgs e)
        {
            //Lister des articles
            GestionArticle.ListerArticles(this);
        }

        #region propriétes
        public TextBox TxtNom
        {
            get { return this.txtNomArticle; }
        }

        public GridView GridArticles
        {
            get { return this.gridArticles; }
        }
        #endregion

        protected void btnRechercher_Click(object sender, EventArgs e)
        {
            GestionArticle.ListerArticles(this);
        }
    }
}