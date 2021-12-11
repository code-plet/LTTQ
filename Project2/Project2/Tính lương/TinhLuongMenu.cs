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
    public partial class TinhLuongMenu : Form
    {
        public TinhLuongMenu()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChamCongButton_Click(object sender, EventArgs e)
        {
            frmChamCong ChamCongForm = new frmChamCong();
            ChamCongForm.ShowDialog();
        }

        private void BanKeLuongButton_Click(object sender, EventArgs e)
        {
            frmBanKeLuong bankeluongform = new frmBanKeLuong();
            bankeluongform.ShowDialog();
        }

        private void LuongChucDanhBtn_Click(object sender, EventArgs e)
        {
            frmLuongChucDanh LuongChucDanhForm = new frmLuongChucDanh();
            LuongChucDanhForm.ShowDialog();
        }
    }
}
