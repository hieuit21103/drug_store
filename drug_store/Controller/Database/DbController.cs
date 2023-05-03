using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Data.SQLite;

namespace drug_store.Controller.Database
{
    internal class DbController
    {
        string connectionString { get; set; }
        SQLiteConnection connection;
        public DbController()
        {
            connectionString = new Database().connectionString;
            try
            {
               connection = new SQLiteConnection("data source="+connectionString+";");
               connection.Open();
            }catch (Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int check(string username, string password)
        {
            int type = -1;
            try
            {
                string cmd = "SELECT matkhau, loai FROM taikhoan WHERE taikhoan=@username";
                SQLiteCommand command = new SQLiteCommand(cmd,connection);
                command.Parameters.AddWithValue("@username", username);
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
    }
}
