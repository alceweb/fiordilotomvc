namespace FiordilotoMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class counseling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventis", "Counseling", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Eventis", "Counseling");
        }
    }
}
