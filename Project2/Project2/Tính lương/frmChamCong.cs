using System;
using System.Data;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            LoadBoPhan();
        }

        private void cmbBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bỏ
        }
        private void LoadBoPhan()
        {
            try
            {
                string sql = @"Select BoPhanID, TenBoPhan From BoPhan Order by TenBoPhan";
                DataTable dt = db.Read(sql);
                cmbBoPhan.DataSource = dt;
                cmbBoPhan.ValueMember = "BoPhanID";
                cmbBoPhan.DisplayMember = "TenBoPhan";
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách bộ phận!");
            }
        }

        private void LoadItems()
        {
            //bỏ
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select a.NhanVienID as 'Mã Nhân Viên', b.TenNV as 'Tên Nhân Viên', c.NgayCongChuan as 'Ngày Công Chuẩn', c.NgayDiLam as 'Ngày Đi Làm', c.NgayNghiLe as 'Ngày Nghỉ Lễ', c.NgayNghiPhepTinhLuong as 'Ngày N.P Tính Lương', c.NgayKhongLuong as 'Ngày Không Lương', c.NgayTinhLuong as 'Ngày Tính Lương', c.NgayChamCong as 'Ngày Chấm Công',
		                     c.GhiChu as 'Ghi Chú', c.TrangThai as 'Ghi Chú'
                            from NhanVienBoPhan a inner join NhanVien b on a.NhanVienID = b.NhanVienID
                            left join ChamCong c on c.BoPhanID = a.BoPhanID and c.NhanVienID = a.NhanVienID and c.Thang = '" + dtpThang.Value.ToString("yyyyMM") + @"'
                            Where a.BoPhanID = '" + cmbBoPhan.SelectedValue + "'";
                DataTable dt = db.Read(sql);
                bindingSource1.DataSource = dt;
                this.ChamCongGrid.DataSource = bindingSource1;
                // Customize Cell Status
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi hiển thị danh sách chấm công!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int dem = 0;
            DataGridViewRowCollection rows = ChamCongGrid.Rows;
            for (int i = 0; i < ChamCongGrid.RowCount -1; i++)
            {
                DataGridViewCellCollection Cells = rows[i].Cells;
                if (Cells != null)
                {
                    string ChamCongID = Cells["ChamCongID"].Value.ToString();
                    int NgayCongChuan = Convert.ToInt32(Cells["NgayCongChuan"].Value.ToString());
                    int NhanVienID = Convert.ToInt32(Cells["NhanVienID"].Value.ToString());
                    int NgayDiLam = Convert.ToInt32(Cells["NgayDiLam"].Value.ToString());
                    int NgayNghiLe = Convert.ToInt32(Cells["NgayNghiLe"].Value.ToString());
                    int NgayNghiPhepTinhLuong = Convert.ToInt32(Cells["NgayNghiPhepTinhLuong"].Value.ToString());
                    int NgayKhongLuong = Convert.ToInt32(Cells["NgayKhongLuong"].Value.ToString());
                    int NgayTinhLuong = Convert.ToInt32(Cells["NgayTinhLuong"].Value.ToString());
                    int NgayChamCong = Convert.ToInt32(Cells["NgayChamCong"].Value.ToString());
                    string GhiChu = Cells["GhiChu"].Value.ToString();

                    string TrangThai = Cells["TrangThai"].Value.ToString();

                    if (ChamCongID == "")
                    {
                        // thực hiện lệnh insert
                        string sql = @"INSERT INTO [ChamCong]
                                           ([Thang]
                                           ,[NgayCongChuan]
                                           ,[BoPhanID]
                                           ,[NhanVienID]
                                           ,[NgayDiLam]
                                           ,[NgayNghiLe]
                                           ,[NgayNghiPhepTinhLuong]
                                           ,[NgayKhongLuong]
                                           ,[NgayTinhLuong]
                                           ,[NgayChamCong]
                                           ,[GhiChu]
                                           ,[TrangThai])
                                     VALUES(
                                           '" + dtpThang.Value.ToString("yyyyMM") + @"'
                                           ,'" + NgayCongChuan + @"'
                                           ,'" + cmbBoPhan.SelectedValue + @"'
                                           ,'" + NhanVienID + @"'
                                           ,'" + NgayDiLam + @"'
                                           ,'" + NgayNghiLe + @"'
                                           ,'" + NgayNghiPhepTinhLuong + @"'
                                           ,'" + NgayKhongLuong + @"'
                                           ,'" + NgayTinhLuong + @"'
                                           ,'" + NgayChamCong + @"'
                                           ,'" + GhiChu + @"'
                                           ,'1')";
                        db.Execute(sql);
                        dem++;
                    }
                    else
                    {
                        if (TrangThai == "1")
                        {
                            string sql = @"UPDATE [ChamCong]
                                       SET[Thang] = '" + dtpThang.Value.ToString("yyyyMM") + @"'
                                      ,[NgayCongChuan] = '" + NgayCongChuan + @"'
                                      ,[BoPhanID] = '" + cmbBoPhan.SelectedValue + @"'
                                      ,[NhanVienID] = '" + NhanVienID + @"'
                                      ,[NgayDiLam] = '" + NgayDiLam + @"'
                                      ,[NgayNghiLe] =  '" + NgayNghiLe + @"'
                                      ,[NgayNghiPhepTinhLuong] = '" + NgayNghiPhepTinhLuong + @"'
                                      ,[NgayKhongLuong] = '" + NgayKhongLuong + @"'
                                      ,[NgayTinhLuong] = '" + NgayTinhLuong + @"'
                                      ,[NgayChamCong] = '" + NgayChamCong + @"'
                                      ,[GhiChu] = '" + GhiChu + @"'
                                 WHERE ChamCongID = '" + ChamCongID + "'";
                            db.Execute(sql);
                            dem++;
                        }
                    }
                }
            }
            btnHienThi_Click(null, null);
            if (dem == 0)
            {
                MessageBox.Show("Không có bản ghi nào thay đổi");
            }
            else
            {
                MessageBox.Show("Lưu " + dem + " bản ghi thành công!");
            }

        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            // update toan bo ve trang thai = 2
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn nộp bản chấm công này không. Nếu nộp bạn sẽ không thể thay đổi dữ liệu chấm công!", "Thông báo", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int dem = 0;
                    DataGridViewRowCollection rows = ChamCongGrid.Rows;
                    for (int i = 0; i < ChamCongGrid.RowCount - 1; i++)
                    {
                        DataGridViewCellCollection Cells = rows[i].Cells;
                        if (Cells != null)
                        {
                            if (Cells["TrangThai"].ToString() == "1")
                            {

                                string ChamCongID = Cells["ChamCongID"].ToString();

                                string sql = @"Update ChamCong Set TrangThai = 2 where ChamCongID = '" + ChamCongID + "'";
                                db.Execute(sql);
                                dem++;

                                // insert sang bảng ChiTietBanKeLuong
                                string ThangKeLuong = Cells["Thang"].ToString();
                                string NhanVienID = Cells["NhanVienID"].ToString();
                                string NgayCongChuan = Cells["NgayCongChuan"].ToString();
                                string NgayTinhLuong = Cells["NgayTinhLuong"].ToString();

                                sql = @"INSERT INTO [dbo].[ChiTietBanKeLuong]
                                           ([ThangKeLuong]
                                           ,[NhanVienID]
                                           ,[TienLuongCung]
                                           ,[HieuSuat]
                                           ,[NgayCongChuan]
                                           ,[NgayTinhLuong]
                                           ,[PhuCap]
                                           ,[TamUng]
                                           ,[ThucLinh]
                                           ,[TongLuong]
                                           ,[ThueThuNhapCaNhan]
                                           ,[TrangThai])
                                     VALUES
                                           ('" + ThangKeLuong + @"'
                                           ,'" + NhanVienID + @"'
                                           ,NULL
                                           ,NULL
                                           ,'" + NgayCongChuan + @"'
                                           ,'" + NgayTinhLuong + @"'
                                           ,NULL
                                           ,NULL
                                           ,NULL
                                           ,NULL
                                           ,NULL
                                           ,'1')";
                                db.Execute(sql);
                            }
                        }
                    }

                    btnHienThi_Click(null, null);
                    if (dem == 0)
                    {
                        MessageBox.Show("Không có bản ghi nào được nộp!");
                    }
                    else
                    {

                        MessageBox.Show("Nộp " + dem.ToString() + " bản thành công!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nộp chấm công!");
            }
        }

        /*private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            //if (e.RowHandle == view.FocusedRowHandle) return;
            if (e.Column.FieldName != "TrangThai") return;
            // Fill a cell
            if (e.CellValue != null && e.CellValue.ToString().Trim() != "" && Convert.ToInt32(e.CellValue) == 2)
            {
                Image image = Image.FromFile("D:\\important files\\PTPMOOP\\PTKTHDT\\HRM_VTHP\\Image\\lock.png");
                e.Graphics.DrawImage(image, new Point(e.Bounds.Location.X + 35, e.Bounds.Location.Y));
            }
            if (e.CellValue != null && e.CellValue.ToString().Trim() != "" && Convert.ToInt32(e.CellValue) == 1)
            {
                Image image = Image.FromFile("D:\\important files\\PTPMOOP\\PTKTHDT\\HRM_VTHP\\Image\\unlock.png");
                e.Graphics.DrawImage(image, new Point(e.Bounds.Location.X + 35, e.Bounds.Location.Y));
            }
        }*/
    }
}
