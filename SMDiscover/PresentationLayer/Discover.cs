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
            if(lvDiscover.FocusedItem != null)
            {
                lblDiscover.Text = lvDiscover.FocusedItem.Text;
                foreach(DataLayer.models.ShoppingMall mall in mallsInCity)
                {
                    if (mall.Name == lvDiscover.FocusedItem.Text)
                        ShoppingMall.mall = mall;
                }

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
            
            /*Country c = new Country();
            c.Name = "Argentina";
            countries.Add(c);

            Country c0 = new Country();
            c0.Name = "Pakistan";
            countries.Add(c0);*/
            foreach (Country country in countries)
            {
                cbCountry.Items.Add(country.Name);
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*City c = new City();
            c.CityName = "Patka";
            c.Country.Name = "Argentina";
            City c2 = new City();
            c2.CityName = "Patka2";
            c2.Country.Name = "Pakistan";
            cities.Add(c);
            cities.Add(c2);*/
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
            
            foreach (DataLayer.models.ShoppingMall mall in malls)
            {
                if (mall.City.CityName == cbTown.Text && mall.City.Country.Name == cbCountry.Text)
                {
                    lvDiscover.Items.Add(mall.Name);
                    mallsInCity.Add(mall);
                }

            }
            /*
            for(int i = 0; i < 3; i++)
            lvDiscover.Items.Add("TEST 1 TEST 1 " + i);*/
        }
    }
}
