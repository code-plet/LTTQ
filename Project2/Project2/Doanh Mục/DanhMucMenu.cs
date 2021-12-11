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
    public partial class DanhMucMenu : MetroFramework.Forms.MetroForm
    {
        public DanhMucMenu()
        {
            InitializeComponent();
        }

        private void BoPhanButton_Click(object sender, EventArgs e)
        {
            ThemBoPhan thembp = new ThemBoPhan();
            thembp.ShowDialog();
        }

        private void LoaiHopDongButton_Click(object sender, EventArgs e)
        {
            ThemLoaiHD Themhd = new ThemLoaiHD();
            Themhd.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
