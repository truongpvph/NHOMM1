namespace GUI
{
    partial class Thongke
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
            labtongsoluongsachchomuon = new Label();
            label4 = new Label();
            lbldausach = new Label();
            labtongslsach = new Label();
            labtongsoluongdausach = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lbltongpt = new Label();
            label6 = new Label();
            labtongphieumuon = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labtongsoluongsachchomuon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbldausach);
            groupBox1.Controls.Add(labtongslsach);
            groupBox1.Controls.Add(labtongsoluongdausach);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 205);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống Kê Sách";
            // 
            // labtongsoluongsachchomuon
            // 
            labtongsoluongsachchomuon.AutoSize = true;
            labtongsoluongsachchomuon.Location = new Point(321, 136);
            labtongsoluongsachchomuon.Name = "labtongsoluongsachchomuon";
            labtongsoluongsachchomuon.Size = new Size(17, 20);
            labtongsoluongsachchomuon.TabIndex = 5;
            labtongsoluongsachchomuon.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 136);
            label4.Name = "label4";
            label4.Size = new Size(218, 20);
            label4.TabIndex = 4;
            label4.Text = "Tổng Số Lượng Sách Cho Mượn";
            // 
            // lbldausach
            // 
            lbldausach.AutoSize = true;
            lbldausach.Location = new Point(321, 84);
            lbldausach.Name = "lbldausach";
            lbldausach.Size = new Size(17, 20);
            lbldausach.TabIndex = 3;
            lbldausach.Text = "0";
            // 
            // labtongslsach
            // 
            labtongslsach.AutoSize = true;
            labtongslsach.Location = new Point(321, 39);
            labtongslsach.Name = "labtongslsach";
            labtongslsach.Size = new Size(17, 20);
            labtongslsach.TabIndex = 2;
            labtongslsach.Text = "0";
            labtongslsach.Click += labtongslsach_Click;
            // 
            // labtongsoluongdausach
            // 
            labtongsoluongdausach.AutoSize = true;
            labtongsoluongdausach.Location = new Point(40, 84);
            labtongsoluongdausach.Name = "labtongsoluongdausach";
            labtongsoluongdausach.Size = new Size(176, 20);
            labtongsoluongdausach.TabIndex = 1;
            labtongsoluongdausach.Text = "Tổng Số Lượng Đầu Sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 39);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Tổng Số Lượng Sách";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbltongpt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(labtongphieumuon);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(870, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(647, 205);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống Kê Phiếu Mượn-Trả";
            // 
            // lbltongpt
            // 
            lbltongpt.AutoSize = true;
            lbltongpt.Location = new Point(290, 84);
            lbltongpt.Name = "lbltongpt";
            lbltongpt.Size = new Size(17, 20);
            lbltongpt.TabIndex = 7;
            lbltongpt.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 39);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 4;
            label6.Text = "Tổng Số Phiếu Mượn";
            // 
            // labtongphieumuon
            // 
            labtongphieumuon.AutoSize = true;
            labtongphieumuon.Location = new Point(290, 39);
            labtongphieumuon.Name = "labtongphieumuon";
            labtongphieumuon.Size = new Size(17, 20);
            labtongphieumuon.TabIndex = 6;
            labtongphieumuon.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 84);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 5;
            label5.Text = "Tổng Số Phiếu Trả";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(25, 350);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1492, 381);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống Kê Quá Hạn";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1469, 333);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(622, 297);
            button1.Name = "button1";
            button1.Size = new Size(235, 47);
            button1.TabIndex = 3;
            button1.Text = "Xem Chi Tiết Phiếu Quá Hạn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Thongke";
            Size = new Size(1639, 776);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbldausach;
        private Label labtongslsach;
        private Label labtongsoluongdausach;
        private Label label1;
        private GroupBox groupBox2;
        private Label lbltongpt;
        private Label label6;
        private Label labtongphieumuon;
        private Label label5;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button button1;
        private Label labtongsoluongsachchomuon;
        private Label label4;
    }
}
