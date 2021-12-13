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
    public partial class Welcome : MetroFramework.Forms.MetroForm
    {
        public Welcome()
        {
            InitializeComponent();
            labelTime.Text = DateTime.Now.ToString();
        }

        Database database = new Database();

        private void Welcome_Load(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM NguoiDung WHERE NguoiDungID ='" + Login.ID_USER + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblUsername.Text = dr["TenDangNhap"].ToString();
                }    
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng Xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                this.Close();
                Application.Restart();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
        }

        private void btnPhanquyen_Click(object sender, EventArgs e)
        {
            if (UserAccount.HeThongAccess || UserAccount.QuanTriAccess)
            {
                PhanQuyen phanQuyen = new PhanQuyen();
                phanQuyen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Vượt Quyền Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {          
                ChangePassword changePassword = new ChangePassword();
                changePassword.ShowDialog();              
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            if (UserAccount.QuanTriAccess || UserAccount.HeThongAccess)
            {
                QuanLyNguoiDung quanLy = new QuanLyNguoiDung();
                quanLy.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Vượt Quyền Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnTinhluong_Click(object sender, EventArgs e)
        {
            if (UserAccount.TienLuongAccess || UserAccount.QuanTriAccess)
            {
                TinhLuongMenu tinhluong = new TinhLuongMenu();
                DialogResult TinhLuongResult = tinhluong.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Vượt Quyền Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHopdong_Click(object sender, EventArgs e)
        {
            if (UserAccount.NhanSuAccess || UserAccount.QuanTriAccess)
            {
                HopDong hopDong = new HopDong();
                hopDong.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Vượt Quyền Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHoso_Click(object sender, EventArgs e)
        {
            if (UserAccount.NhanSuAccess || UserAccount.QuanTriAccess)
            {
                HoSo hoSo = new HoSo();
                hoSo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Vượt Quyền Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCVBP_Click(object sender, EventArgs e)
        {
            if (UserAccount.NhanSuAccess || UserAccount.QuanTriAccess)
            {
                CVBPMenu CVBP = new CVBPMenu();
                CVBP.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Vượt Quyền Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (UserAccount.DanhMucAccess || UserAccount.QuanTriAccess)
            {
                DanhMucMenu danhMuc = new DanhMucMenu();
                danhMuc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này", "Vượt Quyền Truy Cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
