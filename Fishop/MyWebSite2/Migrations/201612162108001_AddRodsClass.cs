namespace MyWebSite2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRodsClass : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Products", newName: "Rods");
            AddColumn("dbo.Reels", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Reels", "Material", c => c.String());
            AddColumn("dbo.Reels", "Length", c => c.Int(nullable: false));
            DropColumn("dbo.Reels", "Construction");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reels", "Construction", c => c.String());
            DropColumn("dbo.Reels", "Length");
            DropColumn("dbo.Reels", "Material");
            DropColumn("dbo.Reels", "CategoryId");
            RenameTable(name: "dbo.Rods", newName: "Products");
        }
    }
}
