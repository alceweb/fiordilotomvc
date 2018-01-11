namespace FiordilotoMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class citta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventis", "Città", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Eventis", "Città");
        }
    }
}
