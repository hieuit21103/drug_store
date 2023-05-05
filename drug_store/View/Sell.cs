using drug_store.Controller.Basic;
using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            dataGridView2.DataSource = controller.getDataTable("thuoc");
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
        }

        private void ibtnLoaiBo_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.SelectedCells.Count;
            if (n > 0)
            {
                for (int i = n-1; i >= 0; i--)
                {
                    int selectedRows = dataGridView1.SelectedCells[i].RowIndex;
                    dataGridView1.Rows.RemoveAt(selectedRows);
                }
            }
        }

        private void ibtnThanhToanIn_Click(object sender, EventArgs e)
        {
            Controller.Basic.Controller controller = new Controller.Basic.Controller();
            controller.generateInvoice();
        }
    }
}
