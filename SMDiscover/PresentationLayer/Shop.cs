using System;
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
    public partial class Shop : UserControl
    {
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
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            ShoppingMall?.BringToFront();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            Review?.BringToFront();
        }
    }
}
