using System;
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
