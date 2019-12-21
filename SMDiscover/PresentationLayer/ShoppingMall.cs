﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ShoppingMall : UserControl
    {
        public DataLayer.models.ShoppingMall mall;
        public Discover Discover
        {
            get; set;
        }

        public Shop Shop
        {
            get; set;
        }
        public ShoppingMall()
        {
            InitializeComponent();
            mall = new DataLayer.models.ShoppingMall();
        }

        //shop BringToFront event
        private void btnRecovery_Click(object sender, EventArgs e)
        {
            Discover?.BringToFront();
        }

        private void btnToBeRemoved_Click(object sender, EventArgs e)
        {
            Shop?.BringToFront();
        }

        private void ShoppingMall_Load(object sender, EventArgs e)
        {
            lblTitle.Text = mall.Name;
            lblValue1.Text = mall.HoursO + " - " + mall.HoursC;
            lblValue2.Text = mall.Address;
            lblValue3.Text = mall.About;

            foreach(DataLayer.models.Shop shop in mall.Shops)
            {
                lvShops.Items.Add(shop.Name);
            }
        }
    }
}
