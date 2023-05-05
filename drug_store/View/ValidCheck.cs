using System;
using System.Collections.Generic;
using System.Windows.Forms;
using drug_store.Controller.Database;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            DateTimeOffset now = TimeZoneInfo.ConvertTime(DateTimeOffset.Now, localTimeZone);
            DateTime today = now.DateTime;
            DbController controller = new DbController();
            Dictionary<int, string> list = controller.getDataList("thuoc", "hsd");
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    foreach (KeyValuePair<int, string> item in list)
                    {
                        DateTime hsd = DateTime.Parse(item.Value);
                        TimeSpan timeSpan = hsd - today;
                        if (timeSpan.TotalDays <= 30 && timeSpan.TotalDays > 0)
                        {
                            fill(dataGridView1, controller.getMedData(item.Key));
                        }
                    }
                    break;
                case 1:
                    foreach (KeyValuePair<int, string> item in list)
                    {
                        DateTime hsd = DateTime.Parse(item.Value);
                        TimeSpan timeSpan = hsd - today;
                        if (timeSpan.TotalDays < 0)
                        {
                            fill(dataGridView1, controller.getMedData(item.Key));
                        }
                    }
                    break;
            }
            controller.close();
        }

        private void fill(DataGridView dataGridView, List<string> data)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            for (int i = 0; i < 8; i++)
            {
                row.Cells[i].Value = data[i];
            }
            dataGridView1.Rows.Add(row);
        }
    }
}
