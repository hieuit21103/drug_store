using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace drug_store.View
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void BTN_report_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime first = Convert.ToDateTime(dateTime_First.Value.ToString());
                DateTime last = Convert.ToDateTime(dateTime_Last.Value.ToString());
                DbController dbController = new DbController();
                dataGridView_report.DataSource = dbController.view_report(first, last);
                double s = 0;
                for(int i=0; i<dataGridView_report.Rows.Count; i++)
                {
                    s += Convert.ToDouble(dataGridView_report.Rows[i].Cells[3].Value);
                }
                txt_total.Text = s.ToString();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
