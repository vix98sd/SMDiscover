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
            return this.citiesRepository.GetAllCities();
        }
        public string InsertCity(City city)
        {
            if (citiesRepository.InsertCity(city) != 0)
                return "City successfully inserted!";
            else
                return "City was not inserted!";
        }
        
        // Cekam UpdateCity iz repozitorijuma!
    }
}
