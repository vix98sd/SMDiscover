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
    public partial class ShoppingMall : UserControl
    {

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
    }
}
