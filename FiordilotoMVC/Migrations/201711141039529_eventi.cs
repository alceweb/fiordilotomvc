namespace FiordilotoMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Eventis",
                c => new
                    {
                        Evento_Id = c.Int(nullable: false, identity: true),
                        Vendita = c.Boolean(nullable: false),
                        Didattica = c.Boolean(nullable: false),
                        Corso = c.Boolean(nullable: false),
                        DescrizioneB = c.String(),
                        Descrizione = c.String(),
                        Regia = c.String(),
                        Evidenza = c.Boolean(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Partecipazioni = c.String(),
                        Archivio = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Evento_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Eventis");
        }
    }
}
