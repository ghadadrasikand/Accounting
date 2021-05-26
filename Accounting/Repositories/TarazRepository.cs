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
    public class TarazRepository:ITarazRepository
    {
        private readonly string connectionString;
        public TarazRepository()
        {
            connectionString = "data source=PC-PC; initial catalog=Accounting; integrated security=true";
        }
        public DataTable GetAllByProcedure()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_GetAll", connection);
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
        public Taraz GetById(int id)
        {
            Taraz taraz = new Taraz();
            //document = null;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_GetById", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.HasRows)
                {

                    //@DocumentDetail,@DocumentDate,@DocumentPage,1,@Bedehkar,@Bestankar,@TotalBedehkar,@TotalBestankar,@MandeHesab,@AccountId
                    //document = null;
                    taraz.Id = (int)reader["Id"];
                    taraz.AccountId = (int)reader["AccountId"];
                    taraz.Flag = (bool)reader["Flag"];
                    taraz.GardeshBedehkar = (int)reader["GardeshBedehkar"];
                    taraz.GardeshBestankar = (int)reader["GardeshBestankar"];
                    taraz.MandeBedehkar = (int)reader["MandeBedehkar"];
                    taraz.MandeBestankar = (int)reader["MandeBestankar"];
                    taraz.TotalGardeshBedehkar = (int)reader["TotalGardeshBedehkar"];
                    taraz.TotalGardeshBestankar = (int)reader["TotalGardeshBestankar"];
                    taraz.TotalMandeBedehkar = (int)reader["TotalMandeBedehkar"];
                    taraz.TotalMandeBestankar = (int)reader["TotalMandeBestankar"];

                }

            }
            connection.Close();
            return taraz;
        }
        public DataTable GetAllNameAccount()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_NameAccount_GetAll", connection);
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

        public int Insert(Taraz taraz)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;
            //@AccountId,@GardeshBedehkar,@GardeshBestankar,@MandeBedehkar,@MandeBestankar,@TotalGardeshBedehkar,@TotalGardeshBestankar,@TotalMandeBedehkar,@TotalMandeBestankar
            command.Parameters.AddWithValue("@AccountId", taraz.AccountId);
            command.Parameters.AddWithValue("@GardeshBedehkar", taraz.GardeshBedehkar);
            command.Parameters.AddWithValue("@GardeshBestankar", taraz.GardeshBestankar);
            command.Parameters.AddWithValue("@MandeBedehkar", taraz.MandeBedehkar);

            command.Parameters.AddWithValue("@MandeBestankar", taraz.MandeBestankar);
            command.Parameters.AddWithValue("@TotalGardeshBedehkar", taraz.TotalGardeshBedehkar);
            command.Parameters.AddWithValue("@TotalGardeshBestankar", taraz.TotalGardeshBestankar);
            command.Parameters.AddWithValue("@TotalMandeBedehkar", taraz.TotalMandeBedehkar);
            command.Parameters.AddWithValue("@TotalMandeBestankar", taraz.TotalMandeBestankar);

            command.Parameters.AddWithValue("@Flag", 1);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int Update(Taraz taraz)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_Update", connection);
            command.CommandType = CommandType.StoredProcedure;
            //@DocumentDetail,@DocumentDate,@DocumentPage,1,@Bedehkar,@Bestankar,@TotalBedehkar,@TotalBestankar,@MandeHesab,@AccountId
            command.Parameters.AddWithValue("@Id", taraz.Id);
            command.Parameters.AddWithValue("@AccountId", taraz.AccountId);
            command.Parameters.AddWithValue("@Flag", taraz.Flag);
            command.Parameters.AddWithValue("@GardeshBedehkar", taraz.GardeshBedehkar);
            command.Parameters.AddWithValue("@GardeshBestankar", taraz.GardeshBestankar);
            command.Parameters.AddWithValue("@MandeBedehkar", taraz.MandeBedehkar);

            command.Parameters.AddWithValue("@MandeBestankar", taraz.MandeBestankar);
            command.Parameters.AddWithValue("@TotalGardeshBedehkar", taraz.TotalGardeshBedehkar);
            command.Parameters.AddWithValue("@TotalGardeshBestankar", taraz.TotalGardeshBestankar);
            command.Parameters.AddWithValue("@TotalMandeBedehkar", taraz.TotalMandeBedehkar);
            command.Parameters.AddWithValue("@TotalMandeBestankar", taraz.TotalMandeBestankar);

            
            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public int Delete(int id)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_Delete", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }


    }
}
