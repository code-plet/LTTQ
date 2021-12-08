
namespace Project2.Features
{
    partial class QuanLyNguoiDung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNguoiDung));
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.lblBoPhan = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblQuanTri = new System.Windows.Forms.Label();
            this.cbQuanTri = new System.Windows.Forms.CheckBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grdNguoiDung = new System.Windows.Forms.DataGridView();
            this.TenBoPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuanTri = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cbQuanTri);
            this.grbThongTin.Controls.Add(this.lblQuanTri);
            this.grbThongTin.Controls.Add(this.txtMatKhau);
            this.grbThongTin.Controls.Add(this.txtTenDangNhap);
            this.grbThongTin.Controls.Add(this.cmbNhanVien);
            this.grbThongTin.Controls.Add(this.cmbBoPhan);
            this.grbThongTin.Controls.Add(this.lblMatKhau);
            this.grbThongTin.Controls.Add(this.lblNhanVien);
            this.grbThongTin.Controls.Add(this.lblTenDangNhap);
            this.grbThongTin.Controls.Add(this.lblBoPhan);
            this.grbThongTin.Location = new System.Drawing.Point(13, 63);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(774, 131);
            this.grbThongTin.TabIndex = 0;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.AutoSize = true;
            this.lblBoPhan.Location = new System.Drawing.Point(37, 34);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(62, 17);
            this.lblBoPhan.TabIndex = 1;
            this.lblBoPhan.Text = "Bộ Phận";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(37, 68);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(109, 17);
            this.lblTenDangNhap.TabIndex = 3;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(436, 34);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(74, 17);
            this.lblNhanVien.TabIndex = 4;
            this.lblNhanVien.Text = "Nhân Viên";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(436, 68);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(68, 17);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật Khẩu";
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(147, 27);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(221, 24);
            this.cmbBoPhan.TabIndex = 6;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbBoPhan_SelectedIndexChanged);
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(516, 27);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(221, 24);
            this.cmbNhanVien.TabIndex = 12;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(147, 63);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(221, 22);
            this.txtTenDangNhap.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(516, 63);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(221, 22);
            this.txtMatKhau.TabIndex = 14;
            // 
            // lblQuanTri
            // 
            this.lblQuanTri.AutoSize = true;
            this.lblQuanTri.Location = new System.Drawing.Point(37, 100);
            this.lblQuanTri.Name = "lblQuanTri";
            this.lblQuanTri.Size = new System.Drawing.Size(64, 17);
            this.lblQuanTri.TabIndex = 15;
            this.lblQuanTri.Text = "Quản Trị";
            // 
            // cbQuanTri
            // 
            this.cbQuanTri.AutoSize = true;
            this.cbQuanTri.Location = new System.Drawing.Point(147, 100);
            this.cbQuanTri.Name = "cbQuanTri";
            this.cbQuanTri.Size = new System.Drawing.Size(18, 17);
            this.cbQuanTri.TabIndex = 16;
            this.cbQuanTri.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.Location = new System.Drawing.Point(13, 209);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(106, 36);
            this.btnThemMoi.TabIndex = 1;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(182, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Location = new System.Drawing.Point(351, 209);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(106, 36);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Location = new System.Drawing.Point(681, 209);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(106, 36);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(516, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 36);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grdNguoiDung
            // 
            this.grdNguoiDung.AllowUserToAddRows = false;
            this.grdNguoiDung.AllowUserToDeleteRows = false;
            this.grdNguoiDung.AllowUserToOrderColumns = true;
            this.grdNguoiDung.AllowUserToResizeColumns = false;
            this.grdNguoiDung.AllowUserToResizeRows = false;
            this.grdNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenBoPhan,
            this.MaNV,
            this.TenNV,
            this.TenDangNhap,
            this.MatKhau,
            this.QuanTri});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdNguoiDung.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdNguoiDung.Location = new System.Drawing.Point(13, 261);
            this.grdNguoiDung.Name = "grdNguoiDung";
            this.grdNguoiDung.ReadOnly = true;
            this.grdNguoiDung.RowHeadersWidth = 51;
            this.grdNguoiDung.RowTemplate.Height = 24;
            this.grdNguoiDung.Size = new System.Drawing.Size(774, 176);
            this.grdNguoiDung.TabIndex = 6;
            this.grdNguoiDung.SelectionChanged += new System.EventHandler(this.grdNguoiDung_SelectionChanged);
            // 
            // TenBoPhan
            // 
            this.TenBoPhan.DataPropertyName = "TenBoPhan";
            this.TenBoPhan.HeaderText = "Bộ Phận";
            this.TenBoPhan.MinimumWidth = 6;
            this.TenBoPhan.Name = "TenBoPhan";
            this.TenBoPhan.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 150;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            this.TenDangNhap.Width = 120;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Width = 110;
            // 
            // QuanTri
            // 
            this.QuanTri.DataPropertyName = "QuanTri";
            this.QuanTri.HeaderText = "Quản Trị";
            this.QuanTri.MinimumWidth = 6;
            this.QuanTri.Name = "QuanTri";
            this.QuanTri.ReadOnly = true;
            this.QuanTri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuanTri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QuanTri.Width = 60;
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdNguoiDung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.grbThongTin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuanLyNguoiDung";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Quản Lý Người Dùng";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.QuanLyNguoiDung_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.CheckBox cbQuanTri;
        private System.Windows.Forms.Label lblQuanTri;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblBoPhan;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView grdNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QuanTri;
    }
}