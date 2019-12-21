using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CitiesRepository
    {
        private string connectionString = "Data Source=Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMDiscoverDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<City> GetAllCities()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Cities";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<City> listToReturn = new List<City>();

                while (sqlDataReader.Read())
                {
                    City city = new City();
                    Country country = new Country();

                    city.CityName = sqlDataReader.GetString(0);
                    country.Name = sqlDataReader.GetString(1);
                    city.Country = country;
                }

                return listToReturn;
            }
        }
        public int InsertCity(City c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO CITIES (CityName, CountryName) VALUES(" + string.Format(
                    "'{0}', '{1}'", c.CityName, c.Country.Name) + ")";
                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteCity(string name)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DELETE FROM CITIES WHERE CityName = " + name;

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
