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
        int maND = 2;
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

                    SqlCommand checkBalanceCommand = new SqlCommand("f_LaySoDu", connection);
                    checkBalanceCommand.CommandType = CommandType.StoredProcedure;
                    checkBalanceCommand.Parameters.AddWithValue("@MaND", maND);

                    float soDu = Convert.ToSingle(checkBalanceCommand.ExecuteScalar());
                    float soTien = float.Parse(txtSoTien.Text);

                    if (soDu >= soTien)
                    {
                        SqlCommand thanhToanCommand = new SqlCommand("p_ThanhToan", connection);
                        thanhToanCommand.CommandType = CommandType.StoredProcedure;
                        thanhToanCommand.Parameters.AddWithValue("@MaND", maND);
                        thanhToanCommand.Parameters.AddWithValue("@MaPhi", maPhi);
                        thanhToanCommand.Parameters.AddWithValue("@SoTien", soTien);
                        thanhToanCommand.Parameters.AddWithValue("@NoiDung", $"Thanh toán phí đăng cho xe {txtTenXe.Text}");

                        int result = thanhToanCommand.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Thanh toán thành công!");
                            ThanhToanThanhCong?.Invoke();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi thực hiện thanh toán.");
                        }
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
