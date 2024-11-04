using DBMS_CarRentalBroker.Models;
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
    public partial class FXeCuaToi : Form
    {
        int maND = 2;
        String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";

        public FXeCuaToi()
        {
            InitializeComponent();
            LoadDataXeCuaToi();
            AddButtonsToDataGridView();
        }

        private void LoadDataXeCuaToi()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_XeCuaToi", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaND", maND); // Thêm tham số vào command

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();

                dgvXeCuaToi.DataSource = dataTable;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemXe themXeForm = new FThemXe();
            themXeForm.Show();
        }

        private void AddButtonsToDataGridView()
        {
            DataGridViewButtonColumn buttonColumnChiTietXe = new DataGridViewButtonColumn();
            buttonColumnChiTietXe.HeaderText = ""; // Tiêu đề cột
            buttonColumnChiTietXe.Text = "Chi tiết xe"; // Văn bản hiển thị trên nút
            buttonColumnChiTietXe.UseColumnTextForButtonValue = true; // Sử dụng văn bản cột cho tất cả các nút
            buttonColumnChiTietXe.Name = "ChiTietXe"; // Đặt tên cho cột
            dgvXeCuaToi.Columns.Add(buttonColumnChiTietXe);
        }

        private void dgvXeCuaToi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvXeCuaToi.Columns["ChiTietXe"].Index)
                {
                    int maXe = Convert.ToInt32(dgvXeCuaToi.Rows[e.RowIndex].Cells["MaXe"].Value);

                    if (maXe != null)
                    {
                        FChinhSuaXe chiTietXeForm = new FChinhSuaXe(maXe);
                        chiTietXeForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin xe.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTimKiem.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_TimKiemXeTheoMaND", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Truyền tham số MaND và TenXe vào stored procedure
                command.Parameters.AddWithValue("@MaND", maND);
                command.Parameters.AddWithValue("@TenXe", searchText);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();

                dgvXeCuaToi.DataSource = dataTable;
            }
        }
    }
}
