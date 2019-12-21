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
        public RatingBusiness()
        {
            this.ratingsRepository = new RatingsRepository();
        }
        public List<Rating> GetAllRatings()
        {
            List<Rating> ratings = new List<Rating>();
            return ratings;
            //return this.ratingsRepository.GetAllRatings();

        }
    }
}
