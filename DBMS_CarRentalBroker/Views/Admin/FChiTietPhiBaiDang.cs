using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.Admin
{
    public partial class FChiTietPhiBaiDang : Form
    {
        DBConnection1 db = new DBConnection1();
        public FChiTietPhiBaiDang(int idXe)
        {
            InitializeComponent();
            FChiTietPhiBaiDang_Load(idXe);
        }

        private void FChiTietPhiBaiDang_Load(int idXe)
        {
            SqlConnection conn = db.layKetNoi();
            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.func_LayPhiBaiDangChiTiet(@MaXe)", conn))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@MaXe", idXe);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtXe = new DataTable();
                    adapter.Fill(dtXe);

                    if (dtXe.Rows.Count > 0)
                    {
                        lbBatDau.Text = dtXe.Rows[0]["NgayBatDau"].ToString();
                        lbKetThuc.Text = dtXe.Rows[0]["NgayKetThuc"].ToString();
                        lbChuXe.Text = dtXe.Rows[0]["HoTen"].ToString();
                        lbBienSoXe.Text = dtXe.Rows[0]["BienSoXe"].ToString();
                        lbSoTien.Text = dtXe.Rows[0]["SoTien"].ToString();
                        lbTenXe.Text = dtXe.Rows[0]["Ten"].ToString();
                        lbThuongHieu.Text = dtXe.Rows[0]["ThuongHieu"].ToString();
                        lbThanhToan.Text = dtXe.Rows[0]["DaThanhToan"].ToString();

                    }
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
