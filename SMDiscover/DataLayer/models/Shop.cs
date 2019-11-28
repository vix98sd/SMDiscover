using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.models
{
    public class Shop
    {
        public Shop()
        {
            City = new City();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
    }
}
