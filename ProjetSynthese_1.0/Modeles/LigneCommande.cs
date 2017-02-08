namespace ProjetSynthese_1._0.Modeles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LigneCommande")]
    public partial class LigneCommande
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numCommande { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numArticle { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int quantite { get; set; }

        [Key]
        [Column(Order = 3)]
        public double prix { get; set; }

        public virtual Article Article { get; set; }

        public virtual Commande Commande { get; set; }
    }
}
