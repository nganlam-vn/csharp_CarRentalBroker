using DBMS_CarRentalBroker.Common;
using DBMS_CarRentalBroker.Dao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.NguoiThue
{
    public partial class FDanhSachHopDong : Form
    {
        public DBConnection dbConn = new DBConnection();
        DataTable dsHopDongConNo = new DataTable();
        string query = "";
        int userId = Global.MaND;

        public FDanhSachHopDong()
        {
            InitializeComponent();
            dtgvChuaThanhToan.AutoGenerateColumns = false;
            dtgvDaThanhToan.AutoGenerateColumns = false;
            dtgvConNo.AutoGenerateColumns = false;
            layChuaThanhToan();
            tcHopDong.SelectedIndexChanged += tbHopDong_SelectedIndexChanged;
            laySoDu(userId);
        }

        private void tbHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcHopDong.SelectedTab == tpChuaThanhToan)
            {
                layChuaThanhToan();
            }
            else if (tcHopDong.SelectedTab == tpDaThanhToan)
            {
                layDaThanhToan();
            }
            else if (tcHopDong.SelectedTab == tpConNo)
            {
                layConNo();
            }
        }
        
        public void layChuaThanhToan()
        {
            query = "SELECT * FROM v_danhSachHopDong WHERE MaND = @UserId AND DaThanhToan = 0";

            using (SqlCommand command = new SqlCommand(query, dbConn.getConnection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvChuaThanhToan.DataSource = dataTable;

                dbConn.closeConnection();
            }
        }

        public void layDaThanhToan()
        {
            query = "SELECT * FROM v_danhSachHopDong WHERE MaND = @UserId AND ConNo = 0";

            using (SqlCommand command = new SqlCommand(query, dbConn.getConnection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                dbConn.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvDaThanhToan.DataSource = dataTable;

                dbConn.closeConnection();

            }
        }

        public void layConNo()
        {
            query = "SELECT * FROM v_danhSachHopDong WHERE MaND = @UserId AND ConNo != 0";

            using (SqlCommand command = new SqlCommand(query, dbConn.getConnection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                dbConn.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvConNo.DataSource = dataTable;
                dsHopDongConNo = dataTable;

                dbConn.closeConnection();

            }
        }

        private void dtgvConNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int rowId = e.RowIndex;
            DataGridViewRow row = dtgvConNo.Rows[rowId];

            if (dsHopDongConNo.Rows.Count > rowId)
            {
                DataRow selectedRow = dsHopDongConNo.Rows[rowId];

                FThanhToan fThanhToan = new FThanhToan();

                fThanhToan.CarContractRow = selectedRow;
                fThanhToan.ShowDialog();
            }
        }

        private void laySoDu(int userId)
        {
            string query = "SELECT * FROM func_layThongTinTaiKhoan(@UserId)";
            using (SqlCommand cmd = new SqlCommand(query, dbConn.getConnection))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);

                dbConn.openConnection();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.txtSoDu.Text = reader["SoDu"].ToString();
                    }
                }

                dbConn.closeConnection();
            }
        }
    }
}

