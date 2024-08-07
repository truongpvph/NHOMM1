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
    public partial class Quanlydocgia : UserControl
    {
        DocgiaBLL service;
        LoaidocgiaBLL services;
        public string idWhenClick;
        public Quanlydocgia()
        {
            InitializeComponent();
            service = new DocgiaBLL();
            services = new LoaidocgiaBLL();
            b();
        }
        public void loadgrid()
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã độc giả";
            dataGridView1.Columns[2].Name = "Tên loại độc giả";
            dataGridView1.Columns[3].Name = "Tên độc giả";
            dataGridView1.Columns[4].Name = "Ngày sinh";
            dataGridView1.Columns[5].Name = "Địa chỉ";
            dataGridView1.Columns[6].Name = "Email";
            dataGridView1.Columns[7].Name = "CCCD";
            dataGridView1.Columns[8].Name = "SĐT";
            dataGridView1.Rows.Clear();
            int stt = 1;
            var docGiaList = service.GetDocGia();
            var loaiDocGiaList = services.GetLoaiDocGia();
            foreach (var dg in docGiaList)
            {
                var loaiDocGia = loaiDocGiaList.FirstOrDefault(ldg => ldg.MaLoaiDocGia == dg.LoaiDocGia)?.TenLoaiDocGia;
                dataGridView1.Rows.Add(stt++,
                                       dg.MaDocGia,
                                       loaiDocGia,
                                       dg.TenDocGia,
                                       dg.NgaySinh,
                                       dg.DiaChi,
                                       dg.Email,
                                       dg.Cmnd,
                                       dg.Sdt);
            }
        }
        public void load()
        {
            var dg = service.GetDocGia().Find(x => x.MaDocGia == idWhenClick);
            var loaiDocGia = services.GetLoaiDocGia().FirstOrDefault(ldg => ldg.MaLoaiDocGia == dg.LoaiDocGia)?.TenLoaiDocGia;
            txtmadocgia.Text = dg.MaDocGia;
            cbbtenloaidocgia.Text = loaiDocGia;
            txtHoTen.Text = dg.TenDocGia;
            datengaysinh.Text = dg.NgaySinh.ToString();
            txtdiachi.Text = dg.DiaChi;
            txtemail.Text = dg.Email;
            txtcccd.Text = dg.Cmnd;
            txtsodienthoai.Text = dg.Sdt;
        }
        public void b()
        {
            cbbtenloaidocgia.Items.Clear();
            foreach (var dg in services.GetLoaiDocGia())
            {
                cbbtenloaidocgia.Items.Add(dg.TenLoaiDocGia);
            }
            if (cbbtenloaidocgia.Items.Count > 0)
            {
                cbbtenloaidocgia.SelectedIndex = 0;
            }
        }
        private void btnhienthi_Click(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị từ ô đã chọn
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;

                // Kiểm tra nếu giá trị ô không phải null và không rỗng
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                {
                    idWhenClick = cellValue.ToString();
                    load();
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmadocgia.Text = "";
            cbbtenloaidocgia.Text = "";
            txtHoTen.Text = "";
            datengaysinh.Value = DateTime.Now;
            txtdiachi.Text = "";
            txtemail.Text = "";
            txtcccd.Text = "";
            txtsodienthoai.Text = "";
            txtTimKiem.Text = "";
            loadgrid();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DocGium dg = new DocGium();
                var loaiDocGia = services.GetLoaiDocGia().FirstOrDefault(ldg => ldg.TenLoaiDocGia == cbbtenloaidocgia.SelectedItem.ToString());
                dg.MaDocGia = "DG" + (service.GetDocGia().Count + 1);
                dg.LoaiDocGia = loaiDocGia.MaLoaiDocGia;
                dg.TenDocGia = txtHoTen.Text;
                dg.NgaySinh = DateTime.Parse(datengaysinh.Value.ToShortDateString());
                dg.DiaChi = txtdiachi.Text;
                dg.Email = txtemail.Text;
                dg.Cmnd = txtcccd.Text;
                dg.Sdt = txtsodienthoai.Text;
                MessageBox.Show(service.ThemDG(dg));
                loadgrid();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DocGium dg = service.GetDocGia().Find(x => x.MaDocGia == idWhenClick);
                var loaiDocGia = services.GetLoaiDocGia().FirstOrDefault(ldg => ldg.TenLoaiDocGia == cbbtenloaidocgia.SelectedItem.ToString());
                dg.LoaiDocGia = loaiDocGia.MaLoaiDocGia;
                dg.TenDocGia = txtHoTen.Text;
                dg.NgaySinh = DateTime.Parse(datengaysinh.Value.ToShortDateString());
                dg.DiaChi = txtdiachi.Text;
                dg.Email = txtemail.Text;
                dg.Cmnd = txtcccd.Text;
                dg.Sdt = txtsodienthoai.Text;
                MessageBox.Show(service.SuaDG(dg));
                loadgrid();
            }
        }
        public void timkiem(string search = "")
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã độc giả";
            dataGridView1.Columns[2].Name = "Tên loại độc giả";
            dataGridView1.Columns[3].Name = "Tên độc giả";
            dataGridView1.Columns[4].Name = "Ngày sinh";
            dataGridView1.Columns[5].Name = "Địa chỉ";
            dataGridView1.Columns[6].Name = "Email";
            dataGridView1.Columns[7].Name = "CCCD";
            dataGridView1.Columns[8].Name = "SĐT";
            dataGridView1.Rows.Clear();
            int stt = 1;
            var loaiDocGiaList = services.GetLoaiDocGia();
            var docGiaList = service.GetDocGia();

            if (!string.IsNullOrEmpty(search))
            {
                docGiaList = docGiaList.Where(x => x.TenDocGia.ToLower().Contains(search.ToLower())).ToList();
            }

            foreach (var dgg in docGiaList)
            {
                var tenLoaiDocGia = loaiDocGiaList.FirstOrDefault(ldg => ldg.MaLoaiDocGia == dgg.LoaiDocGia)?.TenLoaiDocGia;
                dataGridView1.Rows.Add(stt++,
                                       dgg.MaDocGia,
                                       tenLoaiDocGia,
                                       dgg.TenDocGia,
                                       dgg.NgaySinh,
                                       dgg.DiaChi,
                                       dgg.Email,
                                       dgg.Cmnd,
                                       dgg.Sdt);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text;
            timkiem(search);
        }
    }
}
