using drug_store.Controller.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace drug_store.View
{
    public partial class Edit : Form
    {
        private int id;
        private int type;
        private Home oppa;
        public Edit(Home oppa,int type,int id)
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
            List<string> types = dbController.getType();
            foreach (string type in types)
            {
                comboBox1.Items.Add(type);
            }
            List<string> data = dbController.getMedData(id);
            textBox1.Text = data[0];
            textBox6.Text = data[2];
            comboBox1.SelectedIndex = Int32.Parse(data[1]);
            textBox2.Text = data[5];
            textBox4.Text = data[3];
            textBox5.Text = data[4];
            dateTimePicker1.Text = data[6];
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
                string tenthuoc = textBox2.Text;
                string gia = textBox5.Text;
                if (Int32.TryParse(textBox4.Text, out int value))
                {
                     soluong = (int)(Int32.Parse(textBox4.Text) + numericUpDown1.Value);
                }
                else
                {
                    MessageBox.Show("Sai kiểu dữ liệu");
                }
                string idnsx = textBox6.Text;
                string idnhom = comboBox1.SelectedIndex.ToString();
                string nsx = dateTimePicker1.Text;
                string hsd = dateTimePicker2.Text;
                if (Int32.TryParse(idthuoc, out int i) && Int32.TryParse(idnsx, out int i1) && Int32.TryParse(idnhom, out int i2) && Int32.TryParse(gia, out int i4))
                {
                    string command = $"UPDATE THUOC WHERE ID={idthuoc} SET IDNHOM={idnhom},IDNSX={idnsx},SOLUONG={soluong},GIABAN={gia},TENTHUOC='{tenthuoc}',NSX='{nsx}',HSD='{hsd}'";
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
