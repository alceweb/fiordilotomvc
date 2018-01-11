namespace FiordilotoMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class posizioneFDL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventis", "Posizione", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Eventis", "Posizione");
        }
    }
}
