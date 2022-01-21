using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace QuanLyNhaHang.DAL
{
    public class DataProvider
    {
        
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) { return instance = new DataProvider(); } return instance; }
            private set => instance = value;
        }

        private DataProvider() { }

        private string SQL_conection_string = "server=localhost;uid=root; pwd=;database=nhahang;Convert Zero Datetime=True";

        public DataTable ExecuteQuery(string query, object[] param = null)
        {
            DataTable data = new DataTable();
            try
            {

                MySqlConnection con = new MySqlConnection(SQL_conection_string);

                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                if (param != null)
                {
                    int i = 0;
                    foreach (string item in query.Split(' '))
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(data);

                con.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return data;
            //trả về 1 bảng table, dùng để select, cập nhật dữ liệu lên
        }


        public int ExecuteNonQuery(string query, object[] param = null)
        {
            int data = 0;

            try
            {
                MySqlConnection con = new MySqlConnection(SQL_conection_string);

                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                if (param != null)
                {
                    int i = 0;
                    foreach (string item in query.Split(' '))
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                //trả về số dòng bị ảnh hưởng bởi câu lệnh đó
                //insert , update, delete

                con.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return data; 
            
        }
        public object ExecuteScalar(string query, object[] param = null)
        {
            object data = 0;

            try
            {
                MySqlConnection con = new MySqlConnection(SQL_conection_string);

                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);

                if (param != null)
                {
                    int i = 0;
                    foreach (string item in query.Split(' '))
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                con.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return data;
        }
    }
}
