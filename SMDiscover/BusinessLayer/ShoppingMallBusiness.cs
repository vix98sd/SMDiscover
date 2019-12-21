using DataLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ShoppingMallBusiness
    {
        public List<ShoppingMall> GetAllShoppingMalls()
        {
            ShoppingMallsRepository shoppingMallsRepository = new ShoppingMallsRepository();
            List<ShoppingMall> allShoppingMalls = shoppingMallsRepository.GetAllShoppingMalls();

            //List<ShoppingMall> allShoppingMalls = new List<ShoppingMall>(); // Zameniti sa pozivom fje iz DataLayera, kad bude gotova

            allShoppingMalls = SetShops(allShoppingMalls);

            return allShoppingMalls;
        }

        public string InsertShoppingMall(ShoppingMall shoppingMall)
        {
            List<ShoppingMall> shoppingMalls = GetAllShoppingMalls();
            foreach (ShoppingMall s in shoppingMalls)
                if (s.Name == shoppingMall.Name && s.Address == shoppingMall.Address && s.City == shoppingMall.City)
                    return "Shopping Mall already exsists.";

            // Poziv fje iz Data Layera

            return "Successful insert - shopping mall";
        }

        public string UpdateShoppingMall(ShoppingMall shoppingMall)
        {
            // Poziv fje iz DataLayera

            return "Successful update - shopping mall";
        }

        public string DeleteShoppingMall(ShoppingMall shoppingMall)
        {
            // Poziv fje iz DataLayera

            return "Successful udelete - shopping mall";
        }

        // Metoda vrsi postavljanje Shopova u Shopping mallove
        private List<ShoppingMall> SetShops(List<ShoppingMall> shoppingMalls)
        {
            SMShopBusiness sMShopBusiness = new SMShopBusiness();

            shoppingMalls = sMShopBusiness.SetShops(shoppingMalls);

            return shoppingMalls;
        }

    }
}
