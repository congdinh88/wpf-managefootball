namespace ManageFootball.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchCode = c.String(maxLength: 128),
                        TeamId = c.Int(nullable: false),
                        PlayerId = c.Int(nullable: false),
                        YellowCard = c.Boolean(nullable: false),
                        RedCard = c.Boolean(nullable: false),
                        Goals = c.Boolean(nullable: false),
                        Time = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.MatchCode)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.MatchCode)
                .Index(t => t.TeamId)
                .Index(t => t.PlayerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stats", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Stats", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.Stats", "MatchCode", "dbo.Matches");
            DropIndex("dbo.Stats", new[] { "PlayerId" });
            DropIndex("dbo.Stats", new[] { "TeamId" });
            DropIndex("dbo.Stats", new[] { "MatchCode" });
            DropTable("dbo.Stats");
        }
    }
}
