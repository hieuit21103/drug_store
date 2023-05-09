using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class EditStaff : Form
    {
        private int id;
        private int type;
        private Home oppa;
        public EditStaff(Home oppa, int type, int id)
        {
            this.type = type;
            this.oppa = oppa;
            this.id = id;
            InitializeComponent();
        }

        private void ibtnTailai3_Click(object sender, EventArgs e)
        {
            oppa.OpenChildForm(new List(oppa, type));
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            DbController dbController = new DbController();
            List<string> data = dbController.getPersonData(id);
            textBox1.Text = data[0];
            textBox6.Text = data[2];
            comboBox1.SelectedIndex = Int32.Parse(data[1]);
            textBox2.Text = data[5];
            textBox4.Text = data[3];
            dateTimePicker2.Text = data[7];
            dbController.close();
        }

        private void ibtnThemf3_Click(object sender, EventArgs e)
        {
            int soluong = 0;
            if (IsTextBoxEmpty())
            {
                MessageBox.Show("Thiếu dữ liệu");
            }
            else
            {
                DbController controller = new DbController();
                string idthuoc = textBox1.Text;
                string diachi = textBox2.Text;
                string ten = textBox6.Text;
                string sdt = textBox7.Text;
                string idnhom = comboBox1.SelectedIndex.ToString();
                string hsd = dateTimePicker2.Text;
                string luong = textBox4.Text;
                string email = textBox3.Text;
                if (Int32.TryParse(idthuoc, out int i) && Int32.TryParse(idnhom, out int i2) && Int32.TryParse(luong, out int i4) && Int32.TryParse(sdt,out int i3))
                {
                    string command = $"UPDATE NHANVIEN WHERE ID={idthuoc} SET diachi={diachi},ten={ten},gioitinh={Int32.Parse(idnhom)},sdt={Int32.Parse(sdt)},email='{email}',luong='{luong}',ngaylam='{hsd}'";
                    controller.querry(command);
                    MessageBox.Show("Cập nhật thành công");
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

    }
}
