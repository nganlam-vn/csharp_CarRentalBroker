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
            childForm.Dock = DockStyle.Fill;
            pnContent.Controls.Add(childForm);
            pnContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnXeTrenSan_Click(object sender, EventArgs e)
        {

        }

        private void btnDaDuocThue_Click(object sender, EventArgs e)
        {
            FXeDaChoThue fXeDaChoThue = new FXeDaChoThue();
            OpenChildForm(fXeDaChoThue);

        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {

        }

        private void btnBestSeller_Click(object sender, EventArgs e)
        {

        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKiXe_Click(object sender, EventArgs e)
        {
            FDanhSachDangKyXe fDanhSachDangKyXe = new FDanhSachDangKyXe();
            OpenChildForm(fDanhSachDangKyXe);
        }
    }
}
