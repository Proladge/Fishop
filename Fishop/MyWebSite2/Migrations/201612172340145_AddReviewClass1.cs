namespace MyWebSite2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReviewClass1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        parentReview = c.Int(nullable: false),
                        Name = c.String(),
                        reviewText = c.String(),
                        Phone = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reviews");
        }
    }
}
