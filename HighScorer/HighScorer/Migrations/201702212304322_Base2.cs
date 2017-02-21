namespace HighScorer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Links");
            AlterColumn("dbo.Links", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Links", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Links");
            AlterColumn("dbo.Links", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Links", "Id");
        }
    }
}
