namespace ManageFootball.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        Time = c.DateTime(nullable: false),
                        Add = c.String(),
                        TeamId1 = c.Int(nullable: false),
                        TeamId2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Teams", t => t.TeamId1)
                .ForeignKey("dbo.Teams", t => t.TeamId2)
                .Index(t => t.TeamId1)
                .Index(t => t.TeamId2);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchCode = c.String(nullable: false, maxLength: 128),
                        TeamId = c.Int(nullable: false),
                        Sco = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.MatchCode)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.MatchCode)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Teams = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "TeamId2", "dbo.Teams");
            DropForeignKey("dbo.Matches", "TeamId1", "dbo.Teams");
            DropForeignKey("dbo.Scores", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Scores", "MatchCode", "dbo.Matches");
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Scores", new[] { "TeamId" });
            DropIndex("dbo.Scores", new[] { "MatchCode" });
            DropIndex("dbo.Matches", new[] { "TeamId2" });
            DropIndex("dbo.Matches", new[] { "TeamId1" });
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Scores");
            DropTable("dbo.Matches");
        }
    }
}
