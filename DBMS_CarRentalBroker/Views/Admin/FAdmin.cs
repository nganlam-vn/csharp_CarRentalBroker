using CarRentalBroker.Dao;
using DBMS_CarRentalBroker.Views.NguoiThue;
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
    public partial class FAdmin : Form
    {
        private Form currentFormchild;
        TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
        public FAdmin()
        {
            InitializeComponent();
            OpenChildForm(new FXeTrenSan());
        }

        private void OpenChildForm(Form childForm)
        {

            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
            currentFormchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.AutoScroll = true;
            childForm.Dock = DockStyle.Fill;
            pnContent.Controls.Add(childForm);
            pnContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnXeTrenSan_Click(object sender, EventArgs e)
        {
            FXeTrenSan fXeTrenSan = new FXeTrenSan();
            OpenChildForm(fXeTrenSan);

        }

        private void btnDaDuocThue_Click(object sender, EventArgs e)
        {
            FXeDaChoThue fXeDaChoThue = new FXeDaChoThue();
            OpenChildForm(fXeDaChoThue);

        }
        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            FXeChoGiaHan fXeChoGiaHan = new FXeChoGiaHan();
            OpenChildForm(fXeChoGiaHan);
        }

        private void btnBestSeller_Click(object sender, EventArgs e)
        {
            FThongKeXuHuong fThongKeXuHuong = new FThongKeXuHuong();
            OpenChildForm(fThongKeXuHuong);
        }

        private void btnKhoanThanhToan_Click(object sender, EventArgs e)
        {
            FCacKhoanThanhToan fCacKhoanThanhToan = new FCacKhoanThanhToan();
            OpenChildForm(fCacKhoanThanhToan);

        }

        private void btnDangKiXe_Click(object sender, EventArgs e)
        {
            FDanhSachDangKyXe fDanhSachDangKyXe = new FDanhSachDangKyXe();
            OpenChildForm(fDanhSachDangKyXe);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           FXeChoThanhToan fXeChoThanhToan = new FXeChoThanhToan();
            OpenChildForm(fXeChoThanhToan); 
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FQuanLyNguoiDung fQuanLyNguoiDung = new FQuanLyNguoiDung();
            OpenChildForm(fQuanLyNguoiDung);
        }

        private void btnDSHopDong_Click(object sender, EventArgs e)
        {
            FHopDong fHopDong = new FHopDong();
            OpenChildForm(fHopDong);

        }

        private void FAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            taiKhoanDao.dangXuat();
        }
        private void btnLKNH_Click(object sender, EventArgs e)
        {
            FLienKetTKNganHang fLienKetTKNganHang = new FLienKetTKNganHang();
            OpenChildForm(fLienKetTKNganHang);

        }
    }
}
