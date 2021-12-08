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
    public partial class HopDong : MetroFramework.Forms.MetroForm
    {
        public HopDong()
        {
            InitializeComponent();
        }

        int kt = 0;
        Database database = new Database();
        DataTable dt = new DataTable();
        BindingManagerBase currentRow;
        int HopDongID = 0;

        void Load_DL()
        {
            string sql = @"select f.TenBoPhan, e.NhanVienID, e.HopDongID, e.LoaiHopDongID, e.TenNV, e.MaHopDong, e.TenLoaiHopDong, e.NgayKy, e.NgayHieuLuc, e.NgayHetHan, e.NgayKetThuc, e.BoPhanID, e.TrangThai from BoPhan f inner join
                           (select a.NhanVienID, a.TrangThai, a.HopDongID, a.LoaiHopDongID, a.MaHopDong, a.NgayHetHan, a.NgayHieuLuc, a.NgayKetThuc, a.NgayKy, b.TenLoaiHopDong, c.TenNV, d.BoPhanID from HopDong a
                           inner join LoaiHopDong b on a.LoaiHopDongID = b.LoaiHopDongID 
                           inner join NhanVien c on a.NhanVienID = c.NhanVienID
                           inner join NhanVienBoPhan d on a.NhanVienID = d.NhanVienID) as e on f.BoPhanID = e.BoPhanID";
            dt = database.Read(sql);
            grdHopDong.DataSource = dt;

            currentRow = BindingContext[dt];
            currentRow.PositionChanged += currentRow_PositionChanged;
        }

        void Reset()
        {
            cmbBoPhan.Enabled = false;
            cmbNhanVien.Enabled = false;
            cmbTenLoaiHopDong.Enabled = false;
            dtpNgayHetHan.Enabled = false;
            dtpNgayHieuLuc.Enabled = false;
            dtpNgayKetThuc.Enabled = false;
            dtpNgayKy.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            txtMaHopDong.Enabled = false;
            txtMaHopDong.Text = "";
            cbTrangThai.Enabled = false;
        }

        
        private void HopDong_Load(object sender, EventArgs e)
        {
            string sql = "Select * from LoaiHopDong";
            DataTable dt = database.Read(sql);
            cmbTenLoaiHopDong.DataSource = dt;
            cmbTenLoaiHopDong.ValueMember = "LoaiHopDongID";
            cmbTenLoaiHopDong.DisplayMember = "TenLoaiHopDong";
            sql = "Select * from BoPhan";
            DataTable dt1 = database.Read(sql);
            cmbBoPhan.DataSource = dt1;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            Load_DL();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            cmbTenLoaiHopDong.Enabled = true;
            dtpNgayHetHan.Enabled = true;
            dtpNgayHieuLuc.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            dtpNgayKy.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = true;
            txtMaHopDong.Enabled = true;
            txtMaHopDong.Text = "";
            cbTrangThai.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            cmbBoPhan.Enabled = true;
            cmbNhanVien.Enabled = true;
            cmbTenLoaiHopDong.Enabled = true;
            dtpNgayHetHan.Enabled = true;
            dtpNgayHieuLuc.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            dtpNgayKy.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = true;
            txtMaHopDong.Enabled = true;
            cbTrangThai.Enabled = true;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete HopDong where HopDongID = '" + HopDongID + "'";
            database.Execute(sql);
            Load_DL();
            Reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                string sql = "Insert into HopDong( MaHopDong, LoaiHopDongID, NgayKy, NgayHieuLuc, NgayHetHan, NhanVienID, NgayKetThuc, TrangThai) values ('" + txtMaHopDong.Text + "', '" + cmbTenLoaiHopDong.SelectedValue + "', '" + dtpNgayKy.Value + "', '" + dtpNgayHieuLuc.Value + "', '" + dtpNgayHetHan.Value + "', '" + cmbNhanVien.SelectedValue + "', '" + dtpNgayKetThuc.Value + "', '" + cbTrangThai.Checked + "')";
                if (database.Execute(sql) == false)
                {
                    MessageBox.Show("Lỗi khi thêm mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Load_DL();
                }
            }
            else
            {
                string sql = "Update HopDong set MaHopDong ='" + txtMaHopDong.Text + "', LoaiHopDongID = '" + cmbTenLoaiHopDong.SelectedValue + "', NgayKy = '" + dtpNgayKy.Value + "', NgayHieuLuc = '" + dtpNgayHieuLuc.Value + "', NgayHetHan = '" + dtpNgayHetHan.Value + "', NgayKetThuc = '" + dtpNgayKetThuc.Value + "', NhanVienID = '" + cmbNhanVien.SelectedValue + "', TrangThai = '" + cbTrangThai.Checked + "' where HopDongID = '" + HopDongID + "'";
                database.Execute(sql);
                Load_DL();
            }
            Reset();
        }

        private void currentRow_PositionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (currentRow.Position >= 0)
            {
                DataRow r = dt.Rows[currentRow.Position];
                txtMaHopDong.Text = r["MaHopDong"].ToString();
                HopDongID = int.Parse(r["HopDongID"].ToString());
                cmbBoPhan.SelectedValue = int.Parse(r["BoPhanID"].ToString());
                cmbNhanVien.SelectedValue = int.Parse(r["NhanVienID"].ToString());
                cmbTenLoaiHopDong.SelectedValue = int.Parse(r["LoaiHopDongID"].ToString());
                dtpNgayKy.Value = DateTime.Parse(r["NgayKy"].ToString());
                dtpNgayHieuLuc.Value = DateTime.Parse(r["NgayHieuLuc"].ToString());
                dtpNgayKetThuc.Value = DateTime.Parse(r["NgayKetThuc"].ToString());
                dtpNgayHetHan.Value = DateTime.Parse(r["NgayHetHan"].ToString());
                cbTrangThai.Checked = Boolean.Parse(r["TrangThai"].ToString());
            }
        }

        private void cbTrangThai_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
