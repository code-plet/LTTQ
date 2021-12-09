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
        string isAdmin;

        private void Welcome_Load(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM NguoiDung WHERE NguoiDungID ='" + Login.ID_USER + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lblUsername.Text = dr["TenDangNhap"].ToString();
                    isAdmin = dr["QuanTri"].ToString();
                }    
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng Xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
        }

        private void btnPhanquyen_Click(object sender, EventArgs e)
        {
            if (isAdmin == "False")
            {
                MessageBox.Show("Bạn không có quyền để sử dụng tính năng này", isAdmin, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PhanQuyen phanQuyen = new PhanQuyen();
                phanQuyen.Show();
            }    
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {          
                ChangePassword changePassword = new ChangePassword();
                changePassword.Show();              
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung quanLy = new QuanLyNguoiDung();
            quanLy.Show();
        }

        private void btnTinhluong_Click(object sender, EventArgs e)
        {
            TinhLuongMenu tinhluong = new TinhLuongMenu();
            DialogResult TinhLuongResult = tinhluong.ShowDialog();
        }
    }
}
