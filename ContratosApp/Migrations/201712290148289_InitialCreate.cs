namespace ContratosApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contrato",
                c => new
                    {
                        ContratoID = c.Int(nullable: false, identity: true),
                        NombreContrato = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFinal = c.DateTime(nullable: false),
                        Garante_ID = c.Int(),
                        Locador_ID = c.Int(),
                        Locatario_ID = c.Int(),
                        Propiedades_IDPropiedad = c.Int(),
                    })
                .PrimaryKey(t => t.ContratoID)
                .ForeignKey("dbo.Garante", t => t.Garante_ID)
                .ForeignKey("dbo.Locador", t => t.Locador_ID)
                .ForeignKey("dbo.Locatario", t => t.Locatario_ID)
                .ForeignKey("dbo.Propiedad", t => t.Propiedades_IDPropiedad)
                .Index(t => t.Garante_ID)
                .Index(t => t.Locador_ID)
                .Index(t => t.Locatario_ID)
                .Index(t => t.Propiedades_IDPropiedad);
            
            CreateTable(
                "dbo.Garante",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Locador",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Locatario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Propiedad",
                c => new
                    {
                        IDPropiedad = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.IDPropiedad);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contrato", "Propiedades_IDPropiedad", "dbo.Propiedad");
            DropForeignKey("dbo.Contrato", "Locatario_ID", "dbo.Locatario");
            DropForeignKey("dbo.Contrato", "Locador_ID", "dbo.Locador");
            DropForeignKey("dbo.Contrato", "Garante_ID", "dbo.Garante");
            DropIndex("dbo.Contrato", new[] { "Propiedades_IDPropiedad" });
            DropIndex("dbo.Contrato", new[] { "Locatario_ID" });
            DropIndex("dbo.Contrato", new[] { "Locador_ID" });
            DropIndex("dbo.Contrato", new[] { "Garante_ID" });
            DropTable("dbo.Propiedad");
            DropTable("dbo.Locatario");
            DropTable("dbo.Locador");
            DropTable("dbo.Garante");
            DropTable("dbo.Contrato");
        }
    }
}
