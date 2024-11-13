using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            FChiTietXe_Load(idXe);
        }

        private void FChiTietXe_Load(int idXe)
        {
            SqlConnection conn = db.layKetNoi();
            conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand("pro_LayChiTietXe", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaXe", idXe);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtXe = new DataTable();
                    adapter.Fill(dtXe);
                    
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
                        lbSoSan.Text = dtXe.Rows[0]["LaXeSoSan"].ToString();
                        lbXeDien.Text = dtXe.Rows[0]["LaXeDien"].ToString();
                        lbThang.Text = dtXe.Rows[0]["TheoThang"].ToString();
                        lbNgay.Text = dtXe.Rows[0]["TheoNgay"].ToString();
                        lbGio.Text = dtXe.Rows[0]["TheoGio"].ToString();
                        string projectPath = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
                        string imagePath = Path.Combine(projectPath, "imgs", dtXe.Rows[0]["HinhAnh"].ToString());

                        // In đường dẫn ra để kiểm tra
                        Console.WriteLine("Image Path: " + imagePath);

                        if (File.Exists(imagePath))
                        {
                            pbXe.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            MessageBox.Show("Hình ảnh không tồn tại trong thư mục imgs. Đường dẫn: " + imagePath);
                        }


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
