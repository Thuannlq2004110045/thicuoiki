namespace GUI
{
    partial class FormBanHang
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
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.quanLySieuThiDataSet = new GUI.QuanLySieuThiDataSet();
            this.tblStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStaffTableAdapter = new GUI.QuanLySieuThiDataSetTableAdapters.tblStaffTableAdapter();
            this.idNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySieuThiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(1105, 495);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 29);
            this.label11.TabIndex = 40;
            this.label11.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(957, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 29);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tổng tiền:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(946, 549);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 33);
            this.textBox2.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(946, 605);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 33);
            this.textBox1.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 24);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.Text = "Nước Giải Khát";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Location = new System.Drawing.Point(768, 599);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 39);
            this.button4.TabIndex = 35;
            this.button4.Text = "Tính tiền trả lại";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(768, 673);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 53);
            this.button3.TabIndex = 34;
            this.button3.Text = "In hóa đơn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(539, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 53);
            this.button1.TabIndex = 33;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(234, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 43);
            this.button2.TabIndex = 32;
            this.button2.Text = "Thêm vào hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Column4";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(62, 443);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(549, 300);
            this.dataGridView2.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.tuoiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStaffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(685, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 333);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(876, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "Danh sách hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(112, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "Số lượng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(111, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(111, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(111, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tên Khách";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(763, 549);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tiền khách đưa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(1188, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(550, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lập hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(111, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "tên nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Location = new System.Drawing.Point(1165, 673);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 53);
            this.button5.TabIndex = 41;
            this.button5.Text = "Đăng xuất";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(272, 99);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 33);
            this.textBox3.TabIndex = 75;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(272, 159);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 33);
            this.textBox4.TabIndex = 76;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(272, 223);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 33);
            this.textBox5.TabIndex = 77;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(272, 282);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(239, 33);
            this.textBox6.TabIndex = 78;
            // 
            // quanLySieuThiDataSet
            // 
            this.quanLySieuThiDataSet.DataSetName = "QuanLySieuThiDataSet";
            this.quanLySieuThiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStaffBindingSource
            // 
            this.tblStaffBindingSource.DataMember = "tblStaff";
            this.tblStaffBindingSource.DataSource = this.quanLySieuThiDataSet;
            // 
            // tblStaffTableAdapter
            // 
            this.tblStaffTableAdapter.ClearBeforeFill = true;
            // 
            // idNVDataGridViewTextBoxColumn
            // 
            this.idNVDataGridViewTextBoxColumn.DataPropertyName = "idNV";
            this.idNVDataGridViewTextBoxColumn.HeaderText = "idNV";
            this.idNVDataGridViewTextBoxColumn.MinimumWidth = 3;
            this.idNVDataGridViewTextBoxColumn.Name = "idNVDataGridViewTextBoxColumn";
            this.idNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tuoiDataGridViewTextBoxColumn
            // 
            this.tuoiDataGridViewTextBoxColumn.DataPropertyName = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.HeaderText = "Tuoi";
            this.tuoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tuoiDataGridViewTextBoxColumn.Name = "tuoiDataGridViewTextBoxColumn";
            this.tuoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 793);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySieuThiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private QuanLySieuThiDataSet quanLySieuThiDataSet;
        private System.Windows.Forms.BindingSource tblStaffBindingSource;
        private QuanLySieuThiDataSetTableAdapters.tblStaffTableAdapter tblStaffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}