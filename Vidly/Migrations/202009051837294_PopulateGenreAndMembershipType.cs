namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreAndMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Pay As You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly', 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Quarterly', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Annual', 300, 12, 20)");
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
