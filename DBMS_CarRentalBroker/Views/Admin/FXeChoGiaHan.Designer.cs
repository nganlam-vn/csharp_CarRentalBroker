namespace DBMS_CarRentalBroker.Views.Admin
{
    partial class FXeChoGiaHan
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
            this.gvXeChoGiaHan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeChoGiaHan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH XE CHỜ GIA HẠN";
            // 
            // gvXeChoGiaHan
            // 
            this.gvXeChoGiaHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvXeChoGiaHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvXeChoGiaHan.Location = new System.Drawing.Point(111, 61);
            this.gvXeChoGiaHan.Name = "gvXeChoGiaHan";
            this.gvXeChoGiaHan.RowHeadersWidth = 62;
            this.gvXeChoGiaHan.RowTemplate.Height = 28;
            this.gvXeChoGiaHan.Size = new System.Drawing.Size(801, 391);
            this.gvXeChoGiaHan.TabIndex = 2;
            // 
            // FXeChoGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvXeChoGiaHan);
            this.Name = "FXeChoGiaHan";
            this.Text = "FXeChoGiaHan";
            this.Load += new System.EventHandler(this.FXeChoGiaHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvXeChoGiaHan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvXeChoGiaHan;
    }
}