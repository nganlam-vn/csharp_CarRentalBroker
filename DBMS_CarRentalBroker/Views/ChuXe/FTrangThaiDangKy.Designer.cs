namespace DBMS_CarRentalBroker.Views.ChuXe
{
    partial class FTrangThaiDangKy
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
            this.dgvTrangThaiDangKy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThaiDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrangThaiDangKy
            // 
            this.dgvTrangThaiDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrangThaiDangKy.Location = new System.Drawing.Point(12, 12);
            this.dgvTrangThaiDangKy.Name = "dgvTrangThaiDangKy";
            this.dgvTrangThaiDangKy.RowHeadersWidth = 51;
            this.dgvTrangThaiDangKy.RowTemplate.Height = 24;
            this.dgvTrangThaiDangKy.Size = new System.Drawing.Size(776, 426);
            this.dgvTrangThaiDangKy.TabIndex = 1;
            // 
            // FTrangThaiDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTrangThaiDangKy);
            this.Name = "FTrangThaiDangKy";
            this.Text = "FTrangThaiDangKy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrangThaiDangKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrangThaiDangKy;
    }
}