namespace AppSenAgriculture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBdSenAgriculture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilisateurs", "ProfessionClient1", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Utilisateurs", "ProfessionClient1");
        }
    }
}
