using System;
using System.Linq;
using BusinessLayer;
using DataLayer.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests_SM_Discover
{
    [TestClass]
    public class UserUnitTest
    {
        User u = new User();
        UserBusiness ub = new UserBusiness();

        [TestInitialize]
        public void Init()
        {
            Library_SMD_Test.CreateUser(ref u);
        }

        [TestMethod]
        public void TestInsert()
        {
            if (!ub.GetAllUsers().Exists(tmp => tmp.Id == u.Id))
                Assert.Fail("User was not inserted!");
        }

        [TestMethod]
        public void TestDelete()
        {
            ub.DeleteUser(u);
            if (ub.GetAllUsers().Exists(tmp => u.Id == tmp.Id))
                Assert.Fail("User was not deleted!");
        }

        [TestMethod]
        public void TestUpdate()
        {
            u.Name=Library_SMD_Test.RandomName(7);
            ub.UpdateUser(u);
            if (!ub.GetAllUsers().Exists(tmp => tmp.Name == u.Name && tmp.Id==u.Id))
                Assert.Fail("User was not updated!");
        }
        [TestCleanup]
        public void CleanUp()
        {
            ub.DeleteUser(u);
        }
    }
}
