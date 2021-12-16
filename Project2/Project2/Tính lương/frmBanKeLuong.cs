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
    public partial class frmBanKeLuong : Form
    {
        public frmBanKeLuong()
        {
            InitializeComponent();

        }

        private void frmBanKeLuong_Load(object sender, EventArgs e)
        {
            string time = dtpThang.Value.Year.ToString() + dtpThang.Value.Month.ToString("D2");
            string sql = @"select a.NhanVienID , a.MaNV as 'Mã Nhân Viên', a.TenNV as 'Tên Nhân Viên', b.TamUng as 'Tạm Ứng', b.ThangTamUng as 'Tháng tạm Ứng', c.NgayCongChuan as 'Ngày Công Chuẩn', c.ThangKeLuong,
                                c.TrangThai as 'Trạng Thái', c.ChiTietBanKeLuongID, c.ThueThuNhapCaNhan, c.NgayTinhLuong as 'Ngày Tính Lương', f.TienLuongCung as 'Tiền Lương Cứng', f.PhuCap*f.TienLuongCung/100 as 'Phụ Cấp', g.HieuSuat as 'Hiệu Suất',
                                f.TienLuongCung * g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2)) as 'Tổng Lương',
                                f.TienLuongCung * g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2) ) - b.TamUng as 'Thực Lĩnh' 
                            From NhanVien a 
                            inner join ChiTietTamUng b on a.NhanVienID = b.NhanVienID and b.ThangTamUng = '" + time + @"'
                            inner join NhanVienChucDanh d on a.NhanVienID = d.NhanVienID
                            inner join LuongChucDanh f on f.ChucDanhID = d.ChucDanhID
                            inner join DanhGiaHieuSuat g on g.NhanVienID = a.NhanVienID and g.Thang = '" + time + @"'
                            left join ChiTietBanKeLuong c on c.NhanVienID = a.NhanVienID and  c.ThangKeLuong = '" + time + "'";
            DataTable dt = db.Read(sql);
            bindingSource1.DataSource = dt;
            this.BanKeLuongGrid.DataSource = bindingSource1;
            this.BanKeLuongGrid.Columns["NhanVienID"].Visible = false;
            this.BanKeLuongGrid.Columns["ChiTietBanKeLuongID"].Visible = false;
            this.BanKeLuongGrid.Columns["ThueThuNhapCaNhan"].Visible = false;
            this.BanKeLuongGrid.Columns["ThangKeLuong"].Visible = false;
        }

        Database db = new Database();

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {

            try
            {

                string time = dtpThang.Value.Year.ToString() + dtpThang.Value.Month.ToString("D2");
                string sql = @"select a.MaNV as 'Mã Nhân Viên', a.TenNV as 'Tên Nhân Viên',f.TienLuongCung as 'Tiền Lương Cứng',g.HieuSuat as 'Hiệu Suất',c.NgayCongChuan as 'Ngày Công Chuẩn',c.NgayTinhLuong as 'Ngày Tính Lương',f.PhuCap*f.TienLuongCung/100 as 'Phụ Cấp', b.TamUng as 'Tạm Ứng',  c.ThangKeLuong,
                                f.TienLuongCung * g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2) ) - b.TamUng as 'Thực Lĩnh',
                                f.TienLuongCung * g.HieuSuat * (Round((CONVERT(float, c.NgayTinhLuong)/CONVERT(float,c.NgayCongChuan)),2)) as 'Tổng Lương'
                            From NhanVien a 
                            inner join ChiTietTamUng b on a.NhanVienID = b.NhanVienID and b.ThangTamUng = '" + time + @"'
                            inner join NhanVienChucDanh d on a.NhanVienID = d.NhanVienID
                            inner join LuongChucDanh f on f.ChucDanhID = d.ChucDanhID
                            inner join DanhGiaHieuSuat g on g.NhanVienID = a.NhanVienID and g.Thang = '" + time + @"'
                            left join ChiTietBanKeLuong c on c.NhanVienID = a.NhanVienID and  c.ThangKeLuong = '" + time + "'";
                DataTable dt = db.Read(sql);
                bindingSource1.DataSource = dt;
                this.BanKeLuongGrid.DataSource = bindingSource1;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không tính được lương!");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            #region Fixing Bug
            int dem = 0;
            DataGridViewRowCollection row = BanKeLuongGrid.Rows;
            for (int i = 0; i < BanKeLuongGrid.RowCount - 1; i++)
            {
                DataGridViewCellCollection CellCollection = row[i].Cells;
                if (CellCollection != null)
                {
                    string ChiTietBanKeLuongID = CellCollection[8].Value.ToString();
                    int NgayCongChuan = Int32.Parse(CellCollection[5].Value.ToString());
                    int NhanVienID = Convert.ToInt32(CellCollection[0].Value.ToString());
                    decimal HieuSuat = Decimal.Parse(CellCollection[13].Value.ToString());
                    decimal TienLuongCung = Decimal.Parse(CellCollection[11].Value.ToString());
                    decimal PhuCap = Decimal.Parse(CellCollection[12].Value.ToString());
                    decimal TamUng = Decimal.Parse(CellCollection[3].Value.ToString());
                    int NgayTinhLuong = Int32.Parse(CellCollection[10].Value.ToString());
                    int TongLuong = Int32.Parse(CellCollection[14].Value.ToString());
                    decimal ThueThuNhapCaNhan = Decimal.Parse(CellCollection[9].Value.ToString());
                    decimal ThucLinh = Decimal.Parse(CellCollection[15].Value.ToString());
                    string TrangThai = CellCollection[7].Value.ToString();


                    if (ChiTietBanKeLuongID != "" && TrangThai == "1")
                    {
                        string sql = @"UPDATE ChiTietBanKeLuong
                        SET
                            [TienLuongCung] = '" + TienLuongCung + @"'
                            ,[HieuSuat] = '" + HieuSuat + @"'
                            ,[PhuCap] = '" + PhuCap + @"'
                            ,[TamUng] = '" + TamUng + @"'
                            ,[TongLuong] = '" + TongLuong + @"' 
                            ,[ThueThuNhapCaNhan] = '" + ThueThuNhapCaNhan + @"'
                            ,[ThucLinh] = '" + ThucLinh + @"'   
                        WHERE ChiTietBanKeLuongID = '" + ChiTietBanKeLuongID + "'";
                        db.Execute(sql);
                        dem++;
                    }
                    //else
                    //{
                    //    MessageBox.Show("Không có bản kê lương nào để lưu!");
                    //}
                }
            }
            
            if(dem == 0)
            {
                MessageBox.Show("Không có bản kê lương nào thay đổi");
            }
            else
            {
                MessageBox.Show("Lưu " + dem + " bản kê lương");
            }
            #endregion
        }

        private void btnNop_Click(object sender, EventArgs e)
        {
            try
            {
                int dem = 0;
                DataGridViewRowCollection row = BanKeLuongGrid.Rows;
                for (int i = 0; i < BanKeLuongGrid.RowCount - 1; i++)
                {
                    DataGridViewCellCollection CellCollection = row[i].Cells;
                    if (CellCollection != null)
                    {
                        if (CellCollection[7].Value.ToString() == "1")
                        {
                            string ChiTietBanKeLuongID = CellCollection[8].Value.ToString();

                            string sql = @"Update ChiTietBanKeLuong Set TrangThai = 2 where ChiTietBanKeLuongID = '" + ChiTietBanKeLuongID + "'";
                            db.Execute(sql);

                            sql = @"update ChiTietTamUng set TrangThaiID = 2 Where NhanVienID = '"+ CellCollection[0].Value.ToString() + "' And ThangTamUng = '"+ CellCollection[4].Value.ToString() + "'";
                            db.Execute(sql);
                            dem++;
                        }

                    }
                }
                //btnNop_Click(null, null);
                if (dem == 0)
                {
                    MessageBox.Show("Không có bản kê lương nào được nộp!");
                }
                else
                    MessageBox.Show("Nộp " + dem.ToString() + " bản kê lương thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nộp chấm công!");
            }
        }

    }
}
