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
    public partial class ChucVu : MetroFramework.Forms.MetroForm
    {
        public ChucVu()
        {
            InitializeComponent();
        }

        int kt = 0;
        Database database = new Database();
        DataTable dt = new DataTable();
        BindingManagerBase currentRow;

        void currentRow_PositionChanged(object sender, EventArgs e)
        {
            if (currentRow.Position >= 0)
            {
                DataRow r = dt.Rows[currentRow.Position];
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                cmbTenChucDanh.SelectedValue = int.Parse(r["ChucDanhID"].ToString());
                cmbBoPhan.SelectedValue = int.Parse(r["BoPhanID"].ToString());
                cmbNhanVien.SelectedValue = int.Parse(r["NhanVienID"].ToString());
            }
        }
        void Load_DL()
        {
            string sql = @"SELECT DISTINCT BP.BoPhanID, BP.TenBoPhan, CDNV.TenChucDanh, CDNV.TenNV, NVBP.NhanVienID, CDNV.ChucDanhID
                           FROM NhanVienBoPhan NVBP
                           INNER JOIN BoPhan BP ON NVBP.BoPhanID = BP.BoPhanID
                           INNER JOIN 
	                       (SELECT LCD.ChucDanhID, LCD.TenChucDanh, NVCD.NhanVienID, NV.TenNV
	                        FROM NhanVienChucDanh NVCD
	                        INNER JOIN LuongChucDanh LCD ON NVCD.ChucDanhID = LCD.ChucDanhID
	                        INNER JOIN NhanVien NV ON NVCD.NhanVienID = NV.NhanVienID) 
		                    AS CDNV ON NVBP.NhanVienID = CDNV.NhanVienID";
            dt = database.Read(sql);
            grdChucVu.DataSource = dt;

            currentRow = BindingContext[dt];
            currentRow.PositionChanged += currentRow_PositionChanged;
        }

        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            btnCapNhat.Enabled = false;
            cmbTenChucDanh.Enabled = false;
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            string sql = "Select * from BoPhan";
            DataTable dt1 = database.Read(sql);
            cmbBoPhan.DataSource = dt1;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            sql = "Select * from LuongChucDanh";
            DataTable dt2 = database.Read(sql);
            cmbTenChucDanh.DataSource = dt2;
            cmbTenChucDanh.ValueMember = "ChucDanhID";
            cmbTenChucDanh.DisplayMember = "TenChucDanh";
            Load_DL();
            Reset();

            grdChucVu.Columns[0].Visible = false;          
            grdChucVu.Columns[4].Visible = false;
            grdChucVu.Columns[5].Visible = false;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            cmbTenChucDanh.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbNhanVien.Enabled = false;
            cmbBoPhan.Enabled = false;
            cmbTenChucDanh.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (cmbNhanVien.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Không đc phép nhập trùng");
                }
                else
                {
                    string sql = "Insert into NhanVienChucDanh(NhanVienID, ChucDanhID) values ('" + cmbNhanVien.SelectedValue + "', '" + cmbTenChucDanh.SelectedValue + "')";
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
                string sql = "Update NhanVienChucDanh set NhanVienID ='" + cmbNhanVien.SelectedValue + "', ChucDanhID = '" + cmbTenChucDanh.SelectedValue + "' where NhanVienID = '" + cmbNhanVien.SelectedValue + "'";
                database.Execute(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete NhanVienChucDanh where NhanVienID = '" + cmbNhanVien.SelectedValue + "' AND ChucDanhID = '" + cmbTenChucDanh.SelectedValue + "'";
            database.Execute(sql);
            Load_DL();
            Reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                this.Close();
                CVBPMenu cVBP = new CVBPMenu();
                cVBP.Show();
            }
        }
    }
}
