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
    public partial class QuanLyNguoiDung : MetroFramework.Forms.MetroForm
    {
        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        int kt = 0;
        int NguoiDungID = 0;
        Database database = new Database();
        DataTable dt = new DataTable();
        BindingManagerBase currentRow;


        void Load_DL()
        {
            string sql = @"select a.NguoiDungID, a.TenDangNhap, a.MatKhau, a.QuanTri, b.NhanVienID, b.MaNV, b.TenNV, c.BoPhanID, d.TenBoPhan from NguoiDung a 
                            inner join NhanVien b on a.NhanVienID = b.NhanVienID
                            inner join NhanVienBoPhan c on a.NhanVienID = c.NhanVienID
                            inner join BoPhan d on d.BoPhanID = c.BoPhanID";
            dt = database.Read(sql);
            grdNguoiDung.DataSource = dt;

            currentRow = BindingContext[dt];
            currentRow.PositionChanged += currentRow_PositionChanged;
        }

        void Reset()
        {
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            cbQuanTri.Enabled = false;
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            string sql = "Select * from BoPhan";
            DataTable dtBoPhan = database.Read(sql);
            cmbBoPhan.DataSource = dtBoPhan;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            Load_DL();
            Reset();

            grdNguoiDung.Columns[0].Visible = false;           
            grdNguoiDung.Columns[4].Visible = false;
            grdNguoiDung.Columns[7].Visible = false;           
        }

        private void currentRow_PositionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (currentRow.Position >= 0)
            {
                DataRow r = dt.Rows[currentRow.Position];
                txtTenDangNhap.Text = r["TenDangNhap"].ToString();
                txtMatKhau.Text = r["MatKhau"].ToString();
                NguoiDungID = int.Parse(r["NguoiDungID"].ToString());
                cmbBoPhan.SelectedValue = int.Parse(r["BoPhanID"].ToString());
                cmbNhanVien.SelectedValue = int.Parse(r["NhanVienID"].ToString());
                cbQuanTri.Checked = Boolean.Parse(r["QuanTri"].ToString());
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            kt = 1;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            txtMatKhau.Text = "";
            txtTenDangNhap.Text = "";
            cbQuanTri.Enabled = true;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            btnThemMoi.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            txtMatKhau.Clear();
            cbQuanTri.Enabled = true;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            btnThemMoi.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu");
                }
                else
                {
                    string matkhau = DuLieu.Security.EncryptMd5(txtMatKhau.Text);
                    string sql = "Insert into NguoiDung(TenDangNhap, MatKhau, QuanTri, NhanVienID) values ('" + txtTenDangNhap.Text + "', '" + matkhau + "', '" + cbQuanTri.Checked + "', '" + cmbNhanVien.SelectedValue + "')";
                    if (database.Execute(sql) == false)
                    {
                        MessageBox.Show("Lỗi khi thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Load_DL();
                    }
                }
            }
            else
            {
                Database db = new Database();
                dt = db.Read(@"select TenDangNhap from NguoiDung where NguoiDungID = "+UserAccount.UserID);
                
                if (dt.Rows[0]["TenDangNhap"].ToString() == txtTenDangNhap.Text)
                {
                    UserAccount.QuanTriAccess = cbQuanTri.Checked;
                }
                string sql = "";
                if (txtMatKhau.Text.Trim() != "")
                {
                    string matkhau = DuLieu.Security.EncryptMd5(txtMatKhau.Text);
                    sql = "Update NguoiDung set TenDangNhap = '" + txtTenDangNhap.Text + "', MatKhau = '" + matkhau + "', QuanTri = '" + cbQuanTri.Checked + "', NhanVienID = " + cmbNhanVien.SelectedValue + " where NguoiDungID = '" + NguoiDungID + "'";
                }
                else
                {
                    sql = "Update NguoiDung set TenDangNhap = '" + txtTenDangNhap.Text + "', QuanTri = '" + cbQuanTri.Checked + "', NhanVienID = " + cmbNhanVien.SelectedValue + " where NguoiDungID = '" + NguoiDungID + "'";
                }

                database.Execute(sql);
                Load_DL();
                txtMatKhau.Text = "";
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql2 = "Delete from QuyenNguoiDung where NguoiDungID = '" + NguoiDungID + "'";
            string sql = "Delete from NguoiDung where NguoiDungID = '" + NguoiDungID + "'";
            database.Execute(sql);
            database.Execute(sql2);
            Load_DL();
            Reset();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string BoPhanID = cmbBoPhan.SelectedValue.ToString();
            string sql = "select a.NhanVienID, a.TenNV from NhanVien a INNER JOIN NhanVienBoPhan b on a.NhanVienID = b.NhanVienID and b.BoPhanID = '" + BoPhanID + "'";
            DataTable dtNhanVien = database.Read(sql);
            cmbNhanVien.DataSource = dtNhanVien;
            cmbNhanVien.ValueMember = "NhanVienID";
            cmbNhanVien.DisplayMember = "TenNV";
        }

        private void grdNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}
