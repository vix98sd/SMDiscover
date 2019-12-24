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
    public partial class EditShop : UserControl
    {
        private ShopBusiness shopBusiness;
        private ShoppingMallBusiness shoppingMallBusiness;
        private CountryBusiness countryBusiness;
        private CityBusiness cityBusiness;
        private SMShopBusiness sMShopBusiness;
        private List<DataLayer.models.Shop> shops;
        private List<DataLayer.models.ShoppingMall> shoppingMalls;
        private List<Country> countries;
        private List<City> cities;

        public EditShop()
        {
            InitializeComponent();
            shopBusiness = new ShopBusiness();
            shoppingMallBusiness = new ShoppingMallBusiness();
            countryBusiness = new CountryBusiness();
            cityBusiness = new CityBusiness();
            sMShopBusiness = new SMShopBusiness();
            shops = new List<DataLayer.models.Shop>();
            shoppingMalls = new List<DataLayer.models.ShoppingMall>();
            countries = new List<Country>();
            cities = new List<City>();
        }


        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();
            FillCbCountries();
            FillCbCities();
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country country = new Country();
            country.Name = cbCountry.Text;
            FillCbCities(country);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSelect.SelectedIndex > 0)
            {
                DataLayer.models.Shop shop = shops[cbSelect.SelectedIndex - 1];
                tbName.Text = shop.Name;
                tbLocation.Text = shop.Address;
                tbAbout.Text = shop.About;
                tbImage.Text = shop.Image;
                
                cbCountry.Text = shop.City.Country.Name;
                cbTown.Text = shop.City.CityName;
            }
            else
            {
                MessageBox.Show("Select shop first!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbSelect.SelectedIndex > 0)
            {
                MessageBox.Show(shopBusiness.DeleteShop(shops[cbSelect.SelectedIndex - 1]));
                SetContent();
            }
            else
            {
                MessageBox.Show("Select shop first!");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbLocation.Text == "" || 
                tbAbout.Text == "" || tbImage.Text == "" ||
                cbSelect.SelectedIndex < 0 || cbCountry.SelectedIndex < 0 || cbTown.SelectedIndex < 0)
            {
                MessageBox.Show("Fill all fields, and select all values!");
            }
            else if (cbSelect.Text == "Add new shop")
            {
                DataLayer.models.Shop shop = new DataLayer.models.Shop();
                shop.Name = tbName.Text;
                shop.Address = tbLocation.Text;
                shop.About = tbAbout.Text;
                shop.Image = tbImage.Text;
                shop.City.Country.Name = cbCountry.Text;
                shop.City.CityName = cbTown.Text;

                MessageBox.Show(shopBusiness.InsertShop(shop));
                SetContent();
            }
            else
            {
                MessageBox.Show(shopBusiness.UpdateShop(shops[cbSelect.SelectedIndex - 1]));
            }
        }



        public void SetContent()
        {
            ClearAll();
            FillCbSelect();
            FillCbCountries();
            FillCbCities();
            FillCbMall();
        }

        private void ClearAll()
        {
            tbName.Text = "";
            tbLocation.Text = "";
            tbAbout.Text = "";
            tbImage.Text = "";
        }

        private void FillCbSelect()
        {
            cbSelect.Text = "";
            cbSelect.Items.Clear();
            cbShop.Text = "";
            cbShop.Items.Clear();

            shops = shopBusiness.GetAllShops();
            cbSelect.Items.Add("Add new shop");

            foreach (DataLayer.models.Shop shop in shops)
            {
                cbSelect.Items.Add(shop.Name);
                cbShop.Items.Add(shop.Name);
            }

        }

        private void FillCbCountries()
        {
            cbCountry.Text = "";
            cbCountry.Items.Clear();

            countries = countryBusiness.GetAllCountires();

            foreach (Country country in countries)
            {
                cbCountry.Items.Add(country.Name);
            }
        }

        private void FillCbCities()
        {
            cbTown.Text = "";
            cbTown.Items.Clear();

            cities = cityBusiness.GetAllCities();

            foreach (City city in cities)
            {
                cbTown.Items.Add(city.CityName);
            }
        }

        private void FillCbCities(Country country)
        {
            cbTown.Text = "";
            cbTown.Items.Clear();

            foreach (City city in cities)
            {
                if (city.Country.Name == country.Name)
                    cbTown.Items.Add(city.CityName);
            }
        }

        private void FillCbMall()
        {
            cbMall.Text = "";
            cbMall.Items.Clear();

            shoppingMalls = shoppingMallBusiness.GetAllShoppingMalls();

            foreach (DataLayer.models.ShoppingMall shoppingMall in shoppingMalls)
            {
                cbMall.Items.Add(shoppingMall.Name);
            }

        }

        private void btnSaveSMShop_Click(object sender, EventArgs e)
        {
            if(cbMall.SelectedIndex >= 0 && cbShop.SelectedIndex >= 0)
            {
                SMShop sMShop = new SMShop();
                sMShop.ShopId = shops[cbShop.SelectedIndex].Id;
                sMShop.SMId = shoppingMalls[cbMall.SelectedIndex].Id;

                MessageBox.Show(sMShopBusiness.InsertShopInMall(sMShop));
            }
            else
            {
                MessageBox.Show("Select mall and shop!");
            }
        }
    }
}
