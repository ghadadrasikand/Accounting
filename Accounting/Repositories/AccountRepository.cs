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
    
    public class AccountRepository:IAccountRepository
    {
        private readonly string connectionString;
        public AccountRepository()
        {
            connectionString = "data source=PC-PC; initial catalog=Accounting; integrated security=true";
        }
        public DataTable GetAllByProcedure()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Account_GetAll", connection);
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

        public Account GetById(int id)
        {
            Account account = new Account();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Account_GetById", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    account.Id = (int)reader["Id"];
                    account.TarafHesab = reader["TarafHesab"].ToString();
                    account.AccountName = reader["AccountName"].ToString();
                    
                }

            }
            connection.Close();
            return account;
        }
        public int Insert(Account account)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Account_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TarafHesab", account.TarafHesab);
            command.Parameters.AddWithValue("@AccountName", account.AccountName);
            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int Update(Account account)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Account_Update", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", account.Id);
            command.Parameters.AddWithValue("@TarafHesab", account.TarafHesab);
            command.Parameters.AddWithValue("@AccountName", account.AccountName);
            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

    }
}
