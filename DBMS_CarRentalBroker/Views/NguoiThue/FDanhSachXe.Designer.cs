namespace DBMS_CarRentalBroker.Views.NguoiThue
{
    partial class FDanhSachXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgvCarList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tcDanhSachXe = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpTatCa = new System.Windows.Forms.TabPage();
            this.tpGoiY = new System.Windows.Forms.TabPage();
            this.dgvXeGoiY = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarList)).BeginInit();
            this.tcDanhSachXe.SuspendLayout();
            this.tpTatCa.SuspendLayout();
            this.tpGoiY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeGoiY)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(660, 60);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(176, 37);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tìm kiếm";
            // 
            // dtgvCarList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dtgvCarList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCarList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCarList.ColumnHeadersHeight = 30;
            this.dtgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenXe,
            this.SoGhe,
            this.Mau,
            this.ThuongHieu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCarList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvCarList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dtgvCarList.Location = new System.Drawing.Point(0, 0);
            this.dtgvCarList.Name = "dtgvCarList";
            this.dtgvCarList.ReadOnly = true;
            this.dtgvCarList.RowHeadersVisible = false;
            this.dtgvCarList.RowHeadersWidth = 62;
            this.dtgvCarList.Size = new System.Drawing.Size(863, 308);
            this.dtgvCarList.TabIndex = 10;
            this.dtgvCarList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.dtgvCarList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dtgvCarList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvCarList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvCarList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvCarList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvCarList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvCarList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dtgvCarList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dtgvCarList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvCarList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvCarList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvCarList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvCarList.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvCarList.ThemeStyle.ReadOnly = true;
            this.dtgvCarList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dtgvCarList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvCarList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvCarList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvCarList.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvCarList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dtgvCarList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvCarList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCarList_CellClick);
            // 
            // TenXe
            // 
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.HeaderText = "TenXe";
            this.TenXe.MinimumWidth = 8;
            this.TenXe.Name = "TenXe";
            this.TenXe.ReadOnly = true;
            // 
            // SoGhe
            // 
            this.SoGhe.DataPropertyName = "SoGhe";
            this.SoGhe.HeaderText = "SoGhe";
            this.SoGhe.MinimumWidth = 8;
            this.SoGhe.Name = "SoGhe";
            this.SoGhe.ReadOnly = true;
            // 
            // Mau
            // 
            this.Mau.DataPropertyName = "Mau";
            this.Mau.HeaderText = "Mau";
            this.Mau.MinimumWidth = 8;
            this.Mau.Name = "Mau";
            this.Mau.ReadOnly = true;
            // 
            // ThuongHieu
            // 
            this.ThuongHieu.DataPropertyName = "ThuongHieu";
            this.ThuongHieu.HeaderText = "ThuongHieu";
            this.ThuongHieu.MinimumWidth = 8;
            this.ThuongHieu.Name = "ThuongHieu";
            this.ThuongHieu.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(260, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách xe cho thuê";
            // 
            // tcDanhSachXe
            // 
            this.tcDanhSachXe.Controls.Add(this.tpTatCa);
            this.tcDanhSachXe.Controls.Add(this.tpGoiY);
            this.tcDanhSachXe.ItemSize = new System.Drawing.Size(180, 40);
            this.tcDanhSachXe.Location = new System.Drawing.Point(12, 103);
            this.tcDanhSachXe.Name = "tcDanhSachXe";
            this.tcDanhSachXe.SelectedIndex = 0;
            this.tcDanhSachXe.Size = new System.Drawing.Size(871, 352);
            this.tcDanhSachXe.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcDanhSachXe.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcDanhSachXe.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcDanhSachXe.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcDanhSachXe.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcDanhSachXe.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcDanhSachXe.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcDanhSachXe.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcDanhSachXe.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcDanhSachXe.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcDanhSachXe.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcDanhSachXe.TabButtonSelectedState.FillColor = System.Drawing.Color.Teal;
            this.tcDanhSachXe.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcDanhSachXe.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcDanhSachXe.TabButtonSelectedState.InnerColor = System.Drawing.Color.Teal;
            this.tcDanhSachXe.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcDanhSachXe.TabIndex = 0;
            this.tcDanhSachXe.TabMenuBackColor = System.Drawing.Color.White;
            this.tcDanhSachXe.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpTatCa
            // 
            this.tpTatCa.Controls.Add(this.dtgvCarList);
            this.tpTatCa.Location = new System.Drawing.Point(4, 44);
            this.tpTatCa.Name = "tpTatCa";
            this.tpTatCa.Size = new System.Drawing.Size(863, 304);
            this.tpTatCa.TabIndex = 0;
            this.tpTatCa.Text = "Tất cả";
            this.tpTatCa.UseVisualStyleBackColor = true;
            // 
            // tpGoiY
            // 
            this.tpGoiY.Controls.Add(this.dgvXeGoiY);
            this.tpGoiY.Location = new System.Drawing.Point(4, 44);
            this.tpGoiY.Name = "tpGoiY";
            this.tpGoiY.Size = new System.Drawing.Size(863, 304);
            this.tpGoiY.TabIndex = 0;
            this.tpGoiY.Text = "Gợi ý";
            this.tpGoiY.UseVisualStyleBackColor = true;
            // 
            // dgvXeGoiY
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvXeGoiY.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXeGoiY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvXeGoiY.ColumnHeadersHeight = 30;
            this.dgvXeGoiY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvXeGoiY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXeGoiY.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvXeGoiY.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvXeGoiY.Location = new System.Drawing.Point(0, 0);
            this.dgvXeGoiY.Name = "dgvXeGoiY";
            this.dgvXeGoiY.ReadOnly = true;
            this.dgvXeGoiY.RowHeadersVisible = false;
            this.dgvXeGoiY.RowHeadersWidth = 62;
            this.dgvXeGoiY.Size = new System.Drawing.Size(863, 304);
            this.dgvXeGoiY.TabIndex = 11;
            this.dgvXeGoiY.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.dgvXeGoiY.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvXeGoiY.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvXeGoiY.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvXeGoiY.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvXeGoiY.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvXeGoiY.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvXeGoiY.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvXeGoiY.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvXeGoiY.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvXeGoiY.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXeGoiY.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvXeGoiY.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvXeGoiY.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvXeGoiY.ThemeStyle.ReadOnly = true;
            this.dgvXeGoiY.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvXeGoiY.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvXeGoiY.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXeGoiY.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvXeGoiY.ThemeStyle.RowsStyle.Height = 22;
            this.dgvXeGoiY.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dgvXeGoiY.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvXeGoiY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXeGoiY_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenXe";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenXe";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SoGhe";
            this.dataGridViewTextBoxColumn2.HeaderText = "SoGhe";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mau";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mau";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ThuongHieu";
            this.dataGridViewTextBoxColumn4.HeaderText = "ThuongHieu";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FDanhSachXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(926, 467);
            this.Controls.Add(this.tcDanhSachXe);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FDanhSachXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FDanhSachXe";
            this.Load += new System.EventHandler(this.FDanhSachXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarList)).EndInit();
            this.tcDanhSachXe.ResumeLayout(false);
            this.tpTatCa.ResumeLayout(false);
            this.tpGoiY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeGoiY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvCarList;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThuongHieu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TabControl tcDanhSachXe;
        private System.Windows.Forms.TabPage tpTatCa;
        private System.Windows.Forms.TabPage tpGoiY;
        private Guna.UI2.WinForms.Guna2DataGridView dgvXeGoiY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}