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
    public partial class ValidCheck : Form
    {
        public ValidCheck()
        {
            InitializeComponent();
        }

        private void ValidCheck_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
