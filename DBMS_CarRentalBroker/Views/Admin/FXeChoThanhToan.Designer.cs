namespace DBMS_CarRentalBroker.Views.Admin
{
    partial class FXeChoThanhToan
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
            this.gvXeChoThanhToan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeChoThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(94, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH XE ĐANG CHỜ THANH TOÁN PHÍ ĐĂNG BÀI";
            // 
            // gvXeChoThanhToan
            // 
            this.gvXeChoThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvXeChoThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvXeChoThanhToan.Location = new System.Drawing.Point(112, 84);
            this.gvXeChoThanhToan.Name = "gvXeChoThanhToan";
            this.gvXeChoThanhToan.RowHeadersWidth = 62;
            this.gvXeChoThanhToan.RowTemplate.Height = 28;
            this.gvXeChoThanhToan.Size = new System.Drawing.Size(699, 354);
            this.gvXeChoThanhToan.TabIndex = 1;
            this.gvXeChoThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvXeChoThanhToan_CellClick);
            // 
            // FXeChoThanhToan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.gvXeChoThanhToan);
            this.Controls.Add(this.label1);
            this.Name = "FXeChoThanhToan";
            this.Text = "FXeChoThanhToan";
            this.Load += new System.EventHandler(this.FXeChoThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvXeChoThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvXeChoThanhToan;
    }
}