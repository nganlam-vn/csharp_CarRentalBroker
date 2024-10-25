using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CarRentalBroker.Views.NguoiThue
{
    public partial class FThanhToan : Form
    {
        public DBConnection dbConn = new DBConnection();
        public DataRow CarContractRow { get; set; }
        public int userId = 3;
        public int maHD;

        public FThanhToan()
        {
            InitializeComponent();
            LayThongTinTaiKhoan(userId);
            DataTable adminInfo = getAdminAccountInfo();
            if (adminInfo.Rows.Count > 0) 
            {
                DataRow row = adminInfo.Rows[0]; 
                txtTenNguoiNhan.Text = row["TenTaiKhoan"].ToString();
                txtStkNguoiNhan.Text = row["SoTaiKhoan"].ToString();
            }
        }

        private void LayThongTinTaiKhoan(int userId)
        {
            using (SqlCommand cmd = new SqlCommand("proc_layThongTinTaiKhoan", dbConn.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);

                dbConn.openConnection();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.txtStkNguoiGui.Text = reader["SoTaiKhoan"].ToString();
                        this.txtTenNguoiGui.Text = reader["TenTaiKhoan"].ToString();
                        this.txtSoDu.Text = reader["SoDu"].ToString();
                    }
                }

                dbConn.closeConnection();
            }
        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            int maNguoiGui = 3;
            int maNguoiNhan = getIdAdmin();
            int maHD = int.Parse(CarContractRow["MaHopdong"].ToString());
            float soTien = float.Parse(txtSoTien.Text);
            string noiDung = txtSoTien.Text;

            try
            {
                using (SqlCommand cmd = new SqlCommand("pro_chuyenTien", dbConn.getConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("SenderID", maNguoiGui);
                    cmd.Parameters.AddWithValue("@ReceiverID", maNguoiNhan);
                    cmd.Parameters.AddWithValue("@Amount", soTien);
                    cmd.Parameters.AddWithValue("@ContractID", maHD);
                    cmd.Parameters.AddWithValue("@Content", noiDung);

                    dbConn.openConnection();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Giao dịch thành công!");
                        FDanhSachHopDong fDanhSachHopDong = new FDanhSachHopDong();
                        FTrangChu fTrangChu = new FTrangChu();
                        fTrangChu.OpenChildForm(fDanhSachHopDong);
                        fDanhSachHopDong.layChuaThanhToan();
                        fDanhSachHopDong.layDaThanhToan();
                        fDanhSachHopDong.layConNo();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Giao dịch thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giao dịch không thành công: " + ex.Message);
            }
            finally
            {
                dbConn.closeConnection();
            }
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getIdAdmin()
        {
            string query = "select nd.MaND from NguoiDung as nd where nd.MaVT = 1";
            int adminId = 0;
            try
            {
                using (SqlCommand command = new SqlCommand(query, dbConn.getConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        adminId = Convert.ToInt32(reader["MaND"]);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return adminId;
        }

        public DataTable getAdminAccountInfo()
        {
            string query = "SELECT tknh.SoTaiKhoan, tknh.TenTaiKhoan " +
                "FROM NguoiDung AS nd " +
                "JOIN TKNganHang tknh on tknh.MaTKNH = nd.MaTKNH " +
                "WHERE nd.MaVT = 1";
            SqlCommand cmd = new SqlCommand(query, dbConn.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable adminInfo = new DataTable();
            adapter.Fill(adminInfo);
            return adminInfo;
        }

    }
}
