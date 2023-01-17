using RecipeApp.Model;
using System.Data.Entity;

namespace RecipeApp
{
    public class DataContext: DbContext
    {
        public DataContext() : base("DefaultConnection")
        { }
        public DbSet<Dish> Dish { get; set; }   
        public DbSet<DishCategory> dishCategories { get; set; }
        public DbSet<DishCountry> dishCountries { get; set; }
        public DbSet<Continent> continents { get; set; }
        public DbSet<Ingridient> ingridients { get; set; }
        public DbSet<DishIngridient> dishIngridients { get; set; }
    }
}
