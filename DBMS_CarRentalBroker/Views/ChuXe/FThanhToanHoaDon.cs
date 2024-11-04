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

namespace DBMS_CarRentalBroker.Views.ChuXe
{
    public partial class FThanhToanHoaDon : Form
    {
        private Xe xe;
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CarRentalBroker;Integrated Security=True;Encrypt=False;";

        public FThanhToanHoaDon(Xe xe)
        {
            InitializeComponent();
            this.xe = xe;
            ThanhToanHoaDon_Load(xe);
        }

        private void ThanhToanHoaDon_Load(Xe xe)
        {
            txtTen.Text = xe.Ten;
            txtBienSoXe.Text = xe.BienSoXe;
            chkLaXeSoSan.Checked = xe.LaXeSoSan;
            chkLaXeDien.Checked = xe.LaXeDien;
            txtNamSanXuat.Text = xe.NamSanXuat.ToString();
            txtSoGhe.Text = xe.SoGhe.ToString();
            txtMau.Text = xe.Mau;
            txtPhanKhoi.Text = xe.PhanKhoi.ToString();
            txtThuongHieu.Text = xe.ThuongHieu;
        }
    }
}
