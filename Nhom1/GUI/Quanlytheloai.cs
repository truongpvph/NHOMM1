using BLL;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Quanlytheloai : UserControl
    {
        TheLoaiSevice sevice = new TheLoaiSevice();
        public Quanlytheloai()
        {
            sevice = new TheLoaiSevice();
            InitializeComponent();
        }
        public void ShowData(List<TheLoai> tl)
        {
            dtgquanlytl.Rows.Clear();
            dtgquanlytl.ColumnCount = 3;
            int stt = 1;
            dtgquanlytl.Columns[0].HeaderText = "Số thứ tự";
            dtgquanlytl.Columns[1].HeaderText = "Mã thể loại";
            dtgquanlytl.Columns[2].HeaderText = "Tên thể loại";
            foreach (var item in tl)
            {
                dtgquanlytl.Rows.Add(stt++, item.MaTheLoai, item.TenTheLoai);
            }
        }
        public void loadTKiem(string search = "")
        {
            dtgquanlytl.ColumnCount = 3;
            dtgquanlytl.Columns[0].HeaderText = "Số thứ tự";
            dtgquanlytl.Columns[1].HeaderText = "Mã thể loại";
            dtgquanlytl.Columns[2].HeaderText = "Tên thể loại";
            dtgquanlytl.Rows.Clear();
            int stt = 1;
            var tl = sevice.CNShow();
            if (!string.IsNullOrEmpty(search))
            {
                tl = tl.Where(x =>
                x.MaTheLoai.ToLower().Contains(search.ToLower()) ||
                x.TenTheLoai.ToLower().Contains(search.ToLower())).ToList();
            }
            foreach (var item in tl)
            {
                dtgquanlytl.Rows.Add(stt++, item.MaTheLoai, item.TenTheLoai);
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            List<TheLoai> theLoais = sevice.CNShow();
            ShowData(theLoais);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TheLoai tl = new TheLoai();
                tl.MaTheLoai = "TL" + (sevice.CNShow().Count + 1);
                tl.TenTheLoai = txttentheloai.Text;
                MessageBox.Show(sevice.CNThem(tl));
                loadTKiem();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ten = txttentheloai.Text;
            string ma = txtmatheloai.Text;
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = sevice.CNSua(ma, ten);
                MessageBox.Show(kq);
                List<TheLoai> theLoais = sevice.CNShow();
                ShowData(theLoais);
                return;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchvalue = txtTimKiem.Text;
            loadTKiem(searchvalue);
        }

        private void dtgquanlytl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgquanlytl.Rows[e.RowIndex];
            txtmatheloai.Text = row.Cells[1].Value.ToString();
            txttentheloai.Text = row.Cells[2].Value.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dtgquanlytl.Rows.Clear();
        }
    }
}

