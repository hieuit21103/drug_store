using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.Linq;
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
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }

        private void ibtnThemf2_Click(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            if (IsTextBoxEmpty())
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
                string idnhom = comboBox1.SelectedIndex.ToString();
                string nsx = dateTimePicker1.Text;
                string hsd = dateTimePicker2.Text;
                if (Int32.TryParse(idthuoc, out int i) && Int32.TryParse(idnsx, out int i1) && Int32.TryParse(idnhom, out int i2) && Int32.TryParse(soluong, out int i3) && Int32.TryParse(gia, out int i4))
                {
                    string command = $"INSERT INTO THUOC VALUES({idthuoc},{idnhom},{idnsx},{soluong},{gia},'{tenthuoc}','{nsx}','{hsd}')";
                    controller.querry(command);
                }
                else
                {
                    MessageBox.Show("Sai kiểu dữ liệu");
                }
            }
        }
        private bool IsTextBoxEmpty()
        {
            return Controls.OfType<TextBox>().Any(textBox => string.IsNullOrEmpty(textBox.Text));
        }

        private void Add_Load(object sender, EventArgs e)
        {
            DbController controller = new DbController();
            List<string> list = controller.getType();
            controller.close();
            foreach (string type in list)
            {
                comboBox1.Items.Add(type);
            }
            comboBox1.SelectedIndex = 0;
        }
    }

}
