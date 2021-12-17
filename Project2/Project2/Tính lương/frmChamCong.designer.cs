namespace Project2
{
    partial class frmChamCong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCong));
            this.grbThongTinChamCong = new System.Windows.Forms.GroupBox();
            this.btnHienThi = new DevExpress.XtraEditors.SimpleButton();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblBoPhan = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNgayCongChuan = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtNgayDiLam = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtNgayNghiLe = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtNgayNghiPhepTinhLuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtNgayKhongLuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtNgayTinhLuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtNgayChamCong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtGhiChu = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItems = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.ChamCongGrid = new System.Windows.Forms.DataGridView();
            this.btnNop = new DevExpress.XtraEditors.SimpleButton();
            this.grbThongTinChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCongChuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayDiLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNghiLe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNghiPhepTinhLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKhongLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTinhLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamCongGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinChamCong
            // 
            this.grbThongTinChamCong.Controls.Add(this.btnHienThi);
            this.grbThongTinChamCong.Controls.Add(this.cmbBoPhan);
            this.grbThongTinChamCong.Controls.Add(this.dtpThang);
            this.grbThongTinChamCong.Controls.Add(this.lblThang);
            this.grbThongTinChamCong.Controls.Add(this.lblBoPhan);
            this.grbThongTinChamCong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinChamCong.Location = new System.Drawing.Point(12, 12);
            this.grbThongTinChamCong.Name = "grbThongTinChamCong";
            this.grbThongTinChamCong.Size = new System.Drawing.Size(1054, 66);
            this.grbThongTinChamCong.TabIndex = 44;
            this.grbThongTinChamCong.TabStop = false;
            this.grbThongTinChamCong.Text = "Thông tin Chấm Công";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(888, 19);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 13;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(279, 21);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(166, 22);
            this.cmbBoPhan.TabIndex = 12;
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(643, 21);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(156, 22);
            this.dtpThang.TabIndex = 11;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(538, 28);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(42, 14);
            this.lblThang.TabIndex = 5;
            this.lblThang.Text = "Tháng";
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.AutoSize = true;
            this.lblBoPhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoPhan.Location = new System.Drawing.Point(204, 28);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(52, 14);
            this.lblBoPhan.TabIndex = 2;
            this.lblBoPhan.Text = "Bộ phận";
            // 
            // txtNgayCongChuan
            // 
            this.txtNgayCongChuan.Name = "txtNgayCongChuan";
            // 
            // txtNgayDiLam
            // 
            this.txtNgayDiLam.Name = "txtNgayDiLam";
            // 
            // txtNgayNghiLe
            // 
            this.txtNgayNghiLe.Name = "txtNgayNghiLe";
            // 
            // txtNgayNghiPhepTinhLuong
            // 
            this.txtNgayNghiPhepTinhLuong.Name = "txtNgayNghiPhepTinhLuong";
            // 
            // txtNgayKhongLuong
            // 
            this.txtNgayKhongLuong.Name = "txtNgayKhongLuong";
            // 
            // txtNgayTinhLuong
            // 
            this.txtNgayTinhLuong.Name = "txtNgayTinhLuong";
            // 
            // txtNgayChamCong
            // 
            this.txtNgayChamCong.Name = "txtNgayChamCong";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Name = "txtGhiChu";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItems
            // 
            this.repositoryItems.AutoHeight = false;
            this.repositoryItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItems.Name = "repositoryItems";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemPictureEdit1.Appearance.Image")));
            this.repositoryItemPictureEdit1.Appearance.Options.UseImage = true;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(733, 338);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 37);
            this.btnLuu.TabIndex = 50;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // ChamCongGrid
            // 
            this.ChamCongGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChamCongGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChamCongGrid.Location = new System.Drawing.Point(12, 84);
            this.ChamCongGrid.Name = "ChamCongGrid";
            this.ChamCongGrid.Size = new System.Drawing.Size(1054, 248);
            this.ChamCongGrid.TabIndex = 52;
            // 
            // btnNop
            // 
            this.btnNop.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNop.Appearance.Options.UseFont = true;
            this.btnNop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNop.ImageOptions.Image")));
            this.btnNop.Location = new System.Drawing.Point(900, 338);
            this.btnNop.Name = "btnNop";
            this.btnNop.Size = new System.Drawing.Size(122, 37);
            this.btnNop.TabIndex = 53;
            this.btnNop.Text = "Nộp";
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 387);
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.ChamCongGrid);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grbThongTinChamCong);
            this.Name = "frmChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAM CONG";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            this.grbThongTinChamCong.ResumeLayout(false);
            this.grbThongTinChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayCongChuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayDiLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNghiLe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNghiPhepTinhLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayKhongLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayTinhLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChamCongGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinChamCong;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblBoPhan;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.SimpleButton btnHienThi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNgayCongChuan;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNgayDiLam;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNgayNghiLe;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNgayNghiPhepTinhLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNgayKhongLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNgayTinhLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtNgayChamCong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.DataGridView ChamCongGrid;
        private DevExpress.XtraEditors.SimpleButton btnNop;
    }
}