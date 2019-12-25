using System;
using System.Transactions;
using BusinessLayer;
using DataLayer.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests_SM_Discover
{
    
    [TestClass]
    public class SMShopUnitTest
    {
        Shop s = new Shop();
        ShoppingMall sm = new ShoppingMall();
        Country co = new Country();
        City ci = new City();
        SMShop sms = new SMShop();
        SMShopBusiness smsb = new SMShopBusiness();

        public void Init()
        {
            Library_SMD_Test.CreateCountry(ref co);
            Library_SMD_Test.CreateCity(ref ci,co);
            Library_SMD_Test.CreateShop(ref s, ci);
            Library_SMD_Test.CreateShoppingMall(ref sm, ci);
            Library_SMD_Test.CreateSMShop(ref sms, s, sm);
        }

        [TestMethod]
        public void TestInsert()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Init();

                if (!smsb.GetAllSMShops().Exists(tmp => tmp.ShopId == sms.ShopId && tmp.SMId == sms.SMId))
                    Assert.Fail("SMShop was not inserted!");
            }
        }

        [TestMethod]
        public void TestDelete()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Init();

                smsb.DeleteShop(sms);
                if (smsb.GetAllSMShops().Exists(tmp => tmp.ShopId == sms.ShopId && tmp.SMId == sms.SMId && tmp.No==sms.No))
                    Assert.Fail("SMShop was not inserted!");
            }
        }

        [TestMethod]
        public void TestUpdate()
        {
            // Nemam update funkciju
        }
    }
}
