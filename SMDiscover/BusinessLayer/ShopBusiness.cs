using DataLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ShopBusiness
    {
        public List<Shop> GetAllShops()
        {
            /*List<Shop> allShops = new List<Shop>(); // Zameniti sa pozivom fje iz DataLayera, kad bude gotova
            return allShops;*/
            ShopsRepository shopsRepository = new ShopsRepository();
            return shopsRepository.GetAllShops();
        }

        public string InsertShop(Shop shop)
        {
            List<Shop> shops = GetAllShops();
            foreach (Shop s in shops)
                if (s.Name == shop.Name && s.Address == shop.Address && s.City == shop.City)
                    return "Shop already exsists.";

            // Poziv fje iz Data Layera
            ShopsRepository shopsRepository = new ShopsRepository();
            shopsRepository.InsertShop(shop);

            return "Successful insert - shop";
        }

        public string UpdateShop(Shop shop)
        {
            // Poziv fje iz DataLayera
            ShopsRepository shopsRepository = new ShopsRepository();
            

            return "Successful update - shop";
        }

        public string DeleteShop(Shop shop)
        {
            // Poziv fje iz DataLayera
            ShopsRepository shopsRepository = new ShopsRepository();
            shopsRepository.DeleteShop(shop.Id);

            return "Successful delete - shop";
        }

    }
}
