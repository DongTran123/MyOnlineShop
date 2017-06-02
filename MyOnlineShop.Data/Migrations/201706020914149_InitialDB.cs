namespace MyOnlineShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Contentt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Contentt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        URL = c.String(nullable: false, maxLength: 500),
                        DisplayOrder = c.Int(),
                        GroupID = c.Int(nullable: false),
                        Target = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuGroups", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(maxLength: 250),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 500),
                        Description = c.String(maxLength: 500),
                        HomeFlag = c.Boolean(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductCategoryDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductCategoryID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(maxLength: 250),
                        DisplayOrder = c.Int(),
                        HomeFlag = c.Boolean(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryID, cascadeDelete: true)
                .Index(t => t.ProductCategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductCategoryDetailID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(maxLength: 250),
                        Image = c.String(maxLength: 500),
                        Image1 = c.String(maxLength: 500),
                        Image2 = c.String(maxLength: 500),
                        Image3 = c.String(maxLength: 500),
                        MoreImage = c.String(storeType: "xml"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Warranty = c.Int(),
                        Description = c.String(maxLength: 500),
                        Contentt = c.String(),
                        ViewCount = c.Int(nullable: false),
                        HomeFlag = c.Boolean(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        MetaKeyword = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductCategoryDetails", t => t.ProductCategoryDetailID, cascadeDelete: true)
                .Index(t => t.ProductCategoryDetailID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Description = c.String(maxLength: 500),
                        URL = c.String(maxLength: 500),
                        DisplayOrder = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductCategoryDetailID", "dbo.ProductCategoryDetails");
            DropForeignKey("dbo.ProductCategoryDetails", "ProductCategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups");
            DropIndex("dbo.Products", new[] { "ProductCategoryDetailID" });
            DropIndex("dbo.ProductCategoryDetails", new[] { "ProductCategoryID" });
            DropIndex("dbo.Menus", new[] { "GroupID" });
            DropTable("dbo.Slides");
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategoryDetails");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Footers");
        }
    }
}
