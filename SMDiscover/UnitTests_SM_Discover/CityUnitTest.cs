using System;
using System.Transactions;
using BusinessLayer;
using DataLayer.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests_SM_Discover
{
    [TestClass]
    public class CityUnitTest
    {   
        [TestMethod]
        public void TestInsert()
        {
            using (var scope = new TransactionScope())
            {
                City c = new City();
                CityBusiness cb = new CityBusiness();
                Country co = new Country();
                Library_SMD_Test.CreateCountry(ref co);
                Library_SMD_Test.CreateCity(ref c, co);
                if (!cb.GetAllCities().Exists(tmp => tmp.CityName == c.CityName && tmp.Country.Name == c.Country.Name))
                    Assert.Fail("Country was not inserted!");
            }
            
        }
    }
}
