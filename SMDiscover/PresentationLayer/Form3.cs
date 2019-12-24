using DataLayer.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer

{
    public partial class Form3 : Form
    {
        public Form3(User user)
        {
            InitializeComponent();
            SidePanel.Height = btnDiscover.Height;
            SidePanel.Top = btnDiscover.Top;
            discover1.BringToFront();
            discover1.ShoppingMall = shoppingMall1;
            shoppingMall1.Discover = discover1;
            shoppingMall1.Shop = shop1;
            shop1.ShoppingMall = shoppingMall1;
            shop1.Review = review1;
            review1.Shop = shop1;

            discover1.ShoppingMall.Shop.Review.User = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDiscover.Height;
            SidePanel.Top = btnDiscover.Top; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEditMall.Height;
            SidePanel.Top = btnEditMall.Top;
            editMall1.BringToFront();
            editUser1.ClearEditUserForm();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEditShop.Height;
            SidePanel.Top = btnEditShop.Top;
            editShop1.BringToFront();
            editUser1.ClearEditUserForm();

        }

        private void forgotPassword1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btnEditUser.Height;
            SidePanel.Top = btnEditUser.Top;
            editUser1.BringToFront();
        }
    }
}
