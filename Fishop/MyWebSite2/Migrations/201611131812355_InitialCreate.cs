namespace MyWebSite2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Firstname = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        ProductID = c.Int(nullable: false),
                        ProductPrice = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Artikul = c.String(),
                        Price = c.Int(nullable: false),
                        Material = c.String(),
                        Length = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Construction = c.String(),
                        SectionsNumber = c.Int(nullable: false),
                        imageName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
        }
    }
}
