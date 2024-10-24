namespace CarRentalBroker.Views.Admin
{
    partial class FXeGiaHan
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
            this.gvXeDangThue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeDangThue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(83, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH XE CHỜ GIA HẠN";
            // 
            // gvXeDangThue
            // 
            this.gvXeDangThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvXeDangThue.Location = new System.Drawing.Point(0, 56);
            this.gvXeDangThue.Name = "gvXeDangThue";
            this.gvXeDangThue.RowHeadersWidth = 62;
            this.gvXeDangThue.RowTemplate.Height = 28;
            this.gvXeDangThue.Size = new System.Drawing.Size(801, 391);
            this.gvXeDangThue.TabIndex = 2;
            this.gvXeDangThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvXeDangThue_CellClick);
            // 
            // FXeGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvXeDangThue);
            this.Name = "FXeGiaHan";
            this.Text = "FXeDangChoThue";
            this.Load += new System.EventHandler(this.FXeDangChoThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvXeDangThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvXeDangThue;
    }
}