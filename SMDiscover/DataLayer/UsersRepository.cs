using DataLayer.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class UsersRepository
    {
        private string connectionString = "Data Source=Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SMDiscoverDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<User> GetAllUsers()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Users";

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
                sqlCommand.CommandText = "INSERT INTO USERS (Name, Surname, Email, Password, Username, SecretQuestion, Answer, Admin) VALUES(" + string.Format(
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
                sqlCommand.CommandText = "UPDATE USERS SET Name = '" + s.Name +
                    "', Surname = '" + s.Surname + "', Email = " + s.Email +
                    ", Password = '" + s.Password + "', Username = " + s.Username +
                    "', SecretQuestion = " + s.SecretQuestion + "', Answer = " + s.Answer +
                    "', Admin = " + s.Admin + "' WHERE Id = " + s.Id;

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
                sqlCommand.CommandText = "DELETE FROM USERS WHERE Id = " + id;

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }

}
