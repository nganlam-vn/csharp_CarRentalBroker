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

namespace CarRentalBroker.Views.NguoiThue
{
    public partial class FChiTietXe : Form
    {
        public DBConnection dbConn = new DBConnection();
        public DataRow CarDetailRow { get; set; }
        public FChiTietXe()
        {
            InitializeComponent();
        }

        public void LoadCarDetails()
        {
            if (CarDetailRow != null)
            {
                txtTen.Text = CarDetailRow["TenXe"].ToString();
                txtBienSo.Text = CarDetailRow["BienSoXe"].ToString();
                txtNamSX.Text = CarDetailRow["NamSanXuat"].ToString();
                txtSoGhe.Text = CarDetailRow["SoGhe"].ToString();
                txtMau.Text = CarDetailRow["Mau"].ToString();
                txtPhanKhoi.Text = CarDetailRow["PhanKhoi"].ToString();
                txtThuongHieu.Text = CarDetailRow["ThuongHieu"].ToString();
                txtChuXe.Text = CarDetailRow["ChuXe"].ToString();
                txtTheoGio.Text = CarDetailRow["TheoGio"].ToString();
                txtTheoNgay.Text = CarDetailRow["TheoNgay"].ToString();
                txtTheoThang.Text = CarDetailRow["TheoThang"].ToString();
            }
        }

        private void btnBookCar_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpFrom.Value;
            DateTime ngayKetThuc = dtpTo.Value;

            int maND = 3;
            int maXe = Convert.ToInt32(CarDetailRow["MaXe"]);
            float donGia = 0;
            int choice = 0;

            if (rdTheoGio.Checked)
            {
                if (ngayBatDau.Hour == ngayKetThuc.Hour)
                {
                    MessageBox.Show("Khung thời gian thuê xe theo giờ không hợp lệ!");
                    return;
                }
                choice = 1;
                donGia = Convert.ToSingle(CarDetailRow["TheoGio"]);
            }
            else if (rdTheoNgay.Checked)
            {
                if (ngayBatDau.Day == ngayKetThuc.Day)
                {
                    MessageBox.Show("Khung thời gian thuê xe theo ngày không hợp lệ!");
                    return;
                }
                choice = 2;
                donGia = Convert.ToSingle(CarDetailRow["TheoNgay"]);
            }
            else if (rdTheoThang.Checked)
            {
                if (ngayBatDau.Month == ngayKetThuc.Month)
                {
                    MessageBox.Show("Khung thời gian thuê xe theo tháng không hợp lệ!");
                    return;
                }
                choice = 3;
                donGia = Convert.ToSingle(CarDetailRow["TheoThang"]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình thức thuê.");
                return;
            }

            bookRentalContract(ngayBatDau, ngayKetThuc, maND, maXe, donGia, choice);
        }

        private void bookRentalContract(DateTime ngayBatDau, DateTime ngayKetThuc, int maND, int maXe, float donGia, int choice)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("proc_themHopDong", dbConn.getConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                    cmd.Parameters.AddWithValue("@MaND", maND);
                    cmd.Parameters.AddWithValue("@MaXe", maXe);
                    cmd.Parameters.AddWithValue("@DonGia", donGia);
                    cmd.Parameters.AddWithValue("@choice", choice);

                    MessageBox.Show(string.Format("Ngày bắt đầu: {0}, Ngày kết thúc: {1}, Mã người dùng: {2}, Mã xe: {3}, Đơn giá: {4}, Lựa chọn: {5}",
                        ngayBatDau, ngayKetThuc, maND, maXe, donGia, choice));

                    dbConn.openConnection();

                    if(cmd.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("Hợp đồng đặt xe thành công!");
                        this.Hide();
                        FTrangChu  fTrangChu = new FTrangChu();
                        fTrangChu.OpenChildForm(new FDanhSachHopDong());
                    }    
                    else
                    {
                        MessageBox.Show("Hợp đồng đặt xe thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hợp đồng đặt xe không thành công: " + ex.Message);
            }
            finally
            {
                dbConn.closeConnection();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
