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
    public partial class ThemBoPhan : MetroFramework.Forms.MetroForm
    {
        public ThemBoPhan()
        {
            InitializeComponent();
        }

        int kt = 0;
        Database database = new Database();
        DataTable dt = new DataTable();
        BindingManagerBase currentRow;
        int BoPhanID = 0;

        void Load_DL()
        {
            string sql = @"Select * from BoPhan";
            dt = database.Read(sql);
            grdThemBP.DataSource = dt;

            currentRow = BindingContext[dt];
            currentRow.PositionChanged += currentRow_PositionChanged;
        }

        private void currentRow_PositionChanged(object sender, EventArgs e)
        {
            if (currentRow.Position >= 0)
            {
                DataRow r = dt.Rows[currentRow.Position];
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtBoPhan.Text = r["TenBoPhan"].ToString();
                BoPhanID = int.Parse(r["BoPhanID"].ToString());
            }
        }

        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            txtBoPhan.Text = "";
            txtBoPhan.Enabled = false;
        }

        private void ThemBoPhan_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtBoPhan.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnCapNhat.Enabled = true;
            btnSua.Enabled = false;
            btnHuybo.Enabled = true;
            txtBoPhan.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from NhanVienBoPhan where BoPhanID = '" + BoPhanID + "'";
            DataTable dtNVBP = database.Read(sql);
            if (dtNVBP.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong NhanVienBoPhan");
            }
            else
            {
                sql = "Delete BoPhan where BoPhanID = '" + BoPhanID + "'";
                database.Execute(sql);
                Load_DL();
            }

            Reset();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (txtBoPhan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên bộ phận", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "Insert into BoPhan(TenBoPhan) values(N'" + txtBoPhan.Text + "')";
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
                string sql = "Update BoPhan set TenBoPhan =N'" + txtBoPhan.Text + "' where BoPhanID ='" + BoPhanID + "'";
                database.Execute(sql);
                Load_DL();
            }
            Reset();
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                this.Close();
                DanhMuc danhMuc = new DanhMuc();
                danhMuc.ShowDialog();
            }
        }
    }
}
