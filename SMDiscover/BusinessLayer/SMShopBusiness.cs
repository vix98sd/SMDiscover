using DataLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SMShopBusiness
    {
        public List<SMShop> GetAllSMShops()
        {
            /*List<SMShop> allSMShops = new List<SMShop>(); // Zameniti sa pozivom fje iz DataLayera, kad bude gotova
            return allSMShops;*/
            SMShopsRepository sMShopsRepository = new SMShopsRepository();
            return sMShopsRepository.GetAllSMShops();
        }

        public string InsertShopInMall (SMShop shop)
        {
            List<SMShop> sMShops = GetAllSMShops();
            foreach (SMShop s in sMShops)
                if (s.ShopId == shop.ShopId && s.SMId == shop.SMId)
                    return "Shop already exsists ih this shopping mall.";

            // Poziv fje iz Data Layera
            SMShopsRepository sMShopsRepository = new SMShopsRepository();
            sMShopsRepository.InsertSMShop(shop);

            return "Successful insert - shop in shopping mall";
        }

        public string DeleteShopFromMall(SMShop shop)
        {
            // Poziv fje iz DataLayera

            return "Successful delete - shop from mall";
        }

        // Metoda u listu Shopping Mallova dodaje listu Shopova
        // koji se nalaze unutar njih
        public List<ShoppingMall> SetShops(List<ShoppingMall> shoppingMalls)
        {
            List<SMShop> sMShops = GetAllSMShops();
            ShopBusiness shopBusiness = new ShopBusiness();
            List<Shop> shops = shopBusiness.GetAllShops();

            for (int i = 0; i < shoppingMalls.Count; i++)
                foreach (SMShop sMShop in sMShops)
                    if (sMShop.SMId == shoppingMalls[i].Id)
                        foreach (Shop shop in shops)
                            if (sMShop.ShopId == shop.Id)
                                shoppingMalls[i].Shops.Add(shop);

            return shoppingMalls;
        }
    }
}
