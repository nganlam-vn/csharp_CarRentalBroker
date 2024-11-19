namespace DBMS_CarRentalBroker.Views.NguoiThue
{
    partial class FChiTietXe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChiTietXe));
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBookCar = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTheoThang = new System.Windows.Forms.TextBox();
            this.txtTheoNgay = new System.Windows.Forms.TextBox();
            this.txtTheoGio = new System.Windows.Forms.TextBox();
            this.rdTheoThang = new System.Windows.Forms.RadioButton();
            this.rdTheoGio = new System.Windows.Forms.RadioButton();
            this.rdTheoNgay = new System.Windows.Forms.RadioButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtChuXe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.txtThuongHieu = new System.Windows.Forms.TextBox();
            this.txtPhanKhoi = new System.Windows.Forms.TextBox();
            this.txtSoGhe = new System.Windows.Forms.TextBox();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.txtNamSX = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.pbXe = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(900, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "X";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.lblClose);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 55);
            this.panel3.TabIndex = 221;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(806, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(26, 25);
            this.lblClose.TabIndex = 166;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 25);
            this.label5.TabIndex = 165;
            this.label5.Text = "Thông tin chi tiết xe";
            // 
            // btnBookCar
            // 
            this.btnBookCar.BackColor = System.Drawing.Color.Teal;
            this.btnBookCar.Location = new System.Drawing.Point(602, 540);
            this.btnBookCar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBookCar.Name = "btnBookCar";
            this.btnBookCar.Size = new System.Drawing.Size(118, 45);
            this.btnBookCar.TabIndex = 220;
            this.btnBookCar.Text = "Xác nhận";
            this.btnBookCar.UseVisualStyleBackColor = false;
            this.btnBookCar.Click += new System.EventHandler(this.btnBookCar_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(99, 522);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpTo.RightToLeftLayout = true;
            this.dtpTo.Size = new System.Drawing.Size(198, 27);
            this.dtpTo.TabIndex = 219;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(99, 481);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFrom.RightToLeftLayout = true;
            this.dtpFrom.Size = new System.Drawing.Size(198, 27);
            this.dtpFrom.TabIndex = 218;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 527);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 18);
            this.label13.TabIndex = 217;
            this.label13.Text = "Đến";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 487);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 18);
            this.label12.TabIndex = 216;
            this.label12.Text = "Từ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 441);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 18);
            this.label11.TabIndex = 215;
            this.label11.Text = "Khung thời gian thuê";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 392);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 214;
            this.label10.Text = "/tháng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 356);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 213;
            this.label9.Text = "/ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 212;
            this.label8.Text = "/giờ";
            // 
            // txtTheoThang
            // 
            this.txtTheoThang.Location = new System.Drawing.Point(169, 389);
            this.txtTheoThang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTheoThang.Name = "txtTheoThang";
            this.txtTheoThang.Size = new System.Drawing.Size(168, 27);
            this.txtTheoThang.TabIndex = 211;
            // 
            // txtTheoNgay
            // 
            this.txtTheoNgay.Location = new System.Drawing.Point(169, 349);
            this.txtTheoNgay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTheoNgay.Name = "txtTheoNgay";
            this.txtTheoNgay.Size = new System.Drawing.Size(168, 27);
            this.txtTheoNgay.TabIndex = 210;
            // 
            // txtTheoGio
            // 
            this.txtTheoGio.Location = new System.Drawing.Point(169, 313);
            this.txtTheoGio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTheoGio.Name = "txtTheoGio";
            this.txtTheoGio.Size = new System.Drawing.Size(168, 27);
            this.txtTheoGio.TabIndex = 209;
            // 
            // rdTheoThang
            // 
            this.rdTheoThang.AutoSize = true;
            this.rdTheoThang.Location = new System.Drawing.Point(48, 390);
            this.rdTheoThang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdTheoThang.Name = "rdTheoThang";
            this.rdTheoThang.Size = new System.Drawing.Size(119, 22);
            this.rdTheoThang.TabIndex = 208;
            this.rdTheoThang.TabStop = true;
            this.rdTheoThang.Text = "Theo tháng";
            this.rdTheoThang.UseVisualStyleBackColor = true;
            // 
            // rdTheoGio
            // 
            this.rdTheoGio.AutoSize = true;
            this.rdTheoGio.Location = new System.Drawing.Point(48, 318);
            this.rdTheoGio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdTheoGio.Name = "rdTheoGio";
            this.rdTheoGio.Size = new System.Drawing.Size(97, 22);
            this.rdTheoGio.TabIndex = 207;
            this.rdTheoGio.TabStop = true;
            this.rdTheoGio.Text = "Theo giờ";
            this.rdTheoGio.UseVisualStyleBackColor = true;
            // 
            // rdTheoNgay
            // 
            this.rdTheoNgay.AutoSize = true;
            this.rdTheoNgay.Location = new System.Drawing.Point(48, 354);
            this.rdTheoNgay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdTheoNgay.Name = "rdTheoNgay";
            this.rdTheoNgay.Size = new System.Drawing.Size(111, 22);
            this.rdTheoNgay.TabIndex = 206;
            this.rdTheoNgay.TabStop = true;
            this.rdTheoNgay.Text = "Theo ngày";
            this.rdTheoNgay.UseVisualStyleBackColor = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 29);
            this.label7.TabIndex = 205;
            this.label7.Text = "Đơn giá thuê";
            // 
            // txtChuXe
            // 
            this.txtChuXe.Location = new System.Drawing.Point(588, 216);
            this.txtChuXe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtChuXe.Name = "txtChuXe";
            this.txtChuXe.Size = new System.Drawing.Size(227, 27);
            this.txtChuXe.TabIndex = 204;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 202;
            this.label6.Text = "Màu sắc";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(163, 81);
            this.txtTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(174, 27);
            this.txtTen.TabIndex = 201;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(23, 77);
            this.lbId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(44, 18);
            this.lbId.TabIndex = 200;
            this.lbId.Text = "Tên ";
            // 
            // txtThuongHieu
            // 
            this.txtThuongHieu.Location = new System.Drawing.Point(588, 167);
            this.txtThuongHieu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtThuongHieu.Name = "txtThuongHieu";
            this.txtThuongHieu.Size = new System.Drawing.Size(227, 27);
            this.txtThuongHieu.TabIndex = 199;
            // 
            // txtPhanKhoi
            // 
            this.txtPhanKhoi.Location = new System.Drawing.Point(588, 125);
            this.txtPhanKhoi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhanKhoi.Name = "txtPhanKhoi";
            this.txtPhanKhoi.Size = new System.Drawing.Size(227, 27);
            this.txtPhanKhoi.TabIndex = 198;
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.Location = new System.Drawing.Point(163, 214);
            this.txtSoGhe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.Size = new System.Drawing.Size(174, 27);
            this.txtSoGhe.TabIndex = 193;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(471, 219);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(64, 18);
            this.lbGioiTinh.TabIndex = 197;
            this.lbGioiTinh.Text = "Chủ xe";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 188;
            this.label1.Text = "Biển số";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(468, 170);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(110, 18);
            this.lbEmail.TabIndex = 196;
            this.lbEmail.Text = "Thương hiệu";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 189;
            this.label2.Text = "Năm sản xuất";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Location = new System.Drawing.Point(468, 128);
            this.lbSdt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(88, 18);
            this.lbSdt.TabIndex = 195;
            this.lbSdt.Text = "Phân khối";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 190;
            this.label3.Text = "Số ghế";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(163, 123);
            this.txtBienSo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(174, 27);
            this.txtBienSo.TabIndex = 191;
            // 
            // txtNamSX
            // 
            this.txtNamSX.Location = new System.Drawing.Point(163, 169);
            this.txtNamSX.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(174, 27);
            this.txtNamSX.TabIndex = 192;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(588, 78);
            this.txtMau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(227, 27);
            this.txtMau.TabIndex = 202;
            // 
            // pbXe
            // 
            this.pbXe.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbXe.ErrorImage")));
            this.pbXe.ImageRotate = 0F;
            this.pbXe.Location = new System.Drawing.Point(474, 269);
            this.pbXe.Margin = new System.Windows.Forms.Padding(2);
            this.pbXe.Name = "pbXe";
            this.pbXe.Size = new System.Drawing.Size(341, 236);
            this.pbXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbXe.TabIndex = 222;
            this.pbXe.TabStop = false;
            // 
            // FChiTietXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(844, 598);
            this.Controls.Add(this.pbXe);
            this.Controls.Add(this.txtMau);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnBookCar);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTheoThang);
            this.Controls.Add(this.txtTheoNgay);
            this.Controls.Add(this.txtTheoGio);
            this.Controls.Add(this.rdTheoThang);
            this.Controls.Add(this.rdTheoGio);
            this.Controls.Add(this.rdTheoNgay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChuXe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtThuongHieu);
            this.Controls.Add(this.txtPhanKhoi);
            this.Controls.Add(this.txtSoGhe);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.txtNamSX);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FChiTietXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCarDetail";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBookCar;
        public System.Windows.Forms.DateTimePicker dtpTo;
        public System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtTheoThang;
        public System.Windows.Forms.TextBox txtTheoNgay;
        public System.Windows.Forms.TextBox txtTheoGio;
        private System.Windows.Forms.RadioButton rdTheoThang;
        private System.Windows.Forms.RadioButton rdTheoGio;
        private System.Windows.Forms.RadioButton rdTheoNgay;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtChuXe;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbId;
        public System.Windows.Forms.TextBox txtThuongHieu;
        public System.Windows.Forms.TextBox txtPhanKhoi;
        public System.Windows.Forms.TextBox txtSoGhe;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtBienSo;
        public System.Windows.Forms.TextBox txtNamSX;
        public System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.Label lblClose;
        private Guna.UI2.WinForms.Guna2PictureBox pbXe;
    }
}