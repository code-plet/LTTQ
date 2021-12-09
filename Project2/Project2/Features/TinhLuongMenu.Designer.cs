
namespace Project2.Features
{
    partial class TinhLuongMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhLuongMenu));
            this.ChamCongButton = new System.Windows.Forms.Button();
            this.TinhLuongButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChamCongButton
            // 
            this.ChamCongButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ChamCongButton.BackColor = System.Drawing.Color.White;
            this.ChamCongButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChamCongButton.FlatAppearance.BorderSize = 0;
            this.ChamCongButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ChamCongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChamCongButton.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChamCongButton.Image = ((System.Drawing.Image)(resources.GetObject("ChamCongButton.Image")));
            this.ChamCongButton.Location = new System.Drawing.Point(12, 36);
            this.ChamCongButton.Name = "ChamCongButton";
            this.ChamCongButton.Size = new System.Drawing.Size(144, 129);
            this.ChamCongButton.TabIndex = 3;
            this.ChamCongButton.Text = "Chấm Công";
            this.ChamCongButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChamCongButton.UseVisualStyleBackColor = false;
            this.ChamCongButton.Click += new System.EventHandler(this.ChamCongButton_Click);
            // 
            // TinhLuongButton
            // 
            this.TinhLuongButton.BackColor = System.Drawing.Color.White;
            this.TinhLuongButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TinhLuongButton.FlatAppearance.BorderSize = 0;
            this.TinhLuongButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TinhLuongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TinhLuongButton.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhLuongButton.Image = ((System.Drawing.Image)(resources.GetObject("TinhLuongButton.Image")));
            this.TinhLuongButton.Location = new System.Drawing.Point(185, 36);
            this.TinhLuongButton.Name = "TinhLuongButton";
            this.TinhLuongButton.Size = new System.Drawing.Size(144, 129);
            this.TinhLuongButton.TabIndex = 4;
            this.TinhLuongButton.Text = "Bản Kê Lương";
            this.TinhLuongButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TinhLuongButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(311, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 30);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TinhLuongMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 174);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TinhLuongButton);
            this.Controls.Add(this.ChamCongButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TinhLuongMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChamCongButton;
        private System.Windows.Forms.Button TinhLuongButton;
        private System.Windows.Forms.Button CloseButton;
    }
}