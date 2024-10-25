﻿using CarRentalBroker.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentalBroker.Views.NguoiThue
{
    public partial class FDanhSachXe : Form
    {
        public NguoiThueDAO nguoiThueDao;

        public FDanhSachXe()
        {
            InitializeComponent();
            dtgvCarList.AutoGenerateColumns = false;
            nguoiThueDao = new NguoiThueDAO();
        }

        private void FDanhSachXe_Load(object sender, EventArgs e)
        {
            DataTable carList = nguoiThueDao.getAllCar();
            dtgvCarList.DataSource = carList;
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
    }
}
