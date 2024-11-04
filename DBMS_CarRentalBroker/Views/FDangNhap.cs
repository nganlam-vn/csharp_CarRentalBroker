using CarRentalBroker.Dao;
using DBMS_CarRentalBroker.Common;
using DBMS_CarRentalBroker.Models;
using DBMS_CarRentalBroker.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CarRentalBroker.Views
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDao taiKhoanDao = new TaiKhoanDao();
                if (taiKhoanDao.dangNhap(new TaiKhoan(tbTenDangNhap.Text, tbMatKhau.Text)))
                {
                    this.Hide();
                    if(Global.maVT == 1)
                    {
                        FQuanLyNguoiDung fMain = new FQuanLyNguoiDung();
                        fMain.ShowDialog();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
