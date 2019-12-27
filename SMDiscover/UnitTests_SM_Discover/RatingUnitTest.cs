using System;
using System.Transactions;
using BusinessLayer;
using DataLayer.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests_SM_Discover
{
    [TestClass]
    public class RatingUnitTest
    {
        Rating r = new Rating();
        RatingBusiness rb = new RatingBusiness();
        City ci = new City();
        Country co = new Country();
        Shop s = new Shop();
        User u = new User();
        Random rand=new Random();

        public void Init()
        {
            Library_SMD_Test.CreateCountry(ref co);
            Library_SMD_Test.CreateCity(ref ci, co);
            Library_SMD_Test.CreateShop(ref s, ci);
            Library_SMD_Test.CreateUser(ref u);
            Library_SMD_Test.CreateRating(ref r, s, u);
        }


        [TestMethod]
        public void TestInsert()
        {
            using(TransactionScope scope=new TransactionScope())
            {
                Init();

                if (!rb.GetAllRatings().Exists(tmp => tmp.UserId == r.UserId && tmp.ShopId == r.ShopId))
                    Assert.Fail("Rating was not inserted!");
            }
        }

        [TestMethod]
        public void TestDelete()
        {
            using (TransactionScope scope = new TransactionScope()) 
            {
                Init();

                rb.DeleteRating(r.UserId, r.ShopId);
                if (rb.GetAllRatings().Exists(tmp => tmp.UserId == r.UserId && tmp.ShopId == r.ShopId))
                    Assert.Fail("Rating was not deleted!");
            }          
        }

        [TestMethod]
        public void TestUpdate()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                Init();

                r.Rate = rand.Next(1, 5);
                rb.UpdateRating(r);
                if (!rb.GetAllRatings().Exists(tmp => tmp.UserId == r.UserId && tmp.ShopId == r.ShopId && tmp.Rate==r.Rate))
                    Assert.Fail("Rating was not updated!");
            }
        }
    }
}
