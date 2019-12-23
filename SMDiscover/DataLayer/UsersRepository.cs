using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UsersRepository
    {
        // Vanja:
        //private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SMDiscoverDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Laki:
        //private string connectionString = "Data Source=Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMDiscoverDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SMDiscoverDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<User> GetAllUsers()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM USERS";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<User> listToReturn = new List<User>();

                while (sqlDataReader.Read())
                {
                    User s = new User();
                    s.Id = sqlDataReader.GetInt32(0);
                    s.Name = sqlDataReader.GetString(1);
                    s.Surname = sqlDataReader.GetString(2);
                    s.Email = sqlDataReader.GetString(3);
                    s.Password = sqlDataReader.GetString(4);
                    s.Username = sqlDataReader.GetString(5);
                    s.SecretQuestion = sqlDataReader.GetString(6);
                    s.Answer = sqlDataReader.GetString(7);
                    s.Admin = sqlDataReader.GetInt32(8);
                    listToReturn.Add(s);
                }

                return listToReturn;
            }
        }

        public int InsertUser(User s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO USERS (NAME, SURNAME, EMAIL, PASSWORD, USERNAME, SECRETQUESTION, ANSWER, ADMIN) VALUES(" + string.Format(
                    "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}", s.Name, s.Surname, s.Email, s.Password, s.Username, s.SecretQuestion, s.Answer, s.Admin) + ")";
                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int UpdateUser(User s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "UPDATE USERS SET NAME = '" + s.Name +
                    "', SURNAME = '" + s.Surname + "', EMAIL = '" + s.Email +
                    "', PASSWORD = '" + s.Password + "', USERNAME = '" + s.Username +
                    "', SECRETQUESTION = '" + s.SecretQuestion + "', ANSWER = '" + s.Answer +
                    "', ADMIN = '" + s.Admin + "' WHERE ID_USER = " + s.Id + ";";

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteUser(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "DELETE FROM USERS WHERE ID = " + id;

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }

}
