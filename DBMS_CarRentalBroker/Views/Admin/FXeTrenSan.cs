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
    public partial class FXeTrenSan : Form
    {
        DBConnection1 db = new DBConnection1();
        public FXeTrenSan()
        {
            InitializeComponent();
        }

        private void FXeTrenSan_Load(object sender, EventArgs e)
        {
            GetCarsByKeyword("");

        }

        private void GetCarsByKeyword(string inputText)
        {

            SqlConnection conn = db.layKetNoi();
            conn.Open();
            try
            {
                // Câu lệnh SQL gọi hàm
                string query = "SELECT * FROM dbo.f_TraKQTheoKeyword(@InputText)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@InputText", txtYeuCau.Text);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtXe = new DataTable();
                    adapter.Fill(dtXe);
                    gvYeuCau.DataSource = dtXe;
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            GetCarsByKeyword("");
        }

        private void gvYeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng nào được chọn (tránh trường hợp nhấp vào tiêu đề cột)
            try
            {

                if (e.RowIndex >= 0)
                {
                    // Lấy hàng hiện tại
                    DataGridViewRow selectedRow = gvYeuCau.Rows[e.RowIndex];
                    int idXe = int.Parse(selectedRow.Cells[0].Value.ToString()); //Cell[0] là cột mã xe

                    FChiTietXe fChiTietXe = new FChiTietXe(idXe);
                    fChiTietXe.Show();
                    //MessageBox.Show("Xe đã chọn: " + idXe);


                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một xe để xem chi tiết!");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }
    }
}
