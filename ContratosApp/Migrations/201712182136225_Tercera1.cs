namespace ContratosApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tercera1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Garante", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Garante", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Garante", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Locador", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Locador", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Locador", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Locatario", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Locatario", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Locatario", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locatario", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Locatario", "LastName", c => c.String());
            AlterColumn("dbo.Locatario", "Name", c => c.String());
            AlterColumn("dbo.Locador", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Locador", "LastName", c => c.String());
            AlterColumn("dbo.Locador", "Name", c => c.String());
            AlterColumn("dbo.Garante", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Garante", "LastName", c => c.String());
            AlterColumn("dbo.Garante", "Name", c => c.String());
        }
    }
}
