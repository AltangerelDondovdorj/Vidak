namespace Vidak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedGenreTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movie", "GenreTypes_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movie", new[] { "GenreTypes_Id" });
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.Movie", "GenreTypes_Id", c => c.Byte());
            AlterColumn("dbo.GenreTypes", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.GenreTypes", "Name", c => c.String(maxLength: 255));
            AddPrimaryKey("dbo.GenreTypes", "Id");
            CreateIndex("dbo.Movie", "GenreTypes_Id");
            AddForeignKey("dbo.Movie", "GenreTypes_Id", "dbo.GenreTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movie", "GenreTypes_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movie", new[] { "GenreTypes_Id" });
            DropPrimaryKey("dbo.GenreTypes");
            AlterColumn("dbo.GenreTypes", "Name", c => c.String());
            AlterColumn("dbo.GenreTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Movie", "GenreTypes_Id", c => c.Int());
            AddPrimaryKey("dbo.GenreTypes", "Id");
            CreateIndex("dbo.Movie", "GenreTypes_Id");
            AddForeignKey("dbo.Movie", "GenreTypes_Id", "dbo.GenreTypes", "Id");
        }
    }
}
