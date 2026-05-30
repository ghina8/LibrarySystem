using System.Data;
using Microsoft.Data.SqlClient;

namespace LibrarySystem
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            @"Server=DESKTOP-CBHNHTT\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static DataTable GetData(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void ExecuteQuery(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}