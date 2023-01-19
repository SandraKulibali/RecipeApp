﻿using RA.BLL.BLL;
using RA.BLL.Model;
using System.Data.Entity;

namespace RA.BLL
{
    public class DataContext: DbContext
    {
        public DataContext() : base("Data Source=223-12;Initial Catalog = RecipeApp;Trusted_Connection=true")
        { }
        public DbSet<Dish> Dish { get; set; }   
        public DbSet<DishCategory> dishCategories { get; set; }
        public DbSet<DishCountry> dishCountries { get; set; }
        public DbSet<Continent> continents { get; set; }
        public DbSet<Ingridient> ingridients { get; set; }
        public DbSet<DishIngridient> dishIngridients { get; set; }
    }
}
