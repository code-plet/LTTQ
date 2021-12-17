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
    public partial class HoSo : MetroFramework.Forms.MetroForm
    {
        public HoSo()
        {
            InitializeComponent();
        }

        int kt = 0;
        int NhanVienID = 0;
        Database database = new Database();
        DataTable dt = new DataTable();
        BindingManagerBase currentRow;

        
        void Load_DL()
        {
            string sql = @"Select a.NhanVienID, a.MaNV, a.TenNV, a.NgaySinh, b.GioiTinhID ,b.GioiTinh, a.DiaChi, a.SDT, a.SoCMND, a.Email, a.TrangThaiID 
                        from NhanVien a inner join GioiTinh b 
                        on a.GioiTinhID = b.GioiTinhID";
            dt = database.Read(sql);
            grdHoSo.DataSource = dt;

            currentRow = BindingContext[dt];
            currentRow.PositionChanged += currentRow_PositionChanged;
        }

        void currentRow_PositionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            if (currentRow.Position >= 0)
            {
                DataRow r = dt.Rows[currentRow.Position];
                txtDiaChi.Text = r["DiaChi"].ToString();
                txtEmail.Text = r["Email"].ToString();
                txtMaNV.Text = r["MaNV"].ToString();
                txtSoCMND.Text = r["SoCMND"].ToString();
                txtSDT.Text = r["SDT"].ToString();
                txtTenNV.Text = r["TenNV"].ToString();
                NhanVienID = int.Parse(r["NhanVienID"].ToString());
                cmbGioiTinh.SelectedValue = Boolean.Parse(r["GioiTinhID"].ToString());
                dtpNgaySinh.Value = DateTime.Parse(r["NgaySinh"].ToString());
                cbTrangThaiID.Checked = Boolean.Parse(r["TrangThaiID"].ToString());
            }
        }

        void Reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtSoCMND.Text = "";
            txtEmail.Text = "";
            txtEmail.Enabled = false;
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoCMND.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuybo.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cmbGioiTinh.Enabled = false;
            cbTrangThaiID.Enabled = false;
        }

        private void HoSo_Load(object sender, EventArgs e)
        {
            string sql = "Select * from GioiTinh";
            DataTable dt = database.Read(sql);
            cmbGioiTinh.DataSource = dt;
            cmbGioiTinh.ValueMember = "GioiTinhID";
            cmbGioiTinh.DisplayMember = "GioiTinh";
            Load_DL();
            Reset();
            
            grdHoSo.Columns[0].Visible = false;
            grdHoSo.Columns[4].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtMaNV.Text = "";
            txtSoCMND.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            cmbGioiTinh.Enabled = true;
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtSoCMND.Enabled = true;
            txtSDT.Enabled = true;
            txtSoCMND.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbTrangThaiID.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            cmbGioiTinh.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtEmail.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMaNV.Enabled = false;
            txtSoCMND.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNV.Enabled = true;
            cbTrangThaiID.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                string sql1 = "select * from NhanVien where MaNV = '" + txtMaNV.Text + "'";
                DataTable dt = database.Read(sql1);
               
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtSoCMND.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập 1 số thông tin cần nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtMaNV.Text.Length >= 8)
                {
                    MessageBox.Show("Bạn không được nhập Mã nhân viên quá 8 ký tự", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dt != null)
                {
                    MessageBox.Show("Không được nhập trùng mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "Insert into NhanVien(MaNV, TenNV, NgaySinh, GioiTinhID, SDT, SoCMND, Email, DiaChi, TrangThaiID) values ('" + txtMaNV.Text + "', N'" + txtTenNV.Text + "', '" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "', '" + cmbGioiTinh.SelectedValue + "', '" + txtSDT.Text + "', '" + txtSoCMND.Text + "' , '" + txtEmail.Text + "', N'" + txtDiaChi.Text + "', '" + cbTrangThaiID.Checked + "')";
                    if (database.Execute(sql) == false)
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
                string sql = "Update NhanVien set MaNV = '" + txtMaNV.Text + "', TenNV = N'" + txtTenNV.Text + "', NgaySinh = '" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "', GioiTinhID = '" + cmbGioiTinh.SelectedValue + "', SDT = '" + txtSDT.Text + "', SoCMND = '" + txtSoCMND.Text + "', Email = '" + txtEmail.Text + "', DiaChi = N'" + txtDiaChi.Text + "', TrangThaiID = '" + cbTrangThaiID.Checked + "' where NhanVienID = '" + NhanVienID + "'";
                database.Execute(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập chữ");
            }
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập chữ");
            }
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn không được phép nhập số");
            }
        }
    }
}
