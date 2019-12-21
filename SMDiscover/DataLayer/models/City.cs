using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.models
{
    public class City
    {
        public City()
        {
            Country = new Country();
        }

        public string CityName { get; set; }
        public Country Country { get; set; }
    }
}
