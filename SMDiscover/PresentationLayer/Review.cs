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
        public User User { get; set; }
        public Shop Shop
        {
            get; set;
        }
        public Review()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Shop?.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RatingBusiness ratingBusiness = new RatingBusiness();
            Rating rating = new Rating();
        }
    }
}
