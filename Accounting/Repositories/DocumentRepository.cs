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
    public class DocumentRepository:IDocumentRepository
    {
        private readonly string connectionString;
        public DocumentRepository()
        {
            connectionString = "data source=PC-PC; initial catalog=Accounting; integrated security=true";
        }
        public DataTable GetAllByProcedure()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_GetAll", connection);
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

        public Document GetById(int id)
        {
            Document document = new Document();
            //document = null;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_GetById", connection);
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
                    document.Id =(int)reader["Id"];
                    document.DocumentDetail = reader["DocumentDetail"].ToString();
                    document.DocumentDate = (DateTime)reader["DocumentDate"];
                    document.DocumentPage = (int)reader["DocumentPage"];
                    document.Flag = (bool)reader["Flag"];
                    document.Bedehkar = (int)reader["Bedehkar"];
                    document.Bestankar = (int)reader["Bestankar"];
                    document.TotalBedehkar = (int)reader["TotalBedehkar"];
                    document.TotalBestankar = (int)reader["TotalBestankar"];
                    document.MandehHesab = (int)reader["MandeHesab"];
                    document.AccountId = (int)reader["AccountId"];
                    
                }

            }
            connection.Close();
            return document;
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
        public int Insert(Document document)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_Insert", connection);
            command.CommandType = CommandType.StoredProcedure;
            //@DocumentDetail,@DocumentDate,@DocumentPage,1,@Bedehkar,@Bestankar,@TotalBedehkar,@TotalBestankar,@MandeHesab,@AccountId
            command.Parameters.AddWithValue("@DocumentDetail",document.DocumentDetail);
            command.Parameters.AddWithValue("@DocumentDate",document.DocumentDate);
            command.Parameters.AddWithValue("@DocumentPage", document.DocumentPage);
            command.Parameters.AddWithValue("@Flag", 1);
            command.Parameters.AddWithValue("@Bedehkar", document.Bedehkar);
            command.Parameters.AddWithValue("@Bestankar", document.Bestankar);
            command.Parameters.AddWithValue("@TotalBedehkar", document.TotalBedehkar);
            command.Parameters.AddWithValue("@TotalBestankar", document.TotalBestankar);
            command.Parameters.AddWithValue("@MandeHesab", document.MandehHesab);
            command.Parameters.AddWithValue("@AccountId", document.AccountId);
            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public int Update(Document document)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_Update", connection);
            command.CommandType = CommandType.StoredProcedure;
            //@DocumentDetail,@DocumentDate,@DocumentPage,1,@Bedehkar,@Bestankar,@TotalBedehkar,@TotalBestankar,@MandeHesab,@AccountId
            command.Parameters.AddWithValue("@Id", document.Id);
            command.Parameters.AddWithValue("@DocumentDetail", document.DocumentDetail);
            command.Parameters.AddWithValue("@DocumentDate",document.DocumentDate);
            command.Parameters.AddWithValue("@DocumentPage", document.DocumentPage);
            command.Parameters.AddWithValue("@Flag", document.Flag);

            command.Parameters.AddWithValue("@Bedehkar", document.Bedehkar);
            command.Parameters.AddWithValue("@Bestankar", document.Bestankar);
            command.Parameters.AddWithValue("@TotalBedehkar", document.TotalBedehkar);
            command.Parameters.AddWithValue("@TotalBestankar",document.TotalBestankar);
            command.Parameters.AddWithValue("@MandeHesab", document.MandehHesab);
            command.Parameters.AddWithValue("@AccountId", document.AccountId);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public int Delete(int id)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_Delete", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            
            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

    }
}
