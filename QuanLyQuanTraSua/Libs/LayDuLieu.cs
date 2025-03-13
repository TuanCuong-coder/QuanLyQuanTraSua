using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyQuanTraSua.Libs
{
    internal class LayDuLieu
    {
        private static LayDuLieu _instance;

        public static LayDuLieu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LayDuLieu();
                }
                return _instance;
            }
        }

        private string connectionString =
           "Data Source=TUANCUONG;Initial Catalog=QuanLyQuanTraSua;Persist Security Info=True;User ID=sa;Password=123456";



        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            string[] listParams = query.Split(' ');
                            int index = 0;
                            foreach (string param in listParams)
                            {
                                if (param.Contains("@"))
                                {
                                    command.Parameters.AddWithValue(param, parameters[index]);
                                    index++;
                                }
                            }
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(data);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi thực hiện truy vấn: {ex.Message}");
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            string[] listParams = query.Split(' ');
                            int index = 0;
                            foreach (string param in listParams)
                            {
                                if (param.Contains("@"))
                                {
                                    command.Parameters.AddWithValue(param, parameters[index]);
                                    index++;
                                }
                            }
                        }

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi thực hiện truy vấn: {ex.Message}");
            }

            return rowsAffected;
        }

     
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object result = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            string[] listParams = query.Split(' ');
                            int index = 0;
                            foreach (string param in listParams)
                            {
                                if (param.Contains("@"))
                                {
                                    command.Parameters.AddWithValue(param, parameters[index]);
                                    index++;
                                }
                            }
                        }

                        result = command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi thực hiện truy vấn: {ex.Message}");
            }

            return result;
        }
    }
}
