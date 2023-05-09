using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class ListStaff : Form
    {
        private int id = -1;
        private int type;
        private Home parent;
        public ListStaff(Home parent, int type)
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
                    parent.OpenChildForm(new EditStaff(parent, type, id));
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
                dataGridView1.DataSource = controller.search("nhanvien", "ten", textBox1.Text);
            }
            else
            {
                dataGridView1.DataSource = controller.getDataTable("nhanvien");
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
                        controller.querry($"DELETE FROM NHANVIEN WHERE ID={id}");
                        refresh();
                    }
                    break;
                case 1:
                    for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                    {
                        DataGridViewCell selectedCell = dataGridView1.SelectedCells[i];
                        id = Int32.Parse(dataGridView1.Rows[selectedCell.RowIndex].Cells[0].Value.ToString());
                        DbController controller = new DbController();
                        controller.querry($"DELETE FROM NHANVIEN WHERE ID={id}");
                        refresh();
                    }
                    break;
            }
        }

        private void refresh()
        {
            DbController controller = new DbController();
            dataGridView1.DataSource = controller.getDataTable("nhanvien");
            controller.close();
        }

        private void List_Load(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            dataGridView1.DataSource = controller.getDataTable("nhanvien");
            refresh();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            parent.OpenChildForm(new AddStaff());
        }
    }
}
