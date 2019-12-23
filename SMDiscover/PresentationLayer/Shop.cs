using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.models;

namespace PresentationLayer
{
    public partial class Shop : UserControl
    {
        public DataLayer.models.Shop shop;
        public ShoppingMall ShoppingMall
        {
            get; set;
        }
        public Review Review
        {
            get; set;
        }

        //ShoppingMall BringToFront event
        public Shop()
        {
            InitializeComponent();
            shop = new DataLayer.models.Shop();
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            ShoppingMall?.BringToFront();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            Review.shop = shop;
            Review.SetContent();
            Review?.BringToFront();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            
        }
        public void SetContent()
        {
            lblShop.Text = shop.Name;
            lblValue2.Text = shop.Address + ", "
                           + shop.City.CityName;
            lblValue3.Text = shop.About;

            double sv = 0;
            int counter = 0;
            RatingBusiness ratingBusiness = new RatingBusiness();

            lbReviews.Items.Clear();
            foreach(Rating rating in ratingBusiness.GetAllRatings())
            {
                if(rating.ShopId == shop.Id)
                {
                    lbReviews.Items.Add("Rate: " + rating.Rate + " -> Comment: " + rating.Comment);
                    sv += rating.Rate;
                    counter++;
                }
            }
            
            lblAV.Text = Convert.ToString(Math.Round(sv / counter, 2));
        }
    }
}
