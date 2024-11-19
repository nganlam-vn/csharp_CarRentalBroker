namespace DBMS_CarRentalBroker.Views.Admin
{
    partial class FHopDong
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
            this.gvHopDong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // gvHopDong
            // 
            this.gvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHopDong.Location = new System.Drawing.Point(1, 116);
            this.gvHopDong.Name = "gvHopDong";
            this.gvHopDong.RowHeadersWidth = 62;
            this.gvHopDong.RowTemplate.Height = 28;
            this.gvHopDong.Size = new System.Drawing.Size(950, 335);
            this.gvHopDong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(186, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH CÁC HỢP ĐỒNG";
            // 
            // FHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvHopDong);
            this.Name = "FHopDong";
            this.Text = "FHopDong";
            this.Load += new System.EventHandler(this.FHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvHopDong;
        private System.Windows.Forms.Label label1;
    }
}