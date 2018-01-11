namespace FiordilotoMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class credits : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventis", "Credits", c => c.Boolean(nullable: false));
            AddColumn("dbo.Eventis", "Casa", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Eventis", "Casa");
            DropColumn("dbo.Eventis", "Credits");
        }
    }
}
