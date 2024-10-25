using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CarRentalBroker.Models
{
    public static class TaiKhoan
    {
        public static string tenDangNhap { get; set; }
        public static string matKhau { get; set; }
        public static int maND { get; set; }
        public static int maVT { get; set; }

        static TaiKhoan()
        {
            tenDangNhap = "guest";
            matKhau = "123";
            maND = 0;
            maVT = 0;
        }
    }
}
