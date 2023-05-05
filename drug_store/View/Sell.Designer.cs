namespace drug_store.View
{
    partial class Sell
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ibtnThanhToanIn = new FontAwesome.Sharp.IconButton();
            this.ibtnLoaiBo = new FontAwesome.Sharp.IconButton();
            this.ibtncar = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bán Thuốc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(29, 458);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 209);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1095, 280);
            this.dataGridView2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(657, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 30);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 33);
            this.comboBox1.TabIndex = 11;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.LightBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(961, 65);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(163, 46);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Tìm kiếm";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // ibtnThanhToanIn
            // 
            this.ibtnThanhToanIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ibtnThanhToanIn.FlatAppearance.BorderSize = 0;
            this.ibtnThanhToanIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThanhToanIn.ForeColor = System.Drawing.Color.White;
            this.ibtnThanhToanIn.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.ibtnThanhToanIn.IconColor = System.Drawing.Color.LightBlue;
            this.ibtnThanhToanIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThanhToanIn.IconSize = 30;
            this.ibtnThanhToanIn.Location = new System.Drawing.Point(785, 693);
            this.ibtnThanhToanIn.Margin = new System.Windows.Forms.Padding(4);
            this.ibtnThanhToanIn.Name = "ibtnThanhToanIn";
            this.ibtnThanhToanIn.Size = new System.Drawing.Size(163, 46);
            this.ibtnThanhToanIn.TabIndex = 7;
            this.ibtnThanhToanIn.Text = "Thanh Toán";
            this.ibtnThanhToanIn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtnThanhToanIn.UseVisualStyleBackColor = false;
            this.ibtnThanhToanIn.Click += new System.EventHandler(this.ibtnThanhToanIn_Click);
            // 
            // ibtnLoaiBo
            // 
            this.ibtnLoaiBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ibtnLoaiBo.FlatAppearance.BorderSize = 0;
            this.ibtnLoaiBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLoaiBo.ForeColor = System.Drawing.Color.White;
            this.ibtnLoaiBo.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ibtnLoaiBo.IconColor = System.Drawing.Color.LightBlue;
            this.ibtnLoaiBo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLoaiBo.IconSize = 30;
            this.ibtnLoaiBo.Location = new System.Drawing.Point(188, 693);
            this.ibtnLoaiBo.Margin = new System.Windows.Forms.Padding(4);
            this.ibtnLoaiBo.Name = "ibtnLoaiBo";
            this.ibtnLoaiBo.Size = new System.Drawing.Size(163, 46);
            this.ibtnLoaiBo.TabIndex = 7;
            this.ibtnLoaiBo.Text = "Loại Bỏ";
            this.ibtnLoaiBo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtnLoaiBo.UseVisualStyleBackColor = false;
            this.ibtnLoaiBo.Click += new System.EventHandler(this.ibtnLoaiBo_Click);
            // 
            // ibtncar
            // 
            this.ibtncar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ibtncar.FlatAppearance.BorderSize = 0;
            this.ibtncar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtncar.ForeColor = System.Drawing.Color.White;
            this.ibtncar.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.ibtncar.IconColor = System.Drawing.Color.LightBlue;
            this.ibtncar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtncar.IconSize = 30;
            this.ibtncar.Location = new System.Drawing.Point(889, 404);
            this.ibtncar.Margin = new System.Windows.Forms.Padding(4);
            this.ibtncar.Name = "ibtncar";
            this.ibtncar.Size = new System.Drawing.Size(235, 46);
            this.ibtncar.TabIndex = 7;
            this.ibtncar.Text = "Thêm Vào Giỏ Hàng";
            this.ibtncar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtncar.UseVisualStyleBackColor = false;
            this.ibtncar.Click += new System.EventHandler(this.ibtncar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "idnhom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "idnsx";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "giaban";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "tenthuoc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "nsx";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "hsd";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "soluong";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 790);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ibtnThanhToanIn);
            this.Controls.Add(this.ibtnLoaiBo);
            this.Controls.Add(this.ibtncar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sell";
            this.Text = "frmSellMedicine";
            this.Load += new System.EventHandler(this.Sell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton ibtncar;
        private FontAwesome.Sharp.IconButton ibtnLoaiBo;
        private FontAwesome.Sharp.IconButton ibtnThanhToanIn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}