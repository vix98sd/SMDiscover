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
    public partial class Discover : UserControl
    {

        public ShoppingMall ShoppingMall
        {
            get; set;
        }


        public Discover()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShoppingMall?.BringToFront();
        }
    }
}
