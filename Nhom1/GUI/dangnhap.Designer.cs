namespace GUI
{
    partial class Dangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txttaikhoan = new TextBox();
            groupBox1 = new GroupBox();
            txtmatkhau = new TextBox();
            btnthoat = new Button();
            label1 = new Label();
            btndangnhap = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txttaikhoan
            // 
            txttaikhoan.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttaikhoan.Location = new Point(6, 26);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(256, 27);
            txttaikhoan.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txttaikhoan);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Lime;
            groupBox1.Location = new Point(374, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 58);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài Khoản ";
            // 
            // txtmatkhau
            // 
            txtmatkhau.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmatkhau.Location = new Point(0, 26);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(262, 27);
            txtmatkhau.TabIndex = 5;
            txtmatkhau.UseSystemPasswordChar = true;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.FromArgb(192, 255, 255);
            btnthoat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.ForeColor = Color.Red;
            btnthoat.Location = new Point(523, 429);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(118, 43);
            btnthoat.TabIndex = 43;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("VNI-Awchon", 17.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(265, 80);
            label1.Name = "label1";
            label1.Size = new Size(482, 39);
            label1.TabIndex = 39;
            label1.Text = "HỆ THỐNG ĐĂNG NHẬP THƯ vIỆN ";
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = Color.FromArgb(192, 255, 255);
            btndangnhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndangnhap.ForeColor = Color.Red;
            btndangnhap.Location = new Point(374, 429);
            btndangnhap.Margin = new Padding(1);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(117, 43);
            btndangnhap.TabIndex = 42;
            btndangnhap.Text = "Đăng Nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtmatkhau);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Lime;
            groupBox2.Location = new Point(374, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 56);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật Khẩu ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.anhdangnhap;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 563);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // Dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 567);
            Controls.Add(groupBox1);
            Controls.Add(btnthoat);
            Controls.Add(label1);
            Controls.Add(btndangnhap);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Name = "Dangnhap";
            Text = "Đăng Nhập";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttaikhoan;
        private GroupBox groupBox1;
        private TextBox txtmatkhau;
        private Button btnthoat;
        private Label label1;
        private Button btndangnhap;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}
