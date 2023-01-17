using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Model
{
    public class DishIngridient
    {
        public Guid ID { get; set; }
        public Guid DishId { get; set; }
        public Dish Dish { get; set; }
        public Guid IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
    }
}
