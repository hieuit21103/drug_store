using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class List : Form
    {
        private int type;
        private Home parent;
        public List(Home parent,int type)
        {
            InitializeComponent();
            this.type = type;
            this.parent = parent;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int id = -1;
            if(type == 0)
            {
                if(dataGridView1.SelectedRows.Count > 0)
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
                    parent.OpenChildForm(new Edit(parent,type,id));
                }
                else
                {
                    MessageBox.Show("id = -1");
                }

            }
        }

        private void ibtnbin_Click(object sender, EventArgs e)
        {

        }

        private void List_Load(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            dataGridView1.DataSource = controller.getDataTable("thuoc");
            controller.close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
