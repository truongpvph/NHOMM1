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
    public partial class Loaidocgia : UserControl
    {
        LoaiDocGiaSevice sevice = new LoaiDocGiaSevice();
        public Loaidocgia()
        {
            sevice = new LoaiDocGiaSevice();
            InitializeComponent();
        }
        public void ShowData(List<LoaiDocGium> ldg)
        {
            dtgquanlyldg.Rows.Clear();
            dtgquanlyldg.ColumnCount = 5;
            int stt = 1;
            dtgquanlyldg.Columns[0].HeaderText = "Số thứ tự";
            dtgquanlyldg.Columns[1].HeaderText = "Mã độc giả";
            dtgquanlyldg.Columns[2].HeaderText = "Tên loại độc giả";
            dtgquanlyldg.Columns[3].HeaderText = "Số sách mượn tối đa";
            dtgquanlyldg.Columns[4].HeaderText = "Ngày mượn tối đa";
            foreach (var item in ldg)
            {
                dtgquanlyldg.Rows.Add(stt++, item.MaLoaiDocGia, item.TenLoaiDocGia,
                    item.SoSachMuonToiDa, item.NgayMuonToiDa);
            }
        }
        public void loadTkiem(string search = "")
        {
            dtgquanlyldg.ColumnCount = 5;
            dtgquanlyldg.Columns[0].HeaderText = "Số thứ tự";
            dtgquanlyldg.Columns[1].HeaderText = "Mã độc giả";
            dtgquanlyldg.Columns[2].HeaderText = "Tên loại độc giả";
            dtgquanlyldg.Columns[3].HeaderText = "Số sách mượn tối đa";
            dtgquanlyldg.Columns[4].HeaderText = "Ngày mượn tối đa";
            dtgquanlyldg.Rows.Clear();
            int stt = 1;
            var ldg = sevice.CNShow();
            if (!string.IsNullOrEmpty(search))
            {
                ldg = ldg.Where(x =>
                x.MaLoaiDocGia.ToLower().Contains(search.ToLower())).ToList();
            }
            foreach (var item in ldg)
            {
                dtgquanlyldg.Rows.Add(stt++, item.MaLoaiDocGia, item.TenLoaiDocGia,
                    item.SoSachMuonToiDa, item.NgayMuonToiDa);
            }
        }

        public void LoadLoaiDocGiaList()
        {
            List<string> loaiDocGiaList = new List<string>();

            loaiDocGiaList.Add("Giảng viên");
            loaiDocGiaList.Add("Sinh viên");

            cbbtenloaidocgia.Items.Clear();
            cbbtenloaidocgia.Items.AddRange(loaiDocGiaList.ToArray());

            if (cbbtenloaidocgia.Items.Count > 0)
            {
                cbbtenloaidocgia.SelectedIndex = 0;
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            List<LoaiDocGium> loaiDocGia = sevice.CNShow();
            ShowData(loaiDocGia);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoaiDocGium ldg = new LoaiDocGium();
                ldg.MaLoaiDocGia = "LDG" + (sevice.CNShow().Count + 1);
                ldg.TenLoaiDocGia = cbbtenloaidocgia.SelectedItem.ToString();
                ldg.SoSachMuonToiDa = Convert.ToInt32(txtsoluong.Text);
                ldg.NgayMuonToiDa = Convert.ToInt32(txtngaymuontoida.Text);
                MessageBox.Show(sevice.CNThem(ldg));
                loadTkiem();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtmadocgia.Text;
            string ten = cbbtenloaidocgia.SelectedItem.ToString();
            int sach = Convert.ToInt32(txtsoluong.Text);
            int ngay = Convert.ToInt32(txtngaymuontoida.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = sevice.CNSua(ma, ten, sach, ngay);
                MessageBox.Show(kq);
                List<LoaiDocGium> loaiDocGia = sevice.CNShow();
                ShowData(loaiDocGia);
                return;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchvalue = txtTimKiem.Text;
            loadTkiem(searchvalue);
        }

        private void dtgquanlyldg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgquanlyldg.Rows[e.RowIndex];
            txtmadocgia.Text = row.Cells[1].Value.ToString();
            cbbtenloaidocgia.Text = row.Cells[2].Value.ToString();
            txtsoluong.Text = row.Cells[3].Value.ToString();
            txtngaymuontoida.Text = row.Cells[4].Value.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dtgquanlyldg.Rows.Clear();
        }

        private void Loaidocgia_Load(object sender, EventArgs e)
        {
            LoadLoaiDocGiaList();
        }
    }
}
