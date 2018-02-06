namespace Vidak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotionsToCustmerName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MembershipType", newName: "MembershipTypes");
            AlterColumn("dbo.Customer", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Name", c => c.String());
            RenameTable(name: "dbo.MembershipTypes", newName: "MembershipType");
        }
    }
}
