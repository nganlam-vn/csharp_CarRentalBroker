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
    public partial class FXeGiaHan : Form
    {
        SqlConnection conn = new SqlConnection(DBMS_CarRentalBroker.Properties.Settings.Default.cnnStr);
        public FXeGiaHan()
        {
            InitializeComponent();
        }

        private void FXeDangChoThue_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string TrangThai = "Khóa";
                string sqlStr = string.Format("SELECT * FROM Xe WHERE TrangThai = N'{0}'", TrangThai);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtDanhSachXe = new DataTable();
                adapter.Fill(dtDanhSachXe);
                gvXeDangThue.DataSource = dtDanhSachXe; /// gvHsinh = name cua data gridview
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

        private void gvXeDangThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng nào được chọn (tránh trường hợp nhấp vào tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow selectedRow = gvXeDangThue.Rows[e.RowIndex];
                int idXe = int.Parse(selectedRow.Cells[0].Value.ToString()); //Cell[0] là cột mã xe
                FChiTietXe fChiTietXe = new FChiTietXe(idXe);
                fChiTietXe.Show();
            }

        }
    }
}
