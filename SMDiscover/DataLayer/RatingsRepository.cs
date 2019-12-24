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
    public class RatingsRepository
    {
        string connectionString = new GlobalVariables().connectionString;
        
        public List<Rating> GetAllRatings()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM RATINGS";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<Rating> listToReturn = new List<Rating>();

                while (sqlDataReader.Read())
                {
                    Rating rating = new Rating();

                    rating.UserId = sqlDataReader.GetInt32(0);
                    rating.ShopId = sqlDataReader.GetInt32(1);
                    rating.Rate = sqlDataReader.GetInt32(2);
                    rating.Comment = sqlDataReader.GetString(3);

                    listToReturn.Add(rating);
                }

                return listToReturn;
            }
        }
        public int InsertRating(Rating rating)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO RATINGS (ID_USER, ID_SHOP, RATE, COMMENT) VALUES(" + string.Format(
                    "{0}, {1}, {2}, '{3}'", rating.UserId, rating.ShopId, rating.Rate, rating.Comment) + ")";

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int UpdateRating(Rating rating)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "UPDATE RATINGS SET RATE = '" + rating.Rate +
                    "', COMMENT = '" + rating.Comment + "' WHERE ID_USER = " + rating.UserId + " AND ID_SHOP = " + rating.ShopId;

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteRating(int userID, int shopID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DELETE FROM RATINGS WHERE ID_USER = " + userID + " AND ID_SHOP = " + shopID;

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
