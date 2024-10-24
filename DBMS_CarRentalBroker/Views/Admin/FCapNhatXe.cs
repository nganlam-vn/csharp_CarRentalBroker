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
    public partial class FCapNhatXe : Form
    {
        SqlConnection conn = new SqlConnection(DBMS_CarRentalBroker.Properties.Settings.Default.cnnStr);
        public FCapNhatXe()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr =
                    string.Format("UPDATE Xe SET " + " Ten = '{0}'," + " BienSoXe = '{1}', " + " LaXeSoSan = '{2}', " + " LaXeDien = '{3}'," + " NamSanXuat = '{4}'," + " SoGhe= '{5}', " + " Mau= '{6}'," + " PhanKhoi = '{7}', " + " ThuongHieu= '{8}', " + " TrangThai= '{9}'," + " MaChuXe = '{10}'  WHERE Ma = '{11}'",
                    tbTenXe.Text,
                    tbBienSoXe.Text,
                    cbSoSan.Checked ? 1 : 0,  // Chuyển thành giá trị 1 nếu Checked, ngược lại là 0
                    cbXeDien.Checked ? 1 : 0,
                    tbNamSanXuat.Text,
                    tbSoGhe.Text,
                    tbMauSac,
                    tbPhanKhoi.Text,
                    tbThuongHieu.Text,
                    cbbTrangThai.SelectedItem.ToString(),
                    int.Parse(tbMaChuXe.Text),
                    int.Parse(tbMaXe.Text)
                    );
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thay đổi thông tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to add" + ex);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
