namespace GUI
{
    partial class Timkiemphieumuon
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
            groupBox6 = new GroupBox();
            groupBox8 = new GroupBox();
            txtTimKiem = new TextBox();
            groupBox7 = new GroupBox();
            rdomaphieumuon = new RadioButton();
            rdotendocgia = new RadioButton();
            rdomaphieutra = new RadioButton();
            dataGridView1 = new DataGridView();
            btnxemchitiet = new Button();
            btnxemtatca = new Button();
            button3 = new Button();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(groupBox8);
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Location = new Point(253, 25);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1009, 192);
            groupBox6.TabIndex = 144;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tìm Kiếm";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(button3);
            groupBox8.Controls.Add(txtTimKiem);
            groupBox8.Location = new Point(13, 110);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(975, 78);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Nội Dung Cần Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(6, 32);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(768, 27);
            txtTimKiem.TabIndex = 110;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(rdomaphieumuon);
            groupBox7.Controls.Add(rdotendocgia);
            groupBox7.Controls.Add(rdomaphieutra);
            groupBox7.Location = new Point(13, 26);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(975, 78);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Tìm kiếm theo";
            // 
            // rdomaphieumuon
            // 
            rdomaphieumuon.AutoSize = true;
            rdomaphieumuon.Location = new Point(621, 26);
            rdomaphieumuon.Name = "rdomaphieumuon";
            rdomaphieumuon.Size = new Size(134, 24);
            rdomaphieumuon.TabIndex = 2;
            rdomaphieumuon.TabStop = true;
            rdomaphieumuon.Text = "Mã Phiếu Mượn";
            rdomaphieumuon.UseVisualStyleBackColor = true;
            // 
            // rdotendocgia
            // 
            rdotendocgia.AutoSize = true;
            rdotendocgia.Location = new Point(339, 33);
            rdotendocgia.Name = "rdotendocgia";
            rdotendocgia.Size = new Size(110, 24);
            rdotendocgia.TabIndex = 1;
            rdotendocgia.TabStop = true;
            rdotendocgia.Text = "Tên Độc Giả";
            rdotendocgia.UseVisualStyleBackColor = true;
            // 
            // rdomaphieutra
            // 
            rdomaphieutra.AutoSize = true;
            rdomaphieutra.Location = new Point(44, 33);
            rdomaphieutra.Name = "rdomaphieutra";
            rdomaphieutra.Size = new Size(115, 24);
            rdomaphieutra.TabIndex = 0;
            rdomaphieutra.TabStop = true;
            rdomaphieutra.Text = "Mã Phiếu Trả";
            rdomaphieutra.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 294);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1504, 335);
            dataGridView1.TabIndex = 145;
            // 
            // btnxemchitiet
            // 
            btnxemchitiet.Location = new Point(1385, 145);
            btnxemchitiet.Name = "btnxemchitiet";
            btnxemchitiet.Size = new Size(150, 29);
            btnxemchitiet.TabIndex = 146;
            btnxemchitiet.Text = "Xem Chi Tiết";
            btnxemchitiet.UseVisualStyleBackColor = true;
            // 
            // btnxemtatca
            // 
            btnxemtatca.Location = new Point(1385, 51);
            btnxemtatca.Name = "btnxemtatca";
            btnxemtatca.Size = new Size(150, 29);
            btnxemtatca.TabIndex = 147;
            btnxemtatca.Text = "Xem Tất Cả";
            btnxemtatca.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(809, 32);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 148;
            button3.Text = "Tìm Kiếm";
            button3.UseVisualStyleBackColor = true;
            // 
            // Timkiemphieumuon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnxemtatca);
            Controls.Add(btnxemchitiet);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox6);
            Name = "Timkiemphieumuon";
            Size = new Size(1639, 776);
            groupBox6.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox6;
        private GroupBox groupBox8;
        private Button button3;
        private TextBox txtTimKiem;
        private GroupBox groupBox7;
        private RadioButton rdomaphieumuon;
        private RadioButton rdotendocgia;
        private RadioButton rdomaphieutra;
        private DataGridView dataGridView1;
        private Button btnxemchitiet;
        private Button btnxemtatca;
    }
}
