using CarRentalBroker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.Admin
{
    public partial class FQuanLyNguoiDung : Form
    {
        DBConnect db = new DBConnect();
        public FQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void FQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string sqlString = String.Format("SELECT * FROM v_NguoiDung");
            dgvNguoiDung.DataSource = db.thucThiDataTable(sqlString);
            dgvNguoiDung.Columns["MaND"].HeaderText = "Mã người dùng";
            dgvNguoiDung.Columns["Ten"].HeaderText = "Vai trò";
            dgvNguoiDung.Columns["HoTen"].HeaderText = "Họ tên";
            dgvNguoiDung.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dgvNguoiDung.Columns["MatKhau"].HeaderText = "Mật khẩu";
        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
