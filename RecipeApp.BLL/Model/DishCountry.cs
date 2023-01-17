using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Model
{
    public class DishCountry
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Continent> ContinentId { get; set; }
    }
}
