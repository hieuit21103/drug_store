using drug_store.Controller;
using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class Customer : Form
    {
        private int id = -1;
        private Home parent;
        private Invoice invoice;
        private string username;
        private int type = 0;
        public Customer(Home parent,string username)
        {
            this.parent = parent;
            this.username = username;
            InitializeComponent();
        }

        public Customer(Home parent, string username,int type, Invoice invoice)
        {
            this.parent = parent;
            this.username = username;
            this.type = type;
            this.invoice = invoice;
            InitializeComponent();
            label1.Text = "Chọn bệnh nhân";
        }


        private void ibtnbin_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                delete(0);
            }
            if (dataGridView1.SelectedCells.Count > 0)
            {
                delete(1);
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ibtnsearchf3_Click(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            if (textBox1.Text != "")
            {
                dataGridView1.DataSource = controller.search("khachhang", "hoten", textBox1.Text);
            }
            else
            {
                dataGridView1.DataSource = controller.getDataTable("khachhang");
            }
            controller.close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnsearchf3.PerformClick();
                textBox1.Text = "";
            }
        }

        private void delete(int type)
        {

            switch (type)
            {
                case 0:
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[i];
                        id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                        DbController controller = new DbController();
                        controller.querry($"DELETE FROM KHACHHANG WHERE ID={id}");
                        refresh();
                    }
                    break;
                case 1:
                    for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                    {
                        DataGridViewCell selectedCell = dataGridView1.SelectedCells[i];
                        id = Int32.Parse(dataGridView1.Rows[selectedCell.RowIndex].Cells[0].Value.ToString());
                        DbController controller = new DbController();
                        controller.querry($"DELETE FROM KHACHHANG WHERE ID={id}");
                        refresh();
                    }
                    break;
            }
        }

        private void refresh()
        {
            DbController controller = new DbController();
            dataGridView1.DataSource = controller.getDataTable("khachhang");
            controller.close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            refresh();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.ShowDialog();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            int id = Int32.Parse(dataGridView1.Rows[selectedRow].Cells[0].Value.ToString());
            string name = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            if (type == 0)
            {  
                parent.OpenChildForm(new Sell(parent, username, id, name));
            }
            else
            {
                invoice.generate(username,name);
                this.Close();
            }
        }
    }
}
