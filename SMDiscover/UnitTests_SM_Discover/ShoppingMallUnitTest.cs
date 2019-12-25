using System;
using System.Transactions;
using BusinessLayer;
using DataLayer.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests_SM_Discover
{
    [TestClass]
    public class ShoppingMallUnitTest
    {
        ShoppingMall sm = new ShoppingMall();
        ShoppingMallBusiness smb = new ShoppingMallBusiness();
        Country co = new Country();
        City ci = new City();

        public void Init()
        {
            Library_SMD_Test.CreateCountry(ref co);
            Library_SMD_Test.CreateCity(ref ci, co);
            Library_SMD_Test.CreateShoppingMall(ref sm, ci);
        }

        [TestMethod]
        public void TestInsert()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Init();

                if (!smb.GetAllShoppingMalls().Exists(tmp => tmp.Id == sm.Id))
                    Assert.Fail("Shop was not inserted!");
            }
        }

        [TestMethod]
        public void TestDelete()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Init();

                smb.DeleteShoppingMall(sm);
                if (smb.GetAllShoppingMalls().Exists(tmp => tmp.Id == sm.Id))
                    Assert.Fail("Shop was not inserted!");
            }
        }

        [TestMethod]
        public void TestUpdate()
        {
            // Treba mi update funkcija iz data layera!!!
        }
    }
}
