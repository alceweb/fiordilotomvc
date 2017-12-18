namespace FiordilotoMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventi1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventis", "Titolo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Eventis", "Titolo");
        }
    }
}
