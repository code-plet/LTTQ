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
    public partial class NVBP : MetroFramework.Forms.MetroForm
    {
        public NVBP()
        {
            InitializeComponent();
        }

        int kt = 0;
        Database database = new Database();
        DataTable dt = new DataTable();
        BindingManagerBase currentRow;
        int NhanVienID = 0;

        void currentRow_PositionChanged(object sender, EventArgs e)
        {
            if (currentRow.Position >= 0)
            {
                DataRow r = dt.Rows[currentRow.Position];
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                cmbTenNV.SelectedValue = int.Parse(r["NhanVienID"].ToString());
                cmbBoPhan.SelectedValue = int.Parse(r["BoPhanID"].ToString());
                NhanVienID = int.Parse(r["NhanVienID"].ToString());
            }
        }
        void Load_DL()
        {
            string sql = @"Select a.NhanVienID, a.BoPhanID, b.TenNV, c.TenBoPhan
                            from ((NhanVienBoPhan a inner join NhanVien b on a.NhanVienID = b.NhanVienID)
                            inner join BoPhan c on a.BoPhanID = c.BoPhanID)";
            dt = database.Read(sql);
            grdBoPhan.DataSource = dt;

            currentRow = BindingContext[dt];
            currentRow.PositionChanged += currentRow_PositionChanged;
        }
        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuybo.Enabled = false;
            btnXoa.Enabled = false;
            cmbBoPhan.Enabled = false;
            cmbTenNV.Enabled = false;
        }

        private void BoPhan_Load(object sender, EventArgs e)
        {          
            string sql = "Select * from NhanVien";
            DataTable dt = database.Read(sql);
            cmbTenNV.DataSource = dt;
            cmbTenNV.ValueMember = "NhanVienID";
            cmbTenNV.DisplayMember = "TenNV";
            sql = "Select * from BoPhan";
            DataTable dt1 = database.Read(sql);
            cmbBoPhan.DataSource = dt1;
            cmbBoPhan.ValueMember = "BoPhanID";
            cmbBoPhan.DisplayMember = "TenBoPhan";
            Load_DL();
            Reset();

            grdBoPhan.Columns[0].Visible = false;
            grdBoPhan.Columns[1].Visible = false;          
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
            cmbTenNV.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnXoa.Enabled = false;
            cmbTenNV.Enabled = true;
            cmbBoPhan.Enabled = true;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                string sql = "Insert into NhanVienBoPhan(NhanVienID, BoPhanID) values ('" + cmbTenNV.SelectedValue + "', '" + cmbBoPhan.SelectedValue + "')";
                if (database.Execute(sql) == false)
                {
                    MessageBox.Show("Lỗi khi thêm mới");
                }
                else
                {
                    Load_DL();
                }
            }
            else
            {
                string sql = "Update NhanVienBoPhan set NhanVienID ='" + cmbTenNV.SelectedValue + "', BoPhanID = '" + cmbBoPhan.SelectedValue + "' where NhanVienID = '" + cmbTenNV.SelectedValue + "'";
                database.Read(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from NhanVienChucDanh where NhanVienID = '" + NhanVienID + "'";
            DataTable dtNVCD = database.Read(sql);
            if (dtNVCD.Rows.Count > 0)
            {
                MessageBox.Show("Hãy xóa nhân viên bên chức vụ trước!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sql = "Delete NhanVienBoPhan where NhanVienID = '" + cmbTenNV.SelectedValue + "' AND BoPhanID = '" + cmbBoPhan.SelectedValue + "'";
                database.Execute(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
