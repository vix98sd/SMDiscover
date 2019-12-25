using System;
using System.Transactions;
using BusinessLayer;
using DataLayer.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests_SM_Discover
{
    [TestClass]
    public class ShopUnitTest
    {
        Shop s = new Shop();
        Country co = new Country();
        City ci = new City();
        ShopBusiness sb = new ShopBusiness();

        public void Init()
        {
            Library_SMD_Test.CreateCountry(ref co);
            Library_SMD_Test.CreateCity(ref ci, co);
            Library_SMD_Test.CreateShop(ref s, ci);
        }

        [TestMethod]
        public void TestInsert()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Init();

                if (!sb.GetAllShops().Exists(tmp => tmp.Id == s.Id))
                    Assert.Fail("Shop was not inserted!");
            }
        }

        [TestMethod]
        public void TestDelete()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Init();

                sb.DeleteShop(s);
                if (sb.GetAllShops().Exists(tmp => tmp.Id == s.Id))
                    Assert.Fail("Shop was not deleted!");
            }
        }

        [TestMethod]
        public void TestUpdate()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Init();

                s.Name = Library_SMD_Test.RandomName(8);
                sb.UpdateShop(s);
                if (!sb.GetAllShops().Exists(tmp => tmp.Id == s.Id && tmp.Name==s.Name))
                    Assert.Fail("Shop was not updated!");
            }
        }
    }
}
