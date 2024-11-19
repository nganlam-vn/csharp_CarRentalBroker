using DBMS_CarRentalBroker.Common;
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
    public partial class FTrangThaiDangKy : Form
    {
        int maND = Global.MaND;
        String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";

        public FTrangThaiDangKy()
        {
            InitializeComponent();
            LoadDataKhoanThanhToan();
        }
        private void LoadDataKhoanThanhToan()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("p_KhoanThanhToan", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaChuXe", maND);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    adapter.Fill(dataTable);

                    dgvTrangThaiDangKy.DataSource = dataTable;
                    dgvTrangThaiDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (!dgvTrangThaiDangKy.Columns.Contains("ThanhToanButton"))
                    {
                        DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                        btnColumn.Name = "ThanhToanButton";
                        btnColumn.HeaderText = "Thanh Toán";
                        btnColumn.Text = "Thanh Toán";
                        btnColumn.UseColumnTextForButtonValue = true;
                        dgvTrangThaiDangKy.Columns.Add(btnColumn);
                    }

                    dgvTrangThaiDangKy.CellClick += dgvTrangThaiDangKy_CellClick;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void dgvTrangThaiDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTrangThaiDangKy.Columns["ThanhToanButton"].Index && e.RowIndex >= 0)
            {
                string trangThai = dgvTrangThaiDangKy.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                int hoatDong = Convert.ToInt32(dgvTrangThaiDangKy.Rows[e.RowIndex].Cells["HoatDong"].Value);

                if (trangThai == "Chưa thuê" && hoatDong == 0)
                {
                    int maPhi = Convert.ToInt32(dgvTrangThaiDangKy.Rows[e.RowIndex].Cells["MaPhi"].Value);

                    FChiTietPhi thanhToanForm = new FChiTietPhi(maPhi);
                    thanhToanForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thanh toán chỉ khả dụng khi xe đã được duyệt nhưng chưa được hoạt động.");
                }
            }
        }
    }
}
