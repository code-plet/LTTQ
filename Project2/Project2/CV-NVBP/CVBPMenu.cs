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
    public partial class CVBPMenu : MetroFramework.Forms.MetroForm
    {
        public CVBPMenu()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChucVuBtn_Click(object sender, EventArgs e)
        {
            ChucVu CV = new ChucVu();
            CV.ShowDialog();
        }

        private void NVBPButton_Click(object sender, EventArgs e)
        {
            NVBP nvbp = new NVBP();
            nvbp.ShowDialog();
        }
    }
}
