using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ShoppingMallsRepository
    {
        // Vanja:
        //private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataBaseSMD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Laki:
        //private string connectionString = "Data Source=Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMDiscoverDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Miki:
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMDiscover;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public List<ShoppingMall> GetAllShoppingMalls()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM SHOPPING_MALLS";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<ShoppingMall> listToReturn = new List<ShoppingMall>();

                while (sqlDataReader.Read())
                {
                    ShoppingMall shoppingMall = new ShoppingMall();

                    shoppingMall.Id = sqlDataReader.GetInt32(0);
                    shoppingMall.Name = sqlDataReader.GetString(1);
                    shoppingMall.Address = sqlDataReader.GetString(2);
                    shoppingMall.About = sqlDataReader.GetString(3);
                    shoppingMall.Image = sqlDataReader.GetString(4);
                    shoppingMall.HoursO = sqlDataReader.GetString(5);
                    shoppingMall.HoursC = sqlDataReader.GetString(6);
                    shoppingMall.City.Country.Name = sqlDataReader.GetString(7);
                    shoppingMall.City.CityName = sqlDataReader.GetString(8);

                    listToReturn.Add(shoppingMall);
                }

                return listToReturn;
            }
        }
        public int InsertShoppingMall(ShoppingMall shoppingMall)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO SHOPPING_MALLS (NAME, ADDRESS, ABOUT, IMAGE, HOURSOPEN, HOURSCLOSED, COUNTRYNAME, CITYNAME) VALUES(" + string.Format(
                    "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}'", shoppingMall.Name, shoppingMall.Address, shoppingMall.About, shoppingMall.Image, shoppingMall.HoursO,
                    shoppingMall.HoursC, shoppingMall.City.Country.Name, shoppingMall.City.CityName) + ")";

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteShoppingMall(int smID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                int countExecuteNonQuery = 0;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DELETE FROM SM_SHOP WHERE ID_SM = " + smID;
                countExecuteNonQuery += sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "DELETE FROM SHOPPING_MALLS WHERE ID_SM = " + smID;
                countExecuteNonQuery += sqlCommand.ExecuteNonQuery();

                return countExecuteNonQuery;
            }
        }
    }
}
