using DataLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RatingBusiness
    {
        private RatingsRepository ratingsRepository;
        public CountriesBusiness()
        {
            this.ratingsRepository = new RatingsRepository();
        }
        public List<Rating> GetAllRatings()
        {
            return this.ratingsRepository.GetAllRatings();
        }
    }
}
