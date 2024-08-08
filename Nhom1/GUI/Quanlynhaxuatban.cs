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
    public partial class Quanlynhaxuatban : UserControl
    {
        NXBSevice sevice = new NXBSevice();
        public Quanlynhaxuatban()
        {
            sevice = new NXBSevice();
            InitializeComponent();
        }
        public void Showdata(List<NhaXuatBan> xb)
        {
            dtgquanlynxb.Rows.Clear();
            dtgquanlynxb.ColumnCount = 6;
            int stt = 1;
            dtgquanlynxb.Columns[0].HeaderText = "Số thứ tự";
            dtgquanlynxb.Columns[1].HeaderText = "Mã nhà xuất bản";
            dtgquanlynxb.Columns[2].HeaderText = "Tên nhà xuất bản";
            dtgquanlynxb.Columns[3].HeaderText = "Địa chỉ";
            dtgquanlynxb.Columns[4].HeaderText = "Số điện thoại";
            dtgquanlynxb.Columns[5].HeaderText = "Email";
            foreach (var item in xb)
            {
                dtgquanlynxb.Rows.Add(stt++, item.MaNhaXuatBan, item.TenNhaXuatBan, item.DiaChi, item.Sdt, item.Email);
            }
        }
        public void loadTKiem(string search = "")
        {
            dtgquanlynxb.ColumnCount = 6;
            dtgquanlynxb.Columns[0].HeaderText = "Số thứ tự";
            dtgquanlynxb.Columns[1].HeaderText = "Mã nhà xuất bản";
            dtgquanlynxb.Columns[2].HeaderText = "Tên nhà xuất bản";
            dtgquanlynxb.Columns[3].HeaderText = "Địa chỉ";
            dtgquanlynxb.Columns[4].HeaderText = "Số điện thoại";
            dtgquanlynxb.Columns[5].HeaderText = "Email";
            dtgquanlynxb.Rows.Clear();
            int stt = 1;
            var xb = sevice.CNShow();
            if (!string.IsNullOrEmpty(search))
            {
                xb = xb.Where(x =>
                x.MaNhaXuatBan.ToLower().Contains(search.ToLower()) ||
                x.TenNhaXuatBan.ToLower().Contains(search.ToLower()) ||
                x.DiaChi.ToLower().Contains(search.ToLower())).ToList();
            }
            foreach (var item in xb)
            {
                dtgquanlynxb.Rows.Add(stt++, item.MaNhaXuatBan, item.TenNhaXuatBan, item.DiaChi, item.Sdt, item.Email);
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            List<NhaXuatBan> nhaXuatBans = sevice.CNShow();
            Showdata(nhaXuatBans);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sdt = txtSoDienThoai.Text;
            if (sevice.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại sai");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Thêm mới", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                NhaXuatBan xb = new NhaXuatBan();
                xb.MaNhaXuatBan = "NXB" + (sevice.CNShow().Count + 1);
                xb.TenNhaXuatBan = txttennhaxuatban.Text;
                xb.DiaChi = txtdiachi.Text;
                xb.Sdt = txtSoDienThoai.Text;
                xb.Email = txtemail.Text;
                MessageBox.Show(sevice.CNThem(xb));
                loadTKiem();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtmanhaxuatban.Text;
            string ten = txttennhaxuatban.Text;
            string dchi = txtdiachi.Text;
            string sdt = txtSoDienThoai.Text;
            string email = txtemail.Text;
            if (sevice.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại sai");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string kq = sevice.CNSua(ma, ten, dchi, sdt, email);
                MessageBox.Show(kq);
                List<NhaXuatBan> nhaXuatBans = sevice.CNShow();
                Showdata(nhaXuatBans);
                return;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchvalue = txtTimKiem.Text;
            loadTKiem(searchvalue);
        }

        private void dtgquanlynxb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgquanlynxb.Rows[e.RowIndex];
            txtmanhaxuatban.Text = row.Cells[1].Value.ToString();
            txttennhaxuatban.Text = row.Cells[2].Value.ToString();
            txtdiachi.Text = row.Cells[3].Value.ToString();
            txtSoDienThoai.Text = row.Cells[4].Value.ToString();
            txtemail.Text = row.Cells[5].Value.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            dtgquanlynxb.Rows.Clear();
        }
    }
}
