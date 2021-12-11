
namespace Project2.Features
{
    partial class ThemLoaiHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLoaiHD));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLoaiHopDong = new System.Windows.Forms.TextBox();
            this.lblTinhThanh = new System.Windows.Forms.Label();
            this.grdThemHD = new System.Windows.Forms.DataGridView();
            this.IDLoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemHD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(576, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 49);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(550, 177);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 38);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuybo
            // 
            this.btnHuybo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuybo.Location = new System.Drawing.Point(425, 177);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(77, 38);
            this.btnHuybo.TabIndex = 21;
            this.btnHuybo.Text = "Hủy Bỏ";
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuyBo_Click_1);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Location = new System.Drawing.Point(269, 176);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(106, 38);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(138, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 38);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(6, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 38);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLoaiHopDong);
            this.groupBox1.Controls.Add(this.lblTinhThanh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 98);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtLoaiHopDong
            // 
            this.txtLoaiHopDong.Location = new System.Drawing.Point(158, 33);
            this.txtLoaiHopDong.Name = "txtLoaiHopDong";
            this.txtLoaiHopDong.Size = new System.Drawing.Size(286, 27);
            this.txtLoaiHopDong.TabIndex = 2;
            // 
            // lblTinhThanh
            // 
            this.lblTinhThanh.AutoSize = true;
            this.lblTinhThanh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhThanh.Location = new System.Drawing.Point(79, 42);
            this.lblTinhThanh.Name = "lblTinhThanh";
            this.lblTinhThanh.Size = new System.Drawing.Size(73, 18);
            this.lblTinhThanh.TabIndex = 1;
            this.lblTinhThanh.Text = "Hợp Đồng";
            // 
            // grdThemHD
            // 
            this.grdThemHD.AllowUserToAddRows = false;
            this.grdThemHD.AllowUserToDeleteRows = false;
            this.grdThemHD.AllowUserToOrderColumns = true;
            this.grdThemHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdThemHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLoaiHD,
            this.TenHD});
            this.grdThemHD.Location = new System.Drawing.Point(6, 221);
            this.grdThemHD.Name = "grdThemHD";
            this.grdThemHD.ReadOnly = true;
            this.grdThemHD.RowHeadersWidth = 51;
            this.grdThemHD.RowTemplate.Height = 24;
            this.grdThemHD.Size = new System.Drawing.Size(621, 150);
            this.grdThemHD.TabIndex = 23;
            // 
            // IDLoaiHD
            // 
            this.IDLoaiHD.DataPropertyName = "LoaiHopDongID";
            this.IDLoaiHD.HeaderText = "Loại Hợp Đồng ID";
            this.IDLoaiHD.MinimumWidth = 6;
            this.IDLoaiHD.Name = "IDLoaiHD";
            this.IDLoaiHD.ReadOnly = true;
            this.IDLoaiHD.Width = 125;
            // 
            // TenHD
            // 
            this.TenHD.DataPropertyName = "TenLoaiHopDong";
            this.TenHD.HeaderText = "Tên Loại Hợp Đồng";
            this.TenHD.MinimumWidth = 6;
            this.TenHD.Name = "TenHD";
            this.TenHD.ReadOnly = true;
            this.TenHD.Width = 290;
            // 
            // ThemLoaiHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 383);
            this.ControlBox = false;
            this.Controls.Add(this.grdThemHD);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemLoaiHD";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Thêm Loại Hợp Đồng";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.ThemLoaiHD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLoaiHopDong;
        private System.Windows.Forms.Label lblTinhThanh;
        private System.Windows.Forms.DataGridView grdThemHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLoaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHD;
    }
}