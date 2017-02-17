namespace MyWebSite2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReelClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Inches_per_Crank = c.Int(nullable: false),
                        Friction = c.String(),
                        BearingsNumber = c.String(),
                        GearRatio = c.Single(nullable: false),
                        Artikul = c.String(),
                        Price = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Construction = c.String(),
                        Description = c.String(),
                        imageName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reels");
        }
    }
}
