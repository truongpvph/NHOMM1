namespace GUI
{
    partial class Quanlyphieutra
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
            cbbtendocgia = new TextBox();
            txtmaphieutra = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            cbbtennhanvien = new ComboBox();
            cbbmaphieumuon = new ComboBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbmaphieumuon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbbtennhanvien);
            groupBox1.Controls.Add(btnclear);
            groupBox1.Controls.Add(btnhienthi);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(cbbtendocgia);
            groupBox1.Controls.Add(txtmaphieutra);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(72, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 624);
            groupBox1.TabIndex = 140;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phiếu Trả";
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.FromArgb(255, 192, 128);
            btnclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnclear.Location = new Point(555, 539);
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
            btnhienthi.Location = new Point(23, 539);
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
            btnsua.Location = new Point(389, 539);
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
            btnthem.Location = new Point(209, 539);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 124;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // cbbtendocgia
            // 
            cbbtendocgia.Location = new Point(160, 331);
            cbbtendocgia.Name = "cbbtendocgia";
            cbbtendocgia.Size = new Size(489, 27);
            cbbtendocgia.TabIndex = 121;
            // 
            // txtmaphieutra
            // 
            txtmaphieutra.BackColor = Color.White;
            txtmaphieutra.Enabled = false;
            txtmaphieutra.Location = new Point(165, 91);
            txtmaphieutra.Name = "txtmaphieutra";
            txtmaphieutra.Size = new Size(489, 27);
            txtmaphieutra.TabIndex = 119;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(25, 334);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 118;
            label5.Text = "Tên Độc Giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(23, 172);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 117;
            label3.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 98);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 116;
            label1.Text = "Mã Phiếu Trả";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(803, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(764, 306);
            groupBox2.TabIndex = 141;
            groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(755, 258);
            dataGridView1.TabIndex = 126;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(667, 20);
            label2.Name = "label2";
            label2.Size = new Size(253, 38);
            label2.TabIndex = 142;
            label2.Text = "Quản Lý Phiếu Trả";
            // 
            // cbbtennhanvien
            // 
            cbbtennhanvien.FormattingEnabled = true;
            cbbtennhanvien.Location = new Point(165, 164);
            cbbtennhanvien.Name = "cbbtennhanvien";
            cbbtennhanvien.Size = new Size(484, 28);
            cbbtennhanvien.TabIndex = 129;
            // 
            // cbbmaphieumuon
            // 
            cbbmaphieumuon.FormattingEnabled = true;
            cbbmaphieumuon.Location = new Point(165, 244);
            cbbmaphieumuon.Name = "cbbmaphieumuon";
            cbbmaphieumuon.Size = new Size(484, 28);
            cbbmaphieumuon.TabIndex = 131;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(23, 252);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 130;
            label4.Text = "Mã Phiếu Mượn";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(803, 447);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(773, 312);
            groupBox3.TabIndex = 142;
            groupBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(755, 280);
            dataGridView2.TabIndex = 126;
            // 
            // Quanlyphieutra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Name = "Quanlyphieutra";
            Size = new Size(1639, 776);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnclear;
        private Button btnhienthi;
        private Button btnsua;
        private Button btnthem;
        private TextBox cbbtendocgia;
        private TextBox txtHoTen;
        private TextBox txtmaphieutra;
        private Label label5;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox cbbmaphieumuon;
        private Label label4;
        private ComboBox cbbtennhanvien;
        private GroupBox groupBox3;
        private DataGridView dataGridView2;
    }
}
