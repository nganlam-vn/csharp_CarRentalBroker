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

namespace CarRentalBroker.Views.Admin
{
    public partial class FChiTietXe : Form
    {
        SqlConnection conn = new SqlConnection(DBMS_CarRentalBroker.Properties.Settings.Default.cnnStr);
        public FChiTietXe(int idXe)
        {
            InitializeComponent();
            LoadData(idXe);
        }

        private void LoadData(int idXe)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT * FROM Xe WHERE MaXe = {0}", idXe);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtXe = new DataTable();

                // Điền dữ liệu vào DataTable từ adapter
                adapter.Fill(dtXe);

                // Kiểm tra nếu DataTable có dữ liệu
                if (dtXe.Rows.Count > 0)
                {
                    // Lấy dữ liệu từ cột "Ten" của hàng đầu tiên
                    lbTenXe.Text = dtXe.Rows[0]["Ten"].ToString(); // "Ten" là tên cột chứa dữ liệu
                    lbThuongHieu.Text = dtXe.Rows[0]["ThuongHieu"].ToString();
                    lbNamSanXuat.Text = dtXe.Rows[0]["NamSanXuat"].ToString();
                    lbMauSac.Text = dtXe.Rows[0]["Mau"].ToString();
                    lbSoGhe.Text = dtXe.Rows[0]["SoGhe"].ToString();
                    lbPhanKhoi.Text = dtXe.Rows[0]["PhanKhoi"].ToString();
                    lbTrangThai.Text = dtXe.Rows[0]["TrangThai"].ToString();

                }
                else
                {
                    lbTenXe.Text = "Không tìm thấy xe với mã đã cho.";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
