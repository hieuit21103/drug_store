using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace drug_store.Controller.Database
{
    internal class DbController
    {
        string connectionString { get; set; }
        SQLiteConnection connection { get; set; }
        public DbController()
        {
            connectionString = new Database().connectionString;
            try
            {
                connection = new SQLiteConnection("data source=" + connectionString + ";");
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void querry(string cmd)
        {
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            try
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int check(string username, string password)
        {
            int type = -1;
            try
            {
                string cmd = $"SELECT matkhau, loai FROM taikhoan WHERE taikhoan='{username}'";
                SQLiteCommand command = new SQLiteCommand(cmd, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["matkhau"].ToString() == password)
                    {
                        type = Int32.Parse(reader["loai"].ToString());
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return type;
        }


        public DataTable getDataTable(string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public List<string> getType()
        {
            List<string> types = new List<string>();
            string cmd = "SELECT * FROM NHOMTHUOC";
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                types.Add(reader["tennhom"].ToString());
            }
            return types;
        }

        public List<string> getMedData(int id)
        {
            List<string> list = new List<string>();
            string cmd = $"SELECT * FROM THUOC WHERE ID={id}";
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader["id"].ToString());
                list.Add(reader["idnhom"].ToString());
                list.Add(reader["idnsx"].ToString());
                list.Add(reader["soluong"].ToString());
                list.Add(reader["giaban"].ToString());
                list.Add(reader["tenthuoc"].ToString());
                list.Add(reader["nsx"].ToString());
                list.Add(reader["hsd"].ToString());
            }
            return list;
        }

        public Dictionary<int,string> getDataList(string tableName,string columnName)
        {
            Dictionary<int,string> result = new Dictionary<int, string>();
            string cmd = $"SELECT id,{columnName} from {tableName}";
            SQLiteCommand command = new SQLiteCommand(cmd, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(Int32.Parse(reader["id"].ToString()),reader[columnName].ToString());
            }
            return result;
        }
        public void close()
        {
            connection.Close();
        }
    }
}
