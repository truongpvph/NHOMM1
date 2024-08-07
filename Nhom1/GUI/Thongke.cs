using BLL;
using DTO.Context;
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
    public partial class Thongke : UserControl
    {
        
        ChitietBLL services;
        SachBLL service;
        PhieumuonBLL servicepm;
        PhieutraBLL servicept;

        public Thongke()
        {
            InitializeComponent();
            services = new ChitietBLL();
            service = new SachBLL();
            servicepm = new PhieumuonBLL();
            servicept = new PhieutraBLL();
            LoadData();
        }

        private void labtongslsach_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {   
            var sosach = service.GetSaches();
            int tongs = (int)sosach.Sum(s => s.SoLuong);
            int dau = sosach.Count();
            var pm = servicepm.GetPhieuMuons();
            var pt = servicept.GetPhieutras();
            int sopm = pm.Count();
            int sopt = pt.Count();
            var dangmuon = services.GetChiTietPhieuMuons();
            int sodangmuon = dangmuon.Where(ct => !ct.HanTra.HasValue).Sum(ct => ct.SoLuong ?? 0);
            labtongslsach.Text =tongs.ToString();
            lbldausach.Text = dau.ToString();
            labtongsoluongsachchomuon.Text = sodangmuon.ToString();
            labtongphieumuon.Text = sopm.ToString();
            lbltongpt.Text = sopt.ToString();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            LoadOverdueData();
            
        }
        private void LoadOverdueData()
        {
            using (var context = new MyContext())
            {
                DateTime now = DateTime.Now;

                var overdueDetails = from ctp in context.ChiTietPhieuMuons
                                     join pm in context.PhieuMuons on ctp.MaPhieuMuon equals pm.MaPhieuMuon
                                     join dg in context.DocGia on pm.MaDocGia equals dg.MaDocGia
                                     join s in context.Saches on ctp.MaSach equals s.MaSach
                                     where ctp.HanTra < now && ctp.SoLuong > 0
                                     select new
                                     {
                                         MaChiTietPhieuMuon = ctp.MaChiTietPhieuMuon,
                                         MaPhieuMuon = ctp.MaPhieuMuon,
                                         TenDocGia = dg.TenDocGia,
                                         TenSach = s.TenSach,
                                         SoLuong = ctp.SoLuong,
                                         HanTra = ctp.HanTra
                                     };

                dataGridView1.DataSource = overdueDetails.ToList();
            }
        }
    }
}
