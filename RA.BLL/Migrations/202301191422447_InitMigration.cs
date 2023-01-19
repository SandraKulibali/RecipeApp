namespace RA.BLL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Continents",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        DishCountryId = c.Int(nullable: false),
                        DishCountry_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DishCountries", t => t.DishCountry_Id)
                .Index(t => t.DishCountry_Id);
            
            CreateTable(
                "dbo.DishCountries",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Instructions = c.String(),
                        DishCategoryId = c.Guid(nullable: false),
                        DishCounryId = c.Guid(nullable: false),
                        dishCountry_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DishCategories", t => t.DishCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.DishCountries", t => t.dishCountry_Id)
                .Index(t => t.DishCategoryId)
                .Index(t => t.dishCountry_Id);
            
            CreateTable(
                "dbo.DishCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingridients",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        ImagePath = c.String(),
                        Dish_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id)
                .Index(t => t.Dish_Id);
            
            CreateTable(
                "dbo.DishIngridients",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        DishId = c.Guid(nullable: false),
                        IngridientId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dishes", t => t.DishId, cascadeDelete: true)
                .ForeignKey("dbo.Ingridients", t => t.IngridientId, cascadeDelete: true)
                .Index(t => t.DishId)
                .Index(t => t.IngridientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DishIngridients", "IngridientId", "dbo.Ingridients");
            DropForeignKey("dbo.DishIngridients", "DishId", "dbo.Dishes");
            DropForeignKey("dbo.Ingridients", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.Dishes", "dishCountry_Id", "dbo.DishCountries");
            DropForeignKey("dbo.Dishes", "DishCategoryId", "dbo.DishCategories");
            DropForeignKey("dbo.Continents", "DishCountry_Id", "dbo.DishCountries");
            DropIndex("dbo.DishIngridients", new[] { "IngridientId" });
            DropIndex("dbo.DishIngridients", new[] { "DishId" });
            DropIndex("dbo.Ingridients", new[] { "Dish_Id" });
            DropIndex("dbo.Dishes", new[] { "dishCountry_Id" });
            DropIndex("dbo.Dishes", new[] { "DishCategoryId" });
            DropIndex("dbo.Continents", new[] { "DishCountry_Id" });
            DropTable("dbo.DishIngridients");
            DropTable("dbo.Ingridients");
            DropTable("dbo.DishCategories");
            DropTable("dbo.Dishes");
            DropTable("dbo.DishCountries");
            DropTable("dbo.Continents");
        }
    }
}
