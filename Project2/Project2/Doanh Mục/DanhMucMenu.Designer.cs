
namespace Project2.Features
{
    partial class DanhMucMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMucMenu));
            this.LoaiHopDongButton = new System.Windows.Forms.Button();
            this.BoPhanButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoaiHopDongButton
            // 
            this.LoaiHopDongButton.BackColor = System.Drawing.Color.Gainsboro;
            this.LoaiHopDongButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoaiHopDongButton.FlatAppearance.BorderSize = 0;
            this.LoaiHopDongButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoaiHopDongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoaiHopDongButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiHopDongButton.Image = ((System.Drawing.Image)(resources.GetObject("LoaiHopDongButton.Image")));
            this.LoaiHopDongButton.Location = new System.Drawing.Point(171, 94);
            this.LoaiHopDongButton.Name = "LoaiHopDongButton";
            this.LoaiHopDongButton.Size = new System.Drawing.Size(144, 129);
            this.LoaiHopDongButton.TabIndex = 6;
            this.LoaiHopDongButton.Text = "Loại Hợp Đồng";
            this.LoaiHopDongButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoaiHopDongButton.UseVisualStyleBackColor = false;
            this.LoaiHopDongButton.Click += new System.EventHandler(this.LoaiHopDongButton_Click);
            // 
            // BoPhanButton
            // 
            this.BoPhanButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BoPhanButton.BackColor = System.Drawing.Color.Gainsboro;
            this.BoPhanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoPhanButton.FlatAppearance.BorderSize = 0;
            this.BoPhanButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BoPhanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoPhanButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoPhanButton.Image = ((System.Drawing.Image)(resources.GetObject("BoPhanButton.Image")));
            this.BoPhanButton.Location = new System.Drawing.Point(18, 94);
            this.BoPhanButton.Name = "BoPhanButton";
            this.BoPhanButton.Size = new System.Drawing.Size(144, 129);
            this.BoPhanButton.TabIndex = 5;
            this.BoPhanButton.Text = "Bộ Phận";
            this.BoPhanButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BoPhanButton.UseVisualStyleBackColor = false;
            this.BoPhanButton.Click += new System.EventHandler(this.BoPhanButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(301, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 30);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DanhMucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LoaiHopDongButton);
            this.Controls.Add(this.BoPhanButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhMucMenu";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Danh Mục";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoaiHopDongButton;
        private System.Windows.Forms.Button BoPhanButton;
        private System.Windows.Forms.Button CloseButton;
    }
}