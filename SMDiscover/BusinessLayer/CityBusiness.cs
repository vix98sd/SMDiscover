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
	private CitiesRepository CitiesRepository;
        public CityBusiness()
        {
            this.citiesRepository = new CitiesRepository();
        }
        public List<City> GetAllCities()
        {
            return this.citiesRepository.GetAllCities();
        }
    }
}
