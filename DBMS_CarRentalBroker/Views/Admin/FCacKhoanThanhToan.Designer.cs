namespace DBMS_CarRentalBroker.Views.Admin
{
    partial class FCacKhoanThanhToan
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
            this.txtSoDu = new Guna.UI2.WinForms.Guna2TextBox();
            this.gvThanhToan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số dư ví";
            // 
            // txtSoDu
            // 
            this.txtSoDu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDu.DefaultText = "";
            this.txtSoDu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoDu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoDu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoDu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDu.ForeColor = System.Drawing.Color.Black;
            this.txtSoDu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoDu.Location = new System.Drawing.Point(554, 138);
            this.txtSoDu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.PasswordChar = '\0';
            this.txtSoDu.PlaceholderText = "";
            this.txtSoDu.SelectedText = "";
            this.txtSoDu.Size = new System.Drawing.Size(337, 50);
            this.txtSoDu.TabIndex = 1;
            // 
            // gvThanhToan
            // 
            this.gvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThanhToan.Location = new System.Drawing.Point(12, 211);
            this.gvThanhToan.Name = "gvThanhToan";
            this.gvThanhToan.RowHeadersWidth = 62;
            this.gvThanhToan.RowTemplate.Height = 28;
            this.gvThanhToan.Size = new System.Drawing.Size(1068, 327);
            this.gvThanhToan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(126, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(862, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "DANH SÁCH XE ĐANG CHỜ THANH TOÁN CỦA NGƯỜI THUÊ";
            // 
            // FCacKhoanThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvThanhToan);
            this.Controls.Add(this.txtSoDu);
            this.Controls.Add(this.label1);
            this.Name = "FCacKhoanThanhToan";
            this.Text = "FCacKhoanThanhToan";
            this.Load += new System.EventHandler(this.FCacKhoanThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSoDu;
        private System.Windows.Forms.DataGridView gvThanhToan;
        private System.Windows.Forms.Label label2;
    }
}