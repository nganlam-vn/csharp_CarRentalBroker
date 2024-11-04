using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_CarRentalBroker.Common
{
    public static class Global
    {
        public static string tenDangNhap;
        public static string matKhau;
        public static int maND;
        public static int maVT;

        public static string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public static string MatKhau { get => matKhau; set => matKhau = value; }
        public static int MaND { get => maND; set => maND = value; }
        public static int MaVT { get => maVT; set => maVT = value; }
    }
}
