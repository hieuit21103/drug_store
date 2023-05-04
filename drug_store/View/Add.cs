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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void ibtnTailai_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }

        private void ibtnThemf2_Click(object sender, EventArgs e)
        {
            DbController controller = new DbController(); 
            if(IsTextBoxEmpty())
            {
                MessageBox.Show("Thiếu dữ liệu", "Lỗi!");
            }
            else
            {
                string idthuoc = textBox1.Text;
                string tenthuoc = textBox2.Text;
                string gia = textBox3.Text;
                string soluong = textBox4.Text;
                string idnsx = textBox6.Text;
                string ghichu = textBox7.Text;
                string idnhom = comboBox1.SelectedIndex.ToString();
                string nsx = dateTimePicker1.Text;
                string hsd = dateTimePicker2.Text;
                string command = $"INSERT INTO THUOC VALUES({idthuoc},{idnhom},{idnsx},{soluong},{gia},{tenthuoc},{ghichu},{nsx},{hsd})";
                controller.querry(command);                
            }
        }
        private bool IsTextBoxEmpty()
        {
            return Controls.OfType<TextBox>().Any(textBox => string.IsNullOrEmpty(textBox.Text));
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }

}
