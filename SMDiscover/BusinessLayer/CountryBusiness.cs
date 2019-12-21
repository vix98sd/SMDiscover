using DataLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CountryBusiness
    {
	private CountriesRepository countriesRepository;
        public CountryBusiness()
        {
            this.countriesRepository = new CountriesRepository();
        }
        public List<Country> GetAllCountires()
        {
            /*List<Country> countries = new List<Country>();
            return countries;*/
            return this.countriesRepository.getAllCountries();
        }
        // Cekam CountriesReSpository ;)
    }
}
