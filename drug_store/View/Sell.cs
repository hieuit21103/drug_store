using drug_store.Controller;
using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class Sell : Form
    {
        private string username;
        public Sell(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            dataGridView2.DataSource = controller.getDataTable("thuoc");
            List<string> types = controller.getType();
            comboBox1.Items.Add("None");
            comboBox1.SelectedIndex = 0;
            foreach (string type in types)
            {
                comboBox1.Items.Add(type);
            }
            
            controller.close();
        }

        private void ibtncar_Click(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            int n = dataGridView2.SelectedCells.Count;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int selectedRows = dataGridView2.SelectedCells[i].RowIndex;
                    int id = Int32.Parse(dataGridView2.Rows[selectedRows].Cells[0].Value.ToString());
                    fill(dataGridView1, controller.getMedData(id));
                }
            }
            controller.close();
        }
        private void fill(DataGridView dataGridView, List<string> data)
        {
            data[3].Remove(0);
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            for (int i = 0; i < 7; i++)
            {
                row.Cells[i].Value = data[i];
            }
            dataGridView1.Rows.Add(row);
            row.Cells[7].Value = 1;
        }

        private void ibtnLoaiBo_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.SelectedCells.Count;
            if (n > 0)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    int selectedRows = dataGridView1.SelectedCells[i].RowIndex;
                    dataGridView1.Rows.RemoveAt(selectedRows);
                }
            }
        }

        private void ibtnThanhToanIn_Click(object sender, EventArgs e)
        {
            int size = dataGridView1.Rows.Count;
            List<int> id = new List<int>();
            List<int> quantity = new List<int>();
            if (size > 0)
            {
                for (int i = 0; i < size; i++)
                {
                    int id1 = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    int quantity1 = Int32.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    id.Add(id1);
                    quantity.Add(quantity1);
                }
                Invoice invoice = new Invoice(id, quantity, size);
                invoice.generate(username);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            if (textBox1.Text != "")
            {
                dataGridView2.DataSource = controller.search("thuoc", "tenthuoc", textBox1.Text);
            }
            else
            {
                dataGridView2.DataSource = controller.getDataTable("thuoc");
            }
            controller.close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView2.DataSource = controller.getDataTable("thuoc");
            }
            else
            {
                dataGridView2.DataSource = controller.search("thuoc", "idnhom", (comboBox1.SelectedIndex + 1).ToString()); 
            }
            controller.close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                iconButton1.PerformClick();
                textBox1.Text = "";
            }
        }
    }
}
