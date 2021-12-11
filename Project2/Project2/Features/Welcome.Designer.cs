
namespace Project2.Features
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnTinhluong = new System.Windows.Forms.Button();
            this.btnPhanquyen = new System.Windows.Forms.Button();
            this.btnQuanly = new System.Windows.Forms.Button();
            this.btnHoso = new System.Windows.Forms.Button();
            this.btnHopdong = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCVBP = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsername.Location = new System.Drawing.Point(129, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(42, 25);
            this.lblUsername.Style = MetroFramework.MetroColorStyle.Black;
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "......";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(953, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(72, 64);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.Red;
            this.btnDoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMK.FlatAppearance.BorderSize = 0;
            this.btnDoiMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.Image")));
            this.btnDoiMK.Location = new System.Drawing.Point(51, 85);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(170, 142);
            this.btnDoiMK.TabIndex = 2;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnTinhluong
            // 
            this.btnTinhluong.BackColor = System.Drawing.Color.Lime;
            this.btnTinhluong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhluong.FlatAppearance.BorderSize = 0;
            this.btnTinhluong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTinhluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhluong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhluong.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhluong.Image")));
            this.btnTinhluong.Location = new System.Drawing.Point(51, 297);
            this.btnTinhluong.Name = "btnTinhluong";
            this.btnTinhluong.Size = new System.Drawing.Size(170, 141);
            this.btnTinhluong.TabIndex = 3;
            this.btnTinhluong.Text = "Tính Lương";
            this.btnTinhluong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTinhluong.UseVisualStyleBackColor = false;
            // 
            // btnPhanquyen
            // 
            this.btnPhanquyen.BackColor = System.Drawing.Color.Blue;
            this.btnPhanquyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhanquyen.FlatAppearance.BorderSize = 0;
            this.btnPhanquyen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPhanquyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanquyen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanquyen.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanquyen.Image")));
            this.btnPhanquyen.Location = new System.Drawing.Point(306, 296);
            this.btnPhanquyen.Name = "btnPhanquyen";
            this.btnPhanquyen.Size = new System.Drawing.Size(170, 141);
            this.btnPhanquyen.TabIndex = 4;
            this.btnPhanquyen.Text = "Phân Quyền ";
            this.btnPhanquyen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPhanquyen.UseVisualStyleBackColor = false;
            this.btnPhanquyen.Click += new System.EventHandler(this.btnPhanquyen_Click);
            // 
            // btnQuanly
            // 
            this.btnQuanly.BackColor = System.Drawing.Color.Yellow;
            this.btnQuanly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanly.FlatAppearance.BorderSize = 0;
            this.btnQuanly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuanly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanly.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanly.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanly.Image")));
            this.btnQuanly.Location = new System.Drawing.Point(306, 85);
            this.btnQuanly.Name = "btnQuanly";
            this.btnQuanly.Size = new System.Drawing.Size(170, 142);
            this.btnQuanly.TabIndex = 5;
            this.btnQuanly.Text = "Quản Lý Người Dùng";
            this.btnQuanly.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanly.UseVisualStyleBackColor = false;
            this.btnQuanly.Click += new System.EventHandler(this.btnQuanly_Click);
            // 
            // btnHoso
            // 
            this.btnHoso.BackColor = System.Drawing.Color.Fuchsia;
            this.btnHoso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoso.FlatAppearance.BorderSize = 0;
            this.btnHoso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHoso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoso.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoso.Image = ((System.Drawing.Image)(resources.GetObject("btnHoso.Image")));
            this.btnHoso.Location = new System.Drawing.Point(555, 85);
            this.btnHoso.Name = "btnHoso";
            this.btnHoso.Size = new System.Drawing.Size(170, 142);
            this.btnHoso.TabIndex = 6;
            this.btnHoso.Text = "Hồ Sơ Nhân Viên";
            this.btnHoso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHoso.UseVisualStyleBackColor = false;
            this.btnHoso.Click += new System.EventHandler(this.btnHoso_Click);
            // 
            // btnHopdong
            // 
            this.btnHopdong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHopdong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHopdong.FlatAppearance.BorderSize = 0;
            this.btnHopdong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopdong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopdong.Image = ((System.Drawing.Image)(resources.GetObject("btnHopdong.Image")));
            this.btnHopdong.Location = new System.Drawing.Point(555, 297);
            this.btnHopdong.Name = "btnHopdong";
            this.btnHopdong.Size = new System.Drawing.Size(170, 142);
            this.btnHopdong.TabIndex = 7;
            this.btnHopdong.Text = "Hợp Đồng";
            this.btnHopdong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHopdong.UseVisualStyleBackColor = false;
            this.btnHopdong.Click += new System.EventHandler(this.btnHopdong_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(25, 565);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(57, 26);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCVBP
            // 
            this.btnCVBP.BackColor = System.Drawing.Color.MediumPurple;
            this.btnCVBP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCVBP.FlatAppearance.BorderSize = 0;
            this.btnCVBP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCVBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCVBP.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCVBP.Image = ((System.Drawing.Image)(resources.GetObject("btnCVBP.Image")));
            this.btnCVBP.Location = new System.Drawing.Point(807, 85);
            this.btnCVBP.Name = "btnCVBP";
            this.btnCVBP.Size = new System.Drawing.Size(170, 142);
            this.btnCVBP.TabIndex = 9;
            this.btnCVBP.Text = "Chức Vụ - Bộ Phận";
            this.btnCVBP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCVBP.UseVisualStyleBackColor = false;
            this.btnCVBP.Click += new System.EventHandler(this.btnCVBP_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.Color.Aqua;
            this.btnDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMuc.Image")));
            this.btnDanhMuc.Location = new System.Drawing.Point(807, 297);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(170, 142);
            this.btnDanhMuc.TabIndex = 10;
            this.btnDanhMuc.Text = "Danh Mục";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // Welcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1026, 591);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnCVBP);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.btnHopdong);
            this.Controls.Add(this.btnHoso);
            this.Controls.Add(this.btnQuanly);
            this.Controls.Add(this.btnPhanquyen);
            this.Controls.Add(this.btnTinhluong);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.Padding = new System.Windows.Forms.Padding(22, 60, 22, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Welcome,";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnTinhluong;
        private System.Windows.Forms.Button btnPhanquyen;
        private System.Windows.Forms.Button btnQuanly;
        private System.Windows.Forms.Button btnHoso;
        private System.Windows.Forms.Button btnHopdong;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCVBP;
        private System.Windows.Forms.Button btnDanhMuc;
    }
}