using DataLayer.models;
using DataLayer.sql_db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ShopsRepository
    {
        string connectionString = new GlobalVariables().connectionString;
        
        public List<Shop> GetAllShops()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM SHOPS";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<Shop> listToReturn = new List<Shop>();

                while (sqlDataReader.Read())
                {
                    Shop shop = new Shop();

                    shop.Id = sqlDataReader.GetInt32(0);
                    shop.Name = sqlDataReader.GetString(1);
                    shop.Address = sqlDataReader.GetString(2);
                    shop.About = sqlDataReader.GetString(3);
                    shop.Image = sqlDataReader.GetString(4);
                    shop.City.Country.Name = sqlDataReader.GetString(5);
                    shop.City.CityName = sqlDataReader.GetString(6);

                    listToReturn.Add(shop);
                }

                return listToReturn;
            }
        }

        public int InsertShop(Shop shop)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO SHOPS (NAME, ADDRESS, ABOUT, IMAGE, COUNTRYNAME, CITYNAME) VALUES(" + string.Format(
                    "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}'", shop.Name, shop.Address, shop.About, shop.Image, shop.City.Country, shop.City.CityName) + ")";
                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteShop(int shopID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                int countExecuteNonQuery = 0;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DELETE FROM SHOPS WHERE ID_SHOP = " + shopID;
                countExecuteNonQuery += sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "DELETE FROM SHOPS WHERE ID_SHOP = " + shopID;
                countExecuteNonQuery += sqlCommand.ExecuteNonQuery();

                return countExecuteNonQuery;
            }
        }

    }
}
