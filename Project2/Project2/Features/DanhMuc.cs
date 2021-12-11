using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2.Features
{
    public partial class DanhMuc : MetroFramework.Forms.MetroForm
    {
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            this.Close();
            ThemBoPhan themBoPhan = new ThemBoPhan();
            themBoPhan.ShowDialog();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            this.Close();
            ThemLoaiHD themLoaiHD = new ThemLoaiHD();
            themLoaiHD.ShowDialog();
        }
    }
}
