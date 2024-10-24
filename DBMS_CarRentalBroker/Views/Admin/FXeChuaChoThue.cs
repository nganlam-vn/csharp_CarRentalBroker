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
    public partial class FXeChuaChoThue : Form
    {
        public FXeChuaChoThue()
        {
            InitializeComponent();
        }

        private void FXeChuaDuocThue_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBMS_CarRentalBroker.Properties.Settings.Default.cnnStr);
            try
            {
                conn.Open();
                string TrangThai = "Chưa thuê";
                string sqlStr = string.Format("SELECT MaXe, Ten, ThuongHieu, Mau FROM Xe WHERE TrangThai = N'{0}'", TrangThai);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtDanhSachXe = new DataTable();
                adapter.Fill(dtDanhSachXe);
                gvXeChuaDuocThue.DataSource = dtDanhSachXe; /// gvHsinh = name cua data gridview
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

        private void gvXeChuaDuocThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng nào được chọn (tránh trường hợp nhấp vào tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow selectedRow = gvXeChuaDuocThue.Rows[e.RowIndex];
                int idXe = int.Parse(selectedRow.Cells[0].Value.ToString()); //Cell[0] là cột mã xe
                FChiTietXe fChiTietXe = new FChiTietXe(idXe);
                fChiTietXe.Show();
            }


        }
    }
}
