using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAnNhom21
{
    internal class Connection
    {
        public static string user;
        public static string pass;

        public static string connectString = Properties.Settings.Default.ConnectionString;
        public static string GetConnectionString(string user, string pass)
        {
            return connectString + ";User Id=" + user + ";Password=" + pass;
        }

        public static SqlConnection getConnection()
        {
            return new SqlConnection(connectString);
        }

        public static DataTable LoadDataTable(string query)
        {
            connectString = GetConnectionString(user, pass);
            SqlConnection conn = new SqlConnection(connectString);
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataTable);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        public static void ExecuteCommand(SqlCommand command)
        {
            connectString = GetConnectionString(user, pass);
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        public static void ExecuteCommandAdmin(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
