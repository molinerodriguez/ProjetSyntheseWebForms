namespace ProjetSynthese_1._0.Modeles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Serializable]
    [Table("NotificationStockCritique")]
    public partial class NotificationStockCritique
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numNotification { get; set; }

        [Required]
        [StringLength(50)]
        public string message { get; set; }

        public DateTime dateNotification { get; set; }
    }
}
