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
        private void panel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void GiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlydocgia qlydg = new Quanlydocgia();
            panel(qlydg);
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Thongke tk = new Thongke();
            panel(tk);
        }
    }
}
