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
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtMKCu.Focus();
        }

        private void checkboxMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxMK.Checked)
            {
                txtMKCu.UseSystemPasswordChar = false;
                txtMKMoi.UseSystemPasswordChar = false;
                txtNhaplai.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKCu.UseSystemPasswordChar = true;
                txtMKMoi.UseSystemPasswordChar = true;
                txtNhaplai.UseSystemPasswordChar = true;
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMKCu.Clear();
            txtMKMoi.Clear();
            txtNhaplai.Clear();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string name = "";
            string password = DuLieu.Security.EncryptMd5(txtMKCu.Text);
            string password2 = DuLieu.Security.EncryptMd5(txtMKMoi.Text);
            DataTable dt = database.Read("SELECT * FROM NguoiDung WHERE NguoiDungID = '" + Login.ID_USER + "' AND MatKhau = '" + password + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                    name = dr["TenDangNhap"].ToString();
            }
            if (name != "")
            {             
                if (txtMKMoi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNhaplai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMKMoi.Text.Equals(txtNhaplai.Text))
                {
                    database.Read("UPDATE NguoiDung SET MatKhau ='" + password2 + "' WHERE NguoiDungID = '" + Login.ID_USER + "'");
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMKCu.Clear();
                    txtMKMoi.Clear();
                    txtNhaplai.Clear();
                }
                else
                    MessageBox.Show("Mật khẩu nhập lại không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
}
