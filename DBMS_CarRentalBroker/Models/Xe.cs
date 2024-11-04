using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_CarRentalBroker.Models
{
    public class Xe
    {
        private int maXe;
        private string ten;
        private string bienSoXe;
        private bool laXeSoSan;
        private bool laXeDien;
        private int namSanXuat;
        private int soGhe;
        private string mau;
        private int phanKhoi;
        private string thuongHieu;
        private string trangThai;


        public int MaXe { get; set; }
        public string Ten { get; set; }
        public string BienSoXe { get; set; }
        public bool LaXeSoSan { get; set; }
        public bool LaXeDien { get; set; }
        public int NamSanXuat { get; set; }
        public int SoGhe { get; set; }
        public string Mau { get; set; }
        public int PhanKhoi { get; set; }
        public string ThuongHieu { get; set; }
        public string TrangThai { get; set; }
    }
}
