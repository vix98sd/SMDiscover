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
    public class SMShopsRepository
    {

        string connectionString = new GlobalVariables().connectionString;
            public List<SMShop> GetAllSMShops()
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM SM_SHOP";

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    List<SMShop> listToReturn = new List<SMShop>();

                    while (sqlDataReader.Read())
                    {
                        SMShop sMShop = new SMShop();

                        sMShop.No = sqlDataReader.GetInt32(0);
                        sMShop.SMId = sqlDataReader.GetInt32(1);
                        sMShop.ShopId = sqlDataReader.GetInt32(2);

                        listToReturn.Add(sMShop);
                    }

                    return listToReturn;
                }
            }
            public int InsertSMShop(SMShop sMShop)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "INSERT INTO SM_SHOP (ID_SM, ID_Shop) VALUES(" + string.Format(
                        "{0}, {1}", sMShop.SMId, sMShop.ShopId) + ")";
                    return sqlCommand.ExecuteNonQuery();
                }
            }

            public int DeleteSMShop(int no)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM SM_SHOP WHERE No = " + no;

                    return sqlCommand.ExecuteNonQuery();
                }
            }
    }
}
