using RA.BLL.Model;
using System;
using System.Collections.Generic;

namespace RA.BLL.BLL
{
    public class Dish
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public Guid DishCategoryId { get; set; }
        public DishCategory dishCategory { get; set; }
        public Guid DishCounryId { get; set; }
        public DishCountry dishCountry { get; set; }
        public ICollection<Ingridient> ingridients { get; set; }

    }
}