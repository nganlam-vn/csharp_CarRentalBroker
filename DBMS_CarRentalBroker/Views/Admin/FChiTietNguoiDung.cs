using CarRentalBroker;
using CarRentalBroker.Dao;
using CarRentalBroker.Models;
using DBMS_CarRentalBroker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.Admin
{
    public partial class FChiTietNguoiDung : Form
    {
        DBConnect db = new DBConnect();
        NguoiDungDao nguoiDungDao = new NguoiDungDao();
        bool isEdited;
        FQuanLyNguoiDung fQuanLyNguoiDung;
        public FChiTietNguoiDung(NguoiDung nguoiDung, TaiKhoan taiKhoan, bool isEdited, FQuanLyNguoiDung fQuanLyNguoiDung)
        {
            InitializeComponent();
            loadVaiTro();
            loadData(nguoiDung, taiKhoan);
            this.isEdited = isEdited;
            this.fQuanLyNguoiDung = fQuanLyNguoiDung;
        }

        private void loadData(NguoiDung nguoiDung, TaiKhoan taiKhoan)
        {
            tbMaNguoiDung.Text = nguoiDung.MaND.ToString();
            cbVaiTro.SelectedValue = taiKhoan.MaVT;
            tbHoTen.Text = nguoiDung.HoTen;
            dtpNgaySinh.Value = nguoiDung.NgaySinh >= DateTimePicker.MinimumDateTime ? nguoiDung.NgaySinh : DateTime.Today;
            tbCCCD.Text = nguoiDung.CCCD;
            tbEmail.Text = nguoiDung.Email;
            tbDiaChi.Text = nguoiDung.DiaChi;
            tbQuocTich.Text = nguoiDung.QuocTich;
            tbSoDienThoai.Text = nguoiDung.SoDienThoai;
            tbSoGPLX.Text = nguoiDung.SoGPLX;
            tbTenDangNhap.Text = taiKhoan.TenDangNhap;
            tbMatKhau.Text = taiKhoan.MatKhau;
        }

        private void loadVaiTro()
        {
            String sqlString = String.Format("SELECT * FROM VaiTro");
            DataTable dt = db.thucThiDataTable(sqlString);
            cbVaiTro.DataSource = dt;
            cbVaiTro.DisplayMember = "Ten";
            cbVaiTro.ValueMember = "MaVT";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NguoiDung nguoiDung = new NguoiDung();
            nguoiDung.MaVT = Convert.ToInt32(cbVaiTro.SelectedValue);
            nguoiDung.HoTen = tbHoTen.Text;
            nguoiDung.NgaySinh = dtpNgaySinh.Value;
            nguoiDung.CCCD = tbCCCD.Text;
            nguoiDung.Email = tbEmail.Text;
            nguoiDung.DiaChi = tbDiaChi.Text;
            nguoiDung.QuocTich = tbQuocTich.Text;
            nguoiDung.SoDienThoai = tbSoDienThoai.Text;
            nguoiDung.SoGPLX = tbSoGPLX.Text;

            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TenDangNhap = tbTenDangNhap.Text;
            taiKhoan.MatKhau = tbMatKhau.Text;

            if (!isEdited)
            {
                try
                {
                    nguoiDungDao.themNguoiDung(nguoiDung, taiKhoan);
                    MessageBox.Show("Thêm người dùng thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    nguoiDung.MaND = Convert.ToInt32(tbMaNguoiDung.Text);
                    nguoiDungDao.suaNguoiDung(nguoiDung, taiKhoan);
                    MessageBox.Show("Sửa người dùng thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            fQuanLyNguoiDung.loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maND = Convert.ToInt32(tbMaNguoiDung.Text);
                int maVT = Convert.ToInt32(cbVaiTro.SelectedValue);
                string tenDangNhap = tbTenDangNhap.Text;
                nguoiDungDao.xoaNguoiDung(maND, maVT, tenDangNhap);
                MessageBox.Show("Xóa người dùng thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            fQuanLyNguoiDung.loadData();
        }

        public void anMaNguoiDung()
        {
            lblMaNguoiDung.Visible = false;
            tbMaNguoiDung.Visible = false;
        }

        public void voHieuHoaCbVaiTro()
        {
            cbVaiTro.Enabled = false;
        }

        public void anBtnXoa()
        {
            btnXoa.Visible = false;
        }
    }
}
