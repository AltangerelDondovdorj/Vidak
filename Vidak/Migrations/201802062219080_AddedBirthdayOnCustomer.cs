namespace Vidak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthdayOnCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Birthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Birthday");
        }
    }
}
