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
using CarRentalBroker.Dao;
using CarRentalBroker.Models;
using DBMS_CarRentalBroker;

namespace CarRentalBroker.Views
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            TaiKhoan.tenDangNhap = tbEmail.Text;
            TaiKhoan.matKhau = tbPassword.Text;

            TaiKhoanDao taiKhoanDao = new TaiKhoanDao();

            try
            {
                if (taiKhoanDao.kiemTraDangNhap(TaiKhoan.tenDangNhap, TaiKhoan.matKhau))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    Form1 fMain = new Form1();
                    fMain.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
