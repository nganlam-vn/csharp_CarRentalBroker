﻿using CarRentalBroker;
using DBMS_CarRentalBroker.Common;
using DBMS_CarRentalBroker.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DBMS_CarRentalBroker.Views.NguoiThue
{
    public partial class FDanhSachXe : Form
    {
        public NguoiThueDAO nguoiThueDao;
        public DBConnection dbConn = new DBConnection();


        public FDanhSachXe()
        {
            InitializeComponent();
            dtgvCarList.AutoGenerateColumns = false;
            nguoiThueDao = new NguoiThueDAO();
        }

        private void FDanhSachXe_Load(object sender, EventArgs e)
        {
            RefreshCarList();
            GoiYThuongHieu();
        }

        private void dtgvCarList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int rowId = e.RowIndex;
            DataGridViewRow row = dtgvCarList.Rows[rowId];
            DataTable carDetails = nguoiThueDao.getCarDetails();

            if (carDetails.Rows.Count > rowId)
            {
                DataRow selectedRow = carDetails.Rows[rowId];

                FChiTietXe carDetailFrm = new FChiTietXe();

                carDetailFrm.CarDetailRow = selectedRow;

                carDetailFrm.LoadCarDetails();

                carDetailFrm.ShowDialog();
            }
        }

        public void RefreshCarList()
        {
            DataTable carList = nguoiThueDao.getAllCar();
            dtgvCarList.DataSource = carList;
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim();
            string query = "SELECT * FROM func_timKiemXeDaDuyet(@SearchTerm)";

            using (SqlCommand command = new SqlCommand(query, dbConn.getConnection))
            {

                command.Parameters.AddWithValue("@SearchTerm", searchText);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                dbConn.openConnection();
                adapter.Fill(dataTable);
                dbConn.closeConnection();

                dtgvCarList.DataSource = dataTable;

            }
        }

        private void GoiYThuongHieu()
        {
            if(Global.MaVT == 3)
            {
                DialogResult hopThoaiGoiY = MessageBox.Show("Bạn có muốn dùng gợi ý của chúng tôi không?", "Gợi ý thương hiệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoaiGoiY == DialogResult.Yes)
                {
                    string sqlString = String.Format("SELECT dbo.func_GoiYThuongHieu('{0}')", Global.MaND);
                    DBConnect db = new DBConnect();
                    string tuKhoa = db.thucThiScalar(sqlString).ToString();
                    txtTimKiem.Text = tuKhoa;
                }
            }
        }
    }
}