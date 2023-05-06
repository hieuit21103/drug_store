using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
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
                string id = textBox1.Text;
                string sdt = textBox2.Text;
                string diachi = textBox3.Text;
                string tuoi = textBox4.Text;
                string ten = textBox6.Text;
                string gioitinh = comboBox1.SelectedItem.ToString();
                if (Int32.TryParse(id, out int i) && Int32.TryParse(tuoi, out int i2))
                {
                    if (sdt.Length == 10)
                    {
                        string command = $"INSERT INTO KHACHHANG VALUES({id},'{ten}','{gioitinh}',{tuoi},'{sdt}','{diachi}')";
                        controller.querry(command);
                    }
                    else
                    {
                        MessageBox.Show("Sai số điện thoại");
                    }
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
            comboBox1.SelectedIndex = 0;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
