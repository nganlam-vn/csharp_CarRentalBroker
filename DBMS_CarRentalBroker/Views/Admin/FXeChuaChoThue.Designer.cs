namespace CarRentalBroker.Views.Admin
{
    partial class FXeChuaChoThue
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
            this.gvXeChuaDuocThue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeChuaDuocThue)).BeginInit();
            this.SuspendLayout();
            // 
            // gvXeChuaDuocThue
            // 
            this.gvXeChuaDuocThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvXeChuaDuocThue.Location = new System.Drawing.Point(0, 61);
            this.gvXeChuaDuocThue.Name = "gvXeChuaDuocThue";
            this.gvXeChuaDuocThue.RowHeadersWidth = 62;
            this.gvXeChuaDuocThue.RowTemplate.Height = 28;
            this.gvXeChuaDuocThue.Size = new System.Drawing.Size(801, 391);
            this.gvXeChuaDuocThue.TabIndex = 0;
            this.gvXeChuaDuocThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvXeChuaDuocThue_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH XE CHƯA ĐƯỢC THUÊ";
            // 
            // FXeChuaDuocThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvXeChuaDuocThue);
            this.Name = "FXeChuaDuocThue";
            this.Text = "FXeChuaDuocThue";
            this.Load += new System.EventHandler(this.FXeChuaDuocThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvXeChuaDuocThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvXeChuaDuocThue;
        private System.Windows.Forms.Label label1;
    }
}