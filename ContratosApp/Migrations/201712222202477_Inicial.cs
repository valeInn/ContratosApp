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
                .ForeignKey("dbo.Persona", t => t.Garante_ID)
                .ForeignKey("dbo.Persona", t => t.Locador_ID)
                .ForeignKey("dbo.Persona", t => t.Locatario_ID)
                .ForeignKey("dbo.Propiedad", t => t.Propiedades_IDPropiedad)
                .Index(t => t.Garante_ID)
                .Index(t => t.Locador_ID)
                .Index(t => t.Locatario_ID)
                .Index(t => t.Propiedades_IDPropiedad);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
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
            DropForeignKey("dbo.Contrato", "Locatario_ID", "dbo.Persona");
            DropForeignKey("dbo.Contrato", "Locador_ID", "dbo.Persona");
            DropForeignKey("dbo.Contrato", "Garante_ID", "dbo.Persona");
            DropIndex("dbo.Contrato", new[] { "Propiedades_IDPropiedad" });
            DropIndex("dbo.Contrato", new[] { "Locatario_ID" });
            DropIndex("dbo.Contrato", new[] { "Locador_ID" });
            DropIndex("dbo.Contrato", new[] { "Garante_ID" });
            DropTable("dbo.Propiedad");
            DropTable("dbo.Persona");
            DropTable("dbo.Contrato");
        }
    }
}
