using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace college
{
    internal class DBConnection
    {
        static SqlConnection sqlConnection;
        static string connectionString =
            "server = MICHAELSWISA\\SQLSERVER;initial catalog=College; user id=sa; password=1234;TrustServerCertificate=Yes";

        public static bool Connect()
        {
            try
            {
                if (sqlConnection == null)
                {
                    sqlConnection = new SqlConnection(connectionString);
                }

                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void Disconnect()
        {
            sqlConnection.Close();
        }

        //public static DataTable GetDataTable(
        //    string sql,
        //    string[] parameters,
        //    string[] values,
        //    DataTable dt
        //)
        //{
        //    if (Connect())
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = sqlConnection;
        //            cmd.CommandText = sql;
        //            // Add parameters
        //            if (parameters != null && values != null)
        //            {
        //                for (int i = 0; i < parameters.Length; i++)
        //                {
        //                    cmd.Parameters.AddWithValue(parameters[i], values[i]);
        //                }
        //            }
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            adapter.Fill(dt);

        //            return dt;
        //        }
        //        catch (SqlException ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    return null;
        //}

        public static SqlDataReader RunSQLAllResult(
            string sql,
            string[] parameters = null,
            string[] values = null
        )
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    return cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            return null;
        }

        public static void NoReturnValue(
            string sql,
            string[] parameters = null,
            string[] values = null
        )
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void NoReturnV(
            string sql,
            DateTime date,
            int price,
            string[] parameters = null,
            string[] values = null
        )
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@price", price);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
