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
            return this.ratingsRepository.GetAllRatings();
        }
        public string InsertRating(Rating rating) 
        {
            if (ratingsRepository.InsertRating(rating) != 0)
                return "Rating successfully inserted!";
            else
                return "Rating was not inserted!";
        }
        public string UpdateRating(Rating rating)
        {
            if (ratingsRepository.UpdateRating(rating) != 0)
                return "Rating successfully deleted!";
            else
                return "Rating was not updated!";
        }
        public string DeleteRating(int Userid, int ShopId)
        {
            if (ratingsRepository.DeleteRating(Userid,ShopId) != 0)
                return "Rating successfully deleted!";
            else
                return "Rating was not deleted!";
        }
    }
}
