using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Repository
{
    public static class DbContext
    {
        private static string _connectionString = "Data Source=FLIXLAPTOP\\DBKURSTEST01;Initial Catalog=KlumpenDB;Integrated Security=SSPI;TrustServerCertificate=True;";

        public static DataTable ExecuteQueryReturnTable(string sqlQuery, List<SqlParameter> parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);

                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                DataTable result = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(result);

                return result;
            }
        }

        public static void ExecuteNonQuery(string sqlQuery, List<SqlParameter> parameters)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand( sqlQuery, connection);

                foreach(SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }

                cmd.ExecuteNonQuery();
            }
        }
    }
}
