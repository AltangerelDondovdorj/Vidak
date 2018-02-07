namespace Vidak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateAndOtherProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movie", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "NumberInStock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "NumberInStock");
            DropColumn("dbo.Movie", "ReleaseDate");
            DropColumn("dbo.Movie", "DateAdded");
            DropColumn("dbo.Movie", "GenreId");
        }
    }
}
