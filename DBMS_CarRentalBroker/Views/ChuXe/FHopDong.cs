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
    public partial class FHopDong : Form
    {
        private String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";
        private int maHopDong;

        public FHopDong(int maHopDong)
        {
            InitializeComponent();
            this.maHopDong = maHopDong;
            LoadContractDetails();
        }

        private void LoadContractDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM ViewInHopDong WHERE MaHopDong = @MaHopDong", connection))
                    {
                        command.Parameters.AddWithValue("@MaHopDong", maHopDong);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtTenKhachThue.Text = reader["TenKhachThue"].ToString();
                            txtSDTKhachThue.Text = reader["SoDienThoaiKhach"].ToString();
                            txtTenChuXe.Text = reader["TenChuXe"].ToString();
                            txtSDTChuXe.Text = reader["SoDienThoaiChuXe"].ToString();
                            txtTenXe.Text = reader["TenXe"].ToString();
                            txtNgayBatDau.Text = Convert.ToDateTime(reader["NgayBatDau"]).ToString("dd/MM/yyyy");
                            txtNgayKetThuc.Text = Convert.ToDateTime(reader["NgayKetThuc"]).ToString("dd/MM/yyyy");
                            txtTongTien.Text = reader["TongTien"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No contract details found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading contract details: " + ex.Message);
                }
            }
        }
    }
}
