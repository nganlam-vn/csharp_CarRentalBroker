﻿using DBMS_CarRentalBroker.Common;
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

namespace DBMS_CarRentalBroker.Views.ChuXe
{
    public partial class FLichSuThanhToan : Form
    {
        int maND = Global.MaND;
        String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";

        public FLichSuThanhToan()
        {
            InitializeComponent();
            LoadDataHoaDon();
        }

        private void LoadDataHoaDon()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "EXEC pro_LayHoaDonTheoNguoiDung @MaND";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaND", maND);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();

                dgvLichSuThanhToan.DataSource = dataTable;
            }
        }
        private void dgvLichSuThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
