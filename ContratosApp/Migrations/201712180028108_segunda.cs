namespace ContratosApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segunda : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Contrato");
            AlterColumn("dbo.Contrato", "NombreContrato", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Contrato", "NombreContrato");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Contrato");
            AlterColumn("dbo.Contrato", "NombreContrato", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Contrato", "NombreContrato");
        }
    }
}
