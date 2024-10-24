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
    public partial class FDanhSachDangKyXe : Form
    {
        private int selectedXeId = -1; // Khai báo biến để lưu trữ ID xe được chọn
        SqlConnection conn = new SqlConnection(DBMS_CarRentalBroker.Properties.Settings.Default.cnnStr);
        public FDanhSachDangKyXe()
        {
            InitializeComponent();
            
        }

        private void DanhSachXe_Load(object sender, EventArgs e)
        {
            LoadDataChoDuyet();
            LoadDataTuChoi();
        }

        private void LoadDataTuChoi()
        {
            try
            {
                conn.Open();
                string TrangThai = "Từ chối";
                string sqlStr = string.Format("SELECT MaXe, Ten, ThuongHieu, Mau FROM Xe WHERE TrangThai = N'{0}'", TrangThai);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtDanhSachXe = new DataTable();
                adapter.Fill(dtDanhSachXe);
                gvTuChoi.DataSource = dtDanhSachXe; 
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

        private void LoadDataChoDuyet()
        {
            try
            {
                conn.Open();
                string TrangThai = "Chờ duyệt";
                string sqlStr = string.Format("SELECT MaXe, Ten, ThuongHieu, Mau FROM Xe WHERE TrangThai = N'{0}'", TrangThai);

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtDanhSachXe = new DataTable();
                adapter.Fill(dtDanhSachXe);
                gvChoDuyet.DataSource = dtDanhSachXe; /// gvHsinh = name cua data gridview
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

        private void gvChoDuyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng nào được chọn (tránh trường hợp nhấp vào tiêu đề cột)
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Lấy hàng hiện tại
                    DataGridViewRow selectedRow = gvChoDuyet.Rows[e.RowIndex];
                    int idXe = int.Parse(selectedRow.Cells[0].Value.ToString()); //Cell[0] là cột mã xe
                    selectedXeId = int.Parse(selectedRow.Cells[0].Value.ToString()); //Cell[0] là cột mã xe
                    FChiTietXe fChiTietXe = new FChiTietXe(idXe);
                    fChiTietXe.Show();


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
            finally
            {
                conn.Close();
            }
            
           
        }

        private void gvTuChoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng nào được chọn (tránh trường hợp nhấp vào tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // Lấy hàng hiện tại
                DataGridViewRow selectedRow = gvTuChoi.Rows[e.RowIndex];
                int idXe = int.Parse(selectedRow.Cells[0].Value.ToString()); //Cell[0] là cột mã xe
                FChiTietXe fChiTietXe = new FChiTietXe(idXe);
                fChiTietXe.Show();
            }

        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedXeId != -1)
                {
                    conn.Open();
                    string sqlStr = string.Format("UPDATE Xe SET TrangThai = N'Chưa thuê' WHERE MaXe = {0}", selectedXeId);
                   
                    // Sử dụng SqlCommand để thực hiện truy vấn
                    using (SqlCommand command = new SqlCommand(sqlStr, conn))
                    {
                        // Thực hiện truy vấn
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra nếu có ít nhất một dòng được cập nhật
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật trạng thái thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy xe với ID đã chọn.");
                        }
                    }
                    LoadDataChoDuyet();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một xe để cập nhật.");
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

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedXeId != -1)
                {
                    conn.Open();
                    string sqlStr = string.Format("UPDATE Xe SET TrangThai = N'Từ chối' WHERE MaXe = {0}", selectedXeId);

                    // Sử dụng SqlCommand để thực hiện truy vấn
                    using (SqlCommand command = new SqlCommand(sqlStr, conn))
                    {
                        // Thực hiện truy vấn
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra nếu có ít nhất một dòng được cập nhật
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật trạng thái thành công!");
                            
                            LoadDataTuChoi();
                            gvTuChoi.Refresh();

                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy xe với ID đã chọn.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một xe để cập nhật.");
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
