using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przychodnia.Helpers
{
    public static class DataBaseHelper
    {
        private static readonly string connectionString = Settings.Default.dbstring;

        private static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static DataTable ExecuteQueryCommand(SqlCommand command)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = OpenConnection())
            {
                command.Connection = connection;


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public static bool ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            bool result = true;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Jeśli istnieją parametry, dodaj je do zapytania
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException sqlex)
                    {
                        Console.WriteLine(sqlex.Message);
                        result = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        result = false;
                    }
                }
            }
            return result;
        }


        public static bool ExecuteNonQueryCommand(SqlCommand command)
        {
            bool result = true;
            using (SqlConnection connection = OpenConnection())
            {
                command.Connection = connection;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqlex)
                {
                    Console.WriteLine(sqlex.Message);
                    result = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    result = false;
                }
            }
            return result;
        }
        public static int ExecuteScalarCommand(SqlCommand command)
        {
            int result = 0;
            using (SqlConnection connection = OpenConnection())
            {
                command.Connection = connection;

                try
                {
                    result = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (SqlException sqlex)
                {
                    Console.WriteLine(sqlex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }
    }
}
