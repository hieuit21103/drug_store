using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class Edit : Form
    {
        private int id;
        public Edit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void ibtnTailai3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            DbController dbController = new DbController();
            List<string> types = dbController.getType();
            foreach (string type in types)
            {
                comboBox1.Items.Add(type);
            }
            List<string> data = dbController.getMedData(id);
            textBox1.Text = data[0];
            textBox6.Text = data[2];
            comboBox1.SelectedIndex = Int32.Parse(data[1]);
            textBox2.Text = data[5];
            textBox4.Text = data[3];
            textBox5.Text = data[4];
            dateTimePicker1.Text = data[6];
            dateTimePicker2.Text = data[7];
            dbController.close();
        }
    }
}
