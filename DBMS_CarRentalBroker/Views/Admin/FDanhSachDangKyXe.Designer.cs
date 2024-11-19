namespace DBMS_CarRentalBroker.Views.Admin
{
    partial class FDanhSachDangKyXe
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
            this.label1 = new System.Windows.Forms.Label();
            this.gvChoDuyet = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gvTuChoi = new System.Windows.Forms.DataGridView();
            this.btnTuChoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnDuyet = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvChoDuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTuChoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH CÁC XE ĐANG CHỜ DUYỆT";
            // 
            // gvChoDuyet
            // 
            this.gvChoDuyet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvChoDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChoDuyet.Location = new System.Drawing.Point(2, 65);
            this.gvChoDuyet.Name = "gvChoDuyet";
            this.gvChoDuyet.RowHeadersWidth = 62;
            this.gvChoDuyet.RowTemplate.Height = 28;
            this.gvChoDuyet.Size = new System.Drawing.Size(622, 290);
            this.gvChoDuyet.TabIndex = 0;
            this.gvChoDuyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvChoDuyet_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(101, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "DANH SÁCH CÁC XE BỊ TỪ CHỐI";
            // 
            // gvTuChoi
            // 
            this.gvTuChoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTuChoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTuChoi.Location = new System.Drawing.Point(2, 518);
            this.gvTuChoi.Name = "gvTuChoi";
            this.gvTuChoi.RowHeadersWidth = 62;
            this.gvTuChoi.RowTemplate.Height = 28;
            this.gvTuChoi.Size = new System.Drawing.Size(622, 298);
            this.gvTuChoi.TabIndex = 13;
            this.gvTuChoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTuChoi_CellClick);
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.BorderRadius = 10;
            this.btnTuChoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTuChoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTuChoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTuChoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTuChoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTuChoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuChoi.ForeColor = System.Drawing.Color.White;
            this.btnTuChoi.Location = new System.Drawing.Point(115, 383);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(132, 45);
            this.btnTuChoi.TabIndex = 14;
            this.btnTuChoi.Text = "Từ chối";
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.BorderRadius = 10;
            this.btnDuyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDuyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDuyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Location = new System.Drawing.Point(384, 383);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(132, 45);
            this.btnDuyet.TabIndex = 15;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // FDanhSachDangKyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 816);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.btnTuChoi);
            this.Controls.Add(this.gvTuChoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvChoDuyet);
            this.Name = "FDanhSachDangKyXe";
            this.Text = "DanhSachXe";
            this.Load += new System.EventHandler(this.FDanhSachDangKyXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvChoDuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTuChoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView gvChoDuyet;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView gvTuChoi;
    private Guna.UI2.WinForms.Guna2Button btnTuChoi;
    private Guna.UI2.WinForms.Guna2Button btnDuyet;
}
}