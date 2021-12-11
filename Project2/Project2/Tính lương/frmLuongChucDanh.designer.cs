namespace Project2
{
    partial class frmLuongChucDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuongChucDanh));
            this.grbLuongChucDanh = new System.Windows.Forms.GroupBox();
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.txtTienLuongCung = new DevExpress.XtraEditors.TextEdit();
            this.txtPhuCap = new DevExpress.XtraEditors.TextEdit();
            this.lblTienLuongCung = new System.Windows.Forms.Label();
            this.txtChucDanh = new DevExpress.XtraEditors.TextEdit();
            this.lblChucDanh = new System.Windows.Forms.Label();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.LuongChucDanhGrid = new System.Windows.Forms.DataGridView();
            this.grbLuongChucDanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienLuongCung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhuCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucDanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongChucDanhGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLuongChucDanh
            // 
            this.grbLuongChucDanh.Controls.Add(this.lblPhuCap);
            this.grbLuongChucDanh.Controls.Add(this.txtTienLuongCung);
            this.grbLuongChucDanh.Controls.Add(this.txtPhuCap);
            this.grbLuongChucDanh.Controls.Add(this.lblTienLuongCung);
            this.grbLuongChucDanh.Controls.Add(this.txtChucDanh);
            this.grbLuongChucDanh.Controls.Add(this.lblChucDanh);
            this.grbLuongChucDanh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLuongChucDanh.Location = new System.Drawing.Point(12, 11);
            this.grbLuongChucDanh.Name = "grbLuongChucDanh";
            this.grbLuongChucDanh.Size = new System.Drawing.Size(721, 76);
            this.grbLuongChucDanh.TabIndex = 37;
            this.grbLuongChucDanh.TabStop = false;
            this.grbLuongChucDanh.Text = "Thông tin Lương Chức Danh";
            // 
            // lblPhuCap
            // 
            this.lblPhuCap.AutoSize = true;
            this.lblPhuCap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuCap.Location = new System.Drawing.Point(517, 36);
            this.lblPhuCap.Name = "lblPhuCap";
            this.lblPhuCap.Size = new System.Drawing.Size(51, 14);
            this.lblPhuCap.TabIndex = 4;
            this.lblPhuCap.Text = "Phụ cấp";
            // 
            // txtTienLuongCung
            // 
            this.txtTienLuongCung.Location = new System.Drawing.Point(366, 30);
            this.txtTienLuongCung.Name = "txtTienLuongCung";
            this.txtTienLuongCung.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienLuongCung.Properties.Appearance.Options.UseFont = true;
            this.txtTienLuongCung.Size = new System.Drawing.Size(126, 20);
            this.txtTienLuongCung.TabIndex = 3;
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(583, 33);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuCap.Properties.Appearance.Options.UseFont = true;
            this.txtPhuCap.Size = new System.Drawing.Size(122, 20);
            this.txtPhuCap.TabIndex = 3;
            // 
            // lblTienLuongCung
            // 
            this.lblTienLuongCung.AutoSize = true;
            this.lblTienLuongCung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienLuongCung.Location = new System.Drawing.Point(253, 36);
            this.lblTienLuongCung.Name = "lblTienLuongCung";
            this.lblTienLuongCung.Size = new System.Drawing.Size(98, 14);
            this.lblTienLuongCung.TabIndex = 2;
            this.lblTienLuongCung.Text = "Tiền lương cứng";
            // 
            // txtChucDanh
            // 
            this.txtChucDanh.Location = new System.Drawing.Point(93, 30);
            this.txtChucDanh.Name = "txtChucDanh";
            this.txtChucDanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucDanh.Properties.Appearance.Options.UseFont = true;
            this.txtChucDanh.Size = new System.Drawing.Size(128, 20);
            this.txtChucDanh.TabIndex = 1;
            this.txtChucDanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChucDanh_KeyPress);
            // 
            // lblChucDanh
            // 
            this.lblChucDanh.AutoSize = true;
            this.lblChucDanh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucDanh.Location = new System.Drawing.Point(6, 36);
            this.lblChucDanh.Name = "lblChucDanh";
            this.lblChucDanh.Size = new System.Drawing.Size(66, 14);
            this.lblChucDanh.TabIndex = 0;
            this.lblChucDanh.Text = "Chức danh";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Appearance.Options.UseFont = true;
            this.btnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.Image")));
            this.btnHuyBo.Location = new System.Drawing.Point(462, 102);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(119, 32);
            this.btnHuyBo.TabIndex = 35;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(612, 102);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 32);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(312, 102);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(119, 32);
            this.btnCapNhat.TabIndex = 39;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(162, 102);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 32);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(12, 102);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 32);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // LuongChucDanhGrid
            // 
            this.LuongChucDanhGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LuongChucDanhGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuongChucDanhGrid.Location = new System.Drawing.Point(12, 165);
            this.LuongChucDanhGrid.Name = "LuongChucDanhGrid";
            this.LuongChucDanhGrid.ReadOnly = true;
            this.LuongChucDanhGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LuongChucDanhGrid.Size = new System.Drawing.Size(721, 219);
            this.LuongChucDanhGrid.TabIndex = 41;
            this.LuongChucDanhGrid.SelectionChanged += new System.EventHandler(this.LuongChucDanhGrid_SelectionChanged);
            // 
            // frmLuongChucDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 396);
            this.Controls.Add(this.LuongChucDanhGrid);
            this.Controls.Add(this.grbLuongChucDanh);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "frmLuongChucDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUONG CHUC DANH";
            this.Load += new System.EventHandler(this.frmLuongChucDanh_Load);
            this.grbLuongChucDanh.ResumeLayout(false);
            this.grbLuongChucDanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienLuongCung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhuCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucDanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongChucDanhGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLuongChucDanh;
        private DevExpress.XtraEditors.TextEdit txtPhuCap;
        private DevExpress.XtraEditors.TextEdit txtChucDanh;
        private System.Windows.Forms.Label lblChucDanh;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label lblPhuCap;
        private DevExpress.XtraEditors.TextEdit txtTienLuongCung;
        private System.Windows.Forms.Label lblTienLuongCung;
        private System.Windows.Forms.DataGridView LuongChucDanhGrid;
    }
}