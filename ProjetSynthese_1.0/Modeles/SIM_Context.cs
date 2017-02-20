namespace ProjetSynthese_1._0.Modeles
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SIM_Context : DbContext
    {
        public SIM_Context()
            : base("name=SIM_Context")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<BonDistribution> BonDistributions { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Filiale> Filiales { get; set; }
        public virtual DbSet<Fournisseur> Fournisseurs { get; set; }
        public virtual DbSet<NotificationStockCritique> NotificationStockCritiques { get; set; }
        public virtual DbSet<Paiement> Paiements { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StockCentral> StockCentrals { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Vente> Ventes { get; set; }
        public virtual DbSet<LigneBonDistribution> LigneBonDistributions { get; set; }
        public virtual DbSet<LigneCommande> LigneCommandes { get; set; }
        public virtual DbSet<LigneVente> LigneVentes { get; set; }
        public virtual DbSet<NotificationBonDistribution> NotificationBonDistributions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasMany(e => e.LigneBonDistributions)
                .WithRequired(e => e.Article)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.LigneCommandes)
                .WithRequired(e => e.Article)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.LigneVentes)
                .WithRequired(e => e.Article)
                .HasForeignKey(e => e.numVente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.Stocks)
                .WithRequired(e => e.Article)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Article>()
                .HasOptional(e => e.StockCentral)
                .WithRequired(e => e.Article);

            modelBuilder.Entity<BonDistribution>()
                .HasMany(e => e.LigneBonDistributions)
                .WithRequired(e => e.BonDistribution)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BonDistribution>()
                .HasMany(e => e.NotificationBonDistributions)
                .WithRequired(e => e.BonDistribution)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Commande>()
                .HasMany(e => e.LigneCommandes)
                .WithRequired(e => e.Commande)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Filiale>()
                .HasMany(e => e.BonDistributions)
                .WithRequired(e => e.Filiale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Filiale>()
                .HasMany(e => e.Stocks)
                .WithRequired(e => e.Filiale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Filiale>()
                .HasMany(e => e.Utilisateurs)
                .WithRequired(e => e.Filiale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Filiale>()
                .HasMany(e => e.Ventes)
                .WithRequired(e => e.Filiale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fournisseur>()
                .HasMany(e => e.Commandes)
                .WithRequired(e => e.Fournisseur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vente>()
                .HasMany(e => e.Paiements)
                .WithRequired(e => e.Vente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vente>()
                .HasMany(e => e.LigneVentes)
                .WithRequired(e => e.Vente)
                .WillCascadeOnDelete(false);
        }
    }
}
