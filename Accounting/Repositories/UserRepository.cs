using Accounting.IRepositories;
using Accounting.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly string connectionString;
        public UserRepository()
        {
            connectionString = "data source=PC-PC; initial catalog=Accounting; integrated security=true";
        }
        public DataTable GetAllByProcedure()
        {
            DataTable dt = new DataTable(); 
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Users_GetAll", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);
            /*while (reader.Read())
            {

            }*/
            connection.Close();
            return dt;
        }

        public User Login(string username,string password)
        {
            User user = null;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_User_Login", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Password", password);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                if (reader.HasRows)
                {
                    user = new User();
                    user.Id = (int)reader["Id"];
                    user.Name = reader["Name"].ToString();
                    user.UserName = reader["UserName"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Type = reader["Type"].ToString();
                }

            }
            connection.Close();
            return user;
        }

        public User GetById(int id)
        {
            User user = new User();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_User_GetById", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    user.Id = (int)reader["Id"];
                    user.Name = reader["Name"].ToString();
                    user.UserName = reader["UserName"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Type = reader["Type"].ToString();
                }

            }
            connection.Close();
            return user;
        }
        public int Insert(User user)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_User_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name",user.Name);
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@Type", user.Type);
            connection.Open();
            result=command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public int Update(User user)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_User_Update", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", user.Id);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@Type", user.Type);
            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int Delete(int id)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_User_Delete", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
