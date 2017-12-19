namespace ContratosApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contrato",
                c => new
                    {
                        NombreContrato = c.String(nullable: false, maxLength: 128),
                        FechaInicio = c.String(),
                        FechaFinal = c.String(),
                        Garante_IDGarante = c.Int(),
                        Locador_IDLocador = c.Int(),
                        Locatario_IDLocatario = c.Int(),
                        Propiedades_IDPropiedad = c.Int(),
                    })
                .PrimaryKey(t => t.NombreContrato)
                .ForeignKey("dbo.Garante", t => t.Garante_IDGarante)
                .ForeignKey("dbo.Locador", t => t.Locador_IDLocador)
                .ForeignKey("dbo.Locatario", t => t.Locatario_IDLocatario)
                .ForeignKey("dbo.Propiedad", t => t.Propiedades_IDPropiedad)
                .Index(t => t.Garante_IDGarante)
                .Index(t => t.Locador_IDLocador)
                .Index(t => t.Locatario_IDLocatario)
                .Index(t => t.Propiedades_IDPropiedad);
            
            CreateTable(
                "dbo.Garante",
                c => new
                    {
                        IDGarante = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.IDGarante);
            
            CreateTable(
                "dbo.Locador",
                c => new
                    {
                        IDLocador = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.IDLocador);
            
            CreateTable(
                "dbo.Locatario",
                c => new
                    {
                        IDLocatario = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.IDLocatario);
            
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
            DropForeignKey("dbo.Contrato", "Locatario_IDLocatario", "dbo.Locatario");
            DropForeignKey("dbo.Contrato", "Locador_IDLocador", "dbo.Locador");
            DropForeignKey("dbo.Contrato", "Garante_IDGarante", "dbo.Garante");
            DropIndex("dbo.Contrato", new[] { "Propiedades_IDPropiedad" });
            DropIndex("dbo.Contrato", new[] { "Locatario_IDLocatario" });
            DropIndex("dbo.Contrato", new[] { "Locador_IDLocador" });
            DropIndex("dbo.Contrato", new[] { "Garante_IDGarante" });
            DropTable("dbo.Propiedad");
            DropTable("dbo.Locatario");
            DropTable("dbo.Locador");
            DropTable("dbo.Garante");
            DropTable("dbo.Contrato");
        }
    }
}
