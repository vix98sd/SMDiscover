using DataLayer.models;
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
        private string connectionString = "Data Source=Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMDiscoverDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

                    
                }

                return listToReturn;
            }
        }
       
    }
}
