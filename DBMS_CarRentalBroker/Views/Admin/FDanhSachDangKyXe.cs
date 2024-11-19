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
using TheArtOfDevHtmlRenderer.Adapters;

namespace DBMS_CarRentalBroker.Views.Admin
{
    public partial class FDanhSachDangKyXe : Form
    {
        DBConnection1 db = new DBConnection1();
        public FDanhSachDangKyXe()
        {
            InitializeComponent();
        }
        private int selectedXeId = -1;

        private void FDanhSachDangKyXe_Load(object sender, EventArgs e)
        {
            XeChoDuyet_Load();
            XeTuChoi_Load();
           
        }

        private void XeChoDuyet_Load() {
            SqlConnection conn = db.layKetNoi();
            using (conn)
            {
                string query = "SELECT * FROM v_XeDangChoDuyet"; 
                gvChoDuyet.DataSource = db.thucThiDataTable(query);
            }
        }

        private void XeTuChoi_Load()
        {

            SqlConnection conn = db.layKetNoi();
            using (conn) { 
                string query = "SELECT * FROM v_XeTuChoi";
                gvTuChoi.DataSource = db.thucThiDataTable(query);
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = db.layKetNoi();
           
            using (conn)
            {
                conn.Open();
                
                try
                {
                    
                    if (selectedXeId != -1)
                    {
                        // Sử dụng SqlCommand để thực hiện truy vấn
                        using (SqlCommand command = new SqlCommand("proc_TuChoi", conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@MaXe", selectedXeId);
                            command.ExecuteNonQuery(); //executeNonQuery thực hiện câu lệnh sql như insert, update, delete
                            MessageBox.Show("Xe đã được từ chối.");
                            XeChoDuyet_Load();
                            XeTuChoi_Load();
                           
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

        private void gvTuChoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem dòng nào được chọn (tránh trường hợp nhấp vào tiêu đề cột)
            try
            {
                
                if (e.RowIndex >= 0)
                {
                    // Lấy hàng hiện tại
                    DataGridViewRow selectedRow = gvTuChoi.Rows[e.RowIndex];
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

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = db.layKetNoi();

            using (conn)
            {
                conn.Open();

                try
                {

                    if (selectedXeId != -1)
                    {
                        // Sử dụng SqlCommand để thực hiện truy vấn
                        using (SqlCommand command = new SqlCommand("proc_Duyet", conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@MaXe", selectedXeId);
                            command.ExecuteNonQuery(); //executeNonQuery thực hiện câu lệnh sql như insert, update, delete
                            MessageBox.Show("Xe đã được duyệt và đang chờ thanh toán");
                            XeChoDuyet_Load();
                            XeTuChoi_Load();

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
}
