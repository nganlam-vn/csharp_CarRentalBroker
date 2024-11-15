using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace DBMS_CarRentalBroker.Views.Admin
{
    public partial class FThongKeXuHuong : Form
    {
        DBConnection1 db = new DBConnection1();
        public FThongKeXuHuong()
        {
            InitializeComponent();
           
        }

        private void FThongKeXuHuong_Load(object sender, EventArgs e)
        {
            XeSoSan_Load();
            XeSDien_Load();
            Top5_Load();

        }

        private void XeSoSan_Load()
        {
            SqlConnection conn = db.layKetNoi();
            using (conn)
            {
                string query = "SELECT * FROM f_TyLeThueXeSoSan()";
                DataTable dataTable = new DataTable();
                dataTable = db.thucThiDataTable(query);
                gvXeSan.DataSource = dataTable;
                DisplayChartXeSan(dataTable);
            }

        }

        private void XeSDien_Load()
        {
            SqlConnection conn = db.layKetNoi();
            using (conn)
            {
                string query = "SELECT * FROM f_TyLeThueXeDien()";
                DataTable dataTable = new DataTable();
                dataTable = db.thucThiDataTable(query);
                gvXeDien.DataSource = dataTable;
                DisplayChartXeDien(dataTable);
            }

        }

        private void Top5_Load()
        {
            SqlConnection conn = db.layKetNoi();
            using (conn)
            {
                string query = "SELECT * FROM dbo.func_Top5XeThueNhieuNhat()";
                DataTable dataTable = new DataTable();
                dataTable = db.thucThiDataTable(query);

                gvTop5.DataSource = dataTable;
            }

        }


        private void DisplayChartXeDien(DataTable dataTable)
        {
            // Cấu hình cho Chart Control
            chartXeDien.Series.Clear();
            Series series = new Series("Số lần thuê");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu từ DataTable vào biểu đồ
            foreach (DataRow row in dataTable.Rows)
            {
                string xValue = (Convert.ToBoolean(row["LaXeDien"]) ? "Xe điện" : "Xe xăng");
                int yValue = Convert.ToInt32(row["SoLanThue"]);
                series.Points.AddXY(xValue, yValue);

            }

            chartXeDien.Series.Add(series);
            chartXeDien.Titles.Add("Xu hướng thuê xe điện và xe xăng");
        }

        private void DisplayChartXeSan(DataTable dataTable)
        {
            // Cấu hình cho Chart Control
            chartXeSan.Series.Clear();
            Series series = new Series("Số lần thuê");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu từ DataTable vào biểu đồ
            foreach (DataRow row in dataTable.Rows)
            {
                string xValue = (Convert.ToBoolean(row["LaXeSoSan"]) ? "Xe số sàn" : "Xe tự động");
                int yValue = Convert.ToInt32(row["SoLanThue"]);
                series.Points.AddXY(xValue, yValue);

            }

            chartXeSan.Series.Add(series);
            chartXeSan.Titles.Add("Xu hướng thuê xe số sàn và xe tự động");
        }
    }
}
