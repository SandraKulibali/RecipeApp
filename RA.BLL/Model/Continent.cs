using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BLL.Model
{
    public class Continent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DishCountryId { get; set; }
        public DishCountry DishCountry { get; set; }
    }
}
