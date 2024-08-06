namespace GUI
{
    partial class Loaidocgia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnclear = new Button();
            btnhienthi = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtngaymuontoida = new TextBox();
            txtmadocgia = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtTimKiem = new TextBox();
            label8 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtsoluong = new TextBox();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnclear);
            groupBox1.Controls.Add(btnhienthi);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(txtngaymuontoida);
            groupBox1.Controls.Add(txtmadocgia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(688, 624);
            groupBox1.TabIndex = 134;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Loại Độc Giả";
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.FromArgb(255, 192, 128);
            btnclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnclear.Location = new Point(554, 404);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 128;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(22, 404);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 127;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(388, 404);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 125;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(208, 404);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 124;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txtngaymuontoida
            // 
            txtngaymuontoida.Location = new Point(172, 258);
            txtngaymuontoida.Name = "txtngaymuontoida";
            txtngaymuontoida.Size = new Size(489, 27);
            txtngaymuontoida.TabIndex = 121;
            // 
            // txtmadocgia
            // 
            txtmadocgia.BackColor = Color.FromArgb(224, 224, 224);
            txtmadocgia.Enabled = false;
            txtmadocgia.Location = new Point(172, 68);
            txtmadocgia.Name = "txtmadocgia";
            txtmadocgia.Size = new Size(489, 27);
            txtmadocgia.TabIndex = 119;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(7, 265);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 118;
            label5.Text = "Ngày Mượn Tối Đa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(20, 148);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 117;
            label3.Text = "Tên Loại Độc Giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 75);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 116;
            label1.Text = "Mã Loại Độc Giả";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(756, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(764, 619);
            groupBox2.TabIndex = 135;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Độc Giả";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(755, 486);
            dataGridView1.TabIndex = 126;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(179, 41);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo Tên Độc Giả ";
            txtTimKiem.Size = new Size(551, 27);
            txtTimKiem.TabIndex = 125;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(73, 48);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 124;
            label8.Text = "Tìm Kiếm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(643, 13);
            label2.Name = "label2";
            label2.Size = new Size(181, 38);
            label2.TabIndex = 136;
            label2.Text = "Loại Độc Giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(6, 208);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 129;
            label4.Text = "Số Sách Mượn Tối Đa";
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(172, 201);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(489, 27);
            txtsoluong.TabIndex = 130;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(173, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(488, 28);
            comboBox1.TabIndex = 131;
            // 
            // Loaidocgia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Name = "Loaidocgia";
            Size = new Size(1639, 776);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnclear;
        private Button btnhienthi;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtngaymuontoida;
        private TextBox txtmadocgia;
        private Label label5;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox txtTimKiem;
        private Label label8;
        private Label label2;
        private TextBox txtsoluong;
        private Label label4;
        private ComboBox comboBox1;
    }
}
