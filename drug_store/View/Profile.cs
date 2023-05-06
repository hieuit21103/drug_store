using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class Profile : Form
    {
        private int type;
        private string username;
        private Dictionary<int, string> gender = new Dictionary<int, string>()
        {
            { 0, "Nam" },
            { 1, "Nữ" }
        };
        public Profile(string username,int type)
        {
            this.username = username;
            this.type = type;
            InitializeComponent();
        }


        private void Profile_Load(object sender, EventArgs e)
        {
            DbController dbController = new DbController();
            List<string> data = dbController.getSenderData(username);
            textBox1.Text = data[0];
            textBox2.Text = data[1];
            foreach(KeyValuePair<int,string> seggs in gender)
            {
                if(seggs.Key == Int32.Parse(data[2])) {
                    textBox3.Text = seggs.Value;
                }
            }
            textBox4.Text = data[3];
            textBox5.Text = "0"+data[4];
            textBox6.Text = data[5];
            dateTimePicker1.Text = data[6];
            dbController.close();
        }
    }
}
