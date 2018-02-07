namespace Vidak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNewGenreTypeModelAndConnectToMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GenreTypes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GenreTypes", t => t.GenreTypes_Id)
                .Index(t => t.GenreTypes_Id);
            
            CreateTable(
                "dbo.GenreTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movie", "GenreTypes_Id", "dbo.GenreTypes");
            DropIndex("dbo.Movie", new[] { "GenreTypes_Id" });
            DropTable("dbo.GenreTypes");
            DropTable("dbo.Movie");
        }
    }
}
