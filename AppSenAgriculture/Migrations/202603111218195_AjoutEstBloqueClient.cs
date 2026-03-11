namespace AppSenAgriculture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AjoutEstBloqueClient : DbMigration
    {
        public override void Up()
        {
            // Ajoute la colonne EstBloque avec false par défaut
            AddColumn("dbo.Utilisateurs", "EstBloque", c => c.Boolean(nullable: false, defaultValue: false));
        }

        public override void Down()
        {
            // Supprime la colonne si on revient en arrière
            DropColumn("dbo.Utilisateurs", "EstBloque");
        }
    }
}