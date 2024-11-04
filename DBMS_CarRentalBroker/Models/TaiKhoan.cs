using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_CarRentalBroker.Models
{
    internal class TaiKhoan
    {
        private string tenDangNhap;
        private string matKhau;
        private string maND;
        private string maVT;

        public TaiKhoan(string tenDangNhap, string matKhau, string maND, string maVT)
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

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaND { get => maND; set => maND = value; }
        public string MaVT { get => maVT; set => maVT = value; }
    }
}
