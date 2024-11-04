using DBMS_CarRentalBroker.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.ChuXe
{
    public partial class FChiTietXe : Form
    {
        private Xe xe;
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";

        public FChiTietXe(int maXe)
        {
            InitializeComponent();
            ChiTietXe_Load(maXe);
        }

        private void ChiTietXe_Load(int maXe)
        {
            DataRow xeData = LayChiTietXe(maXe);

            if (xeData != null)
            {
                txtTen.Text = xeData["TenXe"].ToString();
                txtBienSoXe.Text = xeData["BienSoXe"].ToString();
                chkLaXeSoSan.Checked = Convert.ToBoolean(xeData["LaXeSoSan"]);
                chkLaXeDien.Checked = Convert.ToBoolean(xeData["LaXeDien"]);
                txtNamSanXuat.Text = xeData["NamSanXuat"].ToString();
                txtSoGhe.Text = xeData["SoGhe"].ToString();
                txtMau.Text = xeData["Mau"].ToString();
                txtPhanKhoi.Text = xeData["PhanKhoi"].ToString();
                txtThuongHieu.Text = xeData["ThuongHieu"].ToString();

                txtChuXe.Text = xeData["TenChuXe"].ToString();
                txtGiaTheoGio.Text = xeData["TheoGio"].ToString();
                txtGiaTheoNgay.Text = xeData["TheoNgay"].ToString();
                txtGiaTheoThang.Text = xeData["TheoThang"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin xe.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataRow LayChiTietXe(int maXe)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("p_LayChiTietXe", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaXe", maXe);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                connection.Open();
                adapter.Fill(dt);
                connection.Close();

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                return null;
            }
        }
    }
}
