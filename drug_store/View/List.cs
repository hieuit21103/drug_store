using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class List : Form
    {
        private int id = -1;
        private int type;
        private Home parent;
        public List(Home parent, int type)
        {
            InitializeComponent();
            this.type = type;
            this.parent = parent;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                }
                if (dataGridView1.CurrentCell != null)
                {
                    int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                    id = Int32.Parse(dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString());
                }
                if (id != -1)
                {
                    parent.OpenChildForm(new Edit(parent, type, id));
                }
                else
                {
                    MessageBox.Show("id = -1");
                }

            }
        }

        private void ibtnbin_Click(object sender, EventArgs e)
        {
            if (type == 0)
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
                dataGridView1.DataSource = controller.search("thuoc", "tenthuoc", textBox1.Text);
            }
            else
            {
                dataGridView1.DataSource = controller.getDataTable("thuoc");
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
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++) {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[i];
                        id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                        DbController controller = new DbController();
                        controller.querry($"DELETE FROM THUOC WHERE ID={id}");
                        refresh();
                    }
                    break;
                case 1:
                    for(int i = 0;i < dataGridView1.SelectedCells.Count;i++)
                    {
                        DataGridViewCell selectedCell = dataGridView1.SelectedCells[i];
                        id = Int32.Parse(dataGridView1.Rows[selectedCell.RowIndex].Cells[0].Value.ToString());
                        DbController controller = new DbController();
                        controller.querry($"DELETE FROM THUOC WHERE ID={id}");
                        refresh();
                    }
                    break;
            }
        }
        
        private void refresh()
        {
            DbController controller = new DbController();
            dataGridView1.DataSource = controller.getDataTable("thuoc");
            controller.close();
        }

        private void List_Load(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            dataGridView1.DataSource = controller.getDataTable("thuoc");
            List<string> types = controller.getType();
            comboBox1.Items.Add("None");
            comboBox1.SelectedIndex = 0;
            foreach (string type in types)
            {
                comboBox1.Items.Add(type);
            }
            controller.close();
            refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = controller.getDataTable("thuoc");
            }
            else
            {
                dataGridView1.DataSource = controller.search("thuoc", "idnhom", (comboBox1.SelectedIndex).ToString());
            }
            controller.close();
        }
    }
}
