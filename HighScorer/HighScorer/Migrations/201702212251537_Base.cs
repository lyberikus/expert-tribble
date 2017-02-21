namespace HighScorer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Url = c.String(),
                        Name = c.String(),
                        Game_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .Index(t => t.Game_Id);
            
            CreateTable(
                "dbo.GameSessions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Game_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .Index(t => t.Game_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        GameSession_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameSessions", t => t.GameSession_Id)
                .Index(t => t.GameSession_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "GameSession_Id", "dbo.GameSessions");
            DropForeignKey("dbo.GameSessions", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.Links", "Game_Id", "dbo.Games");
            DropIndex("dbo.Players", new[] { "GameSession_Id" });
            DropIndex("dbo.GameSessions", new[] { "Game_Id" });
            DropIndex("dbo.Links", new[] { "Game_Id" });
            DropTable("dbo.Players");
            DropTable("dbo.GameSessions");
            DropTable("dbo.Links");
            DropTable("dbo.Games");
        }
    }
}
