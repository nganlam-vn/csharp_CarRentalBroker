﻿namespace DBMS_CarRentalBroker.Views.Admin
{
    partial class FThongKeXuHuong
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartXeDien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gvXeDien = new System.Windows.Forms.DataGridView();
            this.gvXeSan = new System.Windows.Forms.DataGridView();
            this.chartXeSan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gvTop5 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartXeDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartXeSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // chartXeDien
            // 
            chartArea1.Name = "ChartArea1";
            this.chartXeDien.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartXeDien.Legends.Add(legend1);
            this.chartXeDien.Location = new System.Drawing.Point(35, 314);
            this.chartXeDien.Name = "chartXeDien";
            this.chartXeDien.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartXeDien.Series.Add(series1);
            this.chartXeDien.Size = new System.Drawing.Size(374, 191);
            this.chartXeDien.TabIndex = 0;
            this.chartXeDien.Text = "chart1";
            // 
            // gvXeDien
            // 
            this.gvXeDien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvXeDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvXeDien.Location = new System.Drawing.Point(35, 170);
            this.gvXeDien.Name = "gvXeDien";
            this.gvXeDien.RowHeadersWidth = 62;
            this.gvXeDien.RowTemplate.Height = 28;
            this.gvXeDien.Size = new System.Drawing.Size(374, 117);
            this.gvXeDien.TabIndex = 1;
            // 
            // gvXeSan
            // 
            this.gvXeSan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvXeSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvXeSan.Location = new System.Drawing.Point(491, 170);
            this.gvXeSan.Name = "gvXeSan";
            this.gvXeSan.RowHeadersWidth = 62;
            this.gvXeSan.RowTemplate.Height = 28;
            this.gvXeSan.Size = new System.Drawing.Size(407, 117);
            this.gvXeSan.TabIndex = 2;
            // 
            // chartXeSan
            // 
            chartArea2.Name = "ChartArea1";
            this.chartXeSan.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartXeSan.Legends.Add(legend2);
            this.chartXeSan.Location = new System.Drawing.Point(491, 314);
            this.chartXeSan.Name = "chartXeSan";
            this.chartXeSan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartXeSan.Series.Add(series2);
            this.chartXeSan.Size = new System.Drawing.Size(407, 191);
            this.chartXeSan.TabIndex = 3;
            this.chartXeSan.Text = "chart1";
            // 
            // gvTop5
            // 
            this.gvTop5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTop5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTop5.Location = new System.Drawing.Point(35, 581);
            this.gvTop5.Name = "gvTop5";
            this.gvTop5.RowHeadersWidth = 62;
            this.gvTop5.RowTemplate.Height = 28;
            this.gvTop5.Size = new System.Drawing.Size(863, 239);
            this.gvTop5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(241, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOP 5 XE ĐƯỢC THUÊ NHIỀU NHẤT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(208, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "THỐNG KÊ CÁC XU HƯỚNG XE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(307, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "XU HƯỚNG VỀ LOẠI XE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(127, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "XE ĐIỆN/ XE XĂNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(558, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "XE SỐ SÀN/ XE TỰ ĐỘNG";
            // 
            // FThongKeXuHuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 832);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvTop5);
            this.Controls.Add(this.chartXeSan);
            this.Controls.Add(this.gvXeSan);
            this.Controls.Add(this.gvXeDien);
            this.Controls.Add(this.chartXeDien);
            this.Name = "FThongKeXuHuong";
            this.Text = "FThongKeXuHuong";
            this.Load += new System.EventHandler(this.FThongKeXuHuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartXeDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXeSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartXeSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTop5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartXeDien;
        private System.Windows.Forms.DataGridView gvXeDien;
        private System.Windows.Forms.DataGridView gvXeSan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartXeSan;
        private System.Windows.Forms.DataGridView gvTop5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}