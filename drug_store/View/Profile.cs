using System;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class Profile : Form
    {
        int type;
        public Profile(int type)
        {
            this.type = type;
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            if (type == 1)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
            }
        }
    }
}
