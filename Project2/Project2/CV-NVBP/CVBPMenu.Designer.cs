
namespace Project2.Features
{
    partial class CVBPMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CVBPMenu));
            this.ChucVuBtn = new System.Windows.Forms.Button();
            this.NVBPButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChucVuBtn
            // 
            this.ChucVuBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ChucVuBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.ChucVuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChucVuBtn.FlatAppearance.BorderSize = 0;
            this.ChucVuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ChucVuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChucVuBtn.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVuBtn.Image = ((System.Drawing.Image)(resources.GetObject("ChucVuBtn.Image")));
            this.ChucVuBtn.Location = new System.Drawing.Point(8, 58);
            this.ChucVuBtn.Name = "ChucVuBtn";
            this.ChucVuBtn.Size = new System.Drawing.Size(144, 129);
            this.ChucVuBtn.TabIndex = 8;
            this.ChucVuBtn.Text = "Chức Vụ";
            this.ChucVuBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChucVuBtn.UseVisualStyleBackColor = false;
            this.ChucVuBtn.Click += new System.EventHandler(this.ChucVuBtn_Click);
            // 
            // NVBPButton
            // 
            this.NVBPButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NVBPButton.BackColor = System.Drawing.Color.Gainsboro;
            this.NVBPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NVBPButton.FlatAppearance.BorderSize = 0;
            this.NVBPButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NVBPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NVBPButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NVBPButton.Image = ((System.Drawing.Image)(resources.GetObject("NVBPButton.Image")));
            this.NVBPButton.Location = new System.Drawing.Point(167, 58);
            this.NVBPButton.Name = "NVBPButton";
            this.NVBPButton.Size = new System.Drawing.Size(144, 129);
            this.NVBPButton.TabIndex = 7;
            this.NVBPButton.Text = "Nhân Viên-Bộ Phận";
            this.NVBPButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NVBPButton.UseVisualStyleBackColor = false;
            this.NVBPButton.Click += new System.EventHandler(this.NVBPButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(293, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 30);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CVBPMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 206);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ChucVuBtn);
            this.Controls.Add(this.NVBPButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CVBPMenu";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Chức Vụ - Bộ Phận";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChucVuBtn;
        private System.Windows.Forms.Button NVBPButton;
        private System.Windows.Forms.Button CloseButton;
    }
}