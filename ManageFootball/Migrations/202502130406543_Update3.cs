namespace ManageFootball.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Stats", "YellowCard", c => c.Boolean());
            AlterColumn("dbo.Stats", "RedCard", c => c.Boolean());
            AlterColumn("dbo.Stats", "Goals", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Stats", "Goals", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Stats", "RedCard", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Stats", "YellowCard", c => c.Boolean(nullable: false));
        }
    }
}
