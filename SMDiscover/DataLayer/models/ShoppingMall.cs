using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.models
{
    public class ShoppingMall
    {
        public ShoppingMall()
        {
            City = new City();
            Shops = new List<Shop>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public string Image { get; set; }
        public string HoursO { get; set; }
        public string HoursC { get; set; }

        public List<Shop> Shops { get; set; }
    }
}
