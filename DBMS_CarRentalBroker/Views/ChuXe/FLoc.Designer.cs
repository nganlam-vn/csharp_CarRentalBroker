namespace DBMS_CarRentalBroker.Views.ChuXe
{
    partial class FLoc
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
            this.btnLoc = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbTheoGia = new System.Windows.Forms.CheckedListBox();
            this.clbTheoHang = new System.Windows.Forms.CheckedListBox();
            this.clbSoGhe = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnLoc
            // 
            this.btnLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(39, 367);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(123, 35);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Theo Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Theo Hãng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Ghế";
            // 
            // clbTheoGia
            // 
            this.clbTheoGia.FormattingEnabled = true;
            this.clbTheoGia.Location = new System.Drawing.Point(3, 28);
            this.clbTheoGia.Name = "clbTheoGia";
            this.clbTheoGia.Size = new System.Drawing.Size(189, 72);
            this.clbTheoGia.TabIndex = 4;
            // 
            // clbTheoHang
            // 
            this.clbTheoHang.FormattingEnabled = true;
            this.clbTheoHang.Location = new System.Drawing.Point(3, 132);
            this.clbTheoHang.Name = "clbTheoHang";
            this.clbTheoHang.Size = new System.Drawing.Size(188, 140);
            this.clbTheoHang.TabIndex = 5;
            // 
            // clbSoGhe
            // 
            this.clbSoGhe.FormattingEnabled = true;
            this.clbSoGhe.Location = new System.Drawing.Point(3, 301);
            this.clbSoGhe.Name = "clbSoGhe";
            this.clbSoGhe.Size = new System.Drawing.Size(188, 72);
            this.clbSoGhe.TabIndex = 6;
            // 
            // FLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(203, 428);
            this.Controls.Add(this.clbSoGhe);
            this.Controls.Add(this.clbTheoHang);
            this.Controls.Add(this.clbTheoGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoc);
            this.Name = "FLoc";
            this.Text = "FLoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbTheoGia;
        private System.Windows.Forms.CheckedListBox clbTheoHang;
        private System.Windows.Forms.CheckedListBox clbSoGhe;
    }
}