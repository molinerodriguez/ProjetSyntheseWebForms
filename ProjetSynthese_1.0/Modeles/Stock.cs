namespace ProjetSynthese_1._0.Modeles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numArticle { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numFiliale { get; set; }

        public int qteEnStock { get; set; }

        public int qteMoyenneMin { get; set; }

        public virtual Article Article { get; set; }

        public virtual Filiale Filiale { get; set; }
    }
}
