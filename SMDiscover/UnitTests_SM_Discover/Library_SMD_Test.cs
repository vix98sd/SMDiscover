using BusinessLayer;
using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests_SM_Discover
{
    public static class Library_SMD_Test
    {
        static Random random = new Random();
        public static void CreateUser(ref User u)
        {
            u.Name = RandomName(6);
            u.Username = RandomName(6);
            u.Password = RandomPasswd();
            u.Surname = RandomName(7);
            u.SecretQuestion = RandomSecQuestion();
            u.Email = RandomEmail();
            u.Answer = RandomName(8);
            UserBusiness ub = new UserBusiness();
            ub.InsertUser(u);
            string name = u.Name;
            u.Id = ub.GetAllUsers().Where(tmp => tmp.Name == name).ToList()[0].Id;
        }

        public static void CreateCountry(ref Country c)
        {
            c.Name = RandomName(7);
            CountryBusiness cb = new CountryBusiness();
        }

        public static void CreateCity(ref City c, Country country)
        {
            c.CityName = RandomName(6);
            c.Country = country;
            CityBusiness cb = new CityBusiness();
            cb.InsertCity(c);
        }

        public static void CreateShop(ref Shop s, City c)
        {
            s.Name = RandomName(6);
            s.Image = ".";
            s.About= RandomName(6);
            s.Address= RandomName(6) + " " + random.Next(10);
            s.City = c;
            ShopBusiness sb = new ShopBusiness();
            sb.InsertShop(s);
            string name = s.Name;
            s.Id = sb.GetAllShops().Where(tmp => tmp.Name == name).ToList()[0].Id;
        }

        public static void CreateShoppingMall(ref ShoppingMall sm, City c)
        {
            sm.About= RandomName(6);
            sm.Address= RandomName(6) + " " + random.Next(10);
            sm.City = c;
            sm.HoursO = "08:00";
            sm.HoursC = "23:00";
            sm.Image = ".";
            sm.Name = RandomName(5);
            ShoppingMallBusiness smb = new ShoppingMallBusiness();
            smb.InsertShoppingMall(sm);
            string name = sm.Name;
            sm.Id = smb.GetAllShoppingMalls().Where(tmp => tmp.Name == name).ToList()[0].Id;
        }

        public static void CreateSMShop(ref SMShop sms,Shop s, ShoppingMall sm)
        {
            sms.ShopId = s.Id;
            sms.SMId = sm.Id;
            SMShopBusiness smsb = new SMShopBusiness();
            smsb.InsertShopInMall(sms);
        }

        public static void CreateRating(ref Rating r, Shop s, User u)
        {
            r.Comment = RandomName(20);
            r.Rate = random.Next(5);
            r.ShopId = s.Id;
            r.UserId = u.Id;
            RatingBusiness rb = new RatingBusiness();
            rb.InsertRating(r);
        }

        private static string RandomPasswd()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static string RandomName(int n)
        {
            const string charsUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string charsLower = "abcdefghijklmnopqrstuvwxyz";
            return charsUpper[random.Next(25)] + new string(Enumerable.Repeat(charsLower, n).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static string RandomSecQuestion()
        {
            string[] SecQuestions =
            {
                "What Is your favorite book?",
                "What was the name of your first/current/favorite pet?",
                "Where did you go to high school/college?",
                "What city were you born in?",
                "What was your favorite sport in high school?",
                "What is your favorite movie?"
            };

            return SecQuestions[random.Next(4)];
        }

        private static string RandomEmail()
        {
            const string charsLower = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(charsLower, 6).Select(s => s[random.Next(s.Length)]).ToArray()) + "@"
                + new string(Enumerable.Repeat(charsLower, 4).Select(s => s[random.Next(s.Length)]).ToArray()) + "."
                + new string(Enumerable.Repeat(charsLower, 3).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
