namespace DBMS_CarRentalBroker.Views.NguoiThue
{
    partial class FTrangChu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLichSuGD = new System.Windows.Forms.Label();
            this.lblLichSuThue = new System.Windows.Forms.Label();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.lblTrangChu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(191)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.lblLichSuGD);
            this.panel1.Controls.Add(this.lblLichSuThue);
            this.panel1.Controls.Add(this.lblThanhToan);
            this.panel1.Controls.Add(this.lblTrangChu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 551);
            this.panel1.TabIndex = 2;
            // 
            // lblLichSuGD
            // 
            this.lblLichSuGD.AutoSize = true;
            this.lblLichSuGD.ForeColor = System.Drawing.Color.White;
            this.lblLichSuGD.Location = new System.Drawing.Point(26, 322);
            this.lblLichSuGD.Name = "lblLichSuGD";
            this.lblLichSuGD.Size = new System.Drawing.Size(146, 18);
            this.lblLichSuGD.TabIndex = 7;
            this.lblLichSuGD.Text = "Lịch sử giao dịch";
            this.lblLichSuGD.Click += new System.EventHandler(this.lblLichSuGD_Click);
            // 
            // lblLichSuThue
            // 
            this.lblLichSuThue.AutoSize = true;
            this.lblLichSuThue.ForeColor = System.Drawing.Color.White;
            this.lblLichSuThue.Location = new System.Drawing.Point(26, 262);
            this.lblLichSuThue.Name = "lblLichSuThue";
            this.lblLichSuThue.Size = new System.Drawing.Size(142, 18);
            this.lblLichSuThue.TabIndex = 6;
            this.lblLichSuThue.Text = "Lịch sử đặt thuê";
            this.lblLichSuThue.Click += new System.EventHandler(this.lblLichSuThue_Click);
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.ForeColor = System.Drawing.Color.White;
            this.lblThanhToan.Location = new System.Drawing.Point(26, 201);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(101, 18);
            this.lblThanhToan.TabIndex = 5;
            this.lblThanhToan.Text = "Thanh toán";
            this.lblThanhToan.Click += new System.EventHandler(this.lblThanhToan_Click);
            // 
            // lblTrangChu
            // 
            this.lblTrangChu.AutoSize = true;
            this.lblTrangChu.ForeColor = System.Drawing.Color.White;
            this.lblTrangChu.Location = new System.Drawing.Point(26, 135);
            this.lblTrangChu.Name = "lblTrangChu";
            this.lblTrangChu.Size = new System.Drawing.Size(86, 18);
            this.lblTrangChu.TabIndex = 1;
            this.lblTrangChu.Text = "Trang chủ";
            this.lblTrangChu.Click += new System.EventHandler(this.lblTrangChu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 53);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đăng xuất";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(825, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(26, 25);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(194, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 53);
            this.panel3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 25);
            this.label8.TabIndex = 166;
            this.label8.Text = "Hệ thống cho thuê xe ô tô";
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(207, 64);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(838, 475);
            this.pnlContent.TabIndex = 6;
            // 
            // FTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 551);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhSachXe";
            this.Load += new System.EventHandler(this.FTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTrangChu;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label lblLichSuGD;
        private System.Windows.Forms.Label lblLichSuThue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlContent;
    }
}