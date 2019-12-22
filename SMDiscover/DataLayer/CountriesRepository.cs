using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CountriesRepository
    {
        // Vanja:
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataBaseSMD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Laki:
        //private string connectionString = "Data Source=Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMDiscoverDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Country> getAllCountries()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM COUNTRIES";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<Country> listToReturn = new List<Country>();

                while(sqlDataReader.Read())
                {
                    Country country = new Country();

                    country.Name = sqlDataReader.GetString(0);

                    listToReturn.Add(country);
                }

                return listToReturn;
            }
        }

        public int insertCoutry(Country country)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO COUTRIES (COUNTRYNAME) VALUES (" + string.Format(
                    "'{0}'", country.Name) + ");";

                return sqlCommand.ExecuteNonQuery();
            }
        }

    }
}
