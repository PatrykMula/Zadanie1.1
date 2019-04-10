namespace Zadanie1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Danes",
                c => new
                    {
                        DaneId = c.Int(nullable: false, identity: true),
                        temat = c.String(nullable: false, maxLength: 255),
                        czynnosc = c.String(nullable: false, maxLength: 255),
                        opis = c.String(maxLength: 255),
                        status = c.Int(nullable: false),
                        priorytet = c.Int(nullable: false),
                        procent_zakonczenia = c.Int(nullable: false),
                        data_rozpoczecia = c.DateTime(nullable: false),
                        data_zakonczenia = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DaneId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Danes");
        }
    }
}
