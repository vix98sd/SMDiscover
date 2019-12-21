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
    public partial class Form2 : Form
    {
        public Form2()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDiscover.Height;
            SidePanel.Top = btnDiscover.Top;
            discover1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAbout.Height;
            SidePanel.Top = btnAbout.Top;
            about1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
