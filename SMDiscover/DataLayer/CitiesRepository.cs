﻿using DataLayer.models;
using DataLayer.sql_db;
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
        string connectionString = new GlobalVariables().connectionString;

        public List<City> GetAllCities()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM CITIES";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<City> listToReturn = new List<City>();

                while (sqlDataReader.Read())
                {
                    City city = new City();

                    city.CityName = sqlDataReader.GetString(0);
                    city.Country.Name = sqlDataReader.GetString(1);
                    listToReturn.Add(city);

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
                sqlCommand.CommandText = "INSERT INTO CITIES (CITYNAME, COUNTRYNAME) VALUES(" + string.Format(
                    "'{0}', '{1}'", c.CityName, c.Country.Name) + ")";
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
