
namespace Project2.Features
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtNhaplai = new System.Windows.Forms.TextBox();
            this.checkboxMK = new MetroFramework.Controls.MetroCheckBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập lại mật khẩu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập mật khẩu mới";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(153, 110);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(424, 22);
            this.txtMKCu.TabIndex = 3;
            this.txtMKCu.UseSystemPasswordChar = true;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(153, 156);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(424, 22);
            this.txtMKMoi.TabIndex = 4;
            this.txtMKMoi.UseSystemPasswordChar = true;
            // 
            // txtNhaplai
            // 
            this.txtNhaplai.Location = new System.Drawing.Point(153, 205);
            this.txtNhaplai.Name = "txtNhaplai";
            this.txtNhaplai.Size = new System.Drawing.Size(424, 22);
            this.txtNhaplai.TabIndex = 5;
            this.txtNhaplai.UseSystemPasswordChar = true;
            // 
            // checkboxMK
            // 
            this.checkboxMK.AutoSize = true;
            this.checkboxMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxMK.Location = new System.Drawing.Point(470, 87);
            this.checkboxMK.Name = "checkboxMK";
            this.checkboxMK.Size = new System.Drawing.Size(107, 17);
            this.checkboxMK.TabIndex = 6;
            this.checkboxMK.Text = "Hiện mật khẩu";
            this.checkboxMK.UseVisualStyleBackColor = true;
            this.checkboxMK.CheckedChanged += new System.EventHandler(this.checkboxMK_CheckedChanged);
            this.checkboxMK.CheckStateChanged += new System.EventHandler(this.checkboxMK_CheckedChanged);
            // 
            // btnChange
            // 
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Location = new System.Drawing.Point(153, 250);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(119, 35);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Thay Đổi";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(451, 250);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 35);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(303, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy Bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 323);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.checkboxMK);
            this.Controls.Add(this.txtNhaplai);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Đổi Mật Khẩu";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtNhaplai;
        private MetroFramework.Controls.MetroCheckBox checkboxMK;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCancel;
    }
}