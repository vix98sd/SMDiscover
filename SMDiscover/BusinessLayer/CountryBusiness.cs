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
	private CountiresRepository countiresRepository;
        public CountryBusiness()
        {
            this.countriesRepository = new CountriesRepository();
        }
        public List<Country> GetAllCountires()
        {
            return this.countriesRepository.GetAllCountires();
        }
    }
}
