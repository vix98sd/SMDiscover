using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.models;

namespace PresentationLayer
{
    public partial class EditMall : UserControl
    {
        private ShoppingMallBusiness shoppingMallBusiness;
        private CountryBusiness countryBusiness;
        private CityBusiness cityBusiness;
        private List<DataLayer.models.ShoppingMall> shoppingMalls;
        private List<Country> countries;
        private List<City> cities;

        public EditMall()
        {
            InitializeComponent();
            shoppingMallBusiness = new ShoppingMallBusiness();
            countryBusiness = new CountryBusiness();
            cityBusiness = new CityBusiness();
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
                DataLayer.models.ShoppingMall shoppingMall = shoppingMalls[cbSelect.SelectedIndex - 1];
                tbName.Text = shoppingMall.Name;
                tbLocation.Text = shoppingMall.Address;
                tbAbout.Text = shoppingMall.About;
                tbImage.Text = shoppingMall.Image;
                tbOpen.Text = shoppingMall.HoursO;
                tbClose.Text = shoppingMall.HoursC;

                cbCountry.Text = shoppingMall.City.Country.Name;
                cbTown.Text = shoppingMall.City.CityName;
            }
            else
            {
                MessageBox.Show("Select mall first!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cbSelect.SelectedIndex > 0)
            {
                MessageBox.Show(shoppingMallBusiness.DeleteShoppingMall(shoppingMalls[cbSelect.SelectedIndex - 1]));
                SetContent();
            }
            else
            {
                MessageBox.Show("Select mall first!");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(tbName.Text == "" || tbLocation.Text == "" || tbAbout.Text == "" ||
               tbImage.Text == "" || tbOpen.Text == "" || tbClose.Text == "" ||
               cbSelect.SelectedIndex < 0 || cbCountry.SelectedIndex < 0 || cbTown.SelectedIndex < 0 || 
               !int.TryParse(tbOpen.Text, out int n) || !int.TryParse(tbClose.Text, out int nn))
            {
                MessageBox.Show("Fill all fields, and select all values!");
            }
            else if(cbSelect.Text == "Add new mall")
            {
                DataLayer.models.ShoppingMall mall = new DataLayer.models.ShoppingMall();
                mall.Name = tbName.Text;
                mall.Address = tbLocation.Text;
                mall.About = tbAbout.Text;
                mall.Image = tbImage.Text;
                mall.HoursO = tbOpen.Text;
                mall.HoursC = tbClose.Text;
                mall.City.Country.Name = cbCountry.Text;
                mall.City.CityName = cbTown.Text;

                MessageBox.Show(shoppingMallBusiness.InsertShoppingMall(mall));
                SetContent();
            }
            else
            {
                MessageBox.Show(shoppingMallBusiness.UpdateShoppingMall(shoppingMalls[cbSelect.SelectedIndex - 1]));
            }
        }

        public void SetContent()
        {
            ClearAll();
            FillCbSelect();
            FillCbCountries();
            FillCbCities();
        }

        private void ClearAll()
        {
            tbName.Text = "";
            tbLocation.Text = "";
            tbAbout.Text = "";
            tbImage.Text = "";
            tbOpen.Text = "";
            tbClose.Text = "";
        }

        private void FillCbSelect()
        {
            cbSelect.Text = "";
            cbSelect.Items.Clear();

            shoppingMalls = shoppingMallBusiness.GetAllShoppingMalls();
            cbSelect.Items.Add("Add new mall");

            foreach (DataLayer.models.ShoppingMall shoppingMall in shoppingMalls)
            {
                cbSelect.Items.Add(shoppingMall.Name);
            }
            
        }
        
        private void FillCbCountries()
        {
            cbCountry.Text = "";
            cbCountry.Items.Clear();

            countries = countryBusiness.GetAllCountires();
            
            foreach(Country country in countries)
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
                if(city.Country.Name == country.Name)
                    cbTown.Items.Add(city.CityName);
            }
        }
        
    }
}
