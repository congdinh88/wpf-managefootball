namespace ManageFootball.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "Addresse", c => c.String());
            DropColumn("dbo.Matches", "Add");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "Add", c => c.String());
            DropColumn("dbo.Matches", "Addresse");
        }
    }
}
