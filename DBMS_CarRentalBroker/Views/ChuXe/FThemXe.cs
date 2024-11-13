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
    public partial class FThemXe : Form
    {
        int maND = 2;
        String connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";

        public FThemXe()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txtTen.Text;
                string bienSoXe = txtBienSoXe.Text;
                bool laXeSoSan = chkLaXeSoSan.Checked;
                bool laXeDien = chkLaXeDien.Checked;
                int namSanXuat = int.Parse(txtNamSanXuat.Text);
                int soGhe = int.Parse(txtSoGhe.Text);
                string mau = txtMau.Text;
                int phanKhoi = int.Parse(txtPhanKhoi.Text);
                string thuongHieu = txtThuongHieu.Text;

                // Chỉ cần truyền các tham số cần thiết cho p_ThemXe
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("p_ThemXe", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Ten", ten);
                    command.Parameters.AddWithValue("@BienSoXe", bienSoXe);
                    command.Parameters.AddWithValue("@LaXeSoSan", laXeSoSan);
                    command.Parameters.AddWithValue("@LaXeDien", laXeDien);
                    command.Parameters.AddWithValue("@NamSanXuat", namSanXuat);
                    command.Parameters.AddWithValue("@SoGhe", soGhe);
                    command.Parameters.AddWithValue("@Mau", mau);
                    command.Parameters.AddWithValue("@PhanKhoi", phanKhoi);
                    command.Parameters.AddWithValue("@ThuongHieu", thuongHieu);
                    command.Parameters.AddWithValue("@TrangThai", "Chờ duyệt"); // Nếu có cần thiết
                    command.Parameters.AddWithValue("@MaChuXe", maND); // Mã người dùng hiện tại

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Thêm xe thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

    }
}
