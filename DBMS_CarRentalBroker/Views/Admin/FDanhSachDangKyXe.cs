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
            using (SqlConnection conn = new SqlConnection(DBMS_CarRentalBroker.Properties.Settings.Default.cnnStr))
            {
                string query = "SELECT * FROM ViewXeDangChoDuyet";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                conn.Open();
                adapter.Fill(dataTable);
                conn.Close();

                gvChoDuyet.DataSource = dataTable;
            }
        }

        private void XeTuChoi_Load()
        {
            using (SqlConnection conn = new SqlConnection(DBMS_CarRentalBroker.Properties.Settings.Default.cnnStr))
            {
                string query = "SELECT * FROM ViewXeTuChoi";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                conn.Open();
                adapter.Fill(dataTable);
                conn.Close();

                gvTuChoi.DataSource = dataTable;
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DBMS_CarRentalBroker.Properties.Settings.Default.cnnStr))
            {
                
                try
                {
                    
                    if (selectedXeId != -1)
                    {
                        conn.Open();

                        // Sử dụng SqlCommand để thực hiện truy vấn
                        using (SqlCommand command = new SqlCommand("proc_TuChoi", conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@MaXe", selectedXeId);
                            // Add the output parameter
                            SqlParameter messageParam = new SqlParameter("@Message", SqlDbType.NVarChar, 200);
                            messageParam.Direction = ParameterDirection.Output;
                            command.Parameters.Add(messageParam);
                            //chay lenh
                            command.ExecuteNonQuery();
                            //lấy lời nhắn từ procedure trong sql server

                            string message = messageParam.Value.ToString();
                            MessageBox.Show(message);
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
                    //FChiTietXe fChiTietXe = new FChiTietXe(idXe);
                    //fChiTietXe.Show();
                    MessageBox.Show("Xe đã chọn: " + idXe);


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
                   
                    //FChiTietXe fChiTietXe = new FChiTietXe(idXe);
                    //fChiTietXe.Show();
                    MessageBox.Show("Xe đã chọn: " + idXe);


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
            using (SqlConnection conn = new SqlConnection(DBMS_CarRentalBroker.Properties.Settings.Default.cnnStr))
            {

                try
                {

                    if (selectedXeId != -1)
                    {
                        conn.Open();

                        // Sử dụng SqlCommand để thực hiện truy vấn
                        using (SqlCommand command = new SqlCommand("proc_Duyet", conn))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@MaXe", selectedXeId);
                            // Add the output parameter
                            SqlParameter messageParam = new SqlParameter("@Message", SqlDbType.NVarChar, 200);
                            messageParam.Direction = ParameterDirection.Output;
                            command.Parameters.Add(messageParam);
                            //chay lenh
                            command.ExecuteNonQuery();
                            //lấy lời nhắn từ procedure trong sql server

                            string message = messageParam.Value.ToString();
                            MessageBox.Show(message);
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
