using DataLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CityBusiness
    {
	private CitiesRepository citiesRepository;
        public CityBusiness()
        {
            this.citiesRepository = new CitiesRepository();
        }
        public List<City> GetAllCities()
        {
            List<City> cities = new List<City>();
            return cities;
         //   return this.citiesRepository.GetAllCities();
        }
    }
}
