
namespace Project2.Features
{
    partial class HopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HopDong));
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.lblMaHopDong = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.lblNgayHieuLuc = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.dtpNgayKy = new System.Windows.Forms.DateTimePicker();
            this.cmbTenLoaiHopDong = new System.Windows.Forms.ComboBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNgayKy = new System.Windows.Forms.Label();
            this.lblLoaiHopDong = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblBoPhan = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.grdHopDong = new System.Windows.Forms.DataGridView();
            this.TenBoPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHieuLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HieuLuc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtMaHopDong);
            this.grbThongTin.Controls.Add(this.dtpNgayKetThuc);
            this.grbThongTin.Controls.Add(this.dtpNgayHetHan);
            this.grbThongTin.Controls.Add(this.dtpNgayHieuLuc);
            this.grbThongTin.Controls.Add(this.lblMaHopDong);
            this.grbThongTin.Controls.Add(this.lblNgayKetThuc);
            this.grbThongTin.Controls.Add(this.lblNgayHetHan);
            this.grbThongTin.Controls.Add(this.lblNgayHieuLuc);
            this.grbThongTin.Controls.Add(this.cbTrangThai);
            this.grbThongTin.Controls.Add(this.dtpNgayKy);
            this.grbThongTin.Controls.Add(this.cmbTenLoaiHopDong);
            this.grbThongTin.Controls.Add(this.cmbNhanVien);
            this.grbThongTin.Controls.Add(this.cmbBoPhan);
            this.grbThongTin.Controls.Add(this.lblTrangThai);
            this.grbThongTin.Controls.Add(this.lblNgayKy);
            this.grbThongTin.Controls.Add(this.lblLoaiHopDong);
            this.grbThongTin.Controls.Add(this.lblTenNV);
            this.grbThongTin.Controls.Add(this.lblBoPhan);
            this.grbThongTin.Location = new System.Drawing.Point(10, 58);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Size = new System.Drawing.Size(733, 210);
            this.grbThongTin.TabIndex = 0;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHopDong.Location = new System.Drawing.Point(522, 147);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(200, 22);
            this.txtMaHopDong.TabIndex = 30;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(522, 112);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayKetThuc.TabIndex = 29;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(522, 72);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayHetHan.TabIndex = 28;
            // 
            // dtpNgayHieuLuc
            // 
            this.dtpNgayHieuLuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHieuLuc.Location = new System.Drawing.Point(522, 30);
            this.dtpNgayHieuLuc.Name = "dtpNgayHieuLuc";
            this.dtpNgayHieuLuc.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayHieuLuc.TabIndex = 27;
            // 
            // lblMaHopDong
            // 
            this.lblMaHopDong.AutoSize = true;
            this.lblMaHopDong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHopDong.Location = new System.Drawing.Point(424, 152);
            this.lblMaHopDong.Name = "lblMaHopDong";
            this.lblMaHopDong.Size = new System.Drawing.Size(79, 14);
            this.lblMaHopDong.TabIndex = 26;
            this.lblMaHopDong.Text = "Mã hợp đồng";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(424, 112);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(85, 14);
            this.lblNgayKetThuc.TabIndex = 25;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHetHan.Location = new System.Drawing.Point(423, 72);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(81, 14);
            this.lblNgayHetHan.TabIndex = 24;
            this.lblNgayHetHan.Text = "Ngày hết hạn";
            // 
            // lblNgayHieuLuc
            // 
            this.lblNgayHieuLuc.AutoSize = true;
            this.lblNgayHieuLuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHieuLuc.Location = new System.Drawing.Point(424, 35);
            this.lblNgayHieuLuc.Name = "lblNgayHieuLuc";
            this.lblNgayHieuLuc.Size = new System.Drawing.Size(81, 14);
            this.lblNgayHieuLuc.TabIndex = 23;
            this.lblNgayHieuLuc.Text = "Ngày hiệu lực";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.Location = new System.Drawing.Point(128, 188);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(87, 18);
            this.cbTrangThai.TabIndex = 22;
            this.cbTrangThai.Text = "Có hiệu lực";
            this.cbTrangThai.UseVisualStyleBackColor = true;
            this.cbTrangThai.CheckedChanged += new System.EventHandler(this.cbTrangThai_CheckedChanged);
            // 
            // dtpNgayKy
            // 
            this.dtpNgayKy.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKy.Location = new System.Drawing.Point(128, 147);
            this.dtpNgayKy.Name = "dtpNgayKy";
            this.dtpNgayKy.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayKy.TabIndex = 21;
            // 
            // cmbTenLoaiHopDong
            // 
            this.cmbTenLoaiHopDong.FormattingEnabled = true;
            this.cmbTenLoaiHopDong.Location = new System.Drawing.Point(128, 112);
            this.cmbTenLoaiHopDong.Name = "cmbTenLoaiHopDong";
            this.cmbTenLoaiHopDong.Size = new System.Drawing.Size(200, 21);
            this.cmbTenLoaiHopDong.TabIndex = 20;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(128, 72);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(200, 21);
            this.cmbNhanVien.TabIndex = 19;
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(128, 30);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(200, 21);
            this.cmbBoPhan.TabIndex = 18;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbBoPhan_SelectedIndexChanged);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(28, 188);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(63, 14);
            this.lblTrangThai.TabIndex = 17;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblNgayKy
            // 
            this.lblNgayKy.AutoSize = true;
            this.lblNgayKy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKy.Location = new System.Drawing.Point(28, 152);
            this.lblNgayKy.Name = "lblNgayKy";
            this.lblNgayKy.Size = new System.Drawing.Size(50, 14);
            this.lblNgayKy.TabIndex = 4;
            this.lblNgayKy.Text = "Ngày ký";
            // 
            // lblLoaiHopDong
            // 
            this.lblLoaiHopDong.AutoSize = true;
            this.lblLoaiHopDong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHopDong.Location = new System.Drawing.Point(28, 112);
            this.lblLoaiHopDong.Name = "lblLoaiHopDong";
            this.lblLoaiHopDong.Size = new System.Drawing.Size(107, 14);
            this.lblLoaiHopDong.TabIndex = 3;
            this.lblLoaiHopDong.Text = "Tên loại hợp đồng";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(28, 72);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(86, 14);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.AutoSize = true;
            this.lblBoPhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoPhan.Location = new System.Drawing.Point(28, 35);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(52, 14);
            this.lblBoPhan.TabIndex = 1;
            this.lblBoPhan.Text = "Bộ phận";
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(10, 284);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 24);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(175, 284);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 24);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Location = new System.Drawing.Point(341, 284);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 24);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(659, 284);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 24);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuybo
            // 
            this.btnHuybo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuybo.Location = new System.Drawing.Point(506, 284);
            this.btnHuybo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(84, 24);
            this.btnHuybo.TabIndex = 5;
            this.btnHuybo.Text = "Hủy Bỏ";
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // grdHopDong
            // 
            this.grdHopDong.AllowUserToAddRows = false;
            this.grdHopDong.AllowUserToDeleteRows = false;
            this.grdHopDong.AllowUserToOrderColumns = true;
            this.grdHopDong.AllowUserToResizeRows = false;
            this.grdHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenBoPhan,
            this.TenNV,
            this.MaHD,
            this.LoaiHopDong,
            this.NgayKy,
            this.NgayHieuLuc,
            this.NgayHetHan,
            this.NgayKetThuc,
            this.HieuLuc});
            this.grdHopDong.Location = new System.Drawing.Point(10, 324);
            this.grdHopDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdHopDong.Name = "grdHopDong";
            this.grdHopDong.ReadOnly = true;
            this.grdHopDong.RowHeadersWidth = 51;
            this.grdHopDong.RowTemplate.Height = 24;
            this.grdHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHopDong.Size = new System.Drawing.Size(733, 168);
            this.grdHopDong.TabIndex = 6;
            // 
            // TenBoPhan
            // 
            this.TenBoPhan.DataPropertyName = "TenBoPhan";
            this.TenBoPhan.HeaderText = "Tên Bộ Phận";
            this.TenBoPhan.MinimumWidth = 6;
            this.TenBoPhan.Name = "TenBoPhan";
            this.TenBoPhan.ReadOnly = true;
            this.TenBoPhan.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 125;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHopDong";
            this.MaHD.HeaderText = "Mã Hợp Đồng";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 125;
            // 
            // LoaiHopDong
            // 
            this.LoaiHopDong.DataPropertyName = "TenLoaiHopDong";
            this.LoaiHopDong.HeaderText = "Tên Loại Hợp Đồng";
            this.LoaiHopDong.MinimumWidth = 6;
            this.LoaiHopDong.Name = "LoaiHopDong";
            this.LoaiHopDong.ReadOnly = true;
            this.LoaiHopDong.Width = 125;
            // 
            // NgayKy
            // 
            this.NgayKy.DataPropertyName = "NgayKy";
            this.NgayKy.HeaderText = "Ngày Ký";
            this.NgayKy.MinimumWidth = 6;
            this.NgayKy.Name = "NgayKy";
            this.NgayKy.ReadOnly = true;
            this.NgayKy.Width = 125;
            // 
            // NgayHieuLuc
            // 
            this.NgayHieuLuc.DataPropertyName = "NgayHieuLuc";
            this.NgayHieuLuc.HeaderText = "Ngày Hiệu Lực";
            this.NgayHieuLuc.MinimumWidth = 6;
            this.NgayHieuLuc.Name = "NgayHieuLuc";
            this.NgayHieuLuc.ReadOnly = true;
            this.NgayHieuLuc.Width = 125;
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHan.MinimumWidth = 6;
            this.NgayHetHan.Name = "NgayHetHan";
            this.NgayHetHan.ReadOnly = true;
            this.NgayHetHan.Width = 125;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            this.NgayKetThuc.Width = 125;
            // 
            // HieuLuc
            // 
            this.HieuLuc.DataPropertyName = "TrangThai";
            this.HieuLuc.HeaderText = "Hiệu Lực";
            this.HieuLuc.MinimumWidth = 6;
            this.HieuLuc.Name = "HieuLuc";
            this.HieuLuc.ReadOnly = true;
            this.HieuLuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HieuLuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HieuLuc.Width = 125;
            // 
            // HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 499);
            this.Controls.Add(this.grdHopDong);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbThongTin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HopDong";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Hợp Đồng";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.HopDong_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHopDong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtpNgayHieuLuc;
        private System.Windows.Forms.Label lblMaHopDong;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.Label lblNgayHieuLuc;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgayKy;
        private System.Windows.Forms.ComboBox cmbTenLoaiHopDong;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblNgayKy;
        private System.Windows.Forms.Label lblLoaiHopDong;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblBoPhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.DataGridView grdHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHieuLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HieuLuc;
    }
}