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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {

        }
        private void panel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlytheloai quanlytheloai = new Quanlytheloai();
            panel(quanlytheloai);
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhaxuatban quanlynhaxuatban = new Quanlynhaxuatban();
            panel(quanlynhaxuatban);
        }

        private void loaidocgia_Click(object sender, EventArgs e)
        {
            Loaidocgia loaidocgia = new Loaidocgia();
            panel(loaidocgia);
        }
    }
}
