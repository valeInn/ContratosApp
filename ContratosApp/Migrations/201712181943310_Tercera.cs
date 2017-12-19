namespace ContratosApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tercera : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contrato", "FechaInicio", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Contrato", "FechaFinal", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contrato", "FechaFinal", c => c.String());
            AlterColumn("dbo.Contrato", "FechaInicio", c => c.String());
        }
    }
}
