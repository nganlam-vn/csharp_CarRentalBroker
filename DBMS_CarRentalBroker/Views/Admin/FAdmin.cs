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
        public FAdmin()
        {
            InitializeComponent();
            OpenChildForm(new FDanhSachXe());
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
            FDanhSachXe fXeTrenSan = new FDanhSachXe();
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
            FTop5 fTop5 = new FTop5();
            OpenChildForm(fTop5);
        }

        private void btnKhoanThanhToan_Click(object sender, EventArgs e)
        {
            FDanhSachHopDong fDanhSachHopDong = new FDanhSachHopDong();
            OpenChildForm(fDanhSachHopDong);

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
    }
}
