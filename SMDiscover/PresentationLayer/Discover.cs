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
    public partial class Discover : UserControl
    {

        List<Country> countries;
        List<City> cities;
        List<DataLayer.models.ShoppingMall> malls;
        List<DataLayer.models.ShoppingMall> mallsInCity;

        public ShoppingMall ShoppingMall
        {
            get; set;
        }


        public Discover()
        {
            InitializeComponent();
            countries = new List<Country>();
            cities = new List<City>();
            malls = new List<DataLayer.models.ShoppingMall>();
            mallsInCity = new List<DataLayer.models.ShoppingMall>();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(lbDiscover.SelectedIndex >= 0)
            {
                foreach(DataLayer.models.ShoppingMall mall in mallsInCity)
                {
                    if (mall.Name == lbDiscover.SelectedItem.ToString())
                        ShoppingMall.mall = mall;
                }

                ShoppingMall.SetContent();
                ShoppingMall?.BringToFront();
            }
        }

        private void Discover_Load(object sender, EventArgs e)
        {
            CountryBusiness countryBusiness = new CountryBusiness();
            countries = countryBusiness.GetAllCountires();
            CityBusiness cityBusiness = new CityBusiness();
            cities = cityBusiness.GetAllCities();
            ShoppingMallBusiness shoppingMallBusiness = new ShoppingMallBusiness();
            malls = shoppingMallBusiness.GetAllShoppingMalls();
            
            
            foreach (Country country in countries)
            {
                cbCountry.Items.Add(country.Name);
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTown.Items.Clear();

            foreach (City city in cities)
            {
                if(city.Country.Name == countries[cbCountry.SelectedIndex].Name)
                    cbTown.Items.Add(city.CityName);
            }
        }

        private void cbTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            mallsInCity.Clear();
            lbDiscover.Items.Clear();

            foreach (DataLayer.models.ShoppingMall mall in malls)
            {
                if (mall.City.CityName == cbTown.Text && mall.City.Country.Name == cbCountry.Text)
                {
                    lbDiscover.Items.Add(mall.Name);
                    mallsInCity.Add(mall);
                }

            }
        }
    }
}
