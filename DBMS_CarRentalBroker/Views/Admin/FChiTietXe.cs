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

namespace DBMS_CarRentalBroker.Views.Admin
{
    public partial class FChiTietXe : Form
    {
        DBConnection1 db = new DBConnection1();
        public FChiTietXe(int idXe)
        {
            InitializeComponent();
        }

        private void FChiTietXe_Load(int idXe)
        {
            SqlConnection conn = db.layKetNoi();
            conn.Open();
            try
            {
                string sqlStr = string.Format("SELECT * FROM Xe WHERE MaXe = {0}", idXe);

                DataTable dtXe = new DataTable();
                dtXe = db.thucThiDataTable(sqlStr);
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        
        }
    }
}
