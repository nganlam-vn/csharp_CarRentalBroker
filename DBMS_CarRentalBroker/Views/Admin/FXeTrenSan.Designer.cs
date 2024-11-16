namespace DBMS_CarRentalBroker.Views.Admin
{
    partial class FXeTrenSan
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
            this.gvYeuCau = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYeuCau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTim = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvYeuCau)).BeginInit();
            this.SuspendLayout();
            // 
            // gvYeuCau
            // 
            this.gvYeuCau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvYeuCau.Location = new System.Drawing.Point(12, 149);
            this.gvYeuCau.Name = "gvYeuCau";
            this.gvYeuCau.RowHeadersWidth = 62;
            this.gvYeuCau.RowTemplate.Height = 28;
            this.gvYeuCau.Size = new System.Drawing.Size(975, 344);
            this.gvYeuCau.TabIndex = 0;
            this.gvYeuCau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvYeuCau_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bạn muốn dùng xe thế nào ?";
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYeuCau.DefaultText = "";
            this.txtYeuCau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYeuCau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYeuCau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYeuCau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYeuCau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYeuCau.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeuCau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYeuCau.Location = new System.Drawing.Point(43, 69);
            this.txtYeuCau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.PasswordChar = '\0';
            this.txtYeuCau.PlaceholderText = "";
            this.txtYeuCau.SelectedText = "";
            this.txtYeuCau.Size = new System.Drawing.Size(640, 60);
            this.txtYeuCau.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTim.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(779, 69);
            this.btnTim.Name = "btnTim";
            this.btnTim.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTim.Size = new System.Drawing.Size(114, 60);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // FXeTrenSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(999, 505);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtYeuCau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvYeuCau);
            this.Name = "FXeTrenSan";
            this.Text = "FXeTrenSan";
            this.Load += new System.EventHandler(this.FXeTrenSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvYeuCau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvYeuCau;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtYeuCau;
        private Guna.UI2.WinForms.Guna2CircleButton btnTim;
    }
}