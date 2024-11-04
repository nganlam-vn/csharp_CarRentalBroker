using DBMS_CarRentalBroker.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.ChuXe
{
    public partial class FChinhSuaXe : Form
    {
        private Xe xe;
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";

        public FChinhSuaXe(int maXe)
        {
            InitializeComponent();
            LoadXeDetails(maXe);
            LoadGiaThueDetails(maXe);
        }

        private void LoadXeDetails(int maXe)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_LayChiTietXe", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaXe", maXe);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    xe = new Xe
                    {
                        MaXe = maXe,
                        Ten = reader["TenXe"].ToString(),
                        BienSoXe = reader["BienSoXe"].ToString(),
                        LaXeSoSan = Convert.ToBoolean(reader["LaXeSoSan"]),
                        LaXeDien = Convert.ToBoolean(reader["LaXeDien"]),
                        NamSanXuat = Convert.ToInt32(reader["NamSanXuat"]),
                        SoGhe = Convert.ToInt32(reader["SoGhe"]),
                        Mau = reader["Mau"].ToString(),
                        PhanKhoi = Convert.ToInt32(reader["PhanKhoi"]),
                        ThuongHieu = reader["ThuongHieu"].ToString(),
                        TrangThai = reader["TrangThai"].ToString()
                    };
                    txtTen.Text = xe.Ten;
                    txtBienSoXe.Text = xe.BienSoXe;
                    chkLaXeSoSan.Checked = xe.LaXeSoSan;
                    chkLaXeDien.Checked = xe.LaXeDien;
                    txtNamSanXuat.Text = xe.NamSanXuat.ToString();
                    txtSoGhe.Text = xe.SoGhe.ToString();
                    txtMau.Text = xe.Mau;
                    txtPhanKhoi.Text = xe.PhanKhoi.ToString();
                    txtThuongHieu.Text = xe.ThuongHieu;

                    btnSua.Enabled = xe.TrangThai == "Chưa duyệt";
                    btnXoa.Enabled = xe.TrangThai != "Đã Thuê";
                }
                connection.Close();
            }
        }

        private void LoadGiaThueDetails(int maXe)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_LayChiTietGiaThue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaXe", maXe);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtGiaTheoGio.Text = reader["TheoGio"].ToString();
                    txtGiaTheoNgay.Text = reader["TheoNgay"].ToString();
                    txtGiaTheoThang.Text = reader["TheoThang"].ToString();
                }
                connection.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa xe này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                XoaXe(xe.MaXe);
                MessageBox.Show("Xe đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void XoaXe(int maXe)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_XoaXe", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaXe", maXe);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_XoaGiaThue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaXe", maXe);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (xe.TrangThai != "Chưa duyệt")
            {
                MessageBox.Show("Chỉ có thể chỉnh sửa thông tin xe khi trạng thái là 'Chưa duyệt'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                xe.Ten = txtTen.Text;
                xe.BienSoXe = txtBienSoXe.Text;
                xe.LaXeSoSan = chkLaXeSoSan.Checked;
                xe.LaXeDien = chkLaXeDien.Checked;
                xe.NamSanXuat = Convert.ToInt32(txtNamSanXuat.Text);
                xe.SoGhe = Convert.ToInt32(txtSoGhe.Text);
                xe.Mau = txtMau.Text;
                xe.PhanKhoi = Convert.ToInt32(txtPhanKhoi.Text);
                xe.ThuongHieu = txtThuongHieu.Text;

                SuaXe(xe);

                decimal giaTheoGio = Convert.ToDecimal(txtGiaTheoGio.Text);
                decimal giaTheoNgay = Convert.ToDecimal(txtGiaTheoNgay.Text);
                decimal giaTheoThang = Convert.ToDecimal(txtGiaTheoThang.Text);

                SuaGiaThue(xe.MaXe, giaTheoGio, giaTheoNgay, giaTheoThang);

                MessageBox.Show("Thông tin xe và giá thuê đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuaXe(Xe xe)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_SuaXe", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaXe", xe.MaXe);
                command.Parameters.AddWithValue("@Ten", xe.Ten);
                command.Parameters.AddWithValue("@BienSoXe", xe.BienSoXe);
                command.Parameters.AddWithValue("@LaXeSoSan", xe.LaXeSoSan);
                command.Parameters.AddWithValue("@LaXeDien", xe.LaXeDien);
                command.Parameters.AddWithValue("@NamSanXuat", xe.NamSanXuat);
                command.Parameters.AddWithValue("@SoGhe", xe.SoGhe);
                command.Parameters.AddWithValue("@Mau", xe.Mau);
                command.Parameters.AddWithValue("@PhanKhoi", xe.PhanKhoi);
                command.Parameters.AddWithValue("@ThuongHieu", xe.ThuongHieu);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void SuaGiaThue(int maXe, decimal giaTheoGio, decimal giaTheoNgay, decimal giaTheoThang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_SuaGiaThue", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaXe", maXe);
                command.Parameters.AddWithValue("@TheoGio", giaTheoGio);
                command.Parameters.AddWithValue("@TheoNgay", giaTheoNgay);
                command.Parameters.AddWithValue("@TheoThang", giaTheoThang);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


    }
}
