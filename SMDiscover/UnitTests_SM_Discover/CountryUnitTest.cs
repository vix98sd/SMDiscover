using System;
using System.Transactions;
using BusinessLayer;
using DataLayer.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests_SM_Discover
{
    [TestClass]
    public class CountryUnitTest
    {
        [TestMethod]
        public void TestInsert()
        {
            using (var scope = new TransactionScope())
            {
                CountryBusiness cb = new CountryBusiness();
                Country c = new Country();
                Library_SMD_Test.CreateCountry(ref c);
                
                if (!cb.GetAllCountires().Exists(tmp => tmp.Name == c.Name))
                    Assert.Fail("Country was not inserted!");
            }

        }
    }
}
