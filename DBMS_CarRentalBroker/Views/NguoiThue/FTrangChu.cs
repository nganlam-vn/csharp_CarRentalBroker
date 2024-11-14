using DBMS_CarRentalBroker.Dao;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views.NguoiThue
{
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachXe());
        }

        private void lblThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachHopDong());
        }

        public void OpenChildForm(Form childForm)
        {
            foreach (Control ctrl in pnlContent.Controls)
            {
                if (ctrl is Form form)
                {
                    form.Close();
                }
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill; 

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FTrangChu_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FDanhSachXe());
        }

        private void lblLichSuGD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLichSuGiaoDich());
        }

        private void lblLichSuThue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLichSuThueXe());
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
    
            FDangNhap fDangNhap = new FDangNhap();
            fDangNhap.ShowDialog(); 

            Application.Exit();
        }

        private void lblLienKetVi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FLienKetTKNganHang());
        }
    }
}
