using Project2.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        Database database = new Database();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private string getID(string username, string password)
        {
            string id = "";
            password = DuLieu.Security.EncryptMd5(txtPassword.Text);
            DataTable dt = database.Read("SELECT * FROM NguoiDung WHERE TenDangNhap ='" + username + "' AND MatKhau = '" + password + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                    id = dr["NguoiDungID"].ToString();
            }
            return id;
        }

        public static string ID_USER = "";

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ID_USER = getID(txtUsername.Text, txtPassword.Text);
            if (ID_USER != "")
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}

