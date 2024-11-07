namespace DBMS_CarRentalBroker.Views.Admin
{
    partial class FTop5
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
            this.dgTop5 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTop5
            // 
            this.dgTop5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTop5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgTop5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTop5.Location = new System.Drawing.Point(12, 66);
            this.dgTop5.Name = "dgTop5";
            this.dgTop5.RowHeadersWidth = 62;
            this.dgTop5.RowTemplate.Height = 28;
            this.dgTop5.Size = new System.Drawing.Size(686, 230);
            this.dgTop5.TabIndex = 0;
            this.dgTop5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTop5_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOP 5 XE ĐƯỢC THUÊ NHIỀU NHẤT";
            // 
            // FTop5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTop5);
            this.Name = "FTop5";
            this.Text = "FTop5";
            this.Load += new System.EventHandler(this.FTop5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTop5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTop5;
        private System.Windows.Forms.Label label1;
    }
}