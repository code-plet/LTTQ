
namespace Project2.Features
{
    partial class DanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc));
            this.btnBoPhan = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.BackColor = System.Drawing.Color.Lime;
            this.btnBoPhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoPhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoPhan.Location = new System.Drawing.Point(46, 89);
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.Size = new System.Drawing.Size(138, 85);
            this.btnBoPhan.TabIndex = 0;
            this.btnBoPhan.Text = "Thêm Bộ Phận";
            this.btnBoPhan.UseVisualStyleBackColor = false;
            this.btnBoPhan.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHopDong.FlatAppearance.BorderSize = 2;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.Location = new System.Drawing.Point(264, 89);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(138, 85);
            this.btnHopDong.TabIndex = 1;
            this.btnHopDong.Text = "Thêm Loại HĐ";
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 247);
            this.Controls.Add(this.btnHopDong);
            this.Controls.Add(this.btnBoPhan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhMuc";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Danh Mục";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoPhan;
        private System.Windows.Forms.Button btnHopDong;
    }
}