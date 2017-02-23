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
            CharcherNumeroBonDistribution();

        }

        private void CharcherNumeroBonDistribution()
        {
            Utilisateur user = Session["utilisateur"] as Utilisateur;
            var sim = new SIM_Context();
            var result = from b in sim.BonDistributions
                         where b.numFiliale == user.numFiliale
                         select b;

            DDLNumBonDistribution.DataSource = result.ToList();
            DDLNumBonDistribution.DataTextField = "numBonDistribution";
            DDLNumBonDistribution.DataBind();
        }

        #region Proprietes
        public DropDownList DDLNumBonDistribution { get { return this.ddlNumBonDistribution; } }
        public TextBox TxtNomFiliale { get { return this.txtNomFiliale; } }
        public Button BtnRechercher { get { return this.btnRechercher; } }
        public TextBox TxtDateBonDistribution { get { return this.txtDateBonDistribution; } }
        public GridView GridBonDistribution { get { return this.gridBonDistribution; } }
        public Button BtnRecevoir { get { return this.btnRecevoir; } }
        public Button BtnImprimer { get { return this.btnImprimer; } }
        public Label LblResultatRecevoirBonDistribution { get { return this.lblResultatRecevoirBonDistribution; } }


        #endregion

        protected void btnRecevoir_Click(object sender, EventArgs e)
        {
            //A deplacer dans le controleur approprie
            BonDistribution bnd = null;
            using (var sim = new SIM_Context())
            {
                bnd = sim.BonDistributions.Find(int.Parse(this.DDLNumBonDistribution.SelectedItem.Text));


                if (bnd != null)
                {
                    foreach (LigneBonDistribution l in bnd.LigneBonDistributions)
                    {
                        //Rechercher le stock de l'article dans la filiale
                        var result = from s in l.Article.Stocks
                                     where s.numArticle == l.numArticle && s.numFiliale == bnd.numFiliale
                                     select s;

                        if (result.Count() == 0)//Premiere distribution de l'article dans cette filiale
                        {
                            l.Article.Stocks.Add(
                                new Stock
                                {
                                    numArticle = l.numArticle,
                                    numFiliale = bnd.numFiliale,
                                    qteEnStock = l.quantite,
                                    qteMoyenneMin = 0
                                }
                            );
                        }
                        else //Le stock de cet article existe deja dans cette filiale
                        {
                            result.Single().qteEnStock += l.quantite; //Peux pas distribuer un article deux fois!!!!! pour la meme filiale

                        }
                    }



                    sim.SaveChanges();
                    //Message de confirmation!
                    LblResultatRecevoirBonDistribution.Text = "Le bon a été reçu avec succes!";
                    BtnRecevoir.Enabled = false;

                    //efface le bon recu!(juste pour demonstration pour simuler la reception correct!!!)
                    //sim.NotificationBonDistributions.Remove(sim.NotificationBonDistributions.Find(bnd.numBonDistribution));
                    sim.BonDistributions.Remove(bnd);
                    sim.SaveChanges();
                }
            }
        }

        protected void btnImprimer_Click(object sender, EventArgs e)
        {
            lblResultatRecevoirBonDistribution.Text = "Le bon a été imprimé avec succes!";

        }

        protected void btnRechercher_Click(object sender, EventArgs e)
        {


            try
            {
                //A deplacer dans le controleur approprie
                BonDistribution bnd = null;
                using (var sim = new SIM_Context())
                {
                    bnd = sim.BonDistributions.Find(int.Parse(this.DDLNumBonDistribution.SelectedItem.Text));
                    if (bnd != null)
                    {
                        //this.TxtNumBondistribution.Text = bnd.numBonDistribution.ToString();
                        this.TxtNomFiliale.Text = bnd.Filiale.nom;
                        this.TxtDateBonDistribution.Text = bnd.dateBonDistribution.ToShortDateString();
                        this.GridBonDistribution.DataSource = (from b in bnd.LigneBonDistributions
                                                               select new
                                                               {
                                                                   NumeroArticle = b.numArticle,
                                                                   NomArticle = b.Article.nom,
                                                                   Description = b.Article.description,
                                                                   Quantite = b.quantite
                                                               }
                                                             ).ToList();
                        this.GridBonDistribution.DataBind();

                    }
                    else
                    {
                        lblResultatNumeroBonDistribution.Text = "Bon de distribution n'existe pas";
                        return;
                    }
                    lblResultatNumeroBonDistribution.Text = "";
                    BtnRecevoir.Enabled = true;
                    BtnImprimer.Enabled = true;
                    BtnRechercher.Enabled = false;
                    DDLNumBonDistribution.Enabled = false;
                }

            }
            catch (Exception)
            {
                lblResultatNumeroBonDistribution.Text = "Champ obligatoire en numérique!";
            }
        }
    }
}