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
    public partial class ThemLoaiHD : MetroFramework.Forms.MetroForm
    {
        public ThemLoaiHD()
        {
            InitializeComponent();
        }

        int kt = 0;
        Database database = new Database();
        DataTable dt = new DataTable();
        BindingManagerBase currentRow;
        int LoaiHopDongID = 0;

        void Load_DL()
        {
            string sql = @"Select * from LoaiHopDong";
            dt = database.Read(sql);
            grdThemHD.DataSource = dt;

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
                txtLoaiHopDong.Text = r["TenLoaiHopDong"].ToString();
                LoaiHopDongID = int.Parse(r["LoaiHopDongID"].ToString());
            }
        }

        void Reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            btnHuybo.Enabled = false;
            txtLoaiHopDong.Text = "";
            txtLoaiHopDong.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            kt = 1;
            btnCapNhat.Enabled = true;
            btnHuybo.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtLoaiHopDong.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kt = 2;
            btnCapNhat.Enabled = true;
            btnSua.Enabled = false;
            btnHuybo.Enabled = true;
            txtLoaiHopDong.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Select * from HopDong where LoaiHopDongID = '" + LoaiHopDongID + "'";
            DataTable dt = database.Read(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bạn phải xóa bản ghi trong Hợp đồng");
            }
            else
            {
                sql = "Delete LoaiHopDong where LoaiHopDongID = '" + LoaiHopDongID + "'";
                database.Execute(sql);
                Load_DL();
                Reset();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kt == 1)
            {
                if (txtLoaiHopDong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập loại hợp đồng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "Insert into LoaiHopDong(TenLoaiHopDong) values(N'" + txtLoaiHopDong.Text + "')";
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
                string sql = "Update LoaiHopDong set TenLoaiHopDong = N'" + txtLoaiHopDong.Text + "' where LoaiHopDongID = '" + LoaiHopDongID + "'";
                database.Execute(sql);
                Load_DL();
                Reset();
            }
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

        private void ThemLoaiHD_Load(object sender, EventArgs e)
        {
            Load_DL();
            Reset();
        }
    }
}
