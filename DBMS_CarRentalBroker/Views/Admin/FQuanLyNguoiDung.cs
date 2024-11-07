using CarRentalBroker;
using CarRentalBroker.Dao;
using CarRentalBroker.Models;
using DBMS_CarRentalBroker.Common;
using DBMS_CarRentalBroker.Models;
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
        NguoiDungDao nguoiDungDao = new NguoiDungDao();
        TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
        public FQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void FQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
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
            moChiTietNguoiDung(Convert.ToInt32(dgvNguoiDung.Rows[e.RowIndex].Cells[0].Value));
        }

        private void moChiTietNguoiDung(int maND)
        {
            pnThongTin.Controls.Clear();

            // Lấy thông tin người dùng
            NguoiDungDao nguoiDungDao = new NguoiDungDao();
            NguoiDung nguoiDung = nguoiDungDao.layNguoiDung(maND);

            // Lấy thông tin tài khoản
            TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
            TaiKhoan taiKhoan = taiKhoanDao.layTaiKhoan(maND);

            FChiTietNguoiDung fChiTietNguoiDung = new FChiTietNguoiDung(nguoiDung, taiKhoan, true, this);
            fChiTietNguoiDung.TopLevel = false;
            fChiTietNguoiDung.voHieuHoaCbVaiTro();
            pnThongTin.Controls.Add(fChiTietNguoiDung);
            fChiTietNguoiDung.Show();
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            pnThongTin.Controls.Clear();
            FChiTietNguoiDung fChiTietNguoiDung = new FChiTietNguoiDung(new NguoiDung(), new TaiKhoan(), false, this);
            fChiTietNguoiDung.TopLevel = false;
            fChiTietNguoiDung.anMaNguoiDung();
            fChiTietNguoiDung.anBtnXoa();
            pnThongTin.Controls.Add(fChiTietNguoiDung);
            fChiTietNguoiDung.Show();
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            nguoiDungDao.timKiemNguoiDung(dgvNguoiDung, tbTimKiem.Text);
        }

        private void FQuanLyNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            taiKhoanDao.dangXuat();
        }
    }
}
