using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_CarRentalBroker.Models
{
    public class TaiKhoan
    {
        private string tenDangNhap;
        private string matKhau;
        private int maND;
        private int maVT;

        public TaiKhoan(string tenDangNhap, string matKhau, int maND, int maVT)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.maND = maND;
            this.maVT = maVT;
        }

        public TaiKhoan(string tenDangNhap, string matKhau)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }

        public TaiKhoan()
        {
        }

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int MaND { get => maND; set => maND = value; }
        public int MaVT { get => maVT; set => maVT = value; }
    }
}
