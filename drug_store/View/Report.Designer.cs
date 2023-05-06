namespace drug_store.View
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_First = new System.Windows.Forms.DateTimePicker();
            this.dateTime_Last = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_report = new System.Windows.Forms.Button();
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(289, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "QUẢN LÝ DOANH THU";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(18, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn thời gian muốn xem doanh thu:";
            // 
            // dateTime_First
            // 
            this.dateTime_First.CustomFormat = "dd-MM-yyyy";
            this.dateTime_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTime_First.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_First.Location = new System.Drawing.Point(395, 100);
            this.dateTime_First.Name = "dateTime_First";
            this.dateTime_First.Size = new System.Drawing.Size(116, 26);
            this.dateTime_First.TabIndex = 6;
            // 
            // dateTime_Last
            // 
            this.dateTime_Last.CustomFormat = "dd-MM-yyyy";
            this.dateTime_Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTime_Last.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_Last.Location = new System.Drawing.Point(621, 100);
            this.dateTime_Last.Name = "dateTime_Last";
            this.dateTime_Last.Size = new System.Drawing.Size(120, 26);
            this.dateTime_Last.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(551, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đến";
            // 
            // BTN_report
            // 
            this.BTN_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BTN_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_report.FlatAppearance.BorderSize = 0;
            this.BTN_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_report.ForeColor = System.Drawing.Color.White;
            this.BTN_report.Location = new System.Drawing.Point(770, 92);
            this.BTN_report.Name = "BTN_report";
            this.BTN_report.Size = new System.Drawing.Size(106, 44);
            this.BTN_report.TabIndex = 9;
            this.BTN_report.Text = "Thống kê";
            this.BTN_report.UseVisualStyleBackColor = false;
            this.BTN_report.Click += new System.EventHandler(this.BTN_report_Click);
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_report.Location = new System.Drawing.Point(22, 144);
            this.dataGridView_report.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.RowHeadersWidth = 51;
            this.dataGridView_report.RowTemplate.Height = 24;
            this.dataGridView_report.Size = new System.Drawing.Size(854, 440);
            this.dataGridView_report.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(642, 614);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(160, 22);
            this.txt_total.TabIndex = 12;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 646);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_report);
            this.Controls.Add(this.BTN_report);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTime_Last);
            this.Controls.Add(this.dateTime_First);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Report";
            this.Text = "Doanhthu";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_First;
        private System.Windows.Forms.DateTimePicker dateTime_Last;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_report;
        private System.Windows.Forms.DataGridView dataGridView_report;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total;
    }
}