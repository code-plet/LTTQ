
namespace Project2.Features
{
    partial class PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanQuyen));
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.lblBoPhan = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.cmbBoPhan = new System.Windows.Forms.ComboBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.cmbNguoiDung = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbQLHT = new System.Windows.Forms.CheckBox();
            this.cbQLDanhMuc = new System.Windows.Forms.CheckBox();
            this.cbQLNhanSu = new System.Windows.Forms.CheckBox();
            this.cbQLTienLuong = new System.Windows.Forms.CheckBox();
            this.cbTKBaoCao = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cmbNguoiDung);
            this.grbThongTin.Controls.Add(this.cmbNhanVien);
            this.grbThongTin.Controls.Add(this.cmbBoPhan);
            this.grbThongTin.Controls.Add(this.lblNguoiDung);
            this.grbThongTin.Controls.Add(this.lblNhanVien);
            this.grbThongTin.Controls.Add(this.lblBoPhan);
            this.grbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.Location = new System.Drawing.Point(13, 78);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(411, 124);
            this.grbThongTin.TabIndex = 0;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // lblBoPhan
            // 
            this.lblBoPhan.AutoSize = true;
            this.lblBoPhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoPhan.Location = new System.Drawing.Point(6, 29);
            this.lblBoPhan.Name = "lblBoPhan";
            this.lblBoPhan.Size = new System.Drawing.Size(62, 18);
            this.lblBoPhan.TabIndex = 1;
            this.lblBoPhan.Text = "Bộ phận";
            this.lblBoPhan.Click += new System.EventHandler(this.lblBoPhan_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(6, 61);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(73, 18);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Nhân viên";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.Location = new System.Drawing.Point(6, 93);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(82, 18);
            this.lblNguoiDung.TabIndex = 3;
            this.lblNguoiDung.Text = "Người dùng";
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoPhan.FormattingEnabled = true;
            this.cmbBoPhan.Location = new System.Drawing.Point(102, 26);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Size = new System.Drawing.Size(295, 26);
            this.cmbBoPhan.TabIndex = 4;
            this.cmbBoPhan.SelectedIndexChanged += new System.EventHandler(this.cmbBoPhan_SelectedIndexChanged);
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(102, 58);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(295, 26);
            this.cmbNhanVien.TabIndex = 5;
            this.cmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVien_SelectedIndexChanged);
            // 
            // cmbNguoiDung
            // 
            this.cmbNguoiDung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNguoiDung.FormattingEnabled = true;
            this.cmbNguoiDung.Location = new System.Drawing.Point(102, 90);
            this.cmbNguoiDung.Name = "cmbNguoiDung";
            this.cmbNguoiDung.Size = new System.Drawing.Size(295, 26);
            this.cmbNguoiDung.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTKBaoCao);
            this.groupBox1.Controls.Add(this.cbQLTienLuong);
            this.groupBox1.Controls.Add(this.cbQLNhanSu);
            this.groupBox1.Controls.Add(this.cbQLDanhMuc);
            this.groupBox1.Controls.Add(this.cbQLHT);
            this.groupBox1.Location = new System.Drawing.Point(13, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbQLHT
            // 
            this.cbQLHT.AutoSize = true;
            this.cbQLHT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQLHT.Location = new System.Drawing.Point(13, 21);
            this.cbQLHT.Name = "cbQLHT";
            this.cbQLHT.Size = new System.Drawing.Size(143, 22);
            this.cbQLHT.TabIndex = 1;
            this.cbQLHT.Text = "Quản lý hệ thống";
            this.cbQLHT.UseVisualStyleBackColor = true;
            // 
            // cbQLDanhMuc
            // 
            this.cbQLDanhMuc.AutoSize = true;
            this.cbQLDanhMuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQLDanhMuc.Location = new System.Drawing.Point(13, 49);
            this.cbQLDanhMuc.Name = "cbQLDanhMuc";
            this.cbQLDanhMuc.Size = new System.Drawing.Size(150, 22);
            this.cbQLDanhMuc.TabIndex = 2;
            this.cbQLDanhMuc.Text = "Quản lý danh mục";
            this.cbQLDanhMuc.UseVisualStyleBackColor = true;
            // 
            // cbQLNhanSu
            // 
            this.cbQLNhanSu.AutoSize = true;
            this.cbQLNhanSu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQLNhanSu.Location = new System.Drawing.Point(13, 77);
            this.cbQLNhanSu.Name = "cbQLNhanSu";
            this.cbQLNhanSu.Size = new System.Drawing.Size(138, 22);
            this.cbQLNhanSu.TabIndex = 3;
            this.cbQLNhanSu.Text = "Quản lý nhân sự";
            this.cbQLNhanSu.UseVisualStyleBackColor = true;
            // 
            // cbQLTienLuong
            // 
            this.cbQLTienLuong.AutoSize = true;
            this.cbQLTienLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQLTienLuong.Location = new System.Drawing.Point(13, 105);
            this.cbQLTienLuong.Name = "cbQLTienLuong";
            this.cbQLTienLuong.Size = new System.Drawing.Size(148, 22);
            this.cbQLTienLuong.TabIndex = 4;
            this.cbQLTienLuong.Text = "Quản lý tiền lương";
            this.cbQLTienLuong.UseVisualStyleBackColor = true;
            // 
            // cbTKBaoCao
            // 
            this.cbTKBaoCao.AutoSize = true;
            this.cbTKBaoCao.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTKBaoCao.Location = new System.Drawing.Point(13, 133);
            this.cbTKBaoCao.Name = "cbTKBaoCao";
            this.cbTKBaoCao.Size = new System.Drawing.Size(149, 22);
            this.cbTKBaoCao.TabIndex = 5;
            this.cbTKBaoCao.Text = "Thống kê báo cáo";
            this.cbTKBaoCao.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(280, 386);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(144, 38);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 447);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongTin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhanQuyen";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Phân Quyền Người Dùng";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ComboBox cmbNguoiDung;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.ComboBox cmbBoPhan;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblBoPhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTKBaoCao;
        private System.Windows.Forms.CheckBox cbQLTienLuong;
        private System.Windows.Forms.CheckBox cbQLNhanSu;
        private System.Windows.Forms.CheckBox cbQLDanhMuc;
        private System.Windows.Forms.CheckBox cbQLHT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
    }
}