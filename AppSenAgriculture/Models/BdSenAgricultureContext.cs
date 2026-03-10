using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace AppSenAgriculture.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdSenAgricultureContext : DbContext

    {
        public BdSenAgricultureContext() : base("conSenAgriculture") {
        
        }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<Produit> produits { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Utilisateur> utilisateurs { get; set; }
        public DbSet<Cultivateur> cultivateurs{ get; set; }
        public DbSet<UniteMesure> unitemesures { get; set; }
        public DbSet<Facilitateur> facilitateurs { get; set; }
        public DbSet<Departement> departements { get; set; }
        public DbSet<Commune> communes { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Region> regions { get; set; }

        public DbSet<Champ> champs { get; set; }
        public DbSet<MoyenDePaiement> moyendepaiements { get; set; }

        public DbSet<Td_Erreur> tdErreurs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
