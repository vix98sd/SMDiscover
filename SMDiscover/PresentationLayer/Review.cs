using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.models;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Review : UserControl
    {
        public DataLayer.models.Shop shop;
        private RatingBusiness ratingBusiness;
        private List<Rating> ratings;
        private bool alreadyRated;

        public User User { get; set; }
        public Shop Shop
        {
            get; set;
        }
        public Review()
        {
            InitializeComponent();
            shop = new DataLayer.models.Shop();
            ratingBusiness = new RatingBusiness();
            ratings = new List<Rating>();
            alreadyRated = false;
            this.User = new User();
            SetContent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Shop?.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            rating.Rate = trackBarRating.Value;
            rating.Comment = string.IsNullOrEmpty(tbReview.Text) ? "/" : tbReview.Text;
            rating.UserId = User.Id;
            rating.ShopId = shop.Id;

            if (!alreadyRated)
            {
                ratingBusiness.InsertRating(rating);
            }
            else
            {
                ratingBusiness.UpdateRating(rating);
            }

        }

        public void SetContent()
        {
            ratings = ratingBusiness.GetAllRatings();

            foreach(Rating rating in ratings)
            {
                if(rating.UserId == User.Id && rating.ShopId == shop.Id)
                {
                    trackBarRating.Value = rating.Rate;
                    tbReview.Text = rating.Comment;
                    alreadyRated = true;
                    break;
                }
            }
        }
    }
}
