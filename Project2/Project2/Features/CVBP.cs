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
    public partial class CVBP : MetroFramework.Forms.MetroForm
    {
        public CVBP()
        {
            InitializeComponent();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            ChucVu chucVu = new ChucVu();
            chucVu.Show();
            this.Hide();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            BoPhan boPhan = new BoPhan();
            boPhan.Show();
            this.Hide();
        }

        private void CVBP_Load(object sender, EventArgs e)
        {

        }
    }
}
