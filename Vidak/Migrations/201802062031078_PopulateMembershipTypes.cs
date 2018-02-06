namespace Vidak.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
	        Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Pay as You Go', 0, 0, 0)");
	        Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly', 30, 1, 10)");
	        Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Year', 90, 3, 15)");
	        Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Platinium', 300, 12, 20)");
		}
        
        public override void Down()
        {
        }
    }
}
