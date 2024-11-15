namespace DBMS_CarRentalBroker.Views.ChuXe
{
    partial class FLichSuThanhToan
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
            this.dgvLichSuThanhToan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuThanhToan
            // 
            this.dgvLichSuThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuThanhToan.Location = new System.Drawing.Point(12, 12);
            this.dgvLichSuThanhToan.Name = "dgvLichSuThanhToan";
            this.dgvLichSuThanhToan.RowHeadersWidth = 51;
            this.dgvLichSuThanhToan.RowTemplate.Height = 24;
            this.dgvLichSuThanhToan.Size = new System.Drawing.Size(900, 426);
            this.dgvLichSuThanhToan.TabIndex = 1;
            // 
            // FLichSuThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLichSuThanhToan);
            this.Name = "FLichSuThanhToan";
            this.Text = "FLichSuThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuThanhToan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuThanhToan;
    }
}