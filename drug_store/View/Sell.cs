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
            dataGridView1.DataSource = controller.getDataTable("thuoc");
            controller.close();
        }
    }
}
