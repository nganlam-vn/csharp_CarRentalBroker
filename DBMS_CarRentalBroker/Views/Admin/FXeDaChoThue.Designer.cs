namespace DBMS_CarRentalBroker.Views.Admin
{
    partial class FXeDaChoThue
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
            this.gvXeDaThue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeDaThue)).BeginInit();
            this.SuspendLayout();
            // 
            // gvXeDaThue
            // 
            this.gvXeDaThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvXeDaThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvXeDaThue.Location = new System.Drawing.Point(2, 76);
            this.gvXeDaThue.Name = "gvXeDaThue";
            this.gvXeDaThue.RowHeadersWidth = 62;
            this.gvXeDaThue.RowTemplate.Height = 28;
            this.gvXeDaThue.Size = new System.Drawing.Size(704, 391);
            this.gvXeDaThue.TabIndex = 0;
            this.gvXeDaThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvXeChuaDuocThue_CellClick);
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(-6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH XE CHƯA ĐƯỢC THUÊ";
            // 
            // FXeDaChoThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvXeDaThue);
            this.Name = "FXeDaChoThue";
            this.Text = "FXeChuaDuocThue";
            this.Load += new System.EventHandler(this.FXeDaChoThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvXeDaThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvXeDaThue;
        private System.Windows.Forms.Label label1;
    }
}