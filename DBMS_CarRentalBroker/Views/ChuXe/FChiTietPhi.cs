using DBMS_CarRentalBroker.Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DBMS_CarRentalBroker.Views.ChuXe
{
    public partial class FChiTietPhi : Form
    {
        public event Action ThanhToanThanhCong;
        private int maPhi;
        int maND = Global.MaND;
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";

        public FChiTietPhi(int maPhi)
        {
            InitializeComponent();
            this.maPhi = maPhi;
            LoadChiTietPhi();
        }

        private void LoadChiTietPhi()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_LayChiTietPhi", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaPhi", maPhi);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtMaPhi.Text = reader["MaPhi"].ToString();
                    txtSoTien.Text = reader["SoTien"].ToString();
                    txtNgayBatDau.Text = Convert.ToDateTime(reader["NgayBatDau"]).ToString("dd/MM/yyyy");
                    txtNgayKetThuc.Text = Convert.ToDateTime(reader["NgayKetThuc"]).ToString("dd/MM/yyyy");

                    txtMaXe.Text = reader["MaXe"].ToString();
                    txtTenXe.Text = reader["TenXe"].ToString();
                    txtBienSoXe.Text = reader["BienSoXe"].ToString();
                    txtThuongHieu.Text = reader["ThuongHieu"].ToString();

                    int soTien = 0;
                    if (int.TryParse(txtSoTien.Text, out soTien))
                    {
                        int tongTien = (int)(soTien * 0.05);
                        lblTongTien.Text = tongTien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập một số hợp lệ.");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin phí.");
                }
                connection.Close();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Gọi stored procedure `sp_ThanhToanPhi` để kiểm tra xem có đủ số dư và thực hiện thanh toán
                    SqlCommand thanhToanCommand = new SqlCommand("p_ThanhToanPhi", connection);
                    thanhToanCommand.CommandType = CommandType.StoredProcedure;
                    thanhToanCommand.Parameters.AddWithValue("@MaND", maND);
                    thanhToanCommand.Parameters.AddWithValue("@MaPhi", maPhi);

                    // Tham số đầu ra để nhận kết quả
                    SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    thanhToanCommand.Parameters.Add(resultParam);

                    // Thực hiện stored procedure
                    thanhToanCommand.ExecuteNonQuery();

                    // Lấy kết quả từ tham số đầu ra
                    bool thanhToanThanhCong = Convert.ToBoolean(resultParam.Value);
                    if (thanhToanThanhCong) // Nếu kết quả là true, nghĩa là thanh toán thành công
                    {
                        MessageBox.Show("Thanh toán thành công!");
                        ThanhToanThanhCong?.Invoke();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Số dư không đủ để thanh toán.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện thanh toán: " + ex.Message);
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
    }
}
