
namespace Project2.Features
{
    partial class CVBP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CVBP));
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnBoPhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChucVu
            // 
            this.btnChucVu.BackColor = System.Drawing.Color.Aqua;
            this.btnChucVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucVu.Location = new System.Drawing.Point(47, 102);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(127, 80);
            this.btnChucVu.TabIndex = 0;
            this.btnChucVu.Text = "Chức Vụ";
            this.btnChucVu.UseVisualStyleBackColor = false;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.BackColor = System.Drawing.Color.Yellow;
            this.btnBoPhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoPhan.FlatAppearance.BorderSize = 2;
            this.btnBoPhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoPhan.Location = new System.Drawing.Point(252, 102);
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.Size = new System.Drawing.Size(127, 80);
            this.btnBoPhan.TabIndex = 1;
            this.btnBoPhan.Text = "Bộ Phận";
            this.btnBoPhan.UseVisualStyleBackColor = false;
            this.btnBoPhan.Click += new System.EventHandler(this.btnBoPhan_Click);
            // 
            // CVBP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 254);
            this.Controls.Add(this.btnBoPhan);
            this.Controls.Add(this.btnChucVu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CVBP";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Chức Vụ - Bộ Phận";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.CVBP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.Button btnBoPhan;
    }
}