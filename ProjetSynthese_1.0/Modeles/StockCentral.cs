namespace ProjetSynthese_1._0.Modeles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockCentral")]
    public partial class StockCentral
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numArticle { get; set; }

        public int qte { get; set; }

        public int qteCritique { get; set; }

        public virtual Article Article { get; set; }
    }
}
