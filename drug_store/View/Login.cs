using drug_store.Controller.Database;
using System;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbController dbController = new DbController();
            string username = textBox1.Text;
            string password = textBox2.Text;
            int type = dbController.check(username, password);
            if (type != -1)
            {
                Home home = new Home(username, type);
                home.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
