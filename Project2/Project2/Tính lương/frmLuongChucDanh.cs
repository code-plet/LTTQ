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
    public partial class frmLuongChucDanh : Form
    {
        public frmLuongChucDanh()
        {
            InitializeComponent();
        }
        int kt = 0;
        int ChucDanhID = 0;
        Database db = new Database();
        void Load_DL()
        {
            string sql = "Select * from LuongChucDanh";
            DataTable dt = db.Read(sql);
            LuongChucDanhGrid.DataSource = dt;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuyBo.Enabled = false;
            btnXoa.Enabled = false;
            txtChucDanh.Enabled = false;
            txtChucDanh.Text = "";
            txtTienLuongCung.Enabled = false;
            txtTienLuongCung.Text = "";
            txtPhuCap.Enabled = false;
            txtPhuCap.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
            txtChucDanh.Text = "";
            txtChucDanh.Enabled = true;
            txtTienLuongCung.Text = "";
            txtTienLuongCung.Enabled = true;
            txtPhuCap.Text = "";
            txtPhuCap.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnHuyBo.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
            txtChucDanh.Enabled = true;
            txtTienLuongCung.Enabled = true;
            txtPhuCap.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (txtChucDanh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên chức danh");
                }
                else if(txtTienLuongCung.Text=="")
                {
                    MessageBox.Show("Bạn chưa nhập tiền lương cứng");
                }
                else if (txtPhuCap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập phụ cấp");
                }
                else
                {
                    string sql = "Insert into LuongChucDanh(TenChucDanh, TienLuongCung, PhuCap) values (N'" + txtChucDanh.Text + "', '"+txtTienLuongCung.Text+"', '"+txtPhuCap.Text+"')";
                    if (!db.Execute(sql))
                    {
                        MessageBox.Show("Lỗi khi thêm mới");
                    }

                    else
                    {
                        Load_DL();
                    }
                }
            }
            else
            {
                string sql = "Update LuongChucDanh set TenChucDanh =N'" + txtChucDanh.Text + "', TienLuongCung='"+txtTienLuongCung.Text+"', PhuCap='"+txtPhuCap.Text+"' where ChucDanhID = '" + ChucDanhID + "'";
                db.Execute(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select *from NhanVienChucDanh where ChucDanhID = '"+ChucDanhID+"'";
            DataTable dtNVCD = db.Read(sql);
            if(dtNVCD.Rows.Count >0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Nhân viên chức danh trước");
            }
            else
            {
                sql = "Delete LuongChucDanh where ChucDanhID='"+ChucDanhID+"'";
                db.Execute(sql);
                Load_DL();
            }
            Reset();
        }

        private void frmLuongChucDanh_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();      
        }

        private void txtChucDanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập số");
            }
        }

        private void LuongChucDanhGrid_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                ChucDanhID = Int32.Parse(LuongChucDanhGrid.SelectedRows[0].Cells["ChucDanhID"].Value.ToString());

            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
    }
}
