using drug_store.Controller.Basic;
using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drug_store
{
    public partial class Home : Form
    {
        private int type;
        private string username;

        public Home(string username, int type)
        {
            InitializeComponent();
            this.username = username;
            this.type = type;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void thựcPhẩmChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Image img = Image.FromFile(Path.Combine(
                Directory.GetParent(Directory.GetParent(path).FullName).FullName,
                @"Component\Icon\cart.ico"
                ));
            pictureBox1.Image = img;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
