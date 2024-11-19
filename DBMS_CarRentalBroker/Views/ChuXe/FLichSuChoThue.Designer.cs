namespace DBMS_CarRentalBroker.Views.ChuXe
{
    partial class FLichSuChoThue
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
            this.dgvLichSuChoThue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuChoThue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSuChoThue
            // 
            this.dgvLichSuChoThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuChoThue.Location = new System.Drawing.Point(12, 12);
            this.dgvLichSuChoThue.Name = "dgvLichSuChoThue";
            this.dgvLichSuChoThue.RowHeadersWidth = 51;
            this.dgvLichSuChoThue.RowTemplate.Height = 24;
            this.dgvLichSuChoThue.Size = new System.Drawing.Size(900, 426);
            this.dgvLichSuChoThue.TabIndex = 1;
            // 
            // FLichSuChoThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLichSuChoThue);
            this.Name = "FLichSuChoThue";
            this.Text = "FLichSuChoThue";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuChoThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSuChoThue;
    }
}