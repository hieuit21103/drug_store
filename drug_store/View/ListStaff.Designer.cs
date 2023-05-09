namespace drug_store.View
{
    partial class ListStaff
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ibtnbin = new FontAwesome.Sharp.IconButton();
            this.ibtnsearchf3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem Nhân Viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 452);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton1.IconColor = System.Drawing.Color.LightBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(854, 613);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(135, 46);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Sửa";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ibtnbin
            // 
            this.ibtnbin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ibtnbin.FlatAppearance.BorderSize = 0;
            this.ibtnbin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnbin.ForeColor = System.Drawing.Color.White;
            this.ibtnbin.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnbin.IconColor = System.Drawing.Color.LightBlue;
            this.ibtnbin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbin.IconSize = 30;
            this.ibtnbin.Location = new System.Drawing.Point(997, 613);
            this.ibtnbin.Margin = new System.Windows.Forms.Padding(4);
            this.ibtnbin.Name = "ibtnbin";
            this.ibtnbin.Size = new System.Drawing.Size(135, 46);
            this.ibtnbin.TabIndex = 9;
            this.ibtnbin.Text = "Xóa";
            this.ibtnbin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtnbin.UseVisualStyleBackColor = false;
            this.ibtnbin.Click += new System.EventHandler(this.ibtnbin_Click);
            // 
            // ibtnsearchf3
            // 
            this.ibtnsearchf3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ibtnsearchf3.FlatAppearance.BorderSize = 0;
            this.ibtnsearchf3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnsearchf3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ibtnsearchf3.IconColor = System.Drawing.Color.LightBlue;
            this.ibtnsearchf3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsearchf3.IconSize = 30;
            this.ibtnsearchf3.Location = new System.Drawing.Point(1003, 80);
            this.ibtnsearchf3.Margin = new System.Windows.Forms.Padding(4);
            this.ibtnsearchf3.Name = "ibtnsearchf3";
            this.ibtnsearchf3.Size = new System.Drawing.Size(129, 46);
            this.ibtnsearchf3.TabIndex = 2;
            this.ibtnsearchf3.Text = "Tìm kiếm";
            this.ibtnsearchf3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtnsearchf3.UseVisualStyleBackColor = false;
            this.ibtnsearchf3.Click += new System.EventHandler(this.ibtnsearchf3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButton2.IconColor = System.Drawing.Color.LightBlue;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(711, 613);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(135, 46);
            this.iconButton2.TabIndex = 12;
            this.iconButton2.Text = "Thêm";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ListStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 759);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ibtnbin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ibtnsearchf3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListStaff";
            this.Text = "frmNewMedicine";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibtnsearchf3;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ibtnbin;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}