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
    public class CountriesRepository
    {
        string connectionString = new GlobalVariables().connectionString;
        
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

        public int InsertCoutry(Country country)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO COUNTRIES (COUNTRYNAME) VALUES (" + string.Format(
                    "'{0}'", country.Name) + ");";

                return sqlCommand.ExecuteNonQuery();
            }
        }

    }
}
